//  Problem 6. Point in Circle
//  Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius

 var circleK = 5,

    pointX = [0, -5, -4, 1.5, -4, 100, 0, 0.2, 0.9, 2],
    pointY = [1, 0, 5, -3, -3.5, -30, 0, -0.8, -4.93, 2.655],
    loops = pointX.length,
    i,
    isInside;

for (i = 0; i < loops; i += 1) {
    if (pointX[i] !== undefined && pointY[i] !== undefined) {
        isInside = ((pointX[i] * pointX[i] + pointY[i] * pointY[i]) <= (circleK * circleK));
        console.log('X = ' + pointX[i] + '; Y = ' + pointY[i] + '; is in the circle: ' + isInside);
    }
}