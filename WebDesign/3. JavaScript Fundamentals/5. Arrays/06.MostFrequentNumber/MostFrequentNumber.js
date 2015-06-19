/* Problem 6. Most frequent number

Write a script that finds the most frequent number in an array.

Example:
input	                                result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)
*/

var array = [],
    arrLength = 10, // You may edit this number to get larger array of numbers
    counter = 1,
    longestCount = 0,
    number,
    i;

array = randomNumbers(arrLength); // Random generated array of numbers between 0 and 10
console.log('Initial Array is ' + array.join(', '));

array.sort(sortNumbers); // Sorting the array

for (i = 1; i < arrLength; i += 1) {
    
    if (array[i] === array[i - 1]) {
        counter += 1;
        if (counter > longestCount) {
            longestCount = counter;
            number = array[i];
        }
    } else {
        counter = 1;
    }
}

console.log('The most frequent number is ' + number + ' you can find it ' + longestCount + ' times');

function randomNumbers(arrLength) {

    for (i = 0; i < arrLength; i += 1) {

        array.push((Math.random() * 10 + 1) | 0);
    }

    return array;
}

function sortNumbers(a, b) {

    return a - b;
}