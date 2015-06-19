/* 
 * Problem 1. Planar coordinates

Write functions for working with shapes in standard Planar coordinate system.
Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points.
Check if three segment lines can form a triangle.
 */
var pointA,
    pointB,
    pointC,
    lineA,
    lineB,
    lineC,
    i,
    length,
    allPoints = [],
    allLines = [];

function Point(x, y) { // Creating a constructor for the Points
    this.x = x;
    this.y = y;   
}

function Line(pointB, pointE) { // Creating a constructor for the Lines
    this.begin = pointB;
    this.end = pointE;
    this.length = calculateLength(this.begin, this.end);
}

function calculateLength(pointA, pointB) {

    return Math.sqrt((pointB.x - pointA.x) * (pointB.x - pointA.x) + (pointB.y - pointA.y) * (pointB.y - pointA.y));

}

function isTriangle(linaA, lineB, lineC) {

    return lineA.length + lineB.length > lineC.length &&
        lineB.length + lineC.length > linaA.length &&
        lineC.length + linaA.length > lineB.length;
}

pointA = new Point(2, 3); // creating Points via the Constructor
pointB = new Point(5, 7); 
pointC = new Point(2, 6);

allPoints = [pointA, pointB, pointC];

for (i = 0, length = allPoints.length; i < length; i+=1) {

    console.log('Point ' + i + ' is: ' + JSON.stringify(allPoints[i]));
}

console.log('Distance between point 0 and 1 is: ' + calculateLength(pointA, pointB));
console.log('Distance between point 1 and 2 is: ' + calculateLength(pointB, pointC));
console.log('Distance between point 2 and 0 is: ' + calculateLength(pointC, pointA));


lineA = new Line(pointA, pointB); // creating Lines via the Constructor
lineB = new Line(pointB, pointC);
lineC = new Line(pointC, pointA);

allLines = [lineA, lineB, lineC];

for (i = 0, length = allPoints.length; i < length; i += 1) {

    console.log('Line ' + i + ' is: ' + JSON.stringify(allLines[i]));
}

console.log('The Lines 0, 1 and 2 can form a triangle: ' + isTriangle(lineA, lineB, lineC));

