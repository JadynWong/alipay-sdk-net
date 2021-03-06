using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFlashsalesStockSyncUpdateResponse.
    /// </summary>
    public class AlipayFlashsalesStockSyncUpdateResponse : AopResponse
    {
        /// <summary>
        /// 成功时返回的业务参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 当更新库存不成功时，错误码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public string Success { get; set; }
    }
}
