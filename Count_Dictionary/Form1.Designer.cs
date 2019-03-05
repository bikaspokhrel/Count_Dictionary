namespace Count_Dictionary
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
            this.btnCount = new System.Windows.Forms.Button();
            this.lbxCountresult = new System.Windows.Forms.ListBox();
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(145, 96);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(118, 57);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Letters Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lbxCountresult
            // 
            this.lbxCountresult.FormattingEnabled = true;
            this.lbxCountresult.ItemHeight = 16;
            this.lbxCountresult.Location = new System.Drawing.Point(498, 30);
            this.lbxCountresult.Name = "lbxCountresult";
            this.lbxCountresult.Size = new System.Drawing.Size(175, 308);
            this.lbxCountresult.TabIndex = 1;
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(145, 46);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(255, 22);
            this.txtInputWord.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(178, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 58);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtInputWord);
            this.Controls.Add(this.lbxCountresult);
            this.Controls.Add(this.btnCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ListBox lbxCountresult;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Button btnClear;
    }
}

