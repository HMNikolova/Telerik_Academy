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
//36:26