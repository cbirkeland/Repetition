async function addNews() {

    let response = await fetch("api/News", {
        method: "POST",
        body: JSON.stringify({
                header: byId("addFormHeader").value,
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (response.status === 200) {
        let id = await response.json();
        console.log(`News with id = ${id} added`);

    } else {
        console.log("Unexpected error", response);
    }

}

async function recreate() {
    // fetch "api/News/Recreate" med POST

    // kolla statuskod

}
function byId(id) {
    return document.getElementById(id);
}