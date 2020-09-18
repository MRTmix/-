namespace Pharmacy
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMedicinies = new System.Windows.Forms.Button();
            this.buttonPharmasy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonaAvailability_Of_Medicines = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMedicinies
            // 
            this.buttonMedicinies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonMedicinies.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonMedicinies.Location = new System.Drawing.Point(50, 205);
            this.buttonMedicinies.Name = "buttonMedicinies";
            this.buttonMedicinies.Size = new System.Drawing.Size(107, 55);
            this.buttonMedicinies.TabIndex = 0;
            this.buttonMedicinies.Text = "Лекарства";
            this.buttonMedicinies.UseVisualStyleBackColor = false;
            this.buttonMedicinies.Click += new System.EventHandler(this.buttonMedicinies_Click);
            // 
            // buttonPharmasy
            // 
            this.buttonPharmasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonPharmasy.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonPharmasy.Location = new System.Drawing.Point(50, 133);
            this.buttonPharmasy.Name = "buttonPharmasy";
            this.buttonPharmasy.Size = new System.Drawing.Size(107, 55);
            this.buttonPharmasy.TabIndex = 1;
            this.buttonPharmasy.Text = "Аптеки";
            this.buttonPharmasy.UseVisualStyleBackColor = false;
            this.buttonPharmasy.Click += new System.EventHandler(this.buttonPharmasy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buttonaAvailability_Of_Medicines
            // 
            this.buttonaAvailability_Of_Medicines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonaAvailability_Of_Medicines.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonaAvailability_Of_Medicines.Location = new System.Drawing.Point(50, 276);
            this.buttonaAvailability_Of_Medicines.Name = "buttonaAvailability_Of_Medicines";
            this.buttonaAvailability_Of_Medicines.Size = new System.Drawing.Size(107, 55);
            this.buttonaAvailability_Of_Medicines.TabIndex = 16;
            this.buttonaAvailability_Of_Medicines.Text = "Наличие лекарств";
            this.buttonaAvailability_Of_Medicines.UseVisualStyleBackColor = false;
            this.buttonaAvailability_Of_Medicines.Click += new System.EventHandler(this.buttonaAvailability_Of_Medicines_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(214, 373);
            this.Controls.Add(this.buttonaAvailability_Of_Medicines);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPharmasy);
            this.Controls.Add(this.buttonMedicinies);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аптека";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMedicinies;
        private System.Windows.Forms.Button buttonPharmasy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonaAvailability_Of_Medicines;
    }
}

