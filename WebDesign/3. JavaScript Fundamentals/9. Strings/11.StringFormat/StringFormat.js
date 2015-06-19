/* Problem 11. String format

Write a function that formats a string using placeholders.
The function should work with up to 30 placeholders and all types.

Examples:
var str = stringFormat('Hello {0}!', 'Peter'); 
//str = 'Hello Peter!';

var frmt = '{0}, {1}, {0} text {2}';
//str = '1, Pesho, 1 text Gosho'
*/

String.format = function (formatString) {

    if (!formatString)
        return '';

    var args = Array.prototype.slice.call(arguments, 1);

    return formatString.replace(/{(\d+)}/g, function (match, index) {
        return args[index] ? args[index] : match;
    });
};

console.format = function () {
    console.log(String.format.apply(this, arguments));
}

console.log('initial stringFormat: (\'Hello {0}!\', \'Peter\')');
console.format('Hello {0}!', 'Peter');

console.log('initial stringFormat: \'{0}, {1}, {0} text {2}\'');
console.format('{0}, {1}, {0} text {2}', '1', 'Pesho', 'Gosho');