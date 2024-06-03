using ItemsControlMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ItemsControlMVVM.Commands;
using System.Windows;

namespace ItemsControlMVVM.ViewModels
{
    public class MainViewModel
    {
        // to  bind to an observable collection use the get/set if you like ???
        private ObservableCollection<ProductViewModel> _productViewModels;
        // casting to Enumerable
        //uses pointer , not copy. Length is prop a prop in Enumerables
        // IEnumerable implemented y all collections in C# eg list, need to iterate entire Enumerable to get length/count
        public IEnumerable<ProductViewModel> TheProductViewModels => _productViewModels;




        public MainViewModel()
        {

            _productViewModels = new ObservableCollection<ProductViewModel>
            {
                new ("Wooly Hat", "good stuff", 99.5),
                new ("Merino Socks", "good stuff", 44.5),
                new ("Plaid Shirt", "really good stuff", 299.5),
                   new ("Gloves", "really warm", 19.5),
                new ("Shoes", "t is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", 599.5)
            };

            ButtonCommand = new ButtonCommand(this);

        }

        public ICommand ButtonCommand { get; set; }


        public void Test()
        {
            MessageBox.Show("TEST");
        }

    }
}
