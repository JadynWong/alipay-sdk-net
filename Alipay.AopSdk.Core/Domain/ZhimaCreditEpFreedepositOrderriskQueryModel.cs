using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpFreedepositOrderriskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpFreedepositOrderriskQueryModel : AopObject
    {
        /// <summary>
        /// 本次使用免押金额，分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_use_limit")]
        public long CurrentUseLimit { get; set; }

        /// <summary>
        /// 企业证件号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业证件类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ep_cert_type")]
        public string EpCertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 首笔租金金额，分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_rent_amount")]
        public long FirstRentAmount { get; set; }

        /// <summary>
        /// 租期期数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lease_periods")]
        public long LeasePeriods { get; set; }

        /// <summary>
        /// 租赁设备信息列表
        /// </summary>
        [XmlArray("machine_info_list")]
        [XmlArrayItem("machine_info")]
        public List<MachineInfo> MachineInfoList { get; set; }

        /// <summary>
        /// 订单风控业务流水号，商户生成，每次业务保证唯一
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_lease_order_no")]
        public string MerchantLeaseOrderNo { get; set; }

        /// <summary>
        /// 超出免押额度部分的应交押金(人民币分)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_pay_deposit_amount")]
        public long NeedPayDepositAmount { get; set; }

        /// <summary>
        /// 芝麻企业免押额度申请业务流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 付款日
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 每期租金金额，分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_lease_amount")]
        public long PeriodLeaseAmount { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rec_address")]
        public string RecAddress { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rec_mobile")]
        public string RecMobile { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rec_name")]
        public string RecName { get; set; }

        /// <summary>
        /// 剩余可用免押金额，分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remain_limit")]
        public long RemainLimit { get; set; }

        /// <summary>
        /// 租赁总金额，分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public long TotalAmount { get; set; }
    }
}
