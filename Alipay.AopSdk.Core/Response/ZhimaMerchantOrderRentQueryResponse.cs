using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantOrderRentQueryResponse.
    /// </summary>
    public class ZhimaMerchantOrderRentQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否准入:  Y:准入  N:不准入
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admit_state")]
        public string AdmitState { get; set; }

        /// <summary>
        /// 资金流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 借用时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("borrow_time")]
        public string BorrowTime { get; set; }

        /// <summary>
        /// 物品名称,最长不能超过14个汉字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 芝麻信用借还订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付金额类型  RENT:租金  DAMAGE:赔偿金
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_amount_type")]
        public string PayAmountType { get; set; }

        /// <summary>
        /// 支付状态  PAY_INIT:待支付  PAY_SUCCESS:支付成功  PAY_FAILED:支付失败  PAY_INPROGRESS:支付中
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 归还时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restore_time")]
        public string RestoreTime { get; set; }

        /// <summary>
        /// 订单状态:  borrow:借出  restore:归还  cancel:撤销
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_state")]
        public string UseState { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
