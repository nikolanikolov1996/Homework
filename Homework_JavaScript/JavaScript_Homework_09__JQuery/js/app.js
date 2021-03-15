// HOMEWORK PART 1
// let printBtn = $("#printBtn");
// let resultDiv = $("#resultDiv");

// function printMsg(msg) {
//     return `<h1>Hello there ${msg}! We wish you all the best ${msg}!</h1>`;
// }

// function checkProceedInput(input) {
//     if(input === "") {
//         resultDiv.html('<h1>You must enter your name in the input field in order to proceed further!</h1>')
//          .css('color', 'red');
//     } else if(input.length > 5) {
//         resultDiv.html(printMsg(input)).css('color', 'blue');
//     } else  {
//         resultDiv.html(printMsg(input)).css('color', 'green');
//     }
// }

// function clearInput(id) {
//     $(id).val("");
// }

// printBtn.click(function() {
//     let inputValue = $("#nameInput").val();
//     checkProceedInput(inputValue);
//     clearInput('#nameInput');
// })

// HOMEWORK PART 2
let generateBtn = $("#generateBtn");
let resultDiv = $("#resultDiv");
let errorDiv = $("#errorDiv");

function checkColor(color) {
    let check = new Option().style;
    check.color = color;
    return check.color === color;
};

function validateAndProceed(textInput, colorInput) {
    if (textInput === "" || colorInput === "") {
        errorDiv.html('<h3>Both input fields must be filled in order to proceed!!!</h3>')
            .css('color', 'violet');
    } else if (!checkColor(colorInput)) {
        errorDiv.html('<h3>INVALID COLOR! You must enter a valid color in the input field!!!</h3>')
            .css('color', 'red');
    } else {
        resultDiv.html(`<h1>${textInput}</h1>`).css('color', colorInput);
    }
};

function clearInput(idOne, idTwo) {
    $(idOne).val("");
    $(idTwo).val("");
}

generateBtn.click(function () {
    let textValue = $('#textInput').val();
    let colorValue = $('#colorInput').val();
    validateAndProceed(textValue, colorValue);
    clearInput('#textInput', '#colorInput');
});
