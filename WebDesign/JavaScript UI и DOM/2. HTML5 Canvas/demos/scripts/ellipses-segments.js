// (function () {
// 	var canvas = document.getElementById("ellipses-canvas"),
// 		ctx = canvas.getContext("2d"),

// 		position = {
// 			x: 50,
// 			y: 50
// 		}, radius = 45,
// 		ellipseFromTos = [{
// 			from: 0,
// 			to: 2 * Math.PI
// 		}, {
// 			from: Math.PI,
// 			to: 2 * Math.PI
// 		}, {
// 			from: 0,
// 			to: Math.PI / 2
// 		}, {
// 			from: Math.PI / 2,
// 			to: 3 * Math.PI / 2
// 		}, {
// 			from: Math.PI / 2,
// 			to: 2 * Math.PI
// 		}, {
// 			from: Math.PI / 2,
// 			to: 3 * Math.PI
// 		}];

// 	function drawArcPath(x, y, r, from, to, isCounterClockwise) {
// 		ctx.beginPath();
// 		ctx.arc(x, y, r, from, to, isCounterClockwise);
// 		ctx.fill();
// 		ctx.beginPath();
// 		ctx.arc(x, y, r, 0, 2 * Math.PI);
// 		ctx.stroke();
// 	}

// 	for (var i = 0; i < ellipseFromTos.length; i += 1) {
// 		var fromTo = ellipseFromTos[i];
// 		var y = position.y + i * 100;
// 		drawArcPath(position.x, y, radius, fromTo.from, fromTo.to, false);
// 		drawArcPath(position.x + 100, y, radius, fromTo.from, fromTo.to, true);
// 	}
// }());


// (function() {
// 	var canvas = document.getElementById("paths-canvas"),
// 		ctx = canvas.getContext("2d");

// 	ctx.beginPath();
// 	ctx.moveTo(50, 50);
// 	ctx.lineTo(50, 300);
// 	ctx.lineTo(200, 50);
// 	ctx.lineTo(50, 50);
// 	ctx.stroke();

// 	ctx.beginPath();
// 	ctx.moveTo(200, 50);
// 	ctx.lineTo(200,300);
// 	ctx.lineTo(50, 300);
// 	ctx.lineTo(200, 50);
// 	ctx.fill();
// }());


window.onload = function () {
	var theCanvas = document.getElementById("ellipses-canvas");
	var canvasCtx = theCanvas.getContext("2d");
	canvasCtx.fillStyle = 'rgba(0,255,0,0.7)';
	//прояна на цвета на border-a
	canvasCtx.strokeStyle = '#F0F';
	canvasCtx.lineWidth = "5";

	//canvasCtx.beginPath(); 
	//първите два координати са центъра на окръжността, 
	//третия радиуса на окръжността, която искаме, четвъртия от кой ъгъл започва
	//canvasCtx.arc(200, 200, 100, 0, Math.PI); 
	// //цяла окръжност
	// canvasCtx.arc(200, 200, 100, 0, 2 * Math.PI);
	// canvasCtx.moveTo(550, 200);
	// canvasCtx.arc(450, 200, 100, 0, 2 * Math.PI);
	//125 са градусите, а формулата на радиан е: radians = degrees * PI/180
	//canvasCtx.arc(200, 200, 100, 0, 125 * Math.PI / 180);
	//за да начертаем остатъка на 360-125 пишем
	// canvasCtx.arc(200, 200, 100, 0, 125 * Math.PI / 180, true);
	// //линия до центъра(центъра ми е 200,200)
	// canvasCtx.lineTo(200, 200);
	//canvasCtx.closePath();

	canvasCtx.arc(200, 200, 100, 0, 2 * Math.PI);
	//да направя линия между кръговете вместо 0 му казвам да започва от Math.PI
	canvasCtx.arc(450, 200, 100, Math.PI, 3 * Math.PI);	
	canvasCtx.stroke();
	canvasCtx.fill();
	
	// canvasCtx.arc(60, 47, 30, 0, 2 * Math.PI);
	// canvasCtx.arc(60, 47, 30, 0, 2 * Math.PI);
	};
