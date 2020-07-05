using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public override Task<Pet> AddPet([FromBody] NewPet body)
        {
            throw new NotImplementedException();
        }

        public override Task DeletePet(long id)
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<Pet>> FindPets([FromQuery] IEnumerable<string> tags, [FromQuery] int? limit)
        {
            throw new NotImplementedException();
        }

        public override Task<Pet> Find_pet_by_id(long id)
        {
            throw new NotImplementedException();
        }
    }
}
