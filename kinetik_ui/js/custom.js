$(function(){

    //Selectmenu
    $('.forcewidth').selectmenu({width:120});
    $('select').selectmenu();

    //Table Odd/Even styles
   $("table:not(.simple) tr:nth-child(odd)").addClass("odd"); // Table Odd/Even
   $("table:not(.simple) tr:nth-child(even)").addClass("even"); // Table Odd/Even

   //input titles to label
   $(":text").labelify({labelledClass: "inputHighlight" });

  //Gallery pop-ins
   $('.gallery .hor-list').each(function(){
        $(this).hide();
    });

    $('.gallery li img').hover(function(){
        $(this).next('.hor-list').show();
    }, function(){
       $(this).next('.hor-list').hide();
    });
    
    $('.quickFlip').quickFlip();
    
	

    //jQuery UI Tabs
   $('.tabs').tabs();
   //jQuery UI Slider
    $( ".slider" ).slider();
    $(".slider-range").slider({
            range: true,
            min: 0,
            max: 500,
            values: [ 75, 300 ]
    });
    
   //jQuery UI Progressbar
   $( ".progressbar" ).progressbar({
            value: 67
    });

    //jQuery UI Datepicker
    $( ".datepicker" ).datepicker();

    //Datatable
    /*$('.dataTable').dataTable({
        "sPaginationType": "full_numbers",
        "bJQueryUI": true
    });*/

    // Menu
    $('ul.sf-menu').superfish();

    // wysiwyg editor
    /*$(".editor").cleditor({
        width: 625
    });*/

    // message fadeout on click
    $('.msg').click(function(){
		$(this).fadeOut();
		return false;
	});
	
	$('.close').click(function(){
		$(this).parent().fadeOut();
		return false;
	});
	
	$('#dateform').datepicker();
	$('#dateto').datepicker();
	
	function readURL(input) {
        if (input.files && input.files[0]) {
        	//alert('test');
            var reader = new FileReader();
            
            reader.onload = function (e) {
                $('#blah').attr('src', e.target.result);
            }
            
            reader.readAsDataURL(input.files[0]);
        }
    }
    
    $("#imgInp").change(function(){
        readURL(this);
    });
    $("#offer_title").change(function(){
        var offer_title = $(this).attr('value');
        $('.display_title').html(offer_title);
    });
    
    
    $('#offer_name').change(function(){
	    if($(this).val() == 1){
		    $('#percentage-button').show();
		    var offervalue = $('#percentage').find(":selected").text();
			$('.display_offer').html(offervalue);
		    $('#buyx-button').hide();
		    $('#cashback').hide();
	    } else if ($(this).val() == 3) {
	    	$('#buyx-button').show();
	    	var buyxvalue = $('#buyx').find(":selected").text();
			$('.display_offer').html(buyxvalue);
		    $('#percentage-button').hide();
		    $('#cashback').hide();
	    }else if ($(this).val() == 2) {
	    	$('#buyx-button').hide();
		    $('#percentage-button').hide();
		    $('#cashback').show();
		    var cashback = $('#cashback').attr('value');
			$('.display_offer').html(cashback + ' dollars cash back');
	    } else {
		    $('#percentage-button').hide();
		    $('#buyx-button').hide();
		    $('#cashback').hide();
		    var offervalue = $(this).find(":selected").text();
		    //alert(offervalue);
		    $('.display_offer').html(offervalue);
	    }
    });
    
    $('#percentage').change(function(){
	    var offervalue = $(this).find(":selected").text();
	    $('.display_offer').html(offervalue);
    });
    
    $('#buyx').change(function(){
	    var buyxvalue = $(this).find(":selected").text();
	    $('.display_offer').html(buyxvalue);
    });
    
    $('#cashback').change(function(){
	    var cashback = $(this).attr('value');
	    $('.display_offer').html(cashback + ' dollars cash back');
    });
	
	$('#percentage-button, #buyx-button, #cashback').hide();
	
	$("#offer_detail").change(function(){
        var offer_detail = $(this).attr('value');
        $('.display_contents').html(offer_detail);
    });
    
    $("#dateform").change(function(){
        var offer_start = $(this).attr('value');
        $('.offer_start span').html(offer_start);
    });
    
    $("#dateto").change(function(){
        var offer_end = $(this).attr('value');
        $('.offer_end span').html(offer_end);
    });
    
    $(".redemp-method1").change(function(){
        var redemp = $(this).attr('value');
        if (redemp == '1')
            {
                $('.redemp_method').html('<img src="images/barcode.jpg">');
            }else if(redemp == '2'){
                $('.redemp_method').html('Show this Offer to the staff member at the time of purchase to redeem your offer');
            }else if(redemp == '3'){
                $('.redemp_method').html('Once your transaction has been completed your discount will be credited back to your account');
            }else if(redemp == '4'){
                $('.redemp_method').html('<img src="images/nfc.jpg">');
            }
            else
            {
                $('.redemp_method').html('');
            }
        
        
    });
    
});

$(document).ready(function() {
     $('#offer_name').val('0').click();
     /*$('.basic_btn').click(function(){
     	$('#basic_info').fadeOut(function(){
	     	$('#more_info').fadeIn();
     	});
	    
	     
     });
     $('.more_btn').click(function(){
     	$('#more_info').fadeOut(function(){
	     	$('#basic_info').fadeIn();
     	});
	    
	     
     });*/
 });
