using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearnSwagger.Dto;
using LearnSwagger.WebApi.Filters;
using LearnSwagger.WebApi.Models;

namespace LearnSwagger.WebApi.Controllers
{
    /// <summary>
    /// 测试资源
    /// </summary>
    public class TestController : ApiController
    {
        /// <summary>
        /// 1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        [ApiValidFilter]
        public TestInput Get(string id)
        {
            return new TestInput() {Name = id };
        }

        ///// <summary>
        ///// 2
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="msg"></param>
        ///// <returns></returns>
        //[Route("api/Test/{id}/{msg}")]
        //public HttpResponseMessage GetMsg(string id, string msg)
        //{
        //    return new HttpResponseMessage(HttpStatusCode.OK)
        //    {
        //        Content = new StringContent(id + "||" + msg)
        //    };
        //}

        /// <summary>
        /// 3
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [ApiValidFilter]
        public HttpResponseMessage Post(TestInput input)
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(input.Name)
            };
        }

        /// <summary>
        /// 4
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Route("api/Test/Dto")]
        public HttpResponseMessage Post(TestAddInput input)
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(input.TestName)
            };
        }
    }
}
