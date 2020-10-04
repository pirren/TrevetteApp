namespace trevette_api.Domain.Services.Communication
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public BaseResponse(bool succes, string message)
        {
            Success = succes;
            Message = message;
        }
    }
}
