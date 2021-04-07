// Classwork

let feet = 5;
let conversionRate = 0.3048;
let meter = 5;

let feetToMeter = feet * conversionRate;
let meterToFeet = meter / conversionRate;

console.log("Feet to Meter",feetToMeter);
console.log("Meter to Feet",meterToFeet);


// Task 01

let rectangleFirstSide = 5;
let rectangleSecondSide = 15;

let rectangleArea = rectangleFirstSide * rectangleSecondSide;

console.log("Rectangle Area",rectangleArea);


// Task 02

let pi = 3.14;
let circleRadius = 7;

let squareCircleRadius = circleRadius * circleRadius;
let circleArea = pi * squareCircleRadius;

console.log("Circle Area",circleArea);

// Homework 01

let priceOfOnePhone = 119.95;
let taxRate = 0.05;
let quantity = 30;

let taxOfOnePhone = priceOfOnePhone * taxRate;
let totalPriceOfOnePhone = priceOfOnePhone += taxOfOnePhone;
let totalRequiredPrice = totalPriceOfOnePhone * quantity;

console.log("Total Required Price",totalRequiredPrice)