using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMsgDingSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMsgDingSendModel : AopObject
    {
        /// <summary>
        /// 钉钉企业应用ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 消息类型为text时表示消息内容、消息类型为link时表示消息描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息类型为link时的消息点击链接地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 消息类型为link时的图片地址，支持jpg格式图片，大小不超过1MB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 消息类型，文本为text；链接为link
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 接收者，个人为single；部门为department
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 消息类型为link时的消息标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 用户UID列表
        /// </summary>
        [XmlArray("user_ids")]
        [XmlArrayItem("string")]
        public List<string> UserIds { get; set; }
    }
}
