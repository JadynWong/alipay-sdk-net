using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpusCreateResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OpusCreateResponse : AopObject
    {
        /// <summary>
        /// 作品外部id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_opus_id")]
        public string ExternalOpusId { get; set; }

        /// <summary>
        /// 作品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opus_id")]
        public string OpusId { get; set; }
    }
}
