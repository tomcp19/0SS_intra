using intra_models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.CompilerServices;

namespace Gestionnaire_Clients
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();

        public Customer currentCustomer;

        public event PropertyChangedEventHandler PropertyChanged;

        public Customer CurrentCustomer
        {
            get => currentCustomer;
            set
            {
                currentCustomer = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            addCustomer();
        }

        void addCustomer()
        {
            Customers.Add(new Customer() { Name = "Ayanna", LastName = "Vargas", Address = "401-3122 Nullam Ave", City = "Pickering", Province = "ON", PostalCode = "N6C 7M5", PicturePath = "image/user.png", ContactInfo = "Work : 624-767-4994" });
            Customers.Add(new Customer() { Name = "Whitney", LastName = "Parks", Address = "563-3207 Mi Rd.", City = "Greater Sudbury", Province = "ON", PostalCode = "N9G 5V1", PicturePath = "image/user.png", ContactInfo = "Cell : 175-370-4839" });
            Customers.Add(new Customer() { Name = "Louis", LastName = "Watts", Address = "P.O. Box 529, 6291 Aliquam Road", City = "Fredericton", Province = "NB", PostalCode = "E2T 4M4", PicturePath = "image/user.png", ContactInfo = "Cell : 734-499-0531" });
            Customers.Add(new Customer() { Name = "Pamela", LastName = "Knapp", Address = "2425 Urna Road", City = "Mission", Province = "BC", PostalCode = "V6W 1J0", PicturePath = "image/user.png", ContactInfo = "Home : 510-433-5623" });
            Customers.Add(new Customer() { Name = "Clinton", LastName = "Gallagher", Address = "Ap #150-7450 Sapien Rd.", City = "Scarborough", Province = "ON", PostalCode = "M5V 7N1", PicturePath = "image/user.png", ContactInfo = "Home : 328-524-0475" });
            Customers.Add(new Customer() { Name = "Amal", LastName = "Cross", Address = "P.O. Box 738, 9025 Sed Street", City = "Parkland County", Province = "AB", PostalCode = "T6S 6A4", PicturePath = "image/user.png", ContactInfo = "Cell : 250-555-4617" });
            Customers.Add(new Customer() { Name = "Vanna", LastName = "Hyde", Address = "5671 Eros Rd.", City = "Daly", Province = "MB", PostalCode = "R0E 5T0", PicturePath = "image/user.png", ContactInfo = "Email : Quisque@neque.net" });
            Customers.Add(new Customer() { Name = "Madonna", LastName = "Navarro", Address = "P.O. Box 647, 5331 Erat, Rd.", City = "Prince George", Province = "BC", PostalCode = "V6Y 0X2", PicturePath = "image/user.png", ContactInfo = "Home : 369-993-0222" });
            Customers.Add(new Customer() { Name = "Rina", LastName = "Decker", Address = "138-7714 Orci, St.", City = "Hamilton", Province = "ON", PostalCode = "L7Z 9Z5", PicturePath = "image/user.png", ContactInfo = "Work : 140-464-7242" });
            Customers.Add(new Customer() { Name = "Dustin", LastName = "Cole", Address = "531-6134 Ut St.", City = "St. Thomas", Province = "ON", PostalCode = "K1C 9L0", PicturePath = "image/user.png", ContactInfo = "Email : eget.dictum@Aliquamvulputate.ca" });
            Customers.Add(new Customer() { Name = "Kellie", LastName = "Hanson", Address = "6655 Integer Avenue", City = "Windsor", Province = "ON", PostalCode = "P5Y 0S4", PicturePath = "image/user.png", ContactInfo = "Work : 175-412-9657" });
            Customers.Add(new Customer() { Name = "Cain", LastName = "Booth", Address = "P.O. Box 733, 4514 Id Road", City = "Rimouski", Province = "QC", PostalCode = "J7Y 1R5", PicturePath = "image/user.png", ContactInfo = "Cell : 668-418-2708" });
            Customers.Add(new Customer() { Name = "Todd", LastName = "Christian", Address = "8576 A Av.", City = "Smoky Lake", Province = "AB", PostalCode = "T7W 1W6", PicturePath = "image/user.png", ContactInfo = "Cell : 401-455-7531" });
            Customers.Add(new Customer() { Name = "Hashim", LastName = "Hodge", Address = "800-2799 Phasellus Street", City = "Sunset Point", Province = "AB", PostalCode = "T7K 1L3", PicturePath = "image/user.png", ContactInfo = "Home : 108-300-4964" });
            Customers.Add(new Customer() { Name = "Leah", LastName = "Miller", Address = "P.O. Box 716, 6477 Fringilla Rd.", City = "Shawinigan", Province = "QC", PostalCode = "J8Y 2A2", PicturePath = "images/user.png", ContactInfo = "Cell : 408-758-5810" });
            Customers.Add(new Customer() { Name = "Kenneth", LastName = "Roberts", Address = "Ap #173-2146 Ac Street", City = "Swan Hills", Province = "AB", PostalCode = "T3X 8M7", PicturePath = "image/user.png", ContactInfo = "Home : 122-178-1426" });
            Customers.Add(new Customer() { Name = "Carly", LastName = "Christensen", Address = "773-7929 Dapibus Av.", City = "Legal", Province = "AB", PostalCode = "T2C 7N9", PicturePath = "image/user.png", ContactInfo = "Home : 386-338-5818" });
            Customers.Add(new Customer() { Name = "Malik", LastName = "Compton", Address = "7436 Arcu St.", City = "Cap-Rouge", Province = "QC", PostalCode = "J4V 0H1", PicturePath = "image/user.png", ContactInfo = "Cell : 369-993-0222" });
            Customers.Add(new Customer() { Name = "Victoria", LastName = "King", Address = "261-9542 Luctus Rd.", City = "Whitchurch-Stouffville", Province = "ON", PostalCode = "K8N 2G7", PicturePath = "image/user.png", ContactInfo = "Home : 550-230-2146" });
            Customers.Add(new Customer() { Name = "James", LastName = "Simon", Address = "4628 Enim. Av.", City = "Chilliwack", Province = "BC", PostalCode = "V3Z 2J1", PicturePath = "image/user.png", ContactInfo = "Cell : 343-151-5411" });
            Customers.Add(new Customer() { Name = "Christopher", LastName = "Monroe", Address = "8142 Fusce St.", City = "Baie-Comeau", Province = "QC", PostalCode = "G2B 9R9", PicturePath = "image/user.png", ContactInfo = "Work : 827-654-9939" });

            CurrentCustomer = Customers[1];
        }

        
        private void AddCust(object sender, RoutedEventArgs e)
        {
            Customers.Add(new Customer() { Name = "", LastName = "", Address = "", City = "", PostalCode = "", Province = "", ContactInfo = "", PicturePath = "image/user.png" });
            CurrentCustomer = Customers.Last();

        }

        private void DelCust(object sender, RoutedEventArgs e)
        {
            int index = Customers.IndexOf(CurrentCustomer);
            if(index == 0)
            {
                index = 0;
            }
           else
            {
                index = index - 1;
            }
            Customers.Remove(CurrentCustomer);
            CurrentCustomer = Customers[index];

        }

        
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            CurrentCustomer = (Customer)lv.SelectedItem;
        }
        
    }
}
