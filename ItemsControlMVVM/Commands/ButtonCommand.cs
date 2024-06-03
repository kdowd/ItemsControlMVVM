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
    public class ButtonCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public ButtonCommand(MainViewModel mvm)
        {

        }
        public bool CanExecute(object? parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show("Holy Crap");
            //throw new NotImplementedException();
        }
    }
}
