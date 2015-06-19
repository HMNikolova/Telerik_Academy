/* Problem 7. The biggest of five numbers
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

var numA = [5, -2, -2, 0, -3],
    numB = [2, -22, 4, -2.5, -0.5],
    numC = [2, 1, 3, 0, -1.1],
    numD = [4, 0, 2, 5, -2],
    numE = [1, 0, 0, 5, -0.1],
    loops = numA.length,
    biggest,
    i;

for (i = 0; i < loops; i += 1) {

    console.log('The numbers are: ' + numA[i] + ', ' + numB[i] + ', ' + numC[i] + ', ' +
        numD[i] + ' and ' + numE[i]);

    biggest = numA[i];

    if (numB[i] > biggest) {

        biggest = numB[i];
    }

    if (numC[i] > biggest) {

        biggest = numC[i];
    }

    if (numD[i] > biggest) {

        biggest = numD[i];
    }

    if (numE[i] > biggest) {

        biggest = numE[i];
    }

    console.log('The biggest number is ' + biggest);

}