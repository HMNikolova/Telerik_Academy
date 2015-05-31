var first = [5,3,5.5],
    second = [2,4,4.5],
    loops = first.length,
    temp,
    i;

    for (i = 0; i < loops; i += 1) {
        console.log('Initial numbers are ' + first[i] + ' and ' + second[i]);
        if (second[i] > first[i]) {
            temp = second[i];
            second[i] = first[i];
            first[i] = temp;

        }
        console.log('Larger numbers is ' + first[i] + ' and smaller number is ' + second[i]);
    }