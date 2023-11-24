using Project.CORE.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Bussiness
{
    public static class BussinessRules
    {
        /// <summary>
        /// Sonsuz logic alabilir.
        /// </summary>
        /// <param name="logics"></param>
        /// <returns></returns>
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }

}
