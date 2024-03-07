using System;
using System.Runtime.Serialization;

namespace SimpleInfra.Common.Response
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A simple response. </summary>
    ///
    /// <remarks>   Mustafa SAÇLI, 7.05.2019. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    public class SimpleResponse
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the code. </summary>
        ///
        /// <value> The code. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public int Code
        { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a message describing the response. </summary>
        ///
        /// <value> A message describing the response. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public string Message
        { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the response code. </summary>
        ///
        /// <value> The response code. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        [Obsolete("This property will be removed later versions. You can use Code property.")]
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
        [Obsolete("This property will be removed later versions. You can use Message property.")]
        public string ResponseMessage
        { get; set; }

        /// <summary>
        /// Creates new SimpleResponse
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="rCode"></param>
        /// <returns></returns>
        public static SimpleResponse New(int code = 0, string message = null, string rCode = null)
        {
            return (new SimpleResponse())
                    .SetCode(code)
                    .SetMessage(message)
                    .SetRCode(rCode);
        }

        /// <summary>
        /// Sets the code.
        /// </summary>
        /// <param name="code">The response code.</param>
        /// <returns>A SimpleResponse.</returns>
        public SimpleResponse SetCode(int code)
        {
            this.ResponseCode = code;
            this.Code = code;
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
        /// <param name="message">The response message.</param>
        /// <returns>A SimpleResponse.</returns>
        public SimpleResponse SetMessage(string message)
        {
            this.ResponseMessage = message;
            this.Message = message;
            return this;
        }

        /// <summary>
        /// Creates SimpleResponse with Code(value: 1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: 1) and given message.</returns>
        public static SimpleResponse Success(string message = null)
        {
            return (new SimpleResponse())
                    .SetCode(1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Creates SimpleResponse with Code(value: -1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: -1) and given message.</returns>
        public static SimpleResponse Fail(string message = null)
        {
            return (new SimpleResponse())
                    .SetCode(-1)
                    .SetMessage(message);
        }
    }
}