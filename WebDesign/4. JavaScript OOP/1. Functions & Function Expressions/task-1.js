/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	
*/

function solve() {
	return function sums(arr) {
		var sum = 0;

		if (arr === undefined) {
			throw Error;
		}

		if (arr.length === 0) {
			return null;
		}

		arr.map(Number).forEach(function (element) {
			if (isNaN(element)) {
				throw Error;
			}

			sum += element;

		}, this);

		return sum;
	};
}

console.log((solve())([1, 2, 3, 4, 5, -6]));