using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class VM_Orders : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        bool IsRefreshingOrders = false;

        private ObservableCollection<OrderBundle> _orderList;
        public ObservableCollection<OrderBundle> orderList
        {
            get
            {
                return _orderList;
            }
            set
            {
                if (_orderList != value)
                {
                    _orderList = value;
                    OnPropertyChanged();
                }
            }
        }


        public VM_Orders()
        {
            orderList = new ObservableCollection<OrderBundle>();
            LoadOrders_Handler();
        }


        public Task LoadOrders_Handler()
        {
            return LoadOrders();
        }
        private async Task LoadOrders()
        {
            IsRefreshingOrders = true;

            List<Order> orders = new List<Order>();
            OrderBundle bundle = new OrderBundle();

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            orders = new List<Order>();
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            orders.Add(new Order { Id = 0, Action = "Buy", Coin = "BTC", Price = 9000 });
            bundle = new OrderBundle
            {
                Id = 0,
                ProfitUSDT = 200,
                Bundle = orders
            };
            orderList.Add(bundle);

            IsRefreshingOrders = false;
        }
    }
}
