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
using System.Security.Cryptography;

namespace Hastane_Projesi
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {//Ad Soyad Çekme
            Lbltc.Text = tc;//giriş yaparken girilen tc yi hasta detay formunda tc kısmına otomatik olarak eklemesini sağladık.
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Lbltc.Text);//girdigimiz tc degerini hasta detay kısmında yazdırdık.ve orada yazan degeri hasta ad soyad ile kontrolünü yaparak isim kısmına dogru bilgiyi yazddırdık.
            SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                lbladsoyad.Text = dr[0] +" "+ dr[1];//"" bunu arasında boşluk olması için yaptık.
            }
            bgl.baglanti().Close();
            //Randevu Geçmişi
            //DataGridwiew 1
            DataTable dt = new DataTable();//veri tablosu
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where HastaTc="+tc,bgl.baglanti());//data gride verileri aktarmak için(dataAdapter)
            da.Fill(dt);//tablonun içini dt den gelen degerle doldur(tablodan gelen degerle*) datagridde baglantı açıp kapamaya gerek yok
            dataGridView1.DataSource= dt;

            //Branş çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                Cmbbrans.Items.Add(dr2[0]);
            }

        }
    }
}
