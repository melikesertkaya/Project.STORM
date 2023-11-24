using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Entities.Enums
{
    public enum State
    {
        #region OrderState
        CreatingOrder = 1,
        New = 2,
        Packed = 3,
        Shipped = 4,
        Active = 9,
        Passive = 8,
        Modified = 7,
        #endregion

        #region
        Inserted = 001,
        Updated = 002,
        Deleted = 003,
        #endregion


    }
}
