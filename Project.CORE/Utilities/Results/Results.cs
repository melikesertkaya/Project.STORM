using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Results
{
    public class Result : IResult
    {

        /// <summary>
        /// Donus tipi success ve message verir
        /// </summary>
        /// <param name="success"></param>
        /// <param name="messanges"></param>
        public Result(bool success,string messanges):this(success)
        {
            Messange = messanges;
        }
        /// <summary>
        /// Donus tipi bool döner
        /// </summary>
        /// <param name="success"></param>
        public Result(bool success)
        {
            Success = success;
        }
        public Result()
        {

        }
        public bool Success {get;set;}

        public string Messange { get; set; }
    }
}
