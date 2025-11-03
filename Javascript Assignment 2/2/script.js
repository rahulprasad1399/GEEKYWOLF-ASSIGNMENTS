document.getElementById("calculate").addEventListener("click", calculateSum)

function calculateSum(){
    let number1 = +document.getElementById("num1").value
    let number2 = +document.getElementById("num2").value

    let sum = number1 + number2

    document.getElementById("output").innerText = sum
}