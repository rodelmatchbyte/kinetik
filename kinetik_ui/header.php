<!doctype html>
<html>
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" >
	
	<link rel="stylesheet" type="text/css" href="style/style.css" />
        
	<link rel="stylesheet" type="text/css" href="style/fixed.css" title="fixed" media="screen" />
	<link rel="alternate stylesheet" type="text/css" href="style/fluid.css" title="fluid" media="screen" />
	
	<title>Kinetik | Admin Panel</title>

	<script type="text/javascript" src="js/jquery-1.6.1.min.js"></script>
	<script type="text/javascript" src="js/jquery-ui-1.8.14.custom.min.js"></script>
	<script type="text/javascript" src="js/jquery.ui.selectmenu.js"></script>
	<script type="text/javascript" src="js/jquery.labelify.js"></script>
	<script type="text/javascript" src="js/superfish.js"></script>
	<script type="text/javascript" src="js/excanvas.min.js"></script>
    <script type="text/javascript" src="js/jquery.flot.min.js"></script>
    <script type="text/javascript" src="js/jquery.flot.pie.min.js"></script>
    <script type="text/javascript" src="js/jquery.flot.stack.min.js"></script>
    <script type="text/javascript" src="js/jquery.quickflip.min.js"></script>
    
    <script type="text/javascript" src="js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="js/jquery.labelify.js"></script>
    <script type="text/javascript" src="js/iphone-style-checkboxes.js"></script>
    <script type="text/javascript" src="js/jquery.cleditor.min.js"></script>
    <script type="text/javascript" src="js/jquery.colorbox-min.js"></script>
    <script type="text/javascript" src="js/jquery.tipsy.js"></script>
   
    <script type="text/javascript" src="js/fullcalendar.min.js"></script>
    <script type="text/javascript" src="js/jquery.uploadify.v2.1.4.min.js"></script>
    <script type="text/javascript" src="js/uploadify.js"></script>

    <script type="text/javascript" src="js/gcal.js"></script>
    <script type="text/javascript" src="js/swfobject.js"></script>
    <script type="text/javascript" src="js/jquery.pnotify.min.js"></script>

    <script type="text/javascript" src="js/sidemenu.js">// Strictly for sidebar </script>
    <script type="text/javascript" src="js/styleswitch.js">//Chaning the Stylesheet</script>

	<script type="text/javascript" src="js/custom.js"></script>
	
	<script type='text/javascript' src='js/tools.js'></script>
	<script type="text/javascript" src="js/session.js"></script>
	<script type="text/javascript" src="js/common.js"></script>

	<!--[if lt IE 9]>
		<script type="text/javascript" src="js/html5.js"></script>
	<![endif]-->

	<!--[if IE 7]>
		<link rel="stylesheet" type="text/css" href="style/IE7.css" />
	<![endif]-->

</head>
<body>
<!-- values related to session context -->
<input type="hidden" id="sessionAccountId" value=1/>
<input type="hidden" id="sessionAccountName" value=""/>

<div id="wrap">
    <div id="main">

        <header>
            <div class="container_16 clearfix">
                <div class="clearfix">
                    <a id="logo" href="index.php"></a>
                    <input type="text" class="search" title="Search..."/>
                </div>
                
                <nav>
                    <div id="navcontainer" class="clearfix">
                    <div id="user" class="clearfix">
                        <img id="headerLogo" src="" alt="" />
                        <strong class="username">Welcome, <a id="headerAccountName" href="#"></a></strong>
                        <ul class="piped">
                            <li><a href="myaccount.php">My Account</a></li>
                            <li><a href="login.php">Logout</a></li>
                        </ul>
                    </div>
                    
                    <div id="navclose"></div>
                    
                    <ul class="sf-menu">
                        <li>
                            <a href="index.php">
                                <span class="icon"><img src="images/menu/dashboard.png" /></span>
                                <span class="title">Dashboard</span>
                            </a>
                        </li>
                        <li>
                            <a href="history.php">
                                <span class="icon"><img src="images/menu/tables.png" /></span>
                                <span class="title">History</span>
                            </a>
                        </li>
                        <li>
                            <a href="create.php">
                                <span class="icon"><img src="images/menu/form.png" /></span>
                                <span class="title">Create New Offer</span>
                            </a>
                        </li>
                        <li>
                            <a href="setting.php">
                                <span class="icon"><img src="images/menu/settings.png" /></span>
                                <span class="title">Setting</span>
                            </a>
                        </li>
                    </ul>
                    </div>
                </nav>

        
