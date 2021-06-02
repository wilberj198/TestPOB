using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIO
{
    public class ClassStore
    {
        public int IdStore { get; set; }
        public string Nombre { get; set; }
        public bool CreateStore()
        {            
            try
            {
                //implementar la funcion Create
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
