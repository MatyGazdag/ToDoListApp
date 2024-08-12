namespace ToDoListApp.Controls
{
    partial class InputTagUserC
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
            this.TXB_TagName = new System.Windows.Forms.TextBox();
            this.ColorPicker = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TXB_TagName
            // 
            this.TXB_TagName.Dock = System.Windows.Forms.DockStyle.Left;
            this.TXB_TagName.Location = new System.Drawing.Point(0, 0);
            this.TXB_TagName.Margin = new System.Windows.Forms.Padding(4);
            this.TXB_TagName.MinimumSize = new System.Drawing.Size(132, 20);
            this.TXB_TagName.Name = "TXB_TagName";
            this.TXB_TagName.Size = new System.Drawing.Size(132, 22);
            this.TXB_TagName.TabIndex = 0;
            this.TXB_TagName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColorPicker
            // 
            this.ColorPicker.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPicker.Dock = System.Windows.Forms.DockStyle.Right;
            this.ColorPicker.Location = new System.Drawing.Point(177, 0);
            this.ColorPicker.Margin = new System.Windows.Forms.Padding(4);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(99, 25);
            this.ColorPicker.TabIndex = 1;
            this.ColorPicker.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // InputTagUserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ColorPicker);
            this.Controls.Add(this.TXB_TagName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(133, 25);
            this.Name = "InputTagUserC";
            this.Size = new System.Drawing.Size(276, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_TagName;
        private System.Windows.Forms.Panel ColorPicker;
    }
}
