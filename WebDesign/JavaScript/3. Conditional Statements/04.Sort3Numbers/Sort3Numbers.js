/* Problem 4. Sort 3 numbers
Sort 3 real values in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.
Examples:
 a	     b	     c	    result
 5	     1	     2	    5  2  1
-2	    -2	     1	    1 -2 -2
-2	     4	     3	    4  3 -2
 0	    -2.5	 5	    5  0 -2.5
-1.1	-0.5	-0.1  -0.1 -0.5 -1.1
10	    20	    30	    30 20 10
1	    1	    1	    1 1 1
*/

//Feel free to add or remove numbers, but there must be an equal number of numbers in a, b and c
var a = [5, -2, -2, 0, -1.1, 10, 1],
    b = [1, -2, 4, -2.5, -0.5, 20, 1],
    c = [2, 1, 3, 5, -0.1, 30, 1],
    loops = a.length,
    i;

for (i = 0; i < loops; i += 1) {

    console.log('The numbers are: ' + a[i] + ' , ' + b[i] + ' and ' + c[i]);

    if (a[i] > b[i] && a[i] > c[i]) {
        if (b[i] > c[i]) {
            console.log('Sorted Numbers: ' + a[i] + ' , ' + b[i] + ' and ' + c[i]);
        } else {
            console.log('Sorted Numbers: ' + a[i] + ' , ' + c[i] + ' and ' + b[i]);
        }
    } else if (b[i] > a[i] && b[i] > c[i]) {
        if (a[i] > c[i]) {
            console.log('Sorted Numbers: ' + b[i] + ' , ' + a[i] + ' and ' + c[i]);
        } else {
            console.log('Sorted Numbers: ' + b[i] + ' , ' + c[i] + ' and ' + a[i]);
        }
    } else {
        if (a[i] > b[i]) {
            console.log('Sorted Numbers: ' + c[i] + ' , ' + a[i] + ' and ' + b[i]);
        } else {
            console.log('Sorted Numbers: ' + c[i] + ' , ' + b[i] + ' and ' + a[i]);
        }
    }
}