// *** Homework ***
let generateBtn = document.getElementById('generateBtn');

function generateTable(row, col) {
    let body = document.getElementsByTagName("body")[0];
    let tbl = document.createElement("table");
    let tblBody = document.createElement("tbody");
    for (let i = 1; i <= row; i++) {
        let createRow = document.createElement("tr");
        for (let j = 1; j <= col; j++) {
            let createCell = document.createElement("td");
            let cellText = document.createTextNode("Row " + i + ", Column " + j);
            createCell.appendChild(cellText);
            createRow.appendChild(createCell);
        }
        tblBody.appendChild(createRow);
    }
    tbl.appendChild(tblBody);
    body.appendChild(tbl);
    tbl.setAttribute("border", "1");
}

generateBtn.addEventListener('click', function () {
    let rowInput = document.getElementById('row-input').value;
    let colInput = document.getElementById('col-input').value;
    if ((rowInput === "" || colInput === "") || (rowInput < 0 || colInput < 0)) {
        alert("Please enter a positive number in the input fields!");
    } else {
        generateTable(rowInput, colInput);
    }
});
