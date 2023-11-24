using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Results
{
   public class ErrorResult:Result
    {
        public ErrorResult(string messanges):base(false,messanges)
        {

        }
        public ErrorResult():base(false)
        {

        }
    }
}
