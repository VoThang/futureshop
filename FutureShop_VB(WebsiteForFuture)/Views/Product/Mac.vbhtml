@ModelType Webdiyer.WebControls.Mvc.PagedList(Of FutureShop_VB_WebsiteForFuture_.MSTDEVICE)
@Imports FutureShop_VB_WebsiteForFuture_.FutureShopModule
@Code
    ViewData("Title") = "Mac"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div id="sidebar">
    <h3>Mac</h3>
    <ul class="sidebar_menu">
		<li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.MacbookPro, .DevModel = FutureShopModule.DEV_MODEL.New_Model})">MacBook Pro New Model</a></li>
        <li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.MacbookAir, .DevModel = FutureShopModule.DEV_MODEL.New_Model})">MacBook Air New Model</a></li>				
        <li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.MacMini, .DevModel = FutureShopModule.DEV_MODEL.None})">Mac Mini</a></li>
        <li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.Macbook})">MacBook</a></li>				
        <li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.MacbookPro, .DevModel = FutureShopModule.DEV_MODEL.Old_Model})">MacBook Pro Old Model</a></li>
        <li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.IMac})">iMac</a></li>     
        <li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.MacbookAir, .DevModel = FutureShopModule.DEV_MODEL.Old_Model})">MacBook Air Old Model</a></li>				
        <li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.Displays})">Displays</a></li>
		<li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.MacPro})">Mac Pro</a></li>
		<li><a href="@Url.Action("GetMac", "Product", New With {  .DevKbn = FutureShopModule.MAC_KBN.MacServer})">Mac Servers</a></li>
	</ul>
</div> <!-- END of sidebar -->
        
<div id="content">
    <div id ="divMacProduct">
        @Code
            Html.RenderPartial("UCMac", Model)
        End Code
    </div>
</div> <!-- END of content -->



<div class="cleaner"></div>

