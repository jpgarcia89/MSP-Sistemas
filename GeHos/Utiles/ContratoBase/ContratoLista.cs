using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utiles.ContratoBase
{
    public class ContratoLista<T> : ContratoBase
    {

        private ObservableCollection<T> listaItems;

        public ObservableCollection<T> ListaItems
        {
            get { return listaItems; }
            set { listaItems = value; }
        }

        private T dataItem;

        public T DataItem
        {
            get { return dataItem; }
            set { dataItem = value; RaisePropertyChanged("DataItem"); }
        }

        public ContratoLista()
        {
            ListaItems = new ObservableCollection<T>();
        }


    }
}
