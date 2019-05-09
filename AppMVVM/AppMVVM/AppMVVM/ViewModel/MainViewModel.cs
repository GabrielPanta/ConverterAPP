using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppMVVM.ViewModel
{
     public class MainViewModel
    {
        #region Properties
        public Double Moneda { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {

        }
        #endregion

        public ICommand CommandConvertir { get { return new RelayCommand(ConvertMoney); } }

        private  async void ConvertMoney()
        {
            if (Moneda<=0)
             {
                await App.Current.MainPage.DisplayAlert("Error", "Debe Ingresar Un valor mayor a cero ", "Aceptar");
                return;
             }
            throw new NotImplementedException();
        }
    }
}
