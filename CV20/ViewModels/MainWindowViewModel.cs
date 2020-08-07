using System;
using System.Collections.Generic;
using System.Text;
using CV20.ViewModels.Base;

namespace CV20.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title Windows

        ///<summary>
        /// Title Windows
        ///</summary>

        private string _Title = "Анализ статистики CV19";

        public string Title 
        {
            get => _Title;
            set => Set(ref _Title, value);
            //set
            //{
            //    //if(Equals(_Title,value))return;
            //    //_Title = value;
            //    //OnPropertyChanged();

            //    Set(ref _Title, value);
            //}
        }

        #endregion

    }

}
