using System.ComponentModel.DataAnnotations.Schema;
public class Action
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column("Name")]
    public string ?Name { get; set; }
    [Column("RoomId")]
    public int RoomId { get; set; }
    [Column("PlayerId")]
    public int PlayerId { get; set;}

}