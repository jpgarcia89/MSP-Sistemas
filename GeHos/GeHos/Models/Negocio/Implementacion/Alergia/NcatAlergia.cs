/************************************************************************************************************
 * Descripción: Clase Negocio Entidad catAlergia.
 * Observaciones: 
 * Creado por: MC.
 * Historial de Revisiones:
 * -----------------------------------------------------------------------------------------------
 * Fecha        Evento / Método Autor   Descripción
 * -----------------------------------------------------------------------------------------------
 * 07/12/2016					Implementación inicial.
 * -----------------------------------------------------------------------------------------------
*/
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Web;
using GeHos.Models.DB;
using Utiles.RespuestaGenerica;

namespace GeHos.Models
{
    public class NcatAlergia:Negocio<catAlergia>,IcatAlergia
    {
			#region Constructores 

			public NcatAlergia(IUnitOfWork uow) : base(uow) { }

			public NcatAlergia() { }

			#endregion 

			public catAlergiaVM TraerEntidad(object entidad)
			{

				var id = ((object[])entidad)[0]; 

				var catalergia = _repositorio.Find(id);

				catAlergiaVM item= new catAlergiaVM();				

				MapObjects(catalergia, item);

			item.Ok = true;

			return item;
			}

			public CcatAlergiaVM TraerEntidades(object parametros)
			{

			CcatAlergiaVM resultado = new CcatAlergiaVM();

			resultado.ListaItems= new ObservableCollection<catAlergiaVM>(_repositorio.GetAll().Select(res => new catAlergiaVM()
				{ 
				#region MappingsTEs
alId=res.alId,
alNombre=res.alNombre,
alEsMedicamento=res.alEsMedicamento,
				#endregion MappingsTEs
				}));

			resultado.Ok = true;

			return resultado;
	
			}

			public RespuestaGenerica AgregarEntidad(object entidad)
			{
				var entidadEditada = (catAlergiaVM)((object[])entidad)[0];

				//Crea una nueva instancia de Entidad
catAlergia entidadNueva = new catAlergia();

				 MapObjects(entidadEditada, entidadNueva);

				//Agrega al repositorio de Entidad una nueva Entidad
				_repositorio.Add(entidadNueva);

				//Confirma datos en BD a traves del UoF
				return _unitOfWork.SaveChanges();
			}

			public RespuestaGenerica ActualizarEntidad(object entidad)
			{
				var entidadEditada = (catAlergiaVM)((object[])entidad)[0];

				object codigo = entidadEditada.alId;

				//Busca Entidad en DB
catAlergia entidadBase = _repositorio.Find(codigo);

				 MapObjects(entidadEditada, entidadBase);

				//Actualiza repositorio de Entidad
				_repositorio.Update(entidadBase);

				//Confirma datos en BD a traves del UoF
				return _unitOfWork.SaveChanges();
			}

			public RespuestaGenerica RemoverEntidad(object entidad)
			{
				var codigo = (catAlergiaVM)((object[])entidad)[0];

				//Obtiene Entidad a Eliminar
catAlergia entidadBaja = _repositorio.Find(codigo);

				//Elimina del repositorio Entidad de BD
				_repositorio.Remove(entidadBaja);

				//Confirma datos en BD a traves del UoF
				return _unitOfWork.SaveChanges();
			}

		}																
}																	
