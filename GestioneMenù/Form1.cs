using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneMenù
{
    public partial class Form1 : Form
    {
        proprietario Proprietario = new proprietario();
        utente Utente = new utente();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.SelectedItem == "Utente")
            {
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
            }

            if (comboBox1.SelectedItem == "Proprietario")
            {
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username" && textBox2.Text == "Password")
            {
                Proprietario.Show();
                this.Visible = false;
            }

            if (textBox1.Text == "" && textBox2.Text == "" && label1.Visible == false)
            {
                Utente.Show();
                this.Visible = false;
            }

            if(textBox1.Text != "Username" && textBox2.Text != "Password" && textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("Valori inseriti errati");
                textBox1.Text = "";
                textBox2.Text = "";
            }

            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Inserire un ruolo");
            }
        }
    }
}
