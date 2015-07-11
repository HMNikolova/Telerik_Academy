//Object define property - на обект искам да му закача пропърти
//синтаксиса е: Object.defineProperty(obj, prop, desc) - obj - обекта към който искам да закачам каквото и да било, prop - даваме името на пропъртото
//desc - дескриптор те са два вида - data descriptor и accessor descriptor - и двата типа имат тези две пропъртита: configurable и enumerable 
//configurable - дали аз мога да променям това пропърти от data descriptor към accessor descriptor
//enumerable ако е сетнато на true, когато си енумерирам обекта т.е. пусна го в един for in, ще излезне в списъка с пропъртита, ако е false просто го няма - по default enumerable е false
//data descriptor се различават от accessor descriptor с това, че имат още две стойности value(стойността, която пазим в това пропърти) и writable(дали можем да променяме тази стойност - Defaults to false)
//accessor descriptor - имат две пропъртита get и set (Both default to undefined)
/*  */
// (function() {
// // using __proto__
//     var obj = {};
//     //на празния обект му закачам пропъртито key1
//     Object.defineProperty(obj, 'key1', {
//         __proto__: null, // no inherited properties
//         value: 'static1'  // not enumerable
//         // not configurable
//         // not writable
//         // as defaults
//     });

// // being explicit
//     Object.defineProperty(obj, 'key2', {
//         enumerable: false,
//         configurable: false,
//         writable: false,
//         value: 'static2'
//     });
    
//     console.log(obj);//принтира ми празен обект, ако сетна enumerable: true, ми казва това е обект, който има пропърти key2 сетнато static2
//     //console.log(obj.key2);

// // recycling same object
// //метод, който сетва някакво пропърти и мога да си го преизползвам(примера отдолу с key4)
//     function withValue(value) {
//         var d = withValue.d || (
//                 withValue.d = {
//                     enumerable: true,
//                     writable: false,
//                     configurable: false,
//                     value: null
//                 }
//             );
//         d.value = value;
//         return d;
//     }
//     //тук мога да кажа добави ми key6
//     obj.key5 = 'value';
//     Object.defineProperty(obj, 'key3', withValue('static3'));
//     Object.defineProperty(obj, 'key4', withValue('static4'));
//     console.log(obj);   
//     console.log(obj.key3);
//     console.log(obj.key4);
// }());


// //Object.defineProperties(obj, props) - накуп да си дефинирам пропъртита -  - obj - обекта към който искам да закачам каквото и да било,props - и му подавам един обект с пропъртитата
// /* */
// (function () {
//     var obj = {};
//     Object.defineProperties(obj, {
//         "property1": {
//             value: true,
//             writable: true
//         },
//         "property2": {
//             value: "Hello",
//             writable: false
//         }
//         // etc. etc.
//     });
// }());


// //Object.create(proto[, propertiesObject]) - използваме го да си създаваме някакъв обект, с дадения прототип на някакъв друг обект и по този начим може да си правим като наследяване
// //имаме фигура и наследник триъгълник
// /* Classical inheritance with Object.create() */
// (function () {
// // Shape - superclass
//     function Shape() {
//         this.x = 0;
//         this.y = 0;
//     }

// // superclass method
//     Shape.prototype.move = function (x, y) {
//         this.x += x;
//         this.y += y;
//         console.info('Shape moved.');
//     };

// // Rectangle - subclass
//     function Rectangle() {
//         Shape.call(this); // call super constructor.
//     }

// // subclass extends superclass
// //прототипа на Rectangle ще бъде прототипа на Shape
// //Object.create - така го наследявам и копирам всичките стойности, но не е закачен към него
//     Rectangle.prototype = Object.create(Shape.prototype);
//     //на конструктора на прототипа е този Rectangle
//     Rectangle.prototype.constructor = Rectangle;

//     var rect = new Rectangle();

//     console.log('Is rect an instance of Rectangle? ' + (rect instanceof Rectangle)); // true
//     console.log('Is rect an instance of Shape? ' + (rect instanceof Shape)); // true
//     rect.move(1, 1); // Outputs, 'Shape moved.'
// }());

