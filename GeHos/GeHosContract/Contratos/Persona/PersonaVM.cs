/************************************************************************************************************
 * Descripción: Clase catPersonaVM.
 * Observaciones: 
 * Creado por: MC.
 * Historial de Revisiones:
 * -----------------------------------------------------------------------------------------------
 * Fecha        Evento / Método Autor   Descripción
 * -----------------------------------------------------------------------------------------------
 * 28/12/2016					Implementación inicial.
 * -----------------------------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Utiles.ContratoBase;

namespace GeHosContract.Contrato
{
    public class PersonaVM : ContratoBase
    {
        #region Atributos
        int AperId;
        Int64? AperPadron;
        string AperApellidoyNombre;
        short? AtipoIdSexo;
        DateTime? AperFechaNacimiento;
        short? AprovId;
        int? AperDNI;
        string AperCUIL;
        string AperTelefono;
        string AperCelular;
        string AperEmail;
        bool AperEsContratado;
        short? AperAntiguedadAnios;
        short? AperAntiguedadMeses;
        short? AperAntiguedadDias;
        short AsecId;
        string AperObservaciones;
        short? AperAntiguedadAniosPago;
        short? AperAntiguedadMesesPago;
        short? AperAntiguedadDiasPago;
        short? AperAntiguedadAniosVacaciones;
        short? AperAntiguedadMesesVacaciones;
        short? AperAntiguedadDiasVacaciones;
        string AperFoto;
        short? AprofId;
        bool? AperLeeoEscribe;
        short? AtipoIdEstadoCivil;
        short? ApaisId;
        DateTime? AperFechaCasamiento;
        string AperDomicilio;
        bool? AperAutorizaNotificarSMS;
        int? AperIdPersonaCronos;
        short? AofiId;
        int? AgdId;
        string AperFuncion;
        bool? AperPertenecePlantaAdministrativa;
        string AperNombre;
        string AperApellido;
        int? AcsIdLugarDeTrabajo;
        DateTime? AperFechaIngreso;
        #endregion Atributos

        #region Propiedades - Get/Set

        public int perId
        {
            get { return AperId; }
            set { AperId = value; }
        }
        public Int64? perPadron
        {
            get { return AperPadron; }
            set { AperPadron = value; }
        }
        public string perApellidoyNombre
        {
            get { return AperApellidoyNombre; }
            set { AperApellidoyNombre = value; }
        }
        public short? tipoIdSexo
        {
            get { return AtipoIdSexo; }
            set { AtipoIdSexo = value; }
        }
        public DateTime? perFechaNacimiento
        {
            get { return AperFechaNacimiento; }
            set { AperFechaNacimiento = value; }
        }
        public short? provId
        {
            get { return AprovId; }
            set { AprovId = value; }
        }
        public int? perDNI
        {
            get { return AperDNI; }
            set { AperDNI = value; }
        }
        public string perCUIL
        {
            get { return AperCUIL; }
            set { AperCUIL = value; }
        }
        public string perTelefono
        {
            get { return AperTelefono; }
            set { AperTelefono = value; }
        }
        public string perCelular
        {
            get { return AperCelular; }
            set { AperCelular = value; }
        }
        public string perEmail
        {
            get { return AperEmail; }
            set { AperEmail = value; }
        }
        public bool perEsContratado
        {
            get { return AperEsContratado; }
            set { AperEsContratado = value; }
        }
        public short? perAntiguedadAnios
        {
            get { return AperAntiguedadAnios; }
            set { AperAntiguedadAnios = value; }
        }
        public short? perAntiguedadMeses
        {
            get { return AperAntiguedadMeses; }
            set { AperAntiguedadMeses = value; }
        }
        public short? perAntiguedadDias
        {
            get { return AperAntiguedadDias; }
            set { AperAntiguedadDias = value; }
        }
        public short secId
        {
            get { return AsecId; }
            set { AsecId = value; }
        }
        public string perObservaciones
        {
            get { return AperObservaciones; }
            set { AperObservaciones = value; }
        }
        public short? perAntiguedadAniosPago
        {
            get { return AperAntiguedadAniosPago; }
            set { AperAntiguedadAniosPago = value; }
        }
        public short? perAntiguedadMesesPago
        {
            get { return AperAntiguedadMesesPago; }
            set { AperAntiguedadMesesPago = value; }
        }
        public short? perAntiguedadDiasPago
        {
            get { return AperAntiguedadDiasPago; }
            set { AperAntiguedadDiasPago = value; }
        }
        public short? perAntiguedadAniosVacaciones
        {
            get { return AperAntiguedadAniosVacaciones; }
            set { AperAntiguedadAniosVacaciones = value; }
        }
        public short? perAntiguedadMesesVacaciones
        {
            get { return AperAntiguedadMesesVacaciones; }
            set { AperAntiguedadMesesVacaciones = value; }
        }
        public short? perAntiguedadDiasVacaciones
        {
            get { return AperAntiguedadDiasVacaciones; }
            set { AperAntiguedadDiasVacaciones = value; }
        }
        public string perFoto
        {
            get { return AperFoto; }
            set { AperFoto = value; }
        }
        public short? profId
        {
            get { return AprofId; }
            set { AprofId = value; }
        }
        public bool? perLeeoEscribe
        {
            get { return AperLeeoEscribe; }
            set { AperLeeoEscribe = value; }
        }
        public short? tipoIdEstadoCivil
        {
            get { return AtipoIdEstadoCivil; }
            set { AtipoIdEstadoCivil = value; }
        }
        public short? paisId
        {
            get { return ApaisId; }
            set { ApaisId = value; }
        }
        public DateTime? perFechaCasamiento
        {
            get { return AperFechaCasamiento; }
            set { AperFechaCasamiento = value; }
        }
        public string perDomicilio
        {
            get { return AperDomicilio; }
            set { AperDomicilio = value; }
        }
        public bool? perAutorizaNotificarSMS
        {
            get { return AperAutorizaNotificarSMS; }
            set { AperAutorizaNotificarSMS = value; }
        }
        public int? perIdPersonaCronos
        {
            get { return AperIdPersonaCronos; }
            set { AperIdPersonaCronos = value; }
        }
        public short? ofiId
        {
            get { return AofiId; }
            set { AofiId = value; }
        }
        public int? gdId
        {
            get { return AgdId; }
            set { AgdId = value; }
        }
        public string perFuncion
        {
            get { return AperFuncion; }
            set { AperFuncion = value; }
        }
        public bool? perPertenecePlantaAdministrativa
        {
            get { return AperPertenecePlantaAdministrativa; }
            set { AperPertenecePlantaAdministrativa = value; }
        }
        public string perNombre
        {
            get { return AperNombre; }
            set { AperNombre = value; }
        }
        public string perApellido
        {
            get { return AperApellido; }
            set { AperApellido = value; }
        }
        public int? csIdLugarDeTrabajo
        {
            get { return AcsIdLugarDeTrabajo; }
            set { AcsIdLugarDeTrabajo = value; }
        }
        public DateTime? perFechaIngreso
        {
            get { return AperFechaIngreso; }
            set { AperFechaIngreso = value; }
        }

        #endregion Propiedaddes - Get/Set

    }
}
