//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.6.2.0 (NJsonSchema v10.1.23.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace petstore.swagger.io
{
    using System = global::System;
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.6.2.0 (NJsonSchema v10.1.23.0 (Newtonsoft.Json v12.0.0.0))")]
    [Microsoft.AspNetCore.Mvc.Route("api")]
    public abstract class PetStoreControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <param name="tags">tags to filter by</param>
        /// <param name="limit">maximum number of results to return</param>
        /// <returns>pet response</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pets")]
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Pet>> FindPets([Microsoft.AspNetCore.Mvc.FromQuery] System.Collections.Generic.IEnumerable<string> tags, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit);
    
        /// <param name="body">Pet to add to the store</param>
        /// <returns>pet response</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("pets")]
        public abstract System.Threading.Tasks.Task<Pet> AddPet([Microsoft.AspNetCore.Mvc.FromBody] NewPet body);
    
        /// <param name="id">ID of pet to fetch</param>
        /// <returns>pet response</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pets/{id}")]
        public abstract System.Threading.Tasks.Task<Pet> Find_pet_by_id(long id);
    
        /// <param name="id">ID of pet to delete</param>
        /// <returns>pet deleted</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("pets/{id}")]
        public abstract System.Threading.Tasks.Task DeletePet(long id);
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.23.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Pet : NewPet
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public long Id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.23.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class NewPet 
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.23.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Error 
    {
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        public int Code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108