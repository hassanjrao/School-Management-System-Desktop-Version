using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Act_3
{
    public partial class Form1 : Form
    {
        public static int index=0;
     
        public Form1()
        {
            InitializeComponent();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtAdd.Text = "";
            txtCity.Text = "";
            txtMobile.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            string fname = Convert.ToString(this.txtFName.Text);
            string sname = Convert.ToString(this.txtLName.Text);
            string city = Convert.ToString(this.txtCity.Text);
            string add = Convert.ToString(this.txtAdd.Text);
            string mob = Convert.ToString(this.txtMobile.Text);

            if(fname.Equals("") || sname.Equals("") || city.Equals("")|| add.Equals("") || mob.Equals(""))
            {
                MessageBox.Show("Some Info is missing");
            }
           
            Database.stdarr[index] = new StudentClass(fname,sname,add,city,mob);
           
            index++;
          
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
