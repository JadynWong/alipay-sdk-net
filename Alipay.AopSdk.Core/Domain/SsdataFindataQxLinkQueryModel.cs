using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataFindataQxLinkQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindataQxLinkQueryModel : AopObject
    {
        /// <summary>
        /// 预留扩展
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// C端用户身份证号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 商户业务流水号，有商户的系统生成的商户业务唯一标识，如果不传，则有上数系统生成一个32位的商户业务流水号并返回
        /// </summary>
        [Newtonsoft.Json.JsonProperty("org_biz_no")]
        public string OrgBizNo { get; set; }

        /// <summary>
        /// C端用户手机号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 用户在操作上数的H5过程中，如果需要跳转到商户的自定义H5，则传递需要跳转的链接地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// C端用户姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