// /* Using propertiesObject argument with Object.create() */
// (function () {
//     var o;
// // create an object with null as prototype
//     o = Object.create(null);

//     o = {};
// // is equivalent to:
//     o = Object.create(Object.prototype);

// // Example where we create an object with a couple of sample properties.
// // (Note that the second parameter maps keys to *property descriptors*.)
//     o = Object.create(Object.prototype, {
//         // foo is a regular 'value property'
//         foo: {
//             writable: true,
//             configurable: true,
//             value: 'hello'
//         },
//         // bar is a getter-and-setter (accessor) property
//         bar: {
//             configurable: false,
//             get: function () {
//                 return 10;
//             },
//             set: function (value) {
//                 console.log('Setting `o.bar` to', value);
//             }
//         }
//     });

//     function Constructor() {
//     }

//     o = new Constructor();
// // is equivalent to:
//     o = Object.create(Constructor.prototype);
// // Of course, if there is actual initialization code in the
// // Constructor function, the Object.create() cannot reflect it

// // create a new object whose prototype is a new, empty object
// // and adding single property 'p', with value 42
//     o = Object.create({}, {p: {value: 42}});

// // by default properties ARE NOT writable, enumerable or configurable:
//     o.p = 24;
//     console.log(o.p); // 42

//     o.q = 12;
//     for (var prop in o) {
//         console.log(prop); // 'q'
//     }

//     delete o.p; // false
// }());
// /**/

// //Object.kes(obj) - връща всички enumerable пропъртита на обекта
// /* */
// (function () {
//     var arr = ['a', 'b', 'c'];
//     console.log(Object.keys(arr)); // console: ['0', '1', '2']

// // array like object
//     var obj = {0: 'a', 1: 'b', 2: 'c'};
//     console.log(Object.keys(obj)); // console: ['0', '1', '2']

// // array like object with random key ordering
//     var an_obj = {100: 'a', 2: 'b', 7: 'c'};
//     console.log(Object.keys(an_obj)); // console: ['2', '7', '100']

// // getFoo is property which isn't enumerable
//     var my_obj = Object.create({}, {
//         getFoo: {
//             value: function () {
//                 return this.foo;
//             }
//         }
//     });
//     my_obj.foo = 1;

//     console.log(Object.keys(my_obj)); // console: ['foo']
// }());

// //Object.preventExtensions() - не позволява да му се добавят нови пропъртита
// /*  */
// (function () {
// // Object.preventExtensions returns the object being made non-extensible.
//     var obj = {};
//     //чейнвам си (obj)
//     var obj2 = Object.preventExtensions(obj);
//     console.log(obj === obj2);

// // Objects are extensible by default.
//     var empty = {};
//     console.log('is "empty" extensible: ' + Object.isExtensible(empty));

// // ...but that can be changed.
//     Object.preventExtensions(empty);
//     console.log('is "empty" extensible: ' + Object.isExtensible(empty));

// // Object.defineProperty throws when adding a new property to a non-extensible object.
//     var nonExtensible = {removable: true};
//     Object.preventExtensions(nonExtensible);
// //Object.defineProperty(nonExtensible, 'new', { value: 8675309 }); // throws a TypeError

// // In strict mode, attempting to add new properties to a non-extensible object throws a TypeError.
//     function fail() {
//         'use strict';
//         nonExtensible.newProperty = 'FAIL'; // throws a TypeError
//     }

// //fail();

//     console.log('is "nonExtensible" extensiblxe: ' + Object.isExtensible(nonExtensible));
// }());


// //Object.seal()-дали обекта ни е запечатън, не мога да добавям ново пропърти, не мога да трия и т.н.
// /*  */
// (function () {
//     var o, obj = {
//         prop: function () {
//         },
//         foo: 'bar'
//     };

