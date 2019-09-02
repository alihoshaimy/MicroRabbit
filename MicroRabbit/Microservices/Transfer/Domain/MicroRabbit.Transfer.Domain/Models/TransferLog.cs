using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timespan { get; set; }

        public TransferLog()
        {
            Timespan = DateTime.Now;
        }
    }
}
