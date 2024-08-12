namespace ToDoListApp
{
    partial class ExportForm
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
            this.CB_Export = new System.Windows.Forms.ComboBox();
            this.BTN_Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Export
            // 
            this.CB_Export.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_Export.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Export.FormattingEnabled = true;
            this.CB_Export.Items.AddRange(new object[] {
            "SQL"});
            this.CB_Export.Location = new System.Drawing.Point(0, 0);
            this.CB_Export.Name = "CB_Export";
            this.CB_Export.Size = new System.Drawing.Size(315, 24);
            this.CB_Export.TabIndex = 0;
            // 
            // BTN_Export
            // 
            this.BTN_Export.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Export.Location = new System.Drawing.Point(0, 30);
            this.BTN_Export.MinimumSize = new System.Drawing.Size(0, 25);
            this.BTN_Export.Name = "BTN_Export";
            this.BTN_Export.Size = new System.Drawing.Size(315, 27);
            this.BTN_Export.TabIndex = 1;
            this.BTN_Export.Text = "Export";
            this.BTN_Export.UseVisualStyleBackColor = true;
            this.BTN_Export.Click += new System.EventHandler(this.BTN_Export_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(315, 57);
            this.Controls.Add(this.BTN_Export);
            this.Controls.Add(this.CB_Export);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Export;
        private System.Windows.Forms.Button BTN_Export;
    }
}