const student = {
    name : "Harry",
    age : "16",
    grade : "A"
}

document.getElementById("showinfo").addEventListener("click", ()=>{
    const studentinfo = document.getElementById("studentinfo")

    studentinfo.innerHTML = `
        <p>Name : ${student.name}</p>
        <p>Age : ${student.age}</p>
        <p>Grade : ${student.grade}</p>
    `
})