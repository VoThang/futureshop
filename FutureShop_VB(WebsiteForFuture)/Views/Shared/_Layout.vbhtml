@Imports FutureShop_VB_WebsiteForFuture_.FutureShopModule
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>App store</title>
<meta name="keywords" content="web store, free templates, website templates, CSS, HTML" />
<meta name="description" content="Web Store Theme - free CSS template provided by templatemo.com" />
<link href="@Url.Content("~/Content/css/templatemo_style.css")" rel="stylesheet" type="text/css" />

<link rel="stylesheet" type="text/css" href="@Url.Content("~/Content/css/ddsmoothmenu.css")" />

<script type="text/javascript" src="@Url.Content("~/Scripts/jquery-1.7.2.min.js")"></script>
<script type="text/javascript" src="@Url.Content("~/Scripts/ddsmoothmenu.js")"></script>

<script type="text/javascript">

    ddsmoothmenu.init({
        mainmenuid: "templatemo_menu", //menu DIV id
        orientation: 'h', //Horizontal or vertical menu: Set to "h" or "v"
        classname: 'ddsmoothmenu', //class added to menu's outer DIV
        //customtheme: ["#1c5a80", "#18374a"],
        contentsource: "markup" //"markup" or ["container_id", "path_to_menu_file"]
    })

</script>
<script type="text/javascript" src="@Url.Content("~/Scripts/jquery.nivo.slider.js")"></script>
<link rel="stylesheet" type="text/css" href="@Url.Content("~/Content/css/nivo-slider.css")" />
<link rel="stylesheet" type="text/css" href="@Url.Content("~/Content/css/default.css")" />
<link rel="stylesheet" type="text/css" href="@Url.Content("~/Content/css/styles.css")" />
<link rel="stylesheet" type="text/css" href="@Url.Content("~/Content/css/paging.css")" />

<script language="javascript" type="text/javascript">
    $(window).load(function () {
        $('#slider').nivoSlider();
    });

    function clearText(field) {
        if (field.defaultValue == field.value) field.value = '';
        else if (field.value == '') field.value = field.defaultValue;
    };

    $$('div.thumbnail-div').each(function (div) {
        div.addEvents({
            'mouseover': function () {
                $(this).tween('marginTop', '-10px');
                $(this).getElements('div.sections-overlay').each(function (d) {
                    d.morph({ opacity: 1, backgroundPosition: "-40px 0px" });
                });
            },
            'mouseout': function () {
                $(this).tween('marginTop', '0px');
                $(this).getElements('div.sections-overlay').each(function (d) {
                    d.morph({ opacity: 0, backgroundPosition: "0px -167px" });
                });
            }
        });
    });
</script>
</head>
<body id="home">

