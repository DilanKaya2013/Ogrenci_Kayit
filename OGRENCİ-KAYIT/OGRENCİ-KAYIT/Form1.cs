using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGRENCİ_KAYIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Ogrenci ogrenci;

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciliste = new List<Ogrenci>();


            ogrenciliste.Add(new Ogrenci(273,"Dilan Kaya","10A","kız","0541464927"));
            ogrenciliste.Add(new Ogrenci(33, "Melek Erişgin", "10A", "kız", "05112131415"));
            ogrenciliste.Add(new Ogrenci(6, "Beyza Tanyeli", "10A", "kız", "054243454647"));
            ogrenciliste.Add(new Ogrenci(1550, "İlayda Daban", "10A", "kız", "0545464748494"));
            ogrenciliste.Add(new Ogrenci(777, "Melisa Tuğtekin", "10A", "kız", "05636465676"));
            ogrenciliste.Add(new Ogrenci(26, "Elif Torun", "10A", "kız", "0573747576787"));
            ogrenciliste.Add(new Ogrenci(230, "Merve bozkurt", "10A", "kız", "05423242526"));
            ogrenciliste.Add(new Ogrenci(245, "Sedef Şirin", "10A", "kız", "05482838485"));
            ogrenciliste.Add(new Ogrenci(132, "Hiranur Kulakçı", "10A", "kız", "05919293949"));


            dataGridView1.DataSource = ogrenciliste.ToList();

        }
    }
}
