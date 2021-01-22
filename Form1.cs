using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Paulius Bakšys PS-01
namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        int[] sk_mas = new int[10];
        int n = 0;
        int s = 10;
        int Sum;



        public Form1()
        {

            InitializeComponent();

        }

       private void button1_Click(object sender, EventArgs e)  // Pirma užduotis
        {

            richTextBox1.Clear();
            try
            {
                sk_mas[n] = Convert.ToInt32(textBox1.Text);

            }
            catch
            {
                richTextBox1.Text = "Ivesta per daug skaičių!";
                n--;
            }


            textBox1.Clear();
            n++;

            for (int i = 0; i < n; i++)
            {
                richTextBox1.Text += sk_mas[i].ToString() + ";" + "\n";
            }

            if (n == 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    Sum += sk_mas[i];
                }
                richTextBox1.Text += "\n*************" + "\nSuma = "
                + Sum.ToString()
                + "\n*************";

                label1.Text = "Įvesti visi 10 skaičių!";

            }
            else
            {
                label1.Text = "Įveskite " + (10 - n) + " skaičius";
            }






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Antra užduotis
        {
            int tree = Convert.ToInt32(textBox2.Text);
            
            richTextBox1.Clear();


            for (int i = 0; i < tree; i++)
            {
                
                for (int j = tree; j > i + 1; j--) 
                {
                    richTextBox1.Text += " ";  
                }
                for (int j = 0; j < i + 1; j++)
                {
                    richTextBox1.Text += "* ";
                }
                richTextBox1.Text += "\n";
            }
           




        }
    }
}

        
