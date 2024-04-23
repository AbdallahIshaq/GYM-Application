namespace GYM_Application
{
    partial class login
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bynLogin = new System.Windows.Forms.Button();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bynLogin);
            this.panel1.Controls.Add(this.txtBoxUserName);
            this.panel1.Controls.Add(this.txtBoxpassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(93, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 446);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gym Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(185, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pure Fitnes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // bynLogin
            // 
            this.bynLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bynLogin.Font = new System.Drawing.Font("Simple Indust Outline", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bynLogin.Location = new System.Drawing.Point(159, 342);
            this.bynLogin.Name = "bynLogin";
            this.bynLogin.Size = new System.Drawing.Size(305, 66);
            this.bynLogin.TabIndex = 4;
            this.bynLogin.Text = "Login";
            this.bynLogin.UseVisualStyleBackColor = false;
            this.bynLogin.Click += new System.EventHandler(this.bynLogin_Click);
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.BackColor = System.Drawing.Color.Lime;
            this.txtBoxUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUserName.Location = new System.Drawing.Point(185, 187);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(248, 31);
            this.txtBoxUserName.TabIndex = 3;
            // 
            // txtBoxpassword
            // 
            this.txtBoxpassword.BackColor = System.Drawing.Color.Lime;
            this.txtBoxpassword.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxpassword.Location = new System.Drawing.Point(185, 280);
            this.txtBoxpassword.Name = "txtBoxpassword";
            this.txtBoxpassword.PasswordChar = '*';
            this.txtBoxpassword.Size = new System.Drawing.Size(248, 31);
            this.txtBoxpassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(185, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 544);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button bynLogin;
        private TextBox txtBoxUserName;
        private TextBox txtBoxpassword;
        private Label label2;
    }
}