using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;


namespace Utiles.ContratoBase
{
    public class ContratoBase : Utiles.RespuestaGenerica.RespuestaGenerica, INotifyPropertyChanged, IEditableObject, IDataErrorInfo, IComparable<ContratoBase>
    {
        public bool HayDiferencias(ContratoBase copia)
        {
            var propDiferente = string.Empty;
            var res = false;
            var properties = this.GetType().GetProperties(System.Reflection.BindingFlags.DeclaredOnly |
                                                            System.Reflection.BindingFlags.GetProperty |
                                                            System.Reflection.BindingFlags.Public |
                                                            System.Reflection.BindingFlags.Instance);
            foreach (var prop in properties)
            {
                if (!prop.Name.Equals("Item"))
                {
                    var propEnCopia = copia.GetType().GetProperty(prop.Name);
                    if (propEnCopia != null)
                    {
                        var valorOriginal = propEnCopia.GetValue(this);
                        var valorCopia = propEnCopia.GetValue(copia);

                        
                        res = (valorCopia != null && valorOriginal != null) ? !valorCopia.Equals(valorOriginal) :
                            (valorCopia == null && valorOriginal == null) ? false : true;
                    }
                }
                if (res)
                {
                    propDiferente = prop.Name;
                    break;
                }

            }
            return res;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        [ScaffoldColumn(false)]
        public string LastValidationError
        {
            get { return lastValidationError; }
            protected set
            {
                lastValidationError = value;
                RaisePropertyChanged("LastValidationError");
            }
        }
        [ScaffoldColumn(false)] 
        public string LastInvalidProperty
        {
            get { return lastInvalidProperty; }
            protected set
            {
                lastInvalidProperty = value;
                RaisePropertyChanged("LastInvalidProperty");
            }
        }

        public virtual bool EsValida()
        {
            var propiedades = this.GetType().GetProperties();
            foreach (var propiedad in propiedades)
            {
                var mensaje = this[propiedad.Name];
                if (mensaje != null)
                {
                    LastValidationError = mensaje;
                    LastInvalidProperty = propiedad.Name;
                    return false;
                }
            }
            LastValidationError = null;
            LastInvalidProperty = null;
            return true;
        }

        public static ContratoBase Clone(ContratoBase objetoAClonar)
        {
            var to = Activator.CreateInstance(objetoAClonar.GetType());
            var from = objetoAClonar;

            if (from != null)
            {
                var fromTypeProperties = new List<PropertyInfo>(from.GetType().GetProperties());

                foreach (var property in to.GetType().GetProperties())
                {
                    if (property.GetSetMethod() != null && fromTypeProperties.Contains(property))
                    {
                        to.GetType().GetProperty(property.Name).SetValue(to, property.GetValue(from));
                    }
                }

            }
            return to as ContratoBase;
        }

        public static T Clone<F, T>(F objetoAClonar)
        {
            var to = Activator.CreateInstance<T>();
            var from = objetoAClonar;

            if (from != null)
            {
                var fromTypeProperties = new List<PropertyInfo>(typeof(F).GetProperties());

                foreach (var property in typeof(T).GetProperties())
                {
                    var propertyFrom = fromTypeProperties.Where(p => p.Name.Equals(property.Name) &&
                        p.PropertyType.Equals(property.PropertyType)).FirstOrDefault();
                    if (property.GetSetMethod() != null && propertyFrom != null)
                    {
                        typeof(T).GetProperty(property.Name).SetValue(to, propertyFrom.GetValue(from));
                    }
                }

            }
            return to;
        }

        public virtual string GetValoresEnColumna()
        {
            return null;
        }

        public virtual string GetValoresEnColumnaParaControlBusqueda()
        {
            return null;
        }

        public virtual string GetId()
        {
            return null;
        }

        public virtual string GetPadreId()
        {
            return null;
        }

        public virtual string GetEstado()
        {
            return null;
        }

        private string descripcion;
        [ScaffoldColumn(false)]
        public string Descripcion
        {
            get { return GetDescripcion(); }
            set { descripcion = value; RaisePropertyChanged("Descripcion"); }
        }

        public virtual string GetDescripcion()
        {
            return this.GetId();
        }
        public virtual string GetDescripcionFull()
        {
            return null;
        }
        private string descripcionFull;
        [ScaffoldColumn(false)]
        public string DescripcionFull
        {
            get { return GetDescripcionFull(); }
            set { descripcionFull = value; RaisePropertyChanged("DescripcionFull"); }
        }
        public virtual string GetParametrosDeBusqueda()
        {
            return null;
        }

        /// <summary>
        /// Retorna arreglo de String con Nombre de Propiedades.
        /// </summary>
        /// <returns></returns>
        public string[] GetPropertiesNames()
        {
            string propiedades = "";
            string[] props = null;
            Type t = this.GetType();
            var s = t.GetCustomAttributes(true);
            System.Reflection.PropertyInfo[] properties = t.GetProperties();
            foreach (System.Reflection.PropertyInfo property in properties)
            {
                var atts = property.GetCustomAttributes(
                typeof(DisplayNameAttribute), true);

                if (atts.Length > 0)
                {
                    propiedades += property.Name + "|";
                }
            }
            if (propiedades.LastIndexOf('|') > -1)
                propiedades = propiedades.Remove(propiedades.LastIndexOf('|'), 1);
            props = propiedades.Split('|');
            return props;
        }

        private bool editando;
        [ScaffoldColumn(false)]
        public bool Editando
        {
            get { return editando; }
            set
            {
                editando = value;
                RaisePropertyChanged("Editando");
            }
        }

        public string ValoresEnColumna
        {
            get { return GetValoresEnColumna(); }
        }

        private string user;
        private string lastValidationError;
        private string lastInvalidProperty;

        [ScaffoldColumn(false)]
        public string User
        {
            get { return user; }
            set { user = value; RaisePropertyChanged("User"); }
        }


        public void BeginEdit()
        {
            DoBeginEdit();
            Editando = true;
        }

        protected virtual void DoBeginEdit()
        {

        }

        public void Actualizar(string propertyName = "")
        {
            var mytype = this.GetType();
            var propiedades = mytype.GetProperties(System.Reflection.BindingFlags.DeclaredOnly |
                                                            System.Reflection.BindingFlags.GetProperty |
                                                            System.Reflection.BindingFlags.Public |
                                                            System.Reflection.BindingFlags.Instance);

            if (!string.IsNullOrEmpty(propertyName))
            {
                var prop = propiedades.Where(p => p.Name.Equals(propertyName)).FirstOrDefault();
                if (prop != null)
                    RaisePropertyChanged(prop.Name);
            }
            else
            {
                foreach (var propiedad in propiedades)
                {
                    RaisePropertyChanged(propiedad.Name);
                }
            }
        }

        public void CancelEdit()
        {
            Editando = false;
            DoCancelEdit();
            // Actualizar();
        }

        protected virtual void DoCancelEdit() { }

        public void EndEdit()
        {
            Editando = false;
            DoEndEdit();
        }

        protected virtual void DoEndEdit()
        {

        }

        public virtual string Error
        {
            get { return string.Empty; }
        }

        public virtual string this[string columnName]
        {
            get { return null; }
        }

        public override string ToString()
        {
            return Descripcion;
        }

        public int CompareTo(ContratoBase other)
        {
            var myparts = this.GetId().Split('.');
            var itsparts = other.GetId().Split('.');
            int res = 0;
            var cant = Math.Min(myparts.Length, itsparts.Length);
            for (int i = 0; i < cant; i++)
            {
                res = Convert.ToInt32(myparts[i]).CompareTo(Convert.ToInt32(itsparts[i]));
                if (res != 0)
                {
                    break;
                }
            }
            if (res == 0)
                res = myparts.Length.CompareTo(itsparts.Length);
            return res;
        }
    }
}

