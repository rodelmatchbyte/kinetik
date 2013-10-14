'use strict'


function setCheckoutEventListeners(){
	setPaymentOverlayPosition()
	setEventListeners()
}

function setEventListeners(){

	btnContinueEvents()
	btnCancelEvents()
	windowEvents()
	txtCcEvents()
	txtCcvEvents()
	txtCcNameEvents()
	slctEvents()
}

function windowEvents(){

	window.addEventListener('resize', function(){
		setPaymentOverlayPosition()
	})
	
}

function btnCancelEvents(){

	el('btnCancel').addEventListener('click', function(){
		el('paymentOverlay').style.display = 'none'
	})
}

function isValid(){
	var i = el('ccStatus').innerHTML == '' &&
	el('ccvStatus').innerHTML == '' &&
	el('ccNameStatus').innerHTML == '' &&
	el('expirationStatus').innerHTML == ''
	
	return i
}

function btnContinueEvents(){

	el('btnContinue').addEventListener('click', function(){
		
		if(! isValid()) return
		
		if(cart.data.itemCount === 0) gotoIndex()
		
		cart.data.storeName = 'online fashion shop'
		cart.data.transactionDate = new Date()
		cart.data.receiptNo = receiptNo()
		cart.data.creditCard = el('txtCc').value

		ajax.post({
			url:"../ws/api/shopify",
			content_type:"application/json; charset=utf-8",
			callback:OnCheckout,
			parameters:{data:JSON.stringify(cart.data)}
		})
	})
}

var defaults = {}

function txtCcEvents(){

	var cc = el('txtCc')
	var ccStatus = el('ccStatus')
	ccStatus.innerHTML = " Credit card number is required."
	defaults.txtCc = cc.value
	
	cc.addEventListener('keypress', function(evt){
	var code = evt.charCode
	if(code < 48 || code > 57 || cc.value.length >= 16)
		evt.preventDefault()

	})
	
	cc.addEventListener('click', function(){
		if(this.value === defaults.txtCc) this.value = ''
	})
	
	cc.addEventListener('blur', function(){
		if(this.value === '') this.value = defaults.txtCc
	})
	
	cc.addEventListener('change', function(){
	
		ccStatus.innerHTML = ''

		
		if(cc.value == '' || cc.value == defaults.txtCc){

			ccStatus.innerHTML = ' Credit card number is required.'
		} else if(/\D/.test(cc.value)){

			ccStatus.innerHTML = ' Only digits are allowed.'
		} else if(cc.value.length > 16 || cc.value.length < 16){

			ccStatus.innerHTML = ' 16 digits are required.'
		}
		
	})
}

function txtCcvEvents(){

	var ccv = el('txtCcv')
	var ccvStatus = el('ccvStatus')
	ccvStatus.innerHTML = ' Security Code/CCV is required.'
	
	defaults.txtCcv = ccv.value
	
	ccv.addEventListener('keypress', function(evt){
		var code = evt.charCode
		if(code < 48 || code > 57 || ccv.value.length >= 4)
			evt.preventDefault()
	})
	
	ccv.addEventListener('click', function(){
		if(this.value === defaults.txtCcv) this.value = ''
	})
	
	ccv.addEventListener('blur', function(){
		if(this.value === '') this.value = defaults.txtCcv
	})
	

	ccv.addEventListener('change', function(){
		ccvStatus.innerHTML = ''

	
		if(ccv.value == '' || ccv.value == '3 or 4 digits'){

			ccvStatus.innerHTML = ' Security Code/CCV is required.'
		}else if(/\D/.test(ccv.value)){

			ccvStatus.innerHTML = ' Only digits are allowed.'
		} else if(ccv.value.length > 4 || ccv.value.length < 3){

			ccvStatus.innerHTML = ' Three to four digits required.'
		}
	})
	

}

function txtCcNameEvents(){
	var ccName = el('txtCcName')
	defaults.txtCcName = ccName.value
	
	var ccNameStatus = el('ccNameStatus')
	ccNameStatus.innerHTML = ' Name is required.'
	
	ccName.addEventListener('click', function(){
		if(this.value === defaults.txtCcName) this.value = ''
	})

	ccName.addEventListener('blur', function(){
		if(this.value === '') this.value = defaults.txtCcName
	})
	
	ccName.addEventListener('change', function(){
		ccNameStatus.innerHTML = ''


		if(ccName.value == '' || ccName.value == defaults.txtCcName){

			ccNameStatus.innerHTML = ' Name is required.'
		}
	})
}

function slctEvents(){
	var slctYear = el('slctYear')
	var slctMonth = el('slctMonth')
	var expStatus = el('expirationStatus')
	expStatus.innerHTML = ' Expiration year is required. Expiration month is required.'
	
	function validateSelects(){
		expStatus.innerHTML = ''

	
		if(slctYear.selectedIndex == 0){

			expStatus.innerHTML += ' Expiration year is required.'
		}
	
		if(slctMonth.selectedIndex == 0){

			expStatus.innerHTML += ' Expiration month is required.'
		}
	}
	
	slctYear.addEventListener('change', validateSelects)
	
	slctMonth.addEventListener('change', validateSelects)
	
}


var defaults = {}

function receiptNo(){
	var r=rand
	return r(10)+r(10)+r(10)+now()
}

function gotoIndex(){
	top.location.href = 'index.htm'
}

function setPaymentOverlayPosition(){
	var overlayHeight = el('paymentOverlayContent').clientHeight;
	var offset = (window.innerHeight - overlayHeight) / 2
	el('paymentOverlayContent').style.marginTop = offset + 'px';
}

function OnCheckout(){

	cart.clear()
		
	var d = '<span>Thank you for your purchase.<br/> An electronic receipt has been sent to your LogoBank wallet.</span>'
	d += '<br/><input class="large_button" type="button" value="Ok" onclick="gotoIndex()">'
	
	el('overlayContent').innerHTML = d
	el('overlay').style.display = 'block'
}