namespace mywinform1
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
            this.SignInCompleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignIn_password = new System.Windows.Forms.TextBox();
            this.SignIn_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignIn_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignInCompleteBtn
            // 
            this.SignInCompleteBtn.Location = new System.Drawing.Point(390, 296);
            this.SignInCompleteBtn.Name = "SignInCompleteBtn";
            this.SignInCompleteBtn.Size = new System.Drawing.Size(143, 45);
            this.SignInCompleteBtn.TabIndex = 13;
            this.SignInCompleteBtn.Text = "SignIn";
            this.SignInCompleteBtn.UseVisualStyleBackColor = true;
            this.SignInCompleteBtn.Click += new System.EventHandler(this.SignInCompleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // SignIn_password
            // 
            this.SignIn_password.Location = new System.Drawing.Point(318, 244);
            this.SignIn_password.Name = "SignIn_password";
            this.SignIn_password.PasswordChar = '●';
            this.SignIn_password.Size = new System.Drawing.Size(279, 25);
            this.SignIn_password.TabIndex = 9;
            this.SignIn_password.Text = "비밀번호";
            this.SignIn_password.UseSystemPasswordChar = true;
            // 
            // SignIn_id
            // 
            this.SignIn_id.Location = new System.Drawing.Point(318, 197);
            this.SignIn_id.Name = "SignIn_id";
            this.SignIn_id.Size = new System.Drawing.Size(279, 25);
            this.SignIn_id.TabIndex = 8;
            this.SignIn_id.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "회원가입";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name";
            // 
            // SignIn_name
            // 
            this.SignIn_name.Location = new System.Drawing.Point(319, 149);
            this.SignIn_name.Name = "SignIn_name";
            this.SignIn_name.Size = new System.Drawing.Size(279, 25);
            this.SignIn_name.TabIndex = 14;
            this.SignIn_name.Text = "이름";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignIn_name);
            this.Controls.Add(this.SignInCompleteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignIn_password);
            this.Controls.Add(this.SignIn_id);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInCompleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SignIn_password;
        private System.Windows.Forms.TextBox SignIn_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SignIn_name;
    }
}