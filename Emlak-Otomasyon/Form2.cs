using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Emlak_Otomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-T2GKN5C\\SQLEXPRESS;Initial Catalog=Siteler;Integrated Security=True");
        private void Goruntule()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select*from sitebilgi", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }
        private void kytd()
        {
            

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbboxsite.Text == "Kırlangıç")
            {
                btnkırlnagıc.BackColor = Color.Yellow;
            }
            if (cmbboxsite.Text == "Masmavi")
            {
                btnmasmavi.BackColor = Color.Yellow;
            }
            if (cmbboxsite.Text == "Bahtiyarlar")
            {
                btnbahtiyar.BackColor = Color.Yellow;
            }
            if (cmbboxsite.Text == "Asır")
            {
                btnasır.BackColor = Color.Yellow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Goruntule();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into sitebilgi (id,site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,setkira) values( '" + txtid.Text.ToString() +
                "','" + cmbboxsite.Text.ToString() + "','" + cmboxoda.Text.ToString() + "','" + txtmertekare.Text.ToString() + "','" + txtfiyat.Text.ToString() + "','" + cmbboxblok.Text.ToString() +
                "','" + txtdaireno.Text.ToString() + "','" + txtad.Text.ToString() + "','" + txttel.Text.ToString() + "','" + txtnot.Text.ToString() + "','" + cmbboxsatkira.Text.ToString());
            komut.ExecuteNonQuery();
            baglantı.Close();
            Goruntule();
        }
    }
}
