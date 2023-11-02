using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace genericdappertest;

[Table("Address")]
public class AddressDTO
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Column("Address")]
    public string Address { get; set; }

    [Column("City")]
    public string City { get; set; }

    [Column("State")]
    public string State { get; set; }
}