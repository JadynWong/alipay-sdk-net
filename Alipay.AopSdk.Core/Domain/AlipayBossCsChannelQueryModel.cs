using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossCsChannelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossCsChannelQueryModel : AopObject
    {
        /// <summary>
        /// 平均通话时长的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("att")]
        public string Att { get; set; }

        /// <summary>
        /// 总接通率的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectionrate")]
        public string Connectionrate { get; set; }

        /// <summary>
        /// 在线小二人数的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("curragentsloggedin")]
        public string Curragentsloggedin { get; set; }

        /// <summary>
        /// 通话中人数的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("curragenttalking")]
        public string Curragenttalking { get; set; }

        /// <summary>
        /// 小休人数的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentnotreadyagents")]
        public string Currentnotreadyagents { get; set; }

        /// <summary>
        /// 等待人数的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentreadyagents")]
        public string Currentreadyagents { get; set; }

        /// <summary>
        /// 总排队数的Qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currnumberwaitingcalls")]
        public string Currnumberwaitingcalls { get; set; }

        /// <summary>
        /// 查询hbase的rowkey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endkey")]
        public string Endkey { get; set; }

        /// <summary>
        /// 查询hbase的rowkey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startkey")]
        public string Startkey { get; set; }

        /// <summary>
        /// 总流入量的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visitorinflow")]
        public string Visitorinflow { get; set; }

        /// <summary>
        /// 总应答量的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visitorresponse")]
        public string Visitorresponse { get; set; }

        /// <summary>
        /// 应答量[转接] 的qualifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visitorresponsetransfer")]
        public string Visitorresponsetransfer { get; set; }
    }
}
