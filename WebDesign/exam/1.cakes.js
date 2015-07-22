function solve(params) {
  var count1,
    count2,
    count3,
    price,
    //s е свързано и не трябва да надминава мах брой сладкиши, които може да купим с s
    s = +params[0],
    c1 = params[1],
    c2 = params[2],
    c3 = params[3],
    answer = 0;
//изциклям всички възможности да си купя сладките така, че да не превишавам сумата s
  for (count1 = 0; count1 <= (s / c1) + 1; count1++) {
    for (count2 = 0; count2 <= (s / c2) + 1; count2++) {
      for (count3 = 0; count3 <= (s / c3) + 1; count3++) {
        price = (count1 * c1) + (count2 * c2) + (count3 * c3);
        //купувам count1 на брой сладкиша от първи тип, count2 на брой сладкиша от втори тип и count3 на брой сладкиша от трети тип
        //price = count1 * c1 + count2 * c2 + count3 * c3;
        //и проверявам каква е цената до момента на това, което се опитвам да купя и търся мах такава цена, която е по-малка или равна на s
        //отговарям на условието да не изхарча повече от парите,които имам
        if (price <= s) {
          // if (price >= answer) console.log(s - price, i1, i2, i3);
          //answer по-голямото от текущия отговор и цената, която току що съм намерил
          answer = Math.max(answer, price);
        }
        // //ако цената се покаже по-голяма от s
        // else{
        //   break;
        // }
      }
    }
  }

  return answer;
}
//проверка в началото
// console.log(solve([110, 13, 15, 17]) == 110);   
// console.log(solve([20, 11, 200, 300]) == 11);  
// console.log(solve([110, 19, 29, 39]) == 107);  

//мах сума 110, цената на един сладкиш струва 13, колко е мах брой сладкиши, които мога да купя с 110 -> 110/13
console.log(solve([110, 13, 15, 17]));   