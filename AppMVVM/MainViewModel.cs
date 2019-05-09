using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace AppMVVM.ViewModel
{
    public class MainViewModel
    {
        #region Properties
        public decimal Pesos { get; set; }
        public decimal Dollars { get; set; }
        public decimal Euros { get; set; }
        public decimal Libras { get; set; }
        #endregion

        public ICommand ConvertCommand { get { return new RelayCommand(ConvertMoney); } }

        private async void ConvertMoney()
        {
            if (Pesos <= 0)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un monto mayor a 0", "Aceptar");
                return;
            }
        }

        #region Constructor
        public MainViewModel()
        {

        }
        #endregion
    }
}