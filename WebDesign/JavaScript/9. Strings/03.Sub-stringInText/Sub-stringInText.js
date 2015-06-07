/* Problem 3. Sub-string in text

Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
*/

var text = 'We are living in an yellow submarine. We don\'t have anything else.Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days',
    lookingFor = 'in',
    counter;

counter = countWord(text, lookingFor);
console.log('In the given text you may find the word ' + lookingFor + ' exactly ' + counter + ' times ');

function countWord(texts, looking) {

    var text = texts.toLowerCase(),
        lookingFor = looking.toLowerCase(),
        counter = 0,
        index = text.indexOf(lookingFor, 0);

    while (index !== -1) {

        counter += 1;
        index = someText.indexOf(lookingFor, index + 1);
    }

    return counter;
}