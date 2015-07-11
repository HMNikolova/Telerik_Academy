// //класическо наследяване
// var Animal = (function () {
//     function Animal(name, age) {
//         this.name = name;
//         this.age = age;
//     }
//     //добавяне на метод toString, който ги залепя двете
//     Animal.prototype.toString = function (){
//         return this.name + ' ' + this.age;
//     };
//     Animal.prototype.eat = function () {
//         return 'Eats...';
//     };
//     return Animal;
// }());
// //правим същото за котка, но да преизползваме горното
// var Cat = (function (parent){
//     //трябва ми конструктор
//     function Cat(name, age, sleep) {
//         //извикваме базовия конструктор
//         //this е текущия ни обект (this е равен на празен обект)
//         parent.call(this, name, age);
//         this.sleep = sleep;
       
//     }
//     //два варианта да наследим Animal
//     //Cat.prototype = new Animal();
//     Cat.prototype = parent.prototype;
    
//      //искам да добавя на котката toString и да преизползвам горния код, като добавя sleep
//      Cat.prototype.toString = function () {
//       //за да извикаме базовия
//       var baseResult = parent.prototype.toString.call(this);
//         return baseResult + ' ' + this.sleep;
         
//      };
//      return Cat;
// }(Animal));
// var someCat = new Cat('Pesho', 5, true);
// console.log(someCat);
// console.log(someCat.eat);
// console.log(someCat.eat());

// //прототипно наследяване
// var animal = {
//     //оставя си в прототипа на animal
//     toString: function () {
//         return 'animal';
//     }
// }
// var dog = {
//     name: 'Pesho',
//     //олвърайдвам toString - закача се за самото куче
//     toString: function () {
//         return 'dog';
//     }
//   }
// //за да не презаписвам toString мога да кажа на това куче прототипа му да е animal
// dog.__proto__ = animal;
// console.log(dog.toString());
// console.log(animal.toString());
// //връща ми прототипа на самото куче
// var dogPrototype = Object.getPrototypeOf(dog);
// console.log(dogPrototype);

// //правилния начин за прототипно наследяване
// var animal = {
//     toString: function () {
//         return 'animal';
//     }
// }
// var dog = Object.create(animal);
// dog.name = 'Pesho';
// var dogPrototype = Object.getPrototypeOf(dog);
// console.log(dog.toString());

// //да го направим да работи и на стари браузери
// var animal = {
//     toString: function () {
//         return 'animal';
//     }
// }
// function createObject(objToCreate) {
//     function Constructor() { };
//     Constructor.prototype = objToCreate;
//     return new Constructor();
// }
// var dog = createObject(animal);
// dog.name = 'Pesho';
// var dogPrototype = Object.getPrototypeOf(dog);
// console.log(dogPrototype.toString());

// //дефиниреане на пропъртита без повторение на dog.нещо си
// var animal = {
//     toString: function () {
//         return 'animal';
//     }
// }
// //наследи ми animal като прототип и добавям празен обект, в който да си опиша всички пропъртита, които ще има кучето
// //defineProperties извиква Object create върху animal и ми създава кучето да има прототип animal
// var dog = Object.defineProperties(animal, {
//     name: {
//         //освен value има и други опции, които може да сетнем: enumerable, което казва дали когато for in-ваме този обект, дали пропъртито да влиза в самия цикъл
//         //writable: false - правиме нещо като константа, която не може да бъде променяна
//         value: 'Pesho',
//     },
//     age: {
//         value: 5,
//     }, 
//     //как да сетнем функция
//     bark: {
//         value: function () {
//             return 'Bark';
//         }
//     }
// });
// console.log(dog.toString());
// console.log(dog.bark());

// //как може да преизползваме методите
// //това ни е единия "клас"
// var animal = (function(){
//   //не наследяваме нищо затова не му казваме Object.create
//     var animal = {
//       //създаваме си function конструктор - init ни е функцията, която искаме да ни бъде конструктор
//       //init е конструктор към animal - и върши работа да ни създаде обект
//       init: function (name, age) {
//           this.name = name;
//           this.age = age;
//           return this;
//       },
//       //правим си пропърти
//       get name() {
//           //това ще ми отговаря, ако кажа var someName = animal.name;
//           return this._name;
//       }, 
//       set name(someValue) {
//           if (someValue.length < 3) {
//               throw new Error('Sorry, name should be at least 3 symbols!'); 
//           }
//           //ако горния иф мине казвам
//           this._name = someValue;
//       },
//       toString: function () {
//           return this.name + ' ' + this.age;
//       }
       
