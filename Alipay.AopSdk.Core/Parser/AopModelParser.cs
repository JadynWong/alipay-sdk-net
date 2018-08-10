using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aop.Api;
using System.Reflection;
using System.Collections;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Parser
{
    public class AopModelParser
    {
        /// <summary>
        /// Json序列化AopObject对象
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        public string SerializeAopObject(AopObject res)

        {
            JsonSerializerSettings jsetting = new JsonSerializerSettings();

            jsetting.NullValueHandling = NullValueHandling.Ignore;

            return JsonConvert.SerializeObject(res, Formatting.None, jsetting);
        }
    }
}