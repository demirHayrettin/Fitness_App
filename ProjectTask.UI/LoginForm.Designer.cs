namespace ProjectTask.UI
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            Usernamelbl = new Label();
            pictureBox1 = new PictureBox();
            Passwordlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(217, 256);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkBlue;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(217, 302);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkBlue;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(347, 302);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 40);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Usernamelbl
            // 
            Usernamelbl.AutoSize = true;
            Usernamelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Usernamelbl.Location = new Point(217, 177);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(54, 20);
            Usernamelbl.TabIndex = 4;
            Usernamelbl.Text = "Email*";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(263, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.BackColorChanged += LoginForm_Load;
            // 
            // Passwordlbl
            // 
            Passwordlbl.AutoSize = true;
            Passwordlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Passwordlbl.Location = new Point(217, 233);
            Passwordlbl.Name = "Passwordlbl";
            Passwordlbl.Size = new Size(83, 20);
            Passwordlbl.TabIndex = 6;
            Passwordlbl.Text = "Password*";
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(660, 542);
            Controls.Add(Passwordlbl);
            Controls.Add(pictureBox1);
            Controls.Add(Usernamelbl);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Name = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label Usernamelbl;
        private PictureBox pictureBox1;
        private Label Passwordlbl;
    }
}
