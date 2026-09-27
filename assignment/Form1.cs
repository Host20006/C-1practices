using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            //insering the information
            string Sname, Sid, Sdept, Ssemester,sinfo;
           Sname=txtname.Text;
            Sid = txtstudentid.Text;
            Sdept=txtdepartemenet.Text;
            Ssemester=textsemester.Text;
            sinfo= Sname+" " + " "+Sid+" " + Sdept+ " " +Ssemester;
            Lpoutput.Text = sinfo;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //clearing
           txtname.Clear();
            txtstudentid.Clear();
            txtdepartemenet.Clear();
            textsemester.Clear();
            lplsemester.Text = " ";
            Lpoutput.Text = string.Empty;

           
        }
    }
}
