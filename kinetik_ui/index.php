<?php
if(isset($_GET['sidebar'])){
    include('s_header.php');
} else {
    include('header.php');
}
?>

        <div id="pagetitle" class="clearfix">
            <h1 class="left">Dashboard</h1>
            <!--<a class="btn grey right medium"><span>View Site</span></a>-->
        </div>
    </div>
</header>
<div class="container_16 clearfix" id="actualbody">
<ul class="breadcrumbs first">
    <li><a href="#">Home</a></li>
    <li class="active"><a href="#">Dashboard</a></li>
</ul>

    <div class="grid_16 widget tabs first">
        <div class="widget_title clearfix">
            <h2>My Offers</h2>
            <ul>
                <li><a href="#table2">Current Offers</a></li>
                <li><a href="#table3">Closed Offers</a></li>
            </ul>
        </div>
        <div class="widget_body">            

            <div id="table2">
                <div class="widget_options clearfix">
                    <select class="small forcewidth">
                        <option>Delete</option>
                        <option>Edit</option>
                    </select>
                    <a href="#" class="btn orange small"><span>Apply to Selected</span></a>

                    <input type="text" class="search" />
                </div>
                <table>
                    <thead>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>Offer Name</td>
                            <td class="center">Total View</td>
                            <td class="center">View Rates</td>
                            <td class="center">Save Rates</td>
                            <td class="center">Redemption Rates</td>
                            <td class="center">Date</td>
                            <td class="center">Action</td>
                        </tr>
                    </thead>
                    <tbody id='currentOffers'>
						<!--
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(25) 20% off Sony Tv's</td>
                            <td class="center">221k</td>
                            <td class="center">85%</td>
                            <td class="center">46%</td>
                            <td class="center">28%</td>
                            <td class="center">01/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li><li><a href="#">Edit</a></li><li><a href="#">Delete</a></li></ul></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(26) 10% off ipads</td>
                            <td class="center">121k</td>
                            <td class="center">65%</td>
                            <td class="center">66%</td>
                            <td class="center">18%</td>
                            <td class="center">11/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li><li><a href="#">Edit</a></li><li><a href="#">Delete</a></li></ul></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(27) Buy 2 get 1 free</td>
                            <td class="center">51k</td>
                            <td class="center">75%</td>
                            <td class="center">80%</td>
                            <td class="center">12%</td>
                            <td class="center">15/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li><li><a href="#">Edit</a></li><li><a href="#">Delete</a></li></ul></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(28) 200 Frequent Flyer Points</td>
                            <td class="center">110k</td>
                            <td class="center">25%</td>
                            <td class="center">20%</td>
                            <td class="center">10%</td>
                            <td class="center">16/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li><li><a href="#">Edit</a></li><li><a href="#">Delete</a></li></ul></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(29) 20% off Sony Tv's</td>
                            <td class="center">20k</td>
                            <td class="center">15%</td>
                            <td class="center">16%</td>
                            <td class="center">18%</td>
                            <td class="center">18/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li><li><a href="#">Edit</a></li><li><a href="#">Delete</a></li></ul></td>
                        </tr>
						-->
                    </tbody>
                </table>
            </div>
            
            
            <div id="table3">
                <table id="tblClosedOffers">
                    <thead>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>Offer Name</td>
                            <td class="center">Total View</td>
                            <td class="center">View Rates</td>
                            <td class="center">Save Rates</td>
                            <td class="center">Redemption Rates</td>
                            <td class="center">Date</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(25) 20% off Sony Tv's</td>
                            <td class="center">221k</td>
                            <td class="center">85%</td>
                            <td class="center">46%</td>
                            <td class="center">28%</td>
                            <td class="center">12/07/13</td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(25) 20% off Sony Tv's</td>
                            <td class="center">221k</td>
                            <td class="center">85%</td>
                            <td class="center">46%</td>
                            <td class="center">28%</td>
                            <td class="center">12/07/13</td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(25) 20% off Sony Tv's</td>
                            <td class="center">221k</td>
                            <td class="center">85%</td>
                            <td class="center">46%</td>
                            <td class="center">28%</td>
                            <td class="center">12/07/13</td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(25) 20% off Sony Tv's</td>
                            <td class="center">221k</td>
                            <td class="center">85%</td>
                            <td class="center">46%</td>
                            <td class="center">28%</td>
                            <td class="center">12/07/13</td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(25) 20% off Sony Tv's</td>
                            <td class="center">221k</td>
                            <td class="center">85%</td>
                            <td class="center">46%</td>
                            <td class="center">28%</td>
                            <td class="center">12/07/13</td>
                        </tr>
                    </tbody>
                </table>
            </div>
            
        </div>
    </div>

	<div class="clear"></div>
	
	<div class="grid_16 widget first">
        <div class="widget_title clearfix">
            <h2>Current Trends</h2>
        </div>
        <div class="widget_body">
            <div class="widget_content">
            	<div style="width:30%; float:left; margin-right: 5%;">
            		<h3>View Rates</h3>
                    <div id="stats" style="width:100%; height: 200px; text-align: center; margin-top: 5px"></div>
                    <script type="text/javascript">
                        $(function () {
                             var data1 = [
                                {
                                    label: "Actual Rate",
                                    data: [[-373597200000, 0], [-370918800000, 20], [-368326800000, 25], [-363056400000, 25], [-360378000000, 28], [-357699600000, 40], [-352429200000, 55], [-349837200000, 70]]
                                },
                                {
                                    label: "Assume Rate", 
                                    data: [[-373597200000, 0], [-370918800000, 10], [-368326800000, 15], [-363056400000, 30], [-360378000000, 30], [-357699600000, 45], [-352429200000, 70], [-349837200000, 88]]
                                }
                            ];

                            $.plot($("#stats"), data1, {
                            		xaxis: { mode: "time" },
                                   grid: {backgroundColor: { colors: ["#fff", "#fff"] } },
                                   colors: ["#80b611", "#4390cc"]
                                });
                        });
                        </script>
            	</div>
            	<div style="width:30%; float:left; margin-right: 5%;">
            		<h3>Save Rates</h3>
                    <div id="stats2" style="width:100%; height: 200px; text-align: center; margin-top: 5px"></div>
                    <script type="text/javascript">
                        $(function () {
                             var data1 = [
                                {
                                    label: "Actual Rate",
                                    data: [[-373597200000, 0], [-370918800000, 20], [-368326800000, 25], [-363056400000, 25], [-360378000000, 28], [-357699600000, 40], [-352429200000, 55], [-349837200000, 70]]
                                },
                                {
                                    label: "Assume Rate", 
                                    data: [[-373597200000, 0], [-370918800000, 10], [-368326800000, 15], [-363056400000, 30], [-360378000000, 30], [-357699600000, 45], [-352429200000, 70], [-349837200000, 88]]
                                }
                            ];

                            $.plot($("#stats2"), data1, {
                            		xaxis: { mode: "time" },
                                   grid: {backgroundColor: { colors: ["#fff", "#fff"] } },
                                   colors: ["#80b611", "#4390cc"]
                                });
                        });
                        </script>
            	</div>
            	<div style="width:30%; float:left;">
            		<h3>Redemption Rates</h3>
                    <div id="stats3" style="width:100%; height: 200px; text-align: center; margin-top: 5px"></div>
                    <script type="text/javascript">
                        $(function () {
                             var data1 = [
                                {
                                    label: "Actual Rate",
                                    data: [[-373597200000, 0], [-370918800000, 20], [-368326800000, 25], [-363056400000, 25], [-360378000000, 28], [-357699600000, 40], [-352429200000, 55], [-349837200000, 70]]
                                },
                                {
                                    label: "Assume Rate", 
                                    data: [[-373597200000, 0], [-370918800000, 10], [-368326800000, 15], [-363056400000, 30], [-360378000000, 30], [-357699600000, 45], [-352429200000, 70], [-349837200000, 88]]
                                }
                            ];

                            $.plot($("#stats3"), data1, {
                            		xaxis: { mode: "time" },
                                   grid: {backgroundColor: { colors: ["#fff", "#fff"] } },
                                   colors: ["#80b611", "#4390cc"]
                                });
                        });
                        </script>
            	</div>
                <div class="clear"></div>
            </div>
        </div>
    </div>

    <div class="clear"></div>
	<script type='text/javascript' src='js/config.js'></script>
	<script type='text/javascript' src='js/tools.js'></script>
	<script type='text/javascript' src='js/ajax.js'></script>
	<script type="text/javascript" src='js/index.js'></script>

<?php include("footer.php") ?>