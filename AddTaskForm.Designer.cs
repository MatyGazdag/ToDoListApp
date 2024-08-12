namespace ToDoListApp
{
    partial class AddTaskForm
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
            this.TX_Name = new System.Windows.Forms.TextBox();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.BottomPart = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TagsPanel = new System.Windows.Forms.Panel();
            this.inputTagUserC1 = new ToDoListApp.Controls.InputTagUserC();
            this.button1 = new System.Windows.Forms.Button();
            this.LBL_Info = new System.Windows.Forms.Label();
            this.BottomPart.SuspendLayout();
            this.TagsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TX_Name
            // 
            this.TX_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.TX_Name.Location = new System.Drawing.Point(0, 0);
            this.TX_Name.Multiline = true;
            this.TX_Name.Name = "TX_Name";
            this.TX_Name.Size = new System.Drawing.Size(317, 31);
            this.TX_Name.TabIndex = 0;
            this.TX_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_Create
            // 
            this.BTN_Create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Create.Location = new System.Drawing.Point(0, 314);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(317, 27);
            this.BTN_Create.TabIndex = 2;
            this.BTN_Create.Text = "Create";
            this.BTN_Create.UseVisualStyleBackColor = true;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // BottomPart
            // 
            this.BottomPart.AutoScroll = true;
            this.BottomPart.Controls.Add(this.TagsPanel);
            this.BottomPart.Controls.Add(this.TX_Name);
            this.BottomPart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPart.Location = new System.Drawing.Point(0, 121);
            this.BottomPart.Name = "BottomPart";
            this.BottomPart.Size = new System.Drawing.Size(317, 193);
            this.BottomPart.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 95);
            this.panel2.TabIndex = 4;
            // 
            // TagsPanel
            // 
            this.TagsPanel.Controls.Add(this.button1);
            this.TagsPanel.Controls.Add(this.inputTagUserC1);
            this.TagsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagsPanel.Location = new System.Drawing.Point(0, 31);
            this.TagsPanel.Name = "TagsPanel";
            this.TagsPanel.Size = new System.Drawing.Size(317, 162);
            this.TagsPanel.TabIndex = 2;
            // 
            // inputTagUserC1
            // 
            this.inputTagUserC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputTagUserC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTagUserC1.Location = new System.Drawing.Point(0, 0);
            this.inputTagUserC1.MinimumSize = new System.Drawing.Size(100, 20);
            this.inputTagUserC1.Name = "inputTagUserC1";
            this.inputTagUserC1.Size = new System.Drawing.Size(317, 20);
            this.inputTagUserC1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Tag";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LBL_Info
            // 
            this.LBL_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Info.ForeColor = System.Drawing.Color.Red;
            this.LBL_Info.Location = new System.Drawing.Point(0, 95);
            this.LBL_Info.Name = "LBL_Info";
            this.LBL_Info.Size = new System.Drawing.Size(317, 26);
            this.LBL_Info.TabIndex = 5;
            this.LBL_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 341);
            this.Controls.Add(this.LBL_Info);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BottomPart);
            this.Controls.Add(this.BTN_Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTaskForm";
            this.Text = "Create";
            this.BottomPart.ResumeLayout(false);
            this.BottomPart.PerformLayout();
            this.TagsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TX_Name;
        private System.Windows.Forms.Button BTN_Create;
        private System.Windows.Forms.Panel BottomPart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TagsPanel;
        private Controls.InputTagUserC inputTagUserC1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBL_Info;
    }
}