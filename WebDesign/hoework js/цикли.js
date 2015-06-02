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


//масиви
var arr0 = new Array(1,2,3,4);
var arr1 = [];
var arr2 = [[1,2,3], [4,5,6], 7];
var arr = new Array(6);//прави ми масив с 6 елемента
var arr22 = new Array('6');//прави ми масив с 1 елемент със стойност стринга 6
//правилния начин да запълним масив с 15 празни елемента
var count = 15;//дори и да сложим var count = '15';, пак резултата ще е същия
var arr = [];
arr[count-1] = undefined;
console.log(arr);
//ако искаме да принтираме определен индекс
var arr8 = [1,2,3];
console.log(arr8[1]);//и ни принтира 2(2) елемент
//може да променим стойност
arr8[1] = 'Two';
console.log(arr8[1]);

//обръщане на масив
var reversed,
i,
len,
numbers = [1,2,3,4,5,6];
reversed = [];
for(i = 0, len = numbers.length; i < len; i += 1){
        //reversed.push(numbers[len-i-1]);
        //по препоръчителния начин
        numbers[i] = numbers[len-i-1];
}
console.log(numbers);
console.log(reversed);

// /*globals console -  за да спре да ни показва грешки*/
// //масив и показване на квадратите с друг масив
// var squares = [],
// i,
// len,
// numbers = [1,2,3,4,5,6,7,8,9];
// for(i = 0, len = numbers.length; i < len; i += 1){
//       squares[i] = numbers[i] * numbers[i]; 
// }
// console.log(numbers);
// console.log(squares);

// //масив на всеки елемент да показва, на кой индекс е
// var i,
// len,
// count = 15,
// numbers = [];
// for (i = 0; i < count; i += 1){
//     numbers[i] = i;
//     //numbers[i] = i%2;
//     //numbers[i] = !!(i%2);
// };
// console.log(numbers);

// //for in цикъл
// var names = ['Gosho', 'Peter', 'John'],
// i;
// for(i in names) {
//     //изкарва ни индексите
//     console.log(i);
//     console.log(names[i]);
// }

// //с for in цикъла може да ходим по пропъртитата на обектите
// var obj = {
//     prop1: 2,
//     prop2: 6
// }, i;
// for (i in obj){
//     console.log(i, obj[i]);
// }

// //for of ни дава достъп до самите обекти
// var names = ['Gosho', 'Peter', 'John'],
// person;
// for(person of names){
//     console.log(person);
// }

// //всеки масив може да си променя постоянно рън тайм размера
// //push ни добавя елемент отзад
// //pop маха елемент най-отзад от масива и ни го връща като резултат от изпълнението
// var numbers = [],
// tail;
// console.log(numbers);
// numbers.push(3,4,5);
// numbers.push(6);
// // //малко извръщения :-)
// // [].push.apply(numbers, numbers);
// // console.log(numbers);
// console.log(numbers);
// tail = numbers.pop();
// console.log('Tail -> ' + tail);
// console.log(numbers);

// //unshift добавя елемент отпред
// var numbers = [],
// numbers1 = [];
// numbers.unshift(5);
// numbers.unshift(4);
// //unshift тук работи като push
// numbers1.unshift(5, 4);
// console.log(numbers);
// console.log(numbers1);

// //shift маха елемент отпред
// var numbers = [];
// numbers.unshift(5);
// numbers.unshift(4);
// console.log(numbers);
// console.log(numbers.shift());
// console.log(numbers);

// //методи на масивите
// //reverse 
// var numbers = [1,2,3];
// numbers.reverse();
// console.log(numbers);

// //join ни позволява да свържем елементите на един масив с някакъв стринг
// var numbers = [1,2,3],
// ul = '<ul><li>';
// console.log(numbers.join(', '));
// console.log(numbers.join('-------------'));
// console.log(numbers.join('Doncho'));
// ul += numbers.join('</li><li>');
// ul += '</li></ul>';
// console.log(ul);

// //конкатенация на масиви
// var numbers = [1,2,3],
// names = ['One', 'Two', 'Three'],
// //result = numbers.concat(names);
// //result = numbers.concat(names, names);
// //или по изчитения вариант
// result = [].concat(numbers, names);
// console.log(numbers);
// console.log(names);
// console.log(result);

// //slice - може да вземем част от масив и да получим друг масив, който е част от оригиналния масив
// var numbers = [1,2,3,4,5,6];
// console.log(numbers.slice(4));
// console.log(numbers.slice(2, 5));

// //масива е референтен тип
// var numbers = [1,2,3],
// copy = numbers;
// numbers[2] = 17;
// console.log(numbers);
// console.log(copy);
// //може да използваме slice, той ни прави шауоу копи на масива 
// var numbers = [1,2,3];
// //slice без параметри, получавам елементите, на масива без референцията, 
// //но резултата, който се получава в copy е нов масив(нова референция)
// //var copy = numbers.slice(); - може да се запише и така
// var copy = numbers.slice(0);
// numbers[2] = 17;
// //като го пуснем виждаме, че оригиналния се е променил, но копието си остава както си е било
// console.log(numbers);
// console.log(copy);
// //с -1 ни връща последния елемент, -2 последните два елемента, -10 ще ни върне трите елемента от масива
// console.log(numbers.slice(-1));

// //splice се използва за едновременно добавяне и изтриване на елементи посредата на масива
// var numbers = [1,2,3,4,5,6,7,8,9];
// //искам от третия индекс да ми изтриеш два елемента, след което да ми добавиш нови елементи от изтритото място нататък
// numbers.splice(3,2, 'Four', 'Five', 'Extra');
// console.log(numbers);
//връща като резултат масив от изтрите елементи
var numbers = [1,2,3,4,5,6,7,8,9];
console.log(numbers.splice(3,2, 'Four', 'Five', 'Extra'));
console.log(numbers);
//1:04:00































