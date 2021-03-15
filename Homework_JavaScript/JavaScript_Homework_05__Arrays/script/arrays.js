
// //*** Homework - #1: ***

// let tellStoryPrompt = prompt("Hello, please enter your Name,Mood,Activity in the same order.\n -DO NOT FORGET TO USE COMMAS BETWEEN THEM.").split(",")

// function tellStory([name, mood, activity]) {
//     alert(`My name is ${name}. Today i am ${activity} all day and that makes me ${mood} because it's so fun!`);
// }

// tellStory(tellStoryPrompt);

// //*** Homework - #2: ***

// let userInput = prompt(`Please enter the five numbers you want to sum separated by comma!`);
// console.log(userInput);
// let userInputArr = userInput.split(",").map(x=>+x);
// console.log(userInputArr);

// function sumNum(arr) {
//     let sum = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
//     alert(`${arr[0]} + ${arr[1]} + ${arr[2]} + ${arr[3]} + ${arr[4]} is equal to ${sum}`);
// }

// function valAndSumNum(arr) {
//      if (isNaN(arr[0]) || isNaN(arr[1]) || isNaN(arr[2]) || isNaN(arr[3]) || isNaN(arr[4])) {
//         alert("Error, some of the values you've entered is not a number!");   
//     } else {
//        sumNum(arr); 
//     }
// }

// valAndSumNum(userInputArr);

// Pokratka verzija :

// let userInput = prompt(`Please enter the five numbers you want to sum separated by comma!`);
// console.log(userInput);
// let userInputArr = userInput.split(",").map(x => +x);
// console.log(userInputArr);

// function valAndSumNum(arr) {
//     let sum = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
//     if (isNaN(sum)) {
//         alert("Error, some of the values you've entered is not a number!");
//     } else {
//         alert(`${arr[0]} + ${arr[1]} + ${arr[2]} + ${arr[3]} + ${arr[4]} is equal to ${sum}`);
//     }
// }

// valAndSumNum(userInputArr);

// // *** Homework - #3 ***

// function linkString (arr) {
//     console.log(arr.join(" "));
// }

// linkString(["JavaScript", "best", "programming", "language", "ever", "!"]);

// // *** Homework - #4 ***

// // Function

// function lStructure (fNum, sNum) {
//     let line = "";
//     for (i = fNum; i <= sNum; i++) {
//         if (i % 2 === 0) {
//             line += i + "\n";
//         } else if (i % 2 !== 0) {
//             line += i + " ";
//         }
//     }
//     console.log(line);
// }

// lStructure(1, 1000);

// // While loop
// let string = "";
// let index = 1;
// let endPoint = 20;
// while (index <= endPoint) {
//     if (index % 2 === 0) {
//         string += index + "\n";
//     } else if (index % 2 !== 0) {
//         string += index + " ";
//     }
//     index++;
// }
// console.log(string);

// // For loop
// let string2 = "";
// for (i = 1; i <= 20; i++) {
//     if (i % 2 === 0) {
//         string2 += i + "\n";
//     } else if (i % 2 !== 0) {
//         string2 += i + " ";
//     }
// }
// console.log(string2);

// // *** Homework - #5 ***

// function findMax(arr) {
//     let max = -Infinity;
//     for (i = 0; i < arr.length; i++) {
//         if (arr[i] > max) {
//             max = arr[i];
//         }
//     }
//     console.log(`The max value in the array is ${max}`);
//     return max; 
// }

// function findMin(arr) {
//     let min = +Infinity;
//     for (i = 0; i < arr.length; i++) {
//         if (arr[i] < min) {
//             min = arr[i];
//         }
//     }
//     console.log(`The min value in the array is ${min}`);
//     return min;
// }


// function sumMaxMin(arr) {
//     let max = findMax(arr);
//     let min = findMin(arr);
//     let sum =  max + min;
//     console.log(`Max: ${max}, Min: ${min}, Sum: ${sum}`);
//     return sum;
// }

// sumMaxMin([100,200,300,400,500,600,700,800,900,100]);


// *** Homework - #6 ***

// let firstName = ["Nikola", "Kristina"];
// let lastName = ["Nikolov", "Ristovska"];

// function mergeArray(fArr, sArr) {
//     let mergedArr = [];
//     let listNum = 1;
//     for (let i = 0; i < fArr.length; i++) {
//         for (let j = 0; j < sArr.length; j++) {
//             mergedArr.push(`${listNum}. ${fArr[i]} ${sArr[i]}`);
//             break;
//         }
//         listNum++;
//     }
//     console.log(mergedArr);
// }

// mergeArray(firstName, lastName);


// function mergeArray(fArr, sArr) {
//     i = 0;
//     fArr.forEach((num1, index) => {
//         let num2 = sArr[index];
//         i++;
//         console.log(`${i}.`, num1, num2);
//     });
// }

// mergeArray(firstName, lastName);
