using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserDetails Data Structure.
    /// </summary>
    [Serializable]
    public class UserDetails : AopObject
    {
        /// <summary>
        /// 用户变更手机号，替换旧的手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_change_mobile")]
        public string UserChangeMobile { get; set; }

        /// <summary>
        /// 孩子家长的手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_mobile")]
        public string UserMobile { get; set; }

        /// <summary>
        /// 张三
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 孩子与家长的关系： 1、爸爸  2、妈妈  3、爷爷  4、奶奶  5、外公  6、外婆  7、家长
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_relation")]
        public string UserRelation { get; set; }
    }
}
