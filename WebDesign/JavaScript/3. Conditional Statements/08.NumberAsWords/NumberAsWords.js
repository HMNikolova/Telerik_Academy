/* Problem 8. Number as words
Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
Examples:
numbers	number as words
0	    Zero
9	    Nine
10	    Ten
12	    Twelve
19	    Nineteen
25	    Twenty five
98	    Ninety eight
273	    Two hundred and seventy three
400	    Four hundred
501	    Five hundred and one
617	    Six hundred and seventeen
711	    Seven hundred and eleven
999	    Nine hundred and ninety nine
*/

var numbers = [0, 9, 10, 12, 19, 25, 98, 273, 400, 501, 617, 711, 999],
    loops = numbers.length,
    result = [],
    hundreds,
    tens,
    ones,
    i;

for (i = 0; i < loops; i += 1) {

    result = generateNumber(numbers[i]);
    console.log(numbers[i] + ' as word is ' + result.join(' '));

}

function generateNumber(number) {

    result = [];
    hundreds = (number / 100) | 0;
    tens = ((number / 10) | 0) % 10;
    ones = number % 10;

    if (hundreds > 0) {
        switch (hundreds) {
            case 1:
                result.push('One Hundred');
                break;
            case 2:
                result.push('Two Hundred');
                break;
            case 3:
                result.push('Three Hundred');
                break;
            case 4:
                result.push('Four Hundred');
                break;
            case 5:
                result.push('Five Hundred');
                break;
            case 6:
                result.push('Six Hundred');
                break;
            case 7:
                result.push('Seven Hundred');
                break;
            case 8:
                result.push('Eight Hundred');
                break;
            case 9:
                result.push('Nine Hundred');
                break;
            default:
                result.push('Error');
                break;
        }
        if ((tens === 0 && ones > 0) || tens === 1) {
            result.push('and');
        }
    }

    if (tens === 1) {
        switch (ones) {
            case 0:
                result.push('Ten');
                break;
            case 1:
                result.push('Eleven');
                break;
            case 2:
                result.push('Twelve');
                break;
            case 3:
                result.push('Thirteen');
                break;
            case 4:
                result.push('Fourteen');
                break;
            case 5:
                result.push('Fifteen');
                break;
            case 6:
                result.push('Sixteen');
                break;
            case 7:
                result.push('Seventeen');
                break;
            case 8:
                result.push('Eighteen');
                break;
            case 9:
                result.push('Nineteen');
                break;
            default:
                result.push('Error');
                break;
        }
    }

    if (tens > 1) {
        switch (tens) {
            case 2:
                result.push('Twenty');
                break;
            case 3:
                result.push('Thirty');
                break;
            case 4:
                result.push('Forty');
                break;
            case 5:
                result.push('Fifty');
                break;
            case 6:
                result.push('Sixty');
                break;
            case 7:
                result.push('Seventy');
                break;
            case 8:
                result.push('Eighty');
                break;
            case 9:
                result.push('Ninety');
                break;
            default:
                result.push('Error');
                break;
        }
    }

    if (tens !== 1 && ones !== 0) {
        switch (ones) {
            case 1:
                result.push('One');
                break;
            case 2:
                result.push('Two');
                break;
            case 3:
                result.push('Three');
                break;
            case 4:
                result.push('Four');
                break;
            case 5:
                result.push('Five');
                break;
            case 6:
                result.push('Six');
                break;
            case 7:
                result.push('Seven');
                break;
            case 8:
                result.push('Eight');
                break;
            case 9:
                result.push('Nine');
                break;
            default:
                result.push('Error');
                break;
        }
    }

    if (!hundreds && !tens && !ones) {
        result.push('Zero');
    }

    return result;
}