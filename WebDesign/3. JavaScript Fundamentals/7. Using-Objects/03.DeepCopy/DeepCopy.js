/* Problem 3. Deep copy

Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types.
*/

var objOne,
    objTwo = { name: 'Alex', age: 21 };

function deepCopy(obj) {

    var result = {},
        property;

    if (typeof obj !== 'object') {

        return obj;
    }

    for (property in obj) {
        result[property] = deepCopy(obj[property]);
    }

    return result;
}

objOne = objTwo; // assign the value of objTwo to the first object

console.log('Initial objects are ' + JSON.stringify(objOne) + ' and ' + JSON.stringify(objTwo));

objTwo.name = 'Sam'; // than changing the name of the second object to Sam 
console.log('Changed second object name to Sam');
console.log('Print object One name (is it Alex?) NO it\'s ' + objOne.name); // but this changes the name of the first object as well!

objOne = deepCopy(objTwo); // the deepCopy will fix this problem
objTwo.name = 'Alexis'; // setting the name to the second object
console.log('Changed second object name to Alexis');
console.log('Oooh object Name is "Alexis"? NO it remains: ' + objOne.name); // now the name of the first object remains intact
console.log('Only the name of the second object is changed to ' + objTwo.name);
