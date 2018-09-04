using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetCardReturnRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetCardReturnRefundModel : AopObject
    {
        /// <summary>
        /// 资产id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产id类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asset_id_type")]
        public string AssetIdType { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 退卡资金场景
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fund_scence")]
        public string FundScence { get; set; }

        /// <summary>
        /// 是否销卡，true为销卡，false不销卡，只退余额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_cancel")]
        public string IsCancel { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单明细
        /// </summary>
        [XmlArray("recharge_details")]
        [XmlArrayItem("recharge_detail")]
        public List<RechargeDetail> RechargeDetails { get; set; }

        /// <summary>
        /// 退卡真实资金，单位元，包含手续费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_amount")]
        public string ReturnAmount { get; set; }

        /// <summary>
        /// 退卡面额，单位元，包含手续费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_asset_amount")]
        public string ReturnAssetAmount { get; set; }

        /// <summary>
        /// 退卡手续费真实资金，单位元，没有放0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_fee_amount")]
        public string ReturnFeeAmount { get; set; }

        /// <summary>
        /// 退卡手续费面额，单位元，没有放0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_fee_asset_amount")]
        public string ReturnFeeAssetAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
