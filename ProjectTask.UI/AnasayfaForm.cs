using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTask.UI
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
        }

        private void btnOgunler_Click(object sender, EventArgs e)
        {
            OgunlerForm ogunlerForm = new OgunlerForm();
            ogunlerForm.Show();
        }

        private void btnYemekler_Click(object sender, EventArgs e)
        {

            YemeklerForm yemeklerForm = new YemeklerForm();
            yemeklerForm.Show();
        }

        private void btnYemekPlani_Click(object sender, EventArgs e)
        {
            YemekPlaniForm yemekPlaniForm = new YemekPlaniForm();
            yemekPlaniForm.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporForm raporForm = new RaporForm();
            raporForm.Show();

        }
    }
}
