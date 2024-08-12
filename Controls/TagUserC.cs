using System.Drawing;
using System.Windows.Forms;
using ToDoListApp.ToDoData;

namespace ToDoListApp
{
    public partial class TagUserC : UserControl
    {
        public Tag tag;

        public TagUserC()
        {
            InitializeComponent();
        }

        public TagUserC(Tag tag)
        {
            InitializeComponent();
            this.tag = tag;
            LB_Name.Text = tag.Name;
        }

        private void tagIcon_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            if(tag != null)
            {
                g.FillEllipse(new SolidBrush(tag.tagColor), tagIcon.Size.Width / 2, tagIcon.Size.Width / 2, tagIcon.Size.Width / 2, tagIcon.Size.Height / 2);
            }else
            {
                g.FillEllipse(new SolidBrush(Color.Red), tagIcon.Size.Width / 2, tagIcon.Size.Width / 2, tagIcon.Size.Width / 2, tagIcon.Size.Height / 2);
            }
        }
    }
}
