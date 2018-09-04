using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QRcode Data Structure.
    /// </summary>
    [Serializable]
    public class QRcode : AopObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// qrcode地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
