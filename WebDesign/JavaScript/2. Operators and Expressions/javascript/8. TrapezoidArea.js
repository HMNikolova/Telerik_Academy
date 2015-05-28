//  Problem 8. Trapezoid area
//  Write an expression that calculates trapezoid's area by given sides a and b and height h.

console.log('----------------------------------------');
console.log('Task 8 output: Trapezoid area');
console.log('----------------------------------------');

var aSizes = [5,2,8.5,100,0.222],
	bSizes = [7,1,4.3,200,0.333],
	hipos = [12,33,2.7,300,0.555],  
	getTrapezoidArea =  function(a,b,h) {
		return ((a+b)/2)*h;
	};     
	for (var i = 0; i < aSizes.length; i+=1) {
		console.log('A='+aSizes[i]+' B='+bSizes[i]+' H='+hipos[i]);
		console.log(getTrapezoidArea(aSizes[i],bSizes[i],hipos[i]));
	}