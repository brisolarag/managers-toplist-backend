using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using managers_back.src.managers.dtos;
using managers_back.src.managers.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace managers_back.src.managers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagerController(IManagerService service) : ControllerBase
    {
        private readonly IManagerService _service = service;

        [HttpGet]
        public async Task<ActionResult<List<ManagerModel>>> GetManagers() {
            try {
                var managers = await _service.GetManagers();
                return Ok(new {success = true, data = managers});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }

        [HttpGet("{managerId:int}")]
        public async Task<ActionResult<ManagerModel>> GetManager(uint managerId) {
            try {
                var manager = await _service.GetManager(managerId);
                return Ok(new {success = true, data = manager});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }

        [HttpPost]
        public async Task<ActionResult<ManagerModel>> NewManager([FromBody] NewManagerRequest request) {
            try {
                var manager = await _service.NewManager(request);
                return Ok(new {success = true, data = manager});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }

        [HttpDelete("{managerId:int}")]
        public async Task<ActionResult<ManagerModel>> RemoveManager(uint managerId) {
            try {
                var manager = await _service.RemoveManager(managerId);
                return Ok(new {success = true, data = manager});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }

        [HttpPatch("{managerId:int}")]
        public async Task<ActionResult<ManagerModel>> EditManager(uint managerId, [FromBody] EditManagerRequest request) {
            try {
                var manager = await _service.EditManager(managerId, request);
                return Ok(new {success = true, data = manager});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }

        [HttpPatch("addStack")]
        public async Task<ActionResult<ManagerModel>> AddStack(uint managerId, [FromBody] string newStack) {
            try {
                var manager = await _service.AddStack(managerId, newStack);
                return Ok(new {success = true, data = manager});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }

        [HttpPatch("removeStack")]
        public async Task<ActionResult<ManagerModel>> RemoveStack(uint managerId, [FromBody] string newStack) {
            try {
                var manager = await _service.RemoveStack(managerId, newStack);
                return Ok(new {success = true, data = manager});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }

        [HttpGet("stacks")]
        public async Task<ActionResult<List<string>>> GetStacks(uint managerId) {
            try {
                var stacks = await _service.GetStacks(managerId);
                return Ok(new {success = true, data = stacks});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }
        
        [HttpPatch("changePosition")]
        public async Task<ActionResult> ChangePosition([FromBody] List<ManagerRankUpdate> updates) {
            try {
                await _service.ChangePosition(updates);
                return Ok(new {success= true});
            } catch (Exception ex) {
                return BadRequest(new {success = false, msg = ex.Message});
            }
        }

    }
}