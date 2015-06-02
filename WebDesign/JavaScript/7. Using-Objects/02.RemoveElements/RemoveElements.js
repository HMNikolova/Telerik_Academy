/* Problem 2. Remove elements

Write a function that removes all elements with a given value.
Attach it to the array type.
Read about prototype and how to attach methods.

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
*/

var array = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'], // You can edit these variables
    element = 1;

Array.prototype.remove = function (element) {

    var i,
        length;

    for (i = 0, length = this.length; i < length; i += 1) {

        if (this[i] === element) {
            this.splice(i, 1);
            i -= 1;
        }
    }

    return this;
};

console.log('Initial array is: ' + array);

array.remove(element);

console.log('Removing ' + element + ' results in: ' + array);