// // New properties may be added, existing properties may be changed or removed.
//     obj.foo = 'baz';
//     obj.lumpy = 'woof';
//     delete obj.prop;

//     o = Object.seal(obj);

//     console.log(o === obj);
//     console.log(Object.isSealed(obj) === true);

// // Changing property values on a sealed object still works.
//     obj.foo = 'quux';
//     console.log('obj.foo = ' + obj.foo);

// // But you can't convert data properties to accessors, or vice versa.
// //Object.defineProperty(obj, 'foo', { get: function() { return 'g'; } }); // throws a TypeError

// // Now any changes, other than to property values, will fail.
//     obj.quaxxor = 'the friendly duck'; // silently doesn't add the property
//     console.log('obj.quaxxor = ' + obj.quaxxor);

//     delete obj.foo; // silently doesn't delete the property
//     console.log('obj.foo = ' + obj.foo);

// // ...and in strict mode such attempts will throw TypeErrors.
//     function fail() {
//         'use strict';
//         delete obj.foo; // throws a TypeError
//         obj.sparky = 'arf'; // throws a TypeError
//     }
//     fail();

// // Attempted additions through Object.defineProperty will also throw.
//     Object.defineProperty(obj, 'ohai', {value: 17}); // throws a TypeError
//     Object.defineProperty(obj, 'foo', {value: 'eit'}); // changes existing property value
// }());


// //Object.freeze() - не мога да екстендвам обекта, не мога да променям пропъртитата му,не мога да ги трия, не мога да им променям стойността
// /* Object.freeze() */
// (function() {
//     var o, obj = {
//         prop: function() {},
//         foo: 'bar'
//     };

// // New properties may be added, existing properties may be changed or removed
//     obj.foo = 'baz';
//     obj.lumpy = 'woof';
//     delete obj.prop;

//     o = Object.freeze(obj);
//     console.log(Object.isFrozen(obj) === true);

// // Now any changes will fail
//     obj.foo = 'quux'; // silently does nothing
//     obj.quaxxor = 'the friendly duck'; // silently doesn't add the property

// // ...and in strict mode such attempts will throw TypeErrors
//     function fail(){
//         'use strict';
//         obj.foo = 'sparky'; // throws a TypeError
//         delete obj.quaxxor; // throws a TypeError
//         obj.sparky = 'arf'; // throws a TypeError
//     }

//     fail();

// // Attempted changes through Object.defineProperty will also throw
//     Object.defineProperty(obj, 'ohai', { value: 17 }); // throws a TypeError
//     Object.defineProperty(obj, 'foo', { value: 'eit' }); // throws a TypeError
// }());

// //Object.assign(target,...sources) - target-кой е обекта на който искаме да assign-ваме пропъртита и след това му изреждаме другите обекти(sources)
// /* Object.assign() */
// // Polyfill
// if (!Object.assign) {
//     Object.defineProperty(Object, 'assign', {
//         enumerable: false,
//         configurable: true,
//         writable: true,
//         value: function(target) {
//             'use strict';
//             if (target === undefined || target === null) {
//                 throw new TypeError('Cannot convert first argument to object');
//             }

//             var to = Object(target);
//             for (var i = 1; i < arguments.length; i++) {
//                 var nextSource = arguments[i];
//                 if (nextSource === undefined || nextSource === null) {
//                     continue;
//                 }
//                 nextSource = Object(nextSource);

//                 var keysArray = Object.keys(Object(nextSource));
//                 for (var nextIndex = 0, len = keysArray.length; nextIndex < len; nextIndex++) {
//                     var nextKey = keysArray[nextIndex];
//                     var desc = Object.getOwnPropertyDescriptor(nextSource, nextKey);
//                     if (desc !== undefined && desc.enumerable) {
//                         to[nextKey] = nextSource[nextKey];
//                     }
//                 }
//             }
//             return to;
//         }
//     });
// }

// // Cloning an object
// (function() {
//     var obj = {a: 1},
//         copy = Object.assign({}, obj);
//     console.log(copy); // { a: 1 }
// }());

