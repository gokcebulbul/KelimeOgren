using System.Data.OleDb;
namespace KelimeOgren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\gokce\\OneDrive\\Masaüstü\\dbSozluk.mdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;

        public void Getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id =@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtÝngilizce.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
            txtTurkce.Focus();
            timer1.Start();
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTurkce.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                Getir();
                txtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                txtTurkce.Enabled = false;
                txtÝngilizce.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
