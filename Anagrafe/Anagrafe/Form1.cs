using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagrafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file =
                       new System.IO.StreamWriter(@"C:\Users\Stage1\Desktop\Prove Stage\DatiForm.txt", true))
            {
                file.WriteLine(textBox4.Text);
                file.WriteLine(textBox5.Text);
                file.WriteLine(textBox6.Text);
                file.WriteLine(textBox7.Text);
                file.WriteLine(textBox8.Text);
                file.WriteLine(textBox9.Text);
                file.WriteLine(textBox10.Text);
                file.WriteLine(textBox11.Text);
                file.WriteLine(textBox12.Text);
                file.WriteLine(textBox13.Text);
                file.WriteLine(textBox14.Text);
                file.WriteLine(textBox15.Text);
                file.WriteLine(textBox16.Text);
                file.WriteLine(textBox17.Text);
                file.WriteLine(textBox18.Text);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Stage1\Desktop\Prove Stage\DatiForm.txt");
            string[] a;
            a = new string[20];
            int b = 0;

            foreach (string line in lines){
                a[b]=line;
                b = b + 1;
            }
            textBox4.Text = a[0];
            textBox5.Text = a[1];
            textBox6.Text = a[2];
            textBox7.Text = a[3];
            textBox8.Text = a[4];
            textBox9.Text = a[5];
            textBox10.Text = a[6];
            textBox11.Text = a[7];
            textBox12.Text = a[8];
            textBox13.Text = a[9];
            textBox14.Text = a[10];
            textBox15.Text = a[11];
            textBox16.Text = a[12];
            textBox17.Text = a[13];
            textBox18.Text = a[14];
            


        }
    }
        }
        
        
    

