using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TrainingWebApi.Infrastructure.Models
{
    public class Countries
    {
        //[JsonProperty(PropertyName ="id")]
        //public string id { get; set; }
        //[JsonProperty(PropertyName = "country")]
        //public string country { get; set; }
        //[JsonProperty(PropertyName = "nationalities")]
        //public string nationalities { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "nationalities")]
        public List<NationalityModel> Nationalities { get; set; }

        [JsonProperty(PropertyName = "iso2Code")]
        public string Iso2Code { get; set; }

        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        [JsonProperty(PropertyName = "military")]
        public MilitaryTcaLevelModel? Military { get; set; }

       // [JsonProperty(PropertyName = "civil")]
        //public CivilTcaLevelModel? Civil { get; set; }
    }

    public class NationalityModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }
    }
}
