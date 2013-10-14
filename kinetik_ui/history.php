<?php
if(isset($_GET['sidebar'])){
    include('s_header.php');
} else {
    include('header.php');
}
?>

        <div id="pagetitle" class="clearfix">
            <h1 class="left">History</h1>
            <!--<a class="btn grey right medium"><span>View Site</span></a>-->
        </div>
    </div>
</header>
<div class="container_16 clearfix" id="actualbody">
<ul class="breadcrumbs first">
    <li><a href="#">Home</a></li>
    <li class="active"><a href="#">History</a></li>
</ul>

    <div class="grid_16 widget first">
        <div class="widget_title clearfix">
            <h2>History</h2>
        </div>
        <div class="widget_body">            

            <div id="table2">
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
                    <tbody>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(25) 20% off Sony Tv's</td>
                            <td class="center">221k</td>
                            <td class="center">85%</td>
                            <td class="center">46%</td>
                            <td class="center">28%</td>
                            <td class="center">01/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li></ul></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(26) 10% off ipads</td>
                            <td class="center">121k</td>
                            <td class="center">65%</td>
                            <td class="center">66%</td>
                            <td class="center">18%</td>
                            <td class="center">11/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li></ul></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(27) Buy 2 get 1 free</td>
                            <td class="center">51k</td>
                            <td class="center">75%</td>
                            <td class="center">80%</td>
                            <td class="center">12%</td>
                            <td class="center">15/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li></ul></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(28) 200 Frequent Flyer Points</td>
                            <td class="center">110k</td>
                            <td class="center">25%</td>
                            <td class="center">20%</td>
                            <td class="center">10%</td>
                            <td class="center">16/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li></ul></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" /></td>
                            <td>(29) 20% off Sony Tv's</td>
                            <td class="center">20k</td>
                            <td class="center">15%</td>
                            <td class="center">16%</td>
                            <td class="center">18%</td>
                            <td class="center">18/07/13</td>
                            <td class="center"><ul class="hor-list piped"><li><a href="#">View</a></li></ul></td>
                        </tr>
                    </tbody>
                </table>
            </div>
            
        </div>
    </div>

	<div class="clear"></div>


<?php include("footer.php") ?>