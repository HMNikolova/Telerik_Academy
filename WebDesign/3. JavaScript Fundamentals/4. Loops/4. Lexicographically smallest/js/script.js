/* Problem 4. Lexicographically smallest
Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
*/
var min,
    max,
    prop;

minMax(document);
minMax(window);
minMax(navigator);

function minMax(obj) {

    min = '~'; // ASCII code 126 (biggest)
    max = ' '; // ASCII code 32 (smallest)

    for (prop in obj) {

        if (prop > max) {
            max = prop;
        }
        if (prop < min) {
            min = prop;
        }
    }

    console.log(obj.toString() + ': min -> ' + min + ', max -> ' + max);
}