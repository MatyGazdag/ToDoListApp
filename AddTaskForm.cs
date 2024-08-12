using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApp.Controls;
using ToDoListApp.ToDoData;

namespace ToDoListApp
{
    public partial class AddTaskForm : Form
    {
        public enum CreateType
        {
            Main,
            Sub
        }

        ToDoBase task;
        CreateType createType;

        public AddTaskForm(CreateType type)
        {
            InitializeComponent();
            createType = type;
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            bool succesed = false;

            if (String.IsNullOrEmpty(TX_Name.Text))
            {
                LBL_Info.Text = "Can't leave empty name";
                return;
            }

            var tags = AssignTags();

            switch (createType)
            {
                case CreateType.Main:
                    task = new ToDoMainTask(TX_Name.Text, tags);
                    goto default;
                case CreateType.Sub:
                    task = new ToDoSubTask(TX_Name.Text, tags);
                    goto default;
                default:
                    succesed = true;
                    break;
            }
            
            if(succesed) Close();
        }

        private List<Tag> AssignTags()
        {
            List<Tag> tags = new List<Tag>();

            for(int i = 0; i < TagsPanel.Controls.Count; i++)
            {
                var tagControl = TagsPanel.Controls[i] as InputTagUserC;

                if (tagControl != null)
                {
                    var data = tagControl.GetTagData();
                    if (data != null)
                        tags.Add(data);
                }
            }

            return tags;
        }

        public ToDoBase GetTask()
        {
            if(task != null) return task;

            return null;
        }
    }
}
