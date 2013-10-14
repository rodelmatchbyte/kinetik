
window.addEventListener('load', function(){

	el('btnSave').addEventListener('click', function(){
		document.save_account.submit()
	})
	
	el('_hidden_').onload = function(){
		var json = JSON.parse(frames['_hidden_'].window.document.body.getElementsByTagName('pre')[0].innerHTML)
		updateSession(json)
		setLogo(json.Logo)
		alert(json.Name + ' saved.')
	}
	
	getAccount()
})


function getAccount(){
	ajax.get({
		url: config.WS_ROOT + 'api/account/' + session.data.accountId,
		callback:displayAccount
	});
}

function updateSession(json)
{
	session.data.accountName = json.Name
	
	if(json.Logo !== '') session.data.logo = json.Logo
	
	session.save()
	setAccountInfo()
}

function setLogo(url){
	if(url !== '') el('imgLogo').src = '../logos/' + url
}

function displayAccount(str){
	if(str === '') return
	var json = JSON.parse(str)
	el('email').value = json.Email
	el('name').value = json.Name
	el('category').value = json.Category
	el('category-button').firstChild.innerHTML = el('category').options[parseInt(json.Category)].innerHTML
	//el('imgLogo').src = '../logos/' + json.Logo
	setLogo(json.Logo)
	el('password').value = json.Password
}