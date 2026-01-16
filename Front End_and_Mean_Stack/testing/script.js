////object constructor syntax
// let obj = new Object();
// console.log(obj);

// obj.name = "nasser"; //set
// console.log(obj.name); //get

/****************************************** */
/****************************************** */
/****************************************** */
/****************************************** */

////object literal syntax
// let obj = {};
// console.log(obj);

// obj.name = "nasser";//set
// console.log(obj.name); //get

/****************************************** */
/****************************************** */
/****************************************** */
/****************************************** */

//// Object literal with properties

// let obj = {
//   name: "nasser",
// };
// console.log(obj);
// console.log(obj.name);
// obj.age = 22;
// console.log(obj.age);

/****************************************** */
/****************************************** */
/****************************************** */
/****************************************** */

//// Factory Function
// function createUser(name = "ali", age) {
//   return {
//     name: name,
//     age,
//   };
// }

// let user = createUser("nasser", 65);
// let user2 = createUser("mohamed", 22);
// console.log(user);

/****************************************** */
/****************************************** */
/****************************************** */
/****************************************** */

//// Constructor Function

// function Employee(id, name, salary) {
//   this._salary = salary;
//   this.name = name;
//   this._id = id;

//     // this.employeeInfo = function () {
//     //   console.log(
//     //     `id = ${this._id}, name = ${this.name}, salary = ${salary}`
//     //     // here salary will be print because closure
//     //     // and name , _id will be printed as there is an property inside the object with the same name
//     //   );
//     // };
// }
// let emp1 = new Employee(1, "nasser", 25000);

// emp1.employeeInfo();

// console.log(emp1._salary);

// So the object looks like this in memory:
/*

emp1 = {
  _id: 1,
  name: "nasser",
  _salary: 25000,
  employeeInfo: function() { ... }
}
*/
// sp instead of creating function inside each object we
// can write this function inside the prototype
// in the (O)bject it self

// Employee.prototype.getSalary = function () {
//   return this._salary;
// };
// Employee.prototype.employeeInfo = function () {
//   console.log(
//     `id = ${this._id}, name = ${this.name}, salary = ${this.salary}`
//   );
// };

// emp1.employeeInfo();
// console.log(emp1.getSalary());

/****************************************** */
/****************************************** */
/****************************************** */
/****************************************** */

//// ., subsrcibe, computed notation
// let userProp = prompt("enter prop name");

// let student = {
//   name: "nasser",
//   0: 22,
//   [userProp]: 25,
// };

// console.log(student["0"]);
// console.log(student.name);
// console.log(student[userProp]);

/****************************************** */
/****************************************** */
/****************************************** */
/****************************************** */

//// this keyword

// let person = {
//   name: "hamada",
//   age: 25,
//   printInfo: function () {
//     console.log(this.name, this.age);
//   },
// };

// person.printInfo();

//// the this problem in callbacks

// let person = {
//   Uname: "nasser",
//   age: 25,
//   printInfo: function () {
//     // Problem: 'this' in setTimeout refers to window
//     let _this = this; // capture this in clpsure
//     setTimeout(function () {
//       console.log(_this.age);
//       console.log(_this.Uname);
//     }, 200);
//   },
// };

// person.printInfo();

/****************************************** */
/****************************************** */
/****************************************** */
/****************************************** */

// function test() {
//   console.log(this); //window
// }

// var div = document.querySelector("div");

// div.addEventListener(
//   "mouseenter",
//   function (e) {
//     console.log(this); //div it self
//     console.log(e);
//   },
//   { once: true }
// );
/****************************************** */
/****************************************** */
/****************************************** */
/****************************************** */

const person = {
  name: "Mohammed",
  age: 22,
  job: "Frontend Developer",
};

for (const key in person) {
  const element = person[key];
  if (key === "name") continue;
  console.log(element);
}
