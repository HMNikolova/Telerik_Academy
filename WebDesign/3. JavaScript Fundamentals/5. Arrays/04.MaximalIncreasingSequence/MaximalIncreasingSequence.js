/* Problem 4. Maximal increasing sequence

Write a script that finds the maximal increasing sequence in an array.

Example:
input	                result
3, 2, 3, 4, 2, 2, 4	    2, 3, 4
*/

var array = [],
    arrLength = 15, // You may edit this number to get larger array of numbers
    counter = 1,
    longestSequence = 0,
    lastIndex,
    finalResult = [],
    i;

array = randomNumbers(arrLength); // Random generated array of numbers between 1 and 10

console.log('Initial Array is ' + array.join(', '));

for (i = 1; i < arrLength; i += 1) {

    if (array[i] > array[i - 1]) {

        counter += 1;
        if (counter > longestSequence) {
            longestSequence = counter;
            lastIndex = i;
        }
    } else {
        counter = 1;
    }
}

for (i = lastIndex - longestSequence + 1; i <= lastIndex; i += 1) {

    finalResult.push(array[i]);
}

console.log('The longest increasing sequence is of ' + longestSequence + ' elements: '
    + finalResult.join(', '));

function randomNumbers(arrLength) {

    for (i = 0; i < arrLength; i += 1) {

        array.push((Math.random() * 10 + 1) | 0);
    }

    return array;
}