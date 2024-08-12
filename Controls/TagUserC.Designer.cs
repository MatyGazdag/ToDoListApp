namespace ToDoListApp
{
    partial class TagUserC
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
            this.LB_Name = new System.Windows.Forms.Label();
            this.tagIcon = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LB_Name
            // 
            this.LB_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.LB_Name.Location = new System.Drawing.Point(35, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LB_Name.Size = new System.Drawing.Size(106, 35);
            this.LB_Name.TabIndex = 0;
            this.LB_Name.Text = "15/10/2024";
            this.LB_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tagIcon
            // 
            this.tagIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tagIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.tagIcon.Location = new System.Drawing.Point(0, 0);
            this.tagIcon.Name = "tagIcon";
            this.tagIcon.Size = new System.Drawing.Size(35, 35);
            this.tagIcon.TabIndex = 1;
            this.tagIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.tagIcon_Paint);
            // 
            // TagUserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.tagIcon);
            this.MinimumSize = new System.Drawing.Size(130, 35);
            this.Name = "TagUserC";
            this.Size = new System.Drawing.Size(141, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Panel tagIcon;
    }
}
