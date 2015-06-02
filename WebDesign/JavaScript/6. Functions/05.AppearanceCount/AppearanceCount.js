/* Problem 5. Appearance count

Write a function that counts how many times given number appears in given array.
Write a test function to check if the function is working correctly.
*/
var i,
    loops = 20;

testTask(loops);

function testTask(loops) {

    var array = randomNumbers(loops), // Random generated array with numbers between 1 and 5
        number = array[Math.random() * loops | 0]; // Picking a random position out of the array
    
    console.log('Initial array is: ' + array.join(', '));
    console.log('You can find the number ' + number + ' in this array ' + findOccurrence(array, number) + ' times');
}

function findOccurrence (array, number) {

    var counter = 0,
        loops = array.length;
        

    for (i = 0; i < loops; i += 1) {

        if (array[i] === number) {
            counter += 1;
        }
    }

    return counter;
}

function randomNumbers(loops) {    
    
    var array = [];

    for (i = 0; i < loops; i += 1) {

        array.push((Math.random() * 5 + 1 ) | 0);
    }

    return array;
}