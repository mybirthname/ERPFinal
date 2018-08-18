﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Services
{
    public class DateTimeService
    {
        public DateTime CurrentTime { get; set; }

        public DateTime ProvideDateTime()
        {
            if (CurrentTime != null)
                return CurrentTime;

            return DateTime.Now;
        }
    }
}
