using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public class storeManager
    {
        private List<Car> theList { get; set; }
        private List<Car> Cart { get; set; }


        public storeManager()
        {
            theList = new List<Car>();
            Cart = new List<Car>();

        }

        public bool Add(Car item)
        {

            if (theList.Contains(item))
            {
                return false;
            }
            else
            {
                this.theList.Add(item);
                return true;
            }

        }

        public bool removeItem(Car item)
        {
            if (theList.Contains(item))
            {
                theList.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addToCart(Car item)
        {
            if (theList.Contains(item))
            {
                Cart.Add(item);

            }
        }

        public List<Car> getCarList()
        {
            List<Car> mirror = new List<Car>(theList.Count);

            foreach (Car i in theList)
            {
                Car item = i;
                mirror.Add(item);
            }
            return mirror;


        }
        public List<Car> getCart()
        {
            List<Car> mirror = new List<Car>(Cart.Count);

            foreach (Car i in Cart)
            {
                Car item = i;
                mirror.Add(item);
            }
            return mirror;


        }
    }
}


