namespace Proiect1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripGOBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripBackBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripForwardBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripHomeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripCBKeywords = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addKeywordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteKeywordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKeywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1135, 659);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripGOBtn,
            this.toolStripBackBtn,
            this.toolStripForwardBtn,
            this.toolStripHomeBtn,
            this.toolStripCBKeywords});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1135, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(280, 28);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripGOBtn
            // 
            this.toolStripGOBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGOBtn.Image")));
            this.toolStripGOBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGOBtn.Name = "toolStripGOBtn";
            this.toolStripGOBtn.Size = new System.Drawing.Size(52, 25);
            this.toolStripGOBtn.Text = "Go";
            this.toolStripGOBtn.Click += new System.EventHandler(this.toolStripGOBtn_Click);
            // 
            // toolStripBackBtn
            // 
            this.toolStripBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackBtn.Image")));
            this.toolStripBackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackBtn.Name = "toolStripBackBtn";
            this.toolStripBackBtn.Size = new System.Drawing.Size(64, 25);
            this.toolStripBackBtn.Text = "Back";
            this.toolStripBackBtn.Click += new System.EventHandler(this.toolStripBackBtn_Click);
            // 
            // toolStripForwardBtn
            // 
            this.toolStripForwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripForwardBtn.Image")));
            this.toolStripForwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripForwardBtn.Name = "toolStripForwardBtn";
            this.toolStripForwardBtn.Size = new System.Drawing.Size(87, 25);
            this.toolStripForwardBtn.Text = "Forward";
            this.toolStripForwardBtn.Click += new System.EventHandler(this.toolStripForwardBtn_Click);
            // 
            // toolStripHomeBtn
            // 
            this.toolStripHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHomeBtn.Image")));
            this.toolStripHomeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHomeBtn.Name = "toolStripHomeBtn";
            this.toolStripHomeBtn.Size = new System.Drawing.Size(74, 25);
            this.toolStripHomeBtn.Text = "Home";
            this.toolStripHomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripHomeBtn.Click += new System.EventHandler(this.toolStripHomeBtn_Click);
            // 
            // toolStripCBKeywords
            // 
            this.toolStripCBKeywords.Name = "toolStripCBKeywords";
            this.toolStripCBKeywords.Size = new System.Drawing.Size(121, 28);
            this.toolStripCBKeywords.Click += new System.EventHandler(this.toolStripCBKeywords_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.meniuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("meniuToolStripMenuItem.Image")));
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.addKeywordToolStripMenuItem,
            this.deleteKeywordToolStripMenuItem,
            this.viewKeywordsToolStripMenuItem});
            this.databaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("databaseToolStripMenuItem.Image")));
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripMenuItem.Image")));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disconnectToolStripMenuItem.Image")));
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // addKeywordToolStripMenuItem
            // 
            this.addKeywordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addKeywordToolStripMenuItem.Image")));
            this.addKeywordToolStripMenuItem.Name = "addKeywordToolStripMenuItem";
            this.addKeywordToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addKeywordToolStripMenuItem.Text = "AddKeyword";
            this.addKeywordToolStripMenuItem.Click += new System.EventHandler(this.addKeywordToolStripMenuItem_Click);
            // 
            // deleteKeywordToolStripMenuItem
            // 
            this.deleteKeywordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteKeywordToolStripMenuItem.Image")));
            this.deleteKeywordToolStripMenuItem.Name = "deleteKeywordToolStripMenuItem";
            this.deleteKeywordToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.deleteKeywordToolStripMenuItem.Text = "DeleteKeyword";
            this.deleteKeywordToolStripMenuItem.Click += new System.EventHandler(this.deleteKeywordToolStripMenuItem_Click);
            // 
            // viewKeywordsToolStripMenuItem
            // 
            this.viewKeywordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewKeywordsToolStripMenuItem.Image")));
            this.viewKeywordsToolStripMenuItem.Name = "viewKeywordsToolStripMenuItem";
            this.viewKeywordsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.viewKeywordsToolStripMenuItem.Text = "ViewKeywords";
            this.viewKeywordsToolStripMenuItem.Click += new System.EventHandler(this.viewKeywordsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1135, 659);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webBrowser1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripGOBtn;
        private System.Windows.Forms.ToolStripButton toolStripBackBtn;
        private System.Windows.Forms.ToolStripButton toolStripForwardBtn;
        private System.Windows.Forms.ToolStripButton toolStripHomeBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addKeywordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewKeywordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripCBKeywords;
        private System.Windows.Forms.ToolStripMenuItem deleteKeywordToolStripMenuItem;
    }
}

