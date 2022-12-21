﻿namespace SimpleInfra.Common.Response
{
    using System.Runtime.Serialization;

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
        /// Sets the code.
        /// </summary>
        /// <param name="responseCode">The response code.</param>
        /// <returns>A SimpleResponse.</returns>
        public new SimpleResponse<T> SetCode(int responseCode)
        {
            this.ResponseCode = responseCode;
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
        /// <param name="responseMessage">The response message.</param>
        /// <returns>A SimpleResponse.</returns>
        public new SimpleResponse<T> SetMessage(string responseMessage)
        {
            this.ResponseMessage = responseMessage;
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
        /// Creates new SimpleResponse instance.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="responseCode"></param>
        /// <param name="responseMessage"></param>
        /// <param name="rCode"></param>
        /// <returns></returns>
        public static SimpleResponse<T> New(T data, int responseCode = 0, string responseMessage = null, string rCode = null)
        {
            return new SimpleResponse<T> { Data = data, ResponseCode = responseCode, ResponseMessage = responseMessage, RCode = rCode };
        }

        /// <summary>
        /// Creates the.
        /// </summary>
        /// <param name="responseCode">The response code.</param>
        /// <param name="responseMessage">The response message.</param>
        /// <param name="rCode">The r code.</param>
        /// <returns>A SimpleResponse.</returns>
        public static SimpleResponse<T> Create(int responseCode = 0, string responseMessage = null, string rCode = null)
        {
            return new SimpleResponse<T> { ResponseCode = responseCode, ResponseMessage = responseMessage, RCode = rCode };
        }
    }
}