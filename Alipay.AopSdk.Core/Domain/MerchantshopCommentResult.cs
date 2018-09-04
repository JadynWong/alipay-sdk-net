using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantshopCommentResult Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantshopCommentResult : AopObject
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 评论时间格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment_time")]
        public string CommentTime { get; set; }

        /// <summary>
        /// 评论用户的头像url，记录用户评价时头像完整路径
        /// </summary>
        [Newtonsoft.Json.JsonProperty("face")]
        public string Face { get; set; }

        /// <summary>
        /// 评论晒图，多个逗号分隔。使用车主平台接口上传图片地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imgs")]
        public string Imgs { get; set; }

        /// <summary>
        /// 评论用户的昵称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 车主平台订单编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply")]
        public string Reply { get; set; }

        /// <summary>
        /// 回复时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply_time")]
        public string ReplyTime { get; set; }

        /// <summary>
        /// 评分， 两位小数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("score")]
        public string Score { get; set; }

        /// <summary>
        /// 车主平台门店编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 评论用户支付宝uid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 评论的用户名称，敏感数据脱敏处理。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
