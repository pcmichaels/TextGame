using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TextAdventure.Model
{
    public class Location
    {
        [StringLength(4000)]
        public string Description { get; set; }
    }
}
