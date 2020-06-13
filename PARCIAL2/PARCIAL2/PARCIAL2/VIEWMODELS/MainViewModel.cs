using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL2.VIEWMODELS
{
    public class MainViewModel
    {

        #region ViewModels
        public ElementoViewModel Elemento { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.Elemento = new ElementoViewModel();
        }
        #endregion


    }
}
