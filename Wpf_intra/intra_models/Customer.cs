using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace intra_models
{
    public class Customer:INotifyPropertyChanged
    {
        public string Name;
        public string LastName;
        public string Address;
        public string City;
        public string Province;
        public string PostalCode;
        public string ContactInfo;
        public string PicturePath;

        public string name
        {
            get => Name;
            set
            {
                Name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Info));
            }
        }
        public string lastname
        {
            get => LastName;
            set
            {
                LastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Info));
            }
        }
        public string address
        {
            get => Address;
            set
            {
                Address = value;
                OnPropertyChanged();
            }
        }
        public string city
        {
            get => City;
            set
            {
                City = value;
                OnPropertyChanged();
            }
        }
        public string province
        {
            get => Province;
            set
            {
                Province = value;
                OnPropertyChanged();
            }
        }
        public string postalcode
        {
            get => PostalCode;
            set
            {
                PostalCode = value;
                OnPropertyChanged();
            }
        }
        public string contactinfo
        {
            get => ContactInfo;
            set
            {
                ContactInfo = value;
                OnPropertyChanged();
            }
        }
        public string picturepath
        {
            get => PicturePath;
            set
            {
                PicturePath = value;
                OnPropertyChanged();
            }
        }
        /*
        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }*/

        public string Info => $"{LastName} , {Name}";

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
