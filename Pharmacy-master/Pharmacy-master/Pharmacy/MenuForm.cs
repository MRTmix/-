using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonMedicinies_Click(object sender, EventArgs e)
        {
            Form formMedicine = new MediciniesForm();
            formMedicine.Show();
        }

        private void buttonPharmasy_Click(object sender, EventArgs e)
        {
            FormPharmacy form = new FormPharmacy();
            form.Show();
        }

        private void buttonaAvailability_Of_Medicines_Click(object sender, EventArgs e)
        {
            FormAvailability_Of_Medicines form = new FormAvailability_Of_Medicines();
            form.Show();
        }
    }
}
