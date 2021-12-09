using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public enum OperationStatus { [Description("в обработке")]
                                  Processing,
                                  [Description("отменен")]
                                  Cancelled,
                                  [Description("завершен")]
                                  Completed
    };
    public class Operation
    {
        private DateTime date;
        private string product;
        private OperationStatus status;

        public Operation(DateTime date, string product, OperationStatus status)
        {
            this.date = date;
            this.product = product;
            this.status = status;
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public string Product
        {
            get
            {
                return product;
            }
        }

        public OperationStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
