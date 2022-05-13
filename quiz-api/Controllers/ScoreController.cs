using Azure.Messaging.ServiceBus;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Quiz.Api.Models;

namespace Quiz.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        public ScoreController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpPost]
        public async Task<string> RequestCertificateAsync(Score score)
        {
            //send message to servicebus
            var client = new ServiceBusClient(Configuration["ServicebusConnectionString"]);
            var sender = client.CreateSender("quiz-cert-requests");

            try
            {
                
                var message = new ServiceBusMessage(JsonConvert.SerializeObject(score));
                message.ContentType = "application/json";
                await sender.SendMessageAsync(message);
                return "Request Accepted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }

        }

       
    }
}
