using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Welcome to JamesLife!");
            listBox1.Items.Add("You are Championne De Pog. Age 0.");
            listBox1.Items.Add("Father age 83.");
            listBox1.Items.Add("Mother age 18.");
            listBox1.Items.Add("----------------------------------------------------");
            listBox1.Items.Add("What do you want to do?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = textBox1.Text;
            if (command == "surrender")
            {
                this.Close();
            }
            if(command == "help")
            {
                MessageBox.Show("In the alpha, we have one command. Surrender.\n(actually we have help too lol)");
                return;
            }
            if(command == "dab")
            {
                dab openDab = new dab();
                openDab.ShowDialog();
                return;
            }
            MessageBox.Show("Command not recognized.");
        }
    }
}
