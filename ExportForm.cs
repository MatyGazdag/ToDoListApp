using System;
using System.IO;
using System.Windows.Forms;
using ToDoListApp.ToDoData;

namespace ToDoListApp
{
    public partial class ExportForm : Form
    {
        Data data;

        public ExportForm(Data data)
        {
            InitializeComponent();

            CB_Export.SelectedIndex = 0;
            this.data = data;
        }

        private void BTN_Export_Click(object sender, EventArgs e)
        {
            switch(CB_Export.SelectedIndex)
            {
                case 0:
                    //SQL
                    SQL_Export();
                    break;
            }

            Close();
        }

        void SQL_Export()
        {
            using(var dialog = new SaveFileDialog())
            {
                dialog.InitialDirectory = "c:\\\\";
                dialog.Filter = "SQL (*.sql)|";
                dialog.AddExtension = true;
                dialog.DefaultExt = ".sql";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(dialog.FileName))
                    {
                        writer.WriteLine
                            ($@"
CREATE TABLE IF NOT EXISTS MainTask (
    ID int,
    Name varchar(255),
    TagID int,
    SubTaskID int
);

CREATE TABLE IF NOT EXISTS Tags (
    ID int,
    Name varchar(255)
);

CREATE TABLE IF NOT EXISTS SubTask (
    ID int,
    Name varchar(255),
    TagID int
);

"
                            );

                        var mainTask = data.mainTasks;
                        if(mainTask.Count == 0)
                        {
                            MessageBox.Show("List empty");
                            return;
                        }

                        for(int id = 0; id < mainTask.Count; id++)
                        {
                            writer.WriteLine($"INSERT INTO `maintask`(`ID`, `Name`, `TagID`, `SubTaskID`) VALUES ({id}, {mainTask[id].Name}, {id}, {id});");
                            for (int idT = 0; idT < mainTask[id].subTasks.Count; idT++)
                            {
                                var subT = mainTask[id].subTasks[idT];
                                writer.WriteLine($"INSERT INTO `subtask`(`ID`, `Name`, `TagID`) VALUES({id}, {subT.Name}, {idT});");
                            }
                            writer.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
