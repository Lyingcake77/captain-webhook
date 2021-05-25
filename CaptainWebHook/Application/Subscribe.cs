using CaptainWebHook.Context;
using CaptainWebHook.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptainWebHook.Application
{
    public class Subscribe
    {
        private readonly DataContext _dataContext;
        public Subscribe(DataContext DataContext)
        {
            _dataContext = DataContext;
        }

        public void CreateSubscription()
        {
            var newWebhooks = new Webhook() { IsDeleted = false, Data = "", WebhookName = "Users", EventName = "VRSUsers" };
            _dataContext.WebHooks.Add(newWebhooks);
            _dataContext.SaveChanges();
            var newSubscription = new Subscription() {
                IsActive = true,
                ProviderId = new Guid(),
                UserId = new Guid(),
                Secret= "secret",
                WebhookUri = "https://localhost:44352/Watcher",
                AuthToken="",
                Webhooks = newWebhooks


            };
            _dataContext.Subscriptions.Add(newSubscription);
            _dataContext.SaveChanges();

        }
        public void UpdateSubscription()
        {

        }
        public void DeleteSubscription()
        {

        }
        public void GetSubscription()
        {

        }
        public void ListSubscription()
        {

        }
    }
}
