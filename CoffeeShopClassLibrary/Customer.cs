using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
    public struct Address
    {
        private String _Street;
        public String Street { get => _Street; set => _Street = value; }
        private String _City;
        public String City { get => _City; set => _City = value; }
        private String _Province;
        public String Province { get => _Province; set => _Province = value; }
        private String _PostalCode;
        public String PostalCode { get => _PostalCode; set => _PostalCode = value; }
        public static Address SHOP_ADDRESS = new Address { Street = "1 King St", City = "Toronto", Province = "ON", PostalCode = "M1M 1M1" };

        public Address(Address addr)
        {
            _Street = addr.Street;
            _City = addr.City;
            _Province = addr.Province;
            _PostalCode = addr.PostalCode;

        }

    }
    public class Customer
    {

        public int _IdNumber;
        public int IdNumber { get => _IdNumber; set => _IdNumber = value; }
        public String _Name;
        public String Name { get => _Name; set => _Name = value; }
        

        private Address _Address;
        public Address Address { get=> _Address; set=> _Address = value;}

        public Int64 _Phone;
        public Int64 Phone { get=>_Phone;

            set
            {
                /*if (value.ToString().Length < 10 || value.ToString().Length > 10)
                {
                    throw new Exception("Telephone No cannot be more than 10 digits");

                }*/

                _Phone = value;
            }
        }

        int generateCustomerId()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return (int)random;
        }

        private Order[] _Orders;
        public Order[] Orders { get => _Orders; }

        private Order _CurrentOrder;
        public Order CurrentOrder {get=> _CurrentOrder;}

        int numberOfOrders;

        public Customer()
        {
            _IdNumber = generateCustomerId();
            _Address = new Address();
            _Orders = new Order[50];

        }

        public Customer(string name, Int64 number, Address address)
        {
            this._Name = name;
            this._Phone = number;
            this._Address = new Address(address);
            this._IdNumber = generateCustomerId();
            this._Orders = new Order[50];
        }

        public Order CreatePhoneOrder(Address addr)
        {
            this._CurrentOrder = new Order(this, addr);

            _Orders[numberOfOrders] = _CurrentOrder;
            numberOfOrders++;
            return this._CurrentOrder;

        }

        public Order AddOrder(Order odr)
        {
            _Orders[numberOfOrders] = odr;
            numberOfOrders++;
            return odr;
        }

        public String GetOrderInfo()
        {
            String temp = " ";
            if (Orders != null)
            {

                foreach (Order orders in Orders)
                {
                    if (orders != null)
                    {
                        temp += orders.GetInfo();
                    }
                }
            }
            return temp;
        }
        public override string ToString()
        {
            return GetInfo();
        }

        public String GetInfo()
        {
            return String.Format("\nCustomer Id: {0}\nCustomer Name: {1}\nMobile Number: {2}\nAddress: {3}, {4}, {5} {6}\n{7}\n",
                IdNumber, Name, Phone, _Address.Street, _Address.City, _Address.Province, _Address.PostalCode, GetOrderInfo());

        }
    }
}