/* Problem 2. Correct brackets

Write a JavaScript function to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/

var expressions = ['((a+b)/5-d)', ')(a+b))', '((4x + 6)(5x + 1) * ((2x + 3)(3x + 1)))'
    , '((x + z) + (5x * 2)', '(3x + (4 * 2))'];


for (var i = 0, len = expressions.length; i < len; i+=1) {

    console.log('Expression ' + expressions[i] + ' is correct? ' + checkBrackets(expressions[i]));
}

function checkBrackets(expression) {

    var bracketCount = 0,
		correctExpression = true;

    for (var i = 0, len = expression.length; i < len; i += 1) {
        if (expression[i] === '(') {
            bracketCount += 1;
        } else if (expression[i] === ')') {
            bracketCount -= 1;
        }
        if (bracketCount < 0) {
            correctExpression = false;
            break;
        }
    }

    if (bracketCount !== 0) {
        correctExpression = false;
    }

    return correctExpression;
}