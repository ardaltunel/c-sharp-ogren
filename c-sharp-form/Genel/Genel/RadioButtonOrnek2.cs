﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genel

{
    public partial class RadioButtonOrnek2 : Form
    {
        public RadioButtonOrnek2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat = 0, tutar = 0;
            try
            {
                fiyat = double.Parse(textBox1.Text);
                if(radioButton1.Checked)
                {
                    tutar = fiyat;
                }
                else if (radioButton2.Checked)
                {
                    tutar = fiyat - (fiyat * 0.25);
                }
                else if (radioButton3.Checked)
                {
                    tutar = fiyat - (fiyat*0.5);
                }
                else if(radioButton4.Checked)
                {
                    tutar = fiyat - (fiyat * 0.75);
                }
                label2.Text = "Tutar = " + tutar.ToString();
                label2.ForeColor = Color.Green;
            }
            catch 
            {
                label2.Text = "Lütfen Geçerli Bir Değer Giriniz";
                label2.ForeColor = Color.Red;
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButtonOrnek2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
            this.MaximizeBox = false;

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int x = (screenWidth - formWidth) / 2;
            int y = (screenHeight - formHeight) / 2;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }
    }
}
