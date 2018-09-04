using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsAddressee Data Structure.
    /// </summary>
    [Serializable]
    public class InsAddressee : AopObject
    {
        /// <summary>
        /// 收件人详细地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_code")]
        public string AddressCode { get; set; }

        /// <summary>
        /// 联系地址-城区
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// 联系地址-城市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 联系方式(mobile登录号)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系地址-电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 联系地址-省份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 联系地址-邮编
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
