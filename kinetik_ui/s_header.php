<!DOCTYPE html>
<html>
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" >
	
	<link rel="stylesheet" type="text/css" href="style/style.css" />
	<link rel="stylesheet" type="text/css" href="style/fluid.css" title="fluid" media="screen" />
        
	<title>Kinetik | Admin Panel</title>
    <script type="text/javascript" src="js/jquery-1.6.1.min.js"></script>
	<script type="text/javascript" src="js/jquery-ui-1.8.14.custom.min.js"></script>
	<script type="text/javascript" src="js/jquery.ui.selectmenu.js"></script>
	<script type="text/javascript" src="js/jquery.labelify.js"></script>
	<script type="text/javascript" src="js/superfish.js"></script>
	<script type="text/javascript" src="js/sidemenu.js">// Strictly for sidebar </script>
	
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

    <div id="sidebar">
        <nav>
            <div id="user" class="clearfix">
                <img src="demo/avatar.png" alt="" />
                <strong class="username">Welcome, <a href="#">Administrator</a></strong>
                <ul class="piped">
                    <li><a href="#">My Account</a></li>
                    <li><a href="#">Logout</a></li>
                </ul>
            </div>
            <ul id="sidemenu">
                <li class="active">
                    <a href="#" class="clearfix">
                        <span class="icon"><img src="images/menu/dashboard.png" /></span>
                        <span class="title">Dashboard</span>
                    </a>
                </li>
                <li>
                    <a href="#" class="clearfix">
                        <span class="icon"><img src="images/menu/tables.png" /></span>
                        <span class="title">Tables</span>
                    </a>
                </li>
                <li>
                    <a href="#" class="clearfix">
                        <span class="icon"><img src="images/menu/form.png" /></span>
                        <span class="title">Form Elements</span>
                    </a>
                </li>
                <li>
                    <a href="#" class="clearfix">
                        <span class="icon"><img src="images/menu/styles.png" /></span>
                        <span class="title">Styles</span>
                    </a>
					<ul>
						<li><a href="index.php">Close Sidebar</a></li>
					</ul>
                </li>
                <li>
                    <a href="#" class="clearfix">
                        <span class="icon"><img src="images/menu/pages.png" /></span>
                        <span class="title">Sample Pages</span>
                    </a>
                </li>
                <li>
                    <a href="#" class="clearfix">
                        <span class="icon"><img src="images/menu/gallery.png" /></span>
                        <span class="title">Gallery</span>
                    </a>
                </li>
                <li>
                    <a href="#" class="clearfix">
                        <span class="icon"><img src="images/menu/charts.png" /></span>
                        <span class="title">Statistics</span>
                    </a>
                </li>
                <li>
                    <a href="#" class="clearfix">
                        <span class="icon"><img src="images/menu/settings.png" /></span>
                        <span class="title">Settings</span>
                    </a>
                </li>
                <li>
                    <a href="#" class="clearfix">
                        <span class="notification">3</span>
                        <span class="icon"><img src="images/menu/msg.png" /></span>
                        <span class="title">Messages</span>
                    </a>
                </li>
            </ul>
        </nav>
    </div>

<div id="wrap" class="sidebarred">
    <div id="main">
        <header>
            <div class="container_16 clearfix">
                <div class="clearfix">
                    <a id="logo" href="index.php?t=dashboard"></a>
                    <input type="text" class="search" title="Search..."/>
                </div>
                
                <div id="pagetitle" class="clearfix">
                    <h1 class="left">Dashboard</h1>
                    <a class="btn grey right medium"><span>View Site</span></a>
                </div>
            </div>
        </header>
        <div class="container_16 clearfix" id="actualbody">

        
