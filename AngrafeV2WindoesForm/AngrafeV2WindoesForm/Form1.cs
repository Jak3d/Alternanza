using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngrafeV2WindoesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Salva i dati nella tabella");
            toolTip1.SetToolTip(button3, "Mostra tabella dati salvati");
            toolTip1.SetToolTip(button4, "Nascondi tabella dati salvati");
            toolTip1.SetToolTip(textBox1, "Riempire tutte le caselle");
            toolTip1.SetToolTip(textBox2, "Riempire tutte le caselle");
            toolTip1.SetToolTip(textBox3, "Riempire tutte le caselle");
            label4.Text = "";
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            listView1.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            button3.Enabled = true;
            button3.Visible = true;
            textBox1.Cursor = default;
            textBox2.Cursor = default;
            textBox3.Cursor = default;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label13.Text = "0";
            
            
            
        }

        public void Button2_Click(object sender, EventArgs e)
        {

            label14.Text = "1";
            label5.Text = textBox1.Text;
            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "Dati caricati";
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            button2.Enabled = false;
            label8.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            button3.PerformClick();
            label14.Text = "0";
            button4.PerformClick();








        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (label9.Text == "0")
            {
                listView1.View = View.Details;
                
                listView1.Columns.Add("Nome", 80);
                listView1.Columns.Add("Cognome", 80);
                listView1.Columns.Add("Codice Fiscale", 200);

                label9.Text = "1";
            }
                button3.Enabled = false;
                button3.Visible = false;
                button4.Enabled = true;
                button4.Visible = true;
                listView1.Visible = true;
            label10.Text = "0";
                
            


            string[] arr = new string[4];
            
            //add items to ListView
            if (label5.Text == "Nome" || label13.Text == "1" || label14.Text == "0") {}
            else
            {
                ListViewItem itm;
                arr[0] = label5.Text;
                label10.Text = label5.Text;
                arr[1] = label6.Text;
                arr[2] = label7.Text;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
                label13.Text = "1";
                
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button3.Visible = true;
            button4.Enabled = false;
            button4.Visible = false;
            listView1.Visible = false;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label8.Text = "1";
            }
            else
            {
                label8.Text = "0";
            }
            if (label8.Text == "1" && label11.Text=="1" && label12.Text == "1")
            {
                button2.Enabled = true;
                
            }
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                label11.Text = "1";
            }
            else
            {
                label11.Text = "0";
            }
            if (label8.Text == "1" && label11.Text == "1" && label12.Text == "1")
            {
                button2.Enabled = true;
                
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                label12.Text = "1";
            }
            else
            {
                label12.Text = "0";
            }
            if (label8.Text == "1" && label11.Text == "1" && label12.Text == "1")
            {
                button2.Enabled = true;
                
            }

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
