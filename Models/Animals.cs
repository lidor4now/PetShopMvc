using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectAnimalShop.Models;

public class Animals
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AnimalId { get; set; }

    [Required(ErrorMessage = "The Name field is required.")]
    [StringLength(100, ErrorMessage = "The Name of the animal can not be more than 100 characters.")]
    public string? Name { get; set; }

    [Range(0, 100, ErrorMessage = "Age must be between 0 and 100.")]
    public int Age { get; set; }

    public string? PictureUrl { get; set; }

    [StringLength(500, ErrorMessage = "The Description can not be more than 200 characters.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "The Category field is required.")]
    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public Categories? Category { get; set; }
    public ICollection<Comments>? Comments { get; set; }

    public Animals(int animalId, string? name, int age, string? pictureUrl, string? description, int categoryId, Categories? category, ICollection<Comments>? comments)
    {
        AnimalId = animalId;
        Name = name;
        Age = age;
        PictureUrl = pictureUrl;
        Description = description;
        CategoryId = categoryId;
        Category = category;
        Comments = comments;
    }

    public Animals()
    {
    }

 
}
