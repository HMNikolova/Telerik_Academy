function solve(args){
	//трябват ни редовете и колоните и да ги сплитнем по спейс
	var rowsCols = args[0].split(' '),
		bounds = {
			//това са стрингове и трябва да ги парсна към число
			rows: +rowsCols[0],
			cols: +rowsCols[1]
		},
		//казвам махни ми първия ред от масива
		matrix = args.slice(1)
		.map(function(line){
			//'dr dl dr ur ul'
			//->
			//['dr', 'dl', 'dr', 'ur', 'ul']
			return line.split(' ');
		}),
		row = 0,
		col = 0,
		sum = 0,
		dir,
		//правим си обект и казваме при u: реда се изменя с -1, при down реда се изменя с +1, при left колоната се изменя с -1, и при right колоната се изменя с +1
		deltas = {
			u: -1,
		    d: +1,
			l: -1,
			r: +1
		},
		leftRight,
		upDown,
		used = {},
		key;
		while(1){
			// //проверка дали нещо излиза от матрицата
			// if(row < 0 || row >= bounds.rows ||
			// 	col < 0 || col >= bounds.cols){
			if(!matrix[row] || !matrix[row][col]){
				//ако това се случи значи сме извън матрицата и искам да ми върнеш
				return 'successed with ' + sum;
			}
			//определяме си всяка клетка
			key = row + ';' + col;
			//if(matrix[row][col] === 'used'){
				//ако имаме used от key значи вече сме го посетили
			if(used[key]){	
				return 'failed at (' + row + ', ' + col + ')';
			}
			used[key] = true;

			//избутай ми един бит налява с row клетки (умножи го по 2 на степен row) 2^0 + колоната например(4)
			//може да се запише и така
			//sum += Math.pow(2, row) + col
			sum += (1<<row) + col;
			
			//update на посоката - дай ми посоката, която се намира на текущата клетка, на която аз се намирам
			//трябва на базата на тази посока да си ъпдейтнем row и col
			dir = matrix[row][col];
			// //като е проверено че не е стъпено на клетката
			// matrix[row][col] = 'used';
			upDown = dir[0];
			leftRight = dir[1];
			//update на реда
			row += deltas[upDown];
			//update на колоната
			col += deltas[leftRight];
		}
		return matrix;
}
var tests = [
	[
  	'3 5',
  	'dr dl dr ur ul',
  	'dr dr ul ur ur',
  	'dl dr ur dl ur'   
	],
	[
  	 '3 5',
 	 'dr dl dl ur ul',
     'dr dr ul ul ur',
     'dl dr ur dl ur'   
	]

];
tests.forEach(function(test){
console.log(solve(test));
});