// // Merging objects
// (function() {
//     var obj,
//         o1 = {a: 1},
//         o2 = {b: 2},
//         o3 = {c: 3};

//     obj = Object.assign(o1, o2, o3);
//     console.log(obj); // { a: 1, b: 2, c: 3 }
//     console.log(o1);  // { a: 1, b: 2, c: 3 }, target object itself is changed.
// }());

// // Inherit properties and non-enumerable properties cannot be copied
// (function() {
//     var obj, copy;
//     obj = Object.create({ foo: 1 }, { // foo is an inherit property.
//         bar: {
//             value: 2  // bar is a non-enumerable property.
//         },
//         baz: {
//             value: 3,
//             enumerable: true  // baz is an own enumerable property.
//         }
//     });

//     copy = Object.assign({}, obj);
//     console.log(copy);
//     console.log(obj);

//     console.log('copy.bar = ' + copy.bar);
//     console.log('obj.bar = ' + obj.bar);
// }());


// // Object.is() - сравнява две стойности
// (function() {
//     console.log(Object.is('foo', 'foo'));     // true
//     console.log(Object.is(window, window));   // true

//     console.log(Object.is('foo', 'bar'));     // false
//     console.log(Object.is([], []));           // false

//     var test = {a: 1};
//     console.log(Object.is(test, test));       // true

//     console.log(console.log(Object.is(null, null))); // true

// // Special Cases
//     console.log(Object.is(0, -0));            // false
//     console.log(Object.is(-0, -0));           // true
//     console.log(Object.is(NaN, 0 / 0));         // true
// }());


// // obj.hasOwnProperty(prop) - да проверим на някакъв обект дали има даденото пропърти
// // Using hasOwnProperty to test for a property's existence
// (function() {
//     o = new Object();
//     o.prop = 'exists';

//     function changeO() {
//         o.newprop = o.prop;
//         delete o.prop;
//     }

//     console.log('"o" has property "prop": ' + o.hasOwnProperty('prop'));   // returns true
//     changeO();
//     console.log('"o" has property "prop": ' + o.hasOwnProperty('prop'));   // returns false
// }());

// // Direct versus inherited properties
// (function() {
//     var o = new Object();
//     o.prop = 'exists';
//     console.log('"o" has property "prop": ' + o.hasOwnProperty('prop'));             // returns true
//     console.log('"o" has property "toString": ' + o.hasOwnProperty('toString'));         // returns false
//     console.log('"o" has property "hasOwnProperty": ' + o.hasOwnProperty('hasOwnProperty'));   // returns false
// }());

// // Iterating over the properties of an object
// (function() {
//     var buz = {
//         fog: 'stack'
//     };

//     for (var name in buz) {
//         if (buz.hasOwnProperty(name)) {
//             console.log('this is fog (' + name + ') for sure. Value: ' + buz[name]);
//         }
//         else {
//             console.log(name); // toString or something else
//         }
//     }
// }());

// // hasOwnProperty as a property
// (function() {
//     var foo = {
//         hasOwnProperty: function() {
//             return false;
//         },
//         bar: 'Here be dragons'
//     };

//     console.log('"foo" has property "bar": ' + foo.hasOwnProperty('bar')); // always returns false

// // Use another Object's hasOwnProperty and call it with 'this' set to foo
//     console.log('"foo" has property "bar": ' + ({}).hasOwnProperty.call(foo, 'bar')); // true

// // It's also possible to use the hasOwnProperty property from the Object prototype for this purpose
//     console.log('"foo" has property "bar": ' + Object.prototype.hasOwnProperty.call(foo, 'bar')); // true
// }());


// //prototypeObj.isPrototypeOf(obj) - сходно на instanceof - дали нещо е наследник на нещо друго, първо записваме родителя - с isPrototypeOf се проверява самото нещо, което сме му задали(prototypeObj), ние може да решим дали това да е прототипа или самия обект                             
// (function () {
//     // consider the following prototype chain
//     function Fee() {
//         // ...
//     }

