// //стринга е нещо, което не се променя
// var text = 'Telerik students';
// //така текста не се променя
// text.replace('Telerik', 'Highschool');
// //за да го променим трябва да напишем
// //text = text.replace('Telerik', 'Highschool');
// //или
// var result = text.replace('Telerik', 'Highschool');
// console.log(text);
// console.log(result);

// //string, който е обект (или казано по друг начин от референтен към примитивен тип)
// var primitiveStr = 'John',
// 	objectStr = new String('John');	
// 	//това ни показва, че е стринг
// console.log(typeof primitiveStr);
// //това ни показва как се е превърнал на обект, но е доста бавно
// console.log(typeof objectStr);

// //а от обект към стринг (или казано по друг начин от примитивен към референтен тип) 
// var primitiveStr = 'John',
// 	objectStr = new String(primitiveStr);
// 	primitiveStr = String(objectStr);
// 	console.log(typeof objectStr);
// 	console.log(typeof primitiveStr);

// //изкарва ни 4 индекс, но си е от тип стринг, не от тип чар, в javascript няма такъв тип
// var s = 'John';
// console.log(typeof s[3]);
// console.log(s[3]);
// //charAt работи като индексатора по същия начин
// console.log(s.charAt(2));

// //конкатенация
// var firstname = 'John',
// 	lastname = 'Ivanov',
// 	//fullname = firstname.concat(' ', lastname);
// 	fullname = firstname + ' ' + lastname;
// console.log(fullname);		

// //replace-ване на всички срещания
// var text = 'Telerik Telerik Telerik Telerik Telerik',
// 	//така replace-ва всички срещания(регулярни изрази се учи)
// 	//result = text.replace(/Telerik/g, 'T');
// 	result = text.replace('Telerik', 'T');
// 	//може да добавиме while и пак да изкара всички срещания, но  е по-бавно
// 	while(result.indexOf('Telerik') >= 0){
// 		result = result.replace('Telerik', 'T');
// 	}
// 	console.log(result);

// //метода search ни търси нещо спямо регулярен израз
//  var text = 'Telerik Telerik Telerik Telerik Telerik';
//  //искам, която и да е буква от A до z, като и малки и големи са валидни + значи да се повтаря поне един път
//  var result = text.search(/[A-z]+/);
//  //пускайки го на 0 индекс е намерило нещо такова
//  console.log(result);

// //indexOf - върни ми индекса на срещането на този подстринг от ляво на дясно
// var text = 'JavaScript is great',
// 	result = text.indexOf('is');	
// console.log(result);

// //indexOf може да приема и втори параметър 
// //искам да гледаш от дясно на тази позиция
// var text = ' is is is is is is ',
// 	index = text.indexOf(' is ');
// 	while(index >= 0){
// 		console.log('Found at ' + index);
// 		index = text.indexOf(' is ', index + 1);
// 	}	

// //дали дадено нещо е дума или не
// var word = 'is',
// 	index = text.indexOf(word),
// 	separators = [' ', ',', '.'],
// 	isWord = true,
// 	i,
// 	len;
// for(i = 0, len = separators.length; i < len; i += 1){
// 	if(i !== 0 && (text[index - 1] !== separators[i] ||
// 		text[index + word.length + 1] !== separators[i])){
// 		isWord = false;
// 	break;
// 	}
// }	

// //lastIndexOf
// var text = 'Gosho eeeee pich!',
// 	index = text.lastIndexOf('eee', 8);
// console.log(index);	

// //split
// var text = 'Gosho, ej toj eeeee pich!',
// 	//words = text.split(/[ ,]/g);//регулярен израз
// 	words = text.split('e').filter(function(word) {
// 		//!! прехвърля нашата стойност от true like или false like, към истинско true или false
// 		return !!word;
// 	});
// 	console.log(words);

// //trim
// var text = '    \n\tGosho, ej toj eeeee pich!    \t\n';
// console.log('----------------------------------');
// console.log(text);
// console.log('----------------------------------');
// console.log('----------------------------------');
// console.log(text.trim());
// console.log('----------------------------------');
// console.log('----------------------------------');
// console.log(text.trimRight());
// console.log('----------------------------------');
// console.log('----------------------------------');
// console.log(text.trimLeft());
// console.log('----------------------------------');

// //substr - искам от тази позиция да ми дадеш толкова на брой символа
// //substring - искам да ми дадеш подстринга от тази до тази позиция
// var text = 'Hello, I am John!';
// console.log(text.substr(7));
// //тук ни взима (4) толкова символи 
// console.log(text.substr(7, 4));
// //тък работи като substr
// console.log(text.substring(7));
// //тук ни казва от 7 до 16 символ
// console.log(text.substring(7, 16));
// //или започни от 5 индекс и ми покажи от 0 до 5 индекс
// console.log(text.substring(5, 0));

// //valueOf - метод, който други методи използват да вземат една стойност
// //при стринговете valueOf е безсмислено
// var text = 'John';
// console.log(text.valueOf());

//нещо като стрингбилдер
[].push('1', '2', '3');
//52:06