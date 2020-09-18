namespace Pharmacy
{
    partial class FormAvailability_Of_Medicines
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPharmacy = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelMedicine = new System.Windows.Forms.Label();
            this.listViewAvailability = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pharmacy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxMedicine = new System.Windows.Forms.ComboBox();
            this.comboBoxPharmacy = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(627, 393);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(129, 44);
            this.buttonDel.TabIndex = 41;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(455, 393);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(129, 44);
            this.buttonEdit.TabIndex = 40;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(289, 393);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 44);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPharmacy
            // 
            this.labelPharmacy.AutoSize = true;
            this.labelPharmacy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPharmacy.Location = new System.Drawing.Point(11, 279);
            this.labelPharmacy.Name = "labelPharmacy";
            this.labelPharmacy.Size = new System.Drawing.Size(53, 18);
            this.labelPharmacy.TabIndex = 38;
            this.labelPharmacy.Text = "Аптека";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(11, 206);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 18);
            this.labelPrice.TabIndex = 36;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(14, 227);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 26);
            this.textBoxPrice.TabIndex = 35;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(11, 141);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(82, 18);
            this.labelQuantity.TabIndex = 34;
            this.labelQuantity.Text = "Количество";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity.Location = new System.Drawing.Point(14, 162);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 26);
            this.textBoxQuantity.TabIndex = 33;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelMedicine
            // 
            this.labelMedicine.AutoSize = true;
            this.labelMedicine.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedicine.Location = new System.Drawing.Point(11, 77);
            this.labelMedicine.Name = "labelMedicine";
            this.labelMedicine.Size = new System.Drawing.Size(74, 18);
            this.labelMedicine.TabIndex = 32;
            this.labelMedicine.Text = "Лекарство";
            // 
            // listViewAvailability
            // 
            this.listViewAvailability.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Medicine,
            this.quantity,
            this.price,
            this.pharmacy});
            this.listViewAvailability.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAvailability.GridLines = true;
            this.listViewAvailability.HideSelection = false;
            this.listViewAvailability.Location = new System.Drawing.Point(289, 120);
            this.listViewAvailability.Name = "listViewAvailability";
            this.listViewAvailability.Size = new System.Drawing.Size(501, 267);
            this.listViewAvailability.TabIndex = 30;
            this.listViewAvailability.UseCompatibleStateImageBehavior = false;
            this.listViewAvailability.View = System.Windows.Forms.View.Details;
            this.listViewAvailability.SelectedIndexChanged += new System.EventHandler(this.listViewAvailability_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 46;
            // 
            // Medicine
            // 
            this.Medicine.Text = "Лекарство";
            this.Medicine.Width = 84;
            // 
            // quantity
            // 
            this.quantity.Text = "Количество";
            this.quantity.Width = 98;
            // 
            // price
            // 
            this.price.Text = "Цена";
            this.price.Width = 77;
            // 
            // pharmacy
            // 
            this.pharmacy.Text = "Аптека";
            this.pharmacy.Width = 129;
            // 
            // comboBoxMedicine
            // 
            this.comboBoxMedicine.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.comboBoxMedicine.FormattingEnabled = true;
            this.comboBoxMedicine.Location = new System.Drawing.Point(14, 99);
            this.comboBoxMedicine.Name = "comboBoxMedicine";
            this.comboBoxMedicine.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMedicine.TabIndex = 43;
            this.comboBoxMedicine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxPressFalse);
            // 
            // comboBoxPharmacy
            // 
            this.comboBoxPharmacy.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.comboBoxPharmacy.FormattingEnabled = true;
            this.comboBoxPharmacy.Location = new System.Drawing.Point(12, 300);
            this.comboBoxPharmacy.Name = "comboBoxPharmacy";
            this.comboBoxPharmacy.Size = new System.Drawing.Size(121, 26);
            this.comboBoxPharmacy.TabIndex = 44;
            this.comboBoxPharmacy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxPressFalse);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(545, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FormAvailability_Of_Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPharmacy);
            this.Controls.Add(this.comboBoxMedicine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPharmacy);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelMedicine);
            this.Controls.Add(this.listViewAvailability);
            this.Name = "FormAvailability_Of_Medicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAvailability_Of_Medicines";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPharmacy;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelMedicine;
        private System.Windows.Forms.ListView listViewAvailability;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Medicine;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader pharmacy;
        private System.Windows.Forms.ComboBox comboBoxMedicine;
        private System.Windows.Forms.ComboBox comboBoxPharmacy;
    }
}