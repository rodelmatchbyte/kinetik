﻿var ajax = (function () {
    //----------
    // private methods
    //----------
    function send(method, arg) {
        var request = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject('Microsoft.XMLHTTP');
        setCallback(request, arg);
        request.open(method, arg.url, true);
        //request.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
        request.setRequestHeader('Content-type', arg.contentType);
        request.send(parameters(arg));
    }

    function post(arg) {
        arg.contentType = 'application/x-www-form-urlencoded';
        send('POST', arg);
    }

    function put(arg) {
        arg.contentType = 'application/x-www-form-urlencoded';
        send('PUT', arg);
    }

    function del(arg) {
        arg.contentType = 'application/x-www-form-urlencoded';
        send('DELETE', arg);
    }

    function get(arg) {
        /*****
        var request = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject('Microsoft.XMLHTTP');
        setCallback(request, arg);
        request.open('GET', arg.url, true);
        request.setRequestHeader('Content-type', 'application/json');
        request.send(parameters(arg));
        *****/
        arg.contentType = 'application/x-www-form-urlencoded';
        send('GET', arg);
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
        del: del
    };
})();
