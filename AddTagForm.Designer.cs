namespace ToDoListApp
{
    partial class AddTagForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TagList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TagList
            // 
            this.TagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagList.Location = new System.Drawing.Point(0, 0);
            this.TagList.Name = "TagList";
            this.TagList.Size = new System.Drawing.Size(319, 294);
            this.TagList.TabIndex = 0;
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 294);
            this.Controls.Add(this.TagList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Tag";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TagList;
    }
}