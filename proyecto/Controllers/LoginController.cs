using Datos;
using Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using proyecto.Config;
using proyecto.Models;
using Entidad;

namespace proyecto.Controllers
{
  [Authorize]
  [ApiController]
  [Route("api/[controller]")]

  public class LoginController : ControllerBase
  {
      TallerContext _context;
      UserService _userService;
      JwtService _jwtService;

      public LoginController(TallerContext context, IOptions<AppSetting> appSettings)
      {
          _context = context;
	 var admin = _context.Users.Find("admin");
      if (admin == null) 
      {
		_context.Users.Add(new User() 
           { 
		         UserName="admin", 
			    Password="admin", 
	               Email="admin@gmail.com", 
                    Estado="ADMIN", 
                    FirstName="Adminitrador", 
                    LastName="", 
                    MobilePhone="31800000000"}
		);
		var registrosGuardados=_context.SaveChanges();
	}
	_userService = new UserService(context);
	_jwtService = new JwtService(appSettings);

          
      }

      [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody]LoginInputModel model)
        {
            var user = _userService.Validate(model.UserName, model.Password);
            if (user == null) return BadRequest("Username or password is incorrect");
            var response= _jwtService.GenerateToken(user);
            return Ok(response);
        }


  }


}