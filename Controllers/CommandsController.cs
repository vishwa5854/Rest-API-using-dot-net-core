using System.Collections;
using System.Collections.Generic;
using crueger.Data;
using crueger.Models;
using Microsoft.AspNetCore.Mvc;

namespace crueger.Controllers
{
    
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICruegerRepository _repository;
        
        public CommandsController(ICruegerRepository repository)
        {
            _repository = repository;
        }
        
        
        //GET api/commands/
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
        
    }
}