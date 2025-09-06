using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace concessionaria.domains;

public class Quote
{
    [Key]
    public Guid Id { get; set; }
        
    [Required]
    public int LaborCost { get; set; }
        
    [Required]
    public int PartsCost { get; set; }
    
    public int AdditionalCost { get; set; }
        
    public DateTime CreatedAt { get; set; }
        
    public DateTime ValidUntil { get; set; }
        
    public bool IsApproved { get; set; }
        
    public DateTime ApprovedAt { get; set; }
    
}