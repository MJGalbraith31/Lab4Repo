' Name: Car Class 
' Programmer: MJ Galbraith 
' Date: Mar. 19, 2020 
' Description: class for a car with its information about make, model, year, price, and if it's new 

Option Strict On

Public Class Car

    Private Shared carCount As Integer

    Private carIdentificationNumber As Integer = 0

    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 1920
    Private carPrice As Double = 0.0
    Private carIsNew As Boolean = False

    ''' <summary>
    ''' Constructor - Default - creates a new car object 
    ''' </summary>
    Public Sub New()

        carCount += 1
        carIdentificationNumber = carCount

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new car object 
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="isNew"></param>
    Public Sub New(make As String, model As String, year As Integer, price As Double, isNew As Boolean)

        Me.New()

        carMake = make
        carModel = model
        carYear = year
        carPrice = price
        carIsNew = isNew

    End Sub

    ''' <summary>
    ''' Count ReadOnly Property - gets the number of cars that have been instantiated/created 
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - gets the identification number of the car object 
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Make Property - gets and sets the make of a car object 
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Model Property - gets and sets the model of a car object 
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Year Property - gets and sets the year of a car object 
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Price Property - gets and sets the price of a car object 
    ''' </summary>
    ''' <returns>Double</returns>
    Public Property Price() As Double
        Get
            Return carPrice
        End Get
        Set(value As Double)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' IsNew Property - gets and sets weather a car object is new 
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property IsNew() As Boolean
        Get
            Return carIsNew
        End Get
        Set(value As Boolean)
            carIsNew = value
        End Set
    End Property

    ''' <summary>
    ''' GetCarData Function - gets a string with the car's information 
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetCarData() As String

        Dim returnString As String = String.Empty

        If IsNew Then

            returnString &= "A new "

        Else

            returnString &= "A used "

        End If

        returnString &= Year.ToString & " " & Make & " " & Model & " worth $" & Price.ToString

        Return returnString

    End Function
End Class
