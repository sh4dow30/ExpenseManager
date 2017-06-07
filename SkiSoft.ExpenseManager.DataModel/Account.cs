using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SkiSoft.ExpenseManager.DataModel
{
    public class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; }
    }
}