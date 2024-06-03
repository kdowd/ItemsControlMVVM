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
        //public event EventHandler? CanExecuteChanged;

        private readonly MainViewModel vm;

        public ButtonCommand(MainViewModel mvm)
        {
            vm = mvm;

        }
        public bool CanExecute(object? parameter)
        {
            if (vm._productViewModels.Count >= 1)
            {
                return true;
            }

            return false;
        }

        public void Execute(object? parameter)
        {
            //MessageBox.Show("CLEAR");
            vm._productViewModels.Clear();
            //CommandManager.InvalidateRequerySuggested();
        }


        public event EventHandler CanExecuteChanged
        {

            add
            {

                CommandManager.RequerySuggested += value;
            }
            remove
            {

                CommandManager.RequerySuggested -= value;
            }
        }




    }
}
