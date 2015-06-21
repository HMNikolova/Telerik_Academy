// //долните две са едно и също
// //global.arrJoin =
// //window.arrJoin =
// function arrJoin (arr, separator) {
// 	var i,
// 	len,
// 	result = '';
// 	for(i = 0, len = arr.length; i < len; i += 1){
// 		result += arr[i];
// 		if(i !== len - 1){
// 			result += separator;
// 		}
// 	}
// 	return result;
// }
// console.log(arrJoin([1,2,3], '-'));
 
 //кое ще се изпълни - втория принт
// function print () {
// 	console.log('File 1');
// }
// function print () {
// 	console.log('File 2');
// }
// print();

// //второто презаписва първото, защото и двете отиват в глобалния сколп и получаваме грешка
// var obj = {
// 	print: function() {
// 		console.log('File 1');
// 	}
// };
// var obj = {
// 	name: 'Gosho'
// };
// obj.print();

// //така мога да достъпя и 6 и 5
// var x = 6;
// function useless() {
// 	var a = 5;
// 	console.log(x, a);
// }
// useless();

// //в if мога да достъпя променлива вътре в if-a
// if(true){
// 	var x = 5;
// }
// console.log(x);

// //тук обаче ще получим undefined
// if(false){
// 	var x = 5;
// }
// console.log(x);

// //няма проблем да имаме променлива с едно и също име на няколко места
// //при iife кода се изпълнява веднага и затова резултата е:innermost,inner,global
// var x = 'global';
// (function() {
// 	var x = 'inner';
// 	(function() {
// 		var x = 'innermost';
// 		console.log(x);
// 	}());
// 	console.log(x);
// }());
// console.log(x);

// //ако разместим console.log(x);, ще ни принтира: inner,innermost,global -> резултата е такъв, защото iife-то се изпълнява веднага
// var x = 'global';
// (function() {
// 	var x = 'inner';
// 	console.log(x);
// 	(function() {
// 		var x = 'innermost';
// 	}());
// 	console.log(x);
// }());
// console.log(x);

// //let ни прави блок скоуп
// if(true){
// 	var withVar = 'with var';
// 	let withLet = 'with let';
// }
// console.log(withVar);
// console.log(withLet);

// //closures - ни дават възможност ние от една функция да достъпваме стойности, които са над нейния скоуп
// //използва се често когато правим модули
// function outer (x) {
// 	return function inner (y) {
// 		return x + ' ' + y;
// 	};
// }
// var f1 = outer(5);	
// console.log(f1(6));
// var f2 = outer('Goshko');
// console.log(f2('Ivanov'));
// console.log(f2('Goshkov'));

// //module
// var db = (function(){
// 	function add (obj) {
// 		console.log('Adding ' + obj);	
// 	}
// 	function list () {
// 		console.log('Listing');
// 	}
// 	return { 
// 		add: add,
// 		list: list
// 	};
// }());
// db.add('Goshko');


// //closures, който има closures...
// var db = (function(){
// 	var objs = [],
// 		result;
// 	function add(obj) {
// 		objs.push(obj);
// 		return result;	
// 	}
// 	function list() {
// 		//тук slice() ни защитава кода от хакери
// 		return objs.slice();
// 	}
// 	result = { 
// 		add: add,
// 		list: list
// 	};
// 	return result;
// }());
// // console.log(db.list());
// // db.add('Goshko');
// // console.log(db.list());
// // var objs = db.list();
// // objs[0] = 'Penka';
// // console.log(db.list());
// console.log(db.add('Goshko').add('Penka').list());

//module е едно iife, което връща обект и този обект прави куожъри с някакви функции. Когато кода връща нещо е модул.
var sum = (function() {
	return function(arr) {
		return arr.reduce(function(s, n){
			return s + n;
		},0);
	};
}());
console.log(typeof(sum));
console.log(sum([1,2,3]));









