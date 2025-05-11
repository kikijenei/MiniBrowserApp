namespace Proiect1
{
    partial class KeywordDelete
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
            this.lblKDel = new System.Windows.Forms.Label();
            this.comboBoxKeywordDelete = new System.Windows.Forms.ComboBox();
            this.BtnDeleteKeyword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKDel
            // 
            this.lblKDel.AutoSize = true;
            this.lblKDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKDel.ForeColor = System.Drawing.Color.Black;
            this.lblKDel.Location = new System.Drawing.Point(38, 51);
            this.lblKDel.Name = "lblKDel";
            this.lblKDel.Size = new System.Drawing.Size(92, 20);
            this.lblKDel.TabIndex = 0;
            this.lblKDel.Text = "Keyword: ";
            // 
            // comboBoxKeywordDelete
            // 
            this.comboBoxKeywordDelete.FormattingEnabled = true;
            this.comboBoxKeywordDelete.Location = new System.Drawing.Point(136, 51);
            this.comboBoxKeywordDelete.Name = "comboBoxKeywordDelete";
            this.comboBoxKeywordDelete.Size = new System.Drawing.Size(238, 24);
            this.comboBoxKeywordDelete.TabIndex = 1;
            this.comboBoxKeywordDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeywordDelete_SelectedIndexChanged);
            // 
            // BtnDeleteKeyword
            // 
            this.BtnDeleteKeyword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnDeleteKeyword.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnDeleteKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteKeyword.ForeColor = System.Drawing.Color.Black;
            this.BtnDeleteKeyword.Location = new System.Drawing.Point(136, 117);
            this.BtnDeleteKeyword.Name = "BtnDeleteKeyword";
            this.BtnDeleteKeyword.Size = new System.Drawing.Size(98, 38);
            this.BtnDeleteKeyword.TabIndex = 2;
            this.BtnDeleteKeyword.Text = "Delete";
            this.BtnDeleteKeyword.UseVisualStyleBackColor = false;
            this.BtnDeleteKeyword.Click += new System.EventHandler(this.BtnDeleteKeyword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(259, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // KeywordDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 212);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnDeleteKeyword);
            this.Controls.Add(this.comboBoxKeywordDelete);
            this.Controls.Add(this.lblKDel);
            this.Name = "KeywordDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeywordDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKDel;
        private System.Windows.Forms.ComboBox comboBoxKeywordDelete;
        private System.Windows.Forms.Button BtnDeleteKeyword;
        private System.Windows.Forms.Button btnCancel;
    }
}