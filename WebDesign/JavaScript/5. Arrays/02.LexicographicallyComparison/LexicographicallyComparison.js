/* Problem 2. Lexicographically comparison

Write a script that compares two char arrays lexicographically (letter by letter).
*/

var charOne = ['hello world'], // You may change this value
    charTwo = ['hello JS!!!'], // You may change this value
    areEqual = true,
    loops = charOne.length,
    i;


if (charOne.length === charTwo.length) {

    for (i = 0; i < loops; i += 1) {

        if (charOne[i] !== charTwo[i]) {
            equalArrays = false;
            break;
        }
    }
} else {
    equalArrays = false;
}

console.log('The two char arrays ' + charOne + ' and ' + charTwo + ' are equal: ' + equalArrays);