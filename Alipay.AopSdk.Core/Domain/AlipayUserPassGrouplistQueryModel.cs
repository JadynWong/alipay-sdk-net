using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPassGrouplistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPassGrouplistQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码，国标码，如果need_shopinfo=true，必须传值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 卡券分组标识，当前值：card（卡）、voucher（券）、ticket（票）、cert（证件）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 是否需要店铺信息，true表需要，false或空表不需要
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_shopinfo")]
        public bool NeedShopinfo { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// pass有效状态: CURRENT：当前的, PAST：失效的
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_status")]
        public string TimeStatus { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
