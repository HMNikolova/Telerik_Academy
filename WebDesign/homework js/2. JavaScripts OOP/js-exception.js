// try{
//     //изпълнява стринга, който е подаден вътре, като стандартен javascript код
//     eval('function () {}');
// }catch(ex){
//     console.log(ex);
// }
// console.log('**************************');
// console.log('**************************');
// console.log('After the handling');
// console.log('**************************');
// console.log('**************************');


// try{
//     //изпълнява стринга, който е подаден вътре, като стандартен javascript код
//     eval('function () {}');
// }catch(ex){
//     console.log('**************************');
//     console.log('NAME:');
//     console.log(ex.name);
//     console.log('**************************');
//     console.log('**************************');
//     console.log('MESSAGE:');
//     console.log(ex.message);
//     console.log('**************************');
// }

// //как да си направим random exception
// function getRandomException() {
//     var exceptions = [
//         'var f;f();',
//         'f()',
//         'function(){}'
//         ];
//         var index = (Math.random() * exceptions.length) | 0;
//         eval(exceptions[index]);
    
// }
// try{
//   getRandomException();
// }catch(ex){
//     if(ex instanceof TypeError){
//         //if(ex.name === TypeError){
//         console.log('TE');
//     }
//     else if(ex instanceof RangeError){
//         //else if(ex.name === RangeError){
//         console.log('RE');
//     }
//     else if(ex instanceof SyntaxError){
//         //else if(ex.name === SyntaxError){
//         console.log('SE');
//     }
//     console.log(ex.message);
//     // console.log('------------------------');
//     // console.log(ex.name);
//     // console.log(ex.message);
//     // console.log('------------------------');
// }

// //ще хвърлям само един exception
// function getRandomException() {
//     var err = new ReferenceError('This is a sample error');
//     throw err;
// }
// try{
//   getRandomException();
// }catch(ex){
//     if(ex instanceof TypeError){
//         //if(ex.name === TypeError){
//         console.log('TE');
//     }
//     else if(ex instanceof RangeError){
//         //else if(ex.name === RangeError){
//         console.log('RE');
//     }
//     else if(ex instanceof SyntaxError){
//         //else if(ex.name === SyntaxError){
//         console.log('SE');
//     }
//     console.log(ex.message);
//     // console.log('------------------------');
//     // console.log(ex.name);
//     // console.log(ex.message);
//     // console.log('------------------------');
// }

// //в javascript може да хвърляме какъвто искаме обект благодарение на ducktyping
// function getRandomException() {
//     throw {
//         name: 'JohnError',
//         message: 'Hohn',
//         x: 'John Hohn'
//     };
// }
// try{
//   getRandomException();
//  }
//  catch(ex){
//      if(ex.name === 'TypeError'){
//          console.log('TE');
//      }
//      else if(ex.name === 'RangeError'){
//          console.log('RE');
//      }
//      else if(ex.name === 'SyntaxError'){
//          console.log('SE');
//      }
//      else if(ex.name === 'JohnError'){
//          console.log('JE');
//          console.log(ex.x);
//      }
//      console.log(ex.message);
//   }


//ако в try имаме някакъв код
function getRandomException() {
    var exceptions = [
       'var f;f();',
        'f()',
        'function(){}'
      ];
        var index = (Math.random() * exceptions.length) | 0;
        eval(exceptions[index]);
}
try{
    console.log('BEFORE THE EXCEPTION');
   //getRandomException();
   //когато getRandomException(); хвърли exception, изпълнението спира и долния ред няма да се принтира
   console.log('AFTER THE EXCEPTION');
 }
 catch(ex){
     if(ex.name === 'TypeError'){
         console.log('TE');
     }
     else if(ex.name === 'RangeError'){
         console.log('RE');
     }
     else if(ex.name === 'SyntaxError'){
         console.log('SE');
     }
     else if(ex.name === 'JohnError'){
         console.log('JE');
         console.log(ex.x);
     }
     console.log(ex.message);
  }
  //независимо дали ще се изпълни try, finally се изпълнява
  finally{
      console.log('IN THE FINALLY');
  }