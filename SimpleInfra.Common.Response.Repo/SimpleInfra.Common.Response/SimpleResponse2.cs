using System.Runtime.Serialization;

namespace SimpleInfra.Common.Response
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A simple response. </summary>
    ///
    /// <remarks>   Mustafa SAÇLI, 7.05.2019. </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    public class SimpleResponse<T> : SimpleResponse
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the data. </summary>
        ///
        /// <value> The data. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public T Data
        { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is fail. if code is less than 0 return true, else return false.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is fail; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public new bool IsFail
        { get { return this.Code < 0; } }

        /// <summary>
        /// Gets a value indicating whether this instance is success. if code is greater than 0 return true, else return false.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public new bool IsSuccess
        { get { return this.Code > 0; } }

        /// <summary>
        /// Sets the code.
        /// </summary>
        /// <param name="code">The response code.</param>
        /// <returns>A SimpleResponse.</returns>
        public new SimpleResponse<T> SetCode(int code)
        {
            this.Code = code;
            return this;
        }

        /// <summary>
        /// Sets the r code.
        /// </summary>
        /// <param name="rCode">The r code.</param>
        /// <returns>A SimpleResponse.</returns>
        public new SimpleResponse<T> SetRCode(string rCode)
        {
            this.RCode = rCode;
            return this;
        }

        /// <summary>
        /// Sets the message.
        /// </summary>
        /// <param name="message">The response message.</param>
        /// <returns>A SimpleResponse.</returns>
        public new SimpleResponse<T> SetMessage(string message)
        {
            this.Message = message;
            return this;
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>A SimpleResponse.</returns>
        public SimpleResponse<T> SetData(T data)
        {
            this.Data = data;
            return this;
        }

        /// <summary>
        /// Resets this instance with Code(0) and Message(null).
        /// </summary>
        /// <returns>Returns instance equal to SimpleResponse{T}.New() </returns>
        public new SimpleResponse Reset()
        {
            return this.SetCode(0)
                    .SetRCode(null)
                    .SetMessage(null)
                    .SetData(default);
        }

        /// <summary>
        /// Creates new SimpleResponse instance.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="rCode"></param>
        /// <returns></returns>
        public static SimpleResponse<T> New(T data, int code = 0, string message = null, string rCode = null)
        {
            return (new SimpleResponse<T>())
                    .SetData(data)
                    .SetCode(code)
                    .SetMessage(message)
                    .SetRCode(rCode);
        }

        /// <summary>
        /// Creates the.
        /// </summary>
        /// <param name="code">The response code.</param>
        /// <param name="message">The response message.</param>
        /// <param name="rCode">The r code.</param>
        /// <returns>A SimpleResponse.</returns>
        public static SimpleResponse<T> Create(int code = 0, string message = null, string rCode = null)
        {
            return (new SimpleResponse<T>())
                    .SetCode(code)
                    .SetMessage(message)
                    .SetRCode(rCode);
        }

        /// <summary>
        /// Set response with Code(value: 1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: 1) and given message.</returns>
        public new SimpleResponse<T> SetSuccess(string message = null)
        {
            return this.SetCode(1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Set response with Code(value: -1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: -1) and given message.</returns>
        public new SimpleResponse<T> SetFail(string message = null)
        {
            return this.SetCode(-1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Creates SimpleResponse with Code(value: 1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: 1) and given message.</returns>
        public new static SimpleResponse<T> Success(string message = null)
        {
            return (new SimpleResponse<T>())
                    .SetCode(1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Creates SimpleResponse with Code(value: -1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse{T} instance with Code(value: -1) and given message.</returns>
        public new static SimpleResponse<T> Fail(string message = null)
        {
            return (new SimpleResponse<T>())
                    .SetCode(-1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Imports the specified response values.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>Returns SimpleResponse{T} instance with given code and message.</returns>
        public new SimpleResponse<T> Import(SimpleResponse response)
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
        /// <returns>Returns SimpleResponse{T} instance with given code and message.</returns>
        public SimpleResponse<T> Import(SimpleResponse<T> response)
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
            if (obj is SimpleResponse<T> response)
            {
                return this.Code == response.Code;
            }

            return false;
        }

        /// <summary>
        /// Get object as simpleresponse.
        /// </summary>
        /// <returns></returns>
        public SimpleResponse AsResponse()
        {
            return New(this.Code, this.Message, this.RCode);
        }

        /// <summary>
        /// Adds the code to current response code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns>Returns SimpleResponse{T} instance with Code(with added value) and current message.</returns>
        public new SimpleResponse<T> AddCode(int code)
        {
            return this.SetCode(this.Code + code);
        }

        /// <summary>
        /// Adds the message to current message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Returns SimpleResponse{T} instance with Message(with added message) and current code.</returns>
        public new SimpleResponse<T> AddMessage(string message)
        {
            return this.SetMessage(string.Format("{0}{1}", this.Message, message));
        }
    }
}