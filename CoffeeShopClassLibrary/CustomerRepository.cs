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
    public class CustomerRepository : RepositoryBase
    {
		public override List<Customer> Customers { get; set; }

		public CustomerRepository()
		{
			Customers = new List<Customer>();
		}

		public void Add(Customer customer)
		{
			Customers.Add(customer);
		}
	}
}
