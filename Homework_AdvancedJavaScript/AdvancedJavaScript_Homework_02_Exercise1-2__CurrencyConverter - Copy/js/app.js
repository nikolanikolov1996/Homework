// [EXERCISES 01:]
let someArr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]

const sumArrNumbers = (array) => {
    let result = 0;
    for (const item of array) {
        result += item;
    }
    return result;
}
console.log(sumArrNumbers(someArr));

// [EXERCISES 02:]
let getAlbums = document.querySelector('#getAlbums');
let resultDiv = document.querySelector('#resultDiv');

displayInTable = (response, element) => {
    element.innerHTML = "";
    let myTable = '<table>';
    let myTBody = '<tbody>';
    for (const album of response) {
        myTBody += `<tr>
            <td>UserId: </td><td> ${album.userId}</td>
            <td>ID: </td><td>${album.id}</td>
            <td>Homeworld: </td><td>${album.title}</td>
        </tr>`;
    }
    myTBody += '</tbody>';
    myTable += myTBody;
    element.innerHTML = myTable;
}

getAlbums.addEventListener('click', function () {
    console.log('Downloading albums from API');
    fetch('https://jsonplaceholder.typicode.com/albums')
        .then(resp => {
            if (resp.ok) {
                return resp.json();
            } else if (resp.status === 404) {
                return Promise.reject('ERROR 404! Page not found!!!');
            } else {
                return Promise.reject('There was some error! ' + resp.status)
            }
        })
        .then(albums => {
            console.log(albums);
            displayInTable(albums, resultDiv);
        })
        .catch(err => console.log(err));
});