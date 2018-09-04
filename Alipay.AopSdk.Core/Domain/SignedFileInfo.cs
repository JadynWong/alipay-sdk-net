using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignedFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SignedFileInfo : AopObject
    {
        /// <summary>
        /// 文档过期时间戳
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 数据名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型  pdf //pdf文档  p7 //pkcs7签名文档
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件读取url地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 文档创建时间戳
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_time")]
        public string GmtTime { get; set; }

        /// <summary>
        /// 签约数据编号，由平台生成
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inner_data_id")]
        public string InnerDataId { get; set; }

        /// <summary>
        /// 签约数据编号，由外部系统定义，用于数据关联
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_data_id")]
        public string OutDataId { get; set; }

        /// <summary>
        /// 文档签名结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signed_data")]
        public string SignedData { get; set; }

        /// <summary>
        /// 资源文件类型  DATA //文件原文  FILE  //文件OSS索引
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_type")]
        public string SourceType { get; set; }
    }
}
