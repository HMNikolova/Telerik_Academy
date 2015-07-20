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
	var theCanvas = document.getElementById("the-canvas");
	var canvasCtx = theCanvas.getContext("2d");
	canvasCtx.fillStyle = 'rgba(0,255,0,0.7)';
	//прояна на цвета на border-a
	canvasCtx.strokeStyle = '#F0F';
	canvasCtx.lineWidth = "5";

	canvasCtx.beginPath(); 
	canvasCtx.moveTo(50, 50);
	canvasCtx.lineTo(100, 70);
	canvasCtx.lineTo(50, 200);
	canvasCtx.closePath();
	//stroke ни начертава линиите
	canvasCtx.stroke();
	canvasCtx.fill();
	
	// canvasCtx.arc(60, 47, 30, 0, 2 * Math.PI);
	// canvasCtx.arc(60, 47, 30, 0, 2 * Math.PI);
	
};