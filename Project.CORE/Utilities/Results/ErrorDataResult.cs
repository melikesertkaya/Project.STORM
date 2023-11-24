using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Results
{
   public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,string messanges):base(data,false,messanges)
        {

        }
        public ErrorDataResult(T data):base(data,false)
        {

        }
        public ErrorDataResult(string messanges):base(default,false,messanges)
        {

        }
        public ErrorDataResult():base(default,false)
        {

        }
    }
}
