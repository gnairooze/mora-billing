using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Ctlg
{
    public class Ctlg_Constants
    {
        #region item def status
        public int ITEMDEF_STATUS_NOT_SET = 0;
        public int ITEMDEF_STATUS_ACTIVE = 1;
        public int ITEMDEF_STATUS_INACTIVE = 2;
        #endregion

        #region item def price part recurring
        public int ITEMDEF_PRICEPART_RECURRING_NOT_SET = 0;
        public int ITEMDEF_PRICEPART_RECURRING_ONCE = 1;
        public int ITEMDEF_PRICEPART_RECURRING_WEEKLY = 2;
        public int ITEMDEF_PRICEPART_RECURRING_MONTHLY = 3;
        public int ITEMDEF_PRICEPART_RECURRING_QUARTERLY = 4;
        public int ITEMDEF_PRICEPART_RECURRING_YEARLY = 5;
        #endregion

        #region item def price part status
        public int ITEMDEF_PRICEPART_STATUS_NOT_SET = 0;
        public int ITEMDEF_PRICEPART_STATUS_ACTIVE = 1;
        public int ITEMDEF_PRICEPART_STATUS_INACTIVE = 2;
        #endregion
    }
}
