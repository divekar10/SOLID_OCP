﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckoutDurationInDays { get; set; }


        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
