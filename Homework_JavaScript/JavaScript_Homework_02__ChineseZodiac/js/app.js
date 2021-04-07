// *** HOMEWORK ***

// let chineseZodiac = prompt(`Hello, would you like to know your Chinese zodiac?`);
// if (chineseZodiac === `yes`) {
// let year = prompt(`Please enter your your birth year.`);
// let parsYear = parseInt(year);
// let result = (parsYear - 4) % 12;
//     if (result === 0) {
//         alert(`Your Chinese zodiac is Rat.`);
//     } else if (result === 1) {
//         alert(`Your Chinese zodiac is Ox.`);
//     } else if (result === 2) {
//         alert(`Your Chinese zodiac is Tiger.`);
//     } else if (result === 3) {
//         alert(`Your Chinese zodiac is Rabbit.`);
//     } else if (result === 4) {
//         alert(`Your Chinese zodiac is Dragon.`);
//     } else if (result === 5) {
//         alert(`Your Chinese zodiac is Snake.`);
//     } else if (result === 6) {
//         alert(`Your Chinese zodiac is Horse.`);
//     } else if (result === 7) {
//         alert(`Your Chinese zodiac is Goat.`);
//     } else if (result === 8) {
//         alert(`Your Chinese zodiac is Monkey.`);
//     } else if (result === 9) {
//         alert(`Your Chinese zodiac is Rooster.`);
//     } else if (result === 10) {
//         alert(`Your Chinese zodiac is Dog.`);
//     } else if (result === 11) {
//         alert(`Your Chinese zodiac is Pig.`);
//     } else {
//         alert (`Please enter your birth year`);
//     }
// } else {
//     alert (`Okay have a nice day.Bye bye.`);
// }

// Chinese Zodiac with switch

let year = prompt(`Please enter your your birth year.`);
let parsYear = parseInt(year);
let result = (parsYear - 4) % 12;

switch (result) {
    case 0:
        alert(`Your Chinese zodiac is Rat.`);
        break;

    case 1:
        alert(`Your Chinese zodiac is Ox.`);
        break;
    case 2:
        alert(`Your Chinese zodiac is Tiger.`);
        break;
    case 3:
        alert(`Your Chinese zodiac is Rabbit.`);
        break;
    case 4:
        alert(`Your Chinese zodiac is Dragon.`);
        break;
    case 5:
        alert(`Your Chinese zodiac is Snake.`);
        break;
    case 6:
        alert(`Your Chinese zodiac is Horse.`);
        break;
    case 7:
        alert(`Your Chinese zodiac is Goat.`);
        break;
    case 8:
        alert(`Your Chinese zodiac is Monkey.`);
        break;
    case 9:
        alert(`Your Chinese zodiac is Rooster.`);
        break;
    case 10:
        alert(`Your Chinese zodiac is Dog.`);
        break;
    case 11:
        alert(`Your Chinese zodiac is Pig.`);
        break;
    default:
        alert (`Please enter your birth year`);
        break;
}