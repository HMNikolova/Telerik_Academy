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
// //връща като резултат масив от изтрите елементи
// var numbers = [1,2,3,4,5,6,7,8,9];
// console.log(numbers.splice(3,2, 'Four', 'Five', 'Extra'));
// console.log(numbers);
// //може и само да добавяме елементи без да ги триеме
// var numbers = [1,2,3,4,5,6,7,8,9];
// //numbers.splice(3,0, 'Four', 'Five', 'Extra');
// //с минус започваме отзад напред
// //numbers.splice(-6,0, 'Four', 'Five', 'Extra');
// //ако е написан по-голям индекс го слага най-отзад елемента, работи като push
// console.log(numbers.splice(17, 12, 'Extra'));
// console.log(numbers);
// //ако искаме да използваме insert
// function insertAt(numbers, pos, value) {
// 	numbers.splice(pos,0,value);
// }
// var numbers = [1,2,3,4,5,6,7,8,9];
// insertAt(numbers,3,'John');
// console.log(numbers);

// //indexOf - казва ни дадена стойност, на кой индекс се намира в масива
// //връща ни -1, ако елемента не бъде намерен
// function insertAt(numbers, pos, value) {
// 	numbers.splice(pos,0,value);
// }
// var numbers = [1,2,5,4,5,6,7,8,9];
// //console.log(numbers.indexOf(5));
// //търси го от 3-ти индекс нататък
// console.log(numbers.indexOf(5, 3));
//може да намерим всички срещания с един while 
// var numbers = [1,2,5,4,5,6,7,8,9], 
// index;
// index = numbers.indexOf(5);
// while(index >= 0) {
// 	console.log(index);
// 	index = numbers.indexOf(5,index + 1);
// }

// //lastIndexOf - търси от дясно на ляво, някои от методите не се поддържат от всички браузери
// //shiv, shim, polyfill - ако видя някои от думите, означава, че някаква функционалност, която не се поддържа от някакви браузери, за тази функционалност се пише код, с който да се поддържат тези браузери
// var numbers = [1,2,5,4,5,6,7,8,9], 
// index;
// //искам да провериш дали в масива, в неговия прототип има indexOf и ако го няма, направими функцията
// if(Array.prototype.indexOf){
// 	Array.prototype.indexOf = function(value, rightOf){
// 		var i,
// 		len;
// 		//ако rightOf не е подадено искам да започнеш от 0 елемент. Започни от rightOf(този параметър), ако е подаден, ако не е подаден това ще е undefined, ако rightOf е undefined(undefined е false like) съответно ще отиде към 0 и ще получи стойност 0
// 		//подобно нещо трябва да имаме и за lastIndexOf, но в обратен ред
// 		for(i = rightOf || 0, len = this.length; i < len; i += 1){
// 			if(this[i] === value){
// 				return i;
// 			}
// 		}
// 		return -1;
// 	}
// }

// //ако изпълним оператора typeOf върху масив ни дава като резултат object
// console.log(typeof([]));

// //типовете в javascript са 6 - undefined, null, boolean, number, string и object
// //ако искаме да проверим типа на една променлива, която е масив
// var arr = [];
// console.log(Array.isArray(arr));
// console.log(Array.isArray([]));
// console.log([] instanceof Array);
// //долните два реда показват, че работи правилно за масив
// console.log(Array.isArray({}));
// console.log(Array.isArray(5));

//разликата кога получаваме undefined
// var numbers = [1,2];
// //тук резултата е undefined
// console.log(numbers[5]);
// numbers[5] = undefined;
// //а тук резултата е масив
// console.log(numbers);

//матрица
var matrix = [],
rows = 5, 
cols = 3,
count = 1,
row,
col;
for(row = 0; row < rows; row += 1){
	matrix.push([]);
	for(col = 0; col < cols; col += 1){
		matrix[row][col] = count;
		count += 1;
	}
}
console.dir(matrix);





//има 3 начина да си направим функция 
// //1.конструктор
// var f = new Function('console.log("Hello")'); 
// f();
// //има 2 функции, с които може да се хаква
// var body = 'hackYou()';
// var f = new Function(body);
// f();
// //eval е втората(прави същото като функция) - тя ни позволява да подадем като стринг, javascript код, който искаме да се изпълни
// var body = 'hackYou()';
// var f = new Function(body);
// eval('console.log("Hacked!")');

//2.declaration - казваме името и кръглите скоби и body-то
fDeclaration();
function fDeclaration(){
	console.log('declaration');
}
//3.expression - правим си функцията, само че я присвояваме на променлива
var fExpression = function(){
	console.log('expression');
}

// function print(){
// 	var i,
// 	count = 5;
// 	for(i = 0; i < count; i += 1){
// 	console.log('Hello!!!' + i);
// 	}
// }
// print();
//12:00
