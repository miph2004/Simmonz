﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Simmonz.AdminSolution.Services;
using Simmonz.ViewModel.User;

namespace Simmonz.AdminSolution.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        public LoginController(IUserService userService,IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
           if(TempData["resultFailed"]!=null)
            {
                ViewBag.FaliedAlert = TempData["resultFailed"];
            }    
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(ModelState);

            var result = await _userService.Authenticate(request);
            if(result.IsSucceed)
            {
                var userPrincipal = this.ValidateToken(result.ResultObject);
                var authProperties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    IsPersistent = false
                };
                HttpContext.Session.SetString("Token", result.ResultObject);
                await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            userPrincipal,
                            authProperties);

                return RedirectToAction("Index", "Home");
            }
            TempData["resultFailed"] = result.Message;
            return RedirectToAction("Index");
            

        }
        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
    }
}