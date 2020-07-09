using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Model
    {
    }
    public class AccountDetails
    {    
        int Accountid   { get; set; }
        int BankID { get; set; }
        String BankAccountNo { get; set; }
        Boolean Isactive { get; set; }
    }
    public class BankDetails 
    {
        int BankID { get; set; }
        int BankName { get; set; }
        String Location { get; set; }
        int Isactive { get; set; }
    }

}
