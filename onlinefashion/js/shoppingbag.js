'use strict'

window.addEventListener('load', function(){
	displayItems()
	displaySummary()
	
	el('btnBuyNow').addEventListener('click', onBtnBuyNow)
})

function onBtnBuyNow(){
	renderPartial('paymentOverlayContent', 'paymentoverlay.htm', onPaymentOverlay)
}

function onPaymentOverlay(){
	el('paymentOverlay').style.display = 'block'
	setCheckoutEventListeners()
}

function getSelectTemplate(index, item){
	var d = '<select onchange="updateItem(' + index + ', this)" size="1">'
	for(var i = 1; i < 6; i++){
		d += '<option '
		if(i == item.quantity) d+= 'selected="selected"'
		d += '>' + (i) + '</option>'
	}
	d+= '</select>'
	return d;
}

function getItemTemplate(index, item){
	var d = '<tr>'
	d += '<td><input type="button" value="REMOVE" onclick="removeItem(' + index + ', this)">' + item.name + '</td>'
	d += '<td>Quantity'
	d += getSelectTemplate(index, item) 
	d += '</td>'
	d += '<td>Ships 1-4 business days</td>'
	d += '<td>AUD $' + formatMoney(item.total) + '</td>' 
	d += '</tr>'
	return d
}

function updateItem(index, slct){
	var item = cart.data.items[index]
	item.quantity = parseInt(slct.value)
	cart.updateItem(item)
	displayHeaderInfo()
	displaySummary()
}

function removeItem(index, el){
	el.parentNode.parentNode.outerHTML = ''
	cart.removeItemByIndex(index)
	displayHeaderInfo()
	displaySummary()
	
}

function displaySummary(){
	el('priceSummarySubtotal').innerHTML = formatMoney(cart.data.grandTotal)
	el('priceSummaryGrandTotal').innerHTML = formatMoney(cart.data.grandTotal)
}

function displayItems(){
	if(cart.data.itemCount <= 0) top.location.href = 'index.htm';
	
	var c = cart.data.items.length
	var d = ''
	for(var i = 0; i < c; i++)
		d += getItemTemplate(i, cart.data.items[i])

	el('tblItems').innerHTML = d
}