using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsDataAutoFraudQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataAutoFraudQueryModel : AopObject
    {
        /// <summary>
        /// 出险城市，六位国标码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accident_city")]
        public string AccidentCity { get; set; }

        /// <summary>
        /// 出险时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accident_date")]
        public string AccidentDate { get; set; }

        /// <summary>
        /// 出险地点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accident_location")]
        public string AccidentLocation { get; set; }

        /// <summary>
        /// 立案金额，单位：元  查勘阶段必传
        /// </summary>
        [Newtonsoft.Json.JsonProperty("case_amount")]
        public string CaseAmount { get; set; }

        /// <summary>
        /// 估损金额，单位：元  核赔阶段必传
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimate_damage_amount")]
        public string EstimateDamageAmount { get; set; }

        /// <summary>
        /// 报案人信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("informant")]
        public Informant Informant { get; set; }

        /// <summary>
        /// 人伤数量，上限15，没有人伤则填0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("injured_count")]
        public long InjuredCount { get; set; }

        /// <summary>
        /// 伤者列表，涉及人伤案件在查勘、核赔阶段必选
        /// </summary>
        [XmlArray("injured_list")]
        [XmlArrayItem("injured")]
        public List<Injured> InjuredList { get; set; }

        /// <summary>
        /// 投保城市，六位国标编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insure_city")]
        public string InsureCity { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insured")]
        public Insured Insured { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 报案时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 报案号，使用保险公司实际业务流程中的报案号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 请求号，每一次请求都需要变化且唯一。可使用UUID实现
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 理赔场景编码，对应实际发生反欺诈调用的场景。  枚举如下：  REPORT:报案  SURVEY:查勘  CLAIMS_ASSESS:核赔
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 标的车信息  报案阶段可选，查勘、核赔阶段必传
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject_car")]
        public ReportCar SubjectCar { get; set; }

        /// <summary>
        /// 三者车数量，上限15辆，如果没有则为0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_party_car_count")]
        public long ThirdPartyCarCount { get; set; }

        /// <summary>
        /// 三者车列表，涉及三者车的案件在查勘、核赔阶段必选
        /// </summary>
        [XmlArray("third_party_car_list")]
        [XmlArrayItem("report_car")]
        public List<ReportCar> ThirdPartyCarList { get; set; }
    }
}
