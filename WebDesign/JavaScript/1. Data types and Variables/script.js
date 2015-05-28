/* Problem 1. JavaScript literals
    Assign all the possible JavaScript literals to different variables.
 */

 	var num = 5,
  floatNum = 5.152536,
  myHexValue = 0xAA,
  str = '"Some text"',
  bool = true,
  myArray = [1, 2, 3],
  object = { 0: "white", 1: "black", 2: "grey" },
  funct = function myfunction() {
    return 'great';
  };

 console.log("number = " + num);

 console.log("float = " + floatNum);

 console.log('hex = ' + myHexValue);

 console.log('string = ' + str);

 console.log('boolean = ' + bool);

 console.log('array = ' + myArray);

 console.log('object = ' + object[1]);

 console.log('function = ' + funct());

/* Problem 2. Quoted text
 Create a string variable with quoted text in it.
 For example: 'How you doin'?', Joey said'.
 */

 var quatedText = "'How you doin'?',Joey said'.";
 console.log(quatedText);

/* Problem 3. Typeof variables
   Try typeof on all variables you created.
   and 
   Problem 4. Typeof null
    Create null, undefined variables and try typeof on them.
 */

var undefType;
var n = null;

var allList = [num, floatNum, myHexValue, str, bool, myArray, object, funct,
    undefType, n];
for (var i = 0; i < allList.length; i++) {
    console.log(typeof allList[i]);
}