using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.ObjectModel;

namespace CoffeeShopClassLibrary
{
    public class CustomerRepository
    {

        private Customer[] _Customers;
        public Customer[] Customers { get=>_Customers; }

        public void Add(Customer customer)
        {
            var repcustomer = new ArrayList(); 
            repcustomer.Add(Customers);
        }

        public CustomerRepository()
        {

        }

        public void Save(string filepath)
        {
            // serialize JSON to a string and then write string to a file
            File.WriteAllText(filepath, JsonConvert.SerializeObject(Customers));
        }

        public void Load(string filepath)
        {
            // read file into a string and deserialize JSON to a type
            Customer customer= JsonConvert.DeserializeObject<Customer>(File.ReadAllText(filepath));
        }

    }
}
