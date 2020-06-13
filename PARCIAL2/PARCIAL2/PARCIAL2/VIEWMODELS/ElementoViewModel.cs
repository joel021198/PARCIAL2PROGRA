using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL2.VIEWMODELS
{
 public   class ElementoViewModel:BaseViewModel
    {
        //apiservic

        #region Attributes
        private string id;
        private string tittle;
        private string url;
        #endregion


        #region Properties
        public string Id 
        {
            get {return this.id;}
            set { SetValue(ref this.id, value); }
        
        }
        public string Tittle 
        {
            get { return this.tittle; }
            set { SetValue(ref this.tittle, value); }
        }
        public string Url
        { 
            get { return this.url; }
            set { SetValue(ref this.url, value); }
        }
        #endregion



        #region Constructor
        public ElementoViewModel ()
        {
            this.LoadELemento();

        }

        private void LoadELemento()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
