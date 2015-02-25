using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XamarinWebApi.Entidades;

namespace XamarinWebApi.Controllers
{
    public class CodificandoController : ApiController
    {
        public List<Palestra> Get()
        {
            return Palestra.Listar();
        }
    }
}