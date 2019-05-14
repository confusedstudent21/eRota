namespace eRota
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bttn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(38, 49);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(139, 31);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(38, 139);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(134, 31);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(249, 42);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(175, 38);
            this.tb_user.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(249, 149);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(175, 38);
            this.tb_password.TabIndex = 3;
            // 
            // bttn_login
            // 
            this.bttn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_login.Location = new System.Drawing.Point(148, 240);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(150, 52);
            this.bttn_login.TabIndex = 4;
            this.bttn_login.Text = "Login";
            this.bttn_login.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 321);
            this.Controls.Add(this.bttn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bttn_login;
    }
}