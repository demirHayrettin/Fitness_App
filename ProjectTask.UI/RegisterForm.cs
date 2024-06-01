using Microsoft.EntityFrameworkCore;
using ProjectTask.DATA;
using ProjectTask.DAL;
using System;
using System.Windows.Forms;

namespace ProjectTask.UI
{
    public partial class RegisterForm : Form
    {
        private readonly AppDbContext _context;

        // Constructor ekledik appDbcontecxt için
        public RegisterForm(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (txtPasswordReg.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            var newUser = new Kullanici
            {
                Ad = txtName.Text,
                Soyad = txtLastname.Text,
                DogumTarihi = dtpBirthdate.Value,
                Cinsiyet = cmbGender.SelectedItem.ToString(),
                Boy = int.Parse(txtHeight.Text),
                Kilo = int.Parse(txtWeight.Text),
                Email = txtEmailReg.Text,
                Sifre = txtPasswordReg.Text // belki hashleyebilrz
            };

            _context.Kullanicilar.Add(newUser);
            _context.SaveChanges();

            MessageBox.Show("User registered successfully!");
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");

        }
    }
}
