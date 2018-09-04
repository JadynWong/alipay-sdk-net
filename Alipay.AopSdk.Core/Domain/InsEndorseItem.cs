using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsEndorseItem Data Structure.
    /// </summary>
    [Serializable]
    public class InsEndorseItem : AopObject
    {
        /// <summary>
        /// 批单项新值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_value")]
        public string NewValue { get; set; }

        /// <summary>
        /// 批单项旧值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("old_value")]
        public string OldValue { get; set; }

        /// <summary>
        /// 批单类型;303:保单改期;311:批改保单标的
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public long Type { get; set; }
    }
}
