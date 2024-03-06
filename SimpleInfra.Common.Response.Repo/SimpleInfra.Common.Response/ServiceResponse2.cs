namespace SimpleInfra.Common.Response
{
    using System;
    using System.Runtime.Serialization;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A service response. </summary>
    ///
    /// <remarks>   Mustafa SAÇLI, 7.05.2019. </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    [Obsolete("This class will be deleted later versions. You can use SimpleResponse class.")]
    public class ServiceResponse<T> : ServiceResponse
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the data. </summary>
        ///
        /// <value> The data. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public T Data
        { get; set; }
    }
}
