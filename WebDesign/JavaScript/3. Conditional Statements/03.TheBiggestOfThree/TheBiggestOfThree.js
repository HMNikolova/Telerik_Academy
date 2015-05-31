/* Problem 3. The biggest of Three
Write a script that finds the biggest of three numbers.
Use nested if statements.
Examples:
 a	     b	    c	    biggest
 5	     2	    2	    5
-2	    -2	    1	    1
-2	     4	    3	    4
 0	    -2.5	5	    5
-0.1	-0.5	-1.1	-0.1
*/

//Feel free to add or remove numbers, but there must be an equal number of numbers in a, b and c
var a = [5, -2, -2, 0, -0.1, 2, 2],
    b = [2, -2, 4, -2.5, -0.5, 2, 2],
    c = [2, 1, 3, 5, -1.1, 2.1, 2],
    loops = a.length,
    i;

for (i = 0; i < loops; i += 1) {

    console.log('The numbers are: ' + a[i] + ' , ' + b[i] + ' and ' + c[i]);
    if (a[i] > b[i]) {
        if (a[i] > c[i]) {
            console.log('Biggest number is: ' + a[i]);
        } else {
            console.log('Biggest number is: ' + c[i]);
        }
    } else {
        if (b[i] > c[i]) {
            console.log('Biggest number is: ' + b[i]);
        } else {
            console.log('Biggest number is: ' + c[i]);
        }
    }
}