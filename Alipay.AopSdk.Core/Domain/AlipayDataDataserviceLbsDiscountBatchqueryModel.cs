using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceLbsDiscountBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceLbsDiscountBatchqueryModel : AopObject
    {
        /// <summary>
        /// 媒体编号，使用前需要找业务申请 ，不申请直接调用会失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 手机IMEI号，imei、user_id、mobile三者必须且只能填一个
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 手机号码，imei、user_id、mobile三者必须且只能填一个
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 输出的券列表大小
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// 支付宝用户ID，imei、user_id、mobile三者必须且只能填一个
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
