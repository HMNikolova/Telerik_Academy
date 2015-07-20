// function invertColorButtonClick() {
// 	var ctx = document.getElementsByTagName("canvas")[0].getContext("2d");
// 	var imageData = ctx.getImageData(0, 0, ctx.canvas.width, ctx.canvas.height);
// 	for (var i = 0; i < imageData.data.length; i += 4) {
// 		imageData.data[i] = 255 - imageData.data[i];
// 		imageData.data[i + 1] = 255 - imageData.data[i + 1];
// 		imageData.data[i + 2] = 255 - imageData.data[i + 2];
// 	}
// 	ctx.putImageData(imageData, 0, 0);
// }

// document.getElementById("invert-colors-btn").addEventListener("click", invertColorButtonClick);

function invertColorButtonClick() {
	var ctx = document.getElementsByTagName("canvas")[0].getContext("2d");
	var imageData = ctx.getImageData(0, 0, ctx.canvas.width, ctx.canvas.height);
	for (var i = 0; i < imageData.data.length; i += 4) {
		var red = imageData.data[i], 
		green = imageData.data[i + 1], 
		blue = imageData.data[i + 2];
		imageData.data[i] = green;
		imageData.data[i + 1] = blue;
		imageData.data[i + 2] = red;
	}
	ctx.putImageData(imageData, 0, 0);
}

document.getElementById("invert-colors-btn").addEventListener("click", invertColorButtonClick);