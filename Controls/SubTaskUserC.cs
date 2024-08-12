using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoListApp.ToDoData;

namespace ToDoListApp
{
    public partial class SubTaskUserC : UserControl
    {
        public ToDoSubTask subTask;

        public SubTaskUserC()
        {
            InitializeComponent();
        }

        public SubTaskUserC(ToDoSubTask taskSub)
        {
            InitializeComponent();
            subTask = taskSub;
            CH_Name.Text = taskSub.Name;
            CH_Name.Checked = taskSub.State;

            AddTags();
        }

        public void AddTags()
        {
            
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
                    clicked.BackColor = Color.White;
                }

                Form1.selected = clicked;
            }
        }

        private void ForwardMouseDownToBasePanel(object sender, MouseEventArgs e)
        {
            basePanel_MouseDown(this, e);
        }

        private void CH_Name_CheckedChanged(object sender, EventArgs e)
        {
            subTask.State = CH_Name.Checked;
        }
    }
}
