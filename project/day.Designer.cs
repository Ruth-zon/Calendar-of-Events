namespace project
{
    partial class day
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
         {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.חתונהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ברמצווהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יוםהולדתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(31, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(108, 82);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.linkLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.Location = new System.Drawing.Point(26, 125);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "הוסף ארוע";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.חתונהToolStripMenuItem,
            this.ברמצווהToolStripMenuItem,
            this.יוםהולדתToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // חתונהToolStripMenuItem
            // 
            this.חתונהToolStripMenuItem.Name = "חתונהToolStripMenuItem";
            this.חתונהToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.חתונהToolStripMenuItem.Text = "חתונה";
            this.חתונהToolStripMenuItem.Click += new System.EventHandler(this.חתונהToolStripMenuItem_Click);
            // 
            // ברמצווהToolStripMenuItem
            // 
            this.ברמצווהToolStripMenuItem.Name = "ברמצווהToolStripMenuItem";
            this.ברמצווהToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ברמצווהToolStripMenuItem.Text = "בר מצווה";
            this.ברמצווהToolStripMenuItem.Click += new System.EventHandler(this.ברמצווהToolStripMenuItem_Click);
            // 
            // יוםהולדתToolStripMenuItem
            // 
            this.יוםהולדתToolStripMenuItem.Name = "יוםהולדתToolStripMenuItem";
            this.יוםהולדתToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.יוםהולדתToolStripMenuItem.Text = "יום הולדת";
            this.יוםהולדתToolStripMenuItem.Click += new System.EventHandler(this.יוםהולדתToolStripMenuItem_Click);
            // 
            // day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "day";
            this.Size = new System.Drawing.Size(129, 161);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem חתונהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ברמצווהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem יוםהולדתToolStripMenuItem;
    }
}
