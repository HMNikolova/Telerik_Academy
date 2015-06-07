/* Problem 9. Extract e-mails

Write a function for extracting all email addresses from given text.
All sub-strings that match the format @… should be recognized as emails.
Return the emails as array of strings.
*/

var text = 'Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.';

console.log('Original text is: ' + text);
console.log('Extracted e-mails are: ' + extractMail(text));

function extractMail(text) {

    var result = [],
        regex = /[A-Za-z0-9_\-\+]+@[A-Za-z0-9\-]+\.([A-Za-z]{2,3})(?:\.[a-z]{2})?/g;

    result = text.match(regex);

    return result;
}