/* Problem 7. Binary search

Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
*/

var array = [],
    arrLength = 20, // You may edit this number to get larger array of numbers
    lookingFor,
    i;

array = randomNumbers(arrLength); // Random generated numbers between 1 and 100
array.sort(sortNumbers); // Sorting the array in order to perform Binary search
console.log('Initial sorted Array is ' + array.join(', '));

lookingFor = array[Math.random() * arrLength | 0]; // Picking a random position out of the array
console.log('Looking for: ' + lookingFor);

console.log('It\'s at position: '
    + binarySearch(array, lookingFor));

function binarySearch(array, lookingFor) {
    
    var left = 0;
    var right = array.length;

    while (left <= right) {
        
        var middle = (left + right) / 2 | 0;

        if (array[middle] === lookingFor) // check if number is in the middle of the array
        {
            return middle;
        } else if (array[middle] > lookingFor) { // if the number is smaller than array[middle]
            right = middle - 1; // setting to look only in indexes before the middle of the array
        } else {
            left = middle + 1; // otherwise doing the opposite
        }
    }

    return -1;
}

function randomNumbers(arrLength) {

    for (i = 0; i < arrLength; i += 1) {

        array.push((Math.random() * 100 + 1) | 0);
    }

    return array;
}

function sortNumbers(a, b) {

    return a - b;
}