using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelContentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelContentCancelModel : AopObject
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modified_date")]
        public long ModifiedDate { get; set; }
    }
}
