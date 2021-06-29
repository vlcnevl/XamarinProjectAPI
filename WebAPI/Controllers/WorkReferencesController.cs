using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkReferencesController : ControllerBase
    {
        IWorkReferenceService _workReferenceService;

        public WorkReferencesController(IWorkReferenceService workReferenceService)
        {
            _workReferenceService = workReferenceService;       
        }

        [HttpPost("add")]
        public IActionResult Add(WorkReference workReference)
        {
            var result = _workReferenceService.Add(workReference);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(WorkReference workReference)
        {
            var result = _workReferenceService.Update(workReference);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(WorkReference workReference)
        {
            var result = _workReferenceService.Delete(workReference);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _workReferenceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _workReferenceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _workReferenceService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyworkid")]
        public IActionResult GetByWorkId(int workId)
        {
            var result = _workReferenceService.GetByWorkId(workId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getworkdetails")]
        public IActionResult GetWorkDetails(int workId)
        {
            var result = _workReferenceService.GetWorkDetails(workId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuserapplication")]
        public IActionResult GetUserApplication(int userId)
        {
            var result = _workReferenceService.GetUserApplication(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
