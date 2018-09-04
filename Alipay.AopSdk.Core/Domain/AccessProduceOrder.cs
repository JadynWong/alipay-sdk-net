using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessProduceOrder Data Structure.
    /// </summary>
    [Serializable]
    public class AccessProduceOrder : AopObject
    {
        /// <summary>
        /// 口碑码批次号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 生产单标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_order_id")]
        public string ProduceOrderId { get; set; }

        /// <summary>
        /// 生产数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_quantity")]
        public long ProduceQuantity { get; set; }

        /// <summary>
        /// 物料属性名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuff_attr_name")]
        public string StuffAttrName { get; set; }

        /// <summary>
        /// 物料材质
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuff_material")]
        public string StuffMaterial { get; set; }

        /// <summary>
        /// 物料尺寸
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuff_size")]
        public string StuffSize { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuff_type")]
        public string StuffType { get; set; }

        /// <summary>
        /// 模板唯一标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_name")]
        public string TemplateName { get; set; }
    }
}
