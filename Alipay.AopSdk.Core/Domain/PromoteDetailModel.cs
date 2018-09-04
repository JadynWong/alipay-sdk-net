using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoteDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteDetailModel : AopObject
    {
        /// <summary>
        /// 广告id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 标的业务id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型（目前只支持ITEM）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 推广标的商品信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_info")]
        public PromoteItemModel ItemInfo { get; set; }

        /// <summary>
        /// 推广数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promote_data")]
        public PromoteDataModel PromoteData { get; set; }
    }
}
