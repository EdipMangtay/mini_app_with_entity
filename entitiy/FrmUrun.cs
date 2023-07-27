using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entitiy
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUNs
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.DURUM,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD, // bağlı olan tablodan id yerine sadece isimi çektim

                                        }).ToList();


        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txtad.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.KATEGORI = int.Parse(cmbkategorı.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtfıyat.Text);
            t.DURUM = true;
            db.TBLURUNs.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün sisteme Eklendi");



        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(textBox1.Text);
            var urun = db.TBLURUNs.Find(delete);
            db.TBLURUNs.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            //LİNQ
            var kategorıler = (from x in db.TBLKATEGORIs
                               select new 
                               {
                                   x.ID, x.AD
                                   
                               }).ToList();

            cmbkategorı.ValueMember = "ID";
            cmbkategorı.DisplayMember = "AD";
            cmbkategorı.DataSource = kategorıler;


        }

        //private void Btntemizle_Click(object sender, EventArgs e)
        //{
        //    // txt.ad içerisinde cmbkategorıden seçilen value değerini al ve tostring olarak yazdır 

        //    txtad.Text = cmbkategorı.SelectedValue.ToString();

        //}
    }
}
