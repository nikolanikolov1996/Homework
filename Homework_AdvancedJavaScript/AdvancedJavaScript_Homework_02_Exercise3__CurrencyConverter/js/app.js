// [Exercise 03:]
let convertBtn = document.querySelector('#convertBtn');
let resultDiv = document.querySelector('#resultDiv');

convertMoney = (element, amount, fromValue, toValue) => {
    let conversionRateEurDol = 1.21;
    let conversionRateEurMkd = 61.94;
    let conversionRateDolMkd = 50.76;
    element.innerHTML = "";
    let header5 = "";
    if (amount === "") {
        header5 += `<h5>Amount field is empty!</h5>`;
    } else if (fromValue === '0' && toValue === '1') {
        const result = parseInt(amount) * conversionRateEurDol;
        header5 += `<h5>${amount} euros is equal to ${result} dollars</h5>`;
    } else if (fromValue === '0' && toValue === '2') {
        const result = parseInt(amount) * conversionRateEurMkd;
        header5 += `<h5>${amount} euros is equal to ${result} denars</h5>`;
    } else if (fromValue === '1' && toValue === '0') {
        const result = parseInt(amount) / conversionRateEurDol;
        header5 += `<h5>${amount} dolars is equal to ${result} euros</h5>`;
    } else if (fromValue === '1' && toValue === '2') {
        const result = parseInt(amount) * conversionRateDolMkd;
        header5 += `<h5>${amount} dolars is equal to ${result} denars</h5>`;
    } else if (fromValue === '2' && toValue === '0') {
        const result = parseInt(amount) / conversionRateEurMkd;
        header5 += `<h5>${amount} denars is equal to ${result} euros</h5>`;
    } else if (fromValue === '2' && toValue === '1') {
        const result = parseInt(amount) / conversionRateDolMkd;
        header5 += `<h5>${amount} denars is equal to ${result} dolars</h5>`;
    } else if (fromValue === toValue) {
        header5 += `<h5>You cant convert the same currency!</h5>`;
    } else {
        alert('Something went wrong. Please try again!');
    }
    element.innerHTML = header5;
}

convertBtn.addEventListener('click', function () {
    let amountInput = document.querySelector('#amountInput').value;
    let fromInput = document.querySelector('#fromInputCurr').value;
    let toInput = document.querySelector('#toInputCurr').value;
    convertMoney(resultDiv, amountInput, fromInput, toInput);
});
