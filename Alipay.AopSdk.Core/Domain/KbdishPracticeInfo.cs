using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishPracticeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishPracticeInfo : AopObject
    {
        /// <summary>
        /// 口碑的菜品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 加价类型  add:直接加 multiply:乘以系数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("increase_mode")]
        public string IncreaseMode { get; set; }

        /// <summary>
        /// 加价金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("increase_price")]
        public string IncreasePrice { get; set; }

        /// <summary>
        /// 做法名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("practice_name")]
        public string PracticeName { get; set; }
    }
}
