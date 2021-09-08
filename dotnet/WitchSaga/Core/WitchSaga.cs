using System.Collections.Generic;
using WitchSaga.Extensions;
using WitchSaga.Models;
using WitchSaga.Utilities;

namespace WitchSaga.Core
{
    public class WitchSaga
    {
        private People _people;
        public WitchSaga(People people)
        {
            _people = people;
        }

        /// <summary>
        /// Get the number of people killed based on a given year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        private double GetNumberOfPeopleKilled(int year)
        {
            //pattern: after the first and second, add the two previous ones plus 1
            // 1 + 2 + 1 = 4
            // 2 + 4 + 1 = 7
            // 4 + 7 + 1 = 12 
            // etc
            //[1, 2, 4, 7, 12, 20, 33, 54, 88 ...]
            var list = new List<int>();

            for (int x = 1; x <= year; x++)
            {
                if (x == 1 || x == 2) //no calculation if 1 or 2
                    list.Add(x);
                else
                {
                    //add two last ones from the array + 1
                    list.Add(list[list.Count - 1] + list[list.Count - 2] + 1);
                }
            }

            return list[year - 1];
        }

        /// <summary>
        /// Get the average number of people killed by the witch
        /// </summary>
        /// <returns></returns>
        public double FindAverageOfPeopleKilled()
        {
            if (!_people.IsValid())
                return -1;

            int yearOfPersonA = _people.PersonA.YearOfDeath - _people.PersonA.AgeOfDeath;
            int yearOfPersonB = _people.PersonB.YearOfDeath - _people.PersonB.AgeOfDeath;

            if (yearOfPersonA.IsZeroOrNegative() || yearOfPersonB.IsZeroOrNegative()) return -1;

            return Utils.GetAverage(GetNumberOfPeopleKilled(yearOfPersonA), GetNumberOfPeopleKilled(yearOfPersonB));
        }
    }
}
