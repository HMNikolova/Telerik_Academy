// function solve(params) {
//     var s = +params[0],
//     result;
// 	// var numbers = s.split(' ');
// 	// //var bestSum = numbers[0];
// 	// for(var i = 0; i < numbers.length; i += 1){
// 	// 	var currenetSum = 0;

// 	// 	// for(var j = i; j < numbers.length; j += 1){
// 	// 	// 	currenetSum += numbers[j];
// 	// 	// 	if(currenetSum > bestSum){
// 	// 	// 		bestSum = currenetSum;
// 	// 	// 	}
// 	// 	}
// 	// }
// 	//return bestSum;
	
// 	result = arr.filter(function(item, index){
// 		if(index < 5){
//       return 2;
// 		}else if(index > 7 && index < 10){
//       return 4;
// 	}else{
// 	return 5;
// 	}
// 	console.log(result);
		
// }

//Използвам в логиката си  индексите на елементите в масива, които са ми върхове.
//За да получа върховете правя проста проверка дали следващия елемент е по-малък от настоящия 
//и дали предодния също е по-малък от настоящия.Така съм сигурен ,че елемента на масива е връх.
//Целта ми е да взема всички върхове и на всеки втори връх да изваждам индекса му,с индекса 
//на предходния връх.Тази логика дава така желаното като имаме три елемента  между два върха 
//да изпише 4 а не 3.След като по условие е казано,че началото на масива е връх и края също,за да 
//не правя допълнителна проверка,просто ги избягвам като слагам 0 в началото и края на масива.
//Като начало си правя променлива index =0 защото и без това 0-я индекс е връх,та все едно 
//маркирам първия връх.След това влизам в цикъла и проверявам дали настоящия елемент е връх
//-ако да,то вадя индекса му от индекса на предходния връх,като запаметявам на всяка врътка 
//ако съм намерил връх в променливата tempIndex.Когато съм намерил връх,смятам колко е 
//разликата между индексите на върховете и го записвам в променливата countRock.
//Проверявам дали bestCount ми е по-малка от countRock и ако да,записвам като най-добра 
//стойност в нея настоящия брой камъни(Линий).Отне ми сигурно половин час да разбера ,
//че трябва да броя линийте,а не кръгчетата.
 
 
 
function solve(par) {
    args = par[0].split(' ').map(Number);  
    args.push(0);     // добавям нула в края на масива
    args.unshift(0);            //тук добавям нула най-отпред в масива
    var countRock = 0;           //променлива да записвам камъните(броя линий)в долината
    var bestCount = 0;                 //променлива за запазване на най-много камъни
    var index = 0;                       //променлива за индекс
    tempIndex = 0;                        //променлива,която пази индекса на предходния връх.
    for (var i = 0; i < args.length; i++) {
        if (args[i] > args[i + 1] && args[i] > args[i - 1]) {//проверка дали елемента е връх
            index = i;                                           // ако е връх настоящия индекс-и става индекс  
            countRock = index - tempIndex;      //намирам броя камъни,
            if (bestCount < countRock) {        //проверка дали най-големия запаметен брой камъни е по-малък от настоящия
                bestCount = countRock;
            }
        }
        tempIndex = index;                      //запазвам индекса на настоящия връх,за да мога после да го използвам
    }
    return bestCount;
}
console.log(solve(['5 1 7 4 8']));   
console.log(solve(['5 1 7 6 3 6 4 2 3 8']));  
console.log(solve(['10 1 2 3 4 5 4 3 2 1 10'])); 

