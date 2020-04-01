using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    /// <summary>
    /// The ModelView for a cash register control
    /// </summary>
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that notifies when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Model class for this ModelView
        /// </summary> 
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                int quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets or sets the number of dimes in the cash register
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                int quantity = value - drawer.Dimes;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets or sets the number of nickels in the cash register
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                int quantity = value - drawer.Nickels;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets or sets the number of quarter in the cash register
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                int quantity = value - drawer.Quarters;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Gets or sets the number of halfdollars in the cash register
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                int quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// Gets or sets the number of dollars in the cash register
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                int quantity = value - drawer.Dollars;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// Gets or sets the number of ones in the cash register
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0) return;
                int quantity = drawer.Ones - value;
                if (quantity > 0) drawer.RemoveBill(Bills.One, quantity);
                else drawer.AddBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }


        /// <summary>
        /// Gets or sets the number of twos in the cash register
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                int quantity = drawer.Twos - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Two, quantity);
                else drawer.AddBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }


        /// <summary>
        /// Gets or sets the number of fives in the cash register
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                int quantity = drawer.Fives - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Five, quantity);
                else drawer.AddBill(Bills.Five, - quantity);
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Gets or sets the number of tens in the cash register
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                int quantity = drawer.Tens - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Ten, quantity);
                else drawer.AddBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }


        /// <summary>
        /// Gets or sets the number of twentys in the cash register
        /// </summary>
        public int Twentys
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                int quantity = drawer.Twenties - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Twenty, quantity);
                else drawer.AddBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twentys");
            }
        }


        /// <summary>
        /// Gets or sets the number of fiftys in the cash register
        /// </summary>
        public int Fiftys
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                int quantity = drawer.Fifties - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Fifty, quantity);
                else drawer.AddBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fiftys");                  
            }
        }



        /// <summary>
        /// Gets or sets the number of hundreds int he cash register
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                int quantity = drawer.Hundreds - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Hundred, quantity);
                else drawer.AddBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundreds");
            }
        }

    }
}
