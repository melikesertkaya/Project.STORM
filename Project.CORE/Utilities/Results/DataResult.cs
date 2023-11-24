using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; set; }

        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        /// <summary>
        /// Success ve messages doner
        /// </summary>
        /// <param name="data"></param>
        /// <param name="success"></param>
        /// <param name="messanges"></param>
        public DataResult(T data,bool success,string messanges):base(success,messanges)
        {
            Data = data;
        }
        public DataResult()
        {

        }
    }
}
