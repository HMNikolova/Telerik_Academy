// var arr = [1,2,3];

// //console.log(arr.slice(1));
// var arrObj = {
// 	'0': 'One',
// 	'1': 'Two',
// 	'2': 'Three',
// 	length: 3
// };
// //искам да изпълни метода slice на масива,като навсякъде в slice, където има this, 
// //това this искам да ми представлява обекта arrObj
// //ако имаме параметри, например 0, се задават отзад
// //това е т.н. дъктайпинг в javascripts
// //t.e. slice метода за да работи,единственото,което му трябва е да има за this обект, който да има length
// console.log([].slice.call(arrObj, 0));

// //function конструктор
// function person (name,age) {
// 	console.log(name, age);
// }
// person('Gosho', 19);
// //функциите могат да се извикват и с new
// new person('Gosho', 19);

// function Peson (name, age) {
	
// }
// var p = new Peson();
// //което ще ми каже да р е от тип person
// //единственото смислено,което ни дава ООП
// console.log(p instanceof Peson);
// console.log('' instanceof Peson);

// function Peson (name) {
// 	this.name = name;
// }
// var p = new Peson('Goshko');
// var p1 = new Peson('Goshko1');
// console.log(p);
// console.log(p1);
// /16:16

