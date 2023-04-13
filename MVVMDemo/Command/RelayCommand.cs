using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<object> EexcuteMethod;
        public RelayCommand(Action<object> EexcuteMethod )
        {
            this.EexcuteMethod = EexcuteMethod;
        }

        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => EexcuteMethod(parameter);
    }
}
