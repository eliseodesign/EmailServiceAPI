namespace EmailServiceApi.DTOs
{
  public class EmailDTO
  {
    public string To { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
  }
}
