using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DownloadHandler
{
    public static class SalesOrderFunction
    {
        [FunctionName("SalesOrderFunction")]
        public static void Run([ServiceBusTrigger("sapdownloadqueuetesting", Connection = "SalesOrderDownload")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
