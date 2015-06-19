/* Problem 7. The biggest of five bers
Write a script that finds the greatest of given 5 variables.
Use nested if statements.
Examples:
a	    b	    c	    d	    e	    biggest
5	    2	    2	    4	    1	    5
-2	    -22	    1	    0	    0	    1
-2	    4	    3	    2	    0	    4
0	    -2.5	0	    5	    5	    5
-3	    -0.5	-1.1	-2	    -0.1	-0.1
*/

var a = [5, -2, -2, 0, -3],
    b = [2, -22, 4, -2.5, -0.5],
    c = [2, 1, 3, 0, -1.1],
    d = [4, 0, 2, 5, -2],
    e = [1, 0, 0, 5, -0.1],
    loops = a.length,
    biggest,
    i;

for (i = 0; i < loops; i += 1) {

    console.log('The numbers are: ' + a[i] + ', ' + b[i] + ', ' + c[i] + ', ' +
        d[i] + ' and ' + e[i]);

    biggest = a[i];

    if (b[i] > biggest) {

        biggest = b[i];
    }

    if (c[i] > biggest) {

        biggest = c[i];
    }

    if (d[i] > biggest) {

        biggest = d[i];
    }

    if (e[i] > biggest) {

        biggest = e[i];
    }

    console.log('The biggest number is ' + biggest);

}