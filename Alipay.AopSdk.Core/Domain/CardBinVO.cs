using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardBinVO Data Structure.
    /// </summary>
    [Serializable]
    public class CardBinVO : AopObject
    {
        /// <summary>
        /// 卡的别名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_alias")]
        public string CardAlias { get; set; }

        /// <summary>
        /// 卡bin值，通常为卡号的前6位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_bin_value")]
        public string CardBinValue { get; set; }

        /// <summary>
        /// 卡类型对象定义
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type_vo")]
        public CardTypeVO CardTypeVo { get; set; }

        /// <summary>
        /// 卡域模型定义
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_vo")]
        public CardDomainVO DomainVo { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 卡号长度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_len")]
        public string InstLen { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 卡版本信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        public string Version { get; set; }
    }
}
