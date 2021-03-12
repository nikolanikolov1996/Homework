// [Assignment 01:]
const objectNum01 = {
    a: 1,
    b: 1,
    c: 1
}

const objectNum02 = {
    d: 1,
    e: 1,
    f: 1
}

const objectNum03 = {
    g: 1,
    h: 1,
    i: 1
}

const objectNum04 = {
    j: 1,
    k: 1,
    l: 1
}

const objectNum05 = {
    m: 1,
    n: 1,
    o: 1
}

const objectNum06 = {
    p: 1,
    q: 1,
    r: 1
}

const objectNum07 = {
    s: 1,
    t: 1,
    u: 1
}

const objectNum08 = {
    v: 1,
    w: 1,
    x: 1,
    y: 1,
    z: 1
}

const arrayOfObjects = [objectNum01, objectNum02, objectNum03, objectNum04, objectNum05, objectNum06, objectNum07, objectNum08]
// Merge two objects
mergeTwoObjects = (firstObject, secondObject) => {
    const mergedObject = Object.assign(firstObject, secondObject);
    return mergedObject;
}

let mergedTwoObjects = mergeTwoObjects(objectNum02, objectNum07);
console.log(mergedTwoObjects);

// Merge array of objects
mergeArrayOfObjects = (someArrOfObj) => {
    const mergedObject = Object.assign(...someArrOfObj);
    return mergedObject;
}

let mergedArrayOfObj = mergeArrayOfObjects(arrayOfObjects);
console.log(mergedArrayOfObj);

// [Assignment 02:]
function Address(street, number, city) {
    this.street = street;
    this.number = number;
    this.city = city;
}

function Student(firstName, lastName, street, number, city, currentSubject) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.address = new Address(street, number, city);
    this.currentSubject = currentSubject;
    this.getFullName = function () {
        return console.log(`${firstName} ${lastName}`);
    }
    this.getAddress = function () {
        return console.log(`${city}, ${street} ${number}`);
    }
}

let student1 = new Student('Nikola', 'Nikolov', 'Stiv Naumov', 9, 'Skopje', 'AJS');
console.log(student1);
student1.getFullName();
student1.getAddress();

let student2 = new Student('Kristina', 'Ristovska', 'Mirce Orovcanec', 16, 'Skopje', 'BJS');
console.log(student2);
student2.getFullName();
student2.getAddress();

// [Assignment 03:]
// Input fields
let recipeNameField = document.querySelector('#recipeName');
let recipeIngredientsField = document.querySelector('#recipeIngredients');
let recipeInstructionsField = document.querySelector('#recipeInstructions');

// Result div
let resultDiv = document.querySelector('#resultDiv');

// Buttons
let submitBtn = document.querySelector('#submitBtn');
let displayBtn = document.querySelector('#displayRecipes');

// Data arr
let recipeArray = [];

function Recipe(recipeName, recipeIngredients, recipeInstructions) {
    this.recipeName = recipeName;
    this.recipeIngredients = recipeIngredients;
    this.recipeInstructions = recipeInstructions;
}

clearInputs = (recipeName, recipeIngredients, recipeInstructions) => {
    recipeName.value = "";
    recipeIngredients.value = "";
    recipeInstructions.value = "";
};

checkInputFields = (recipeNameInput, recipeIngredientsInput, recipeInstructionsInput) => {
    if(recipeNameField.value === "" || recipeIngredientsField.value === "" || recipeInstructionsField.value === "") {
        alert('You must fill all inputs in order to continue');
    } else {
        let newRecipe = new Recipe(recipeNameInput, recipeIngredientsInput, recipeInstructionsInput);
        recipeArray.push(newRecipe);
    }
}

displayRecipes = (recipesArr, element) => {
    element.innerHTML = "";
    let card = "";
    if(recipesArr.length === 0) {
        element.style.display = "block";
        let error = `<h1>You dont have any recipes saved!</h1>`;
        element.innerHTML = error;
   
    } else {
        element.style.display = "block";
        recipesArr.forEach(recipe => {
            card += `
            <div class="card text-center mt-2" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">${recipe.recipeName}</h5>
                    <h6 class="card-text">${recipe.recipeIngredients}</h6>
                    <p class="card-text">${recipe.recipeInstructions}</p>
                </div>
            </div>
            `
        })
        element.innerHTML = card;
    }
}

submitBtn.addEventListener('click', function (e) {
    e.preventDefault();
    let recipeNameInput = recipeNameField.value;
    let recipeIngredientsInput = recipeIngredientsField.value.split(",");
    let recipeInstructionsInput = recipeInstructionsField.value;
    checkInputFields(recipeNameInput, recipeIngredientsInput, recipeInstructionsInput);
    console.log(recipeArray);
    clearInputs(recipeNameField, recipeIngredientsField, recipeInstructionsField);
});


displayBtn.addEventListener('click', function() {
    displayRecipes(recipeArray, resultDiv);
});

displayBtn.addEventListener('dblclick', function() {
    resultDiv.style.display = "none";
});