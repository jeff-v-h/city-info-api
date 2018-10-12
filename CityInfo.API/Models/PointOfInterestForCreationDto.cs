using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    // Althought exactly the same as PointOfInterestCreationDto, DTOs should not be
    // reusable as any change in a requirement can suddenly cause a need for different use cases.
    // ie. one context needs the old DTO, while the new may need an updated one.
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage ="You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
