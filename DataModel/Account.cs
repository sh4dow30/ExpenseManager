using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiSoft.ExpenseManager.DataModel
{
    public class Account
    {
        public string Name { get; set; }
        public decimal InitialBalance { get; set; }
        public string Description { get; set; }
    }
}