using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingWebApi.Models
{
    public class VisaRequirementResponse
    {
        public string countryId { get; set; }
        public string countryOfCitizenshipId { get; set; }
        public bool isVisaRequired { get; set; }
    }
}
