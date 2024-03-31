using Microsoft.AspNetCore.Mvc;

namespace RoomController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllRooms()
        {
            // Aqui você implementaria a lógica para obter todas as salas do seu sistema
            // Por enquanto, vamos retornar uma resposta simples com uma mensagem
            return Ok("Listagem de todas as salas");
        }

        [HttpGet("{id}")]
        public IActionResult GetRoomById(int id)
        {
            // Aqui você implementaria a lógica para obter uma sala específica por ID
            // Por enquanto, vamos retornar uma resposta simples com o ID da sala
            return Ok($"Detalhes da sala com o ID: {id}");
        }

        [HttpPost]
        public IActionResult CreateRoom([FromBody] Room room)
        {
            // Aqui você implementaria a lógica para criar uma nova sala com base nos dados fornecidos
            // Por enquanto, vamos retornar uma resposta simples com os detalhes da sala criada
            return Ok($"Sala criada com sucesso: {room.Name}");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRoom(int id, [FromBody] Room room)
        {
            // Aqui você implementaria a lógica para atualizar uma sala existente com base nos dados fornecidos
            // Por enquanto, vamos retornar uma resposta simples com os detalhes da sala atualizada
            return Ok($"Sala com o ID {id} atualizada com sucesso: {room.Name}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            // Aqui você implementaria a lógica para excluir uma sala com base no ID fornecido
            // Por enquanto, vamos retornar uma resposta simples com o ID da sala excluída
            return Ok($"Sala com o ID {id} excluída com sucesso");
        }
    }
}
