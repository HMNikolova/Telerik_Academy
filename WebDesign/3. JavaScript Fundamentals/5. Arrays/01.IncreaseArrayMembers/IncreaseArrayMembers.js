/* Problem 1. Increase array members

Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
*/

var array = [],
    loops = 20,
    i;

for (i = 0; i < loops; i+=1) {

    array.push(i * 5);
}

console.log('Result is: ' + array.join(', '));