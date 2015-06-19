/* Problem 5. Digit as word
Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
Examples:
digit	result
2	    two
1	    one
0	    zero
5	    five
-0.1	not a digit
hi	    not a digit
9	    nine
10	    not a digit
*/

//Feel free to add or remove numbers
var numbers = [2, 1, 0, 5, -0.1, 'hi', 9, 10],
    loops = numbers.length,
    i;

for (i = 0; i < loops; i += 1) {

    LogDigit(numbers[i]);
}

function LogDigit(number) {
    switch (number) {
        case 0:
            console.log('Digit in ' + number + ' is Zero');
            break;
        case 1:
            console.log('Digit in ' + number + ' is One');
            break;
        case 2:
            console.log('Digit in ' + number + ' is Two');
            break;
        case 3:
            console.log('Digit in ' + number + ' is Three');
            break;
        case 4:
            console.log('Digit in ' + number + ' is Four');
            break;
        case 5:
            console.log('Digit in ' + number + ' is Five');
            break;
        case 6:
            console.log('Digit in ' + number + ' is Six');
            break;
        case 7:
            console.log('Digit in ' + number + ' is Seven');
            break;
        case 8:
            console.log('Digit in ' + number + ' is Eigth');
            break;
        case 9:
            console.log('Digit in ' + number + ' is Nine');
            break;
        default:
            console.log('Digit in ' + number + ' is Not a Digit!');
            break;
    }
}