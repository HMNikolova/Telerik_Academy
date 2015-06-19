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

// //2.declaration - казваме името и кръглите скоби и body-то
// fDeclaration();
// function fDeclaration(){
// 	console.log('declaration');
// }
// //3.expression - правим си функцията, само че я присвояваме на променлива
// var fExpression = function(){
// 	console.log('expression');
// }

// function print(){
// 	var i,
// 	count = 5;
// 	for(i = 0; i < count; i += 1){
// 	console.log('Hello!!!' + i);
// 	}
// }
// print();

// //функция с параметър
// function printSign(number){
// 	console.log(number);
// 	if(number > 0){
// 		console.log('+');
// 	} else if(number < 0) {
// 		console.log('-');
// 	}else{
// 		console.log('0');
// 	}
// }
// // printSign(5);
// // printSign(-5);
// // printSign(0);
// printSign();

// function sum(x,y,z){
// 	console.log(x+y+z);
// }
// sum(1,2,3);

// function sum(x,y){
// 	console.log(x+y);
// }
// function performOperation(operation){
// 	operation(2,3);
// }
// //подавам функцията sum отгоре, като параметър в функцията performOperation, който мога да изпълня 
// performOperation(sum);

// x();
// function x(){
// 	console.log('X');
// 	y();
// 	function y(){
// 		console.log('Y');
// 		z();
// 		function z(){
// 			console.log('Z');
// 		}
// 	}
// }

// function printMax(x,y){
// 	var max = x;
// 	if(max < y){
// 		max = y;
// 	}
// 	console.log('Max element is ' + max);
// }
// printMax(5,2);
// printMax('Two', 'One');

// function printArray(numbers){
// 	var number;
// 	for (number of numbers) {
// 		console.log(number);
// 	}
// }
// printArray([1,2,3]);
// printArray([1,2,3,4,5,6]);

// //триъгълник
// function printLine(n){
// 		var i,
// 		result = '';
// 		for(i = 1; i <= n; i += 1){
// 			result += i + ' ';
// 		}
// 		console.log(result);
// 	} 
// function printTriangle(n){
// 	var row;
// 	for(row = 1; row <= n; row += 1){
// 		printLine(row);
// 	}
// 	for(row = n - 1; row >= 1; row -= 1){
// 		printLine(row);
// 	}
// }
// printTriangle(5);

// //arguments object - обект, който ни дава достъп до всички параметри, които ние подаваме на нашата функция
// function f(x){
// 	//arguments - изглежда като масив, но не е масив и много бавен
// 	 console.log(arguments[0]);
// 	 console.log(arguments[1]);
// 	 console.log(arguments[2]);
// 	//callee - като го пуснем ни дава самата функция
// 	console.log(arguments.callee);
// 	console.log(arguments.callee === f);
// 	//как прехвърляме arguments към масив
// 	//казва ни искам да приложиш метода slice, който идва от масива и да го приложиш на arguments, и тъй като arguments има length, slice ни го превръща в масив
// 	var args = [].slice.apply(arguments);
// 	//резултата ни показва, че първото е false, а args връща true
// 	console.log(Array.isArray(arguments),
// 				Array.isArray(args));
// 	console.log(arguments.length);
// }
// f(1,2,3);

// //метода slice не се интересува върху какво се изпълнява, интересува го да има някакви пропъртита и обекта, върху който се изпълнява има ли пропъртито length то е ок
// //var arr = [].slice.call({length: 5});
// function f(x){
// 	var args = [].slice.apply(arguments);
// 	console.log(args);
// }
// f(1,2,3);

// //абсолютно всяка функция връща стойност
// function sum(){
// 	var number,
// 	s = 0,
// 	args = [].slice.apply(arguments);
// 	for(number of args){
// 		s += number;
// 	} 
// 	return s;
// }
// var result = sum(1,2,3,4);
// console.log(result);

//ако нещо трябва да го направим === 0, не го правим ами слагаме ! отпред
//number % divider === 0//така не се прави
//!(number % divider)//а така

// //как да изкарам рандом число
// function getRandomValue(min, max){
// 	//използваме с двата if хак
// 	if(min == null){
// 		//give to min
// 		min = 0;
// 		max = 100;
// 	}
// 	else if(max == null){//това е съкратен запис на max === undefined || max === null
// 		//give value to max
// 		max = min;
// 		min = 0;
// 	}
// 	//връща ни  рандом число в този интервал, ( | 0) цялото нещо направено към интиджър
// 	return (Math.random() * (max - min) + min) | 0;
// }
// //връща ми рандом цяло число
// console.log(getRandomValue());
// //значи че мах е 10
// console.log(getRandomValue(10));
// //рандом число между 10 и 15
// console.log(getRandomValue(10, 15));

// //по-добрия начин как да изкарам рандом число
// function getRandomValue(options){ 
// 	//ако options е undefined всима празния обект
// 	options = options || {};
// 	var min = options.min || 0,
// 	max = options.max || 100;
// 	return (Math.random() * (max - min) + min) | 0;
// 	}
// 	console.log(getRandomValue());
// 	console.log(getRandomValue({min: 0, max: 10}));
// 	console.log(getRandomValue({min: 10, max: 15}));

// //екма скрипт 6
// var f = (msg) => console.log('Message: ' + msg);
// function f1(msg){
// 	console.log('Message: ' + msg);
// }

// //babel не се поддържа още навсякъде
// var f = (msg) => console.log('Message: ' + msg);
// f('Hello');


