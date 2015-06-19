/* Problem 1. Numbers
Write a script that prints all the numbers from 1 to N.
*/

var number = 20, 
    loops,
    result = [],
    i;
debugger;
loops = number + 1;

for (i = 1; i < loops; i += 1) {

    result.push(i);
}

console.log('The numbers from 1 to ' + number + ' are ' + result.join(', '));