using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CustomerWebApi.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        public CustomerResponse GetAllCustomers()
        {
            CustomerResponse customerRes = new CustomerResponse();
            try
            {
                customerRes.StatusCode = "200";
                Customer c = new Customer();
                
     
                customerRes.Result = Newtonsoft.Json.JsonConvert.SerializeObject(c);

            }
            catch (Exception ex)
            {

                customerRes.Error = ex.Message;
            }
            
            


            return customerRes;
        }
    }


    public class Customer
    {
        public string CustCode { get; set; }
        public string CustName { get; set; }

        public Customer()
        {
            CustCode = "000";
            CustName = "Dummy";
        }
    }

    public class Response
    {

        public string StatusCode { get; set; }
        public string Result { get; set; }
        public string Error { get; set; }
    }

    public class CustomerResponse:Response
    {

    }
}