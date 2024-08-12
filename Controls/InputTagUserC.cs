using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoListApp.ToDoData;

namespace ToDoListApp.Controls
{
    public partial class InputTagUserC : UserControl
    {
        public InputTagUserC()
        {
            InitializeComponent();
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.ShowHelp = true;
            MyDialog.Color = Color.Red;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPicker.BackColor = MyDialog.Color;
            }
        }

        public Tag GetTagData()
        {
            if(String.IsNullOrEmpty(TXB_TagName.Text))
                return null;

            Tag tagData = new Tag(ColorPicker.ForeColor, TXB_TagName.Text);            

            return tagData;
        }
    }
}
