Imports Webdiyer.WebControls.Mvc
Imports FutureShop_VB_WebsiteForFuture_.FutureShopModule

Namespace FutureShop_VB_WebsiteForFuture_
    Public Class ProductController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Product

        Function Index() As ActionResult
            Return View()
        End Function

        Function GetMac(ByVal DevKbn As String, ByVal DevModel As String, Optional ByVal id As Integer = 1) As ActionResult
            Dim product As PagedList(Of MSTDEVICE)
            Dim macType = CInt(DEV_TYPE.Mac)
            Dim macBookPro = CInt(MAC_KBN.MacbookPro)
            Dim macbookAir = CInt(MAC_KBN.MacbookAir)
            Dim kbn As Integer
            Dim model As Integer
            If DevKbn Is Nothing Then
                kbn = MAC_KBN.Macbook
            Else
                kbn = DirectCast([Enum].Parse(GetType(MAC_KBN), DevKbn), Integer)
            End If
            If DevModel Is Nothing Then
                model = DEV_MODEL.None
            Else
                model = DirectCast([Enum].Parse(GetType(DEV_MODEL), DevModel), Integer)
            End If

            Using db = New FutureShop
                If MAC_KBN.Macbook = kbn Then
                    product = db.MSTDEVICEs.OrderBy(Function(x) x.DEV_MNG_NO).Where(Function(x) x.DEV_TYPE = macType And (x.DEV_KBN = macBookPro _
                                                                                                                          Or x.DEV_KBN = macbookAir)).ToPagedList(id, 2)
                Else
                    product = db.MSTDEVICEs.OrderBy(Function(x) x.DEV_MNG_NO).Where(Function(x) x.DEV_TYPE = macType & x.DEV_KBN = kbn _
                                                                                    & x.MODEL = model).ToPagedList(id, 2)
                End If
                If Request.IsAjaxRequest() Then
                    Return View("UCMac", product)
                End If
            End Using
            Return View("Mac", product)
        End Function

    End Class
End Namespace