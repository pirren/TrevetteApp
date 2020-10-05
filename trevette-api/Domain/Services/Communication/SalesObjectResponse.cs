using trevette_api.Domain.Models;

namespace trevette_api.Domain.Services.Communication
{
    public class SalesObjectResponse : BaseResponse
    {
        public SalesObject SalesObject { get; set; }

        public SalesObjectResponse(bool success, string message, SalesObject salesObject) : base(success, message)
        {
            SalesObject = salesObject;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="salesobject">Saved salesobject.</param>
        /// <returns>Response.</returns>
        public SalesObjectResponse(SalesObject salesObject) : this(true, string.Empty, salesObject)
        { }

        /// <summary>
        /// Creates an error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SalesObjectResponse(string message) : this(false, message, null)
        { }
    }
}
