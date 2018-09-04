using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarModel Data Structure.
    /// </summary>
    [Serializable]
    public class CarModel : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 配置类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config_name")]
        public string ConfigName { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("engine_desc")]
        public string EngineDesc { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("family_short_name")]
        public string FamilyShortName { get; set; }

        /// <summary>
        /// 车辆驾驶类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gear_box_type")]
        public string GearBoxType { get; set; }

        /// <summary>
        /// 新车购置价
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purchase_price")]
        public string PurchasePrice { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seat")]
        public string Seat { get; set; }

        /// <summary>
        /// 车辆类型编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_class_code")]
        public string VehicleClassCode { get; set; }

        /// <summary>
        /// 车型代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_code")]
        public string VehicleCode { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_name")]
        public string VehicleName { get; set; }

        /// <summary>
        /// 年份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year_pattern")]
        public string YearPattern { get; set; }
    }
}
