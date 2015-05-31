/*var i = 1,
	n = 10;
while (i <= n) {
	console.log(i);
	i += 1;
}*/

// var n = '10',
// 	sum = 0, 
// 	number = 1;
// n = +n;
// while(number <= n){
// 	sum += number;
// 	number += 1;
// }	
// console.log(sum);

// var n = '9',
// 	divider,
// 	maxDivider, 
// 	isPrime = true;
// 	n = +n;
// 	divider = 2;
// 	maxDivider = Math.sqrt(n);
// while(isPrime && divider <= maxDivider){
// 	isPrime = !!(n%divider);//n%divider, ако е 0, числото не е просто, !!(n%divider), а така се превръща 0 към false
// 	// if (!(n % divider)) { //n%divider е нещо различно от нула(!)
// 	// 	isPrime = false;
// 	// }
// 	divider += 1;
// }	
// if (isPrime){
// 	console.log('Prime');
// }
// else{
// 	console.log('Not prime');
// }

// var n = '170';
// var fact = 1;
// n = +n;
// do {
// 	fact *= n;
// 	n-= 1;
// }while(n);
// console.log(fact);

// //умножение на n * m
// var n = '3',
// 	m = '7',
// 	product = 1,
// 	//може да кажем само 
// 	//number = n;
// 	//но ако не знаем на колко са ни равни n и m, пишем долните три реда
// 	max = Math.max(n,m),
// 	min = Math.min(n,m),
// 	number = min;
// //с do - while цикъла (при него се изпълнява поне един път цикъла)
// do {
// 	product *= number;
// 	number += 1;
// }while(number <= max);
// console.log(product);
// //или само с while цикъл(при него може и да не се влезне в цикъл, това е единствената разлика м/у двата цикъла)	
// while(number <= max) {
// 	product *= number;
// 	number += 1;
// }
// console.log(product);

// //горния цикъл, представен с for цикъл
// var product2 = 1,
// 	n = '3',
//  	m = '7',
// 	max = Math.max(n,m),
// 	min = Math.min(n,m),
// 	number = min;
// for(number = min; number <= max; number += 1){
// 	product2 *= number;
// }	
// console.log(product2);

//три примера за безкраен цикъл
//for(;;)
//while(1){}
//do{}while(1);

////различен запис на for цикъл на едното място дава различен резултат
// var i,
// 	sum;
// for(i = 1, sum = 1; i<= 128; i *= 2, sum += i) {
// 	console.log('i = ' + i, 'sum = ' + sum);
// }	
// for(i = 1, sum = 1; i<= 128; sum += i, i *= 2) {
// 	console.log('i = ' + i, 'sum = ' + sum);
// }	
// for(i = 1, sum = 0; i<= 128; i *= 2) {
// 	sum += i;
// 	console.log('i = ' + i, 'sum = ' + sum);
// }	

// //повдигнато число на степен
// var power,
// 	number,
// 	result,
// 	i;
// 	number = 3.14;
// 	power = 4;
// 	result = 1;
// //ако number ни е степен на двойката, най-бързия начин да получим 2 на някоя степен
// //result = 1 << power;
// //ако имаме например
// //number = 4;
// //power = 4;
// //result = 1 << 2*power;
// for(i = 0; i < power; i += 1){
// 	result *= number;
// }
// console.log(result);


// //вложен for цикъл
// var i,j,
//   count = 5;
// for(i = 0; i < count; i += 1){
// 	for(j = 0; j < count; j += 1){
// 		console.log(i + ', ' + j);
// 	}
// }

// //триъгълник от числа
// var row,
// 	col,
// 	n = 5,
// 	line;
// for(row = 0; row < n; row += 1){
// 	line = '';
// 	for(col = 0; col <= row; col += 1){
// 		line += col + 1 + ' ';
// 	}
// 	console.log(line);
// }	

//принтиране на прости числа
// var n = '3',
// 	m = '100',
// 	product = 1,
// 	max = Math.max(+n,+m),
// 	min = Math.min(+n,+m),
// 	divider,
// 	maxDivider,
// 	isPrime,
// 	number;
// for(number = min; number <= max; number += 1){
// 	isPrime = true;
// 	divider = 2;
// 	maxDivider = Math.sqrt(number);
// 	while(isPrime && divider <= maxDivider){
// 		isPrime = !!(number % divider);
// 		divider += 1;
// 	}
// 	if(isPrime){
// 		console.log(number);
// 	}
// }

// //всички четирицифрени щастливи числа
// var a, b, c, d;
// for (a =1 ; a <= 9; a += 1) {
//     for (b = 0; b <= 9; b += 1)
//       for (c = 0; c <= 9; c += 1)
//         for (d = 0; d <= 9; d += 1)
//           if (a + b === c + d)
//             console.log(a + '' + b + '' + c + '' + d);
// }
// //или така
// var a, b, c, d;
// for (a = 1 ; a < 10; a++) {
//     for (b = 0; b < 10; b++){
//       for (c = 0; c < 10; c++){
//         d = a + b - c;
//           if (0 <= d && d <= 9 ){
//             console.log(a + '' + b + '' + c + '' + d);
//         	}
//     	}
// 	}
// }

// //всички комбинации в тотото 
// var i1, i2, i3, i4, i5, i6;
// for (i1 = 1; i1 <= 44; i1+=1)
//   for (i2 = i1 + 1; i2 <= 45; i2+=1)
//     for (i3 = i2 + 1; i3 <= 46; i3+=1)
//       for (i4 = i3 + 1; i4 <= 47; i4+=1)
//         for (i5 = i4 + 1; i5 <= 48; i5+=1)
//           for (i6 = i5 + 1; i6 <= 49; i6+=1)
//             console.log('{0} {1} {2} {3} {4} {5}',
//               i1, i2, i3, i4, i5, i6);

// //for in цикъл - използва се за обхождане на масиви и обекти
// var arr = ['One', 'Two', 'Tree'],
// i;
// for (i in arr){
// 	console.log(arr[i]);
// }

// var person = {
// 	name: 'Donco',
// 	age: 18
// },
// prop;
// for(prop in person){
// 	console.log(prop, person[prop]);
// }

// //for of цикъл - замества foreach цикъла
// var arr = ['One', 'Two', 'Tree'],
// i;
// for(i of arr){
// 	console.log(i);
// }
// //по същия начин, но с in във цикъла for in може да изкараме индексите на елементите
// for (i in arr){
// 	console.log(i);
// }





