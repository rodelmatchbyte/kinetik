
function Random(limit){
	return Math.floor(Math.random() * limit);
}

function FormatDate(dte){
	dte = new Date(dte);
	var year = dte.getFullYear().toString().substr(2,2);
	var month = dte.getMonth() + 1;
	month = month < 10? '0'+month.toString() : month.toString();
	var date = dte.getDate();
	date = date < 10? '0'+date.toString() : date.toString();
	return date+'/'+month+'/'+year;
}

function GetOfferRow(arg){
	var r = '';
	
	r+= '<tr id="offer' + arg.row.Id + '"';
	r+= arg.odd ? 'class="odd"' : 'class="even"'
	r += ' >';
	
	r+= '<td><input type="checkbox"/></td>'
	r+= '<td>' + arg.row.Title + '</td>';
	r+= '<td class="center">'+ Random(300) +'k</td>';
	r+= '<td class="center">'+ Random(100) +'%</td>';
	r+= '<td class="center">'+ Random(100) +'%</td>';
	r+= '<td class="center">'+ Random(100) +'%</td>';
	r+= '<td class="center">'+ FormatDate(arg.row.Start) +'</td>';
	r+= '<td class="center"><ul class="hor-list piped">';
	r += '<li><a href="#">View</a></li>';
	r += '<li><a href="#">Edit</a></li>';
	r += '<li><a href="#" onclick="DeleteOffer(' + arg.row.Id + ')">Delete</a></li>';

	r+= '</ul></td>';
	
	r+= '</tr>';
	
	return r;
}


function DeleteOffer(id){
	ajax.del({
		url: config.WS_ROOT + 'api/offer/' + id,
		callback: DeleteRow
	})
}

function DeleteRow(id){
	var row = el('offer'+id)
	row.parentNode.removeChild(row)
}

function ShowCurrentOffers(json){
	if(json === '') return;
	json = JSON.parse(json);
	var currentOffers = el('currentOffers');
	
	var rows = ''
	var c = json.length;
	for(var i=0; i < c; i++)
		rows += GetOfferRow({odd:i%2, row:json[i]});
	
	currentOffers.innerHTML = rows;

}

window.addEventListener('load', function(){

	ajax.get({
		url: config.WS_ROOT + 'api/offer',
		callback: ShowCurrentOffers
	})
	
})


