using WitchSaga.Extensions;

namespace WitchSaga.Models
{
    public class Person
    {
        public Person(int ageOfDeath, int yearOfDeath)
        {
            AgeOfDeath = ageOfDeath;
            YearOfDeath = yearOfDeath;
        }
        public int AgeOfDeath { get; set; }
        public int YearOfDeath { get; set; }

        /// <summary>
        /// Check if person object is valid
        /// </summary>
        /// <returns></returns>
        public bool IsPersonValid()
        {
            if (AgeOfDeath.IsZeroOrNegative() || YearOfDeath.IsZeroOrNegative())
                return false;

            return true;
        }
    }
}
