using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionBuildQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionBuildQueryResponse : AopResponse
    {
        /// <summary>
        /// 构建的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时
        /// </summary>
        [Newtonsoft.Json.JsonProperty("build_status")]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 创建版本的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时；6-版本创建成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_status")]
        public string CreateStatus { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_rotation")]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 是否创建版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_created")]
        public string VersionCreated { get; set; }
    }
}
