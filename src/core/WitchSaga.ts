import { People, Person } from "../models/index";
import { IsNegative, GetAverage } from "../utils/index";

class WitchSaga {
    private _people: People;

    constructor(people: People) {
        this._people = people;
    }

     /**
      * Check if person object is valid
      * @param person of type Person
      * @returns true or false
      */
    private IsPersonValid(person: Person): boolean {
        if (IsNegative(person.yearOfDeath) || IsNegative(person.ageOfDeath))
            return false;

        return person.yearOfDeath > person.ageOfDeath;
    }

    /**
     * Check if the given people object is valid
     * @returns true or false
     */
    private IsValid(): boolean {
        if (!this._people.personA || !this._people.personB || !this._people.personA.ageOfDeath || !this._people.personA.yearOfDeath || !this._people.personB.ageOfDeath || !this._people.personB.yearOfDeath)
            return false;

        if (!this.IsPersonValid(this._people.personA)
            || !this.IsPersonValid(this._people.personB))
            return false;

        return true;
    }

    /**
     * Get the number of people killed based on a given year
     * @param year 
     * @returns the number of people killed
     */
    private GetNumberOfPeopleKilled(year: number): number {
        //pattern: after the first and second, add the two previous ones plus 1
        // 1 + 2 + 1 = 4
        // 2 + 4 + 1 = 7
        // 4 + 7 + 1 = 12 
        // etc
        //[1, 2, 4, 7, 12, 20, 33, 54, 88 ...]
        let array = [];
        
        for (let x = 1; x <= year; x++) {
            if (x == 1 || x == 2) //no calculation if 1 or 2
                array.push(x)
            else {
                //add two last ones from the array + 1
                array.push(array[array.length - 1] + array[array.length - 2] + 1);
            }

        }

        return array[year - 1];
    }

    /**
     * Get the average number of people killed by the witch
     * @returns average number
     */
    public FindAverageOfPeopleKilled(): number {
        if (!this.IsValid())
            return -1;
    
        var yearOfPersonA = this._people.personA.yearOfDeath - this._people.personA.ageOfDeath;
        var yearOfPersonB = this._people.personB.yearOfDeath - this._people.personB.ageOfDeath;
    
        console.log("person A:" + this.GetNumberOfPeopleKilled(yearOfPersonA));
        console.log("person B:" + this.GetNumberOfPeopleKilled(yearOfPersonB));
    
        console.log("Average: " + GetAverage(this.GetNumberOfPeopleKilled(yearOfPersonA), this.GetNumberOfPeopleKilled(yearOfPersonB)));
        

        const average = GetAverage(this.GetNumberOfPeopleKilled(yearOfPersonA), this.GetNumberOfPeopleKilled(yearOfPersonB));

        return average;
    }
}

export default WitchSaga;