using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey_w_Validations.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        public string name {get;set;}

        [Required]
        public string location {get;set;}

        [Required]
        public string language {get;set;}

        [MinLength(20)]
        public string area {get;set;}
    }
}