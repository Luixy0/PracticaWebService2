using PracticaWebService.Models;
using System.Collections.Generic;

namespace PracticaWebService.DataAccess
{
    /// <summary>
    /// Luixandra Azereth Saucedo Quirino
    /// 20/11/2021
    /// Interface de acceso a metodos de persistencia
    /// </summary>
    public interface IDataAccessProvider
    {
        List<CatPersonal> GetPersonal();
        CatPersonal GetPersonalid(int ID);
        bool Postpersonal(CatPersonal persona); 
    }
}
