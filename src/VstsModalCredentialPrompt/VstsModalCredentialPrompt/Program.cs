using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Client.Controls;
using Microsoft.VisualStudio.Services.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsModalCredentialPrompt
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var accountName = "youraccountname";

            var host = new ConsoleDialogHost();
            var credentials = new VssClientCredentials(false, host);

            var collection = new TfsTeamProjectCollection(new Uri($"https://{accountName}.visualstudio.com"), credentials);
            var workItemStore = collection.GetService<WorkItemStore>();
            var workItem = workItemStore.GetWorkItem(59);
        }
    }
}
