using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Player
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column("Name")]
    public string ?Name { get; set; }
    [Column("CurrentRoomId")]
    public int CurrentRoomId { get; set;}

}