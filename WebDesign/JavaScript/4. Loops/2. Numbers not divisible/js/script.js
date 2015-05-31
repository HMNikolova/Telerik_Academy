/* Problem 2. Numbers not divisible
Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
*/

var numbers = 64, 
    loops,
    result = [],
    i;

loops = numbers + 1;

for (i = 1; i < loops; i += 1) {

    if (!(i % 21)) {
        continue;
    }

   result.push(i);
}

console.log('The numbers from 1 to ' + numbers + ' not divisible by 3 and 7 are ' + result.join(', '));