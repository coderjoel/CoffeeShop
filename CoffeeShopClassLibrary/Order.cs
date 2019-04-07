using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
    public enum Type
    {
        PhoneOrder,
        RestaurantOrder
    }
    public class Order
    {

        private int _OrderId;
        public int OrderId{ get => _OrderId; set => _OrderId = value; }

        int generateOrderrId()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;

            return (int)random;

        }
        private Customer _Customer;
        [JsonIgnore]
        public Customer Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
				if (_Customer == null)
				{
					_Customer = value;
				}
				else
				{
					Console.WriteLine("Something went wrong! Customer cannot be changed once assigned.");
				}				
            }

        }
    
        private DateTime _OrderTime;
        public DateTime OrderTime { get; }

        private DateTime _DeliveryTime;
        public DateTime DeliveryTime { get => _DeliveryTime; }

        private decimal _Cost;
        public decimal Cost { get=>_Cost;}

        private Type _OrderType;
        public Type OrderType { get=> _OrderType;}

        private OrderItem[] _Items;
        public OrderItem[] Items { get => _Items; }

        private bool _Delivered;
        public bool Delivered { get => _Delivered; }

        private String _Status;
        public String Status { get => _Status; }

        private Address _DeliveryAddress;
        public Address DeliveryAddress { get => _DeliveryAddress; set => _DeliveryAddress = value; }
        
        
        int numberOfItems;
        

        public void Deliver()
        {
                this._Delivered = true;
        }

        public Order(Customer customer, Address addr)
        {
            this._OrderId = generateOrderrId();
            this._Customer = customer;
            this._OrderType = Type.PhoneOrder;
            this._DeliveryAddress = new Address(addr);
            this._Cost = 0;
            this.numberOfItems= 0;
            this._Items = new OrderItem[25];
            this._OrderTime = DateTime.Now;
            this._Delivered = false;
            this._Status="Not Delievered";
        }

        public Order()
        {
            this._OrderId = generateOrderrId();
            this._Customer = new Customer();
            this._DeliveryAddress = new Address(Address.SHOP_ADDRESS);
            this._Cost = 0;
            this.numberOfItems = 0;
            this._Items = new OrderItem[25];
            this._OrderTime = DateTime.Now; 
            this._Delivered = false;
            this._Status = "Not Delievered";
            this._OrderType = Type.RestaurantOrder;
        }

        public void AddOrderItem(IMenuItem item)
        {
            OrderItem oi = new OrderItem(item);
            _Items[numberOfItems] = oi;
            numberOfItems ++;
            _Cost = _Cost + (item.BaseCost);
        }

        public String GetOrders()
        {
            String temp = " ";
            if (Items != null)
            {
                foreach (OrderItem odrItem in Items)
                {
                    if (odrItem != null)
                    {
                        temp += odrItem.GetInfo();
                    }
                }
            }
            
            return temp;
        }

        public string GetInfo()
        {
            if (this._Delivered == true)
            { this._Status = "Delievery time = " + DateTime.Now.ToString("hh:mm tt"); }
            else
            { this._Status = "Not Delievered"; }
            return string.Format("\nOrders:\nOrder Id: {0}\nCustomer Name : {1}\nOrder Time: {2}\nCost : ${3}\n" +
                "Delivery Address: {4}, {5}, {6} {7}\n{8}\nItems: {9}\n", OrderId, Customer.Name ,
                               OrderTime.ToString("hh:mm tt"), Cost, DeliveryAddress.Street, DeliveryAddress.City,DeliveryAddress.Province,
                               DeliveryAddress.PostalCode,Status, GetOrders());
        }
    }
}
