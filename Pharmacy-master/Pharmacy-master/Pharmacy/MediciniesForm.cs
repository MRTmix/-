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
    public partial class MediciniesForm : Form
    {
        public MediciniesForm()
        {
            InitializeComponent();
            ShowMedicines();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Medicines medicines = new Medicines();
            medicines.title = textBoxTitle.Text;
            medicines.form_lease = textBoxForm_Lease.Text;
            medicines.dosage = textBoxDosage.Text;
            medicines.manufacturer = textBoxManufacturer.Text;
            medicines.shelf_life = textBoxShel_Life.Text;
            Program.db.Medicines.Add(medicines);
            Program.db.SaveChanges();
            ShowMedicines();
        }
        void ShowMedicines()
        {
            listViewMedicines.Items.Clear();
            //проход о коллекции клиентов, в базе данных
            foreach (Medicines medicines in Program.db.Medicines)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        medicines.id_medicine.ToString(), medicines.title, medicines.form_lease, medicines.dosage, medicines.manufacturer, medicines.shelf_life
                    });
                item.Tag = medicines;
                listViewMedicines.Items.Add(item);
            }
            listViewMedicines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMedicines.SelectedItems.Count == 1)
            {
                Medicines medicines = listViewMedicines.SelectedItems[0].Tag as Medicines;
                textBoxTitle.Text = medicines.title;
                textBoxDosage.Text = medicines.dosage;
                textBoxManufacturer.Text = medicines.manufacturer;
                textBoxForm_Lease.Text = medicines.form_lease;
                textBoxShel_Life.Text = medicines.shelf_life;
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxDosage.Text = "";
                textBoxManufacturer.Text = "";
                textBoxForm_Lease.Text = "";
                textBoxShel_Life.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMedicines.SelectedItems.Count == 1)
            {
                Medicines medicines = listViewMedicines.SelectedItems[0].Tag as Medicines;
                medicines.title = textBoxTitle.Text;
                medicines.form_lease = textBoxForm_Lease.Text;
                medicines.dosage = textBoxDosage.Text;
                medicines.manufacturer = textBoxManufacturer.Text;
                medicines.shelf_life = textBoxShel_Life.Text;
                Program.db.SaveChanges();
                ShowMedicines();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewMedicines.SelectedItems.Count == 1)
            {
                Medicines medicines = listViewMedicines.SelectedItems[0].Tag as Medicines;
                Program.db.Medicines.Remove(medicines);
                Program.db.SaveChanges();
                ShowMedicines();
            }
        }
    }
}
