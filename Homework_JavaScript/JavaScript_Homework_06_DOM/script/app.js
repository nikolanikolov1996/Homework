// *** Homework Part 1 ***

// let headerInFirstDiv = document.getElementById('myTitle');
// let paragraphInFirstDiv = document.getElementsByClassName('paragraph')[0];
// let paragraphInSecondDiv = document.getElementsByClassName('paragraph')[1];
// let textInSecondDiv = document.querySelector('text')
// let headerInThirdDiv = document.getElementsByTagName('h1')[1];
// let header3InThirdDiv = headerInThirdDiv.nextElementSibling;

// headerInFirstDiv.innerText = "";
// headerInFirstDiv.innerText = "This text was added through JavaScript innerText";
// paragraphInFirstDiv.innerText = "";
// paragraphInFirstDiv.innerText = "This is very easy exercise! And this exercise was also changed through JS!";
// paragraphInSecondDiv.innerText = "";
// paragraphInSecondDiv.innerText = "YES YES , its really very very easy!";
// textInSecondDiv.innerText += " changing the elements text by using innerText";
// headerInThirdDiv.innerText = "";
// headerInThirdDiv.innerText = "My homework exercise was to change this header text content! ";
// header3InThirdDiv.innerText = "";
// header3InThirdDiv.innerText = "SORRY H1!"

// // *** Homework Part 2 ***

// let numArr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// let myDiv = document.getElementById('myDiv');

// function printNumbers(arr) {
//     myDiv.innerHTML = "";
//     myDiv.innerHTML += '<ul>';
//     for (i = 0; i < arr.length; i++) {
//         myDiv.innerHTML += `<li>${arr[i]}</li>`;
//     }
//     myDiv.innerHTML += '</ul>';
// }

// // function sumArray(arr) {
// //     let sum = 0;
// //     for (i = 0; i < arr.length; i++) {
// //         sum += arr[i];
// //     }
// //     myDiv.innerHTML += `<h3>${sum}</h3>`;
// // }

// function printSumOfArray(arr) {
//     let sum = 0;
//     myDiv.innerHTML += '<p>';
//     for (i = 0; i < arr.length; i++) {
//         sum += arr[i]
//         if (arr[i] !== arr.length) {
//             myDiv.innerHTML += `${arr[i]} + `
//         } else {
//             myDiv.innerHTML += `${arr[i]} = ${sum}`
//         }
//     }
//     myDiv.innerHTML += '</p>';
// }
// printNumbers(numArr);

// // sumArray(numArr);

// printSumOfArray(numArr);

// *** BONUS HOMEWORK ***

let inputRecipeName = prompt('Hello, please enter your recipe name.')
let inputIngredientsNum = prompt('Please enter how many ingredients do you need for the recipe.')
let inputIngredientName = prompt('Please enter the name of every ingredient you need for the recipe SEPARATED with commas.').split(",");
let myDiv = document.getElementById('myDiv');
let recipeTable = document.getElementById('recipeTable');

function printRecipeName (input) {
    myDiv.innerHTML += `<h1>${input}</h1>`
}

function printIngredientNum (input) {
    myDiv.innerHTML += `<h2>For this recipe we need ${input} ingredients.</h2>`;
}

function printIngredientsList (input) {
    myDiv.innerHTML += `<ul>`;
    for(i = 0; i < input.length; i++) {
        myDiv.innerHTML += `<li>${input[i]}</li>`
    }
    myDiv.innerHTML += `</ul>`;
}
function printIngredientsListTable (input) {
    recipeTable.innerHTML += '<tbody>';
    for(i = 0; i < input.length; i++) {
        recipeTable.innerHTML += `<tr><td>${input[i]}</td></tr>`;
    }
    recipeTable.innerHTML += '</tbody>';
}

printRecipeName(inputRecipeName);
printIngredientNum(inputIngredientsNum);
printIngredientsListTable(inputIngredientName);
