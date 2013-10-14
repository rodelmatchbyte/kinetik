function setAccountInfo(){

	
	var logo = el('headerLogo')
	if(logo !== null) logo.src = '../logos/' + session.data.logo
	
	var name = el('headerAccountName')
	if(name !== null) name.innerHTML = session.data.accountName
}

window.addEventListener('load', function(){
	setAccountInfo()
})


if(session.data.hash === undefined) top.location.href = 'login.php'


