<?php
if(isset($_GET['sidebar'])){
    include('s_header.php');
} else {
    include('header.php');
}
?>

        <div id="pagetitle" class="clearfix">
            <h1 class="left">Create New Offer</h1>
            <!--<a class="btn grey right medium"><span>View Site</span></a>-->
        </div>
    </div>
</header>
<div class="container_16 clearfix" id="actualbody">
	<ul class="breadcrumbs first">
	    <li><a href="#">Home</a></li>
	    <li class="active"><a href="#">Create New Offer</a></li>
	</ul>
	<div class="clear"></div>

    <div class="grid_10 widget first">
        <div class="widget_title clearfix">
            <h2>Create New Offer</h2>
        </div>
        <div class="widget_body">
		
        	<form id="create_offer" method="POST" name="create_offer" action="../ws/api/offer" enctype="multipart/form-data">
				<input type="hidden" name="account_id" value="1"/>
		        <table>
		            <tr>
		                <td width="20%"><label for="title">Title</label></td>
		                <td><input id="offer_title" type="text" name="title" class=":required"/></td>
		            </tr>
		            <tr>
		                <td><label for="offer">Offer</label></td>
		                <td>
		                	<select id="offer_name" name="offer_name">
		                		<option value="0">Select offer type</option>
		                		<option value="1">% Off</option>
		                		<option value="2">Cash Back</option>
		                		<option value="3">Buy x get 1 free</option>
		                		<option value="4">2 for 1</option>
							</select>
							<select id="percentage" name="percentage">
		                		<option value="0">Select Percentage</option>
		                		<option value="5">5% off</option>
		                		<option value="10">10% off</option>
		                		<option value="15">15% off</option>
		                		<option value="20">20% off</option>
		                		<option value="25">25% off</option>
		                		<option value="30">30% off</option>
		                		<option value="35">35% off</option>
		                		<option value="40">40% off</option>
		                		<option value="45">45% off</option>
		                		<option value="50">50% off</option>
							</select>
							<select id="buyx" name="buyx">
		                		<option value="0">Select value</option>
		                		<option value="1">Buy 1 get 1 free</option>
		                		<option value="2">Buy 2 get 1 free</option>
		                		<option value="3">Buy 3 get 1 free</option>
		                		<option value="4">Buy 4 get 1 free</option>
		                		<option value="5">Buy 5 get 1 free</option>
							</select>
							<input id="cashback" name="cashback" type="text" value="$">
		                </td>
		            </tr>
		            <tr>
		                <td><label for="Start">Start</label></td>
		                <td><input id="dateform" name="start" type="text" class=":required"/></td>
		            </tr>
		            <tr>
		                <td><label for="title">End</label></td>
		                <td><input id="dateto" type="text" name="end" class=":required"/></td>
		            </tr>
		            <tr>
		                <td><label for="image">Image</label></td>
		                  <td><input id="imgInp" type="file" name="image" class=":required"/></td>
		            </tr>
		            <tr>
		                <td><label for="stores">Stores</label></td>
		                <td><input id="stores" type="text" name="stores" class=":required"/></td>
		            </tr>
		            <tr>
		                <td><label for="title">Text</label></td>
		                <td><textarea  name="offer_detail" id="offer_detail"></textarea></td>
		            </tr>
		            <tr>
		                <td><label for="target_aud">Target Audience</label></td>
		                <td>
			                <select name="target_aud" id="target_aud">
		                		<option value="0">Select Target Audience</option>
		                		<option value="1">All Customers</option>
		                		<option value="2">Previous Customers</option>
		                		<option value="3">Customers who 'Liked' us</option>
		                		<option value="4">Custom Demographic</option>
		                		<option value="5">Targeted Location</option>
		                		<option value="6">Limited Wallets</option>
							</select>
		                </td>
		            </tr>
		            <tr>
		                <td><label for="method">Method</label></td>
		                <td>
			                <select name="redemp_method" id="redemp_method1" class="redemp-method1">
		                		<option value="0">Select value</option>
		                		<option value="1">On screen Barcode</option>
		                		<option value="2">Show & Save</option>
		                		<option value="3">Post Txn Reimbursement</option>
		                		<option value="4">NFC Coupon</option>
							</select>
		                </td>
		            </tr>
		            <tr>
		                <td></td>
		                <td style="padding:9px 5px 15px"><a id="btnLoadOffer" href="javascript:void(null)" class="btn medium"><span>Load Offer</span></a><br /></td>
		            </tr>
		        </table>
        	</form>			
        </div>
    </div>
	<div class="grid_6 widget">
		<div class="widget_title clearfix">
            <h2>Display</h2>
        </div>
        <div class="widget_body">
        	<div id="display_container">
        		<div id="offer_container" class="clearfix">
        			<h1>Offer</h1>
        			<div class="quickFlip">
	        			<div id="offer_container2">
	        				<div id="basic_info">
	        					<div class="basic_btn quickFlipCta">
				        			<div class="display_logo"><img id="companyLogo"  alt="" /></div>
						        	<div class="display_title">Offer title</div>
						        	<div class="display_offer">Offer type</div>
						        	<div class="clear"></div>
				        				
						        	<img id="blah" src="images/placeholder.jpg" alt="your image" />
						        	<div class="info_div">Tap Offer for more details</div>
						        	<a class="btn_edit"><img src="images/btn_edit.jpg"></a>
						        	<a class="btn_delete"><img src="images/btn_delete.jpg"></a>
						        	<div class="clear"></div>
	        					</div>
							</div>
	        			</div>
	        			<div id="offer_container3">
							<div id="more_info">
					        	<div class="more_btn quickFlipCta">
					        		<div class="display_contents">
						        	Offer's Details
						        	</div>
						        	<div id="redemp_method" class="redemp_method">
						        	</div>
						        	
						        	<div class="condition_div">
						        		<h2>Conditions</h2>
							        	<div class="offer_start">
							        		<label>Offer Start:</label>
							        		<span>Date</span>
							        	</div>
							        	<span> - </span>
							        	<div class="offer_end">
							        		<label>Offer End:</label>
							        		<span>Date</span>
							        	</div>
						        	</div>
						        	<a class="btn_edit"><img src="images/btn_edit.jpg"></a>
						        	<a class="btn_delete"><img src="images/btn_delete.jpg"></a>
									
									<div class="clear"></div>
								</div>
							</div>
        				</div>
					</div>
        		</div>
        	</div>
        </div>
	</div>
	<div class="clear"></div>
	
<script type='text/javascript' src='js/config.js'></script>
<script type='text/javascript' src='js/tools.js'></script>
<script type='text/javascript' src='js/ajax.js'></script>
<script type="text/javascript" src='js/create.js'></script>

<?php include("footer.php") ?>