using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Test_Walkthrough.Model;


namespace Test_Walkthrough
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly HttpClient client = new HttpClient();
        private const string URL = "http://localhost:58544/";
        static void Main(string[] args)
        {
            try
            {
                //Call Json API
                log.InfoFormat("Main Start");
                // Console.Write(msg);
                CallWebAPIAsync().Wait();
                log.InfoFormat("Main End");
            }
            catch( Exception ex)
            {
                log.ErrorFormat("Error in during main call:{0}",ex);
            }
            
        }

        private static async Task CallWebAPIAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58544/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("API/GetMessages");
                if (response.IsSuccessStatusCode)
                {
                    MessageDto result = await response.Content.ReadAsAsync<MessageDto>();
                    Console.WriteLine("Id:{0}\tName:{1}\tName:{2}", result.Id, result.MessageText, result.MessageBody);
                    
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
        }
     }
}
