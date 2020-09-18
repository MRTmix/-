namespace Pharmacy
{
    partial class MediciniesForm
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
            this.listViewMedicines = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.form_lease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shelf_life = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelForm_Lease = new System.Windows.Forms.Label();
            this.textBoxForm_Lease = new System.Windows.Forms.TextBox();
            this.labelDosage = new System.Windows.Forms.Label();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.labelShelf_Life = new System.Windows.Forms.Label();
            this.textBoxShel_Life = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMedicines
            // 
            this.listViewMedicines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.title,
            this.form_lease,
            this.dosage,
            this.manufacturer,
            this.shelf_life});
            this.listViewMedicines.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMedicines.GridLines = true;
            this.listViewMedicines.HideSelection = false;
            this.listViewMedicines.Location = new System.Drawing.Point(287, 107);
            this.listViewMedicines.Name = "listViewMedicines";
            this.listViewMedicines.Size = new System.Drawing.Size(501, 267);
            this.listViewMedicines.TabIndex = 0;
            this.listViewMedicines.UseCompatibleStateImageBehavior = false;
            this.listViewMedicines.View = System.Windows.Forms.View.Details;
            this.listViewMedicines.SelectedIndexChanged += new System.EventHandler(this.listViewMedicines_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 46;
            // 
            // title
            // 
            this.title.Text = "Название";
            this.title.Width = 84;
            // 
            // form_lease
            // 
            this.form_lease.Text = "Форма выпуска";
            this.form_lease.Width = 98;
            // 
            // dosage
            // 
            this.dosage.Text = "Дозировка";
            this.dosage.Width = 77;
            // 
            // manufacturer
            // 
            this.manufacturer.Text = "Производитель";
            this.manufacturer.Width = 99;
            // 
            // shelf_life
            // 
            this.shelf_life.Text = "Срок годности";
            this.shelf_life.Width = 93;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(12, 85);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 26);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(9, 64);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(68, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Название";
            // 
            // labelForm_Lease
            // 
            this.labelForm_Lease.AutoSize = true;
            this.labelForm_Lease.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForm_Lease.Location = new System.Drawing.Point(9, 128);
            this.labelForm_Lease.Name = "labelForm_Lease";
            this.labelForm_Lease.Size = new System.Drawing.Size(106, 18);
            this.labelForm_Lease.TabIndex = 4;
            this.labelForm_Lease.Text = "Форма выпуска";
            // 
            // textBoxForm_Lease
            // 
            this.textBoxForm_Lease.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForm_Lease.Location = new System.Drawing.Point(12, 149);
            this.textBoxForm_Lease.Name = "textBoxForm_Lease";
            this.textBoxForm_Lease.Size = new System.Drawing.Size(100, 26);
            this.textBoxForm_Lease.TabIndex = 3;
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDosage.Location = new System.Drawing.Point(9, 193);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(77, 18);
            this.labelDosage.TabIndex = 6;
            this.labelDosage.Text = "Дозировка";
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDosage.Location = new System.Drawing.Point(12, 214);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(100, 26);
            this.textBoxDosage.TabIndex = 5;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.Location = new System.Drawing.Point(9, 266);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(107, 18);
            this.labelManufacturer.TabIndex = 8;
            this.labelManufacturer.Text = "Производитель";
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxManufacturer.Location = new System.Drawing.Point(12, 287);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(100, 26);
            this.textBoxManufacturer.TabIndex = 7;
            // 
            // labelShelf_Life
            // 
            this.labelShelf_Life.AutoSize = true;
            this.labelShelf_Life.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShelf_Life.Location = new System.Drawing.Point(142, 59);
            this.labelShelf_Life.Name = "labelShelf_Life";
            this.labelShelf_Life.Size = new System.Drawing.Size(99, 18);
            this.labelShelf_Life.TabIndex = 10;
            this.labelShelf_Life.Text = "Срок годности";
            // 
            // textBoxShel_Life
            // 
            this.textBoxShel_Life.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShel_Life.Location = new System.Drawing.Point(145, 80);
            this.textBoxShel_Life.Name = "textBoxShel_Life";
            this.textBoxShel_Life.Size = new System.Drawing.Size(100, 26);
            this.textBoxShel_Life.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(287, 380);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 44);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(453, 380);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(129, 44);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(625, 380);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(129, 44);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(543, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MediciniesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelShelf_Life);
            this.Controls.Add(this.textBoxShel_Life);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.labelForm_Lease);
            this.Controls.Add(this.textBoxForm_Lease);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.listViewMedicines);
            this.Name = "MediciniesForm";
            this.Text = "Медикаменты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMedicines;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader form_lease;
        private System.Windows.Forms.ColumnHeader dosage;
        private System.Windows.Forms.ColumnHeader manufacturer;
        private System.Windows.Forms.ColumnHeader shelf_life;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelForm_Lease;
        private System.Windows.Forms.TextBox textBoxForm_Lease;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label labelShelf_Life;
        private System.Windows.Forms.TextBox textBoxShel_Life;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}