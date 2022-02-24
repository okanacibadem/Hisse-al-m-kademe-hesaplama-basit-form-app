using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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
            double fiyat = Convert.ToDouble(textBox1.Text);
            double anaara = Convert.ToDouble(textBox2.Text);
            double kademe = Convert.ToDouble(textBox3.Text);

            for (int i = 0; i < kademe; i++)
            {
                fiyat =fiyat- (fiyat*3 / 100);

                listView1.Items.Add("Alım Fiyatı"+fiyat);
            }
                       
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
