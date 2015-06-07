/* Problem 1. Make person

Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders
*/

var persons = [
    new Person('Kim', 'Valencia', 25, 'male'),
    new Person('Charlotte', 'Le Bonne', 29, 'female'),
    new Person('James', 'Tomkins', 15, 'male'),
    new Person('Helen', 'Owen', 17, 'female'),
    new Person('Kevin', 'Nolan', 32, 'male'),
    new Person('Audrey', 'Tautou', 39, 'female'),
    new Person('Jerard', 'Pique', 21, 'male'),
    new Person('Penelope', 'Cruz', 41, 'female'),
    new Person('Jean', 'Dujardin', 42, 'male'),
    new Person('Keira', 'Knightley', 29, 'female')
];

console.log('Task 01: list of 10 persons:');

persons.forEach(function (item, index) {
    console.log('Index' + index + ' ' + JSON.stringify(item));
});

function Person(firstName, lastName, age, gender) {

    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}

console.log(new Array(31).join('-'));

/* Problem 2. People of age

Write a function that checks if an array of person contains only people of age (with age 18 or greater)
Use only array methods and no regular loops (for, while)
*/
console.log('Task 02:');

var isAllAdult = persons.every(function (item) {

    return item.age >= 18;
});

console.log('Is everyone over 18 years old? ' + isAllAdult);

var isAllUnder50 = persons.every(function (item) {

    return item.age < 50;
});

console.log('Is everyone under 50 years old? ' + isAllUnder50);

console.log(new Array(31).join('-'));

/* Problem 3. Underage people

Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while)
*/

console.log('Task 03: All persons under 18');

var allUnderage = persons.filter(function (item) {

    return item.age < 18;
});

allUnderage.forEach(function (item) {
    console.log(JSON.stringify(item));
});

allUnderage = [];

allUnderage = persons.filter(function (item) {

    return item.age > 18 && item.age < 30 && item.gender === 'male';
});

console.log('Bonus: Everyone who is aged between 18 and 30 and is male:');

allUnderage.forEach(function (item) {
    console.log(JSON.stringify(item));
});

console.log(new Array(31).join('-'));

/* Problem 4. Average age of females

Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
Use only array methods and no regular loops (for, while)
*/

var allWomen = persons.filter(function (item) {

    if (item.gender === 'female') {
        return item.age;
    }
});

var sumAge = allWomen.reduce(function (sumAge, person) {
    return sumAge + person.age;
}, 0);

console.log('Task 04: The average age of all Women is ' + (sumAge / allWomen.length).toFixed(2) + ' years old');

console.log(new Array(31).join('-'));

/*Problem 5. Youngest person

Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
Use Array#find
*/

console.log('Task 05: Youngest person is:');

persons.sort(function (first, second) { // Please note that the method sort changes the original array!

    return first.age - second.age;
});

// If it is not predifined you may get: Uncaught TypeError: persons.find is not a function
if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}

var youngestPerson = persons.find(function (item) {

    if (item !== undefined) {
        return item; // In a sorted array by age the very first element will do the job
    }
});

console.log(JSON.stringify(youngestPerson));

console.log(new Array(31).join('-'));

/* Problem 6. Group people

Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
Use Array#reduce
Use only array methods and no regular loops (for, while)
*/

var sorted = persons.reduce(function (obj, item) {

    if (obj[item.firstName[0]]) {
        obj[item.firstName[0]].push(item);
    } else {
        obj[item.firstName[0]] = [item];
    }
    return obj;
}, {});

console.log('Task 06:' + JSON.stringify(sorted));
