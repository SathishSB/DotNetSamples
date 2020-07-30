using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApIExmple.Controllers
{
    [RoutePrefix("api/Calculate")]
    public class CalculateController : ApiController
    {
        // GET api/Calculate/Addition
        [Route("Addition")]
        public int GetAddition() // Add arguments
        {
            return 2+3;
        }

        // GET api/Calculate/Subtraction
        [Route("Subtraction")]
        public int GetSubtraction() // Add arguments
        {
            return 3-2;
        }

        // GET api/Calculate/Multiplication
        [Route("Multiplication")]
        public int GetMultiplication() // Add arguments
        {
           return 2*3;
        }

        [HttpPost]
        // GET api/Calculate/AddTwoNembers
        [Route("AddTwoNembers")]
        public int AddTwoNembers(int a, int b)
        {
            return 2 + 3;
        }

        [HttpPost]
        // GET api/Calculate/AddPrefix
        [Route("AddPrefix")]
        public String AddPrefix([FromBody] string str)
        {
            return String.Format("Mr {0}",str);
        }

        [HttpPost]
        // GET api/Calculate/ConcatinateStrings
        [Route("ConcatinateStrings")]
        public string SubtractTwoNembers(String str1, String str2)
        {
            return String.Format("{0} - {0}", str1, str2);
        }

        [HttpPost]
        // GET api/Calculate/GetSubString
        [Route("GetSubString")]
        public string SubString(String str1, int a)
        {
            return str1.Substring(0, a);
        }    
    }  
} 