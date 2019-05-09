using AppMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMVVM.Infrastructer
{
  public  class InstanceLocator
    {
        #region Properties
        public MainViewModel Main{ get; set; }
        #endregion

        #region Constructor
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        #endregion
    }
}
