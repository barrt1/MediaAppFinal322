using System;
using System.Collections.Generic;
using System.Text;

namespace MediaAppFinal.Tables
{
    //hold multiple user data
   class RegUserTable
    {
        public Guid UserId { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }


    }
}
