using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AiOcrTableContext Data Structure.
    /// </summary>
    [Serializable]
    public class AiOcrTableContext : AopObject
    {
        /// <summary>
        /// one past end column index(单元格所占的列数(colspan)为ex - sx)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ex")]
        public long Ex { get; set; }

        /// <summary>
        /// one past end row index(单元格所占的行数(rowspan)为ey - sy)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ey")]
        public long Ey { get; set; }

        /// <summary>
        /// cell height,图片上单元格的高度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("height")]
        public long Height { get; set; }

        /// <summary>
        /// start from column(单元格的起始列id)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sx")]
        public long Sx { get; set; }

        /// <summary>
        /// start row(单元格的起始行id)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sy")]
        public long Sy { get; set; }

        /// <summary>
        /// 表格文字内容
        /// </summary>
        [XmlArray("text")]
        [XmlArrayItem("string")]
        public List<string> Text { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// cell width，图片上单元格的宽度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        public long Width { get; set; }
    }
}
