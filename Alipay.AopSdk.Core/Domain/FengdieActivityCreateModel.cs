using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FengdieActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivityCreateModel : AopObject
    {
        /// <summary>
        /// 云凤蝶站点的 id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        public long ActivityId { get; set; }
    }
}
