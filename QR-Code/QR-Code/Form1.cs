using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;


namespace QR_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                QRCodeEncoder qrencod = new QRCodeEncoder();
                if (checkBox1.Checked == true)
                {
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {                                            
                        qrencod.QRCodeBackgroundColor = colorDialog1.Color;     
                    }
                     
                }
                Bitmap qrcode = qrencod.Encode(textBox1.Text);
                pictureBox1.Image = qrcode as Image;
                
            }
            else
            {
                MessageBox.Show("Favor informar uma URL");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (checkBox2.Checked == true)
            {
                if (pictureBox1.Image != null && String.IsNullOrEmpty(textBox2.Text) == false)
                {
                    SaveFileDialog salvarArquivo = new SaveFileDialog();
                    salvarArquivo.FileName = textBox2.Text;
                    salvarArquivo.DefaultExt = ".bmp";
                    if (salvarArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        pictureBox1.Image.Save(salvarArquivo.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        MessageBox.Show("Arquivo : " + salvarArquivo.FileName + " --> Salvo" );
                    }                

                }
                else
                {
                    MessageBox.Show("Gerar QRCode ou digitar nome do arquivo");
                }
            }
            if (checkBox3.Checked == true)
            {
                if (pictureBox1.Image != null && String.IsNullOrEmpty(textBox2.Text) == false)
                {
                    SaveFileDialog salvarArquivo = new SaveFileDialog();
                    salvarArquivo.FileName = textBox2.Text;
                    salvarArquivo.DefaultExt = ".gif";
                    if (salvarArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        pictureBox1.Image.Save(salvarArquivo.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        MessageBox.Show("Arquivo : " + salvarArquivo.FileName + " --> Salvo");
                    }

                }
                else
                {
                    MessageBox.Show("Gerar QRCode ou digitar nome do arquivo");
                }
            }
            if (checkBox4.Checked == true)
            {
                if (pictureBox1.Image != null && String.IsNullOrEmpty(textBox2.Text) == false)
                {
                    SaveFileDialog salvarArquivo = new SaveFileDialog();
                    salvarArquivo.FileName = textBox2.Text;
                    salvarArquivo.DefaultExt = ".png";
                    if (salvarArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        pictureBox1.Image.Save(salvarArquivo.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Arquivo : " + salvarArquivo.FileName + " --> Salvo");
                    }

                }
                else
                {
                    MessageBox.Show("Gerar QRCode ou digitar nome do arquivo");
                }
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrado para Art Chik Produtos Publicitários");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }
    }
}
