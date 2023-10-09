using QRCoder;
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

namespace Talas_Makine_İkmal_Depo
{
    public partial class FrmMalzemeKaydi : Form
    {
        public FrmMalzemeKaydi()
        {
            InitializeComponent();
        }

        BaglantiSinifi bgl = new BaglantiSinifi();

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaMenu fr = new FrmAnaMenu();
            fr.Show();
            this.Hide();
        }

        void Listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_MalzemeKayit", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (
                  dTPGirisTarihi.Text == "" || txtMalzemeAdi.Text == "" || txtGrubu.Text == "" || txtBirim.Text == "" || txtMiktar.Text == "" || txtTeslimEden.Text == "" || txtTeslimAlan.Text == "" || txtFirma.Text == "" ||
                  dTPGirisTarihi.Text == string.Empty || txtMalzemeAdi.Text == string.Empty || txtGrubu.Text == string.Empty || txtBirim.Text == string.Empty || txtMiktar.Text == string.Empty || txtTeslimEden.Text == string.Empty || txtTeslimAlan.Text == string.Empty || txtFirma.Text == string.Empty  
               )
            {
                dTPGirisTarihi.BackColor = Color.Yellow;
                txtMalzemeAdi.BackColor = Color.Yellow;
                txtGrubu.BackColor = Color.Yellow;
                txtBirim.BackColor = Color.Yellow;
                txtMiktar.BackColor = Color.Yellow;
                txtTeslimEden.BackColor = Color.Yellow;
                txtTeslimAlan.BackColor = Color.Yellow;
                txtFirma.BackColor = Color.Yellow;                               
                MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtCikisMalzemeAdi.Text = txtMalzemeAdi.Text;
                txtCikisGrubu.Text = txtGrubu.Text;
                txtCikisMiktar.Text = txtMiktar.Text;
                txtCikisBirim.Text = txtBirim.Text;
                txtCikisTeslimEden.Text = txtTeslimEden.Text;
                txtCikisTeslimAlan.Text = txtTeslimAlan.Text;
                SqlConnection baglanti = new SqlConnection(bgl.Adres);               
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_MalzemeKayit (GIRISTARIHI,MALZEMEADI,GRUB,MIKTAR,BIRIM,TESLIMEDEN,TESLIMALAN,FIRMA,CIKISMALZEMEADI,CIKISGRUB,CIKISMIKTAR,CIKISBIRIM,CIKISTESLIMEDEN,CIKISTESLIMALAN,KULLANIMYERI,MUDURLUK,MALZEMERESMI) " +
                                                  "VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)", baglanti);
                komut.Parameters.AddWithValue("@p1", dTPGirisTarihi.Text);
                komut.Parameters.AddWithValue("@p2", txtMalzemeAdi.Text);
                komut.Parameters.AddWithValue("@p3", txtGrubu.Text);
                komut.Parameters.AddWithValue("@p4", txtMiktar.Text);
                komut.Parameters.AddWithValue("@p5", txtBirim.Text);
                komut.Parameters.AddWithValue("@p6", txtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p7", txtTeslimAlan.Text);
                komut.Parameters.AddWithValue("@p8", txtFirma.Text);
                komut.Parameters.AddWithValue("@p9", txtCikisMalzemeAdi.Text);
                komut.Parameters.AddWithValue("@p10", txtCikisGrubu.Text);
                komut.Parameters.AddWithValue("@p11", txtCikisMiktar.Text);
                komut.Parameters.AddWithValue("@p12", txtCikisBirim.Text);
                komut.Parameters.AddWithValue("@p13", txtCikisTeslimEden.Text);
                komut.Parameters.AddWithValue("@p14", txtCikisTeslimAlan.Text);
                komut.Parameters.AddWithValue("@p15", txtKullanimYeri.Text);
                komut.Parameters.AddWithValue("@p16", txtMudurluk.Text);
                komut.Parameters.AddWithValue("@p17", txtResim.Text);
                komut.ExecuteNonQuery();                
                Listele();
                baglanti.Close();
                MessageBox.Show("Sisteme Kaydedildi ve QR Kod Oluşturuldu", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //txtCikisMalzemeAdi.Text = txtMalzemeAdi.Text;
                //txtCikisGrubu.Text = txtGrubu.Text;
                //txtCikisMiktar.Text = txtMiktar.Text;
                //txtCikisBirim.Text = txtBirim.Text;
                //txtCikisTeslimEden.Text = txtTeslimEden.Text;
                //txtCikisTeslimAlan.Text = txtTeslimAlan.Text;

                //txtMalzemeAdi.Text = "";
                //txtGrubu.Text = "";
                //txtMiktar.Text = "";
                //txtBirim.Text = "";
                //txtTeslimEden.Text = "";
                //txtTeslimAlan.Text = "";

                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("insert into Tbl_Raporlama (GIRISTARIHI,MALZEMEADI,GRUB,MIKTAR,BIRIM,TESLIMEDEN,TESLIMALAN,FIRMA,CIKISMALZEMEADI,CIKISGRUB,CIKISMIKTAR,CIKISBIRIM,CIKISTESLIMEDEN,CIKISTESLIMALAN,KULLANIMYERI,MUDURLUK,MALZEMERESMI) " +
                                                  "VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)", baglanti);
                komut1.Parameters.AddWithValue("@p1", dTPGirisTarihi.Text);
                komut1.Parameters.AddWithValue("@p2", txtMalzemeAdi.Text);
                komut1.Parameters.AddWithValue("@p3", txtGrubu.Text);
                komut1.Parameters.AddWithValue("@p4", txtMiktar.Text);
                komut1.Parameters.AddWithValue("@p5", txtBirim.Text);
                komut1.Parameters.AddWithValue("@p6", txtTeslimEden.Text);
                komut1.Parameters.AddWithValue("@p7", txtTeslimAlan.Text);
                komut1.Parameters.AddWithValue("@p8", txtFirma.Text);
                komut1.Parameters.AddWithValue("@p9", txtCikisMalzemeAdi.Text);
                komut1.Parameters.AddWithValue("@p10", txtCikisGrubu.Text);
                komut1.Parameters.AddWithValue("@p11", txtCikisMiktar.Text);
                komut1.Parameters.AddWithValue("@p12", txtCikisBirim.Text);
                komut1.Parameters.AddWithValue("@p13", txtCikisTeslimEden.Text);
                komut1.Parameters.AddWithValue("@p14", txtCikisTeslimAlan.Text);
                komut1.Parameters.AddWithValue("@p15", txtKullanimYeri.Text);
                komut1.Parameters.AddWithValue("@p16", txtMudurluk.Text);
                komut1.Parameters.AddWithValue("@p17", txtResim.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();

                string str = "  - Malzeme Resmi: " + pictureBox1.ImageLocation + " \n " + "  - ID No: " + txtID.Text + " \n " + " - Giriş Tarihi: " + dTPGirisTarihi.Text + " \n " + " - Malzeme Adı: " + txtMalzemeAdi.Text + " \n " + " - Grubu: " + txtGrubu.Text + " \n " + " - Birim: " + txtBirim.Text + " \n " + " - Miktar: " + txtMiktar.Text + " \n " + " - Teslim Eden:" + txtTeslimEden.Text + " \n " + " - Teslim Alan: " + txtTeslimAlan.Text + " \n " + " - Firma: " + txtFirma.Text + " - Çıkış Tarihi: " + dTPCikisTarihi.Text + " \n " + " - Çıkan Malzemenin Adı: " + txtCikisMalzemeAdi.Text + " \n " + " - Çıkan Malzemenin Grubu: " + txtCikisGrubu.Text + " \n " + " - Çıkan Malzemenin Birimi: " + txtCikisMiktar.Text + " \n " + " - Çıkan Malzemenin Miktarı: " + txtCikisMiktar.Text + " \n " + " - Çıkan Malzemeyi Teslim Eden:" + txtCikisTeslimEden.Text + " \n " + " - Çıkan Malzemeyi Teslim Alan: " + txtCikisTeslimAlan.Text + " \n " + " \n " + " - Kullanım Yeri: " + txtKullanimYeri.Text + " \n " + " - Müdürlük: " + txtMudurluk.Text + " \n ";
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                pictureBox2.Image = qrCodeImage;

                SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.
                sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.
                sfd.Title = "qrCodeImage";//diğaloğumuzun başlığını belirliyoruz.
                sfd.FileName = "QR COD";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.
                DialogResult sonuç = sfd.ShowDialog();
                if (sonuç == DialogResult.OK)
                {
                    pictureBox2.Image.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Tbl_MalzemeKayit where MALZEMEID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", txtID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Sistemden Silindi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Delete from Tbl_Raporlama where MALZEMEID=@P1", baglanti);
            komut1.Parameters.AddWithValue("@P1", txtID.Text);
            komut1.ExecuteNonQuery();;
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tbl_MalzemeKayit set GIRISTARIHI=@P1, CIKISTARIHI=@P2, MALZEMEADI=@P3, GRUB=@P4, MIKTAR=@P5, BIRIM=@P6, TESLIMEDEN=@P7, TESLIMALAN=@P8, FIRMA=@P9, CIKISMALZEMEADI=@P10, CIKISGRUB=@P11, CIKISMIKTAR=@P12, CIKISBIRIM=@P13, CIKISTESLIMEDEN=@P14, CIKISTESLIMALAN=@P15, KULLANIMYERI=@P16, MUDURLUK=@P17, MALZEMERESMI=@P18 WHERE MALZEMEID=@P19 ", baglanti);
            komut.Parameters.AddWithValue("@p1", dTPGirisTarihi.Text);
            komut.Parameters.AddWithValue("@p2", dTPCikisTarihi.Text);
            komut.Parameters.AddWithValue("@p3", txtMalzemeAdi.Text);
            komut.Parameters.AddWithValue("@p4", txtGrubu.Text);
            komut.Parameters.AddWithValue("@p5", txtMiktar.Text);
            komut.Parameters.AddWithValue("@p6", txtBirim.Text);
            komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", txtFirma.Text);
            komut.Parameters.AddWithValue("@p10", txtCikisMalzemeAdi.Text);
            komut.Parameters.AddWithValue("@p11", txtCikisGrubu.Text);
            komut.Parameters.AddWithValue("@p12", txtCikisMiktar.Text);
            komut.Parameters.AddWithValue("@p13", txtCikisBirim.Text);
            komut.Parameters.AddWithValue("@p14", txtCikisTeslimEden.Text);
            komut.Parameters.AddWithValue("@p15", txtCikisTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p16", txtKullanimYeri.Text);
            komut.Parameters.AddWithValue("@p17", txtMudurluk.Text);
            komut.Parameters.AddWithValue("@p18", txtResim.Text);
            komut.Parameters.AddWithValue("@p19", txtID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Sistem Güncellendi", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update Tbl_Raporlama set GIRISTARIHI=@P1, CIKISTARIHI=@P2, MALZEMEADI=@P3, GRUB=@P4, MIKTAR=@P5, BIRIM=@P6, TESLIMEDEN=@P7, TESLIMALAN=@P8, FIRMA=@P9, CIKISMALZEMEADI=@P10, CIKISGRUB=@P11, CIKISMIKTAR=@P12, CIKISBIRIM=@P13, CIKISTESLIMEDEN=@P14, CIKISTESLIMALAN=@P15, KULLANIMYERI=@P16, MUDURLUK=@P17, MALZEMERESMI=@P18 WHERE MALZEMEID=@P19 ", baglanti);
            komut1.Parameters.AddWithValue("@p1", dTPGirisTarihi.Text);
            komut1.Parameters.AddWithValue("@p2", dTPCikisTarihi.Text);
            komut1.Parameters.AddWithValue("@p3", txtMalzemeAdi.Text);
            komut1.Parameters.AddWithValue("@p4", txtGrubu.Text);
            komut1.Parameters.AddWithValue("@p5", txtMiktar.Text);
            komut1.Parameters.AddWithValue("@p6", txtBirim.Text);
            komut1.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            komut1.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            komut1.Parameters.AddWithValue("@p9", txtFirma.Text);
            komut1.Parameters.AddWithValue("@p10", txtCikisMalzemeAdi.Text);
            komut1.Parameters.AddWithValue("@p11", txtCikisGrubu.Text);
            komut1.Parameters.AddWithValue("@p12", txtCikisMiktar.Text);
            komut1.Parameters.AddWithValue("@p13", txtCikisBirim.Text);
            komut1.Parameters.AddWithValue("@p14", txtCikisTeslimEden.Text);
            komut1.Parameters.AddWithValue("@p15", txtCikisTeslimAlan.Text);
            komut1.Parameters.AddWithValue("@p16", txtKullanimYeri.Text);
            komut1.Parameters.AddWithValue("@p17", txtMudurluk.Text);
            komut1.Parameters.AddWithValue("@p18", txtResim.Text);
            komut1.Parameters.AddWithValue("@p19", txtID.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void FrmMalzemeKaydi_Load(object sender, EventArgs e)
        {
            txtMalzemeAdi.Text = "";
            txtGrubu.Text = "";
            txtMiktar.Text = "";
            txtBirim.Text = "";
            txtTeslimEden.Text = "";
            txtTeslimAlan.Text = "";
            Listele();
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dTPGirisTarihi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dTPCikisTarihi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMalzemeAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGrubu.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBirim.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMiktar.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtTeslimEden.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtTeslimAlan.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtFirma.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();            
            txtResim.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            pictureBox1.ImageLocation= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtCikisMalzemeAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtCikisGrubu.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtCikisBirim.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtCikisMiktar.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtCikisTeslimEden.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtCikisTeslimAlan.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            txtKullanimYeri.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
            txtMudurluk.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_MalzemeKayit where GRUB like '%" + txtAra.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
