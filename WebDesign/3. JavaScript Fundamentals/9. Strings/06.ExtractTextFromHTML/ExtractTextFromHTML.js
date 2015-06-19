/* Problem 6. Extract text from HTML

Write a function that extracts the content of a html page given as text.
The function should return anything that is in a tag, without the tags.

Example:
<html>
  <head>
    <title>Sample site</title>
  </head>
  <body>
    <div>text
      <div>more text</div>
      and more...
    </div>
    in body
  </body>
</html>

Result: Sample sitetextmore textand more...in body
*/

var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>',
    htmlSecond = '<html><head><title>News</title></ head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>';

console.log('Extracted text is ' + extractText(html));
console.log('Extracted text is ' + extractText(htmlSecond));

function extractText(html) {

    var regex = /<[^>]+>/g; 

    /* from: regex101.com
    < matches the characters < literally
    [^>] match a single character not present in the list
    Quantifier: + Between one and unlimited times
    > matches the characters > literally
    g modifier: global. All matches (don't return on first match)    
    */

    return html.replace(regex, ''); 
}