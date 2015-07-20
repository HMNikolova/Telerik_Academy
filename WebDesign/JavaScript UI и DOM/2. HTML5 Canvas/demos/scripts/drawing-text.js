(function () {
	var canvas = document.getElementById('the-canvas'),
		ctx = canvas.getContext('2d'),
		// ctx.fillStyle = 'rgba(0,255,0,0.7)';
	 //    ctx.strokeStyle = '#F0F';
	 //    ctx.lineWidth = "5";
	    
	 //    var text = 'some text';
	 //    ctx.font = '100px Arial';
	 //    ctx.fillText(text, 50, 150);
	 //    ctx.strokeText(text, 50, 150);
	 //    var width = ctx.mesureText(text).width;

	 //    ctx.beginPath();
	 //    ctx.strokeStyle = '#0F0';
	 //    ctx.moveTo(50, 50);
	 //    ctx.lineTo(50 + width, 50);

	 //    ctx.beginPath();
	 //    ctx.strokeStyle = '#000';
	 //    ctx.moveTo(50, 170);
	 //    ctx.lineTo(50 + width, 170);
	 //    ctx.stroke();

	 //    ctx.strokeStyle = '#000';
	 //    ctx.fillText(text, 50, 250);
	 //    ctx.strokeText(text, 50, 250);

		text,
		x = 50,
		y = 50,
		minFontSize,
		fontFamily,
		fillColor,
		strokeColor,
		currentFontSize,
		offset;

	offset = 5;
	minFontSize = '28';
	fontFamily = 'Arial';
	fillColor = 'yellowgreen';
	strokeColor = '#003311';
	text = 'Telerik  Academy';
	ctx.fillStyle = 'yellowgreen';
	ctx.strokeStyle = '#003311';

	currentFontSize = 48;
	 while (minFontSize <= currentFontSize) {
	 	ctx.font = currentFontSize + 'px ' + fontFamily;
	 	ctx.fillText(text, x, y);
	 	ctx.strokeText(text, x, y);
	 	y += currentFontSize + offset;
	 	currentFontSize -= 4;
	 }
}());