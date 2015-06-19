//  Problem 3. Rectangle area
//  Write an expression that calculates rectangle’s area by given width and height.

var rectArea = function(width,height) {
	return width*height;
}; 
var widths = [5,2.5,3];
var heights = [5,3,4];
for (var i = widths.length - 1; i >= 0; i--) {
	console.log(widths[i] + ' * ' + heights[i] + ' = ' + rectArea(widths[i],heights[i])); 
}