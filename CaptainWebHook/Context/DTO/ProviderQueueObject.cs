using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptainWebHook.Context.DTO
{
    public class ProviderQueueObject
    {
        public Guid ProviderId { get; set; }
        public object QueueObject { get; set; }
    }
}
