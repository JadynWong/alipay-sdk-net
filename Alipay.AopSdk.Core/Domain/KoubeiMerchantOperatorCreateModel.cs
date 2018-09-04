using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorCreateModel : AopObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 折让限额单位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount_limit_unit")]
        public string DiscountLimitUnit { get; set; }

        /// <summary>
        /// 折让限额值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount_limit_value")]
        public string DiscountLimitValue { get; set; }

        /// <summary>
        /// 免单限额单位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("free_limit_unit")]
        public string FreeLimitUnit { get; set; }

        /// <summary>
        /// 免单限额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("free_limit_value")]
        public string FreeLimitValue { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 操作员绑定的部门类型 5-部门，6-门店
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 操作员名字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 角色ID, 示例值角色为店长
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        public string RoleId { get; set; }
    }
}
