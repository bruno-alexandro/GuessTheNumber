
using Microsoft.AspNetCore.Connections;

public class RoomRepository : IRoomRepository
{
    private readonly ApplicationDbContext _context = new ApplicationDbContext();
    public void Add(Room room)
    {
        _context.Add(room);
        _context.SaveChanges();
    }

    public List<Room> Get()
    {
        throw new NotImplementedException();
    }
}