/* Problem 4. Number of elements

Write a function to count the number of div elements on the web page
*/

console.log('There are ' + countDiv() + ' div\'s on this web-page: ' + window.location.href);
// The window.location.href property returns the URL of the current page

function countDiv() {

    var array = document.getElementsByTagName('div'), // This will return an array
        length = array.length;
    
    return length;
}