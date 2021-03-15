// // *** Student exercise #2: ***

// function celToFahr(celsius) {
//     let result = celsius * 1.8 + 32;
//     alert(`${celsius} Celsius is ${result} Fahrenheit.`);
// }

// function fahrToCel(fahrenheit) {
//     let result = (5 / 9) * (fahrenheit - 32);
//     alert(`${fahrenheit} Fahrenheit is ${result} Celsius.`);
// }

// let personDecision = prompt(`Please enter 'C' if you want to convert Celsius to Fahrenheit \n or 'F' if you want to convert Fahrenheit to Celsius.`);

// if (personDecision === `C`) {
//    let celsius = parseInt(prompt(`Please enter your Celsius Degrees`));
//    celToFahr(celsius);
// } else if (personDecision === `F`) {
//     let fahrenheit = parseInt(prompt(`Please enter your Fahrenheit Degrees`));
//     fahrToCel(fahrenheit);
// } else {
//     alert(`Please enter C for Celsius or F for Fahrenheit!`);
// }

// // *** Student exercise #3: ***

// function calculateAge(birthYear,currentYear) {
//     let result = currentYear - birthYear;
//     console.log(`You are ${result} years old.`);
// }

// calculateAge(1996,2021);
// calculateAge(1995,2021);
// calculateAge(2001,2021);

// // *** Bonus #3: ***

// function calculateAge() {
//     let currentYear = new Date().getFullYear();
//     let birthYear = parseInt(prompt(`Please enter your birth year.`))
//     let result = currentYear - birthYear;
//     alert(`You are ${result} years old.`);
// }

// calculateAge();

// // *** Homework Part#1: ***

// function typeOfFunc(parameter) {
//     let result = typeof(parameter);
//     console.log(`The variable you entered is from type ${result}.`);
// }

// typeOfFunc(2);
// typeOfFunc(`Nikola`);
// typeOfFunc(false);
// typeOfFunc();
// typeOfFunc(0);

// // *** Homework Part#2: ***

// function dogsAge() {
//     let result = prompt(`Hello,please enter Dog for Dog's age conversion \n or enter Human for Human's age conversion.`);
//     if (result === `Dog`) {
//         let value = parseInt(prompt(`Please enter your human years.`));
//         let calcAge = value * 7;
//         alert(`${value} human years is ${calcAge} dog years.`);
//         console.log(`${value} human years is ${calcAge} dog years.`);
//     } else if (result === `Human`) {
//         let value = parseInt(prompt(`Please enter your dog years.`));
//         let calcAge = value / 7;
//         alert(`${value} dog years is ${calcAge} human years.`);
//         console.log(`${value} dog years is ${calcAge} human years.`);
//     } else {
//         alert(`Please enter Dog or Human!`);
//     }
// }

// dogsAge();

// // *** Homework Part#3: ***

let accTotalAmount = 100000;

function takeOutMoney(money) {
    let withdrawMoney = accTotalAmount - money;
    if (money > accTotalAmount) {
        alert(`You dont have the ammount of money you requested for!`)
    } else if (money <= accTotalAmount) {
        alert(`You have taken out ${money}$ and now your account total balance is ${withdrawMoney}$.`)
    } else {
        alert(`Please enter a number!`)
    }
}


function ATM() {
    let customerChoice = prompt(`Hello our dear customer, please enter \n WITHDRAW if you want to take out money.`);
    if (customerChoice === `WITHDRAW`) {
        takeOutMoney(parseInt(prompt(`Please enter the amount of money you want to withdraw.`)));
    } else {
        alert(`Please write WITHDRAW if you want to take out money!`)
    }
}

ATM();
