namespace Proiect1
{
    partial class KeywordInput
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
            this.lblKeywordInput = new System.Windows.Forms.Label();
            this.textBoxKeywordInput = new System.Windows.Forms.TextBox();
            this.btnOKKeywordInput = new System.Windows.Forms.Button();
            this.btnCancelKeywordInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeywordInput
            // 
            this.lblKeywordInput.AutoSize = true;
            this.lblKeywordInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblKeywordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywordInput.Location = new System.Drawing.Point(61, 82);
            this.lblKeywordInput.Name = "lblKeywordInput";
            this.lblKeywordInput.Size = new System.Drawing.Size(86, 20);
            this.lblKeywordInput.TabIndex = 0;
            this.lblKeywordInput.Text = "Keyword:";
            // 
            // textBoxKeywordInput
            // 
            this.textBoxKeywordInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxKeywordInput.Location = new System.Drawing.Point(159, 82);
            this.textBoxKeywordInput.Name = "textBoxKeywordInput";
            this.textBoxKeywordInput.Size = new System.Drawing.Size(221, 22);
            this.textBoxKeywordInput.TabIndex = 1;
            this.textBoxKeywordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeywordInput_KeyDown);
            // 
            // btnOKKeywordInput
            // 
            this.btnOKKeywordInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOKKeywordInput.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKKeywordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKKeywordInput.Location = new System.Drawing.Point(99, 155);
            this.btnOKKeywordInput.Name = "btnOKKeywordInput";
            this.btnOKKeywordInput.Size = new System.Drawing.Size(107, 43);
            this.btnOKKeywordInput.TabIndex = 2;
            this.btnOKKeywordInput.Text = "OK";
            this.btnOKKeywordInput.UseVisualStyleBackColor = false;
            this.btnOKKeywordInput.Click += new System.EventHandler(this.btnOKKeywordInput_Click);
            // 
            // btnCancelKeywordInput
            // 
            this.btnCancelKeywordInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancelKeywordInput.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelKeywordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelKeywordInput.Location = new System.Drawing.Point(255, 155);
            this.btnCancelKeywordInput.Name = "btnCancelKeywordInput";
            this.btnCancelKeywordInput.Size = new System.Drawing.Size(107, 43);
            this.btnCancelKeywordInput.TabIndex = 3;
            this.btnCancelKeywordInput.Text = "Cancel";
            this.btnCancelKeywordInput.UseVisualStyleBackColor = false;
            this.btnCancelKeywordInput.Click += new System.EventHandler(this.btnCancelKeywordInput_Click);
            // 
            // KeywordInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 270);
            this.Controls.Add(this.btnCancelKeywordInput);
            this.Controls.Add(this.btnOKKeywordInput);
            this.Controls.Add(this.textBoxKeywordInput);
            this.Controls.Add(this.lblKeywordInput);
            this.MinimizeBox = false;
            this.Name = "KeywordInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeywordInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeywordInput;
        private System.Windows.Forms.TextBox textBoxKeywordInput;
        private System.Windows.Forms.Button btnOKKeywordInput;
        private System.Windows.Forms.Button btnCancelKeywordInput;
    }
}