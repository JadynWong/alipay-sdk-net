using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoCarSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoCarSaveModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 用户ID,车主会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
