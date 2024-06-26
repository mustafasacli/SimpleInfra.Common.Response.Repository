using System.Collections.Generic;

namespace SimpleInfra.Common.Response
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="SimpleInfra.Common.Response.SimpleResponse" />
    public class SimplePagedResponse<T> : SimpleResponse
    {
        private List<T> _page = null;

        /// <summary>
        /// Gets or sets the total count.
        /// </summary>
        /// <value>
        /// The total count.
        /// </value>
        public int TotalCount
        { get; set; }

        /// <summary>
        /// Gets the item count.
        /// </summary>
        /// <value>
        /// The item count.
        /// </value>
        public int ItemCount
        { get { return Items?.Count ?? 0; } }

        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        public List<T> Items
        {
            get { return _page ?? new List<T>(); }
            set { _page = value; }
        }

        // TODO  : Method chaining will be added.

        /// <summary>
        /// Sets the code.
        /// </summary>
        /// <param name="code">The response code.</param>
        /// <returns>A SimpleResponse.</returns>
        public new SimplePagedResponse<T> SetCode(int code)
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
        public new SimplePagedResponse<T> SetRCode(string rCode)
        {
            this.RCode = rCode;
            return this;
        }

        /// <summary>
        /// Sets the message.
        /// </summary>
        /// <param name="message">The response message.</param>
        /// <returns>A SimpleResponse.</returns>
        public new SimplePagedResponse<T> SetMessage(string message)
        {
            this.ResponseMessage = message;
            this.Message = message;
            return this;
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>A SimpleResponse.</returns>
        public SimplePagedResponse<T> SetItems(List<T> data)
        {
            this.Items = data;
            return this;
        }

        /// <summary>
        /// Resets this instance with Code(0) and Message(null).
        /// </summary>
        /// <returns>Returns instance equal to SimplePagedResponse{T}.New() </returns>
        public new SimplePagedResponse<T> Reset()
        {
            return this.SetCode(0)
                    .SetRCode(null)
                    .SetMessage(null)
                    .SetItems(default);
        }

        /// <summary>
        /// News the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="code">The code.</param>
        /// <param name="message">The message.</param>
        /// <param name="rCode">The r code.</param>
        /// <returns></returns>
        public static SimplePagedResponse<T> New(List<T> data, int code = 0, string message = null, string rCode = null)
        {
            return (new SimplePagedResponse<T>())
                    .SetItems(data)
                    .SetCode(code)
                    .SetMessage(message)
                    .SetRCode(rCode);
        }

        /// <summary>
        /// Creates the specified code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="message">The message.</param>
        /// <param name="rCode">The r code.</param>
        /// <returns></returns>
        public static SimplePagedResponse<T> Create(int code = 0, string message = null, string rCode = null)
        {
            return (new SimplePagedResponse<T>())
                    .SetCode(code)
                    .SetMessage(message)
                    .SetRCode(rCode);
        }

        /// <summary>
        /// Set response with Code(value: 1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: 1) and given message.</returns>
        public new SimplePagedResponse<T> SetSuccess(string message = null)
        {
            return this.SetCode(1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Set response with Code(value: -1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: -1) and given message.</returns>
        public new SimplePagedResponse<T> SetFail(string message = null)
        {
            return this.SetCode(-1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Creates SimpleResponse with Code(value: 1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimpleResponse instance with Code(value: 1) and given message.</returns>
        public new static SimplePagedResponse<T> Success(string message = null)
        {
            return (new SimplePagedResponse<T>())
                    .SetCode(1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Creates SimpleResponse with Code(value: -1) and given message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns SimplePagedResponse{T} instance with Code(value: -1) and given message.</returns>
        public new static SimplePagedResponse<T> Fail(string message = null)
        {
            return (new SimplePagedResponse<T>())
                    .SetCode(-1)
                    .SetMessage(message);
        }

        /// <summary>
        /// Imports the specified response values.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>Returns SimplePagedResponse{T} instance with given code and message.</returns>
        public new SimplePagedResponse<T> Import(SimpleResponse response)
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
        /// <returns>Returns SimplePagedResponse{T} instance with given code and message.</returns>
        public SimplePagedResponse<T> Import(SimplePagedResponse<T> response)
        {
            return this.SetCode(response.Code)
                    .SetMessage(response.Message)
                    .SetRCode(response.RCode)
                    .SetItems(response.Items);
        }
    }
}