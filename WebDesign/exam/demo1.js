function solve (params) {
	var args = params[0].split(' ').map(Number);
	args.push(0);
	args.unshift(0);
	var count = 0, 
		bestCount = 0,
		index,
		tempIndex;
		for(var i = 0; i < args.length; i++){
			if(args[i] > args[i + 1] && args[i] > args[i - 1]){
				index = i;
				count = index - tempIndex;
				if(bestCount < count){
					bestCount = count;
				}
			}
			tempIndex = index;
		}
		return bestCount;
}
console.log(solve(['5 1 7 4 8']));   
console.log(solve(['5 1 7 6 3 6 4 2 3 8']));  
console.log(solve(['10 1 2 3 4 5 4 3 2 1 10'])); 