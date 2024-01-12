namespace EmailServiceApi.Services
{
    public interface IResponseService
    {
        public IReturn<T> Provider<T>(T data, string message, bool success);
    }
}