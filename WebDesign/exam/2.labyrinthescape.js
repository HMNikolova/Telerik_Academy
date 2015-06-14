function solve(args){
	//разделени по спейс
	var sizes = args[0].split(' '),
	//броя редове
	rows = parseInt(sizes[0]),
	//броя колони
	cols = parseInt(sizes[1]),
	//1 3 - ред и колона
	startPosition = args[1].split(' '),
	row = parseInt(startPosition[0]),
	col= parseInt(startPosition[1]),
	lab = args.slice(2),
	visited = {},
	sum = 0,
	count = 0,
	//измененията в обектите
	directions = {
		u: {
			row: -1,
			col: 0
		} ,
		r: {
			row: 0,
			col: +1
		} ,
		d: {
			row: +1,
			col: 0
		} ,
		l: {
			row: 0,
			col: -1
		} 
	};
	//формула на матрицата
function getValueAt(row, col, cols){
	return row * cols + col + 1;
}

function inRange(value, border){
	//ако е между тези две стойности значи е в рейндж
	return 0 <= value && value < border;
}

while(true){
	//дали сме извън лабиринта
	if(!inRange(row, rows) || !inRange(col, cols)){
		//изкарваме сумата
		return 'out ' + sum;
	}
	//дали клетка е посетена
	if(visited[cellValue]){
		return 'lost ' + count;
	}

	var cellValue = getValueAt(row, col, cols);
	sum += cellValue;
	count++;
	//правим пропърти във визетед обекта, което е с ключ и стойност
	//раазбираме дали клетката ни е посетена
	visited[cellValue] = true;

	//проверяваме каква ни е посоката в която сме в момента
	var dir = lab[row][col];
	//update на row независимо от посоката
	row += directions[dir].row;
	col += directions[dir].col;
	
}

} 
var test = [
 "3 4",
 "1 3",
 "lrrd",
 "dlll",
 "rddd"];
 console.log(solve(test));

