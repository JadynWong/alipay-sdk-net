using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupInfo : AopObject
    {
        /// <summary>
        /// 创建者用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator_uid")]
        public string CreatorUid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群头像url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_img")]
        public string GroupImg { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 群成员上限
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_threshold")]
        public long GroupThreshold { get; set; }

        /// <summary>
        /// 群类型,0:普通群、1：经费群、5：活动群、6：娱乐群
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 群主用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("master_uid")]
        public string MasterUid { get; set; }
    }
}
