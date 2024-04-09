using Microsoft.AspNetCore.Mvc;

namespace RoomController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly RoomRepository _roomRepository = new RoomRepository();
        [HttpGet]
        public IActionResult GetAllRooms()
        {
            return Ok(_roomRepository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetRoomById(int id)
        {
            return Ok($"Detalhes da sala com o ID: {id}");
        }

        [HttpPost]
        public IActionResult CreateRoom([FromBody] Room room)
        {
            _roomRepository.Add(room);
            return Ok($"Sala criada com sucesso: {room.Name}");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRoom(int id, [FromBody] Room room)
        {
            return Ok($"Sala com o ID {id} atualizada com sucesso: {room.Name}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            return Ok($"Sala com o ID {id} excluída com sucesso");
        }
    }
}
