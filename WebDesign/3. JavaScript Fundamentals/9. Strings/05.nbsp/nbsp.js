/* Problem 5. nbsp

Write a function that replaces non breaking white-spaces in a text with &nbsp;
*/

var text = 'Write a function that replaces non breaking white-spaces';

console.log('Initial text is: ' + text);
console.log('Result is ' + replaceNonBreakingSpace(text));

function replaceNonBreakingSpace(text) {

    var replaceWith = '&nbsp';

    return text.split(' ').join(replaceWith);
}