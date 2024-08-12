using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ToDoListApp.ToDoData;

namespace ToDoListApp
{
    public partial class TaskBaseUserC : UserControl
    {
        public ToDoMainTask mainTask;

        public List<SubTaskUserC> uiSubtasks = new List<SubTaskUserC>();

        int count = 0;

        public TaskBaseUserC(ToDoMainTask todotask)
        {
            InitializeComponent();
            this.mainTask = todotask;
            CH_Main.Text = mainTask.Name;
            CH_Main.Checked = mainTask.State;

            count = 0;

            AddTags();
            AddTasks();
        }


        bool toggle = true;

        private void BTN_ToggleSubList_Click(object sender, EventArgs e)
        {
            toggle = !toggle;

            SubTasks.Visible = toggle;
            SubTasks.Enabled = toggle;
        }

        private void BTN_AddSubTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(AddTaskForm.CreateType.Sub);
            
            addTaskForm.StartPosition = FormStartPosition.CenterParent;
            addTaskForm.ShowDialog();

            var task = addTaskForm.GetTask() as ToDoSubTask;
            if (task == null)
                return;

            AddTask(task);
        }
        private void AddTags()
        {
            foreach(var tag in mainTask.tags)
            {
                var uiTag = new TagUserC(tag);
                uiTag.Dock = DockStyle.Left;
                TagList.Controls.Add(uiTag);
            }
        }

        public void AddTasks()
        {
            foreach(var task in mainTask.subTasks)
            {
                CreateControl(task);
            }
        }

        public void AddTask(ToDoSubTask task)
        {
            CreateControl(task);
        }

        private void CreateControl(ToDoSubTask task)
        {
            var subTask = new SubTaskUserC(task);
            subTask.Dock = DockStyle.Top;
            uiSubtasks.Add(subTask);
            subTask.BackColor = uiSubtasks.Count % 2 == 0 ? Form1.system[0] : Form1.system[1];
            SubTasks.Controls.Add(subTask);
        }

        private void basePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var clicked = this as Control;

            if (clicked != null)
            {
                if (Form1.selected != clicked)
                {
                    if (Form1.selected != clicked)
                    {
                        basePanel.BackColor = Color.White;
                    }
                }

                Form1.selected = clicked;
            }
        }

        private void ForwardMouseDownToBasePanel(object sender, MouseEventArgs e)
        {
            basePanel_MouseDown(basePanel, e);
        }

        private void CH_Main_CheckedChanged(object sender, EventArgs e)
        {
            mainTask.State = CH_Main.Checked;
        }
    }
}
