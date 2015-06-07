/* Problem 1. Reverse string

Write a JavaScript function that reverses a string and returns it.

Example:
input	output
sample	elpmas
*/

var words = ['evil', 'stressed', 'star', 'loop', 'sample'];

for (var i = 0, len = words.length; i < len; i+=1) {

    console.log('The word ' + words[i] + ' reversed is ' + reverseString(words[i]));
}

function reverseString(str) {

    return str.split('').reverse().join('');
}
