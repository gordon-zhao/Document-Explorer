namespace Document_Explorer
{
    partial class MainForm
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
            this.UI_DocumentList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UI_InfoBox = new System.Windows.Forms.Label();
            this.UI_TagList = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_DocumentList
            // 
            this.UI_DocumentList.FormattingEnabled = true;
            this.UI_DocumentList.IntegralHeight = false;
            this.UI_DocumentList.ItemHeight = 16;
            this.UI_DocumentList.Location = new System.Drawing.Point(156, 27);
            this.UI_DocumentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UI_DocumentList.Name = "UI_DocumentList";
            this.UI_DocumentList.Size = new System.Drawing.Size(293, 340);
            this.UI_DocumentList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // UI_InfoBox
            // 
            this.UI_InfoBox.Location = new System.Drawing.Point(455, 33);
            this.UI_InfoBox.Name = "UI_InfoBox";
            this.UI_InfoBox.Size = new System.Drawing.Size(247, 340);
            this.UI_InfoBox.TabIndex = 3;
            this.UI_InfoBox.Text = "No document selected.";
            // 
            // UI_TagList
            // 
            this.UI_TagList.CheckOnClick = true;
            this.UI_TagList.FormattingEnabled = true;
            this.UI_TagList.IntegralHeight = false;
            this.UI_TagList.Location = new System.Drawing.Point(12, 27);
            this.UI_TagList.Name = "UI_TagList";
            this.UI_TagList.Size = new System.Drawing.Size(138, 338);
            this.UI_TagList.TabIndex = 4;
            this.UI_TagList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.UI_TagList_ItemCheck);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 583);
            this.Controls.Add(this.UI_TagList);
            this.Controls.Add(this.UI_InfoBox);
            this.Controls.Add(this.UI_DocumentList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Document Explorer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_DocumentList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label UI_InfoBox;
        private System.Windows.Forms.CheckedListBox UI_TagList;
    }
}

