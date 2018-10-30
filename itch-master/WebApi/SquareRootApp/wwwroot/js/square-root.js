
let errorMessage = "";
let result = "";

function render() {
    document.getElementById("error").innerText = errorMessage;
    document.getElementById("result").innerText = result;
}

async function squareRoot() {

    let number = document.getElementById("number").value;

    let response = await fetch(`api/squareroot?number=${number}`);

    if (response.status === 200) {

        result = await response.json();
        errorMessage = "";

    }  else if (response.status === 400) {

        result = "";
        errorMessage = await response.text();

    } else {
        result = "";
        errorMessage = `Unexpected (status code=${response.status})`;
    }
    render();

}
