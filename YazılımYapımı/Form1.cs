using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
        }
 
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pbtaska1_MouseDown(object sender, MouseEventArgs e)
        {
            pbtaska1.DoDragDrop(pbtaska1.Image, DragDropEffects.Copy);
            MessageBox.Show("Yapan Kişi:Gamze");
            MessageBox.Show("Yapılacak Tarih:25.06.2018");
            pbtaska1.Hide();
        }

        private void pbtaska2_MouseDown(object sender, MouseEventArgs e)
        {
            pbtaska2.DoDragDrop(pbtaska2.Image, DragDropEffects.Copy);
            MessageBox.Show("Yapan Kişi:Cansu");
            MessageBox.Show("Yapılacak Tarih:21.08.2018");
            pbtaska2.Hide();
        }

        private void pbtaskc1_MouseDown(object sender, MouseEventArgs e)
        {
            pbtaskc1.DoDragDrop(pbtaskc1.Image, DragDropEffects.Copy);
            MessageBox.Show("Yapan Kişi:Atakan");
            MessageBox.Show("Yapılacak Tarih:15.10.2018");
            pbtaskc1.Hide();
        }

        private void pbtaskb1_MouseDown(object sender, MouseEventArgs e)
        {
            pbtaskb1.DoDragDrop(pbtaskb1.Image, DragDropEffects.Copy);
            MessageBox.Show("Yapan Kişi:Suat Eren");
            MessageBox.Show("Yapılacak Tarih:05.09.2018");
            pbtaskb1.Hide();
        }

        private void pbtaskb2_MouseDown(object sender, MouseEventArgs e)
        {
            pbtaskb2.DoDragDrop(pbtaskb2.Image, DragDropEffects.Copy);
            MessageBox.Show("Yapan Kişi:Kürşat");
            MessageBox.Show("Yapılacak Tarih:28.05.2018");
            pbtaskb2.Hide();
        }

        private void pbtaska3_MouseDown(object sender, MouseEventArgs e)
        {
            pbtaska3.DoDragDrop(pbtaska3.Image, DragDropEffects.Copy);
            MessageBox.Show("Yapan Kişi:Ayşenur");
            MessageBox.Show("Yapılacak Tarih:04.05.2018");
            pbtaska3.Hide();
        }

        private void pbtaskc2_MouseDown(object sender, MouseEventArgs e)
        {
            pbtaskc2.DoDragDrop(pbtaskc2.Image, DragDropEffects.Copy);
            MessageBox.Show("Yapan Kişi:Rüya");
            MessageBox.Show("Yapılacak Tarih:18.05.2018");
            pbtaskc2.Hide();
        }

        private void pbtaska4_MouseDown(object sender, MouseEventArgs e)
        {
            pbtaska4.DoDragDrop(pbtaska4.Image, DragDropEffects.Copy);
            MessageBox.Show("Yapan Kişi:Emin");
            MessageBox.Show("Yapılacak Tarih:16.05.2018");
            pbtaska4.Hide();
        }

   
    }
}
