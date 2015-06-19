//  Problem 1. Odd or Even
//  Write an expression that checks if given integer is odd or even.

	console.log('----------------------------------------');
	console.log('Task 1 output: Odd or Even');
	console.log('----------------------------------------');

var oddEvenCheck = function(num) {
		if (num % 2 === 0) {
			return false;
		}
		else {
			return true;
		}
	};
	
var numbers = [0,-1,-2,2,3];
	for (var i = numbers.length - 1; i >= 0; i--) {
		console.log(numbers[i] + ' ' + oddEvenCheck(numbers[i]));
	}