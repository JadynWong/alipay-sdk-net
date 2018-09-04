using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FengdieActivitySchemaData Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivitySchemaData : AopObject
    {
        /// <summary>
        /// 默认数据的内容，内容格式参考模板开发过程中自动生成的mock数据（与schema文件同名的json文件）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 指定需要初始化的schema区域，与模板中schema文件路径对应
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
