using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using ToDoListApp.ToDoData;

namespace ToDoListApp
{
    public static class SaveSystem
    {
        public static string FILE_NAME;

        public static string FILE_PATH
        {
            get { return _filePath; }

            set
            {
                _filePath = value;
                FILE_NAME = Path.GetFileName(_filePath) + Path.GetExtension(_filePath);
            }
        }

        private static string _filePath;

        static OpenFileDialog openFile = new OpenFileDialog()
        {
            InitialDirectory = "c:\\\\",
            Filter = "To Do File (*.todo)|",
            Multiselect = false,
            AddExtension = true,
            DefaultExt = ".todo"
        };

        static SaveFileDialog saveFile = new SaveFileDialog()
        {
            InitialDirectory = "c:\\\\",
            Filter = "To Do File (*.todo)|",
            AddExtension = true,
            DefaultExt = ".todo"
        };

        public static void Save(Data data)
        {
            if (IsDataEmpty(data)) return;

            if(FILE_PATH != null)
            {
                XmlSerializer xml = new XmlSerializer(typeof(Data));
                using (var writer = new StreamWriter(FILE_PATH))
                {
                    xml.Serialize(writer, data);
                }

                return;
            }

            using (var dialog = saveFile)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (String.IsNullOrEmpty(FILE_PATH))
                    {
                        //First Save
                        File.Create(dialog.FileName).Close();
                    }

                    FILE_PATH = dialog.FileName;

                    XmlSerializer xml = new XmlSerializer(typeof(Data));
                    using(var writer = new StreamWriter(FILE_PATH))
                    {
                        xml.Serialize(writer, data);
                    }
                }
            }
        }

        public static void SaveAs(Data data)
        {
            if (IsDataEmpty(data)) return;

            using (var dialog = saveFile)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!dialog.CheckFileExists)
                    {
                        File.Create(dialog.FileName).Close();
                    }

                    FILE_PATH = dialog.FileName;
                    
                    XmlSerializer xml = new XmlSerializer(typeof(Data));
                    using (var writer = new StreamWriter(FILE_PATH))
                    {
                        xml.Serialize(writer, data);
                    }
                }
            }
        }

        public static string Open()
        {
            using (var dialog = openFile)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!dialog.CheckFileExists)
                    {
                        MessageBox.Show("File not exists");
                        return "";
                    }

                    FILE_PATH = dialog.FileName;
                    return FILE_PATH;
                }
            }
            return "";
        }

        public static Data Load(string path)
        {
            if(String.IsNullOrEmpty(path))
                return null;

            XmlSerializer xml = new XmlSerializer(typeof(Data));
            Data data = new Data();

            using (var reader = new StreamReader(path))
            { 
                data = (Data)xml.Deserialize(reader);
            }

            return data;
        }

        private static bool IsDataEmpty(Data data)
        {
            bool condition = data.mainTasks.Count == 0;
            if(condition)
            {
                MessageBox.Show("To Do List is Empty");
            }
            return condition;
        }
    }
}
