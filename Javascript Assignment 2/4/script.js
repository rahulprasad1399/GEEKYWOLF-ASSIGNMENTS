let favouriteColor = []

document.getElementById("addcolor").addEventListener("click", ()=>{
    let colorInput = document.getElementById("colorinput").value

    favouriteColor.push(colorInput)
    displayColor()
    colorInput.value = ""
})

function displayColor(){
    let colorlist = document.getElementById("colorlist")
    colorlist.innerHTML = ""

    favouriteColor.forEach((color)=>{
        const li = document.createElement('li')
        li.textContent = color
        colorlist.appendChild(li)
    })
}