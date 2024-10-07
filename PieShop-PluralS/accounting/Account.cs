using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShop_PluralS.Accounting
{

    public record Account (string AccountNumber);
    //positional record




   /* public record Account
           //word changes, but same concept.
           //records used when there is just data, typically same as classes but classes contain otheer data members
    {
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                accountNumber = value;

            }

        }
    }
   */


    /*  public class Account
      {
          private string accountNumber;

          public string AccountNumber
          {
              get { return accountNumber; }
              set
              {
                  accountNumber = value;

              }

          }
      }
    */
    //can be made into a record
}
