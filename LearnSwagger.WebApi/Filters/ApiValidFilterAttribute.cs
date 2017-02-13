using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace LearnSwagger.WebApi.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public class ApiValidFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            base.OnActionExecuting(actionContext);

            string responsemessagebody = "";

            Dictionary<string, dynamic> actionargument = actionContext.ActionArguments;

            if (actionContext.Request.Method == HttpMethod.Get)
            {
                foreach (KeyValuePair<string, dynamic> arg in actionargument)
                {
                    string name = arg.Value;
                    //每天action的消息体不同可以tostring，然后处理
                    //responsemessagebody += arg.ToString();
                    //请求消息体相同
                    //可以直接使用
                    //    (typeobject)arg 直接使用
                }
            }
            else if(actionContext.Request.Method == HttpMethod.Post)
            {
                foreach (KeyValuePair<string, dynamic> arg in actionargument)
                {
                    string name = arg.Value.Name;
                    //每天action的消息体不同可以tostring，然后处理
                    //responsemessagebody += arg.ToString();
                    //请求消息体相同
                    //可以直接使用
                    //    (typeobject)arg 直接使用
                }
            }

            
        }
    }
}