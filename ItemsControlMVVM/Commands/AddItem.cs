using ItemsControlMVVM.Models;
using ItemsControlMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ItemsControlMVVM.Commands
{
    public class AddItem : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly MainViewModel theModel;


        public AddItem(MainViewModel theModel)
        {
            this.theModel = theModel;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            theModel.AddNewItem();

        }
    }
}
