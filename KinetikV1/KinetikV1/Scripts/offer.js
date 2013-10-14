function ShowOffer() {
    var offerId = document.getElementById('offerId').value;
    ajax.get({
        url: config.WS_ROOT + 'api/offer/' + offerId,
        callback: OnShowOffer
    });
}

function OnShowOffer(json) {
    alert(json);
}

function OnDeleteOffer(json) {
    alert(json);
}

function DeleteOffer() {
    var offerId = document.getElementById('offerId').value;
    ajax.del({
        url: config.WS_ROOT + 'api/offer/' + offerId,
        callback: OnDeleteOffer
    });
}

function OnUpload(json) {
    alert(json);
}

function UploadFile(file) {
    if (document.upload.action === '')
        document.upload.action = config.WS_ROOT + 'api/fileupload/';
    document.upload.submit();
}

function AddOffer() {
    var offer = {};
    offer.Title = document.getElementById('inpTitle').value;
    offer.ImageUrl = document.getElementById('inpImageUrl').value;
    offer.Start = new Date(document.getElementById('inpStart').value);
    offer.End = new Date(document.getElementById('inpEnd').value);

    UploadFile();

    ajax.post({
        url: config.WS_ROOT + "api/offer/",
        callback: OnAddOffer,
        parameters: offer
    });

}

function OnAddOffer(json) {
    alert(json);
    document.getElementById('addOfferStatus').innerHTML = json.toString();
}

function ShowOffers() {
    ajax.get({
        url: config.WS_ROOT + "api/offer/",
        callback: DisplayOffers
    });
}

function DisplayOffers(json) {
    json = JSON.parse(json);
    var c = json.length;
    var offers = '';
    for (var i = 0; i < c; i++) {
        offers += '<li>';
        offers += json[i].Id;
        offers += ' - ' + json[i].Title;
        offers += ' - ' + json[i].ImageUrl;
        offers += ' - ' + json[i].Start;
        offers += ' - ' + json[i].End;
        offers += '</li>';
    }
    document.getElementById('offers').innerHTML = offers;
}

function TestShopify() {
    var param = { };
    param.id = 5;
    param.name = 'shopify_name';
    param.date = new Date();

    ajax.post({
        url: config.WS_ROOT + 'api/shopify',
        parameters:param
    });
}
