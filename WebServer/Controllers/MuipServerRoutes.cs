﻿using EggLink.DanhengServer.Util;
using EggLink.DanhengServer.WebServer.Request;
using EggLink.DanhengServer.WebServer.Response;
using EggLink.DanhengServer.WebServer.Server;
using Microsoft.AspNetCore.Mvc;

namespace EggLink.DanhengServer.WebServer.Controllers
{
    [ApiController]
    [Route("/")]
    public class MuipServerRoutes
    {
        [HttpGet("/muip/auth_admin")]
        [HttpPost("/muip/auth_admin")]
        public IActionResult AuthAdminKey([FromBody] AuthAdminKeyRequestBody req)
        {
            var data = MuipManager.AuthAdminAndCreateSession(req.admin_key, req.key_type);
            if (data == null)
            {
                return new JsonResult(new AuthAdminKeyResponse(1, "Admin key is invalid or the function is not enabled!", null));
            }
            return new JsonResult(new AuthAdminKeyResponse(0, "Authorized admin key successfully!", data));
        }

        [HttpGet("/muip/exec_cmd")]
        [HttpPost("/muip/exec_cmd")]
        public IActionResult ExecuteCommand([FromBody] AdminExecRequest req)
        {
            var resp = MuipManager.ExecuteCommand(req.SessionId, req.Command, req.TargetUid);
            return new JsonResult(resp);
        }

        [HttpGet("/muip/server_information")]
        public IActionResult GetServerInformation([FromBody] ServerInformationRequest req)
        {
            var resp = MuipManager.GetInformation(req.SessionId);
            return new JsonResult(resp);
        }

        [HttpGet("/muip/player_information")]
        public IActionResult GetPlayerInformation([FromBody] PlayerInformationRequest req)
        {
            var resp = MuipManager.GetPlayerInformation(req.SessionId, req.Uid);
            return new JsonResult(resp);
        }
    }
}
