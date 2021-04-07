// // *** Exercise 1: ***

// let firstName =  `Nikola`;
// let number = 25;
// let dog;
// let cat = false;
// let nullValue = null;

// // Display value

// console.log(firstName);
// console.log(number);
// console.log(dog);
// console.log(cat);
// console.log(nullValue);

// console.log("=======================================================");

// // Display data type

// console.log(typeof firstName);
// console.log(typeof number);
// console.log(typeof dog);
// console.log(typeof cat);
// console.log(typeof nullValue);

// console.log("=======================================================");


// // *** Exercise 2: ***

// let num1 = 25;
// let num2 = 3;
// let num3 = 19.96;
// //  Addition
// let addition = num1 + num2;
// console.log("Addition",addition);

// console.log("=======================================================");

// // Subtraction
// let subtraction = num1 - num3;
// console.log("Subtraction",subtraction);

// console.log("=======================================================");

// // Multiplication
// let multiplication = num1 * num2;
// console.log("Multiplication",multiplication);

// console.log("=======================================================");

// // Division
// let division = num1 / num2;
// console.log("Division",division);

// console.log("=======================================================");

// // Modulus
// let remainder = num1 % num2;
// console.log("Remainder",remainder);

// console.log("=======================================================");

// // Increment a=a+1
// num1++;
// console.log("Increment",num1);

// console.log("=======================================================");

// // Decrement a=a-1
// num2--;
// console.log("Decrement",num2);

// console.log("=======================================================");



// *** Exercise 3: ***

// let closerTo100 = prompt(`Hello, do you want to know which number is closer to 100?`);

// if (closerTo100 === `yes`) {
//     let x = prompt("Please enter your first number");
//     let px = parseInt(x);
//     let y = prompt("Please enter your second number");
//     let py = parseInt(y);

//     if (px > 100 && py > 100) {
//         alert(`Your numbers are ${px} and ${py}`);
//         let x1 = px - 100;
//         let y1 = py - 100;
//         if (x1 < y1) {
//             alert(`${px} is closer to 100!`);
//         } else if (x1 > y1) {
//             alert(`${py} is closer to 100!`);
//         } else {
//             alert(`The numbers you've entered are on same distance from 100!`);
//         }
//     } else if (px < 100 && py < 100) {
//         alert(`Your numbers are ${px} and ${py}`);
//         let x1 = 100 - px;
//         let y1 = 100 - py;
//         if (x1 < y1) {
//             alert(`${px} is closer to 100!`);
//         } else if (x1 > y1) {
//             alert(`${py} is closer to 100!`);
//         } else {
//             alert(`The numbers you've entered are on same distance from 100!`);
//         }
//     } else if (px > 100 && py < 100) {
//         alert(`Your numbers are ${px} and ${py}`);
//         let x1 = px - 100;
//         let y1 = 100 - py;
//         if (x1 < y1) {
//             alert(`${px} is closer to 100!`);
//         } else if (x1 > y1) {
//             alert(`${py} is closer to 100!`);
//         } else {
//             alert(`The numbers you've entered are on same distance from 100!`);
//         }
//     } else if (px < 100 && py > 100) {
//         alert(`Your numbers are ${px} and ${py}`);
//         let x1 = 100 - px;
//         let y1 = py - 100;
//         if (x1 < y1) {
//             alert(`${px} is closer to 100!`);
//         } else if (x1 > y1) {
//             alert(`${py} is closer to 100!`);
//         } else {
//             alert(`The numbers you've entered are on same distance from 100!`);
//         }
//     } else if ((px < 0 && py < 0) || (px < 0 && py > 0) || (px > 0 && py < 0)) {
//         alert(`Your numbers are ${px} and ${py}`);
//         let x1 = px - 100;
//         let y1 = py - 100;
//         if (x1 > y1) {
//             alert(`${px} is closer to 100!`);
//         } else if (x1 < y1) {
//             alert(`${py} is closer to 100!`);
//         } else {
//             alert(`The numbers you've entered are on same distance from 100!`);
//         }
//     } else {
//         alert(`Please enter a number.`);
//     }
// } else {
//     alert(`Okay then have a nice day!`);
// }

// // *** Exercise 4: ***

// let enteredNumber = prompt(`Hello, please enter your number!`);
// let smallerThan13 = enteredNumber - 13; 
// let biggerThan13 =  (enteredNumber - 13) * 2;

// if (enteredNumber <= 13)  {
//     alert(`The difference between your ${enteredNumber} and 13 is equal to ${smallerThan13}.`);
// } else if (enteredNumber > 13) {
//     alert(`Your ${enteredNumber} is bigger than 13 so we calculate ${biggerThan13}.`);
// } else {
//     alert(`Please enter a number.`);
// }

// *** Exercise 5: ***

// let num1 = prompt(`Hello,please enter your first number.`);
// let pnum1 = parseInt(num1);
// console.log(num1,pnum1);

// let num2 = prompt(`Hello,please enter your second number.`);
// let pnum2 = parseInt(num2);
// console.log(num2,pnum2);

// let sum = pnum1 + pnum2;
// let subtract = pnum1 - pnum2;
// let multiply = pnum1 * pnum2;

// if ((pnum1 && pnum2) >= 20 && (pnum1 && pnum2) <= 30) {
//     alert(`The sum between entered ${num1} and ${num2} is equal to ${sum}`);
//     console.log(sum);
// } else if ((pnum1 && pnum2) >= 40 && (pnum1 && pnum2) <= 60) {
//     alert(`The difference between entered ${num1} and ${num2} is equal to ${subtract}`);
//     console.log(subtract);
// } else if ((pnum1 && pnum2) >= 80 && (pnum1 && pnum2) <= 100) {
//     alert(`The multiplication between entered ${num1} and ${num2} is equal to ${multiply}`);
//     console.log(multiply);
// } else {
//     alert(`Try again.`);
// }

// // *** Exercise 6: ***

// let grade1 = prompt(`Please enter your first grade.`);
// let pgrade1 = parseInt(grade1);
// console.log(pgrade1);
// let grade2 = prompt(`Please enter your second grade.`);
// let pgrade2 = parseInt(grade2);
// console.log(pgrade2);
// let grade3 = prompt(`Please enter your third grade.`);
// let pgrade3 = parseInt(grade3);
// console.log(pgrade3);
// let grade4 = prompt(`Please enter your fourth grade.`);
// let pgrade4 = parseInt(grade4);
// console.log(pgrade4);
// let grade5 = prompt(`Please enter your fifth grade.`);
// let pgrade5 = parseInt(grade5);
// console.log(pgrade5);

// let gradeToPass = 8;

// let avg = (pgrade1 + pgrade2 + pgrade3 + pgrade4 + pgrade5) / 5;

// if (avg >= gradeToPass ) {
//     alert(`Congratulations! You've passed !`);
//     console.log(`Congratulations! You've passed !`);
// } else if (avg < gradeToPass) {
//     alert(`We wish you more luck next time! You've failed !`);
//     console.log(`We wish you more luck next time! You've failed !`);
// } else {
//     alert (`Enter valid grades!`);
// }

