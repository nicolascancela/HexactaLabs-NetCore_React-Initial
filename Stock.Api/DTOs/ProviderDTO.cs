using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Stock.Api.DTOs
{
    public class ProviderDTO
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        //TODO: Consultar como mapear la list OfferedProducts
        public List<string> OfferedProducts { get; set; }
    }
}