using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop
{
    public partial class Form1 : Form
    {
        static storeManager CarManager = new storeManager();

        public Form1(List<Car> cars)
        {
            InitializeComponent();
        }

        private void btn_addCar_Click(object sender, EventArgs e)
        {
            double.TryParse(txtbx_price.Text, out double price);

            Car newCar = new Car(txtbx_make.Text, txtbx_model.Text, price);

            bool result = CarManager.Add(newCar);
            if(result == true)
            {
                MessageBox.Show("added successfully");
                txtbx_make.Text = "";
                txtbx_model.Text = "";
                txtbx_price.Text = "";
            }
            else
            {
                MessageBox.Show("failed to add");
            }

            List<Car> mirror = CarManager.getCarList();

            lstbx_cars.DataSource = mirror;
            

        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            List<Car> mirror = CarManager.getCarList();

            int result = lstbx_cars.SelectedIndex;

            Car switchCar = mirror[result];
            CarManager.addToCart(switchCar);

            lstbx_cars.DataSource = CarManager.getCarList();

            List<Car> cartMirror = CarManager.getCart();

            lstbx_cart.DataSource = cartMirror;


            

        }
    }
}
