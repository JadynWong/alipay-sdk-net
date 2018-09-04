using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataFindataOperatorImgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindataOperatorImgQueryModel : AopObject
    {
        /// <summary>
        /// 系统业务流水号，在提交用户信息时获得
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
