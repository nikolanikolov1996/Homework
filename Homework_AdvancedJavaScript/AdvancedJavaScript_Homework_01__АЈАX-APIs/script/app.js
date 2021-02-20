// [***HOMEWORK***]

// [Task 01]

let btnGetPeople = document.querySelector('#btnGetPeople');
let resultDiv = document.querySelector('#resultDiv');

function printIntoTable(response, element) {
    element.innerHTML = "";
    let myTable = '<table>';
    let myTBody = '<tbody>';
    for (const person of response.results) {
        myTBody += `<tr>
            <td>Name: ${person.name}</td>
            <td>Gender: ${person.gender}</td>
            <td>Homeworld: ${person.homeworld}</td>
            <td>Height: ${person.height}</td>
            <td>Hair color: ${person.hair_color}</td>
        </tr>`;
    }
    myTBody += '</tbody>';
    myTable += myTBody;
    element.innerHTML = myTable;
}

btnGetPeople.addEventListener('click', function () {
    console.log('Getting data from API, please wait...');
    $.ajax({
        url: 'https://swapi.dev/api/people/',
        method: 'GET',
        success: function (response) {
            console.log(response);
            let people = response;
            printIntoTable(people, resultDiv);
        },
        error: function (error) {
            if (error.status === 404) {
                console.log('ERROR 404! PAGE NOT FOUND!');
            } else {
                console.log('Oopss! Something went wrong!');
            }
        }
    });
});

// // [Task 02]

// let btnGetInfo = document.querySelector('#btnGetInfo');
// let resultDiv = document.querySelector('#resultDiv');

// function displayInTable(stats, element) {
//     element.innerHTML = "";
//     let myTable = '<table>';
//     let myTBody = '<tbody>';
//         myTBody += `<tr>
//             <td>Country:  ${stats.country}</td>
//             <td>Cases:  ${stats.cases}</td>
//             <td>Active cases:  ${stats.active}</td>
//             <td>Recovered cases:  ${stats.recovered}</td>
//             <td>Deaths:  ${stats.deaths}</td>
//             <td>Today cases:  ${stats.todayCases}</td>
//             <td>Today deaths:  ${stats.todayDeaths}</td>
//         </tr>`;
//     myTBody += '</tbody>';
//     myTable += myTBody;
//     element.innerHTML = myTable;
// }

// btnGetInfo.addEventListener('click', function () {
//     console.log('Getting data from API, please wait...');
//     fetch('https://coronavirus-19-api.herokuapp.com/countries/North%20Macedona')
//     .then(resp => {
//         if(resp.ok) {
//             return resp.json();
//         } else if(resp.status === 404) {
//             return Promise.reject('ERROR 404! Page not found!!!');
//         } else {
//             return Promise.reject('There was some error! ' + resp.statusText);
//         }
//     })
//     .then(info => {
//         console.log(info);
//         displayInTable(info, resultDiv);
//     })
//     .catch(error => {
//         alert('Something went wrong! Please try again! ' + error)
//     })
// });