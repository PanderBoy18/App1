using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderView : ContentView
    {
        Grid grid;

        public OrderView()
        {
            InitializeComponent();

            grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            grid.RowSpacing = 0;

            this.Content = grid;


            this.BindingContextChanged += View1_BindingContextChanged;
        }

        private void View1_BindingContextChanged(object sender, EventArgs e)
        {
            var obj = this.BindingContext as OrderBundle;

            if (obj != null)
            {
                List<Order> list = obj.Bundle;

                for (int i = 0; i < list.Count; i++)
                {

                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });

                    Order order = list[i];
                    grid.Children.Add(new Label
                    {
                        Text = order.Id.ToString()
                    }, 0, i);
                    grid.Children.Add(new Label
                    {
                        Text = order.Action
                    }, 1, i);
                    grid.Children.Add(new Label
                    {
                        Text = order.Coin
                    }, 2, i);
                    grid.Children.Add(new Label
                    {
                        Text = order.Price.ToString()
                    }, 3, i);
                }

                Label label = new Label
                {
                    Text = obj.ProfitUSDT.ToString("0.00"),
                    TextColor = Color.Green,
                    VerticalTextAlignment = TextAlignment.Center
                };

                grid.Children.Add(label, 4, 0);


                Grid.SetRowSpan(label, list.Count);
            }
        }
    }
}