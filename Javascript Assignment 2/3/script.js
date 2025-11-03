let inVisible = true
let message = document.getElementById("message")

document.getElementById("toggleBtn").addEventListener("click", showAndHideMessage)

function showAndHideMessage(){
    inVisible = !inVisible

    if(inVisible){
        message.classList.add("hidden")
    } else {
        message.classList.remove("hidden")
    }
}