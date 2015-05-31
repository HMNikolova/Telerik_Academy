var a = [5,-2,-2,0,-1],
    b = [2,-2,4,-2.5,-0.5],
    c = [2,1,3,4,-5.1],
    loops = a.length,
    i;

function findAndPrintResult(a, b, c) {

    if (!a || !b || !c) {
        console.log(a + ' * ' + b + ' * ' + c + ' results in 0');
    } else if (a > 0 && b > 0 && c > 0) {
        console.log(a + ' * ' + b + ' * ' + c + ' results in "+"');
    } else if (a < 0 && b < 0 && c < 0) {
        console.log(a + ' * ' + b + ' * ' + c + ' results in "-"');
    } else if ((a > 0 && b > 0) || (b > 0 && c > 0) || (a > 0 && c > 0)) {
        console.log(a + ' * ' + b + ' * ' + c + ' results in "-"');
    } else if ((a < 0 && b < 0) || (b < 0 && c < 0) || (a < 0 && c < 0)) {
        console.log(a + ' * ' + b + ' * ' + c + ' results in "+"');
    } 
}

for (i = 0; i < loops; i += 1) {
    findAndPrintResult(a[i], b[i], c[i]);
}