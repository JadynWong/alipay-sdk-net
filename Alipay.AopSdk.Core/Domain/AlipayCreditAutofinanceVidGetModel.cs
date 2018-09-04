using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCreditAutofinanceVidGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCreditAutofinanceVidGetModel : AopObject
    {
        /// <summary>
        /// 机构编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgcode")]
        public string Orgcode { get; set; }

        /// <summary>
        /// 支付宝账号数字ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 当前安装的支付宝钱包版本号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        public string Version { get; set; }
    }
}
