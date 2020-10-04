using trevette_api.Domain.Models;

namespace trevette_api.Domain.Services.Communication
{
    public class SaveCarResponse : BaseResponse
    {
        public Car Car { get; set; }

        public SaveCarResponse(bool success, string message, Car car) : base(success, message)
        {
            Car = car;
        }

        public SaveCarResponse(Car car) : this(true, string.Empty, car) 
        { }

        public SaveCarResponse(string message) : this(false, message, null)
        { }
    }
}
