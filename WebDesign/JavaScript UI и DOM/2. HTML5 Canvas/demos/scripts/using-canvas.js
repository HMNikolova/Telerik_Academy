window.onload = function () {
	var theCanvas = document.getElementById("the-canvas");
	//искам 2d картинка
	var canvasCtx = theCanvas.getContext("2d");
	//може да си направим цвят на фигурата
	canvasCtx.fillStyle = 'rgba(0,255,0,0.7)';
	//колко дебела да е линията
	canvasCtx.lineWidth = "5";
	
	//цифрите са както следва: x,y,width,height
	canvasCtx.strokeRect(100, 70, 250, 400);
	//така ще запълним фигурата
	canvasCtx.fillRect(100, 70, 250, 400);
	
	canvasCtx.fillStyle = 'rgba(255,0,0,0.7)';
	canvasCtx.fillRect(260, 100, 250, 400);
	canvasCtx.strokeRect(260, 100, 250, 400);
	
	
	//canvasCtx.beginPath();
	//canvasCtx.arc(60, 47, 30, 0, 2 * Math.PI);
	//canvasCtx.fill();
	//canvasCtx.arc(60, 47, 30, 0, 2 * Math.PI);
	//canvasCtx.stroke();
	
};