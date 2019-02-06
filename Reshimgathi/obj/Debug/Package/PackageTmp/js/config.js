//Javascript.
var config  = {
  Script: "Javascript",
  Version : "v1.0",
  LoadViewPort : function() {
  		console.log("LoadViewPort");
  		var meta = document.createElement('meta');
  		meta.name = "viewport";
		meta.content = "width=device-width, initial-scale=1, maximum-scale=1, user-scalable=0;";
		//<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=0;">
		document.getElementsByTagName('head')[0].appendChild(meta);
    	console.log(meta);
  }
};