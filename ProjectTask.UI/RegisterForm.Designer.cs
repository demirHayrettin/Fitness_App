namespace ProjectTask.UI
{
    partial class RegisterForm
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLastname = new TextBox();
            label4 = new Label();
            cmbGender = new ComboBox();
            label5 = new Label();
            txtEmailReg = new TextBox();
            label6 = new Label();
            txtPasswordReg = new TextBox();
            btnRegist = new Button();
            txtConfirm = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtHeight = new TextBox();
            label10 = new Label();
            txtWeight = new TextBox();
            dtpBirthdate = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 0;
            label1.Text = "Fit-Kal";
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(43, 143);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(20, 210);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name*";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(117, 207);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(208, 27);
            txtLastname.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(31, 271);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Gender*";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(117, 268);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(208, 28);
            cmbGender.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(395, 140);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 7;
            label5.Text = "Email*";
            // 
            // txtEmailReg
            // 
            txtEmailReg.Location = new Point(472, 136);
            txtEmailReg.Name = "txtEmailReg";
            txtEmailReg.Size = new Size(208, 27);
            txtEmailReg.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(28, 331);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 9;
            label6.Text = "Password*";
            // 
            // txtPasswordReg
            // 
            txtPasswordReg.Location = new Point(117, 328);
            txtPasswordReg.Name = "txtPasswordReg";
            txtPasswordReg.Size = new Size(208, 27);
            txtPasswordReg.TabIndex = 10;
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.DarkBlue;
            btnRegist.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRegist.ForeColor = Color.Transparent;
            btnRegist.Location = new Point(586, 449);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(94, 41);
            btnRegist.TabIndex = 11;
            btnRegist.Text = "Register";
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(117, 384);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(208, 27);
            txtConfirm.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 440);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(28, 387);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 14;
            label8.Text = "Confirm*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(395, 207);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 15;
            label9.Text = "Height*";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(472, 200);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(208, 27);
            txtHeight.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(393, 271);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 17;
            label10.Text = "Weight*";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(472, 268);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(208, 27);
            txtWeight.TabIndex = 18;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(472, 331);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(208, 27);
            dtpBirthdate.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(376, 335);
            label11.Name = "label11";
            label11.Size = new Size(84, 20);
            label11.TabIndex = 20;
            label11.Text = "BirthDate*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(376, 387);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 21;
            label12.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(472, 380);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 22;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(725, 592);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dtpBirthdate);
            Controls.Add(txtWeight);
            Controls.Add(label10);
            Controls.Add(txtHeight);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtConfirm);
            Controls.Add(btnRegist);
            Controls.Add(txtPasswordReg);
            Controls.Add(label6);
            Controls.Add(txtEmailReg);
            Controls.Add(label5);
            Controls.Add(cmbGender);
            Controls.Add(label4);
            Controls.Add(txtLastname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtLastname;
        private Label label4;
        private ComboBox cmbGender;
        private Label label5;
        private TextBox txtEmailReg;
        private Label label6;
        private TextBox txtPasswordReg;
        private Button btnRegist;
        private TextBox txtConfirm;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtHeight;
        private Label label10;
        private TextBox txtWeight;
        private DateTimePicker dtpBirthdate;
        private Label label11;
        private Label label12;
        private TextBox textBox1;
    }
}