@Imports Webdiyer.WebControls.Mvc
@Imports FutureShop_VB_WebsiteForFuture_.FutureShopModule
@ModelType Webdiyer.WebControls.Mvc.PagedList(Of FutureShop_VB_WebsiteForFuture_.MSTDEVICE)
@Code
    ViewData("Title") = "UCMac"
End Code




<div id="divMacProduct">
@If Not Model is Nothing Then
    @:<ul>
        Dim count As Integer = 0
        For Each device As FutureShop_VB_WebsiteForFuture_.MSTDEVICE In Model
            count = count + 1
        If FutureShopModule.CheckDivByThree(count) Then
            @:<div class="col col_14 product_gallery no_margin_right">
            	    @:<a href="productdetail.html"><img style="width: 150px;height: 100px" src="data:image/png;base64,@(Html.Raw(Convert.ToBase64String(device.DEV_IMAGE)))"/></a>
                    @:<h3>@device.DEV_NO</h3>
                    @:<p class="product_price">@device.PRICE</p>
                    @:<a href="shoppingcart.html" class="add_to_cart">Add to Cart</a>
            @:</div>
        Else
             @:<div class="col col_14 product_gallery">
            	    @:<a href="productdetail.html"><img style="width: 150px;height: 100px" src="data:image/png;base64,@(Html.Raw(Convert.ToBase64String(device.DEV_IMAGE)))"/></a>
                    @:<h3>@device.DEV_NO</h3>
                    @:<p class="product_price">@device.PRICE</p>
                    @:<a href="shoppingcart.html" class="add_to_cart">Add to Cart</a>
            @:</div>
        End If
        Next
    @:</ul>
End If
</div>
@Html.AjaxPager(Model, _
    New PagerOptions() With {.PageIndexParameterName = "id", _
    .ShowDisabledPagerItems = True, _
    .ShowPrevNext = False, _
    .ShowMorePagerItems = True, _
    .ShowFirstLast = False, _
    .SeparatorHtml=" ", _
    .CssClass = "pages"}, _
    New AjaxOptions With {.UpdateTargetId = "divMacProduct"})
    
