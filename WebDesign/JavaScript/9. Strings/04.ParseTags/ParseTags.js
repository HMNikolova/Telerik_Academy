/* Problem 4. Parse tags

You are given a text. Write a function that changes the text in all regions:

<upcase>text</upcase> to uppercase.
<lowcase>text</lowcase> to lowercase
<mixcase>text</mixcase> to mix casing(random)
Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

The expected result:
We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

Note: Regions can be nested.
*/

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow <lowcase>SUBMARINE</lowcase></upcase>. We <mixcase>don't</mixcase> have <lowcase>ANYTHING</lowcase> else.";

function changeCase(text) {
    var tagsLen = { 'm': 7, 'u': 6, 'l': 7 },
        stack = [],
        result = [],
        len = text.length,
        tag,
        i;

    for (i = 0; i < len; i += 1) {

        if (text[i] === '<') {
            if (text[i + 1] === '/') {
                i += tagsLen[stack.pop()] + 2;
            } else {
                stack.push(text[i + 1]);
                i += tagsLen[text[i + 1]] + 1;
            }
        } else {
            tag = stack[stack.length - 1];
            if (tag === 'm') {
                if (Math.random() < 0.5) result.push(text[i].toUpperCase());
                else result.push(text[i].toLowerCase());
            } else if (tag === 'u') {
                result.push(text[i].toUpperCase());
            } else if (tag === 'l') {
                result.push(text[i].toLowerCase());
            } else {
                result.push(text[i]);
            }
        }
    }

    return result.join('');
}
console.log('Initial text is: ' + text);
console.log('Changed text is: ' + changeCase(text));