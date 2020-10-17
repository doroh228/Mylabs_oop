using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace InviteCustomer
{
    public partial class Customer 
    {
        static public int Id = 0;
        public string First_name { get;  set; }="";
        public string Second_name { get; set; } = "";
        public string Last_name { get; set; } = "";
        public long NumbersKard { get; set; } = 0;
        public decimal Balance { get; set; } =0;

        private int m = 35;
        public int y
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }
        public Customer()
        {
            Id++;
        }

        public Customer(int id, string first_name, string second_name, string last_name, long numbersKard, decimal balance)
        {
            if (id == 0)
            {
                Id=id+1;
            }
            else if(Id==id)
            {
                Id = id+1;
            }
            else
            {
                Id = id;
            }
            First_name = first_name;
            Second_name = second_name;
            Last_name = last_name;
            NumbersKard = numbersKard;
            Balance = balance;
        }

    }

    public partial class Customer
    {
        public Customer(int id = 1, string first_name = "Dorohov", string second_name = "Sergey", string last_name = "Nikol", long numbersKard = 4255200314234321, decimal balance = 2000, bool justTry = false)
        {

            if (id == Id)
            {
                Id += 1;
            }
            else
            {
                Id = id;
            }
            First_name = first_name;
            Second_name = second_name;
            Last_name = last_name;
            NumbersKard = numbersKard;
            Balance = balance;
        }
    }
    /*    public  string name( )*/
}
