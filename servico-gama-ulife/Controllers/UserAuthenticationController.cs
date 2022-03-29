﻿using Microsoft.AspNetCore.Mvc;
using servico_gama_ulife.Controllers.Request;
using servico_gama_ulife.Controllers.ViewModel;
using servico_gama_ulife.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servico_gama_ulife.Controllers
{
    public class UserAuthenticationController : ControllerBase
    {
        private readonly IUserAuthenticationService _userAuthenticationService;
        public UserAuthenticationController(IUserAuthenticationService iUserAuthenticationService)
        {
            _userAuthenticationService = iUserAuthenticationService;
        }

        [HttpPost]
        public IActionResult UserAutheticationToken([FromBody] UserAuthenticationRequest request)
        {
            string authetication = _userAuthenticationService.ValidAuthenticationToken(request);
            return Ok(new AuthenticationResultViewModel(authetication != null ? "Login efetuado com sucesso" : "Usuário ou senha incorreto", authetication));
        }
    }
}
