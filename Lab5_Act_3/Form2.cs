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
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();
       
        public Form2()
        {
            InitializeComponent();
           

            for(int i=0; i<Form1.index; i++)
            {
                listBox1.Items.Add(Database.stdarr[i].fname);
            }


        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                int index = listBox1.SelectedIndex;

            
                this.txtFname.Text = Database.stdarr[index].fname;
                this.txtSname.Text = Database.stdarr[index].sname;
                this.txtAddress.Text = Database.stdarr[index].address;
                this.txtCity.Text = Database.stdarr[index].city;
                this.txtMobile.Text = Database.stdarr[index].mobile;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
