using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenBatch Data Structure.
    /// </summary>
    [Serializable]
    public class OpenBatch : AopObject
    {
        /// <summary>
        /// 批次id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 批次状态  0，未检测  1，检测中  2，未通过  3，已通过
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 单品数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_num")]
        public string ItemNum { get; set; }
    }
}
