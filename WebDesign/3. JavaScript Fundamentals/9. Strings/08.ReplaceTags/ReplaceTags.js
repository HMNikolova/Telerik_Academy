/* Problem 8. Replace tags

Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
*/

var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log('Original html: ' + html);
console.log('With raplaced tags: ' + replaceTags(html));

function replaceTags(html) {

    var startRegex = /(<a href=)(\S+)(>)/g, // Each expression in the brackets is a group with start count 1
        endRegex = /<\/a>/g,

    html = html.replace(endRegex, '[/URL]');
    html = html.replace(startRegex, '[URL=$2]'); // $2 will keep the content of the second group

    return html;
}