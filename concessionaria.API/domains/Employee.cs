using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace concessionaria.domains;

public class Employee
{
    [Key]
    public Guid Id { get; set; }
        
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
        
    [Required]
    [StringLength(50)]
    public string Position { get; set; }

    [StringLength(100)]
    [EmailAddress]
    [Required]
    public string Email { get; set; }
        
    [StringLength(15)]
    [Required]
    public string Phone { get; set; }
    
    [Required]
    public DateTime HireDate { get; set; }
    
    [Required]
    public decimal? Salary { get; set; }
        
    public bool IsActive { get; set; } = true;
    
    public virtual ICollection<ServiceAppointment> ServiceAppointments { get; set; } = new List<ServiceAppointment>();
}