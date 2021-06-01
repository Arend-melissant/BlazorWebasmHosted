using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebasmHosted.Client.Shared
{
    public partial class MainLayoutComponent
    {
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
