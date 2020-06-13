using PARCIAL2.MODELS;
using PARCIAL2.SERVICES;
using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL2.VIEWMODELS
{
 public   class ElementoViewModel:BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

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
            this.apiService = new ApiService();
            this.LoadELemento();

        }


        #endregion


        #region Methods
        private async void LoadELemento()
        {
            var elemento = await this.apiService.Get<Elemento>(
                "https://jsonplaceholder.typicode.com/",
                "photos/ID",
                "ID");
            this.Id = elemento[0].Id;
            this.Tittle = elemento[0].Tittle;
            this.Url = elemento[0].Url;
        }
        #endregion

    }
}
