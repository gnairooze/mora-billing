using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Accnt
{
    public class Accnt_Constants
    {
        #region account status
        public int ACCOUNT_STATUS_NOT_SET = 0;
        public int ACCOUNT_STATUS_ACTIVE = 1;
        public int ACCOUNT_STATUS_INACTIVE = 2;
        public int ACCOUNT_STATUS_DELETED = 3;
        #endregion

        #region account item status
        public int ACCOUNT_ITEM_STATUS_NOT_SET = 0;
        public int ACCOUNT_ITEM_STATUS_ACTIVE = 1;
        public int ACCOUNT_ITEM_STATUS_INACTIVE = 2;
        #endregion

        #region account item - bill def status
        public int ACCOUNT_ITEM_BILLDEF_STATUS_NOT_SET = 0;
        public int ACCOUNT_ITEM_BILLDEF_STATUS_ACTIVE = 1;
        public int ACCOUNT_ITEM_BILLDEF_STATUS_INACTIVE = 2;
        #endregion

        #region item def price part status
        public int ITEMDEF_PRICEPART_STATUS_NOT_SET = 0;
        public int ITEMDEF_PRICEPART_STATUS_ACTIVE = 1;
        public int ITEMDEF_PRICEPART_STATUS_INACTIVE = 2;
        #endregion
    }
}
