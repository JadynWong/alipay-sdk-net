using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessProduceQrcode Data Structure.
    /// </summary>
    [Serializable]
    public class AccessProduceQrcode : AopObject
    {
        /// <summary>
        /// 口碑码批次号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 码url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("core_url")]
        public string CoreUrl { get; set; }

        /// <summary>
        /// 生产单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_order_id")]
        public string ProduceOrderId { get; set; }

        /// <summary>
        /// 二维码编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode")]
        public string Qrcode { get; set; }
    }
}
