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