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


            string[] lines = File.ReadAllLines(@"C:\Users\Thoma\OneDrive\Desktop\GestioneMenù\GestioneMenù\bin\Debug\Piatti.txt");
            string[] values;

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

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
