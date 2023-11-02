using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace genericdappertest;

[Table("People")]
public class PeopleDTO
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Column("FirstName")]
    public string FirstName { get; set; }

    [Column("Lastname")]
    public string Lastname { get; set; }
}