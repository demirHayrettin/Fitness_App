using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProjectTask.DAL;

namespace ProjectTask.UI
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;

        public LoginForm(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_context);
            registerForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            var user = _context.Kullanicilar.FirstOrDefault(u => u.Email == email && u.Sifre == password);

            if (user != null)
            {
                // Kullanıcı Doğrulama
                AnasayfaForm anasayfaForm = new AnasayfaForm();
                anasayfaForm.Show();
                this.Hide(); // Login formu gizlemekiçin
            }
            else
            {
                // Kullanıcı bulunamadı
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }
    }
}
