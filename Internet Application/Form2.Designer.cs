namespace Internet_Application
{
    partial class Form2
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAproval = new System.Windows.Forms.Label();
            this.lboxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(208, 269);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(179, 26);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAproval
            // 
            this.lblAproval.AutoSize = true;
            this.lblAproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAproval.Location = new System.Drawing.Point(50, 20);
            this.lblAproval.Name = "lblAproval";
            this.lblAproval.Size = new System.Drawing.Size(155, 26);
            this.lblAproval.TabIndex = 7;
            this.lblAproval.Text = "Application is";
            // 
            // lboxOutput
            // 
            this.lboxOutput.FormattingEnabled = true;
            this.lboxOutput.Location = new System.Drawing.Point(55, 77);
            this.lboxOutput.Name = "lboxOutput";
            this.lboxOutput.Size = new System.Drawing.Size(484, 186);
            this.lboxOutput.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 364);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAproval);
            this.Controls.Add(this.lboxOutput);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Label lblAproval;
        public System.Windows.Forms.ListBox lboxOutput;
    }
}