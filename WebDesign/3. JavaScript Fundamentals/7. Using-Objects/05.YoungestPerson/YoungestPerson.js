/* Problem 5. Youngest person

Write a function that finds the youngest person in a given array of people and prints his/hers full name
Each person has properties firstname, lastname and age.

Example:

var people = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
*/

var p1,
    p2,
    p3,
    p4,
    p5,
    length,
    people = [];

p1 = new Person('Mike', 'Johnson', 25);
p2 = new Person('Maria', 'Lamar', 20);
p3 = new Person('Will', 'Smith', 29);
p4 = new Person('Sam', 'Fox', 18);
p5 = new Person('Samanta', 'Baker', 17);

people = [p1, p2, p3, p4, p5];

console.log('Youngest person is ' + JSON.stringify(findYoungestPerson(people)));

function Person(fname, lname, age) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
}

function findYoungestPerson(array) {

    var youngestIndex = 0,
        length = array.length,
        i;

    for (i = 1; i < length; i += 1) {

        if (array[i].hasOwnProperty('age')) {
            if (array[i].age < array[youngestIndex].age) {
                youngestIndex = i;
            }
        }

    }

    return array[youngestIndex];
}