//     }
//     return animal;
// }());
// //това ни е другия клас
// var cat = (function (parent) {
//     //cat взима от animal всичко
//     var cat = Object.create(parent);
//     //наследяване вариант 1
//     //върху, кой обект, искам пропърти което да се казва init
//     Object.defineProperty(cat, 'init', {
//         value: function (name, age, sleep) {
//         //извикваме базовия конструктор в контекста на this 
//         parent.init.call(this, name, age);
//         this.sleep = sleep;
//         return this;
//         }
//     });
//     //наследяване вариант 2
//     // //преизползваме init (наследяването)
//     // cat.init = function (name, age, sleep) {
//     //     //извикваме базовия конструктор в контекста на this 
//     //     parent.init.call(this, name, age);
//     //     this.sleep = sleep;
//     //     return this;
//     // }
    
//     //override на toString и да преизползваме toString
//     cat.toString = function () {
//         //извикваме базовия toString метод
//         var baseResult = parent.toString.call(this);
//         return baseResult + ' ' + this.sleep;
//     }
//     return cat;
// }(animal));
// // //създавам си нов animal
// // //създай ми animal с дефолтна конструкция init
// var someAnimal = Object.create(animal).init('Pesho', 5);
// // //показва ми прайвит променливата _name - тук не пипай
// // console.log(someAnimal);
// // //но мога да пипам през другия сетър и като му кажа pe ще гръмне заради валидацията
// // someAnimal.name = 'pe';
// // ////това ми извиква метода get
// // //var someName = someAnimal.name;
// var someCat = Object.create(cat).init('Gosho', 10, true);
// console.log(someCat);
// //console.log(Object.getPrototypeOf(someCat));
// console.log(someCat.toString());
// console.log(someAnimal.toString());



//още един пример за наследяване
// var vehicle = (function () {
//     var vehicle = { };
//     vehicle.init = function (brand) {
//         this.brand = brand;
//         return this;
//     }
//     //закачаме му метод
//     vehicle.move = function () {
//         return this.brand + ' is moving...';
//     }
//     return vehicle;
// }());
// //наследяваме кола
// var car = (function (parent) {
//     var car = Object.create(parent);
//     //валидация за wheels
//     Object.defineProperty(car, 'wheels', {
//         get: function() {
//             return this._wheels;
//         },
//         set: function(value) {
//             if (value > 4) {
//                 throw new Error('Cars must have less than 5 wheels for some reason!');
//             }
//             this._wheels = value;
//         }
//     });
//     //конструктор
//     Object.defineProperty(car, 'init', {
//         value: function (brand, wheels) {
//             parent.init.call(this, brand);
//             this.wheels = wheels;
//             return this;
//         }
//     });
//     //преизползваме базовия
//     Object.defineProperty(car, 'move', {
//         value: function () {
//             return parent.move.call(this) + ' With ' + this.wheels + ' wheels!';
//         }
//     });
//     return car;
// }(vehicle));
// var someVehicle = Object.create(vehicle).init('Mercedes');
// console.log(someVehicle);
// var someCar = Object.create(car).init('Audi', 4);
// ////при 5 гърми
// //var someCar = Object.create(car).init('Audi', 5);
// console.log(someCar.move());
// //енумериране всички пропъртита на колата
// for (var key in someVehicle) {
//     //console.log(key + ': ' + someCar[key]);
//     //hasOwnProperty, дали този ключ в someCar e дефиниран в самия car или е нещо, което се бърка в прототипа
//     console.log(key + ': ' + someVehicle.hasOwnProperty(key));
// }

// //duck typing е известен като полиморфизъм в другите ооп езици
// //когато закачим нещо конкретно, към някакъв обект и му кажем this.name и направи нещо върху него
// //не е задължително да работя с този обект, който е закачено това пропърти name, а може да работя с всякакви обекти, които имат такова пропърти
// //това е обект не е масив, може slice метода да го извикаме, върху друго нещо, не върху масив
// var arrObj = {
//   length: 3,
//   '0': 'One',
//   '1':'Two',
//   '2': 'Three'  
// };
// var arr = [].slice.call(arrObj);
// //returns ['One', 'Two', 'Three']
// console.log(arr);

var person = {
  name: 'John Doe', age: 0,
  introduce: function () {
    console.log('Hello! I am ' + this.name + ' and I am ' + this.age + '-years-old');
  }
};
person.introduce(); 
person.introduce.call({ name: 'Snoopy',  age: 2 });
