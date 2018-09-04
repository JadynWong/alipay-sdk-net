using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Context Data Structure.
    /// </summary>
    [Serializable]
    public class Context : AopObject
    {
        /// <summary>
        /// 底部链接描述文字，如“查看详情”
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first")]
        public Keyword First { get; set; }

        /// <summary>
        /// 顶部色条的色值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_color")]
        public string HeadColor { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword1")]
        public Keyword Keyword1 { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword2")]
        public Keyword Keyword2 { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public Keyword Remark { get; set; }

        /// <summary>
        /// 点击消息后承接页的地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
