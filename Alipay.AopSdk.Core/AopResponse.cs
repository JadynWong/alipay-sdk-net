using System;
using System.Xml.Serialization;

namespace Aop.Api
{
    [Serializable]
    public abstract class AopResponse
    {
        private string code;
        private string msg;
        private string subCode;
        private string subMsg;
        private string body;

        /// <summary>
        /// 错误码 对应 ErrCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        /// 错误信息 对应 ErrMsg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        /// <summary>
        /// 子错误码 对应 SubErrCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_code")]
        public string SubCode
        {
            get { return subCode; }
            set { subCode = value; }
        }

        /// <summary>
        /// 子错误信息 对应 SubErrMsg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_msg")]
        public string SubMsg
        {
            get { return subMsg; }
            set { subMsg = value; }
        }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public bool IsError
        {
            get
            {
                return !string.IsNullOrEmpty(this.SubCode);
            }
        }
    }
}