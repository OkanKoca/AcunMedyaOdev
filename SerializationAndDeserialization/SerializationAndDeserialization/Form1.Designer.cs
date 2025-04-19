namespace SerializationAndDeserialization
{
    partial class Form1
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
            this.labelAd = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelDepartman = new System.Windows.Forms.Label();
            this.labelMaas = new System.Windows.Forms.Label();
            this.labelDogum = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxDepartman = new System.Windows.Forms.TextBox();
            this.textBoxMaas = new System.Windows.Forms.TextBox();
            this.dateTimePickerDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnJsonSerialize = new System.Windows.Forms.Button();
            this.btnJsonDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(109, 49);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(20, 13);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "Ad";
            this.labelAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(109, 93);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 1;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelDepartman
            // 
            this.labelDepartman.AutoSize = true;
            this.labelDepartman.Location = new System.Drawing.Point(109, 135);
            this.labelDepartman.Name = "labelDepartman";
            this.labelDepartman.Size = new System.Drawing.Size(59, 13);
            this.labelDepartman.TabIndex = 2;
            this.labelDepartman.Text = "Departman";
            // 
            // labelMaas
            // 
            this.labelMaas.AutoSize = true;
            this.labelMaas.Location = new System.Drawing.Point(109, 235);
            this.labelMaas.Name = "labelMaas";
            this.labelMaas.Size = new System.Drawing.Size(33, 13);
            this.labelMaas.TabIndex = 3;
            this.labelMaas.Text = "Maaş";
            this.labelMaas.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDogum
            // 
            this.labelDogum.AutoSize = true;
            this.labelDogum.Location = new System.Drawing.Point(109, 187);
            this.labelDogum.Name = "labelDogum";
            this.labelDogum.Size = new System.Drawing.Size(70, 13);
            this.labelDogum.TabIndex = 4;
            this.labelDogum.Text = "Doğum Tarihi";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(203, 49);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(170, 20);
            this.textBoxAd.TabIndex = 5;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(203, 93);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(170, 20);
            this.textBoxTelefon.TabIndex = 6;
            // 
            // textBoxDepartman
            // 
            this.textBoxDepartman.Location = new System.Drawing.Point(203, 132);
            this.textBoxDepartman.Name = "textBoxDepartman";
            this.textBoxDepartman.Size = new System.Drawing.Size(170, 20);
            this.textBoxDepartman.TabIndex = 7;
            // 
            // textBoxMaas
            // 
            this.textBoxMaas.Location = new System.Drawing.Point(203, 232);
            this.textBoxMaas.Name = "textBoxMaas";
            this.textBoxMaas.Size = new System.Drawing.Size(170, 20);
            this.textBoxMaas.TabIndex = 9;
            // 
            // dateTimePickerDogumTarihi
            // 
            this.dateTimePickerDogumTarihi.Location = new System.Drawing.Point(203, 181);
            this.dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            this.dateTimePickerDogumTarihi.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerDogumTarihi.TabIndex = 10;
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(203, 293);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnSerialize.TabIndex = 11;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(298, 293);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize.TabIndex = 12;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnJsonSerialize
            // 
            this.btnJsonSerialize.Location = new System.Drawing.Point(203, 342);
            this.btnJsonSerialize.Name = "btnJsonSerialize";
            this.btnJsonSerialize.Size = new System.Drawing.Size(75, 35);
            this.btnJsonSerialize.TabIndex = 13;
            this.btnJsonSerialize.Text = "Json Serialize";
            this.btnJsonSerialize.UseVisualStyleBackColor = true;
            this.btnJsonSerialize.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnJsonDeserialize
            // 
            this.btnJsonDeserialize.Location = new System.Drawing.Point(298, 342);
            this.btnJsonDeserialize.Name = "btnJsonDeserialize";
            this.btnJsonDeserialize.Size = new System.Drawing.Size(75, 35);
            this.btnJsonDeserialize.TabIndex = 14;
            this.btnJsonDeserialize.Text = "Json Deserialize";
            this.btnJsonDeserialize.UseVisualStyleBackColor = true;
            this.btnJsonDeserialize.Click += new System.EventHandler(this.btnJsonDeserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonDeserialize);
            this.Controls.Add(this.btnJsonSerialize);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.dateTimePickerDogumTarihi);
            this.Controls.Add(this.textBoxMaas);
            this.Controls.Add(this.textBoxDepartman);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelDogum);
            this.Controls.Add(this.labelMaas);
            this.Controls.Add(this.labelDepartman);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelDepartman;
        private System.Windows.Forms.Label labelMaas;
        private System.Windows.Forms.Label labelDogum;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxDepartman;
        private System.Windows.Forms.TextBox textBoxMaas;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarihi;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnJsonSerialize;
        private System.Windows.Forms.Button btnJsonDeserialize;
    }
}

