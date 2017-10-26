using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AspWebService
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://localhost:9999/Calculator.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {

        [WebMethod]
        public void Calc(string num1, string num2, string op)
        {
            int res = 0;
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            switch (op)
            {
                case "-": res = n1 - n2; break;
                case "p": res = n1 + n2; break;
                case "*": res = n1 * n2; break;
                case "/": res = n1 / n2; break;
            }
            Object obj = new
            {
                Result = res
            };

            var oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            Context.Response.Write(oSerializer.Serialize(obj));

        }
    }
}
