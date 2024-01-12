namespace EmailServiceApi.Controllers
{
    using System.Threading.Tasks;
    using EmailServiceApi.DTOs;
    using EmailServiceApi.Services;
    using EmailServiceApi.Validators;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IResponseService _res;
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService, IResponseService res)
        {
            _emailService = emailService;
            _res = res;
        }

        [HttpPost]
        public IActionResult SendEmail([FromBody] EmailDTO email)
        {
            EmailValidator validator = new EmailValidator();
            var validationResult = validator.Validate(email);

            if(!validationResult.IsValid){
                return BadRequest(_res.Provider(new { }, "Error al validar datos", false));
            }

            bool enviado = _emailService.SendEmail(email);

            if (enviado == true)
            {
                return Ok(_res.Provider(new { }, "El email ha sido enviado correctamente", true));
            }
            else
            {
                return BadRequest(_res.Provider(new { }, "El email no se envio, algo salio mal", false));
            }
        }
    }
}