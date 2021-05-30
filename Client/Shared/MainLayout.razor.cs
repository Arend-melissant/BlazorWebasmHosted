using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;

namespace BlazorWebasmHosted.Client.Shared
{
    public partial class MainLayoutComponent
    {
        protected async System.Threading.Tasks.Task SidebarToggle0Click(dynamic args)
        {
            await InvokeAsync(() => { sidebar0.Toggle(); });

            await InvokeAsync(() => { body0.Toggle(); });
        }

        public string ErrorButtonText {get; set;} = "Set Error";

        protected async System.Threading.Tasks.Task ShowError()
        {
            if (State.ErrorMsg == "")
            {
                State.ErrorMsg = "error";
                ErrorButtonText = "Clear Error";
            }
            else
            {
                State.ErrorMsg = "";
                ErrorButtonText = "Set Error";
            }
        }
    }
}
