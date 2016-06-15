using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.BllDf
{
    public class BllDf_Constants
    {
        #region bill def recurring
        public int BILLDEF_RECURRING_NOT_SET = 0;
        public int BILLDEF_RECURRING_ONCE = 1;
        public int BILLDEF_RECURRING_WEEKLY = 2;
        public int BILLDEF_RECURRING_MONTHLY = 3;
        public int BILLDEF_RECURRING_QUARTERLY = 4;
        public int BILLDEF_RECURRING_YEARLY = 5;
        #endregion

        #region bill def - bill template body status
        public int BILLDEF_BILL_TEMPLATE_BODY_STATUS_NOT_SET = 0;
        public int BILLDEF_BILL_TEMPLATE_BODY_STATUS_ACTIVE = 1;
        public int BILLDEF_BILL_TEMPLATE_BODY_STATUS_INACTIVE = 2;
        #endregion

        #region bill def - bill template body - period status
        public int BILLDEF_BILL_TEMPLATE_BODY_PERIOD_STATUS_NOT_SET = 0;
        public int BILLDEF_BILL_TEMPLATE_BODY_PERIOD_STATUS_ACTIVE = 1;
        public int BILLDEF_BILL_TEMPLATE_BODY_PERIOD_STATUS_INACTIVE = 2;
        #endregion

        #region period status
        public int PERIOD_STATUS_NOT_SET = 0;
        public int PERIOD_STATUS_ACTIVE = 1;
        public int PERIOD_STATUS_INACTIVE = 2;
        #endregion
    }
}