//     function Fi() {
//         // ...
//     }
//     Fi.prototype = new Fee();

//     function Fo() {
//         // ...
//     }
//     Fo.prototype = new Fi();

//     function Fum() {
//         // ...
//     }
//     Fum.prototype = new Fo();

//     var fum = new Fum();

//     if (Fi.prototype.isPrototypeOf(fum)) {
//         console.log('do something safe');
//     }
// }());


// // Object.prototype.propertyIsEnumerable() - проверява дали е сетнато на труе ili на фалсе
// // A basic use of propertyIsEnumerable
// (function() {
//     var o = {};
//     var a = [];
//     o.prop = 'is enumerable';
//     a[0] = 'is enumerable';

//     console.log('is "prop" enumerable: ' + o.propertyIsEnumerable('prop'));   // returns true
//     console.log('is "0" enumerable: ' + a.propertyIsEnumerable(0));        // returns true
// }());

// // User-defined versus built-in objects
// (function() {
//     var a = ['is enumerable'];

//     console.log('is "0" enumerable: ' + a.propertyIsEnumerable(0));          // returns true
//     console.log('is "length" enumerable: ' + a.propertyIsEnumerable('length'));   // returns false

//     console.log('is "Math.random" enumerable: ' + Math.propertyIsEnumerable('random'));   // returns false
//     console.log('is "this.Math" enumerable: ' + this.propertyIsEnumerable('Math'));     // returns false
// }());

// // Direct versus inherited properties
// (function() {
//     var a = [];
//     console.log('is "[].constructor" enumerable: ' + a.propertyIsEnumerable('constructor'));         // returns false

//     function FirstConstructor() {
//         this.property = 'is not enumerable';
//     }

//     FirstConstructor.prototype.firstMethod = function() {};

//     function SecondConstructor() {
//         this.method = function method() { return 'is enumerable'; };
//     }

//     SecondConstructor.prototype = new FirstConstructor;
//     SecondConstructor.prototype.constructor = SecondConstructor;

//     var o = new SecondConstructor();
//     o.arbitraryProperty = 'is enumerable';

//     console.log('is "o.arbitraryProo.perty" enumerable: ' + o.propertyIsEnumerable('arbitraryProperty'));   // returns true
//     console.log('is "o.method" enumerable: ' + o.propertyIsEnumerable('method'));              // returns true
//     console.log('is "o.property" enumerable: ' + o.propertyIsEnumerable('property'));            // returns false

//     o.property = 'is enumerable';

//     console.log('is "o.property" enumerable: ' + o.propertyIsEnumerable('property'));            // returns true

// // These return false as they are on the prototype which
// // propertyIsEnumerable does not consider (even though the last two are iteratable with for-in)
//     console.log('is "o.prototype" enumerable: ' + o.propertyIsEnumerable('prototype'));   // returns false (as of JS 1.8.1/FF3.6)
//     console.log('is "o.constructor" enumerable: ' + o.propertyIsEnumerable('constructor')); // returns false
//     console.log('is "o.firstMethod" enumerable: ' + o.propertyIsEnumerable('firstMethod')); // returns false
// }());


//обект с пропъртита, които не са достъпни отвън
(function () {
    var Logger = (function() {
        function Logger() {
        
        var val = null,
            id = 1,
            history = [];
        Object.defineProperties(this, {
            value: {
                enumerable: true,
                get: function(){
                    return val;
                },
                set: function(value){
                    history.push({ id: id, prop: value});
                    //при всяка интерация id да се увеличава с 1
                    id += 1;
                    val = value;
                }   
            },
            getHistory:{
               value: function() {
        return history.slice(0);
                }
            }
        });
        
    }
    
        return Logger;
    }());
    var logger = new Logger();
    logger.value = 'asdf';
    console.log(logger.value);
    
    logger.value = 'trey';
    console.log(logger.value);
    console.log(logger.history);
    logger.value = 'word';
    console.log(logger.getHistory());
    console.log(logger);
}());


























