using System.ComponentModel.DataAnnotations;

namespace concessionaria.domains;

public class Customer
{
    [Key]
    public Guid Id { get; set; }
        
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
        
    [Required]
    [StringLength(100)]
    [EmailAddress]
    public string Email { get; set; }
        
    [Required]
    [StringLength(15)]
    public string Phone { get; set; }
        
    [StringLength(11)]
    public string? DocumentNumber { get; set; }
        
    public DateTime CreatedAt { get; set; }

    public bool IsActive { get; set; }
}