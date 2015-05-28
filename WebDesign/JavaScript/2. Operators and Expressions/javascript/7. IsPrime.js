// Problem 7. Is prime
// Write an expression that checks if given positive integer number n (n ? 100) is prime.

console.log('----------------------------------------');
console.log('Task 7 output: Is prime ');
console.log('----------------------------------------');

function isPrime(num) {
    if (isNaN(num) || !isFinite(num) || num % 1 || num < 2) {
        return false;
    }

    var m = Math.sqrt(num);
    for (var i = 2; i <= m; i++) {
        if (num % i === 0) {
            return false;
        }
    }
    return true;
}

console.log("Is 1 prime: " + isPrime(1));
console.log("Is 2 prime: " + isPrime(2));
console.log("Is 3 prime: " + isPrime(3));
console.log("Is 4 prime: " + isPrime(4));
console.log("Is 9 prime: " + isPrime(9));
console.log("Is 37 prime: " + isPrime(37));
console.log("Is 97 prime: " + isPrime(97));
console.log("Is 51 prime: " + isPrime(51));
console.log("Is -3 prime: " + isPrime(-3));
console.log("Is 0 prime: " + isPrime(0));
