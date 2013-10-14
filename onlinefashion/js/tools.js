'use strict'

var el = function(id){
	return document.getElementById(id)
}

var renderPartial = function(id, url, callbackFunc){
	ajax.get({
		url: url,
		content_type: 'text/plain',
		callback: function(content){
			var elem = el(id)
			if(elem !== null) elem.innerHTML = content
			if(callbackFunc !== undefined) callbackFunc()
		}
	})
}

function rand(limit){
	return Math.floor(Math.random() * limit).toString();
}

function formatMoney(num){
	num = num.toString()
	if(num === '0') return '0.00'
	var i = num.indexOf('.')
	if(i === -1){ 
		return num+'.00'
	} else{
		var d = num.substring(i+1)
		if(d.length === 1) num = num + '0'
		return num
	}
	
}
