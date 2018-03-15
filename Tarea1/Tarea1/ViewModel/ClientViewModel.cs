using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Model;

namespace Tarea1.ViewModel
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        #region Constructor
        public ClientViewModel()
        {
            InitClass();
        }

        #endregion
        #region Singleton
        private static ClientViewModel instance = null;
        public static ClientViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new ClientViewModel();
            }
            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
            {
                instance = null;
            }
        }
        #endregion
        #region Instances

        private ObservableCollection<Client> _LstClients = new ObservableCollection<Client>();
        public ObservableCollection<Client> LstClients
        {
            get
            {
                return _LstClients;
            }

            set
            {
                _LstClients = value;
                OnPropertyChanged("LstClients");

            }

        }
        private Client _ActualClient { get; set; }

        public Client ActualClient
        {
            get
            {
                return _ActualClient;
            }
            set
            {
                _ActualClient = value;
                OnPropertyChanged("ActualClient");
            }
        }
       
        #endregion
        #region InitClass and InitCommands
        private async void InitClass()
        {

            LstClients = await Client.GetClients();
        }
        #endregion
        #region INotifyPropertyChange Interface Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {

            if (propertyName != null && PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
    }
}
