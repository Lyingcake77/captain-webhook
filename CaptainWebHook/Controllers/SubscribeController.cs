using CaptainWebHook.Application;
using CaptainWebHook.Context;
using CaptainWebHook.Context.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaptainWebHook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public SubscribeController(DataContext DataContext)
        {
            _dataContext = DataContext;
        }

        // GET: api/<RegisterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RegisterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegisterController>
        [HttpPost]
        public void Post()
        {
            var newWebhooks = new Webhook() { IsDeleted = false, Data = "", WebhookName = "Users", EventName = "VRSUsers", CreationTime=DateTime.Now };
            _dataContext.WebHooks.Add(newWebhooks);
            _dataContext.SaveChanges();
            var newSubscription = new Subscription()
            {
                IsActive = true,
                ProviderId = new Guid(),
                UserId = new Guid(),
                Secret = "secret",
                WebhookUri = "https://localhost:44352/Watcher",
                AuthToken = "",
                Webhooks = newWebhooks


            };
            _dataContext.Subscriptions.Add(newSubscription);
            _dataContext.SaveChanges();
        }

        // PUT api/<RegisterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegisterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
