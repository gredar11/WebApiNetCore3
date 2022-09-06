using AutoMapper;
using CommandAPI.Data;
using CommandAPI.Dtos;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        private readonly IMapper _mapper;
        public CommandsController(ICommandAPIRepo commandrepo, IMapper mapper)
        {
            _mapper = mapper;
            _repository = commandrepo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commands = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<CommandReadDto>> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);
            if(command == null)
                return NotFound();
            return Ok(_mapper.Map<CommandReadDto>(command));
        }
    }
}
