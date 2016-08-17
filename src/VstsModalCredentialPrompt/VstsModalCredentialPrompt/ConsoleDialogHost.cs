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
    public class ConsoleDialogHost : IDialogHost
    {
        public async Task<bool?> InvokeDialogAsync(InvokeDialogFunc showDialog, object state)
        {
            var consoleWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
            return showDialog(consoleWindowHandle, state);
        }
    }
}
