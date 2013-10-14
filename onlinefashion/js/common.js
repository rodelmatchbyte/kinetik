'use strict'

window.addEventListener('load', function(){
	renderPartial('page_header', 'header.htm', displayHeaderInfo)
	renderPartial('page_footer', 'footer.htm')
})

function getQuantityStr(){
	var c = cart.data.itemCount
	var d = c.toString() + ' item'
	if(c > 1) d += 's'
	return d
}

function displayHeaderInfo(){
	el('headerQuantity').innerHTML = getQuantityStr()
	el('headerTotal').innerHTML = formatMoney(cart.data.grandTotal)
}
