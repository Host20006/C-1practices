using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lploutput_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //stage1 creating variable
            string day_of_theweek, name_of_the_month, numeric_day, year, fulldate;

            //initialization
            day_of_theweek=txtdayofthemonth.Text;
            name_of_the_month=txtnameofthemonth.Text;
            numeric_day = txtdayofthemonth.Text;
            year=txtyear.Text;

            //stage2  process-concatination of full date
            fulldate = day_of_theweek + " , " + name_of_the_month + " , " + numeric_day + " , " + year;

            //stage3 the ouput using label
            lploutput.Text = fulldate;


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox

            txtdayoftheweek.Clear();
            txtnameofthemonth.Text = "";
            txtdayofthemonth.Clear();
            txtyear.Text=string.Empty;
            //clearing label i can not use clear funtion
            lploutput.Text=string.Empty;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //form close -using this keywordand close function
            this.Close();
        }
    }
}
