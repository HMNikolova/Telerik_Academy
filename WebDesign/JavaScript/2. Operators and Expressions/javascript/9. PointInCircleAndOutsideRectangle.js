// Problem 9. Point in Circle and outside Rectangle
// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

console.log('----------------------------------------');
console.log('Task 9 output: Point in Circle and outside Rectangle ');
console.log('----------------------------------------');

function solveTask(x, y) {
	var isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3 * 3;
	var isOutOfRectangle = !((x >= -1 && x <= -1 + 6) && (y <= 1 && y >= 1 - 2));
	return isInCircle && isOutOfRectangle;
}

console.log("x = 1, y = 4 : " + solveTask(1, 4));
console.log("x = 3, y = 2 : " + solveTask(3, 2));
console.log("x = 0, y = 1 : " + solveTask(0, 1));
console.log("x = 4, y = 1 : " + solveTask(4, 1));
console.log("x = 2, y = 0 : " + solveTask(2, 0));
console.log("x = 4, y = 0 : " + solveTask(4, 0));
console.log("x = 2.5, y = 1.5 : " + solveTask(2.5, 1.5));
console.log("x = 3.5, y = 1.5 : " + solveTask(3.5, 1.5));
console.log("x = -100, y = -100 : " + solveTask(-100, -100));