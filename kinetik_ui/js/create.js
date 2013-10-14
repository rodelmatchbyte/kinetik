

window.onload = function(){

	document.getElementById('btnLoadOffer').onclick = function(){
		document.create_offer.submit();
		alert('Offer Loaded: '+el('offer_title').value);
		//return false;
	}
	
	getAccount()
}

function getAccount(){
	ajax.get({
		url: config.WS_ROOT + 'api/account/1',
		callback:displayLogo
	});
}

function displayLogo(str){
	var json = JSON.parse(str)
	//alert(json.Logo)
	el('companyLogo').src='../logos/' + json.Logo;
}