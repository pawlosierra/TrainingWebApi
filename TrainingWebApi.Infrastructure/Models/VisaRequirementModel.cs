using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingWebApi.Infrastructure.Models
{
    public class VisaRequirementModel
    {
        //[JsonProperty(PropertyName = "Id")]
        public string id { get; set; }
       // [JsonProperty(PropertyName = "countryId")]
        public string countryId { get; set; }
        //[JsonProperty(PropertyName = "countryOfCitizenshipId")]
        public string countryOfCitizenshipId { get; set; }
       // [JsonProperty(PropertyName = "isVisaRequired")]
        public bool isVisaRequired { get; set; }
    }
}
