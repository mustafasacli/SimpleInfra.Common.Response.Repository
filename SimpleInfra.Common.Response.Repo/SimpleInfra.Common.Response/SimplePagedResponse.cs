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
    }
}