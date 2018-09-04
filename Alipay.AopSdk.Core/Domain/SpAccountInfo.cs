using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpAccountInfo : AopObject
    {
        /// <summary>
        /// 机构专户开户银行名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_inst_name")]
        public string AccountInstName { get; set; }

        /// <summary>
        /// 账户名称（个人对应真实姓名，企业用户对应是企业注册名）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 机构专户账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_account_no")]
        public string SpAccountNo { get; set; }
    }
}
