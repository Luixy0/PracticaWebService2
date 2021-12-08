using PracticaWebService.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticaWebService.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;
        public DataAccessProvider(PostgreSqlContext context) {
           _context = context;

        }

        /// <summary>
        /// Luixandra Azereth Saucedo Quirino
        /// Creacion 20/11/2021
        /// Metodo que obtiene listado completo de registros 
        /// en catpersonal
        /// </summary>
        /// <returns>List<CatPersonal></returns>
        public List<CatPersonal> GetPersonal()
        {
            return _context.catpersonal.ToList();
        }
        public CatPersonal GetPersonalid(int ID)
        {
            return _context.catpersonal.Where(Z => Z.id == ID).FirstOrDefault();
        }
        public bool Postpersonal(CatPersonal Per) 
        {
        try
            {
                _context.Add(Per);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
