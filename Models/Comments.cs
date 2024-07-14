using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Authentication;

namespace FinalProjectAnimalShop.Models;

public class Comments
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CommentId { get; set; }

    [Required(ErrorMessage = "The Text field is required.")]
    [StringLength(500, ErrorMessage = "The Comment can not be more than 200 characters.")]
    public string? Text { get; set; }

    [Required(ErrorMessage = "The Animal field is required.")]
    public int AnimalId { get; set; }

    [ForeignKey("AnimalId")]
    public Animals? Animal { get; set; }


    public Comments(string? text, int animalId, Animals? animal)
    {
        Text = text;
        AnimalId = animalId;
        Animal = animal;
    }

    public Comments()
    {

    }

}

