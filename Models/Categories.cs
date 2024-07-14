using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectAnimalShop.Models;

public class Categories
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "The Name field is required.")]
    [StringLength(100, ErrorMessage = "The Name can not be more than 100 characters.")]
    public string? Name { get; set; }
    public ICollection<Animals>? Animals { get; set; }

    public Categories(string? name, ICollection<Animals>? animals)
    {
        Name = name;
        Animals = animals;
    }

    public Categories()
    {

    }

}
