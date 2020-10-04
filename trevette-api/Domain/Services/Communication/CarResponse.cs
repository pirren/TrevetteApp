using trevette_api.Domain.Models;

namespace trevette_api.Domain.Services.Communication
{
    public class CarResponse : BaseResponse
    {
        public Car Car { get; private set; }

        public CarResponse(bool success, string message, Car car) : base(success, message)
        {
            Car = car;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="car">Saved car.</param>
        /// <returns>Response.</returns>
        public CarResponse(Car car) : this(true, string.Empty, car) 
        { }

        /// <summary>
        /// Creates an error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public CarResponse(string message) : this(false, message, null)
        { }
    }
}
