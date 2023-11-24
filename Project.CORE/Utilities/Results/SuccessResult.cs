using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string messanges):base(true,messanges)//Base e bool tipi ve string tipini gonderıyoruz bu class basarılı oldugu için true ve messange sini yolluyoruz
        {

        }
       
        public SuccessResult():base(true)
        {
            
        }

        
    }
}
