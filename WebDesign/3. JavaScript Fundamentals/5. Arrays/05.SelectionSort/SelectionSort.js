/* Problem 5. Selection sort

Sorting an array means to arrange its elements in increasing order.
Write a script to sort an array.
Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/

var array = [],
    arrLength = 10, // You may edit this number to get larger array of numbers
    temp,
    i,
    j;

array = randomNumbers(arrLength); // Random generated array of numbers between -50 and 50

console.log('Initial Array is ' + array.join(', '));

for (i = 0; i < arrLength; i += 1) {

    for (j = i + 1; j < arrLength; j += 1) {

        if (array[i] > array[j]) // swap items
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

console.log('Sorted Array is ' + array.join(', '));

function randomNumbers(arrLength) {

    for (i = 0; i < arrLength; i += 1) {

        array.push((Math.random() * ((i % 5 === 0) ? -50 : 50)) | 0);
    }

    return array;
}