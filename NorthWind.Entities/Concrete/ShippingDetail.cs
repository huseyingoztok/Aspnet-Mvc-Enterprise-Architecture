using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.Concrete
{
    public class ShippingDetail
    {
        [Required(ErrorMessage ="{0} Boş geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} Boş geçilemez")]
        [MinLength(10)]
        [MaxLength(50)]
        public string Address1 { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [MaxLength(50)]
        public string Address3 { get; set; }
        [Required(ErrorMessage = "{0} Boş geçilemez")]
        public string City { get; set; }
        public string Country { get; set; }
        public bool isGift { get; set; }

    }
}
