using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace concessionaria.domains;

public class Car
{
    [Key]
    public Guid Id { get; set; }
        
    [Required]
    [StringLength(50)]
    public string Brand { get; set; }
        
    [Required]
    [StringLength(50)]
    public string Model { get; set; }
        
    [Required]
    public int ManufactureYear { get; set; }
        
    [Required]
    [StringLength(8)]
    public string LicensePlate { get; set; }
        
    [StringLength(20)]
    public string ChassiNumber { get; set; }
        
    public int Odometer { get; set; }
        
    [StringLength(20)]
    public string? Color { get; set; }
        
    public DateTime CreatedAt { get; set; }
    
    [Required]
    public Guid CustomerId { get; set; }
    
    [ForeignKey("CustomerId")]
    public virtual Customer Customer { get; set; }
    
}