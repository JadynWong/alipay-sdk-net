using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdFacerepoSearchResponse.
    /// </summary>
    public class AlipaySecurityProdFacerepoSearchResponse : AopResponse
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 从入参指定的人脸库分组中搜索出来的相似度最高的人脸id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("face_id")]
        public string FaceId { get; set; }
    }
}
