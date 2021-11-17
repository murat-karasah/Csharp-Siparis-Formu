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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "test";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           // Object selectedItem = comboBox1.SelectedItem;
           // String str = selectedItem.ToString();
            listBox1.Items.Add(textBox1.Text);
            comboBox2.Items.Add(textBox1.Text);
        }
    }
}
