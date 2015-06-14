function solve(params) {
	// var N = parseInt(params[0]);
	// var answer = 0;
	//масива params slice-нат без 1-ви елемент и всички числа да ги прехвърля към numbers
	var numbers = params.slice(1).map(Number);
	//ако numbers[0] ни е най-голямата сума ок, ако обаче има по-голяма сума от нея отдолу някъе ще го сметнем
	var bestSum = numbers[0];
	for(var i = 0; i < numbers.length; i += 1){
		var currenetSum = 0;
		for(var j = i; j < numbers.length; j += 1){
			currenetSum += numbers[j];
			if(currenetSum > bestSum){
				bestSum = currenetSum;
			}
		}
	}
	return bestSum;
}
var test = [
'8',
'1',
'6',
'-9',
'4',
'4',
'-2',
'10',
'-1'
];
console.log(solve(test));