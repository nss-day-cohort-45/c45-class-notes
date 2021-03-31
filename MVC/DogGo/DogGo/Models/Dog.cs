using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Models
{
    public class Dog
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        [Required]
        [StringLength(55)]
        public string Breed { get; set; }

        public string Notes { get; set; }

        [DisplayName("Photo")]
        public string ImageUrl { get; set; }
    }
}
