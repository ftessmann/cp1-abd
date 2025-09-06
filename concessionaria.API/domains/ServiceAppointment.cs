using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace concessionaria.domains;

public class ServiceAppointment
{
    [Key]
    public Guid Id { get; set; }
        
    [Required]
    public DateTime ServiceDate { get; set; }
        
    [Required]
    [StringLength(20)]
    public string Status { get; set; }
        
    [Required]
    [StringLength(50)]
    public string ServiceType { get; set; }
        
    [Required]
    [StringLength(1000)]
    public string Description { get; set; }
        
    public DateTime CreatedAt { get; set; }
        
    public DateTime? CompletedAt { get; set; }
    
    [Required]
    public Guid CarId { get; set; }
    [ForeignKey("CarId")]
    public Car Car { get; set; }
    
    [Required]
    public Guid EmployeeId { get; set; }
    [ForeignKey("EmployeeId")]
    public Employee Employee { get; set; }
    
    public Guid QuoteId { get; set; }
    [ForeignKey("QuoteId")]
    public Quote Quote { get; set; }
}