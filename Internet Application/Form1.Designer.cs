namespace Internet_Application
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
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gboxInternetChoices = new System.Windows.Forms.GroupBox();
            this.rbFibre = new System.Windows.Forms.RadioButton();
            this.rbLTE = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.btnCheckApplication = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gboxInternetChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(131, 115);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(130, 20);
            this.tbSalary.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(131, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(130, 20);
            this.tbName.TabIndex = 16;
            // 
            // gboxInternetChoices
            // 
            this.gboxInternetChoices.Controls.Add(this.rbFibre);
            this.gboxInternetChoices.Controls.Add(this.rbLTE);
            this.gboxInternetChoices.Controls.Add(this.rbUSB);
            this.gboxInternetChoices.Location = new System.Drawing.Point(314, 35);
            this.gboxInternetChoices.Name = "gboxInternetChoices";
            this.gboxInternetChoices.Size = new System.Drawing.Size(216, 140);
            this.gboxInternetChoices.TabIndex = 15;
            this.gboxInternetChoices.TabStop = false;
            this.gboxInternetChoices.Text = "Internet Choices";
            // 
            // rbFibre
            // 
            this.rbFibre.AutoSize = true;
            this.rbFibre.Location = new System.Drawing.Point(34, 98);
            this.rbFibre.Name = "rbFibre";
            this.rbFibre.Size = new System.Drawing.Size(48, 17);
            this.rbFibre.TabIndex = 2;
            this.rbFibre.TabStop = true;
            this.rbFibre.Text = "Fibre";
            this.rbFibre.UseVisualStyleBackColor = true;
            // 
            // rbLTE
            // 
            this.rbLTE.AutoSize = true;
            this.rbLTE.Location = new System.Drawing.Point(34, 64);
            this.rbLTE.Name = "rbLTE";
            this.rbLTE.Size = new System.Drawing.Size(71, 17);
            this.rbLTE.TabIndex = 1;
            this.rbLTE.TabStop = true;
            this.rbLTE.Text = "LTE/ Wifi";
            this.rbLTE.UseVisualStyleBackColor = true;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(34, 32);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(84, 17);
            this.rbUSB.TabIndex = 0;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB Dongle";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // btnCheckApplication
            // 
            this.btnCheckApplication.Location = new System.Drawing.Point(70, 206);
            this.btnCheckApplication.Name = "btnCheckApplication";
            this.btnCheckApplication.Size = new System.Drawing.Size(460, 47);
            this.btnCheckApplication.TabIndex = 14;
            this.btnCheckApplication.Text = "Check Application";
            this.btnCheckApplication.UseVisualStyleBackColor = true;
            this.btnCheckApplication.Click += new System.EventHandler(this.btnCheckApplication_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(66, 118);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 13;
            this.lblSalary.Text = "Salary";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(67, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 290);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.gboxInternetChoices);
            this.Controls.Add(this.btnCheckApplication);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Internet Application";
            this.gboxInternetChoices.ResumeLayout(false);
            this.gboxInternetChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbSalary;
        internal System.Windows.Forms.TextBox tbName;
        internal System.Windows.Forms.GroupBox gboxInternetChoices;
        internal System.Windows.Forms.RadioButton rbFibre;
        internal System.Windows.Forms.RadioButton rbLTE;
        internal System.Windows.Forms.RadioButton rbUSB;
        internal System.Windows.Forms.Button btnCheckApplication;
        internal System.Windows.Forms.Label lblSalary;
        internal System.Windows.Forms.Label lblName;
    }
}