<div id="templatemo_wrapper">
	<div id="templatemo_header">
    	<div id="site_title"><h1><a href="http://www.templatemo.com">Future Shop</a></h1></div>
        
        <div id="header_right">
            <ul id="language">
                <li><a href="#">Login</a></li>
                <li><a href="#">Sign in</a></li>
            </ul>
            <div class="cleaner"></div>
            <div id="templatemo_search">
                <form action="#" method="get">
                  <input type="text" value="Search" name="keyword" id="keyword" title="keyword" onfocus="clearText(this)" onblur="clearText(this)" class="txt_field" />
                  <input type="submit" name="Search" value="" alt="Search" id="searchbutton" title="Search" class="sub_btn"  />
                </form>
            </div>
         </div> <!-- END -->
    </div> <!-- END of header -->
    
    <div id="templatemo_menu" class="ddsmoothmenu">
        <ul>
            <li><a href="@Url.Action("Index", "Home")" class="selected">Home</a></li>
            <li><a href="products.html">Products</a>
                <ul>
                    <li><a href="@Url.Action("GetMac", "Product", New With { .DevKbn = FutureShopModule.MAC_KBN.Macbook})">Mac computer</a></li>
                    <li><a href="@Url.Action("GetProduct", "Product", New With { .ProductType = FutureShopModule.DEV_TYPE.Ipod})">Ipod player</a></li>
                    <li><a href="@Url.Action("GetProduct", "Product", New With { .ProductType = FutureShopModule.DEV_TYPE.Ipad})">Ipad tablet</a></li>
                    <li><a href="@Url.Action("GetProduct", "Product", New With { .ProductType = FutureShopModule.DEV_TYPE.Accessories})">Accessories</a></li>
              </ul>
            </li>
            <li><a href="about.html">About</a></li>
            <li><a href="faqs.html">FAQs</a></li>
            <li><a href="contact.html">Contact</a></li>
        </ul>
        <br style="clear: left" />
    </div> <!-- end of templatemo_menu -->
    
    <div class="cleaner"></div>

    <div id="templatemo_middle">
    	<div class="slider-wrapper theme-default">
			<div id="slider" class="nivoSlider">
				<img src="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340.png")" data-thumb="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340.png")" alt="" />
				<img src="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_002.png")" data-thumb="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_002.png")" alt=""/>
				<img src="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_003.png")" data-thumb="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_003.png")" alt="" data-transition="slideInLeft" />
				<img src="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_004.png")" data-thumb="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_004.png")" alt=""/>
				<img src="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_005.png")" data-thumb="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_005.png")" alt=""/>
				<img src="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_006.png")" data-thumb="@Url.Content("~/Content/themes/imagesPr/thumbl_980x340_006.png")" alt=""/>
			</div>
			<div id="htmlcaption" class="nivo-html-caption">
				<strong>This</strong> is an example of a <em>HTML</em> caption with <a href="#">a link</a>. 
			</div>
		</div>
    </div> <!-- END of middle -->
    
    <div id="templatemo_main_top"></div>
    <div id="templatemo_main">

        @RenderBody()
    </div>    
    
    <div id="templatemo_footer">
    	<div class="col col_16">
        	<h4>Categories</h4>
            <ul class="footer_menu">
			    <li><a href="#">Aenean et dolor diam</a></li>
                <li><a href="#">Aenean pulvinar</a></li>				
                <li><a href="#">Cras bibendum auctor</a></li>
                <li><a href="#">Donec sodales bibendum</a></li>				
		  </ul>  
        </div>
        <div class="col col_16">
        	<h4>Pages</h4>
            <ul class="footer_menu">
            	<li><a href="#">Home</a></li>
                <li><a href="#">Services</a></li>
                <li><a href="#">Shipping</a></li>
                <li><a href="#">Privacy</a></li>
			</ul>  
        </div>
        <div class="col col_16">
        	<h4>Partners</h4>
            <ul class="footer_menu">
            	<li><a href="http://www.flashmo.com/">Free Flash Templates</a></li>
                <li><a href="http://www.templatemo.com/">Free CSS Templates</a></li>
                <li><a href="http://www.koflash.com/">Website Gallery</a></li>
                <li><a href="http://www.webdesignmo.com/blog/">Web Design Resources</a></li>
			</ul>  
        </div>
        <div class="col col_16">
        	<h4>Social</h4>
            <ul class="footer_menu">
            	<li><a href="#">Twitter</a></li>
                <li><a href="#">Facebook</a></li>
                <li><a href="#">Youtube</a></li>
                <li><a href="#">LinkedIn</a></li> 
		  </ul>  
        </div>
        <div class="col col_13 no_margin_right">
        	<h4>About Us</h4>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur semper quam sit amet turpis rhoncus id venenatis tellus sollicitudin. Fusce ullamcorper, dolor non mollis pulvinar, turpis tortor commodo nisl. Validate <a href="http://validator.w3.org/check?uri=referer" rel="nofollow"><strong>XHTML</strong></a> &amp; <a href="http://jigsaw.w3.org/css-validator/check/referer" rel="nofollow"><strong>CSS</strong></a>.</p>
        </div>
        
        <div class="cleaner h40"></div>
		<center>
			Copyright © 2048 Your Company Name | <a href="http://www.iwebsitetemplate.com" target="_parent">Website Templates</a> by <a href="http://www.templatemo.com" target="_parent">Free CSS Templates</a>
		</center>
    </div> <!-- END of footer -->   
   
</div>

</body>
</html>
