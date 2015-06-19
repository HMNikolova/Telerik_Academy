/* Problem 3. Maximal sequence

Write a script that finds the maximal sequence of equal elements in an array.

Example:
input	                        result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1    2, 2, 2
*/
var array = [],
    arrLength = 15, // You may edit this number to get larger array of numbers
    counter = 1,
    longestSequence = 1,
    value,
    resultSequence = [],
    i;

array = randomNumbers(arrLength); // Random generated array of numbers between 1 and 3

console.log('Initial Array is ' + array.join(', '));

for (i = 1; i < arrLength; i += 1) {

    if (array[i] === array[i - 1]) {
        counter += 1;
        if (longestSequence < counter) {
            longestSequence = counter;
            value = array[i];
        }
    } else {
        counter = 1;
    }
}

for (i = 0; i < longestSequence; i += 1) {
    resultSequence.push(value);
}

console.log('The longest sequence is of ' + longestSequence + ' elements: ' + resultSequence.join(', '));

function randomNumbers(arrLength) {

    for (i = 0; i < arrLength; i += 1) {

        array.push((Math.random() * 3 + 1) | 0);
    }

    return array;
}