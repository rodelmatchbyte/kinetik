window.addEventListener('load', function(){

	el('btnLogin').addEventListener('click', function(){
		ajax.post({
			url: config.WS_ROOT + 'api/login',
			callback: OnLogin,
			parameters: {'username': el('username').value, 'password': el('password').value}
		})
	})
})

function OnLogin(json){
	if(json === "") {
		alert('Server error encountered. Please contact the site administrator.')
		return
	}
	
	json = JSON.parse(json)
	
	if(json.Message !== undefined){
		alert(json.Message)
		el('username').value = ''
		el('password').value = ''
		return
	}
	
	session.save({accountId:json.Id, accountName:json.Name, logo:json.Logo, hash:json.Hash})
	
	top.location.href = 'index.php'
	
	
}