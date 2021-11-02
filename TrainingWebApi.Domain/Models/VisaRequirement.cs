using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingWebApi.Domain.Models
{
    public class VisaRequirement
    {
  
        //public string Id { get; set; }

        public string countryId { get; set; }
  
        public string countryOfCitizenshipId { get; set; }
     
        public bool isVisaRequired { get; set; }
    }
}
