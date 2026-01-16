const students = [];
function addNewStudent(student) {
    students.push(student);
    console.log(`Adding student: ${student.name}`);
}
function avgGradesOfStudent(student) {
    let sum = 0;
    for (let i = 0; i < student.grades.length; i++) {
        sum += student.grades[i];
    }
    return sum / student.grades.length;
}
function getStudentStatus(avg) {
    if (avg >= 90)
        return "Excellent";
    if (avg >= 70)
        return "Good";
    if (avg >= 50)
        return "Average";
    return "Needs improvement";
}
const student_1 = {
    id: 1,
    name: "mohamed Nasser",
    email: "mo@mail.com",
    isActive: true,
    grades: [90, 60.7],
};
const student_2 = {
    id: 2,
    name: "nasser refaat",
    isActive: true,
    grades: [40, 50, 55],
};
addNewStudent(student_1);
console.log("Average grade:", avgGradesOfStudent(student_1));
console.log("Performance:", getStudentStatus(avgGradesOfStudent(student_1)));
