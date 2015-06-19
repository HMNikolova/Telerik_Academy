/* Problem 7. Parse URL

Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.

Example:
URL	                                                    result
http://telerikacademy.com/Courses/Courses/Details/239	{ protocol: http, 
                                                        server: telerikacademy.com 
                                                        resource: /Courses/Courses/Details/239 }
*/

var jsonObj,
    url = 'http://telerikacademy.com/Courses/Courses/Details/239',
    urlSecond = window.location.href; //This will get the current address of the webpage

jsonObj = parseURL(url);

console.log('Parsed URL is ' + JSON.stringify(jsonObj));

jsonObj = parseURL(urlSecond);

console.log('Current URL is ' + JSON.stringify(jsonObj));

function parseURL(url) {

    var protocol,
        server,
        resource,
        indexProtcol,
        indexResource;

    indexProtcol = url.indexOf('://');
    protocol = url.substring(0, indexProtcol);

    indexResource = url.indexOf('/', indexProtcol + 3);
    server = url.substring(indexProtcol + 3, indexResource);

    resource = url.substr(indexResource);

    return {
        protocol: protocol,
        server: server,
        resource: resource
    }
}
