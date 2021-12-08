using Microsoft.AspNetCore.Mvc;
using PracticaWebService.DataAccess;
using PracticaWebService.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;


namespace PracticaWebService.Controles
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatPersonalController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public CatPersonalController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet]
        public IEnumerable<CatPersonal> Get()
        {
            return _dataAccessProvider.GetPersonal();
        }

        [HttpGet("{Id}")]  

        public CatPersonal Getid(int Id)
        {
            CatPersonal personal = _dataAccessProvider.GetPersonalid(Id);

            return personal;

        }
        [HttpPost]
        public object Post(CatPersonal nuevo)
        {
            bool guardar = _dataAccessProvider.Postpersonal(nuevo);
            if (!guardar)
            {
                return BadRequest();
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);    

            }
        }
    }
}
