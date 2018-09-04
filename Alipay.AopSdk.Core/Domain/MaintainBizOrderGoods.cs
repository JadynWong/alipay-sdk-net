using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MaintainBizOrderGoods Data Structure.
    /// </summary>
    [Serializable]
    public class MaintainBizOrderGoods : AopObject
    {
        /// <summary>
        /// 商品图片地址，下单时记录的商品图片
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_image")]
        public string GoodsImage { get; set; }

        /// <summary>
        /// 车主平台商品子订单id。保养订单对应商品子订单表id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_goods_id")]
        public string OrderGoodsId { get; set; }

        /// <summary>
        /// 原始价格，下单时商品的原始价格。金额单位(元)，保留两位小数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_cost")]
        public string OriginalCost { get; set; }

        /// <summary>
        /// 外部商品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_goods_no")]
        public string OutGoodsNo { get; set; }

        /// <summary>
        /// 外部商品套餐唯一标示。下单时记录的ISV端商品套餐主键
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_package_id")]
        public string OutPackageId { get; set; }

        /// <summary>
        /// 外部套餐名称。下单时记录的商品套餐名称，在商品详情页时透出显示
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 销售价格，下单时商品的销售价格。金额单位(元)，保留两位小数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("real_cost")]
        public string RealCost { get; set; }

        /// <summary>
        /// 商品购买数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_num")]
        public long SaleNum { get; set; }
    }
}
