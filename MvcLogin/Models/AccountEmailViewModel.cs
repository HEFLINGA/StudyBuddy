using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcLogin.Models
{
    public class AccountEmailViewModel
    {
        public List<Account> Accounts { get; set; }
        public SelectList Emails { get; set; }
        public string AccountEmail { get; set; }
        public string SearchString { get; set; }
    }
}