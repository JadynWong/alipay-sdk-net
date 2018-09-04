using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseRenterIdinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseRenterIdinfoQueryModel : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
