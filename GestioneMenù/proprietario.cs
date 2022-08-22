using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestioneMenù
{
    public partial class proprietario : Form
    {
        public proprietario()
        {
            InitializeComponent();
        }

        //FILE

        DataTable table = new DataTable();

        private void proprietario_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Prezzo (€)", typeof(float));
            table.Columns.Add("Ingredienti", typeof(string));
            table.Columns.Add("Categoria", typeof(string));


            dataGridView1.DataSource = table;



            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 120;

            read(table, values);
            
        }
        string[] values;
        static void read(DataTable table, string[] values)
        {
            table.Clear();
            string[] lines = File.ReadAllLines(@"C:\Users\Thoma\OneDrive\Desktop\GestioneMenù\GestioneMenù\bin\Debug\Piatti.txt");
            

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');

                string[] row = new string[values.Length];

                for (int x = 0; x < values.Length; x++)
                {
                    row[x] = values[x].Trim();
                }

                table.Rows.Add(row);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.WriteAllText(@"C:\Users\Thoma\OneDrive\Desktop\GestioneMenù\GestioneMenù\bin\Debug\Piatti.txt", textBox1.Text);
            //Use StreamWriter class.
            StreamWriter sw = new StreamWriter(@"C:\Users\Thoma\OneDrive\Desktop\GestioneMenù\GestioneMenù\bin\Debug\Piatti.txt",true);

            //Use write method to write the text
            sw.WriteLine(textBox1.Text + " / " + textBox2.Text + " / " + textBox4.Text + " / " + textBox3.Text + " / " + comboBox3.Text);

            //always close your stream
            sw.Close();

            read(table, values);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox3.ResetText();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comparazione = (values[0]);
            string testo = textBox1.Text;

            foreach (DataRow dr in table.Rows) // search whole table
            {
                if (values[0].ToString() = testo) // if id==2
                {
                    dr["Nome"] = textBox2.Text; //change the name
                    dr["Prezzo (€)"] = textBox4.Text;
                    dr["Ingredienti"] = textBox3.Text;
                    dr["Categoria"] = comboBox3.Text;
                    





                    //break; break or not depending on you
                }
            }


            
        }
        /*static void modifica()     //lettura solo se faccio una struct
        {
            StreamReader lettura = new StreamReader(@"C:\Users\Thoma\OneDrive\Desktop\GestioneMenù\GestioneMenù\bin\Debug\Piatti.txt");
            string a; int i = 0;
            while (!lettura.EndOfStream)
            {
                a = lettura.ReadLine();
                var b = a.Split('/');

            }
        
        }*/
    }
}
