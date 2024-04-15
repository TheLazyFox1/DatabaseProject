using System.ComponentModel;

namespace TechSprint
{
    public partial class MainPage : INotifyPropertyChanged
    {
        private List<Customer> _customers;

        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                OnPropertyChanged(nameof(Customers));
            }
        }

        public MainPage()
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customerRepository = new CustomerRepository();
            Customers = customerRepository.GetAllCustomers();
        }

        // Implement INotifyPropertyChanged interface
    }
}
