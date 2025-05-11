namespace Proiect1
{
    partial class ViewKeywords
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
            this.lblViewKeywords = new System.Windows.Forms.Label();
            this.listViewKeywords = new System.Windows.Forms.ListView();
            this.CloseBtnViewKeywords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblViewKeywords
            // 
            this.lblViewKeywords.AutoSize = true;
            this.lblViewKeywords.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblViewKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewKeywords.Location = new System.Drawing.Point(109, 26);
            this.lblViewKeywords.Name = "lblViewKeywords";
            this.lblViewKeywords.Size = new System.Drawing.Size(203, 32);
            this.lblViewKeywords.TabIndex = 1;
            this.lblViewKeywords.Text = "Keywords List";
            // 
            // listViewKeywords
            // 
            this.listViewKeywords.HideSelection = false;
            this.listViewKeywords.Location = new System.Drawing.Point(69, 82);
            this.listViewKeywords.Name = "listViewKeywords";
            this.listViewKeywords.Size = new System.Drawing.Size(290, 291);
            this.listViewKeywords.TabIndex = 2;
            this.listViewKeywords.UseCompatibleStateImageBehavior = false;
            // 
            // CloseBtnViewKeywords
            // 
            this.CloseBtnViewKeywords.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CloseBtnViewKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtnViewKeywords.Location = new System.Drawing.Point(167, 391);
            this.CloseBtnViewKeywords.Name = "CloseBtnViewKeywords";
            this.CloseBtnViewKeywords.Size = new System.Drawing.Size(96, 42);
            this.CloseBtnViewKeywords.TabIndex = 3;
            this.CloseBtnViewKeywords.Text = "Close";
            this.CloseBtnViewKeywords.UseVisualStyleBackColor = false;
            this.CloseBtnViewKeywords.Click += new System.EventHandler(this.CloseBtnViewKeywords_Click);
            // 
            // ViewKeywords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 469);
            this.Controls.Add(this.CloseBtnViewKeywords);
            this.Controls.Add(this.listViewKeywords);
            this.Controls.Add(this.lblViewKeywords);
            this.Name = "ViewKeywords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewKeywords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewKeywords;
        private System.Windows.Forms.ListView listViewKeywords;
        private System.Windows.Forms.Button CloseBtnViewKeywords;
    }
}