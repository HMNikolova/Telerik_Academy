// (function () {
// 	var canvas = document.getElementById('the-canvas'),
// 		ctx = canvas.getContext('2d');
// 		ctx.fillStyle = 'rgba(0,255,0,0.7)';
// 	    ctx.strokeStyle = '#F0F';
// 	    ctx.lineWidth = "5";

// 	    ctx.beginPath();
// 	    ctx.setLineDash([15, 5]);
// 	    //ctx.setLineDash([15, 5, 30]);
// 	    //ctx.setLineDash([5, 10, 50, 10]);
// 	    ctx.strokeStyle = '#0F0';
// 	    ctx.moveTo(50, 50);
// 	    ctx.lineTo(350, 50);
// 	    //ако искаме да е до края на реда
// 	    //ctx.lineTo(canvas.width, 50);
// }());

// //елипса и квадрат
// (function () {
// 	var canvas = document.getElementById('the-canvas'),
// 		ctx = canvas.getContext('2d');
// 		ctx.fillStyle = 'rgba(0,255,0,0.7)';
// 	    ctx.strokeStyle = '#F0F';
// 	    ctx.lineWidth = "5";

// 	    ctx.beginPath();
// 	    ctx.save();
// 	    //ctx.setLineDash([5, 10, 50, 10]);
// 	    //елипса - по х искам да ги удвояваш, по y да ги правиш на половинка
// 	    ctx.scale(2, 0.5);
// 	    ctx.strokeStyle = '#0F0';
// 	    ctx.arc(100, 100, 75, 0, 2 * Math.PI);
// 	    ctx.stroke();
// 	    ctx.restore();
// 	    //квадрат
// 	    ctx.strokeRect(100,100,100,100);
	    
// }());

//ротация
// (function () {
// 	var canvas = document.getElementById('the-canvas'),
// 		ctx = canvas.getContext('2d');
// 		ctx.fillStyle = 'rgba(0,255,0,0.7)';
// 	    ctx.strokeStyle = '#F0F';
// 	    ctx.lineWidth = "5";

// 		ctx.save();
// 		//8 да е по-малък ъгъла
// 	    //ctx.rotate(Math.PI / 8);
// 	    ctx.rotate(9 / 8 * Math.PI);
// 	    //ctx.strokeRect(100,100,100,100);
// 	    ctx.strokeRect(-100,-100,100,100);
	    
// 	    ctx.save();
// 	    ctx.scale(2, 0.5);
// 	    ctx.strokeStyle = '#0F0';
// 	    ctx.beginPath();
// 	    //ctx.arc(100, 100, 75, 0, 2 * Math.PI);
// 	    ctx.arc(-100, -100, 75, 0, 2 * Math.PI);
// 	    ctx.stroke();

// 	    ctx.restore();
// 	    //с втория рестор връщам началото и квадрата не е завъртян
// 	    ctx.restore();
// 	    ctx.strokeRect(200,200,100,100);
	    
	    
// }());


//транслация
(function () {
	var canvas = document.getElementById('the-canvas'),
		ctx = canvas.getContext('2d');
		ctx.fillStyle = 'rgba(0,255,0,0.7)';
	    ctx.strokeStyle = '#F0F';
	    ctx.lineWidth = "5";

		ctx.save();
		ctx.rotate(1 / 8 * Math.PI);
		ctx.translate(100, 200);
	    ctx.strokeRect(100,100,100,100);
	    
	    ctx.save();
	    ctx.scale(2, 0.5);
	    ctx.strokeStyle = '#0F0';
	    ctx.beginPath();
	    //ctx.arc(100, 100, 75, 0, 2 * Math.PI);
	    ctx.arc(0, 0, 100, 0, 2 * Math.PI);
	    ctx.stroke();

	    ctx.restore();
	    ctx.restore();
	    //премествам началната точка
	    ctx.translate(100, 200);
	    ctx.strokeRect(0,0,100,100);
	    
}());