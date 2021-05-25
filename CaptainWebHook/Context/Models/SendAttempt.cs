using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace CaptainWebHook.Context.Models
{
    /// <summary>
    /// Table for store webhook work items. Each item stores web hook send attempt of <see cref="WebhookEvent"/> to subscribed tenants
    /// </summary>
    public class SendAttempt
    {
        public Guid Id { get; set; }
        /// <summary>
        /// <see cref="WebhookEvent"/> foreign id 
        /// </summary>
        [Required]
        public Guid WebhookEventId { get; set; }

        /// <summary>
        /// <see cref="Subscription"/> foreign id 
        /// </summary>
        [Required]
        public Guid WebhookSubscriptionId { get; set; }

        /// <summary>
        /// Webhook response content that webhook endpoint send back
        /// </summary>
        public string Response { get; set; }

        /// <summary>
        /// Webhook response status code that webhook endpoint send back
        /// </summary>
        public HttpStatusCode? ResponseStatusCode { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public int? UserId { get; set; }

        ///// <summary>
        ///// WebhookEvent of this send attempt.
        ///// </summary>
        //public virtual Webhook WebhookEvent { get; set; }

        ///// <summary>
        ///// WebhookEvent of this send attempt.
        ///// </summary>
        //public virtual Subscription WebHookSubscription { get; set; }
    }
}
