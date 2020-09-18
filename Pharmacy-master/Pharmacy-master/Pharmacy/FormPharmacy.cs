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
    public partial class FormPharmacy : Form
    {
         public FormPharmacy()
        {
            InitializeComponent();
            ShowPharmacy();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Pharmacies pharmacies = new Pharmacies();
            pharmacies.Title = textBoxTitle.Text;
            pharmacies.address = textBoxAddress.Text;
            pharmacies.phone = textBoxPhone.Text;
            pharmacies.office_hours = textBoxOffice_Hours.Text;
            Program.db.Pharmacies.Add(pharmacies);
            Program.db.SaveChanges();
            ShowPharmacy();
        }
        void ShowPharmacy()
        {
            listViewPharmacy.Items.Clear();
            //проход о коллекции клиентов, в базе данных
            foreach (Pharmacies pharmacy in Program.db.Pharmacies)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        pharmacy.id_pharmacy.ToString(), pharmacy.Title, pharmacy.address, pharmacy.phone, pharmacy.office_hours
                    });
                item.Tag = pharmacy;
                listViewPharmacy.Items.Add(item);
            }
            listViewPharmacy.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                Pharmacies pharmacy = listViewPharmacy.SelectedItems[0].Tag as Pharmacies;
                textBoxTitle.Text = pharmacy.Title;
                textBoxAddress.Text = pharmacy.address;
                textBoxPhone.Text = pharmacy.phone;
                textBoxOffice_Hours.Text = pharmacy.office_hours;
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                textBoxOffice_Hours.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                Pharmacies pharmacies = listViewPharmacy.SelectedItems[0].Tag as Pharmacies;
                pharmacies.Title = textBoxTitle.Text;
                pharmacies.address = textBoxAddress.Text;
                pharmacies.phone = textBoxPhone.Text;
                pharmacies.office_hours = textBoxOffice_Hours.Text;
                Program.db.SaveChanges();
                ShowPharmacy();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                Pharmacies pharmacies = listViewPharmacy.SelectedItems[0].Tag as Pharmacies;
                Program.db.Pharmacies.Remove(pharmacies);
                Program.db.SaveChanges();
                ShowPharmacy();
            }
        }
        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }
    }
}
