using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.RequestModels
{
    public  class CategoryResponseModel
    {
        [Required]
        public string? Name { get; set; }

        public string? CategoryImage { get; set; }
     //   public bool IsAdminNftCollectionCategories { get; set; }
    }
}
