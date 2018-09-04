using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishCookInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCookInfo : AopObject
    {
        /// <summary>
        /// 区域
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// 渠道    eatin堂食，takeout外卖,paipai 扫码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cook_channel")]
        public string CookChannel { get; set; }

        /// <summary>
        /// 扩展字典,json串
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cook_ext_content")]
        public string CookExtContent { get; set; }

        /// <summary>
        /// 菜谱id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜谱名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cook_name")]
        public string CookName { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cook_version")]
        public string CookVersion { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 时间区间日期结束
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 时间区间截止 闭区间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 口碑菜谱明细
        /// </summary>
        [XmlArray("kb_cook_detail_list")]
        [XmlArrayItem("kbdish_cook_detail_info")]
        public List<KbdishCookDetailInfo> KbCookDetailList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 时间约束类型 forever:永久;  week:按周，每周周几 month:按月,每月几号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 时间控制值,如果选的week, 值 1,2,3,4 ; 如果选择month 1,11,31 ; 如果选择永久，为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_value")]
        public string PeriodValue { get; set; }

        /// <summary>
        /// 菜谱描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 门店列表
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("string")]
        public List<string> ShopList { get; set; }

        /// <summary>
        /// yazuo,meituan,ele获取，新增的时候必输。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_from")]
        public string SourceFrom { get; set; }

        /// <summary>
        /// 控制的日期区间开始
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 时间控制 到分  闭区间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_user")]
        public string UpdateUser { get; set; }
    }
}
