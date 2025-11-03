document.getElementById("checkbutton").addEventListener('click', showInputType)

function showInputType(){
    const input = document.getElementById("userinput").value
    
    let type;

    if(input === "true" || input === "false"){
        type = "Boolean";
    } else if(!isNaN(Number(input))){
        type = "Number"
    } else {
        type = "String"
    }

    document.getElementById("output").innerText = `input : ${input} of type : ${type}`
}



