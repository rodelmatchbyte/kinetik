'use strict'
var ajax = (function () {

    //----------
    // private methods
    //----------
    
    function send(method, arg) {
        var request = window.XMLHttpRequest ? 
        	new XMLHttpRequest() : new ActiveXObject('Microsoft.XMLHTTP');
        setCallback(request, arg);
        request.open(method, arg.url, true);
		if(arg.content_type !== undefined) content_type=arg.content_type
        request.setRequestHeader('Content-type', content_type);
        request.send(parameters(arg));
    }

	var content_type = 'application/x-www-form-urlencoded' //default
	
    function post(arg) {
        send('POST', arg);
    }

    function put(arg) {
        send('PUT', arg);
    }

    function del(arg) {
        send('DELETE', arg);
    }

    function get(arg) {
        send('GET', arg)
    }


    function setCallback(request, arg) {
        request.onreadystatechange = function () {
            //if (request.readyState === 4 && request.status === 200) {
            if (request.readyState === 4) {
                arg.callback(request.responseText);
            }
        };
    }

    function parameters(arg) {
        var params = '';

        if (arg.parameters !== undefined) {
            for (var prop in arg.parameters) {
                params += prop + '=' + arg.parameters[prop] + '&';
            }

            // remove the '&' at the end
            params = params.substr(0, params.length - 1);
        }
        return params;
    }

    //----------
    // public methods
    //----------

    return {
        post: post,
        get: get,
        put: put,
        del: del,
    };
})();

/***** 

ajax.post({
	url:'www.url.php',
	content_type:'application/json; charset=utf-8',
	callback:function(json){ do something with the json string here...},
	parameters:{name:'name', age:5}
})

ajax.post({
	url:'sendformdata.html',
	content_type:'application/x-www-form-urlencoded',
	callback:onFormSubmit,
	parameters:{data:getData()}
})

*****/