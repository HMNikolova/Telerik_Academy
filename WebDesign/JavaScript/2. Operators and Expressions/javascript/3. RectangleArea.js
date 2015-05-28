//  Problem 3. Rectangle area
//  Write an expression that calculates rectangle’s area by given width and height.

console.log('----------------------------------------');
console.log('Task 3 output: Rectangle area');
console.log('----------------------------------------');

var rectArea = function(width,heigth) {
		return width * heigth;
	};

	
var widths = [5,2.5,3],
	heigths = [5,3,4];
	
	for (var i = widths.length - 1; i >= 0; i--) {
		console.log(widths[i] + '*' + heigths[i] +' = ' + rectArea(widths[i],heigths[i]));
	}