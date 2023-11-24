using Project.CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Results
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string messanges):base(data,true,messanges)
        {

        }
        public SuccessDataResult(T data):base(data,true)
        {

        }
        public SuccessDataResult(string messanges):base(default,true,messanges)
        {

        }
        
        //public SuccessDataResult(Task<User> task) : base(default, true)
        //{
          // Todo: sadece user için doneceksin.
        //}
    }
}
