using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Samochodowy_WF
{
    public partial class Form1 : Form
    {
            List<Car> list = new List<Car>();
        public Form1()
        {
            InitializeComponent();
            dgvCars.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car();
                car.Category = tbCategory.Text;
                car.EngineeCapacity = int.Parse(tbEngineCapacity.Text);
                car.EnginePower = int.Parse(tbEnginePower.Text);
                car.Color = tbColor.Text;
                car.Weight = int.Parse(tbWeight.Text);
                car.NrOfAxies = int.Parse(tbNrOfAxies.Text);
                list.Add(car);

                MessageBox.Show("Dodano nowy obiekt","Sukces",MessageBoxButtons.OK);
                
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Coś poszło nie tak :( wprowadź dane jeszcze raz");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var lista = list;
            dgvCars.DataSource = lista;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
