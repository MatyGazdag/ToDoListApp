using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ToDoListApp.ToDoData;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

#if DEBUG
            var debugItem = new ToolStripMenuItem();
            debugItem.Text = "Debug";
            debugItem.Click += debugButton_Click;
            SoftwareMenu.Items.Add(debugItem);
#endif

            TaskList.ControlAdded += UpdateMenu;
            TaskList.ControlRemoved += UpdateMenu;

            UpdateMenu(this, null);
        }

        Random r = new Random();

        public static Color[] system = new Color[] {
                Color.FromArgb(66, 135, 245),
                Color.FromArgb(42, 111, 222),
            };

        public static object selected;

        #region FileMenu

        #region DebugMenu
        private void debugButton_Click(object sender, EventArgs e)
        {
            AddTestTask();
        }

        #region TestData
        public void AddTestTask()
        {
            for(int i = 0; i < r.Next(1, 5); i++)
            {
                var text = Guid.NewGuid().ToString();
                var tagList = new List<Tag>()
                {
                    new Tag(Color.Red,"15. 10. 2024")
                };
                var list = Enumerable.Range(1, r.Next(2, 6)).Select(o => new ToDoSubTask(text, tagList)).ToList();
                var task = new ToDoMainTask(text, tagList, list);

                TaskBaseUserC taskBaseUserC = new TaskBaseUserC(task);

                TaskList.Controls.Add(taskBaseUserC);
                TaskList.VerticalScroll.Value = TaskList.VerticalScroll.Maximum;
            }
        }
        #endregion
        #endregion

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSystem.SaveAs(PrepareData());
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSystem.Save(PrepareData());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = SaveSystem.Load(SaveSystem.Open());

            if (data == null) return;

            ClearList();

            foreach(var mainTask in data.mainTasks)
            {
                AddTask(mainTask);
            }
        }

        private Data PrepareData()
        {
            Data data = new Data();
            for (int i = 0; i < TaskList.Controls.Count; i++)
            {
                var taskBase = TaskList.Controls[i] as TaskBaseUserC;

                if (taskBase != null)
                {
                    data.mainTasks.Add(taskBase.mainTask);
                }
            }
            return data;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm export = new ExportForm(PrepareData());
            export.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region SelectionAndAllMenu
        #region Task
        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Must select task by left mouse click");
                return;
            }
            var item = sender as ToolStripMenuItem;

            if (item == null)
                return;

            var tags = item.Tag.ToString().Split(' ');

            if (tags[0] == "Tag")
            {
                if (tags[1] == "Add")
                {

                }
                else if (tags[1] == "Remove")
                {

                }
            }
            else if (tags[0] == "Task")
            {
                if (tags[1] == "Remove")
                {
                    RemoveSelectedTask();
                }
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
                return;

            var tags = item.Tag.ToString().Split(' ');

            if (tags[0] == "Tag")
            {
                if (tags[1] == "Add")
                {

                }
                else if (tags[1] == "Remove")
                {

                }
            }
            else if (tags[0] == "Task")
            {
                if (tags[1] == "Remove")
                {
                    RemoveAllTasks();
                }
            }
        }
        #endregion

        #region Tag
        private void selectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

        #region RemoveMenuLogic
        void RemoveSelectedTask()
        {
            if(selected.GetType() == typeof(TaskBaseUserC))
            {
                var taskBase = (TaskBaseUserC)selected;

                taskBase.Dispose();
                TaskList.Controls.Remove(taskBase);
                selected = null;
            }else if(selected.GetType() == typeof(SubTaskUserC))
            {
                var taskSub = (SubTaskUserC)selected;

                taskSub.Dispose();
                //taskSub.Parent.Controls.Remove(taskSub);
                selected = null;
            }
        }

        void RemoveAllTasks()
        {
            var dec = MessageBox.Show("Do you realy want to remove all tasks?","Remove All", MessageBoxButtons.YesNo);

            if (dec == DialogResult.Yes)
            {
                ClearList();
            }
        }
        #endregion

        #region AddMenu
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(AddTaskForm.CreateType.Main);
            addTaskForm.Parent = Parent;
            addTaskForm.StartPosition = FormStartPosition.CenterParent;
            addTaskForm.ShowDialog();

            var task = addTaskForm.GetTask() as ToDoMainTask;
            if (task == null)
                return;

            AddTask(task);
        }
        #endregion

        #region AddMenuLogic
        public void AddTask(ToDoMainTask task)
        {
            var taskBaseUserC = new TaskBaseUserC(task);
            taskBaseUserC.Parent = TaskList.Parent;

            TaskList.Controls.Add(taskBaseUserC);
            TaskList.VerticalScroll.Value = TaskList.VerticalScroll.Maximum;
        }
        #endregion

        void UpdateMenu(object sender, ControlEventArgs e)
        {
            saveAsToolStripMenuItem.Enabled = !String.IsNullOrEmpty(SaveSystem.FILE_PATH);

            saveToolStripMenuItem.Enabled = TaskList.Controls.Count != 0;

            saveToolStripMenuItem.Text = SaveSystem.FILE_NAME?.Length > 6 ? 
                $"Save {SaveSystem.FILE_NAME?.Substring(0, 6)}..." : 
                $"Save {SaveSystem.FILE_NAME}";
        }

        private void ClearList()
        {
            foreach (Control c in TaskList.Controls)
            {
                c.Dispose();
            }
            TaskList.Controls.Clear();
        }
    }
}
