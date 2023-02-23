namespace RehberUygulamasi
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.LblId = new System.Windows.Forms.Label();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.TxtMail = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(532, 331);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rehber";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BtnSil);
			this.groupBox2.Controls.Add(this.BtnKaydet);
			this.groupBox2.Controls.Add(this.BtnGuncelle);
			this.groupBox2.Controls.Add(this.MskTelefon);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.TxtMail);
			this.groupBox2.Controls.Add(this.TxtSoyad);
			this.groupBox2.Controls.Add(this.TxtAd);
			this.groupBox2.Controls.Add(this.TxtID);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.LblId);
			this.groupBox2.Location = new System.Drawing.Point(550, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(363, 331);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Yeni Kişi";
			// 
			// LblId
			// 
			this.LblId.AutoSize = true;
			this.LblId.Location = new System.Drawing.Point(17, 37);
			this.LblId.Name = "LblId";
			this.LblId.Size = new System.Drawing.Size(33, 19);
			this.LblId.TabIndex = 0;
			this.LblId.Text = "ID:";
			// 
			// TxtID
			// 
			this.TxtID.Location = new System.Drawing.Point(116, 34);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(218, 26);
			this.TxtID.TabIndex = 6;
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Font = new System.Drawing.Font("Calisto MT", 10F);
			this.BtnGuncelle.Location = new System.Drawing.Point(116, 221);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(105, 35);
			this.BtnGuncelle.TabIndex = 7;
			this.BtnGuncelle.Text = "GUNCELLE";
			this.BtnGuncelle.UseVisualStyleBackColor = true;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.GridColor = System.Drawing.Color.Cornsilk;
			this.dataGridView1.Location = new System.Drawing.Point(3, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(526, 306);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "AD:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "TELEFON:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "MAIL:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "SOYAD:";
			// 
			// MskTelefon
			// 
			this.MskTelefon.Location = new System.Drawing.Point(116, 163);
			this.MskTelefon.Mask = "(599) 000 00 00";
			this.MskTelefon.Name = "MskTelefon";
			this.MskTelefon.Size = new System.Drawing.Size(218, 26);
			this.MskTelefon.TabIndex = 3;
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(116, 66);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(218, 26);
			this.TxtAd.TabIndex = 0;
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(229, 221);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(105, 35);
			this.BtnSil.TabIndex = 8;
			this.BtnSil.Text = "SIL";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(116, 261);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(218, 35);
			this.BtnKaydet.TabIndex = 4;
			this.BtnKaydet.Text = "KAYDET";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(116, 99);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(218, 26);
			this.TxtSoyad.TabIndex = 1;
			// 
			// TxtMail
			// 
			this.TxtMail.Location = new System.Drawing.Point(116, 131);
			this.TxtMail.Name = "TxtMail";
			this.TxtMail.Size = new System.Drawing.Size(218, 26);
			this.TxtMail.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.ClientSize = new System.Drawing.Size(925, 355);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Form1";
			this.Text = "Telefon Rehberi";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.MaskedTextBox MskTelefon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblId;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.TextBox TxtMail;
	}
}

