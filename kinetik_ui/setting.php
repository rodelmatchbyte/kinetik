<?php
if(isset($_GET['sidebar'])){
    include('s_header.php');
} else {
    include('header.php');
}
?>

        <div id="pagetitle" class="clearfix">
            <h1 class="left">Setting</h1>
            <!--<a class="btn grey right medium"><span>View Site</span></a>-->
        </div>
    </div>
</header>
<div class="container_16 clearfix" id="actualbody">
<ul class="breadcrumbs first">
    <li><a href="#">Home</a></li>
    <li class="active"><a href="#">Setting</a></li>
</ul>

    <div class="grid_16 widget first">
        <div class="widget_title clearfix">
            <h2>Setting</h2>
        </div>
        <div class="widget_body">
	        <table>
	            <tr>
	                <td width="250px"><label for="accountname">Redemption method</label></td>
	                <td>
		                <select>
		                	<option value="0">Select Your method</option>
		                	<option value="1">Onscreen Barcode</option>
		                	<option value="1">Show & Save</option>
		                	<option value="1">Post Txn Reimbursement</option>
		                	<option value="1">NFC eGift Card</option>
		                </select>
	                </td>
	            </tr>
	            <tr>
	                <td width="250px"><label >Link to POS</label></td>
	                <td>
		                <select>
		                	<option value="0">Select Your method</option>
		                	<option value="1">eReceipts</option>
		                	<option value="1">Basket Details</option>
		                	<option value="1">Enabe eGift Cards</option>
		                	<option value="1">Bar Code Scanner</option>
		                </select>
	                </td>
	            </tr>
	            <tr>
	                <td></td>
	                <td style="padding:9px 5px 15px"><a href="#" class="btn medium"><span>Save</span></a><br /></td>
	            </tr>
	        </table>
        </div>
    </div>

	<div class="clear"></div>
	
<?php include("footer.php") ?>