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
    public partial class FormAvailability_Of_Medicines : Form
    {
        public FormAvailability_Of_Medicines()
        {
            InitializeComponent();
            ShowMedicine();
            ShowPharmacy();
            ShowAvailability();
        }
        void ShowMedicine()
        {
            comboBoxMedicine.Items.Clear();
            foreach (Medicines medicines in Program.db.Medicines)
            {
                string[] item = { medicines.id_medicine.ToString() + ":", medicines.title, medicines.form_lease};
                comboBoxMedicine.Items.Add(string.Join(" ", item));
            }
        }
        void ShowPharmacy()
        {
            comboBoxPharmacy.Items.Clear();
            foreach (Pharmacies pharmacies in Program.db.Pharmacies)
            {
                string[] item = { pharmacies.id_pharmacy.ToString() + ":", pharmacies.Title, pharmacies.address };
                comboBoxPharmacy.Items.Add(string.Join(" ", item));
            }
        }
        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }
        private void ComboBoxPressFalse(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (num == e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Аvailability аvailability = new Аvailability();
            аvailability.id_medicine = Convert.ToInt32(comboBoxMedicine.Text.Split(':')[0]);
            аvailability.quantity = textBoxQuantity.Text;
            аvailability.price = textBoxPrice.Text;
            аvailability.id_pharmacy = Convert.ToInt32(comboBoxPharmacy.Text.Split(':')[0]);
            Program.db.Аvailability.Add(аvailability);
            Program.db.SaveChanges();
            ShowAvailability();
        }
        void ShowAvailability()
        {
            listViewAvailability.Items.Clear();
            //проход о коллекции клиентов, в базе данных
            foreach (Аvailability аvailability in Program.db.Аvailability)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        аvailability.id_availability.ToString(), аvailability.Medicines.title +" "+ аvailability.Medicines.form_lease, аvailability.quantity, аvailability.price, аvailability.Pharmacies.Title +" "+ аvailability.Pharmacies.address
                    });
                item.Tag = pharmacy;
                listViewAvailability.Items.Add(item);
            }
            listViewAvailability.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                Аvailability аvailability = listViewAvailability.SelectedItems[0].Tag as Аvailability;
                аvailability.id_medicine = Convert.ToInt32(comboBoxMedicine.Text.Split(':')[0]);
                аvailability.quantity = textBoxQuantity.Text;
                аvailability.price = textBoxPrice.Text;
                аvailability.id_pharmacy = Convert.ToInt32(comboBoxPharmacy.Text.Split(':')[0]);
                Program.db.SaveChanges();
                ShowAvailability();
            }
        }

        private void listViewAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                Аvailability availability = listViewAvailability.SelectedItems[0].Tag as Аvailability;
                comboBoxMedicine.SelectedIndex = comboBoxMedicine.FindString(availability.id_medicine.ToString());
                comboBoxPharmacy.SelectedIndex = comboBoxPharmacy.FindString(availability.id_pharmacy.ToString());
                textBoxPrice.Text = availability.price;
                textBoxQuantity.Text = availability.quantity;
            }
            else
            {
                Аvailability availability = listViewAvailability.SelectedItems[0].Tag as Аvailability;
                comboBoxMedicine.SelectedIndex = 0;
                comboBoxPharmacy.SelectedIndex = 0;
                textBoxPrice.Text = "";
                textBoxQuantity.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                Аvailability availability = listViewAvailability.SelectedItems[0].Tag as Аvailability;
                Program.db.Аvailability.Remove(availability);
                Program.db.SaveChanges();
                ShowAvailability();
            }
        }
    }
}
