/* Problem 1. English digit

Write a function that returns the last digit of given integer as an English word.

Examples:
input	output
512	    two
1024	four
12309	nine
*/

var array = [512, 1024, 12309, 0, 123, 'hi'],
    loops,
    i;

for (i = 0, loops = array.length; i < loops; i+=1) {

    console.log('The last digit in ' + array[i] + ' is ' + findLastDigit(array[i]));
}

function findLastDigit(number) {

    var digit = number % 10;

    switch (digit) {
        case 0:
            return("Zero");            
        case 1:
            return ("One");            
        case 2:
            return ("Two");            
        case 3:
            return ("Three");            
        case 4:
            return ("Four");            
        case 5:
            return ("Five");            
        case 6:
            return ("Six");            
        case 7:
            return ("Seven");            
        case 8:
            return ("Eight");            
        case 9:
            return ("Nine");            
        default:
            return ("Not a digit");            
    }
}