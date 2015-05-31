//  Problem 2. Divisible by 7 and 5
//  Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var divBySevenFive = function(num) {
	if (num % 5 === 0 && num % 7 === 0) {
		return true;
	}
	else{
		return false;
	}
};

var numbers = [140,35,7,5,0,3];
for (var i = numbers.length - 1; i >= 0; i--) {
	console.log(numbers[i] + ' ' + divBySevenFive(numbers[i]));
}
