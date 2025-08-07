using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public enum Theme { Light, Dark }
    public enum Language { Russian, English }

    public class SettingsManager
    {
        private static SettingsManager instance;
        public static SettingsManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsManager();
                }
                return instance;
            }
        }


        public Theme CurrentTheme { get; private set; } = Theme.Light;
        public Language CurrentLanguage { get; private set; } = Language.English;

        private SettingsManager() { }

        public void ApplySettingsToForm(Form form)
        {
            ApplyTheme(form);
            ApplyLanguage(form);
        }

        public void SetTheme(Theme theme)
        {
            CurrentTheme = theme;
        }

        public void SetLanguage(Language lang)
        {
            CurrentLanguage = lang;
        }

        private void ApplyTheme(Control control)
        {
            Color backColor, foreColor;

            if (CurrentTheme == Theme.Light)
            {
                backColor = Color.White;
                foreColor = Color.Black;
            }
            else
            {
                backColor = Color.FromArgb(30, 30, 30);
                foreColor = Color.White;
            }

            control.BackColor = backColor;
            control.ForeColor = foreColor;

            foreach (Control child in control.Controls)
            {
                ApplyTheme(child);
            }
        }

        private void ApplyLanguage(Control control)
        {
            // Обработка обычных контролов
            if (!string.IsNullOrEmpty(control.Tag as string))
            {
                control.Text = Translate(control.Tag.ToString());
            }

            // Рекурсивно применяем к дочерним контролам
            foreach (Control child in control.Controls)
            {
                ApplyLanguage(child);
            }

            // Обработка MenuStrip и его пунктов
            if (control is MenuStrip menu)
            {
                foreach (ToolStripMenuItem item in menu.Items)
                {
                    ApplyLanguageToMenuItem(item);
                }
            }
        }

        // Метод для рекурсивной обработки ToolStripMenuItem
        private void ApplyLanguageToMenuItem(ToolStripMenuItem item)
        {
            if (!string.IsNullOrEmpty(item.Tag as string))
            {
                item.Text = Translate(item.Tag.ToString());
            }

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    ApplyLanguageToMenuItem(subMenuItem);
                }
            }
        }


        public string Translate(string key)
        {
            var dict = CurrentLanguage == Language.Russian ? translationsRus : translationsEng;
            return dict.TryGetValue(key, out var value) ? value : key;
        }

        // Русский
        private readonly Dictionary<string, string> translationsRus = new Dictionary<string, string>()
{
    { "menuFile", "Файл" },
    { "submenuNew", "Создать" },
    { "submenuOpen", "Открыть" },
    { "submenuSave", "Сохранить" },
    { "submenuSaveAs", "Сохранить как" },
    { "submenuExit", "Выход" },
    { "submenuCloseTab", "Закрыть текущую вкладку" },

    { "menuEdit", "Правка" },
    { "submenuUndo", "Отмена действия" },

    { "menuService", "Сервис" },
    { "submenuSettings", "Настройки" },

    { "menuHelp", "Справка" },
    { "submenuAbout", "О программе..." },

    { "formBrushSize", "Размер кисти" },
    { "btnOK", "ОК" },

    { "formCreateEmptyCanvas", "Создать пустой лист" },
    { "lblWidth", "Ширина" },
    { "lblHeight", "Высота" },
    { "btnCreate", "Создать" },
    { "btnCancel", "Отмена" },

    { "formAbout", "О программе" },
    { "formSettings", "Настройки" },
    { "lblTheme", "Тема" },
    { "lblLanguage", "Язык" },
    { "radioLight", "Светлая" },
    { "radioDark", "Тёмная" },
    { "btnApply", "Применить" },

    { "contextBrushColor", "Цвет кисти" },
    { "contextBrushSize", "Размер кисти" },

    { "lblVersion", "Фоторедактор — версия 1.0" },
    { "lblDeveloper", "Разработчик: Даренский П.А." },
    { "lblDescription", "Минималистичный фоторедактор для базовой обработки изображений.\nВключает инструменты рисования, фильтрации, отмены действий и сохранения.\nРеализована многовкладочная работа с несколькими изображениями одновременно." },
    { "lblCopyright", "© 2025. Все права защищены." },
    { "linkSource", "Источник: github.com/paveldarensky/" },

    { "msgSaveBeforeClose", "Сохранить изменения в проекте \"{0}\" перед закрытием?" },
    { "msgCloseTab", "Закрытие вкладки" },

    { "msgSaveBeforeExit", "Сохранить изменения в проекте \"{0}\" перед выходом?" },
    { "msgExitApp", "Выход из программы" },

    { "msgNothingToUndo", "Нет действий для отмены." },
    { "msgUndo", "Отмена" },

    { "msgSaveError", "Ошибка при сохранении изображения:" },
    { "msgError", "Ошибка" },

    { "msgInvalidBrushRange", "Ошибка: введите корректное число в диапазоне от 0.5 до 25." },
    { "msgInvalidBrushNumber", "Ошибка: введите корректное число." },
    { "msgInputError", "Ошибка ввода" }
};

        // English
        private readonly Dictionary<string, string> translationsEng = new Dictionary<string, string>()
{
    { "menuFile", "File" },
    { "submenuNew", "New" },
    { "submenuOpen", "Open" },
    { "submenuSave", "Save" },
    { "submenuSaveAs", "Save As" },
    { "submenuExit", "Exit" },
    { "submenuCloseTab", "Close Current Tab" },

    { "menuEdit", "Edit" },
    { "submenuUndo", "Undo" },

    { "menuService", "Service" },
    { "submenuSettings", "Settings" },

    { "menuHelp", "Help" },
    { "submenuAbout", "About..." },

    { "formBrushSize", "Brush Size" },
    { "btnOK", "OK" },

    { "formCreateEmptyCanvas", "Create Empty Canvas" },
    { "lblWidth", "Width" },
    { "lblHeight", "Height" },
    { "btnCreate", "Create" },
    { "btnCancel", "Cancel" },

    { "formAbout", "About" },
    { "formSettings", "Settings" },
    { "lblTheme", "Theme" },
    { "lblLanguage", "Language" },
    { "radioLight", "Light" },
    { "radioDark", "Dark" },
    { "btnApply", "Apply" },

    { "contextBrushColor", "Brush Color" },
    { "contextBrushSize", "Brush Size" },

    { "lblVersion", "Фоторедактор — version 1.0" },
    { "lblDeveloper", "Developer: P.A. Darensky" },
    { "lblDescription", "A minimalist photo editor for basic image processing.\nIncludes drawing tools, filters, undo functionality, and saving.\nSupports multi-tab editing of multiple images simultaneously." },
    { "lblCopyright", "© 2025. All rights reserved." },
    { "linkSource", "Source: github.com/paveldarensky/" },

    { "msgSaveBeforeClose", "Save changes to project \"{0}\" before closing?" },
    { "msgCloseTab", "Close Tab" },

    { "msgSaveBeforeExit", "Save changes to project \"{0}\" before exiting?" },
    { "msgExitApp", "Exit Application" },

    { "msgNothingToUndo", "Nothing to undo." },
    { "msgUndo", "Undo" },

    { "msgSaveError", "Error saving image:" },
    { "msgError", "Error" },

    { "msgInvalidBrushRange", "Error: enter a valid number between 0.5 and 25." },
    { "msgInvalidBrushNumber", "Error: enter a valid number." },
    { "msgInputError", "Input Error" }
};

    }

}
