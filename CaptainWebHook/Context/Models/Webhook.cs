using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaptainWebHook.Context.Models
{
    /// <summary>
    /// Store created web hooks. To see who get that webhook check with <see cref="SendAttempt.WebhookEventId"/> and you can get <see cref="SendAttempt.WebhookSubscriptionId"/>
    /// </summary>
    public class Webhook
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Webhook unique name <see cref="WebhookDefinition.Name"/>
        /// </summary>
        [Required]
        public string WebhookName { get; set; }
        public string EventName { get; set; }

        /// <summary>
        /// Webhook data as JSON string.
        /// </summary>
        public string Data { get; set; }

        //[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreationTime { get; set; }


        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }
    }
}
