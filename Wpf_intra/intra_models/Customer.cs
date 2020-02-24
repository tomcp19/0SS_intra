using System;
using System.ComponentModel;

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

        public string Info { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
