/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {

    var Person = (function () {

        function Person(firstname, lastname, age) {

            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        Object.defineProperties(Person.prototype, {
            'firstname': {
                get: function () {

                    return this._firstname;
                },
                set: function (value) {

                    checkIfString(value);
                    value = value.trim();
                    checkLetters(value);
                    checkLength(value);

                    this._firstname = value;
                    return this;
                }
            },
            'lastname': {
                get: function () {

                    return this._lastname;
                },
                set: function (value) {

                    checkIfString(value);
                    value = value.trim();
                    checkLetters(value);
                    checkLength(value);

                    this._lastname = value;
                    return this;
                }
            },
            'age': {
                get: function () {

                    return this._age;
                },
                set: function (value) {

                    checkIfNumber(value);
                    value = value*1;
                    checkIfInRange(value);

                    this._age = value;
                    return this;
                }
            },
            'fullname': {
                get: function () {

                    return this.firstname + ' ' + this.lastname;
                },
                set: function(value) {

                    value = value.split(' ');

                    this._firstname = value[0];
                    this._lastname = value[1];
                    return this;
                }
            }
        });

        Person.prototype.introduce = function () {

            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        };

        function checkIfString(value){
            if (typeof value !== "string") {
                throw {message: 'Input must be a string'};
            }
        }

        function checkLetters(value) {

            var pattern = /[^A-Za-z]/g;

            if (pattern.test(value)) {
                throw {message: 'Name must contain only Latin letters'};
            }
        }

        function checkLength(value) {

            if (value.length < 3 || value.length > 20) {
                throw {message: 'Name must be between 3 and 20 characters'};
            }
        }

        function checkIfNumber(value) {

            if (isNaN(value) || value === null || value === '' || value === undefined || value === false) {
                throw {message: 'Invalid Age input'};
            }
        }

        function checkIfInRange(value) {

            if (value < 0 || value > 150) {
                throw {message: 'Age must be a number between 0 and 150'};
            }
        }

        return Person;
    }());

    return Person;
}

module.exports = solve;