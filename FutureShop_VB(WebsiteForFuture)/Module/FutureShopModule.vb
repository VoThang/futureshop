Imports System.Web
Imports System.Web.Mvc
Imports System.Text
Imports System.Runtime.CompilerServices

Namespace FutureShopModule
    Public Module FutureShopModule
        <Extension>
        Public Function CheckDivByThree(ByVal number As Integer) As Boolean
            Dim numberList = New List(Of Integer)
            Dim sum As Integer = 0
            While number > 0
                numberList.Add(number Mod 10)
                number = number / 10
            End While

            For Each i In numberList
                sum += i
            Next

            If sum Mod 3 = True Then
                Return True
            End If
            Return False
        End Function

        Public Function FormatMoney(ByVal money As Double) As String
            Return money.ToString("###,###,###")
        End Function

        Public Function ConvertStringToDouble(ByVal str As String) As Double
            If IsNullEmpty(str) = False Then
                Return Double.Parse(str, 0)
            End If
            Return 0
        End Function

        Public Function IsNullEmpty(ByVal obj As Object) As Object
            If obj Is Nothing Then
                Return True
            End If
            Dim isString As Boolean = TypeOf obj Is String
            If isString Then
                Dim str As String = CType(obj, String)
                If str.Trim.Length = 0 Then
                    Return True
                End If
            End If
            Return False
        End Function

        Public Function ReplaceDot(ByVal str As String) As String
            Dim s As String = ""
            If IsNullEmpty(str) = False Then
                s = str.Replace(",", "").Replace(".", "").Trim()
            End If
            Return s
        End Function

        Public Function Nvl(ByVal str As String) As String
            If str Is Nothing OrElse str.Trim.Length = 0 Then
                Return ""
            End If
            Return str
        End Function

        Public Enum DEV_TYPE
            Mac = 1
            Ipod = 2
            Ipad = 3
            Accessories = 4
        End Enum

        Public Enum MAC_KBN
            Macbook = 0
            MacbookPro = 1
            MacbookAir = 2
            MacMini = 3
            IMac = 4
            Displays = 5
            MacPro = 6
            MacServer = 7
        End Enum

        Public Enum IPOD_KBN
            Ipod_Shuffle = 1
            Ipod_Nano = 2
            Ipod_Classic = 3
            Ipod_Touch = 4
        End Enum

        Public Enum ACCESSORIES_KBN
            Incase = 1
            Moshi = 2
            Switch_easy = 3
            Case_mate = 4
            Mac_accessoties = 5
            Ipod_accessories = 6
            Griffin_Accessories = 7
            Apple_Accessories = 8
            Logic3 = 9
            SkullCandy = 10
        End Enum

        Public Enum DEV_MODEL
            Old_Model = 1
            New_Model = 2
            None = 3
        End Enum
    End Module
End Namespace

