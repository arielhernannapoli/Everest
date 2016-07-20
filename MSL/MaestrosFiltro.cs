using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MSL
{
    static public class MaestrosFiltro
    {
        #region Enum_Tipos_Maestros

        public enum TipoMaestros
        {
            Productos = 1,
            Materiales = 2,
            Soporte = 3,
            TipoSoporte = 4,
            Clientes = 5,
            Medios = 6,
            Plazas = 7,       // cobertura
            Impuestos = 8,
            Editorial = 9,
            SoporteTipoMedio = 10,
            SoporteTipoSoporte = 11,
            Campanas = 12,
            Subcampanas = 13,
            Presupuesto = 14,
            SoportesTodos = 15,
            Proveedor = 16,
            SoporteCobertua = 17,
            Poblacion1 = 18,
            Poblacion2 = 19,
            Secciones = 20,
            PagoMedio = 21,
            Intercambio = 22,
            Compania = 23,
            Delegacion = 24,
            Colocaciones = 25,
            Formatos = 26,
            ProveedorCUIT = 27
        }

        #endregion Enum_Tipos_Maestros

        #region Medios

        public enum MFMedios
        {
            Servicio = 0,
            Television = 1,
            Internet = 2,
            Exterior = 3,
            Prensa = 4,
            Revista = 5,
            Radio = 6,
            Produccion = 7,
            Filiales = 8,
            Varios = 9,
            Cine = 12,
            Marketing = 13
        }

        #endregion Medios
    }
}