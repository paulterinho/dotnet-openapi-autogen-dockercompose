using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using petstore.swagger.io;

namespace PetStore.API.Controllers
{
    /// <summary>
    /// This class isn't customized at all. When you extend the base controller class, this is class you get.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PetStoreController : PetStoreControllerBase
    {
        public override Task<HttpResponseMessage> AddPet([BindRequired, FromBody] NewPet body)
        {
            throw new NotImplementedException();
        }

        public override Task<HttpResponseMessage> DeletePet([BindRequired] long id)
        {
            throw new NotImplementedException();
        }

        public override Task<HttpResponseMessage> FindPets([FromQuery] IEnumerable<string> tags = null, [FromQuery] IEnumerable<string> tags2 = null, [FromQuery] int? limit = null)
        {
            throw new NotImplementedException();
        }

        public override Task<HttpResponseMessage> Find_pet_by_id([BindRequired] long id)
        {
            throw new NotImplementedException();
        }
    }
}
