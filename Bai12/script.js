function send() {
    let txtMessage = document.getElementById('txtMessage').value;
    if (txtMessage == '') {
        alert("Them du lieu vao");
        return false;
    }

    return true;
}