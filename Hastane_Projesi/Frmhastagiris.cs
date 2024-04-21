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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hastane_Projesi
{
    public partial class Frmhastagiris : Form
    {
        public Frmhastagiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeKayit frm = new FrmUyeKayit();
            frm.Show();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {//HASTA TC VE ŞİFRESİNİN VERİTABANI İLE KONTROLÜ YAPILARAK DİGER FORMA (HASTA DETAY) GEÇİŞ SAGLANMIŞTIR.
            SqlCommand komut = new SqlCommand("SELECT *FROM Tbl_Hastalar WHERE HastaTc=@p1 AND HastaSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read()) 
            { FrmHastaDetay frm = new FrmHastaDetay();
                frm.tc=Msktc.Text; //giriş yaparken girilen tc yi hasta detay formunda tc kısmına otomatik olarak eklemesini sağlad
                frm.Show();
                this.Hide();
            }
            else { MessageBox.Show("Girdiginiz bilgiler yanlış veya kayıt yok!"); }
            bgl.baglanti().Close();


        }
    }
}
