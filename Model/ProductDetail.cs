using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Model
{
    public class ProductDetail
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }

        public DateTime releaseDate { get; set; }
        public string Description { get; set; }
        [Required]
        public double price { get; set; }
        public double starRating { get; set; }

        public string imageUrl { get; set; }



    }
}
