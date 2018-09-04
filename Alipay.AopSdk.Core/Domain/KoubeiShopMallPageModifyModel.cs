using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopMallPageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallPageModifyModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈访问地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mall_url")]
        public string MallUrl { get; set; }

        /// <summary>
        /// 废弃！，务传。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
