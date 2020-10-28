using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_vorm
{
    public partial class From3 : Form
    {
        public From3()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        int boxes = 0;
     
        private void From3_Load(object sender, EventArgs e)
        {
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (aBox.Checked==true)
            {
                boxes++;
                aNumeric.Visible = true;
                label3.Visible = true;
            }
            else
            {
                boxes--;
                aNumeric.Visible = false;
                label3.Visible = false;
            }
            btn_check();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
            if (sBox.Checked == true)
            {
                boxes++;
                sNumeric.Visible = true;
                label8.Visible = true;
            }
            else
            {
                boxes--;
                sNumeric.Visible = false;
                label8.Visible = false;
            }
            btn_check();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        public void btn_check()
        {
            if (boxes>=3)
            {
                button1.Enabled = true;
            }
            else if (boxes<3)
            {
                button1.Enabled = false;
            }
        }
       

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
         
            if (hBox.Checked == true)
            {
                boxes++;
                hNumeric.Visible = true;
                label6.Visible = true;
            }
            else
            {
                boxes--;
                hNumeric.Visible = false;
                label6.Visible = false;
            }
            btn_check();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cBox.Checked == true)
            {
                boxes++;
                cNumeric.Visible = true;
                label5.Visible = true;
            }
            else
            {
                boxes--;
                cNumeric.Visible = false;
                label5.Visible = false;
            }
            btn_check();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            btn_check();
            if (pBox.Checked == true)
            {
                boxes++;
                pNumeric.Visible = true;
                label7.Visible = true;
            }
            else
            {
                boxes--;
                pNumeric.Visible = false;
                label7.Visible = false;
            }
        }

        private void bBox_CheckedChanged(object sender, EventArgs e)
        {
           
            if (bBox.Checked == true)
            {
                boxes++;
                bNumeric.Visible = true;
                label4.Visible = true;
            }
            else
            {
                boxes--;
                bNumeric.Visible = false;
                label4.Visible = false;
            }
            btn_check();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void uncheckAll_Click(object sender, EventArgs e)
        {
            aBox.Checked = false;
            bBox.Checked = false;
            cBox.Checked = false;
            hBox.Checked = false;
            pBox.Checked = false;
            sBox.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e) //расчёт
        {
           
        }
    } 
}
