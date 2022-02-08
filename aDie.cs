using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRollAkashResubmission
{
    /// <summary>
    /// This is the aDie class which is made as per the program requirements.
    /// It has a default constructor and a constructor that needs a seed for program function.
    /// This class is inherited from aRandomVariable Class
    ///
    /// </summary>
    class aDie : aRandomVariable
    {
        /// <summary>
        /// This is the default constructor. Dont need a parameter
        /// </summary>
        public aDie()
        {
            random = new Random(999);
        }

        //Constructor with seed. It will take the required seed and provide it for generation of random sequence.
        /// <summary>
        /// aDie class constructor which accepts a seed value to construct a die with necessary member function.
        /// </summary>
        /// <param name="seed"></param>
        public aDie(int seed)
        {
            random = new Random(seed);
        }

        /// <summary>
        /// The Roll function that generates random numbers with will be used to choose appropriate die image from imagelist.
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            int dieNum = random.Next(1, 7);
            return dieNum;
        }
    }
}
