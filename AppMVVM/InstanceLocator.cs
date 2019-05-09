namespace AppMVVM.Infrastructure
{
    using AppMVVM.ViewModel;


    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructor
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        #endregion
    }
}
