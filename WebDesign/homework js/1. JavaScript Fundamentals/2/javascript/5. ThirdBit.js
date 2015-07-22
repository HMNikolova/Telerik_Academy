//  Problem 5. Third bit
//  Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//    The bits are counted from right to left, starting from bit #0.
//  The result of the expression should be either 1 or 0.

function checkBit(num) {
	return (num >> 3) & 1; 
}
console.log('15: ' + checkBit(15));