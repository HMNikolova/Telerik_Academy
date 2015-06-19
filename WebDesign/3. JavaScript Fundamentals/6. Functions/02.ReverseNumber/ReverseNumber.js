/* Problem 2. Reverse number

Write a function that reverses the digits of given decimal number.

Example:
input	output
256	    652
123.45	54.321
*/

var array = [256, 123.45, 6000, 5001, 3.14],
    loops,
    i;

for (i = 0, loops = array.length; i < loops; i += 1) {

    console.log('The number ' + array[i] + ' reversed is ' + reverseNumber(array[i]));
}

function reverseNumber(number) {

    var numStr = number.toString(),
        reversed = '',
        i;

    for (i = numStr.length - 1; i >= 0; i -= 1) {
        reversed += numStr[i];
    }

    return reversed * 1;
}