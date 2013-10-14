'use strict'

window.addEventListener('load', function(){
	displayProducts()
})

function template(i,p){
	var d = '<li onmouseout=onMouseout('+i+',this) onmouseover=onMouseover(' + i + ',this) onclick="selectProduct(' + i + ')">'
	d+= '<img alt="' + p.name + '" src="images/' + p.url + '" >'
	d += '<div>'+p.brand+'</div>'
	d += '<div>'+p.name+'</div>'
	d += '<div class="price">$'+p.price+'</div></li>'
	d += '</li>'
	return d
}

function onMouseout(i, e){
	e.getElementsByTagName('img')[0].src = 'images/'+products[i].url
}

function onMouseover(i, e){
	e.getElementsByTagName('img')[0].src = 'images/'+products[i].onhover;
}

function displayProducts(){
	var d = '';
	var c = products.length;
	for(var i = 0; i < c ; i++) d += template(i, products[i])
	el('products').innerHTML = d
}

function selectProduct(i){
	session.save({productIndex:i})
	top.location.href = 'catalog.htm'
}