var session = (function(){

	var _session = {}
	
	if(sessionStorage.kinetik != undefined) _session = 
		JSON.parse(sessionStorage.kinetik)
	
	function save(arg){
		if(arg !== undefined){
			if(arg.accountId !== undefined) _session.accountId = arg.accountId
			if(arg.logo != undefined) _session.logo = arg.logo
			if(arg.hash != undefined) _session.hash = arg.hash
			if(arg.accountName != undefined) _session.accountName = arg.accountName	
		}

		
		sessionStorage.kinetik = JSON.stringify(_session)
	}
	
	return{
		data:_session,
		save: save
	}
})()
