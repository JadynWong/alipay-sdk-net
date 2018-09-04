using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WelfareEcoStoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WelfareEcoStoreInfo : AopObject
    {
        /// <summary>
        /// 门店具体位置（中文）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
