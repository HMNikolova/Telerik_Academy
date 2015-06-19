/* Problem 3. Min/Max of sequence
Write a script that finds the max and min number from a sequence of numbers.
*/

var array = [],
    loops = 10, 
    min,
    max,
    i;

array = randomNumbers(loops);
min = array[0];
max = array[0];

for (i = 0; i < loops; i+=1) {

    if (min > array[i]) {
        min = array[i];
    }
    if (max < array[i]) {
        max = array[i];
    }
}

console.log('From the array of ' + array.join(', '));
console.log('The min number is ' + min + ' and the max number is ' + max);

function randomNumbers(loops) {

    for (i = 0; i < loops; i += 1) {

        array.push((Math.random() * ((i % 2) ? -100 : 100)) | 0);
    }

    return array;
}

