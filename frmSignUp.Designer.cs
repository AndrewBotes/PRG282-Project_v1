namespace PRG282_Project_v1
{
    partial class frmSignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtSignUsername = new System.Windows.Forms.TextBox();
            this.txtSignPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(112, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSignPassword);
            this.panel2.Controls.Add(this.txtSignUsername);
            this.panel2.Controls.Add(this.btnSign);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(112, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 234);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(130, 158);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(102, 41);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Sign Up";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtSignUsername
            // 
            this.txtSignUsername.Location = new System.Drawing.Point(180, 57);
            this.txtSignUsername.Name = "txtSignUsername";
            this.txtSignUsername.Size = new System.Drawing.Size(118, 22);
            this.txtSignUsername.TabIndex = 3;
            // 
            // txtSignPassword
            // 
            this.txtSignPassword.Location = new System.Drawing.Point(180, 98);
            this.txtSignPassword.Name = "txtSignPassword";
            this.txtSignPassword.Size = new System.Drawing.Size(118, 22);
            this.txtSignPassword.TabIndex = 4;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRG282_Project_v1.Properties.Resources.Back;
            this.ClientSize = new System.Drawing.Size(600, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSignUp";
            this.Text = "frmSignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSignPassword;
        private System.Windows.Forms.TextBox txtSignUsername;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}