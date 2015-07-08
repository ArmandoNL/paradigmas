using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using System.Data;
using System.IO;

namespace IdentificacionPlantas
{
    class ManejoExcel
    {
        public struct EntidadHojaExcel {
            DataRow fila;
            
        };
       
        /*
        public DataTable ToEntidadHojaExcelList(string direccion)
        {
            var book = new ExcelQueryFactory(direccion);
            DataTable resultado = new DataTable();

            
            bool este = true;
            while (este)
            {
                 var fila = book.Worksheet();
            }

            var australia = from fila in book.Worksheet() 
                select new 
                { 
                   Country = fila[0], 
                   BookCode = fila[1]
                }; 
            
            book.Dispose();
            return resultado;
        }*/

        /*public void leerArchivo(String direccion)
        {
            FileStream archivo = new FileStream(direccion, FileMode.Open);
            archivo.BeginRead(; 
        }*/
    }
}
