using System;
using System.CodeDom;
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
    public partial class Main : Form
    {
           private List<Car> list = new List<Car>();
        
        public Main()
        {
            InitializeComponent();
            dgvCars.DataSource = list;
            SetcolumnsHeader();
        }

        private void SetcolumnsHeader()
        {
            
            dgvCars.Columns[nameof(Car.Category)].HeaderText = "Kategoria";
            dgvCars.Columns[nameof(Car.Weight)].HeaderText = "Waga";
            dgvCars.Columns[nameof(Car.EngineeCapacity)].HeaderText = "Pojemność silnika";
            dgvCars.Columns[nameof(Car.EnginePower)].HeaderText = "Moc silnika";
            dgvCars.Columns[nameof(Car.Color)].HeaderText = "Kolor";
            dgvCars.Columns[nameof(Car.NrOfAxies)].HeaderText = "Ilość Osi";

        }



        private void RefreshList ()
        {
            dgvCars.DataSource = null;
            var cars = list;
            dgvCars.DataSource = cars;
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

                MessageBox.Show("Dodano nowy obiekt!","Sukces",MessageBoxButtons.OK);
                RefreshList();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Coś poszło nie tak :( wprowadź dane jeszcze raz" );
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvCars.SelectedRows.Count > 0)
            {
                // Iteruj przez zaznaczone wiersze
                foreach (DataGridViewRow row in dgvCars.SelectedRows)
                {
                    // Pobierz indeks zaznaczonego wiersza
                    int rowIndex = row.Index;

                    // Pobierz obiekt z listy na podstawie indeksu wiersza
                    Car selectedObject = list[rowIndex];

                    // Usuń obiekt z listy
                    list.Remove(selectedObject);
                MessageBox.Show("pojazd został usunięty");
               RefreshList();
                }
            }    
            else
            {
                MessageBox.Show("zaznacz pojazd który chcesz usunąć");
            }
        }
    }
}
