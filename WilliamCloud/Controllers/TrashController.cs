using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WilliamCloud.ObjectData;

namespace WilliamCloud.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TrashController : ControllerBase
    {
        public TrashController()
        {
        }

        [HttpPost]
        public ActionResult UploadStatus([FromBody] TrashStatusDTO dto)
        {
            dto.SentTime = DateTime.Now;
            return Ok(dto);
        }
    }
}
