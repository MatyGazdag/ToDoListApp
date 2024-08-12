namespace ToDoListApp
{
    partial class SubTaskUserC
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.CH_Name = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CH_Name
            // 
            this.CH_Name.AutoSize = true;
            this.CH_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.CH_Name.Location = new System.Drawing.Point(0, 0);
            this.CH_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CH_Name.Name = "CH_Name";
            this.CH_Name.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.CH_Name.Size = new System.Drawing.Size(106, 43);
            this.CH_Name.TabIndex = 0;
            this.CH_Name.Text = "checkBox1";
            this.CH_Name.UseVisualStyleBackColor = true;
            this.CH_Name.CheckedChanged += new System.EventHandler(this.CH_Name_CheckedChanged);
            this.CH_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForwardMouseDownToBasePanel);
            // 
            // SubTaskUserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CH_Name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(267, 43);
            this.Name = "SubTaskUserC";
            this.Size = new System.Drawing.Size(267, 43);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.basePanel_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CH_Name;
    }
}
