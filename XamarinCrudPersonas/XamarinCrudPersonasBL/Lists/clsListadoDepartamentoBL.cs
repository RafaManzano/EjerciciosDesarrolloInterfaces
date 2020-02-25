using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinCrudPersonasDAL.Lists;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasBL.Lists
{
    public class clsListadoDepartamentoBL
    {
        /// <summary>
        /// Capa de union entre UI y DAL
        /// </summary>
        /// <returns>El listado de departamentos</returns>
        public async Task<List<clsDepartamento>> listadoDepartamentos()
        {
            clsListadoDepartamentosDAL capaDAL = new clsListadoDepartamentosDAL();
            return await capaDAL.listadoDepartamentos();
        }
    }
}
