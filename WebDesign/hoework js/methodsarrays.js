// //дали числата от масива са четни
// //var arr = [1,2,3,4,5,6];
// var arr = [2,4,6];
// //every връща true единствено и само ако всеки от елементите изпълнява това условие, достатъчно е един елемент да не изпълнява условието и резултата ще е false
// var result = arr.every(function(number, index){
//     console.log(number);//число
//     console.log(index);//на кой индекс е
//     return !(number % 2);
// });
// console.log(result);

// //изнасяне на функцията отвън(лошото е че се вижда и от глобалния сколп), ако я ползваме само тук, по-добре е горния вариант
// var arr = [2,4,6];
// function isEven(number, index){
//     return !(number % 2);
// }
// var result = arr.every(isEven);
// console.log(result);

// //some - ако поне един от елементите на масива изпълнява това условие
// var arr = [1,2,3,4,5,6];
// //var arr = [1,3,5];//тук ще ни върне false
// //функцията в some подава винаги като първи параметър числото, като втори параметъ индекс, и накрая масив
// var result = arr.some(function(number, index, arr){
//     console.log('--------------------------');
//     console.log(number);
//     console.log(index);
//     console.log(arr);
//     console.log('--------------------------');
//     return !(number % 2);
// });
// console.log(result);

// //filter е аналогично на where от C#
// //filter връща нов масив, който пази елементите, които изпълняват условието
// var arr = [1,2,3,4,5,6];
// var result = arr.filter(function(item, index){
//  //return !(item % 2);
//  //ако искам нечетните слагам още един !
//  //return !!(item % 2);
//  //може да кажа да са по-големи от 3
//  return index > 3 && !!(item % 2);
// });
// console.log(result);

// //дали едно число е просто
// var arr = [1,2,3,4,5,6,7,8,9,10];
// function isPrime(number){
//     var divisor,
//     maxDivisor = Math.sqrt(number);
//     for(divisor = 2; divisor <= maxDivisor; divisor += 1){
//         if(!(number % divisor)){
//             return false;
//         }
//     }
//     return number > 1;
// }
// var result = arr.filter(isPrime);
// console.log(result);

// //функция, която връща функция
// var numbers = [1,2,3,4,5,6,7,8];
// // function inRange(number){
// //     return 2 < number && number < 6;
// // }
// function inRange(from, to){
//     return function(number){
//         return from < number && number < to;
//     }
// }
// //var result = numbers.filter(inRange);
// var result = numbers.filter(inRange(3,5));
// var result1 = numbers.filter(inRange(2,6));
// console.log(result);
// console.log(result1);

// //reduce - взима целия масив и от този масив връща един резултат, като резултата е от тип обект
// var numbers = [1,2,3,4,5,6,7,8];
// //на функцията първи параметър текуща сума, като втори параметър съответното число, а втория парамаетър на reduce 0
// var sum = numbers.reduce(function(s, number){
//     return s + number;
// }, 0);
// console.log(sum);

// //записано по друг начин
// var numbers = [1,2,3,4,5,6,7,8];
// function nextSum(s, number){
//     return s + number;
// }
// //reduce казва следното: започвайки от обекта 0, подавай го за всеки елемент като първи параметър на колпбека текущото му и като втори параметър подай съответния елемент от масива и аз очаквам като резултат ти да ми върнеш нещо
// var sum = numbers.reduce(nextSum, 0);
// console.log(sum);

// //може да го направим и с умножение на сума
// var numbers = [1,2,3,4];
// function nextSum(s, number){
//     return s * number;
// }
// var sum = numbers.reduce(nextSum, 1);
// console.log(sum);

// //сумираме на четните числа
// var numbers = [1,2,3];
// function nextSum(s, number){
//     if(!(number % 2)){
//     s *= number;
//     }
//     return s;
// }
// var sum = numbers.reduce(nextSum, 1);
// console.log(sum);
// //еквивалентен запис на горния
// var numbers = [1,2,3];
//  function nextSum(s, number){
//   if(!(number % 2)){
//     s *= number;
//   }
//   return s;
// }
// var sum2 = numbers.filter(function(number){
//     return !(number % 2);
// }).reduce(nextSum, 1);
// console.log(sum2);

// //в item получаваме всеки елемент от масива
// var numbers = [1,2,3,4];
// var sum = numbers.reduce(function(s, item){
//     return s + item; 
// }, '');
// console.log(sum);

// //флапване на масиви - може да го направим с reduce
// //това работи за две нествания при трето не работи
// //искам от масива arr да ходиш по всеки от елементите му и казва 1, 1 идва в item, item арей ли е, не, тогава отиваме надолу и го push-ваме
// //после към празния масив, който се записва в r, сложи 1, после отиди към следващо, следващия елемент ми е масива 2,3, той се записва в item, a r представлява
// //r = [1], казва масива 2,3 //item = [2,3], масив ли е, да масив е, пращам го към r и накрая връщам r, резултата на r e r = [1,2,3], отива към 4,5,6, това масив ли е, 
// //item = [4,5,6], масив е, тогава го конкатенирай
// var arr = [1, [2,3],
//      [4,5,6]
// ];
// var arr2 = [1,2,3,4,5,6];
// var result = arr.reduce(function(r, item){
//     if(Array.isArray(item)){
//         //знаем че item е масив и concat долепя задния масив до предишния
//         r = r.concat(item);
//     }
//     else{
//         r.push(item);
//     }
//     return r;
// }, []);
// console.log(result);

// //полезно за изпита
// //array map -минава по всеки от елементите на база на стойността на елемента връща някакъв резултат
// var str = '1 2 3 4 5 6 7 8';
// //какъв е най-лесния начин от тези числа да получа масива numbers
// //var numbers = [1,2,3,4,5,6,7,8];
// //първо ги сплитвам
// //var numbersStr = str.split(' ');
// //минаваме по всеки елемент с един for цикъл и ги кастваме
// //по-лесния начин е да кажем долното, за да може от стринг с числа, да получим масив, където имаме тези числа
// var numbers = str.split(' ').map(Number);
// console.log(numbers);

// var str = '1 2 3 4 5 6 7 8';
// var numbers = [1,1,1,1,1,1].map(function(){
//     //искам да ми направиш масив от 6 елемента и за всеки елемент да ми върнеш Math.random
//     return Math.random();
// });
// console.log(numbers);

// //map е като select в C# - вземи ми елемента и на база на този елемент ми върни нещо
//  var str = '1 2 3 4 5 6 7 8';
//  var numbers = [1,2,3,4,5].map(function(item){
//      return item % 3;
//  });
//  console.log(numbers);

// //дава ми грешка
//  var str = '1 2 3 4 5 6 7 8';
//  var numbers = [1,2,3,4,5].map(function(item, index){
//     return 'numbers[' + index + ']= ' item;
//  });
//  console.log(numbers);

// //от масива с 5 числа искам да получа 5 човека
// //[1,2,3,4,5] - масив от 5 елемента, искам с map за всеки от тези елементи
// //да ми върнеш като резултат нов person, който по никакъв начин не зависи от тези елементи
//функцията ми казва искам да ми изпълниш върху всеки от елементите на този масив ето тази функция
//която ми връща като резултат нов масив
// function makePerson(name, age){
//     return {
//         name: name,
//         age: age
//     };
// }
// var count = '5';
// var people = [1,2,3,4,5].map(function(_, i){
//     return makePerson('Person #' + i, 10 + i);
// });
// console.log(people);
    
    //foreach той работи като for цикъл, само че го правим конкретно върху масива
    //54:00
