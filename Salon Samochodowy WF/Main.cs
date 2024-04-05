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
           private int rowIndex;
           private int Index = 0;
        
        public Main()
        {
            InitializeComponent();
            dgvCars.DataSource = list;
            SetColumnsHeader();
        }
       

        private void SetColumnsHeader()
        {
            dgvCars.Columns[nameof(Car.Id)].HeaderText = "ID";
            dgvCars.Columns[nameof(Car.Category)].HeaderText = "Kategoria";
            dgvCars.Columns[nameof(Car.Weight)].HeaderText = "Waga";
            dgvCars.Columns[nameof(Car.EngineeCapacity)].HeaderText = "Pojemność silnika";
            dgvCars.Columns[nameof(Car.EnginePower)].HeaderText = "Moc silnika";
            dgvCars.Columns[nameof(Car.Color)].HeaderText = "Kolor";
            dgvCars.Columns[nameof(Car.NrOfAxies)].HeaderText = "Ilość Osi";
            dgvCars.Columns[nameof(Car.Model)].HeaderText = "Model";
            dgvCars.Columns[nameof(Car.CarMileage)].HeaderText = "Przebieg";
            dgvCars.Columns[nameof(Car.VinNumber)].HeaderText = "Nr. Vin";
            dgvCars.Columns[nameof(Car.DateOfBuy)].HeaderText = "Data zakupu";
            dgvCars.Columns[nameof(Car.DateOfSell)].HeaderText = "Data sprzedaży";
            dgvCars.Columns[nameof(Car.NoRegistration)].HeaderText = "Nr. Rejestracyjny";
            dgvCars.Columns[nameof(Car.PriceOfSell)].HeaderText = "Cena";
            //dgvCars.Columns[nameof(Car.PriceOfSell)]

           
        }



        private void RefreshList ()
        {
            BindingSource source = new BindingSource();
            source.DataSource = list;
            dgvCars.DataSource = source;
            SetColumnsHeader();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnAdd.Text == "Akceptuj")
                {
                    Car selectedObject = list[rowIndex];
                    selectedObject.Id = int.Parse(tbId.Text);
                    selectedObject.Color = tbColor.Text ;
                    selectedObject.Category = tbCategory.Text;
                    selectedObject.EngineeCapacity = int.Parse(tbEngineCapacity.Text);
                    selectedObject.EnginePower = int.Parse(tbEnginePower.Text);
                    selectedObject.Weight = int.Parse(tbWeight.Text);
                    selectedObject.NrOfAxies = int.Parse(tbNrOfAxies.Text); 
                    selectedObject.NoRegistration = tbNoRegistration.Text;
                    selectedObject.CarMileage = int.Parse(tbCarMileage.Text);
                    selectedObject.VinNumber = tbVinNumber.Text;
                    selectedObject.PriceOfSell = int.Parse(tbPriceOfSell.Text);
                    selectedObject.Model = tbModel.Text;

                    
                    btnAdd.Text = "Dodaj";
                    btnAdd.BackColor = Color.ForestGreen;
                    RefreshList();
                    ClearText();
                 
                }
                else
                {
                    Car car = new Car();
                    Index++;
                    car.Id = Index;
                    car.Category = tbCategory.Text;
                    car.EngineeCapacity = int.Parse(tbEngineCapacity.Text);
                    car.EnginePower = int.Parse(tbEnginePower.Text);
                    car.Color = tbColor.Text;
                    car.Weight = int.Parse(tbWeight.Text);
                    car.NrOfAxies = int.Parse(tbNrOfAxies.Text);
                    car.DateOfBuy = DateTime.Now;
                    car.NoRegistration = tbNoRegistration.Text;
                    car.VinNumber = tbVinNumber.Text;
                    car.CarMileage = int.Parse(tbCarMileage.Text);
                    car.PriceOfSell = int.Parse(tbPriceOfSell.Text);
                    car.Model = tbModel.Text;
                    list.Add(car);
                  

                    MessageBox.Show("Dodano nowy obiekt!", "Sukces", MessageBoxButtons.OK);
                    RefreshList();
                    ClearText();

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Coś poszło nie tak :( wprowadź dane jeszcze raz" + ex );
            }

        }

        private void ClearText()
        {
            tbId.ResetText();
           tbCategory.ResetText();
            tbEngineCapacity.ResetText();
            tbEnginePower.ResetText();
            tbNrOfAxies.ResetText();
            tbColor.ResetText();
            tbWeight.ResetText();
            tbModel.ResetText();
            tbNoRegistration.ResetText();
            tbPriceOfSell.ResetText();
            tbVinNumber.ResetText();
            tbCarMileage.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvCars.SelectedRows.Count > 0)
            {
                    rowIndex = dgvCars.CurrentCell.RowIndex;    
                    Car selectedObject = list[rowIndex];

                
                    list.Remove(selectedObject);
                MessageBox.Show("pojazd został usunięty");
                Index--;
               RefreshList();
                
            }    
            else
            {
                MessageBox.Show("zaznacz pojazd który chcesz usunąć");
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
                rowIndex = dgvCars.CurrentCell.RowIndex;
                Car selectedObject = list[rowIndex];
            if(selectedObject.DateOfSell != null)
            {
                MessageBox.Show("Nie możesz edytować sprzedanego samochodu !");
                return;
            }
            if(dgvCars.SelectedRows.Count > 0)
            {
                tbId.Text = selectedObject.Id.ToString();
                tbColor.Text = selectedObject.Color;
                tbCategory.Text = selectedObject.Category;
                tbEngineCapacity.Text = selectedObject.EngineeCapacity.ToString();
                tbEnginePower.Text = selectedObject.EnginePower.ToString();
                tbWeight.Text = selectedObject.Weight.ToString();
                tbNrOfAxies.Text = selectedObject.NrOfAxies.ToString();
                tbCarMileage.Text = selectedObject.CarMileage.ToString();
                tbModel.Text = selectedObject.Model;
                tbNoRegistration.Text = selectedObject.NoRegistration;
                tbPriceOfSell.Text = selectedObject.PriceOfSell.ToString();
                tbVinNumber.Text = selectedObject.VinNumber;

                btnAdd.Text = "Akceptuj";
                btnAdd.BackColor = Color.Lime;
            }
            else
            {
                MessageBox.Show("zaznacz obiekt do edycji");
            }
        }



        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            MessageBox.Show("niestety nie wiem dlaczego jest problem z Index out of range przy zaznaczaniu:(");
        }

        private void btSell_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                rowIndex = dgvCars.CurrentCell.RowIndex;
                Car selectedObject = list[rowIndex];
                selectedObject.DateOfSell = DateTime.Now;
                RefreshList();
            }
            else
            {
                MessageBox.Show("zaznacz obiekt, który chcesz sprzedać");
            }
        }
    }
}
