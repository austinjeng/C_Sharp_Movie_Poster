using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW03_09156213
{
    public partial class Form1 : Form
    {
        List<Object> pics = new List<object>();
        List<int> checkedImages = new List<int>();
        int i = 0;
        int k = 0;

        public Form1()
        {
            InitializeComponent();
            
            pics.Add(Properties.Resources.movie_001);
            pics.Add(Properties.Resources.movie_002);
            pics.Add(Properties.Resources.movie_003);
            pics.Add(Properties.Resources.movie_004);
            pics.Add(Properties.Resources.movie_005);
            //pictureBox1.Image = (Image)pics[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(k == i)
            {
                k = 0;
            }
            pictureBox1.Image = (Image)pics[checkedImages[k]];
            k++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = 0;
            timer1.Interval = Convert.ToInt32(textBox1.Text) * 1000;
            checkedImages.Clear();

            if(checkBox1.Checked)
            {
                checkedImages.Add(0);
            } 
            if (checkBox2.Checked)
            {
                checkedImages.Add(1);
            } 
            if (checkBox3.Checked)
            {
                checkedImages.Add(2);
            } 
            if (checkBox4.Checked)
            {
                checkedImages.Add(3);
            } 
            if (checkBox5.Checked)
            {
                checkedImages.Add(4);
            }

            i = checkedImages.Count();
            if(i != 0)
            {
                timer1.Start();
            }
        }
    }
}
