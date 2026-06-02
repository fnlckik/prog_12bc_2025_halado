using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarDealership
{
    public class Car : INotifyPropertyChanged
    {
        private string brand;
        private int year;
        private int price;
        private bool isPetrol;
        private string condition;

        public Car()
        {
            brand = "";
            year = 1950;
            price = 0;
            isPetrol = false;
            condition = "";
        }

        public Car(string brand, int year, int price, bool isPetrol, string condition)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
            this.isPetrol = isPetrol;
            this.condition = condition;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - Year;
            }
        }

        public string Brand
        {
            get => brand;
            set { 
                brand = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Brand)));
            }
        }
        public int Year
        {
            get => year;
            set { 
                year = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Year)));
            }
        }
        public int Price
        {
            get => price;
            set { 
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Price)));
            }
        }
        public bool IsPetrol
        {
            get => isPetrol;
            set { isPetrol = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsPetrol)));
            }
        }

        public string Condition
        {
            get => condition;
            set { 
                condition = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Condition)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{Brand} - {Age} éves - {Price} Ft";
        }
    }
}
