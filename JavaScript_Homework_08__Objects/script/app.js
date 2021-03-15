// // *** Homework PART 1 ***
// let animalForm = document.getElementById('animalForm');
// let result = document.getElementsByTagName('h3')[0];
// let animals = [];


// function Animal(aName, aKind, aWords) {
//     this.animalName = aName;
//     this.animalKind = aKind;
//     this.animalSpeak = printMessage(aName, aKind, aWords, result);
// }

// function clearInputs() {
//     animalForm.children[1].value = "";
//     animalForm.children[3].value = "";
//     animalForm.children[5].value = "";
// }

// function printMessage(name, kind, words, element) {
//     element.innerText += `${name} is an animal from the ${kind}s type and he says: '${words}'`
// }

// animalForm.lastElementChild.addEventListener('click', function (e) {
//     result.innerText = "";
//     e.preventDefault();
//     let animalName = animalForm.children[1].value;
//     let animalKind = animalForm.children[3].value;
//     let animalWords = animalForm.children[5].value;
//     console.log(animalWords);
//     if (animalName === "" || animalKind === "" || animalWords === "") {
//         alert('You must fill up all the fields in order to proceed further!');
//     } else {
//         let newAnimal = new Animal(animalName, animalKind, animalWords);
//         animals.push(newAnimal);
//         console.log(animals);
//         clearInputs();
//     }
// });

// *** Homework PART 2 ***

let bookForm = document.getElementById('bookForm');
let result = document.getElementsByTagName('h3')[0];

function Book(title, author, readingStatus) {
    this.title = title;
    this.author = author;
    this.readingStatus = readingStatus;

    this.infoReadingStatus = function () {
        if (readingStatus === "false") {
            result.innerText = `You still need to read '${title}' by ${author}.`
        } else {
            result.innerText = `Already read '${title}' by ${author}.`
        }
    }
}

let book1 = new Book('The robots of dawn', 'Isaac Asimov', true);
let book2 = new Book('Mockingjay: The Final Book of The Hunger Games', 'Suzanne Collins', false);

let books = [book1, book2];

function clearInputs() {
    bookForm.children[1].value = "";
    bookForm.children[3].value = "";
    bookForm.children[4].value = "0";
}

bookForm.lastElementChild.addEventListener('click', function (e) {
    e.preventDefault();
    let bookTitleValue = document.getElementById('bookTitle').value;
    let bookAuthorValue = document.getElementById('bookAuthor').value;
    let bookStatusValue = document.getElementById('bookStatus').value;
    if (bookTitleValue === "" || bookAuthorValue === "" || bookStatusValue === "0") {
        alert('You must fill up all the fields in order to proceed further!')
    } else {
        let newBook = new Book(bookTitleValue, bookAuthorValue, bookStatusValue);
        books.push(newBook);
        newBook.infoReadingStatus();
        console.log(books);
        clearInputs();
    }
});

