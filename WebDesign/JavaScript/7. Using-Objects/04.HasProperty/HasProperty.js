/* 
 * Problem 4. Has property

Write a function that checks if a given object contains a given property.

var obj  = …;
var hasProp = hasProperty(obj, 'length');
 */
var property,
    objJohn = {
    name: 'John',
    age: 25
};

function hasProperty(obj, property) {

    if (typeof obj === 'object' && typeof property === 'string') {
        return obj.hasOwnProperty(property);
    }
    
}

property = 'job';

console.log('Does object ' + JSON.stringify(objJohn) + ' has a property ' + property + '? -> ' + hasProperty(objJohn, property));