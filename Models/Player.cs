using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Player
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    [Column("Name")]
    public string ?Name { get; set; }
    [Column("CurrentRoomId")]
    public int CurrentRoomId { get; set;}

}