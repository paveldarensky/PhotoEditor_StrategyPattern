using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form_Main : Form
    {
        private Dictionary<TabPage, (Bitmap original, Bitmap edited)> tabImages = new Dictionary<TabPage, (Bitmap original, Bitmap edited)>();
        private Dictionary<TabPage, Stack<Bitmap>> undoStacks = new Dictionary<TabPage, Stack<Bitmap>>();

        private IBrushStrategy currentBrush = null;
        private bool isDrawing = false;
        private Point lastPoint;

        public Form_Main()
        {
            this.Icon = Properties.Resources.PhotoEditor;
            this.FormClosing += new FormClosingEventHandler(Form_Main_FormClosing);
            InitializeComponent();

            SettingsManager.Instance.ApplySettingsToForm(this);

            button_BlackWhiteFilter.Image = new Bitmap(Properties.Resources.blackwhite_filter, new Size(24, 24));
            button_InvertFilter.Image = new Bitmap(Properties.Resources.invert_filter, new Size(24, 24));
            button_BlurFilter.Image = new Bitmap(Properties.Resources.blur_filter, new Size(24, 24));
            button_SharpenFilter.Image = new Bitmap(Properties.Resources.sharpen_filter, new Size(24, 24));

            button_SimpleBrush.Image = new Bitmap(Properties.Resources.simple_brush, new Size(24, 24));
            button_PencilBrush.Image = new Bitmap(Properties.Resources.pencil_brush, new Size(24, 24));
            button_BlurBrush.Image = new Bitmap(Properties.Resources.blur_brush, new Size(24, 24));
            button_EraserBrush.Image = new Bitmap(Properties.Resources.eraser_brush, new Size(24, 24));

            OpenToolStripMenuItem.Click += (s, e) => OpenImage();
            SaveToolStripMenuItem.Click += (s, e) => SaveImage();
            SaveAsToolStripMenuItem.Click += (s, e) => SaveImageAs();
            CloseCurrentTabToolStripMenuItem.Click += (s, e) => CloseCurrentTab();
            CreateToolStripMenuItem.Click += (s, e) => CreateNewCanvas();

            button_BlackWhiteFilter.Click += (s, e) =>
            {
                SavePreviousState();
                ApplyFilter(new GrayscaleFilter());
                PushUndoStateIfChanged();
            };

            button_InvertFilter.Click += (s, e) =>
            {
                SavePreviousState();
                ApplyFilter(new InvertFilter());
                PushUndoStateIfChanged();
            };

            button_BlurFilter.Click += (s, e) =>
            {
                SavePreviousState();
                ApplyFilter(new BlurFilter());
                PushUndoStateIfChanged();
            };

            button_SharpenFilter.Click += (s, e) =>
            {
                SavePreviousState();
                ApplyFilter(new SharpenFilter());
                PushUndoStateIfChanged();
            };


        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseAllTabsWithConfirmation())
            {
                e.Cancel = true;
            }
        }

        private void CreateNewCanvas()
        {
            using (var form = new Form_NewCanvasSize())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int width = form.CanvasWidth;
                    int height = form.CanvasHeight;

                    Bitmap original = new Bitmap(width, height);
                    using (Graphics g = Graphics.FromImage(original))
                    {
                        g.Clear(Color.White);
                    }

                    Bitmap edited = new Bitmap(original);
                    var tabPage = AddNewImageTab(edited, "Новый проект");

                    tabImages[tabPage] = (original, edited);
                    panel_Tools.Enabled = true;
                }
            }
        }


        private TabPage AddNewImageTab(Bitmap image, string title)
        {
            var tabPage = new TabPage(title);

            var pictureBox = new PictureBox
            {
                Image = image,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Cross
            };

            pictureBox.MouseDown += pictureBox_EditedPhoto_MouseDown;
            pictureBox.MouseMove += pictureBox_EditedPhoto_MouseMove;
            pictureBox.MouseUp += pictureBox_EditedPhoto_MouseUp;

            tabPage.Controls.Add(pictureBox);
            tabControl_Projects.TabPages.Add(tabPage);
            tabControl_Projects.SelectedTab = tabPage;

            return tabPage;
        }

        private PictureBox GetCurrentPictureBox()
        {
            if (tabControl_Projects.SelectedTab?.Controls.Count > 0)
            {
                return tabControl_Projects.SelectedTab.Controls[0] as PictureBox;
            }
            return null;
        }

        private void CloseCurrentTab()
        {
            if (tabControl_Projects.TabCount == 0)
                return;

            var currentTab = tabControl_Projects.SelectedTab;
            if (currentTab == null)
                return;

            string message = string.Format(
                SettingsManager.Instance.Translate("msgSaveBeforeClose"),
                currentTab.Text);

            string caption = SettingsManager.Instance.Translate("msgCloseTab");

            var result = MessageBox.Show(
                message,
                caption,
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
                return;

            if (result == DialogResult.Yes)
            {
                bool saved = SaveImage();
                if (!saved)
                    return; // не закрываем, если сохранение не удалось
            }

            tabImages.Remove(currentTab); // удаляем из словаря
            tabControl_Projects.TabPages.Remove(currentTab); // удаляем вкладку
        }

        private bool CloseAllTabsWithConfirmation()
        {
            foreach (TabPage tab in tabControl_Projects.TabPages.Cast<TabPage>().ToList())
            {
                tabControl_Projects.SelectedTab = tab; // чтобы SaveImage работал с текущей

                string message = string.Format(
                   SettingsManager.Instance.Translate("msgSaveBeforeExit"),
                   tab.Text);

                string caption = SettingsManager.Instance.Translate("msgExitApp");

                var result = MessageBox.Show(
                    message,
                    caption,
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                    return false;

                if (result == DialogResult.Yes)
                {
                    if (!SaveImage())
                        return false;
                }

                tabImages.Remove(tab);
                tabControl_Projects.TabPages.Remove(tab);
            }

            return true;
        }


        private Bitmap previousState;

        private void SavePreviousState()
        {
            var tab = tabControl_Projects.SelectedTab;
            if (tab == null || !tabImages.TryGetValue(tab, out var images))
                return;

            previousState = (Bitmap)images.edited.Clone();
        }

        private void PushUndoStateIfChanged()
        {
            var tab = tabControl_Projects.SelectedTab;
            if (tab == null || !tabImages.TryGetValue(tab, out var images))
                return;

            if (previousState == null) return;

            if (!BitmapsAreEqual(previousState, images.edited))
            {
                if (!undoStacks.ContainsKey(tab))
                    undoStacks[tab] = new Stack<Bitmap>();

                undoStacks[tab].Push(previousState);
            }

            previousState = null;
        }

        private bool BitmapsAreEqual(Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1.Width != bmp2.Width || bmp1.Height != bmp2.Height)
                return false;

            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }


        private void Undo()
        {
            var tab = tabControl_Projects.SelectedTab;
            if (tab != null && undoStacks.TryGetValue(tab, out var stack) && stack.Count > 0)
            {
                var prevImage = stack.Pop();
                tabImages[tab] = (tabImages[tab].original, prevImage);
                var pictureBox = GetCurrentPictureBox();
                if (pictureBox != null)
                    pictureBox.Image = tabImages[tab].edited;
            }
            else
            {
                string message = SettingsManager.Instance.Translate("msgNothingToUndo");
                string caption = SettingsManager.Instance.Translate("msgUndo");

                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    panel_Tools.Enabled = true;

                    var original = new Bitmap(ofd.FileName);
                    var edited = new Bitmap(original);

                    var tabPage = AddNewImageTab(edited, Path.GetFileName(ofd.FileName));

                    tabImages[tabPage] = (original, edited);
                }
            }
        }

        private bool SaveImage()
        {
            var tab = tabControl_Projects.SelectedTab;
            if (tab != null && tabImages.TryGetValue(tab, out var images))
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            images.edited.Save(sfd.FileName);
                            return true;
                        }
                        catch (Exception ex)
                        {
                            string errorMsg = SettingsManager.Instance.Translate("msgSaveError");
                            string errorCaption = SettingsManager.Instance.Translate("msgError");

                            MessageBox.Show($"{errorMsg} {ex.Message}", errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            return false;
        }


        private void SaveImageAs()
        {
            SaveImage();
        }

        private void ApplyFilter(IFilterStrategy filter)
        {
            var tab = tabControl_Projects.SelectedTab;
            if (tab != null && tabImages.TryGetValue(tab, out var images))
            {
                images.edited = filter.Apply(images.edited);
                tabImages[tab] = (images.original, images.edited); // обновим хранилище
                GetCurrentPictureBox().Image = images.edited;
            }
        }

        private void pictureBox_EditedPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && currentBrush != null)
            {
                var tab = tabControl_Projects.SelectedTab;
                if (tab == null || !tabImages.TryGetValue(tab, out var images))
                    return;

                var point = GetImageCoordinates(e.Location);

                // Подготовка кисти (нужно для ластика, безопасно для остальных)
                currentBrush.Prepare(images.original, images.edited); // <--- ВОТ ТУТ

                // Сохраняем состояние до изменения
                SavePreviousState();

                // Рисуем одиночную точку (т.е. от point до point)
                using (Graphics g = Graphics.FromImage(images.edited))
                {
                    currentBrush.Draw(g, point, point);
                }

                GetCurrentPictureBox().Invalidate();

                isDrawing = true;
                lastPoint = point;
            }
        }

        private void pictureBox_EditedPhoto_MouseMove(object sender, MouseEventArgs e)
        {
            var tab = tabControl_Projects.SelectedTab;
            if (isDrawing && currentBrush != null && e.Button == MouseButtons.Left && tab != null)
            {
                var correctedPoint = GetImageCoordinates(e.Location);
                if (correctedPoint.X >= 0 && correctedPoint.Y >= 0)
                {
                    var images = tabImages[tab];
                    using (Graphics g = Graphics.FromImage(images.edited))
                    {
                        currentBrush.Draw(g, lastPoint, correctedPoint);
                    }
                    lastPoint = correctedPoint;
                    GetCurrentPictureBox().Invalidate();
                }
            }
        }

        private void pictureBox_EditedPhoto_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Открываем контекстное меню, если был клик правой кнопкой
                contextMenuStrip_Brush.Show(GetCurrentPictureBox(), e.Location);
            }
            else
            {
                isDrawing = false;

                PushUndoStateIfChanged();
            }
        }

        private Point GetImageCoordinates(Point mouseLocation)
        {
            var pictureBox = GetCurrentPictureBox();
            if (pictureBox == null || tabControl_Projects.SelectedTab == null)
                return mouseLocation;

            if (!tabImages.TryGetValue(tabControl_Projects.SelectedTab, out var images) || images.edited == null)
                return mouseLocation;

            Bitmap editedImage = images.edited;

            float imgWidth = editedImage.Width;
            float imgHeight = editedImage.Height;
            float pbWidth = pictureBox.ClientSize.Width;
            float pbHeight = pictureBox.ClientSize.Height;

            float ratioX = imgWidth / pbWidth;
            float ratioY = imgHeight / pbHeight;

            if (pictureBox.SizeMode == PictureBoxSizeMode.Zoom)
            {
                float ratio = Math.Min(pbWidth / imgWidth, pbHeight / imgHeight);
                int displayWidth = (int)(imgWidth * ratio);
                int displayHeight = (int)(imgHeight * ratio);

                int offsetX = (int)((pbWidth - displayWidth) / 2);
                int offsetY = (int)((pbHeight - displayHeight) / 2);

                int imgX = (int)((mouseLocation.X - offsetX) * (imgWidth / (float)displayWidth));
                int imgY = (int)((mouseLocation.Y - offsetY) * (imgHeight / (float)displayHeight));

                return new Point(imgX, imgY);
            }

            return new Point((int)(mouseLocation.X * ratioX), (int)(mouseLocation.Y * ratioY));
        }


        private void button_SimpleBrush_Click(object sender, EventArgs e)
        {
            currentBrush = new SimpleBrush(Color.Black, 5); // Выбираем кисть
        }

        private void button_PencilBrush_Click(object sender, EventArgs e)
        {
            currentBrush = new PencilBrush(Color.Black, 1); // Выбираем карандаш
        }

        private void button_BlurBrush_Click(object sender, EventArgs e)
        {
            currentBrush = new BlurBrush(Color.Black, 5); // Выбираем размытую кисть
        }

        private void button_EraserBrush_Click(object sender, EventArgs e)
        {
            var tabPage = tabControl_Projects.SelectedTab;
            if (tabPage == null || !tabImages.TryGetValue(tabPage, out var images))
                return;

            int eraserSize = 20;
            var eraser = new EraserBrush(eraserSize);
            eraser.Prepare(images.original, images.edited);
            currentBrush = eraser;
        }

        private void ChangeBrushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Устанавливаем новый цвет для кисти
                    if (currentBrush is SimpleBrush simpleBrush)
                    {
                        currentBrush = new SimpleBrush(colorDialog.Color, simpleBrush.pen.Width);
                    }
                    else if (currentBrush is PencilBrush pencilBrush)
                    {
                        currentBrush = new PencilBrush(colorDialog.Color);
                    }
                    else if (currentBrush is BlurBrush blurBrush)
                    {
                        currentBrush = new BlurBrush(colorDialog.Color);
                    }
                    // Если нужно добавить поддержку других кистей, добавьте здесь код
                }
            }
        }

        private void ChangeBrushSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_ChangeBrushSize sizeDialog = new Form_ChangeBrushSize())
            {
                if (sizeDialog.ShowDialog() == DialogResult.OK)
                {
                    double newSize = sizeDialog.SelectedSize;

                    // Устанавливаем новый размер для кисти
                    if (currentBrush is SimpleBrush simpleBrush)
                    {
                        currentBrush = new SimpleBrush(simpleBrush.pen.Color, newSize);
                    }
                    else if (currentBrush is PencilBrush pencilBrush)
                    {
                        currentBrush = new PencilBrush(pencilBrush.pen.Color, newSize);
                    }
                    else if (currentBrush is BlurBrush blurBrush)
                    {
                        currentBrush = new BlurBrush(blurBrush.color, newSize);
                    }
                }
            }
        }

        private void ActionCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CloseAllTabsWithConfirmation())
                Application.Exit();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Settings().ShowDialog();
        }
    }

    // ** Strategy **
    public interface IFilterStrategy
    {
        Bitmap Apply(Bitmap image);
    }

    public class GrayscaleFilter : IFilterStrategy
    {
        public Bitmap Apply(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int gray = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                    newImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return newImage;
        }
    }

    public class InvertFilter : IFilterStrategy
    {
        public Bitmap Apply(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    newImage.SetPixel(x, y, inverted);
                }
            }
            return newImage;
        }
    }

    public class BlurFilter : IFilterStrategy
    {
        private readonly float[,] kernel =
        {
        { 1 / 9f, 1 / 9f, 1 / 9f },
        { 1 / 9f, 1 / 9f, 1 / 9f },
        { 1 / 9f, 1 / 9f, 1 / 9f }
    };

        public Bitmap Apply(Bitmap image)
        {
            return ApplyConvolutionFilter(image, kernel);
        }

        private Bitmap ApplyConvolutionFilter(Bitmap image, float[,] kernel)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            int w = image.Width, h = image.Height;

            for (int y = 1; y < h - 1; y++)
            {
                for (int x = 1; x < w - 1; x++)
                {
                    float r = 0, g = 0, b = 0;
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = image.GetPixel(x + kx, y + ky);
                            float weight = kernel[ky + 1, kx + 1];
                            r += pixel.R * weight;
                            g += pixel.G * weight;
                            b += pixel.B * weight;
                        }
                    }
                    newImage.SetPixel(x, y, Color.FromArgb(Clamp(r), Clamp(g), Clamp(b)));
                }
            }
            return newImage;
        }

        private int Clamp(float value)
        {
            return (int)Math.Max(0, Math.Min(255, value));
        }
    }

    public class SharpenFilter : IFilterStrategy
    {
        private readonly float[,] kernel =
        {
        { -1, -1, -1 },
        { -1,  9, -1 },
        { -1, -1, -1 }
    };

        public Bitmap Apply(Bitmap image)
        {
            return ApplyConvolutionFilter(image, kernel);
        }

        private Bitmap ApplyConvolutionFilter(Bitmap image, float[,] kernel)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            int w = image.Width, h = image.Height;

            for (int y = 1; y < h - 1; y++)
            {
                for (int x = 1; x < w - 1; x++)
                {
                    float r = 0, g = 0, b = 0;
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = image.GetPixel(x + kx, y + ky);
                            float weight = kernel[ky + 1, kx + 1];
                            r += pixel.R * weight;
                            g += pixel.G * weight;
                            b += pixel.B * weight;
                        }
                    }
                    newImage.SetPixel(x, y, Color.FromArgb(Clamp(r), Clamp(g), Clamp(b)));
                }
            }
            return newImage;
        }

        private int Clamp(float value)
        {
            return (int)Math.Max(0, Math.Min(255, value));
        }
    }

    // ** Strategy for Brush **
    public interface IBrushStrategy
    {
        void Prepare(Bitmap original, Bitmap edited); // по умолчанию ничего не делает
        void Draw(Graphics g, Point start, Point end);
    }

    public class SimpleBrush : IBrushStrategy
    {
        public Pen pen;

        public SimpleBrush(Color color, double size)
        {
            pen = new Pen(color, (float)size) { StartCap = System.Drawing.Drawing2D.LineCap.Round, EndCap = System.Drawing.Drawing2D.LineCap.Round };
        }

        public void Prepare(Bitmap original, Bitmap edited) { /* ничего */ }

        public void Draw(Graphics g, Point start, Point end)
        {
            if (start == end)
            {
                float radius = pen.Width / 2;
                g.FillEllipse(new SolidBrush(pen.Color), start.X - radius, start.Y - radius, pen.Width, pen.Width);
            }
            else
            {
                g.DrawLine(pen, start, end);
            }
        }
    }


    public class PencilBrush : IBrushStrategy
    {
        public Pen pen;

        public PencilBrush(Color color, double size = 1)  // Добавляем параметр по умолчанию для размера
        {
            pen = new Pen(color, (float)size);
        }

        public void Prepare(Bitmap original, Bitmap edited) { /* ничего */ }

        public void Draw(Graphics g, Point start, Point end)
        {
            if (start == end)
            {
                float radius = pen.Width / 2;
                g.FillEllipse(new SolidBrush(pen.Color), start.X - radius, start.Y - radius, pen.Width, pen.Width);
            }
            else
            {
                g.DrawLine(pen, start, end);
            }
        }
    }


    public class BlurBrush : IBrushStrategy
    {
        public Color color;
        private readonly double size;

        public BlurBrush(Color color, double size = 5)  // Добавляем параметр по умолчанию для размера
        {
            this.color = color;
            this.size = size;
        }

        public void Prepare(Bitmap original, Bitmap edited) { /* ничего */ }

        public void Draw(Graphics g, Point start, Point end)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(50, color)))  // Используем заданный цвет с прозрачностью
            {
                g.FillEllipse(brush, start.X - (float)size / 2, start.Y - (float)size / 2, (float)size, (float)size);
            }
        }
    }


    public class EraserBrush : IBrushStrategy
    {
        private Bitmap originalImage;  // Исходное изображение
        private Bitmap editedImage;    // Редактируемое изображение
        private readonly int size;

        public EraserBrush(int size)
        {
            this.size = size;
        }

        public void Prepare(Bitmap original, Bitmap edited)
        {
            originalImage = original;
            editedImage = edited;
        }

        public void Draw(Graphics g, Point start, Point end)
        {
            // Восстанавливаем исходные пиксели на редактируемом изображении
            using (Graphics g2 = Graphics.FromImage(editedImage))
            {
                // Проходим по области ластика и восстанавливаем пиксели из оригинала
                for (int y = -size / 2; y < size / 2; y++)
                {
                    for (int x = -size / 2; x < size / 2; x++)
                    {
                        int drawX = start.X + x;
                        int drawY = start.Y + y;

                        if (drawX >= 0 && drawX < originalImage.Width && drawY >= 0 && drawY < originalImage.Height)
                        {
                            // Восстанавливаем пиксель из оригинального изображения
                            Color originalColor = originalImage.GetPixel(drawX, drawY);
                            editedImage.SetPixel(drawX, drawY, originalColor);
                        }
                    }
                }
            }

            // Перерисовываем редактируемое изображение
            g.DrawImage(editedImage, 0, 0);
        }
    }

}