//  Problem 5. Third bit
//  Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//    The bits are counted from right to left, starting from bit #0.
//  The result of the expression should be either 1 or 0.

console.log('----------------------------------------');
console.log('Task 5 output: Third bit value ');
console.log('----------------------------------------');

function checkThirdBit(num) {
    return (num >> 3) & 1;
}

console.log("5: " + checkThirdBit(5));
console.log("8: " + checkThirdBit(8));
console.log("0: " + checkThirdBit(0));
console.log("15: " + checkThirdBit(15));
console.log("5343: " + checkThirdBit(5343));
console.log("62241: " + checkThirdBit(62241));