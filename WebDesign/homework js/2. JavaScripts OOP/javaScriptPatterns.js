// //по дефиниция всяка функция може да достъпва обекти, които са в нейния скоупи и в нейния родителски скоуп
// //var obj = {};
// var db = (function () {
//     //това е hidden
//     var lastId = 0,
//         objects = [];
//         //тази функция не е видима отвън, защото не се връща като резултат (ако я върнем в return ще бъде видима), остава да живее само в скоупа на нашия модул
//     function getNextId() {
//         return ++lastId;
//     }    
//     return {
//         //добавяме обект
//         add: function (obj) {
//             obj.id = getNextId();
//             objects.push(obj);
            
//         },
//         //листваме обект
//         list: function () {
//             //да върнем не конкретния масив, ами копие на този масив (за да се предпазим от хак)
//             //return objects.slice();
//             //за пълно предпазване от хак вместо горния return трябва да напишем
//             return objects.map(function (obj) {
//                 return {
//                     name: obj.name,
//                     id: obj.id
//                 };
//             }).slice();
//         }
//     };
// }());
// //db.add('John');
// //за да работи id-то трябва да го напишем така
// db.add({name: 'John'});
// console.log(db.list());


// //revealing module pattern - 
// var db = (function () {
//     var lastId = 0,
//         objects = [];
//     function getNextId() {
//         return ++lastId;
//     }  
//     function addObject (obj) {
//         //addObject създава клоужър с getNextId, което пък само по себе си (++lastId) създава клоужър с lastId
//             obj.id = getNextId();
//             objects.push(obj);
//     }
//     function listObject() {
//         return objects.map(function (obj) {
//                 return {
//                     name: obj.name,
//                     id: obj.id
//                 };
//             }).slice();
//     }
//     return {
//         add: addObject,
//         //като сме стигнали до тук функцията вече е създадена и ние тук връщаме обект, който има пропъртито лист, което сочи към референция на функция, но функцията вече е създадена и си стои в паметта
//         list: listObject,
//         //може функцията getNextId да я добавим отдолу и тя да е видима
//         getNextId: getNextId
//     };
// }());
// //db.add('John');
// //за да работи id-то трябва да го напишем така
// db.add({name: 'John'});
// console.log(db.list());

// //singleton - колкото пъти да правим един обект, той ще има една инстанция 
// //ако направя 5 person-а, аз ги извиквам с new, обаче винаги получавам една и съща референция, получавам един и същи обект
// //всяко iife в javascript ни е singleton
// var databases = (function () {
//     var items = [],
//         db = {
//         //метод add, който е на db прави клоужър към db, който си има метода add, който прави клоужър към db
//         //затова това може да се счупи по-трудно
//         add: function(item){
//             items.push(item);
//             //this e db
//             //return this;
//             return db;
//         },
//         list: function(){
//             return items.slice();
//         }
//     };
//     return {
//         get: function () {
//             return db;
//         }
//     };
// }());
// // console.log(databases.get().add('Fgds').add('John').list());
// // //тук ги получаваме и четирите
// // console.log(databases.get().add('Fgds 1').add('John 1').list());
// var db = databases.get();
// var add = db.add;
// //всеки add връща db
// console.log(add('John').add('Hohn').list());

// //wrong-singleton - грешния сингълтън в другите езици така се пише, но в javascript не
// var calculator = (function () {
//     var instance;
//     return {
//         get: function () {
//             if(typeof (instance) === 'undefined') {
//                 //ако instance e undefined
//                 instance = {
//                     result: 0,
//                     add: function (x) {
//                         this.result += x;
//                     }
//                 };
//             }
//         return instance;    
//         }
//     };
// }());
// calculator.get().add(5);
// calculator.get().add(15);
// calculator.get().add(25);
// console.log(calculator.get().result);

//augmenting modules - екстендване на различните модули
//искам в двата файла да сложа един и същи модул

//file-1
//изпълняваме нормално ифи, и тук(scope) го очакваме
var mod = mod || {};
(function (scope) {
    scope.x = 'file-1';
    //подаваме mod като параметър
}(mod));

//file-2
//екстендвам
//каква е връзката м/у scope и mod - scope е параметъра, който се приема от извикването на функцията. А функцията я извикваме с параметър mod
//връзката м/у scope и mod, е че са един и същи обект
//когато подам mod отгоре в scope, подавам референция към този  mod и тази референция мога да я променям както поискам
var mod = mod || {};
(function (scope) {
    scope.y = 'file-2';
}(mod));
console.log(mod.x);
console.log(mod.y);
//или
console.log(mod.x, mod.y);






