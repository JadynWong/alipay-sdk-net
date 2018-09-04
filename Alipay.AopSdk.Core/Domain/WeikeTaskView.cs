using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeikeTaskView Data Structure.
    /// </summary>
    [Serializable]
    public class WeikeTaskView : AopObject
    {
        /// <summary>
        /// 任务视图描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 蚂蚁微客对当前任务视图编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 任务视图图片链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img")]
        public string Img { get; set; }

        /// <summary>
        /// 任务视图名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 任务视图对应的任务薪资
        /// </summary>
        [Newtonsoft.Json.JsonProperty("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 当前任务视图剩余任务数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_count")]
        public long TaskCount { get; set; }

        /// <summary>
        /// 点击任务视图后唤起微客对应页面的链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
