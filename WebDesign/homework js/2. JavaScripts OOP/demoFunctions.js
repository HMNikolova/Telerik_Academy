// function maxs(arr) {
//     var max = arr[0],
//     i,
//     len;
//     //проверка дали arr e масив
//     if(Array.isArray(arr)){
//         //ако това не е така, го направи на масив, за да ни върне поне едната стойност
//         arr = [arr];
//     }
  
//     for(i = 0, len = arr.length; i < len; i += 1){
//         max = Math.max(max, arr[i]);
//     }
//     return max;
// }
// console.log(max([1,2,3]));
// console.log(max(5));

// function max (arr) {

//   var maxValue = arr[0];
//   for   (var i = 1; i < arr.length; i++) {
//     maxValue = Math.max(maxValue, arr[i]);
//   }  
//   return maxValue;
// }

// function printMsg(msg){
//   console.log(msg);
// }
// console.log(max([5,6,8,9,4,5]));

//length ни казва колко параметъра иска нашата функция

// //function declaration
// function sum(x, y) {
//     return x + y;
// }
// console.log(sum(1,3));

// //function function declaration - неговата декларация се премества най-отгоре възможно на сколпа
// console.log(sum(5,6));
// function sum(x, y) {
//     return x + y;
// }

// function f() {
//     return sum(5,6);
//     function sum (x,y) {
//             return x + y;
//     }
// }
// console.log(f());

//function expressions-те се зареждат точно когато им дойде времето. Тук function значи литерал за функция 
//литерал за функция - има значение къде  сме я дефинирали 

// //function конструктор
// function sum (x, y) {
//     console.log(x + y);
// }
// var sum2 = new Function('x', 'y', 'console.log(x+y);');
// sum(5,6);
// sum2(7,8);

//apply
// var max = Math.max(1,2,3);
// var numbers = [1,2,3,4];
// console.log(Math.max.apply(Math, numbers));

// function sum (x,y,z) {
//     console.log(x+y+z);
// }
// sum(1,2,3);
// var numbers = [2,3,4];
//понеже нямам this може да сложа null, map и т.н.
// sum.apply(null, numbers);

// var person = {
//     name: 'Pesho',
//     age: 17,
//     introduce: function(){
//         console.log(this.name + ' ' + this.age);
//     }
// };
// var person2 = {
//     name: 'John',
//     age: 31
// };
// person.introduce();
// //call и apply правят едно и също единствената разлика е начина, по който даваме параметри
// //извикай introduce метода и да приложиш като this на тази функция person2
// person.introduce.call(person2);

//всеки път когато се изпълнява Х е създава нова функция У
// function x () {
//     function y () {
//         console.log('Y');
//     }
//     console.log('X');
//     y();
// }
// x();

// function x () {
//     function y () {
//         console.log('Y');
//     }
//     return y;
// }
// //резултата от х е функция и тъй като x() е функция, мога отнова да я изпълня
// x()();
// x()();

// //функция, която се изпълнява при създаването, точно един път
// //правим си function expresion (или IIFE)
// (function() {
//     console.log('x');
// }());

// //IIFE което връща резултат
// var module = (function(b){
//     var x = 6;
//     return {

//     };
// }(5));

// //тук поемаме параметъра b
// var module = (function(b){
//     console.log(b);
//     //тук подаваме параметъра 5
// }(5));

// //как да взема външния аргумент от вътрешната функция
// function x () {
//     function y () {
//         var args = arguments;
//         //така ще взема вътрешния аргумент
//         console.log(arguments);
//         //така външния като преди това е присвоен
//         console.log(args);
//     }
// }

// //module е IIFE, което връща резултат
// var getNextId = function(){
//     var lastId = 0;
//     return function(){
//         //с долния ред getNextId става module
//          return lastId += 1;
//     };
// }();
// //колкото пъти го принтираме толкова поредни ID-та ще се принтират
// console.log(getNextId());
// console.log(getNextId());
// console.log(getNextId());
// console.log(getNextId());
// console.log(getNextId());


var generator = function(){
    var lastId = 0;
    //искам да върна обект, в който ще имам функция
    return {
    getNextId: function(){
         return lastId += 1;
     }
    };
}();
console.log(generator.getNextId());
console.log(generator.getNextId());
console.log(generator.getNextId());
console.log(generator.getNextId());
console.log(generator.getNextId());
//ако пишем за браузера това this е за window-a, ако пиша на node.js това this значи глобалния обект
console.log(generator.getNextId.call(this));