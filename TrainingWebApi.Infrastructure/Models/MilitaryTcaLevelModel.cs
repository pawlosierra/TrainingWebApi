using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TrainingWebApi.Infrastructure.Models
{
    public enum MilitaryTcaLevelModel
    {
        [EnumMember(Value = "Yellow")]
        Yellow,

        [EnumMember(Value = "Red")]
        Red
    }
}
