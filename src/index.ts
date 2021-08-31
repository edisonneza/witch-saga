import { People } from "./models/index";
import WitchSaga from "./core/WitchSaga";


const btnSubmit = document.getElementById("btnSubmit");

btnSubmit.addEventListener('click', () => {
    let people: People = {
        personA: {
            ageOfDeath: Number((<HTMLInputElement> document.getElementById("person1Age")).value),
            yearOfDeath: Number((<HTMLInputElement> document.getElementById("person1Year")).value)
        },
        personB: {
            ageOfDeath: Number((<HTMLInputElement> document.getElementById("person2Age")).value),
            yearOfDeath: Number((<HTMLInputElement> document.getElementById("person2Year")).value)
        }
    }

    const witchSaga = new WitchSaga(people);

    const resultContainer = document.getElementById("result");
    resultContainer.innerText = witchSaga.FindAverageOfPeopleKilled().toString();
});


// let otherPeople: People = {
//     personA: {
//         ageOfDeath: 15,
//         yearOfDeath: 12
//     },
//     personB: {
//         ageOfDeath: 12,
//         yearOfDeath: 17
//     }
// }

// const witchSagaOtherPeople = new WitchSaga(otherPeople);

// console.log(witchSagaOtherPeople.FindAverageOfPeopleKilled());

