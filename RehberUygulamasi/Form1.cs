using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace RehberUygulamasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbRehber;Integrated Security=True");

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadDataTable();
		}

		public void LoadDataTable()
		{
			baglanti.Open();
			SqlDataAdapter da = new SqlDataAdapter("select * from TblRehber", baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			baglanti.Close();
		}

		//DB'ye veri kaydetme
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TblRehber (AD,SOYAD,TELEFON, MAIL) values (@p1, @p2, @p3, @p4)",baglanti);
			komut.Parameters.AddWithValue("@p1", TxtAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
			komut.Parameters.AddWithValue("@p4", TxtMail.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kayıt başarı ile gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			AlanTemizle();
			LoadDataTable();
		}



		public void AlanTemizle()
		{
			TxtID.Clear();
			TxtAd.Clear();
			TxtSoyad.Clear();
			MskTelefon.Clear();
			TxtMail.Clear();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			MskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			TxtID.Enabled = false;
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("update TblRehber set AD=@p1, SOYAD=@p2, MAIL=@p3, TELEFON=@p4 where ID=@p5",baglanti);
			komut.Parameters.AddWithValue("@p1", TxtAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", TxtMail.Text);
			komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
			komut.Parameters.AddWithValue("@p5", TxtID.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Güncelleme işlemi başarı ile gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			LoadDataTable();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("delete from TblRehber where ID=@p1",baglanti);
			komut.Parameters.AddWithValue("@p1", TxtID.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Silme işlemi başarı ile gerçekleşti!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			AlanTemizle();
			LoadDataTable();
		}
	}
}
