/* Problem 10. Find palindromes

Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/


var text = 'madam listening to ABBA will take to the next pop level, just press the exe !';

console.log('Initial text is ' + text);
console.log('The palindromes are: ' + checkForPalindromes(text).join(', '));

function checkForPalindromes(text) {

    var result = [],
        symmetric,
        input = text.split(' ');

    for (var i = 0, len = input.length; i < len; i += 1) {

        if (input[i].length > 1) {

            symmetric = true;

            for (var j = 0, len2 = input[i].length; j < len2 / 2; j += 1) {
                if (input[i][j] !== input[i][input[i].length - j - 1]) {
                    symmetric = false;
                    break;
                }
            }

            if (symmetric) {
                result.push(input[i])
            }
        }
    }

    return result;
}