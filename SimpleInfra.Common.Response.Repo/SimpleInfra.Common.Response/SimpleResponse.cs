namespace SimpleInfra.Common.Response
{
    using System.Runtime.Serialization;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A simple response. </summary>
    ///
    /// <remarks>   Mustafa SAÇLI, 7.05.2019. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    public class SimpleResponse
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the response code. </summary>
        ///
        /// <value> The response code. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public int ResponseCode
        { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the response code. </summary>
        ///
        /// <value> The response code. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public string RCode
        { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a message describing the response. </summary>
        ///
        /// <value> A message describing the response. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public string ResponseMessage
        { get; set; }

        /// <summary>
        /// Creates new SimpleResponse
        /// </summary>
        /// <param name="responseCode"></param>
        /// <param name="responseMessage"></param>
        /// <param name="rCode"></param>
        /// <returns></returns>
        public static SimpleResponse New(int responseCode = 0, string responseMessage = null, string rCode = null)
        {
            return new SimpleResponse { ResponseCode = responseCode, ResponseMessage = responseMessage, RCode = rCode };
        }

        /// <summary>
        /// Sets the code.
        /// </summary>
        /// <param name="responseCode">The response code.</param>
        /// <returns>A SimpleResponse.</returns>
        public SimpleResponse SetCode(int responseCode)
        {
            this.ResponseCode = responseCode;
            return this;
        }

        /// <summary>
        /// Sets the r code.
        /// </summary>
        /// <param name="rCode">The r code.</param>
        /// <returns>A SimpleResponse.</returns>
        public SimpleResponse SetRCode(string rCode)
        {
            this.RCode = rCode;
            return this;
        }

        /// <summary>
        /// Sets the message.
        /// </summary>
        /// <param name="responseMessage">The response message.</param>
        /// <returns>A SimpleResponse.</returns>
        public SimpleResponse SetMessage(string responseMessage)
        {
            this.ResponseMessage = responseMessage;
            return this;
        }
    }
}
