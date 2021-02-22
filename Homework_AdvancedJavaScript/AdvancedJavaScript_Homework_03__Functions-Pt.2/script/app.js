// [Exercise 01]

let arrayOfStrings = ['Nikola', 'Kristina', 'Matej', 'Bojan'];
arrayOfStrings.forEach((element, index) => {
    console.log((index + 1) + "." + element);
});

// [Exercise 02]

let arrOfNumbers = [1, 2, 3, 4, 5, 6, 7];
let arrOfStrings = ['Nikola', 'Kristina', 'Bojan', 'Matej'];

concaTheEle = (array) => {
    let concatenate = "";
    for (const item of array) {
        concatenate += item;
    }
    console.log(concatenate);
}
concaTheEle(arrOfNumbers);
concaTheEle(arrOfStrings);

concaTheEleSum = (array) => {
    let concatenate = 0;
    for (const item of array) {
        concatenate += item;
    }
    console.log(concatenate);
}
concaTheEleSum(arrOfNumbers);


linkString = (arr) => {
    let resultDiv = document.querySelector('#resultDiv');
    resultDiv.innerHTML += `<p>${arr.join(" ")}</p>`;
}
linkString(arrOfStrings);
linkString(arrOfNumbers);

// [Exercise 03]

let arrOfStr = ['Nikola', 'Kristina', 'Bojan', 'Matej', 'Kiki', 'Niki', 'Toni', 'Saso'];
let filteredArr = [];

filterArr = (arr) => {
    for (const item of arr) {
        if (item.length <= 5) {
            filteredArr.push(item);
        }
    }
    console.log(filteredArr);
}
filterArr(arrOfStr);

const filteredArrWithHOF = arrOfStr.filter((element) => element.length <= 5);
console.log(filteredArrWithHOF);

// [Exercise 04]

fetch('https://jsonplaceholder.typicode.com/users')
    .then(resp => {
        if (resp.ok) {
            return resp.json();
        } else if (resp.status === 404) {
            return Promise.reject('ERROR 404! Page not found!!!')
        } else {
            return Promise.reject('There was some error! ' + resp.statusText);
        }
    })
    .then(users => {
        addAge(users);
        console.log(users);
    })
    .catch(error => alert('Something went wrong! Please try again! ' + error));

addAge = array => {
    for (const user of array) {
        user.age = Math.floor((Math.random() * 62) + 18);
    }
}

// [Homework 01]

const arrOfNumb = [1, 2, 3, 4, 5, 6, 7, 8];
const emptyArr = [];

// // [Normal]
// multiplyBy10 = (arr) => {
//     for (const numb of arr) {
//         emptyArr.push(numb * 10);
//     }
//     console.log(emptyArr);
// }
// multiplyBy10(arrOfNumb);

// Two parameters
multiplyElement = (arr, multiplier) => {
    for (const numb of arr) {
        emptyArr.push(numb * multiplier)
    }
    console.log(emptyArr);
}
multiplyElement(arrOfNumb, 100);

// [With HOF]
// Multiplied by the position
const mappedEmptyArr = arrOfNumb.map((element, multiplier) => element * multiplier);
console.log(mappedEmptyArr);
// [With HOF]
// Multiplied by 100
const mappedEmptyArrBy100 = arrOfNumb.map((element) => element * 100);
console.log(mappedEmptyArrBy100);

// [Homework 02]

const arrayOfNumb = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14];
const filterNumber = 2;
const filteredArray = [];

filterArr = (arr, filtNum) => {
    for (const number of arr) {
        if(number % filtNum === 0) {
            filteredArray.push(number)
        }
    }
    console.log(filteredArray);
}

filterArr(arrayOfNumb, filterNumber);

const filterAndMapArr = arrayOfNumb.filter((element) => element % 2 === 0).sort((a, b) => a-b);
console.log(filterAndMapArr);