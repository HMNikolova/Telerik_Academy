function solve(params) {
//function solve(args) {
	// 'use strict';
	// var sizes = args[0].split(' ').map(Number),
	// 	field = args.slice(1).map(function (row) {
	// 		return row.split('').map(Number);
	// 	}),
	// 	rows = sizes[0],
	// 	cols = sizes[1],
	// 	row = rows - 1,
	// 	col = cols - 1,
	// 	used = {},
	// 	jumps,
	// 	sum,
	// 	directions = [{}, {
	// 		row: -2,
	// 		col: 1
	// 	}, {
	// 		row: -1,
	// 		col: 2
	// 	}, {
	// 		row: 1,
	// 		col: 2
	// 	}, {
	// 		row: 2,
	// 		col: 1
	// 	}, {
	// 		row: 2,
	// 		col: -1
	// 	}, {
	// 		row: 1,
	// 		col: -2
	// 	}, {
	// 		row: -1,
	// 		col: -2
	// 	}, {
	// 		row: -2,
	// 		col: -1
	// 	}, ];
	// var line = [];
	// for (var c = 0; c < cols; c += 1) {
	// 	var value = c.toString();
	// 	while (value.length < 5) {
	// 		value = ' ' + value;
	// 	}
	// 	line.push(value);
	// }
	// function getValue(row, col) {
	// 	return (1 << row) - col;
	// }

	// function hash(row, col, cols) {
	// 	return row * cols + col;
	// }

	// function inRange(value, border) {
	// 	return 0 <= value && value < border;
	// }

	// jumps = 0;
	// sum = 0;
	// while (true) {
	// 	if (used[hash(row, col, cols)]) {
	// 		return 'Sadly the horse is doomed in ' + jumps + ' jumps';
	// 	}
	// 	if (!inRange(row, rows) || !inRange(col, cols)) {
	// 		return 'Go go Horsy! Collected ' + sum + ' weeds';
	// 	}

	// 	used[hash(row, col, cols)] = true;

	// 	jumps++;
	// 	sum += getValue(row, col);

	// 	var dirIndex = field[row][col],
	// 		dir = directions[dirIndex];

	// 	row += dir.row;
	// 	col += dir.col;
	// }
	function getPoints(row, col){
		return Math.pow(2, row) - col;
	}
	//console.log(getPoints(1,4));
	function getRowsAndCols(str){
		//разделихме стринга по интервал получаваме 2 под стринга
		var parts = str.split(' ');
		//връщам масив с 0 елемент броя редове и 1 елемент от този масив с броя колони
		return [parseInt(parts[0]), parseInt(parts[1])];
	}
	//console.log(getRowsAndCols('3 5'));

	function getValue(params, row, col) {
	        return params[row + 1][col];
	 }
	 //console.log(getValue(params, 2, 4));

	 
	//в params[0] се намира [ 3, 5 ]
	var rowsAndCols = getRowsAndCols(params[0]), 
	//и си правим броя редове и колони в 2-те променливи
	rows = rowsAndCols[0],
	cols = rowsAndCols[1],
	//започвам от някакъв ред и някаква колона
	row = rows - 1,
	col = cols -1,
	//как да броя колко точки имам - всеки път когато стъпя върху някоя клетка, аз ще изкарвам през моята функция 
	//getPoints текущия ред и колона колко са ни точките и ще ги трупам в една променлива points
	points = 0,
	//колко пъти съм стъпил върху дадена клетка 
	moves = 0, 
	used = [];
	//възможните ми движения

	var horseMoves = [[-2,1], [-1, 2], [1, 2], [2, 1],
					  [2, -1], [1, -2], [-1, -2], [-2, -1]];
	while(true){
		//извън рамките на масива 
		if(row >= rows || col >= cols || row < 0 || col < 0){
			console.log("Go go Horsy! Collected " + points + " weeds");
			break;
		} 

		//били ли сме в дадена клетка
		if(used[row + ' ' + col]){
			console.log("Sadly the horse is doomed in " + moves + " jumps ");
			break;
		}

		moves = moves + 1;
		points = points + getPoints(row, col);
		var move = horseMoves[getValue(params, row, col) - 1];
		used[row + ' ' + col] = true;
		row += move[0];
		col += move[1];
	}				  	
}
// 3 5 е реда и колоната
console.log(solve(['3 5', '54561', '43328', '52388']));
//console.log("Go go Horsy! Collected 1 weeds");   
console.log(solve(['3 5', '54361', '43326', '52188']));  
//console.log("Sadly the horse is doomed in 7 jumps ");