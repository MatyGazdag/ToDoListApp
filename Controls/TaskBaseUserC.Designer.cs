namespace ToDoListApp
{
    partial class TaskBaseUserC
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
            this.SubTasks = new System.Windows.Forms.Panel();
            this.BTN_AddSubTask = new System.Windows.Forms.Button();
            this.CH_Main = new System.Windows.Forms.CheckBox();
            this.basePanel = new System.Windows.Forms.Panel();
            this.TagList = new System.Windows.Forms.Panel();
            this.BTN_ToggleSubList = new System.Windows.Forms.Button();
            this.SubTasks.SuspendLayout();
            this.basePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubTasks
            // 
            this.SubTasks.AutoSize = true;
            this.SubTasks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubTasks.Controls.Add(this.BTN_AddSubTask);
            this.SubTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubTasks.Location = new System.Drawing.Point(0, 43);
            this.SubTasks.Margin = new System.Windows.Forms.Padding(4);
            this.SubTasks.Name = "SubTasks";
            this.SubTasks.Size = new System.Drawing.Size(667, 36);
            this.SubTasks.TabIndex = 5;
            // 
            // BTN_AddSubTask
            // 
            this.BTN_AddSubTask.BackColor = System.Drawing.Color.White;
            this.BTN_AddSubTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AddSubTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddSubTask.Location = new System.Drawing.Point(0, 0);
            this.BTN_AddSubTask.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AddSubTask.Name = "BTN_AddSubTask";
            this.BTN_AddSubTask.Size = new System.Drawing.Size(667, 36);
            this.BTN_AddSubTask.TabIndex = 0;
            this.BTN_AddSubTask.Text = "Add Sub Task";
            this.BTN_AddSubTask.UseVisualStyleBackColor = false;
            this.BTN_AddSubTask.Click += new System.EventHandler(this.BTN_AddSubTask_Click);
            // 
            // CH_Main
            // 
            this.CH_Main.AutoSize = true;
            this.CH_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.CH_Main.Location = new System.Drawing.Point(0, 0);
            this.CH_Main.Margin = new System.Windows.Forms.Padding(4);
            this.CH_Main.Name = "CH_Main";
            this.CH_Main.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.CH_Main.Size = new System.Drawing.Size(121, 43);
            this.CH_Main.TabIndex = 0;
            this.CH_Main.Text = "checkBox1";
            this.CH_Main.UseVisualStyleBackColor = true;
            this.CH_Main.CheckedChanged += new System.EventHandler(this.CH_Main_CheckedChanged);
            this.CH_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForwardMouseDownToBasePanel);
            // 
            // basePanel
            // 
            this.basePanel.AutoSize = true;
            this.basePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.basePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.basePanel.Controls.Add(this.TagList);
            this.basePanel.Controls.Add(this.CH_Main);
            this.basePanel.Controls.Add(this.BTN_ToggleSubList);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Margin = new System.Windows.Forms.Padding(4);
            this.basePanel.MinimumSize = new System.Drawing.Size(400, 43);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(667, 43);
            this.basePanel.TabIndex = 0;
            this.basePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.basePanel_MouseDown);
            // 
            // TagList
            // 
            this.TagList.AutoScroll = true;
            this.TagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagList.Location = new System.Drawing.Point(121, 0);
            this.TagList.Margin = new System.Windows.Forms.Padding(4);
            this.TagList.Name = "TagList";
            this.TagList.Size = new System.Drawing.Size(499, 43);
            this.TagList.TabIndex = 3;
            this.TagList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForwardMouseDownToBasePanel);
            // 
            // BTN_ToggleSubList
            // 
            this.BTN_ToggleSubList.AutoSize = true;
            this.BTN_ToggleSubList.BackColor = System.Drawing.Color.Transparent;
            this.BTN_ToggleSubList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ToggleSubList.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_ToggleSubList.Location = new System.Drawing.Point(620, 0);
            this.BTN_ToggleSubList.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ToggleSubList.Name = "BTN_ToggleSubList";
            this.BTN_ToggleSubList.Size = new System.Drawing.Size(47, 43);
            this.BTN_ToggleSubList.TabIndex = 1;
            this.BTN_ToggleSubList.UseVisualStyleBackColor = false;
            this.BTN_ToggleSubList.Click += new System.EventHandler(this.BTN_ToggleSubList_Click);
            this.BTN_ToggleSubList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForwardMouseDownToBasePanel);
            // 
            // TaskBaseUserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SubTasks);
            this.Controls.Add(this.basePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(667, 43);
            this.Name = "TaskBaseUserC";
            this.Size = new System.Drawing.Size(667, 79);
            this.SubTasks.ResumeLayout(false);
            this.basePanel.ResumeLayout(false);
            this.basePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SubTasks;
        private System.Windows.Forms.Button BTN_ToggleSubList;
        private System.Windows.Forms.CheckBox CH_Main;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Button BTN_AddSubTask;
        private System.Windows.Forms.Panel TagList;
    }
}
