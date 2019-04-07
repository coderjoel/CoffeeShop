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
		public const string ERROR = "\nError  : Repository cannot contain more than 10 customers\n";

		public override List<Customer> Customers { get; set; }

		private int Index;

		public CustomerRepository()
		{
			this.Customers = new List<Customer>();
		}

		public void Add(Customer customer)
		{
				Customers.Add(customer);
				//Index++;
		}
	}
}
