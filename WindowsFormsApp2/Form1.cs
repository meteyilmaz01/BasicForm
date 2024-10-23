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
        string name;
        string surname;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            textBox3.BackColor = colorDialog1.Color;
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            surname = textBox2.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(name);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Console.WriteLine(name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("isim  "+textBox1.Text);
            listBox1.Items.Add("soyisim  " + textBox2.Text);
            listBox1.Items.Add("ülkeniz  "+comboBox1.Text);
            listBox1.Items.Add("yaşınız  " + (DateTime.Now.Year - dateTimePicker1.Value.Year));
            if (radioButton1.Checked)
            {
                listBox1.Items.Add("cinsiyetinniz " + radioButton1.Text);
            }
            else {
                listBox1.Items.Add("cinsiyetinniz " + radioButton2.Text);
            }
            if (checkBox1.Checked) listBox1.Items.Add(checkBox1.Text+"  seviyorsunuz");
            if (checkBox2.Checked) listBox1.Items.Add(checkBox2.Text + "  seviyorsunuz");
            progressBar1.Value = 100;


        }

        private void process1_Exited_1(object sender, EventArgs e)
        {

        }
    }
}
