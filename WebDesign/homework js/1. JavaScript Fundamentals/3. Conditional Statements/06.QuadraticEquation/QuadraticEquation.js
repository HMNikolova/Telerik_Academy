/* Problem 6. Quadratic equation
Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
and solves it (prints its real roots).
Calculates and prints its real roots.
Note: Quadratic equations may have 0, 1 or 2 real roots.
Examples:
a	    b	    c	    roots
2	    5	    -3	    x1=-3; x2=0.5
-1	    3	    0	    x1=3; x2=0
-0.5	4	    -8	    x1=x2=4
5	    2	    8	    no real roots
*/

//Feel free to add or remove numbers, but there must be an equal number of numbers in a, b and c
var a = [2, -1, -0.5, 5],
    b = [5, 3, 4, 2],
    c = [-3, 0, -8, 8],
    loops = a.length,
    discriminant,
    root1,
    root2,
    i;

for (i = 0; i < loops; i += 1) {

    console.log('In the quadratic equation ' + a[i] + 'x2 + ' + b[i] + 'x + ' + c[i] + ' = 0');

    discriminant = (b[i] * b[i]) - (4 * a[i] * c[i]);
    if (discriminant > 0) {
        root1 = (-b[i] - Math.sqrt(discriminant)) / (2 * a[i]);
        root2 = (-b[i] + Math.sqrt(discriminant)) / (2 * a[i]);
        console.log("Root x1 = " + root1);
        console.log("Root x2 = " + root2);
    } else if (!discriminant) {
        root1 = root2 = (-b[i] - Math.sqrt(discriminant)) / (2 * a[i]);
        console.log("One Root x = " + root1);
    } else {
        console.log("No real roots.");
    }
}
