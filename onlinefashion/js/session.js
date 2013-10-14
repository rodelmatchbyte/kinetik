var session = (function(){

	var _session = {}
	
	if(sessionStorage.onlinefashion != undefined) _session = 
		JSON.parse(sessionStorage.onlinefashion)
	
	function save(arg){
		if(arg !== undefined){
			if(arg.productIndex !== undefined) _session.productIndex = arg.productIndex
		}

		
		sessionStorage.onlinefashion = JSON.stringify(_session)
	}
	
	return{
		data:_session,
		save: save
	}
})()
