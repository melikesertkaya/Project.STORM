using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Entities.Concrete
{
    public class User:IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }//byte[] bizim için byte array olacak
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }//Veri durumu 

        //Relational Properties 
        public virtual List<OperationClaim>  OperationClaims { get; set; }
     
    }
}
