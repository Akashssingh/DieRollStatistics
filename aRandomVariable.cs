using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRollAkashResubmission
{
    /// <summary>
    /// This is the random variable, modified Random class for purpose of making 1 random sequence rather multiple
    /// </summary>
    class aRandomVariable
    {
        //here it is the main reason that we used static Random variable so it can be instantiated later
        //later. This will give us common random number sequence as we just want 1 random sequence for both dice.
        //Hence, this entire class was used instead of inheriting the aDie class from Random directly.
        //We will be using this class which will provide inheritence to aDie class. 
        public static Random random;
    }
}
