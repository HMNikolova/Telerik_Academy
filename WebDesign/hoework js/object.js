// //var obj = {};//така описваме обект
// console.log(typeof 5);
// console.log(typeof 'string');
// console.log(typeof true);
// console.log(typeof null);//изкарва object, но типа си е null
// console.log(typeof undefined);
// console.log(typeof []);
// console.log(typeof new Date());
// console.log(typeof NaN);
// console.log(3.145646264564864.toFixed(2));
// console.log(NaN.toFixed(2));

// //n е от прмитивен тип
// function changeValue(number){//подсъзнателно си създаваме n`
// 	number = 5;
// 	//n` = 5;
// }
// var n = 15;
// changeValue(n);//var n` = n;
// console.log(n);

// var fname = 'Peter',
// 	lname = 'Ivanov';
// var person = {
// 	firstName: fname,//подсъзнателно си създаваме fname` = fname, firstName = fName`
// 	lastName: lname
// };	
// //тук резулата си остава Ivanov
// //lname = 'Petrov';
// //console.log(person.lastName);
// // person.lastName = 'Petrov';
// // console.log(lname);

// //референтен тип И JSON обектите
// var fname = 'Peter',
// 	lname = 'Ivanov',
// 	marks = [{
// 		subject: 'Math',
// 		mark: 5.5
// 	},{
// 		subject: 'C#',
// 		mark: 3.5
// 	}];
// var person = {
// 	firstName: fname,
// 	lastName: lname,
// 	marks: marks,
// 	hair: {
// 		//нестнати обекти
// 		color: 'blond',
// 		type: 'curly',
// 		//вътрешните обекти също могат да имат функции
// 		toString: function(){
// 			return this.color + ' ' + this.type;
// 		}
// 	},
// 	fullname: function personFullname(){
// 	return this.firstName + ' ' + this.lastName;
// },
// 	getFinalScore: function getFinalScore(){
// 	var score = 0;
// 	for(var i = 0; i < this.marks.length; i += 1){
// 		score += this.marks[i].mark;
// 	}
// 	return score / this.marks.length;
//     }
// };	
// // //променям масива marks
// // marks.push({
// // 	subject: 'JS',
// // 	mark: 6.0
// // });
// // //принтирам marks пропъртито на person обекта
// // console.log(person.marks);
// // //както се вижда по горе в обект може да сложим и функции
// // console.log(person.fullname());
// // console.log(person.getFinalScore()); 
// // console.log(person.marks);
// // //как да достъпим нестнато пропърти
// // console.log(person.hair.type);
// // //принтирай ми функцията от вътрешния обект
// // console.log(person.hair.toString());	

// //правим си билд функция s JSON обект, с която може да си генерираме много наброй обекти
// function buildPerson(fname, lname, hairColor, hairType){
//  var person = {
// 	firstName: fname,
// 	lastName: lname,
// 	hair: {
// 		color: hairColor,
// 		type: hairType,
// 		//вътрешните обекти също могат да имат функции
// 		toString: function(){
// 			return this.color + ' ' + this.type;
// 		}
// 	},
// 	fullname: function personFullname(){
// 	return this.firstName + ' ' + this.lastName;
//     },
// 	getFinalScore: function getFinalScore(){
// 	var score = 0;
// 	for(var i = 0; i < this.marks.length; i += 1){
// 		score += this.marks[i].mark;
// 	}
// 	return score / this.marks.length;
//     }
//  };
//  return person;
// }
// var personDoncho = buildPerson('Doncho', 'Minkov', 'brown', 'straight');
// var personPeter = buildPerson('Peter', 'Ivanov', 'blond', 'curly');
// // console.log(personDoncho.fullname());
// // console.log(personPeter.fullname());
// //тип person - единствено тук пишем функция Person с главна буква и задължително при извикване трябва да сложим new Person
// function Person(fname, lname, hairColor, hairType){
// 	//как мога да му запазя параметрите (fname, lname, hairColor, hairType)
// 	this.firstname = fname;
// 	this.lastname = lname;
// 	this.hair = {
// 		type: hairType,
// 		color: hairColor
// 	};
// 	//как закачам функции
// 	this.fullname = function(){
// 		return this.firstname + ' ' + this.lastname;
// 	}
// }
// var personDoncho2 = new Person('Doncho', 'Minkov', 'brown', 'straight');
// console.log(personDoncho2.fullname());
// //това ми връща true, защото аз така съм си направил типа person
// console.log(personDoncho2 instanceof Person);

// //пропъртита на обекта
// var obj = {
// 	name: 'the name',
// 	'Gosho-e pich': 3
// };
// //console.log(obj.name);
// //еквивалентен запис на горния, вместо точка ползваме ['']
// console.log(obj['name']);

//пропъртита на console.log
for(var prop in console){
	console.log(prop + ' -> ' + console[prop]);
}
//59:20