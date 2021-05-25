using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaptainWebHook.Context.Models {
    public class Subscription
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Subscribed User's id .
        /// </summary>
        public Guid UserId { get; set; }
        public Guid ProviderId { get; set; }

        /// <summary>
        /// Subscription webhook endpoint
        /// </summary>
        [Required]
        public string WebhookUri { get; set; }

        /// <summary>
        /// Webhook secret
        /// </summary>
        [Required]
        public string Secret { get; set; }
        [Required]
        public string AuthToken { get; set; }

        /// <summary>
        /// Is subscription active
        /// </summary>
        public bool IsActive { get; set; }

        public Guid WebhookId { get; set; }
        //json list of webhooks
        public Webhook Webhooks { get; set; }

        //public IDictionary<string, string> Headers { get; set; }

        //public Subscription()
        //{
        //    IsActive = true;
        //    //Headers = new Dictionary<string, string>();
        //    Webhooks = new List<Webhook>();
        //}

    }
}
