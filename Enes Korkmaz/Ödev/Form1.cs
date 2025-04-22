using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
               
                var secilenler = listBox2.SelectedItems.Cast<object>().ToList();

                foreach (var item in secilenler)
                {
                    listBox1.Items.Add(item);
                    listBox2.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Liste'den bir veya daha fazla öğe seçin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
               
                var secilenler = listBox1.SelectedItems.Cast<object>().ToList();

                foreach (var item in secilenler)
                {
                    listBox2.Items.Add(item);
                    listBox1.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Liste'den bir veya daha fazla öğe seçin.");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                }
            }
        }
    }
}