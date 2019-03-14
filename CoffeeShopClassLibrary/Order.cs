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

        private Customer _CurrentCustomer;
        public Customer CurrentCustomer
        {
            get
            {
                return _CurrentCustomer;
            }
            set
            {
                bool check = GetType().GetProperties().Any(p => p.GetValue(this, null) != null);
                if (check != true)
                   Console.WriteLine("Something went wrong! Customer cannot be changed once assigned.");
                _CurrentCustomer = value;
            }

        }
        private DateTime _OrderTime;
        public DateTime OrderTime { get; set; }

        private DateTime _DeliveryTime;
        public DateTime DeliveryTime { get => _DeliveryTime; }

        private decimal _Cost;
        public decimal Cost { get; set; }

        private Type _OrderType;
        public Type OrderType { get; set; }

        private OrderItem[] _Items;
        public OrderItem[] Items { get => _Items; }

        private bool _Delivered;
        public bool Delivered { get => _Delivered; }

        private Address _DeliveryAddress;
        public Address DeliveryAddress { get => _DeliveryAddress; set => _DeliveryAddress = value; }
        public Customer Customer { get; set; }

        int numberOfItems;
        Random random = new Random();

        public void Deliver()
        {
            this._Delivered = true;
            this._DeliveryTime = DateTime.Now;
        }

        public Order(Customer customer, Address addr)
        {
            this._OrderId = generateOrderrId();
            this._CurrentCustomer = customer;
            this._DeliveryAddress = new Address(addr);
            this._Cost = 0;
            this.numberOfItems= 0;
            this._Items = new OrderItem[25];
            this._OrderTime = DateTime.Now;
            this._Delivered = false;
        }

        public Order()
        {
            this._OrderId = generateOrderrId();
            this._CurrentCustomer = customer;
            this._DeliveryAddress = new Address();
            this._Cost = 0;
            this.numberOfItems = 0;
            this._Items = new OrderItem[25];
            this._OrderTime = DateTime.Now;
            this._Delivered = false;
        }

        public void AddOrderItem(MenuItem item)
        {
            OrderItem oi = new OrderItem(item);
            _Items[numberOfItems] = oi;
            //_Items[numberOfItems] = new OrderItem(item);
            numberOfItems ++;
        }

        public String GetInfo()
        {
            String temp = " ";
            if (_Items != null)
            {
                foreach (OrderItem odrItem in _Items)
                {
                    if (odrItem != null)
                    {
                        temp += odrItem.GetInfo();
                    }
                }
            }
            return string.Format("Orders:\n Order Id: {0}\nCustomer Name : {1}\nOrder Time: {2}\nCost : ${3}\n" +
                "Delivery Address: {4}, {5}, {6} {7}\nItems: {8}\n", OrderId, _CurrentCustomer.Name ,
                               OrderTime, Cost, _DeliveryAddress.Street, _DeliveryAddress.City,_DeliveryAddress.Province,
                               _DeliveryAddress.PostalCode, Items);
        }
    }
}