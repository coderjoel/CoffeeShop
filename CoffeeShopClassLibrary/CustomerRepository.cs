using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace CoffeeShopClassLibrary
{
    public class CustomerRepository
    {

        //private List<Customer> _Customers = new List<Customer>();
        //public List<Customer> Customers { get=>_Customers; }

        private ArrayList _Customers; public ArrayList Customers { get => _Customers; set => _Customers = value; }

        public void Add(Customer customer)
        {
            this.Customers.Add(customer);
        }

        public CustomerRepository()
        {
            //this._Customers = Customers;
            this._Customers = new ArrayList();
        }

        public void Save(String filepath)
        {
            try
            {
                // serialize JSON to a string and then write string to a file
                File.WriteAllText(filepath, JsonConvert.SerializeObject(Customers));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Circular refrence Exception");
            }
        }

        public void Load(String filepath)
        {
            // read file into a string and deserialize JSON to a type
            var _Customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(filepath));

            foreach (Customer customer in _Customers)
            {
                if(customer!=null)
                {
                    foreach(Order order in customer.Orders)
                    {
                        if(order!=null)
                        {
                            order.Customer = customer;
                        }
                    }
                }
            }

        }

    }
}
