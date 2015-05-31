/* Problem 1. JavaScript literals
    Assign all the possible JavaScript literals to different variables.
 */

var numInt = 5;

console.log('The number is -> ' + numInt);

var str = '"Some text"';

console.log('The string is -> ' + str);

var boolean = true;

console.log('The bool is -> ' + boolean);

var obj = {
    name: 'John',
    age: 21
};

console.log('The object is -> ' + JSON.stringify(obj));

/* Problem 2. Quoted text
 Create a string variable with quoted text in it.
 For example: 'How you doin'?', Joey said'.
 */

var task2String = '"How you doin\'?", Joey said.';

console.log('Task 2 string is -> ' + task2String);

/* Problem 3. Typeof variables
   Try typeof on all variables you created.
 */
var allVariables = [numInt, str, boolean, obj];
var arrLength = allVariables.length;

for (var i = 0; i < arrLength; i += 1) {

    if (allVariables[i] === obj) {
        console.log('Type of ' + JSON.stringify(obj) + ' is -> ' + typeof allVariables[i]);
        continue;
    }
    console.log('Type of ' + allVariables[i] + ' is -> ' + typeof allVariables[i]);

}

/* Problem 4. Typeof null
    Create null, undefined variables and try typeof on them.
 */

var nullValue = null;

console.log('Type of null is -> ' + typeof nullValue);

var undefinedValue = undefined;

console.log('Type of undefined is -> ' + typeof undefinedValue);