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
using System.IO;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Salon_Samochodowy_WF
{
    public partial class Main : Form
    {

        public static List<Car> list = new List<Car>();
        private List<Category> categories = new List<Category>();
        public List<Car> sortedList;
        private int rowIndex;
        public static int? index;
        public double sellValue = 0.00;
        

        public Main()
        {
            InitializeComponent();
            list = FileHelper.DeserializeFromFile();
            index = FileHelper.FirstCheck();
            dgvCars.DataSource = list;
            FindIndex();
            SellValueCheck();
            InitGroupCombobox();
            SetColumnsHeader();
            lbSellValueView.Text = sellValue.ToString() + " zł";
        }

        private void FindIndex()
        {
                if (index == 0)
                    index = 0;
                else index = list.OrderByDescending(x => x.Id).FirstOrDefault().Id;
        }
        private void InitGroupCombobox()
        {
            
            Category[] enumValues = (Category[])Enum.GetValues(typeof(Category));
            List<Category> categories = enumValues.ToList();
            List<Category> categories1 = categories.ToList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbSort.DataSource = categories1;
            cbSort.DisplayMember = "Name";
        }

        private void SellValueCheck()
        {
            if(list != null) 
            { 
            foreach(Car car in list)
            {
                if(car.DateOfSell != null)
                sellValue += car.PriceOfSell;
            }
            }
        }

        private void SetColumnsHeader()
        {
            if (list != null)
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
            }
        }

        private void RefreshList()
        {
            list = FileHelper.DeserializeFromFile();
            BindingSource source = new BindingSource();
            source.DataSource = list;
            dgvCars.DataSource = source;
            SetColumnsHeader();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                    FileHelper.DeserializeFromFile();

                if (btnAdd.Text == "Akceptuj")
                {
                    
                    if (cbCategory.SelectedItem.ToString() == "Wszystkie")
                    {
                        MessageBox.Show("ustaw odpowiednią kategorię");
                    }
                    Car selectedObject = list[rowIndex];
                    selectedObject.Id = int.Parse(tbId.Text);
                    selectedObject.Color = tbColor.Text;
                    selectedObject.Category = cbCategory.SelectedItem.ToString();
                    selectedObject.EngineeCapacity = int.Parse(tbEngineCapacity.Text);
                    selectedObject.EnginePower = int.Parse(tbEnginePower.Text);
                    selectedObject.Weight = int.Parse(tbWeight.Text);
                    selectedObject.NrOfAxies = int.Parse(tbNrOfAxies.Text);
                    selectedObject.NoRegistration = tbNoRegistration.Text;
                    selectedObject.CarMileage = int.Parse(tbCarMileage.Text);
                    selectedObject.VinNumber = tbVinNumber.Text;
                    selectedObject.PriceOfSell = double.Parse(tbPriceOfSell.Text);
                    selectedObject.Model = tbModel.Text;
                    
                    btnAdd.Text = "Dodaj";
                    btnAdd.BackColor = Color.ForestGreen;
                   
                }
                else
                {

                    FindIndex();
                  
                    index++;
                    
                    if (cbCategory.SelectedItem.ToString() == "Wszystkie") 
                    {
                        MessageBox.Show("ustaw odpowiednią kategorię");
                        return;
                    }
                    Car car = new Car();
                    car.Id = index;
                    car.Category = cbCategory.SelectedItem.ToString();
                    car.EngineeCapacity = int.Parse(tbEngineCapacity.Text);
                    car.EnginePower = int.Parse(tbEnginePower.Text);
                    car.Color = tbColor.Text;
                    car.Weight = int.Parse(tbWeight.Text);
                    car.NrOfAxies = int.Parse(tbNrOfAxies.Text);
                    car.DateOfBuy = DateTime.Now;
                    car.NoRegistration = tbNoRegistration.Text;
                    car.VinNumber = tbVinNumber.Text;
                    car.CarMileage = int.Parse(tbCarMileage.Text);
                    car.PriceOfSell = double.Parse(tbPriceOfSell.Text);
                    car.Model = tbModel.Text;
                    list.Add(car);

                    MessageBox.Show("Dodano nowy obiekt!", "Sukces", MessageBoxButtons.OK);

                }
                    FileHelper.SerializeToFile(list);
                    RefreshList();
                    ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coś poszło nie tak :( wprowadź dane jeszcze raz" + ex);
            }

        }

        private void ClearText()
        {
            tbId.ResetText();
            cbCategory.ResetText();
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
            rowIndex = dgvCars.CurrentCell.RowIndex;
            Car selectedObject = list[rowIndex];

            if (selectedObject.DateOfSell != null)
            {
                MessageBox.Show("Nie masz uprawnień do usuwania danych archiwalnych !");
                return;
            }

            if (dgvCars.SelectedRows.Count > 0)
            {
                list.Remove(selectedObject);
                FileHelper.SerializeToFile(list);
                MessageBox.Show("pojazd został usunięty");
                RefreshList();

            }
            else
            {
                MessageBox.Show("zaznacz pojazd, który chcesz usunąć");
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            rowIndex = dgvCars.CurrentCell.RowIndex;
            Car selectedObject = list[rowIndex];
            if (selectedObject.DateOfSell != null)
            {
                MessageBox.Show("Nie możesz edytować sprzedanego samochodu !");
                return;
            }
            if (dgvCars.SelectedRows.Count > 0)
            {
                tbId.Text = selectedObject.Id.ToString();
                tbColor.Text = selectedObject.Color;
                cbCategory.SelectedItem = selectedObject.Category;
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
        private void btSell_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                rowIndex = dgvCars.CurrentCell.RowIndex;
                Car selectedObject = list[rowIndex];
                selectedObject.DateOfSell = DateTime.Now;
                sellValue += selectedObject.PriceOfSell;
                lbSellValueView.Text = sellValue.ToString() + " zł";
                FileHelper.SerializeToFile(list);
                RefreshList();
            }
            else
            {
                MessageBox.Show("zaznacz obiekt, który chcesz sprzedać");
            }
        }

        private void cbSort_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedCategory = cbSort.SelectedItem.ToString();
            if (selectedCategory != "Wszystkie") 
            {
                sortedList = list.Where(x => x.Category == selectedCategory).ToList();
                dgvCars.DataSource = sortedList;
                
            }
            else
            {
                dgvCars.DataSource= list;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sortedList = list.Where(x => x.DateOfSell == null).ToList();
                dgvCars.DataSource = sortedList;
            }   
            else { dgvCars.DataSource =  list;}
        }
    }

}
