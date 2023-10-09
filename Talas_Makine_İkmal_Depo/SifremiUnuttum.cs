using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talas_Makine_İkmal_Depo
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        BaglantiSinifi bgl = new BaglantiSinifi();
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VDBH89Q\SQLEXPRESS;Initial Catalog=TalasMakineİkmalDepo;Integrated Security=True");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (
                  txtKullaniciAdi.Text == "" || txtSifre.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || cbxGuvenlikSorusu.Text == "" || txtID.Text == "" ||
                  txtKullaniciAdi.Text == String.Empty || txtSifre.Text == String.Empty || txtAdi.Text == String.Empty || txtSoyadi.Text == String.Empty || cbxGuvenlikSorusu.Text == String.Empty || txtID.Text == String.Empty
               )
            {
                txtKullaniciAdi.BackColor = Color.Yellow;
                txtSifre.BackColor = Color.Yellow;
                txtAdi.BackColor = Color.Yellow;
                txtSoyadi.BackColor = Color.Yellow;
                cbxGuvenlikSorusu.BackColor = Color.Yellow;
                txtSorununCevabi.BackColor = Color.Yellow;
                txtID.BackColor = Color.Yellow;
                MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Tbl_KullaniciGirisi set KULLANICIADI=@P1, SIFRE=@P2, ADI=@P3, SOYADI=@P4, GUVENLIKSORUSU=@P5, SORUNUNCEVABI=@P6 WHERE ID=@P7", baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.Parameters.AddWithValue("@p3", txtAdi.Text);
                komut.Parameters.AddWithValue("@p4", txtSoyadi.Text);
                komut.Parameters.AddWithValue("@p5", cbxGuvenlikSorusu.Text);
                komut.Parameters.AddWithValue("@p6", txtSorununCevabi.Text);
                komut.Parameters.AddWithValue("@p7", txtID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void FrmSifremiUnuttum_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
