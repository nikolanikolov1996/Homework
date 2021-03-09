// [Assignment 01]
let tableDiv = document.querySelector('#tableDiv');

getUsers = (url) => {
    return new Promise((resolve, reject) => {
        $.ajax({
            url: url,
            method: 'GET',
            success: (users) => {
                resolve(users);
            },
            error: (error) => {
                reject(error);
            }
        })
    })
}

printData = (data, element) => {
    element.innerHTML = "";
    let myTable = "<table>";
    let myTbody = "<tbody>";
    data.forEach(user => {
        myTbody += `<tr>
                        <td>${user.name}</td>
                        <td>${user.username}</td>
                        <td>${user.email}</td>
                        <td>${user.website}</td>
                        <td>${user.phone}</td>
                    </tr>
        `
    });
    myTable += myTbody;
    element.innerHTML = myTable;
}

printDataBoot = (data, element) => {
    element.innerHTML = "";
    let myTable = `<table class="table table-hover table-dark mt-5">`;
    let myThead = `
                    <thead>
                            <tr>
                                <th scope="col">Name:</th>
                                <th scope="col">Username:</th>
                                <th scope="col">Email:</th>
                                <th scope="col">Website:</th>
                                <th scope="col">Phone:</th>
                            </tr>
                    </thead>
                    `;
    myTable += myThead;
    let myTbody = "<tbody>";
    data.forEach(user => {
        myTbody += `<tr>
                        <td>${user.name}</td>
                        <td>${user.username}</td>
                        <td>${user.email}</td>
                        <td>${user.website}</td>
                        <td>${user.phone}</td>
                    </tr>
        `
    });
    myTable += myTbody;
    element.innerHTML = myTable;
}

checkData = (data) => {
    if (!data || typeof (data) != 'object') {
        throw new Error('There is some problem with the data!')
    }
    if (data.length === 0) {
        throw new Error('There are no documents at all!')
    }
}

// getUsers('https://jsonplaceholder.typicode.com/users')
//     .then(data => {
//         checkData(data)
//         printDataBoot(data, tableDiv);
//     })
//     .catch(error => alert(error));

// [Assignment 02]
let cardDiv = document.querySelector('#cardsDiv');

printDataCards = (data, element) => {
    element.innerHTML = "";
    let card = "";
    data.forEach(user => {
        card += `
        <div class="card text-center mt-2" style="width: 18rem;">
            <div class="card-body">
                <h5 class="card-title">${user.name}</h5>
                <p class="card-text">${user.phone}</p>
            </div>
        </div>
        `
    })
    element.innerHTML = card;
}

async function getDataFetch(url) {
    try {
        let response = await fetch(url);
        if (response.status === 404) {
            throw new Error(`${response.status} PAGE NOT FOUND!`)
        } else {
            let data = await response.json();
            printDataCards(data, cardDiv);
        }
    }
    catch (err) {
        console.log(err.message);
    }
}

// getDataFetch('https://jsonplaceholder.typicode.com/users');

// [Assignment 03]
let fetchBtn = document.querySelector('#fetchData');
let sortAscBtn = document.querySelector('#sortAsc');
let sortDescBtn = document.querySelector('#sortDesc');
let tableDiv2 = document.querySelector('#tableDiv');
let urlSTR = 'https://jsonplaceholder.typicode.com/users';
let initArr = [];

printUserTable = (data, element) => {
    element.innerHTML = "";
    let myTable = `<table class="table table-hover table-dark mt-5">`;
    let myThead = `
                    <thead>
                            <tr>
                                <th scope="col">User ID:</th>
                                <th scope="col">Name:</th>
                                <th scope="col">Username:</th>
                                <th scope="col">Email:</th>
                                <th scope="col">Website:</th>
                                <th scope="col">Phone:</th>
                            </tr>
                    </thead>
                    `;
    myTable += myThead;
    let myTbody = "<tbody>";
    data.forEach(user => {
        myTbody += `<tr>
                        <td>${user.userId}</td>
                        <td>${user.name}</td>
                        <td>${user.username}</td>
                        <td>${user.email}</td>
                        <td>${user.website}</td>
                        <td>${user.phone}</td>
                    </tr>
        `
    });
    myTable += myTbody;
    element.innerHTML = myTable;
}

addUserId = (dataArr) => {
    initArr = dataArr.map((user, userId) => {
        user.userId = userId + 1;
        return user;
    });
    return initArr;
}

sortAsc = (initialArray) => {
    initialArray.sort((firstUser,secondUser) => {
        if(firstUser.userId > secondUser.userId) {
            return 1;
        }
        if(firstUser.userId > secondUser.userId) {
            return -1;
        }
        return 0;
    })
}

sortDesc = (initialArray) => {
    initialArray.sort((firstUser,secondUser) => {
        if(firstUser.userId < secondUser.userId) {
            return 1;
        }
        if(firstUser.userId < secondUser.userId) {
            return -1;
        }
        return 0;
    })
}

async function fetchData(url) {
    let response = await fetch(url);
    let users = await response.json();
    let mappedUsers = addUserId(users);
    
    printUserTable(mappedUsers, tableDiv);
}


fetchBtn.addEventListener('click', function() {
    fetchData(urlSTR);
    
});







sortAscBtn.addEventListener('click', function() {
    sortAsc(initArr);
});

sortDescBtn.addEventListener('click', function() {
    sortDesc(initArr);
});