﻿namespace SimpleInfra.Common.Response
{
    using System.Runtime.Serialization;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A service response. </summary>
    ///
    /// <remarks>   Mustafa SAÇLI, 7.05.2019. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    public class ServiceResponse
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
        /// <summary>   Gets or sets a message describing the response. </summary>
        ///
        /// <value> A message describing the response. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public string ResponseMessage
        { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the response error. </summary>
        ///
        /// <value> The response error. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public string ResponseError
        { get; set; }
    }
}