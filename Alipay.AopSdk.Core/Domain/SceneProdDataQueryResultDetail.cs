using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneProdDataQueryResultDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SceneProdDataQueryResultDetail : AopObject
    {
        /// <summary>
        /// 网商银行申请单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 机构需要查询的订单数据，
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        public string Result { get; set; }
    }
}
