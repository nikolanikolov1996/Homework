// Exercise 1

let namesArray = ["Bill", "Ana", "Josephine", "Elena"];
let namesLengthArray = [];

function mapToArrayElementsLength(arr) {
    for (i = 0; i < arr.length; i++) {
        namesLengthArray.push(arr[i]);
    }
}

mapToArrayElementsLength(namesArray);
console.log(namesLengthArray);

// Exercise 2 

let num = 100;

function getDividableNumbers(num) {
    let arr = [];
    for (i = 1; i <= num; i++) {
        if (i % 7 === 0 && i % 3 === 0) {
            arr.push(i);
        }
    }
    console.log(arr);
}

getDividableNumbers(10000);

// Exercise 3

let firstName = document.getElementById("fname");
let lastName = document.getElementById("lname");
let phoneNum = document.getElementById("phone");
let saveBtn = document.getElementById("saveBtn");

let contacts = [];

function Contact(fName, lName, phoneNum) {
    this.firstName = fName,
    this.lastName = lName,
    this.phoneNum = phoneNum
}

saveBtn.addEventListener("click", function () {
    let tbody = document.getElementById('tbody');
    let contact = new Contact(firstName.value, lastName.value, phoneNum.value);
    contacts.push(contact);
    addNewContact(contacts, tbody);
    console.log(contacts);
    clearForm();
    return false;
});

function displayContacts(contacts) {
    for(let contact of contacts){
        console.log(contact);
    }
}

function addNewContact(contacts, element) {
    element.innerHTML = "";
    for (let contact of contacts) {
        element.innerHTML +=
            `<tr>
            <td>${contact.firstName}</td>
            <td>${contact.lastName}</td>
            <td>${contact.phoneNum}</td>
        </tr>
        `
    }
}

function clearForm() {
    firstName.value = "";
    lastName.value = "";
    phoneNum.value = "";
}