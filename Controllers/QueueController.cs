using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleProjectSE2.Dtos;
using SimpleProjectSE2.Models;
using SimpleProjectSE2.Repositories.Interfaces;

namespace SimpleProjectSE2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        private readonly IQueueRepository _queueRepository;

        public QueueController(IQueueRepository queueRepository)
        {
            _queueRepository = queueRepository;
        }

        [HttpPost("add")]
        public async Task<ActionResult> Add(MessageDto message)
        {
            Message mm = new Message()
            {
                Id = Guid.NewGuid(),
                Type = message.Type,
                Handled = false,
                JsonContent = message.JsonContent,
                AddedAt = DateTime.Now
            };

            if (await _queueRepository.AddMessage(mm))
            {
                return Ok("A new message was added successfully!");
            }

            return BadRequest("Oops, something went wrong!");
        }

        [HttpGet("handled/{messageId}")]
        public async Task<ActionResult> SetHandled(Guid messageId)
        {
            if (await _queueRepository.SetHandled(messageId))
            {
                return Ok("Requested message was set to handled state!");
            }

            return BadRequest("Oops, something went wrong!");
        }

        [HttpGet("retrieve/email")]
        public async Task<ActionResult> GetUnhandledEmail()
        {
            var message = await _queueRepository.GetUnhandledEmailMessage();

            return Ok(message);
        }

        [HttpGet("retrieve/log")]
        public async Task<ActionResult> GetUnhandledLog()
        {
            var message = await _queueRepository.GetUnhandledLoggingMessage();
            return Ok(message);
        }
    }
}
