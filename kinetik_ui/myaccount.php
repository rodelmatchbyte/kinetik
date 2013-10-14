<?php
if(isset($_GET['sidebar'])){
    include('s_header.php');
} else {
    include('header.php');
}
?>

        <div id="pagetitle" class="clearfix">
            <h1 class="left">My Account</h1>
            <!--<a class="btn grey right medium"><span>View Site</span></a>-->
        </div>
    </div>
</header>
<div class="container_16 clearfix" id="actualbody">
<ul class="breadcrumbs first">
    <li><a href="#">Home</a></li>
    <li class="active"><a href="#">My Account</a></li>
</ul>

    <div class="grid_16 widget first">
        <div class="widget_title clearfix">
            <h2>My Account</h2>
        </div>
        <div class="widget_body">
		<form id="save_account" method="POST" name="save_account" action="../ws/api/account" enctype="multipart/form-data" target="_hidden_">
			<input type="hidden" name="id" value="1"/>
	        <table>
	            <tr>
	                <td width="250px"><label for="email">Account Email</label></td>
	                <td><input id="email" type="text" name="email" value="sales@jbhifi.com" /></td>
	            </tr>
	            <tr>
	                <td width="250px"><label for="name">Account Name</label></td>
	                <td><input id="name" type="text" name="name" value="Jb Hifi" /></td>
	            </tr>
	            <tr>
	                <td width="250px"><label for="category">Category</label></td>
	                <td>
		                <select id="category" name="category">
		                	<option value="0">Select Your Category</option>
		                	<option value="1">Accountants</option>
		                	<option value="2">Appliances Sales/Repair Services</option>
		                	<option value="3">Electrical Services/Supplies</option>
		                	<option value="4">Real Estate</option>
		                </select>
	                </td>
	            </tr>
	            <tr>
	                <td width="250px"><label >Logo</label></td>
	                <td><input id="slctLogo" type="file" name="logo"/><img class="imgLogo" alt="" id="imgLogo"/></td>
	            </tr>
	            <tr>
	                <td><label for="password">Password</label></td>
	                <td><input id="password" type="password" name="password" class=":required"/></td>
	            </tr>
	            <tr>
	                <td><label for="confirmpassword">Confirm Password</label></td>
	                <td><input id="confirmpassword" name="confirmpassword" type="password" class=":required"/></td>
	            </tr>
	            <tr>
	                <td></td>
	                <td style="padding:9px 5px 15px"><a id="btnSave" href="javascript:void(null)"  
					class="btn medium"><span>Save</span></a><br /></td>
	            </tr>
	        </table>
			</form>
			<iframe id="_hidden_" name="_hidden_" style="width:0px; height:0px; visibility:hidden" src=""></iframe>
        </div>
    </div>

	<div class="clear"></div>
	<script type="text/javascript" src="js/tools.js"></script>
	<script type="text/javascript" src="js/ajax.js"></script>
	<script type="text/javascript" src="js/config.js"></script>
	<script type="text/javascript" src="js/myaccount.js"></script>
<?php include("footer.php") ?>