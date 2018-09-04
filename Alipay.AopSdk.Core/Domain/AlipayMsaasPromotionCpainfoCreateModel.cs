using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasPromotionCpainfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasPromotionCpainfoCreateModel : AopObject
    {
        /// <summary>
        /// 唯一应用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 应用版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// bundle_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 调试数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("debug")]
        public string Debug { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// IDFA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idfa")]
        public string Idfa { get; set; }

        /// <summary>
        /// IOS版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ios_version")]
        public string IosVersion { get; set; }

        /// <summary>
        /// MAC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mac")]
        public string Mac { get; set; }
    }
}
