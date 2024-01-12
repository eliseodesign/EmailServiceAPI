using EmailServiceApi.DTOs;

namespace EmailServiceApi.Services{
  public interface IEmailService
  {
    bool SendEmail(EmailDTO emailDTO);
  }
}