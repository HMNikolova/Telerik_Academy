//когато имаме хардкоднато предефинирано нещо
// var regex = 'text';
// regex = /sadad/;
// console.log(regex);

// //ако искаме нещо, което взима променлива
// var pattern = 'Gosho';
// //искам да проверя дали това нещо започва с подадения патърн
// var regex = new RegExp('^' + pattern);

// var pattern = /Telerik/;
// var text = 'This is Telerik';
// //test е единствения метод, който се изпълнява върху рег.израз и приема параметър текст всички останали се изпълняват върху стринг
// //test се ползва за булева проверка дали дадена дума я има в текст
// console.log(pattern.test(text));


// //match е метод, който очаква RExspresion и търси на базата на този RExspresion
// var pattern = /Telerik/;
// var text = 'This is Telerik';
// //хубаво е първо да си го кръщаваме
// var matches = text.match(pattern);
// console.log(matches);

// //флага /g търси всички срещания
// var pattern = /Telerik/g;
// var text = 'This is Telerik Telerik Telerik Telerik';
// console.log(text.match(pattern));

// //така ще ни намери целия текст
// var pattern = /[A-z]+/g;
// //var pattern = /[a-z]+/g;
// var text = 'This is Telerik Telerik Telerik Telerik';
// console.log(text.match(pattern));

// ///i казва че търсенето е case insensitive, търси ми всичко независимо дали са написани с малки или с голями букви
// var pattern = /TELERIK/gi;
// var text = 'This is Telerik Telerik Telerik Telerik';
// console.log(text.match(pattern));

//m - multi-line search - търси на всички редове
// var pattern = /TELERIK/igm;
// var text = 'This is Telerik Telerik Telerik Telerik';
// console.log(text.match(pattern));

// //replace - replace-ва всички срещания на патърна от р.израз с текста, който аз му подавам
// var pattern = /Tel/g;
// var text = 'This is Telerik Telerik Telerik Telerik';
// console.log(text.replace(pattern, 'Gosho'));
// console.log(text.replace(/Tel/g, 'Gosho'));

// //split
// //изброявам символите, по които искам да се разделя
// //тирето в pattern трябва да се ескейпва така: \-
// //[ ,.!\-_";'] - поне един от символите,които са оградени в квадратните скоби
// var pattern = /[ ,.!\-_";']/g;
// var text = 'This is Telerik Telerik Telerik Telerik';
// //с филтър може да махнем празните стрингове
// var words = text.split(pattern)
//             .filter(function(word){
//                 return !!word;
//             });
// console.log(words);

// //search ни търси стринг, но ни връща индекса на мястото, където сме го намерили
// var pattern = /Tel/g;
// var text = 'This is Telerik Telerik Telerik Telerik';
// var words = text.search(pattern);
// console.log(words);

//a* - търся да го има 0 или повече пъти
//+ казва искам нещо да го има поне 1 път
//? мачва символа преди нея да се повтаря 0 или 1 пъти 
//*? и +? не са толкова лакоми
// . значи намери ми всички символи 
//.* намира целия текст

// var pattern = /.*/g;
// var text = 'This is Telerik Telerik Telerik Telerik';
// var words = text.match(pattern);
// console.log(words);

// // | казва искам или това или това
// var pattern = /Tele|emy/g;
// //var pattern = /[TAe]/g;
// // pattern = /T|A|e/g;
// var text = 'This is Telerik Telerik Telerik Telerik';
// var words = text.match(pattern);
// console.log(words);

//^ искам да ми дадеш символите, които не са измежду тези символи
//^ в квадратни скоби нито един от тези символи
//^ /^ значи начало в слашове/

//[^A-z]{3} искам от A-z да се среща точно 3 пъти
//[^A-z]{2,4} искам от A-z да се среща между 2 и 4 пъти (символите)
//[^A-z]{3,} искам от A-z да се повтаря поне 3 пъти

//специални символи за групиране на общи черти
// \s мачва single white space, което включва спейс, нов ред, таб
// \S мачва всичко, което не е white space
// \d ми мачва цифри, абсолютно еквивалентно на [^\D]
// \D ми мачва всичко, което не е цифра, абсолютно еквивалентно на [^\d]
// \w ми мачва всички цифри, букви и долна черта
// \W ми мачва всичкО, което не е цифри, букви и долна черта

// //m казва всеки ред е нов текст
// //^ ще значи не началото на текста, а началото на реда и съответно $ няма да значи края на текста, а края на реда
// var pattern = /^Telerik/gm;
// var text = 'Telerik\nTelerik';
// var words = text.match(pattern);
// console.log(words);

//() групира
var pattern = /(\w+) (\w+)/g;
var text = 'Telerik Academy';
//така обърнахме думите
var words = text.replace(pattern, '$2 $1');
console.log(words);









