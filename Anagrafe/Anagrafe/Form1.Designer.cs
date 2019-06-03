namespace Anagrafe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabella = new System.Windows.Forms.TableLayoutPanel();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabella.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salva Dati";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Nome";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Cognome";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(226, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Cod.Fiscale";
            // 
            // tabella
            // 
            this.tabella.ColumnCount = 3;
            this.tabella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tabella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tabella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tabella.Controls.Add(this.textBox17, 1, 4);
            this.tabella.Controls.Add(this.textBox15, 2, 3);
            this.tabella.Controls.Add(this.textBox14, 1, 3);
            this.tabella.Controls.Add(this.textBox13, 0, 3);
            this.tabella.Controls.Add(this.textBox12, 2, 2);
            this.tabella.Controls.Add(this.textBox11, 1, 2);
            this.tabella.Controls.Add(this.textBox10, 0, 2);
            this.tabella.Controls.Add(this.textBox9, 2, 1);
            this.tabella.Controls.Add(this.textBox8, 1, 1);
            this.tabella.Controls.Add(this.textBox7, 0, 1);
            this.tabella.Controls.Add(this.textBox4, 0, 0);
            this.tabella.Controls.Add(this.textBox5, 1, 0);
            this.tabella.Controls.Add(this.textBox6, 2, 0);
            this.tabella.Controls.Add(this.textBox16, 0, 4);
            this.tabella.Controls.Add(this.textBox18, 2, 4);
            this.tabella.Location = new System.Drawing.Point(13, 88);
            this.tabella.Name = "tabella";
            this.tabella.Padding = new System.Windows.Forms.Padding(3);
            this.tabella.RowCount = 5;
            this.tabella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabella.Size = new System.Drawing.Size(313, 137);
            this.tabella.TabIndex = 4;
            this.tabella.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(108, 114);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(96, 20);
            this.textBox17.TabIndex = 13;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(210, 87);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(97, 20);
            this.textBox15.TabIndex = 11;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(108, 87);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(96, 20);
            this.textBox14.TabIndex = 10;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(6, 87);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(96, 20);
            this.textBox13.TabIndex = 9;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(210, 60);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(97, 20);
            this.textBox12.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(108, 60);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(96, 20);
            this.textBox11.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(6, 60);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(96, 20);
            this.textBox10.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(210, 33);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(97, 20);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(108, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(96, 20);
            this.textBox8.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(96, 20);
            this.textBox7.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 20);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(210, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(97, 20);
            this.textBox6.TabIndex = 2;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(6, 114);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(96, 20);
            this.textBox16.TabIndex = 12;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(210, 114);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(96, 20);
            this.textBox18.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Carica Dati";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 303);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabella);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabella.ResumeLayout(false);
            this.tabella.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TableLayoutPanel tabella;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button2;
    }
}