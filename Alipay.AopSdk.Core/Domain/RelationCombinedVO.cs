using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RelationCombinedVO Data Structure.
    /// </summary>
    [Serializable]
    public class RelationCombinedVO : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public ExtraInfoVO ExtInfo { get; set; }

        /// <summary>
        /// 支付宝头像
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 是否支付宝双向好友
        /// </summary>
        [Newtonsoft.Json.JsonProperty("real_friend")]
        public bool RealFriend { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 有可能包含emoji表情，业务方要注意编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_name")]
        public string ViewName { get; set; }
    }
}
