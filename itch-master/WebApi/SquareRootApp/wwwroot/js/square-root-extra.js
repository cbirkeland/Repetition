
let errorMessage = "";
let result = "";

function render() {
    document.getElementById("error").innerText = errorMessage;
    document.getElementById("result").innerText = result;
}

function isInteger(x) {

    return x == parseInt(x);
}
async function squareRoot() {
    errorMessage = "";
    result = "";

    let number = document.getElementById("number").value;
    let nrOfDigits = document.getElementById("nrOfDigits").value;
    let validateOnClientIsChecked = document.getElementById("validateOnClient").checked;

    if (validateOnClientIsChecked) {

        if (!isInteger(number))
            errorMessage = "Client: Enter a number";
        else if (!isInteger(nrOfDigits)) 
            errorMessage = "Client: Enter number of digits";
        else if (nrOfDigits < 0)
            errorMessage = "Client: Number of digits must be greater than 0";
        else if (number < 0) 
            errorMessage = "Client: Can't square root negative numbers";

        if (errorMessage) {
            render();
            return;
        }
    }

    let url = `api/squarerootextra?number=${number}&nrOfDigits=${nrOfDigits}`;

    let response = await fetch(url);

    if (response.status === 200) {

        result = await response.json();
        errorMessage = "";

    }  else if (response.status === 400) {

        result = "";
        errorMessage = await response.text();

    } else {
        result = "";
        errorMessage = `Unexpected(status code = ${ response.status })`;
    }
    render();

}
