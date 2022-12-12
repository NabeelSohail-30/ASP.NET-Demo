namespace LMSWin
{
    partial class LoginForm
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
            this.PanelLoginForm = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtUserPass = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.TxtUserEmail = new System.Windows.Forms.TextBox();
            this.LblUserEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgAvatar = new System.Windows.Forms.PictureBox();
            this.PanelLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLoginForm
            // 
            this.PanelLoginForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelLoginForm.Controls.Add(this.BtnLogin);
            this.PanelLoginForm.Controls.Add(this.TxtUserPass);
            this.PanelLoginForm.Controls.Add(this.LblPass);
            this.PanelLoginForm.Controls.Add(this.TxtUserEmail);
            this.PanelLoginForm.Controls.Add(this.LblUserEmail);
            this.PanelLoginForm.Controls.Add(this.label1);
            this.PanelLoginForm.Location = new System.Drawing.Point(33, 115);
            this.PanelLoginForm.Name = "PanelLoginForm";
            this.PanelLoginForm.Size = new System.Drawing.Size(420, 409);
            this.PanelLoginForm.TabIndex = 0;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(180)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(108, 325);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(203, 46);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUserPass
            // 
            this.TxtUserPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtUserPass.Location = new System.Drawing.Point(59, 239);
            this.TxtUserPass.Name = "TxtUserPass";
            this.TxtUserPass.PasswordChar = '*';
            this.TxtUserPass.Size = new System.Drawing.Size(302, 33);
            this.TxtUserPass.TabIndex = 4;
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.Location = new System.Drawing.Point(54, 206);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(97, 25);
            this.LblPass.TabIndex = 3;
            this.LblPass.Text = "Password";
            // 
            // TxtUserEmail
            // 
            this.TxtUserEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtUserEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.TxtUserEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtUserEmail.Location = new System.Drawing.Point(62, 137);
            this.TxtUserEmail.Name = "TxtUserEmail";
            this.TxtUserEmail.Size = new System.Drawing.Size(302, 33);
            this.TxtUserEmail.TabIndex = 2;
            // 
            // LblUserEmail
            // 
            this.LblUserEmail.AutoSize = true;
            this.LblUserEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserEmail.Location = new System.Drawing.Point(54, 104);
            this.LblUserEmail.Name = "LblUserEmail";
            this.LblUserEmail.Size = new System.Drawing.Size(104, 25);
            this.LblUserEmail.TabIndex = 1;
            this.LblUserEmail.Text = "User Email";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgAvatar
            // 
            this.ImgAvatar.BackColor = System.Drawing.Color.Transparent;
            this.ImgAvatar.Image = global::LMSWin.Properties.Resources.Avatar;
            this.ImgAvatar.Location = new System.Drawing.Point(191, 21);
            this.ImgAvatar.Name = "ImgAvatar";
            this.ImgAvatar.Size = new System.Drawing.Size(100, 94);
            this.ImgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgAvatar.TabIndex = 1;
            this.ImgAvatar.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(484, 550);
            this.Controls.Add(this.ImgAvatar);
            this.Controls.Add(this.PanelLoginForm);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.PanelLoginForm.ResumeLayout(false);
            this.PanelLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLoginForm;
        private System.Windows.Forms.PictureBox ImgAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblUserEmail;
        private System.Windows.Forms.TextBox TxtUserPass;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TxtUserEmail;
        private System.Windows.Forms.Button BtnLogin;
    }
}