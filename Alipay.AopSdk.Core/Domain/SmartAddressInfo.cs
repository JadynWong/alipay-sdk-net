using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmartAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SmartAddressInfo : AopObject
    {
        /// <summary>
        /// 行政区代码-区，使用国家行政区划代码，可参考http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_code")]
        public long AreaCode { get; set; }

        /// <summary>
        /// 行政区代码-市，使用国家行政区划代码，可参考http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public long CityCode { get; set; }

        /// <summary>
        /// 自助售货机地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("machine_address")]
        public string MachineAddress { get; set; }

        /// <summary>
        /// 行政区代码-省，使用国家行政区划代码，可参考http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_code")]
        public long ProvinceCode { get; set; }
    }
}
