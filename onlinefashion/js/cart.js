'use strict'


function now(){
	var dte = new Date();
	var year = dte.getFullYear().toString().substr(2,2);
	var month = dte.getMonth() + 1;
	month = month < 10? '0'+month.toString() : month.toString();
	var date = dte.getDate();
	date = date < 10? '0'+date.toString() : date.toString();
	return date.toString()+month.toString()+year.toString();
}

function receiptNo(){
	var r=rand
	return r(10)+r(10)+r(10)+now()
}  

var cart = (function(){
	var repoName = 'onlinefashion'
	var _cart = {}
	_cart.grandTotal = 0
	_cart.itemCount = 0
	var repo = localStorage[repoName]
	
	if(repo !== undefined && repo !== '') _cart = JSON.parse(repo) 

	function addItem(item){
		if(_cart.items === undefined) _cart.items = []
		item.total = item.price * item.quantity
		_cart.grandTotal += item.total
		_cart.items[_cart.items.length] = item
		_cart.itemCount += item.quantity
		save()
	}
	
	function getItem(name){
		if(_cart.items === undefined || _cart.items.length === 0) return null
		var c = _cart.items.length
		for(var i = 0; i < c; i++){
			if(_cart.items[i].name === name) return _cart.items[i]
		}
		return null
	}
	
	function recompute(){
		var c = _cart.items.length
		_cart.grandTotal = 0
		_cart.itemCount = 0
		for(var i = 0; i < c; i++){
			_cart.items[i].itemTotal = _cart.items[i].price * _cart.items[i].quantity
			_cart.grandTotal += _cart.items[i].itemTotal
			_cart.itemCount += _cart.items[i].quantity
		}
	}
	
	function updateItem(item){
		if(_cart.items === undefined || _cart.items.length === 0) return null
		
		var c = _cart.items.length
		for(var i = 0; i < c; i++){
		
			if(_cart.items[i].name === item.name){
				_cart.items[i] = item;
				recompute()
				save()
				return _cart.items[i]
			}
		}
		
		return null
	}
	
	function removeItemByIndex(index){
		if(_cart.items === undefined || _cart.items.length === 0) return
		if(index < 0 || index >= _cart.items.length) return
		_cart.grandTotal -= _cart.items[index].total
		_cart.itemCount -= _cart.items[index].quantity
		_cart.items.splice(index,1)
		save()		
	}
	
	function removeItem(name){
		if(_cart.items === undefined || _cart.items.length === 0) return
		var c = _cart.items.length
		for(var i = 0; i < c; i++){
			if(_cart.items[i].name === name){
				_cart.grandTotal -= _cart.items[i].total
				_cart.itemCount -= _cart.items[i].quantity
				_cart.items.splice(i,1)
				save()
				return
			}
		}
	}
	
	function save(){
		localStorage[repoName] = JSON.stringify(_cart)
	}
	
	function clear(){
		_cart.items = []
		_cart.grandTotal = 0
		_cart.itemCount = 0
		localStorage.removeItem(repoName)
	}
	
	return{
		data:_cart,
		addItem:addItem,
		removeItem:removeItem,
		removeItemByIndex:removeItemByIndex,
		clear:clear,
		getItem:getItem,
		updateItem:updateItem,
	}
})()

/*****
cart.addItem({
	name:'item1',
	price:1.25,
	quantity:3
})

cart.addItem({
	name:'item2',
	price:1.35,
	quantity:2
})

cart.removeItem('item1')
*****/
