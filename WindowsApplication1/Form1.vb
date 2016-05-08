
Public Class Form1

    Public Class Customer
        Private name As String        'customer name'
        Private id As Integer         'customer id needs to be unique'
        Private city As String        'current city'
        Private state As String       'current state'
        Private zip As String         'current zip'
        Private contact As String       'phone'
        Private country As String     'country'
        Private address As String

        Public Property customerNum() As Integer
            Get
                Return id
            End Get
            Set(custID As Integer)
                id = custID
            End Set
        End Property

        Public Property customerName() As String
            Get
                Return Name
            End Get
            Set(custName As String)
                name = custName
            End Set
        End Property


        Public Property customerCity() As String
            Get
                Return city
            End Get
            Set(custCity As String)
                city = custCity
            End Set
        End Property

        Public Property customerState() As String
            Get
                Return state
            End Get
            Set(custState As String)
                state = custState
            End Set
        End Property

        Public Property customerZip() As String
            Get
                Return zip
            End Get
            Set(custZip As String)
                zip = custZip
            End Set
        End Property

        Public Property customerCountry() As String
            Get
                Return country
            End Get
            Set(custCountry As String)
                country = custCountry
            End Set
        End Property

        ' returns address object
        Public Property customerAddress() As String
            Get
                Return address
            End Get
            Set(custAddress As String)
                address = custAddress
            End Set
        End Property
        ' returns customer contact
        Public Property customerContact() As String
            Get
                Return contact
            End Get
            Set(custContact As String)
                contact = custContact
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal customerName As String, ByVal customerId As Integer, ByVal customerCity As String, ByVal customerState As String, ByVal customerZip As String, ByVal customerContact As String, ByVal customerCountry As String, ByVal line1 As String, Optional ByVal line2 As String = "", Optional ByVal line3 As String = "")
            name = customerName
            id = customerId
            city = customerCity
            state = customerState
            zip = customerZip
            contact = customerContact
            country = customerCountry
            address = line1 + "\n" + line2 + "\n" + line3
        End Sub

    End Class


    'Public CustObj As Customer = New Customer()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim BillingIdSource As New AutoCompleteStringCollection()
        BillingIdSource.AddRange(New String() _
                                  { _
                                    "12345", _
                                    "12346", _
                                    "12347" _
                                  })
        Dim BillingContactSource As New AutoCompleteStringCollection()
        BillingContactSource.AddRange(New String() _
                                  { _
                                    "1234589334", _
                                    "9849217134", _
                                    "2435678756" _
                                  })

        TextBox1.AutoCompleteCustomSource = BillingIdSource
        TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource

        TextBox9.AutoCompleteCustomSource = BillingContactSource
        TextBox9.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TextBox9.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CustObj As Customer = New Customer()
        CustObj.customerName = TextBox2.Text
        CustObj.customerNum = TextBox1.Text
        CustObj.customerCity = TextBox7.Text
        CustObj.customerZip = TextBox6.Text
        CustObj.customerState = ComboBox1.Text
        CustObj.customerAddress = TextBox4.Text + "\n" + TextBox5.Text + "\n" + TextBox6.Text
        CustObj.customerContact = TextBox9.Text


    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class
