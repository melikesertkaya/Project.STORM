using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Results
{
    public interface IResult
    {
        /// <summary>
        /// Readonly
        /// </summary>
        bool Success { get; }
        /// <summary>
        /// Readonly
        /// </summary>
        string Messange { get; }
        
    }
}
