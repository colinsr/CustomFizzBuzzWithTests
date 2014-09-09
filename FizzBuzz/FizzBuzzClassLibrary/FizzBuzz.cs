using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzClassLibrary
{
    public class FizzBuzz
    {
        
        #region Constructors
        public FizzBuzz(int upperBound)
        {
            this.UpperBound = upperBound;
            this.Divisors = new List<Divisor>()
            {
                new Divisor() { Number = 3, Message = "Fizz"},
                new Divisor() { Number = 5, Message = "Buzz"}
            };
        }

        public FizzBuzz(int upperBound, List<Divisor> divisors)
        {
            this.UpperBound = upperBound;
            this.Divisors = divisors;
        }
        #endregion

        #region Properties
        public int UpperBound { get; set; }
        public List<Divisor> Divisors { get; set; }

        #endregion

        #region Methods
        public string[] RunFizzBuzz()
        {
            string[] strings = new string[UpperBound];

            for (int i = 1; i <= UpperBound; i++)
            {
                StringBuilder sb = new StringBuilder();//so that I can concatenate the messages

                foreach (var customDivisor in Divisors)
                {
                    if (i % customDivisor.Number == 0)
                    {
                        sb.Append(customDivisor.Message);
                    }
                    //here if sb.length is < 1 (empty) then print number
                    strings[i - 1] = sb.Length < 1 ? i.ToString() : sb.ToString();
                }
                
            }

            return strings;
        }

        #endregion
    }

    public class Divisor
    {
        #region Properties
        public int Number { get; set; }
        public string Message { get; set; }
        #endregion
    }
}