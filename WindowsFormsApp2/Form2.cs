using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add ("----------Sipariş---------- ");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("##############################----------Yeni Sipariş---------- ");

            if (checkedListBox1.CheckedItems.Count == 0)
            {
                listBox1.Items.Add("---------Sos Tercihi Yok-------- ");

            }
            else
            {
                listBox1.Items.Add("---------Sos Tercihi-------- ");

            }


            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                listBox1.Items.Add("Sos1");
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                listBox1.Items.Add("Sos2");
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                listBox1.Items.Add("Sos3");
                 
            }

            if (radioButton1.Checked || radioButton2.Checked == true)
            {
                listBox1.Items.Add("---------Malzeme Tercihi-------- ");

            }
            else
            {
                listBox1.Items.Add("---------Malzeme Tercihi Yok-------- ");

            }
            if (radioButton1.Checked==true)
            {
                listBox1.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Add(radioButton2.Text);
            }

        }




    }
    }

