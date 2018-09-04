using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SealPosition Data Structure.
    /// </summary>
    [Serializable]
    public class SealPosition : AopObject
    {
        /// <summary>
        /// 关键字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 加盖签章页号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 类型  1 : 基于关键字定位  2 : 基于相对位置定位  3 : 默认签名区  4 : 齐缝章
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public long Type { get; set; }

        /// <summary>
        /// 相对于某一页的X轴偏移
        /// </summary>
        [Newtonsoft.Json.JsonProperty("x")]
        public long X { get; set; }

        /// <summary>
        /// 相对于某一页的y轴偏移
        /// </summary>
        [Newtonsoft.Json.JsonProperty("y")]
        public long Y { get; set; }
    }
}
