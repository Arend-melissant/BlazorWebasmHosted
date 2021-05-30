using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;

namespace BlazorWebasmHosted.Client.Shared
{
    public interface IState
    {
        event Action Notify;
        string ErrorMsg { get; set; }
    }
    public class State : IState
    {
        public event Action Notify;

        string errorMsg = "";
        public string ErrorMsg
        {
            get => errorMsg;
            set
            {
                if (errorMsg != value)
                {
                    errorMsg = value;

                    if (Notify != null)
                    {
                        Notify?.Invoke();
                    }
                }
            }
        }
    }
}
//     public static class Global
//     {
//         public static string ErrorMsg {get; set;} = "Test";
//     }
// }