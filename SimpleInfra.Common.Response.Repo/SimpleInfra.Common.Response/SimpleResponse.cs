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
        private int _code;
        private string _message;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the code. </summary>
        ///
        /// <value> The code. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a message describing the response. </summary>
        ///
        /// <value> A message describing the response. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the response code. </summary>
        ///
        /// <value> The response code. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        [Obsolete("This property will be removed later versions. You should use Code property.")]
        public int ResponseCode
        {
            get { return _code; }
            set { _code = value; }
        }

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
        [Obsolete("This property will be removed later versions. You should use Message property.")]
        public string ResponseMessage
        {
            get { return _message; }
            set { _message = value; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is fail. if code is less than 0 return true, else return false.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is fail; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsFail
        { get { return this.Code < 0; } }

        /// <summary>
        /// Gets a value indicating whether this instance is success. if code is greater than 0 return true, else return false.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsSuccess
        { get { return this.Code > 0; } }

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
            this.Message = message;
            return this;
        }

        /// <summary>
        /// Set response with Code(value: 1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: 1) and given message.</returns>
        public SimpleResponse SetSuccess(string message = null)
        {
            return this.SetCode(1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Set response with Code(value: -1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: -1) and given message.</returns>
        public SimpleResponse SetFail(string message = null)
        {
            return this.SetCode(-1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Resets this instance with Code(0) and Message(null) and Rcode(null).
        /// </summary>
        /// <returns>Returns instance equal to SimpleResponse.New() </returns>
        public SimpleResponse Reset()
        {
            return this.SetCode(0)
                    .SetRCode(null)
                    .SetMessage(null);
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

        /// <summary>
        /// Imports the specified response values.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>Returns SimpleResponse instance with given code and message.</returns>
        public SimpleResponse Import(SimpleResponse response)
        {
            return this.SetCode(response.Code)
                    .SetMessage(response.Message)
                    .SetRCode(response.RCode);
        }

        /// <summary>
        /// Imports the specified response.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response">The response.</param>
        /// <returns>Returns SimpleResponse instance with given code and message.</returns>
        public SimpleResponse Import<T>(SimpleResponse<T> response)
        {
            return this.SetCode(response.Code)
                    .SetMessage(response.Message)
                    .SetRCode(response.RCode);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance. if the Code property value is equal return true, else returns false.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is SimpleResponse response)
            {
                return this.Code == response.Code;
            }

            return false;
        }

        /// <summary>
        /// Adds the code to current response code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns>Returns SimpleResponse instance with Code(with added value) and current message.</returns>
        public SimpleResponse AddCode(int code)
        {
            return this.SetCode(this.Code + code);
        }

        /// <summary>
        /// Adds the message to current message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Returns SimpleResponse instance with Message(with added message) and current code.</returns>
        public SimpleResponse AddMessage(string message)
        {
            return this.SetMessage(string.Format("{0}{1}", this.Message, message));
        }
    }
}