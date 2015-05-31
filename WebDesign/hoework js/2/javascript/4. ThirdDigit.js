//  Problem 4. Third digit
//  Write an expression that checks for given integer if its third digit (right-to-left) is 7.

function checkNum(num){
	var div = Math.floor(num/100) % 10;
	return div === 7;
}
console.log('5: ' + checkNum(5));