using Microsoft.Office.Interop.Excel;
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
    public partial class FrmRaporlama : Form
    {
        public FrmRaporlama()
        {
            InitializeComponent();
        }

        BaglantiSinifi bgl = new BaglantiSinifi();
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VDBH89Q\SQLEXPRESS;Initial Catalog=TalasMakineİkmalDepo;Integrated Security=True");

        void Listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Raporlama", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Count()
        {
            lblCount.Text = $"TOPLAM KAYIT SAYISI={dataGridView1.RowCount - 1}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaMenu fr = new FrmAnaMenu();
            fr.Show();
            this.Hide();
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                int StartCol = 1;
                int StartRow = 1;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.StackTrace);
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void FrmRaporlama_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmRaporlama_Load(object sender, EventArgs e)
        {
            Listele();
            Count();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Raporlama where GIRISTARIHI like '%" + dateTimePicker1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Raporlama where CIKISTARIHI like '%" + dateTimePicker2.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtResim.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Listele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Raporlama where MALZEMEADI like '%" + txtAra.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
