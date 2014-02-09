using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Class.BowlORama.Domain
{
    public class Frame
    {
        public int PinsScored()
        {
            return Roll1 + Roll2;
        }

        public int Roll2
        {
            get
            {
                return roll2;
            }
            set
            {

            }
        }
            

        public int Roll1
        {
            get
            {
                return roll1;
            }
            set
            {
                roll1 = value;
                if (value == 10)
                {
                    IsStrike = true;
                    
                }
            }
        }
            
            

    

        public bool IsStrike { get; set; }

        public int roll1 { get; set; }

        public int roll2 { get; set; }

        public bool IsSpare { get; set; }
    }
}
