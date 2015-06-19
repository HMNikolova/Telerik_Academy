/* Problem 1. Exchange if greater
Write an if statement that takes two double variables a and b and exchanges their values 
if the first one is greater than the second.
As a result print the values a and b, separated by a space.
Examples:
a   b   result
5   2   2 5
3   4   3 4
5.5 4.5 4.5 5.5
*/

//Feel free to add or remove numbers, but there must be an equal number of numbers in first and second
var first = [5, 3, 5.5],
    second = [2, 4, 4.5],
    loops = first.length,
    temp,
    i;

for (i = 0; i < loops; i += 1) {

    console.log('Initial numbers are ' + first[i] + ' and ' + second[i]);

    if (second[i] > first[i]) {
        temp = second[i];
        second[i] = first[i];
        first[i] = temp;
    }

    console.log('Larger number is ' + first[i] + ' and smaller number is ' + second[i]);
}