'use strict'

window.addEventListener('load', function(){
	displayBreadcrumb()
	displayProductInfo()
	initEventListeners()
})

var product = products[session.data.productIndex]

function breadcrumbTemplate(p){
	var d = '<li>Home</li>'
	d += '<li class="breadcrumb_arrow"> > </li>'
	d += '<li>Clothing</li>'
	d += '<li class="breadcrumb_arrow"> > </li>'
	d += '<li>' + p.category + '</li>'
	d += '<li class="breadcrumb_arrow"> > </li>'
	d += '<li>' + p.name + '</li>'
	return d;

}

function displayBreadcrumb(){
	el('breadcrumb').innerHTML = breadcrumbTemplate(products[session.data.productIndex])
}

function displayProductInfo(){
	el('catalogImage').src = 'images/' + product.catalogImage
	el('brandLogo').src = 'images/' + product.brandLogo
	el('name').innerHTML = product.name
	el('brand').innerHTML = product.brand
	el('price').innerHTML = formatMoney(product.price)
	el('detailsBrand').innerHTML = product.brand
	el('detailsName').innerHTML = product.name
	el('detailsSku').innerHTML = sku()
	el('brandInfoLogo').src = 'images/' + product.brandLogo
	el('reviewsBrand').innerHTML = product.brand
	el('reviewsName').innerHTML = product.name
	el('description').innerHTML = product.description
	document.title = 'Online Fashion - ' + product.name
	
}

var tabCtrl = function(arg){
	var panels = []
	var c = arg.panels.length
	for(var i = 0; i < c; i++) panels.push(el(arg.panels[i]))
	
	var selected = 0
	
	var tabs = el(arg.tab).getElementsByTagName('li')
	
	function selectTab(index){
	
		return function(){
		tabs[selected].className = ''
		panels[selected].style.display = 'none'
		
		selected = index
		tabs[selected].className = 'selected_tab'
		panels[selected].style.display = 'block'}
	}
	
	function init(){
		for(var i = 0; i < c; i++) tabs[i].addEventListener('click', selectTab(i))
	}
	
	return{
		init:init
	}

}


function initEventListeners(){

	var tab = tabCtrl({tab:'tabCtrl', panels:['detailsPanel','brandInfoPanel','reviewsPanel']})
	tab.init()
	
	el('btnAdd').addEventListener('click', function(){
		cart.addItem({
			name: products[session.data.productIndex].name,
			price: products[session.data.productIndex].price,
			quantity: 1
		})
		
		displayHeaderInfo()
		getNextStep(products[session.data.productIndex].name)
	})

}

function gotoCheckout(){
	top.location.href = 'shoppingbag.htm'
}

function gotoIndex(){
	top.location.href = 'index.htm'
}

function getNextStep(name){
	var d = '<span>'+name + ' has been added to your shopping bag.</span>'
	d += '<br/><input class="large_button" type="button" value="Continue Shopping" onclick="gotoIndex()">'
	d += '<input class="large_button" type="button" value="Checkout" onclick="gotoCheckout()">'
	el('overlayContent').innerHTML = d
	el('overlay').style.display = 'block'
}