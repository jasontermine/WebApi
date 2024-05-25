using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApi.Models;

public class Person
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonIgnore]
    public Guid uuid { get; set; }
    [Required]
    public string Name { get; set; }
    [Range(0, int.MaxValue)]
    public int Age { get; set; }
}