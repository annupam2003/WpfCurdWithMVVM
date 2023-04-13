using MVVMDemo.AdoNet;
using MVVMDemo.Command;
using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public RelayCommand Mycmd { get; set; }
        AdoDbContext context;
        private Employee _currentEmployee;

        public Employee CurrentEmployee
        {
            get { return _currentEmployee; }
            set { _currentEmployee = value; OnPropertyChanged(nameof(CurrentEmployee)); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Employee> _emplyees;

        public ObservableCollection<Employee> employeesList
        {
            get { return _emplyees; }
            set { _emplyees = value; OnPropertyChanged(nameof(employeesList)); }
        }


        public MainWindowViewModel()
        {
            Mycmd = new RelayCommand(Execute);
            context = new AdoDbContext();
            LoadAllEmployees();
            CurrentEmployee = new Employee();
        }

        protected void OnPropertyChanged(string PropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }


        public void Execute(object parameter)
        {
            string para = parameter as string;
            if (para == "Add")
            {
                context.AddEmployee(CurrentEmployee);
                LoadAllEmployees();
                Clear();
            }
            if (para == "Edit")
            {
                context.EditEmployee(CurrentEmployee);
                LoadAllEmployees();
                Clear();
            }
            if (para == "Remove")
            {
                context.RemoveEmployee(CurrentEmployee.Id);
                LoadAllEmployees();
                Clear();
            }
            if (para == "Clear")
            {
                Clear();
            }
            Employee emp = parameter as Employee;
            {
                CurrentEmployee = emp;
            }
        }

        void LoadAllEmployees()
        {
          employeesList = new ObservableCollection<Employee>(context.GetAllEmployee());
        }
        void Clear()
        {
            CurrentEmployee = new Employee();
        }
    }
}
