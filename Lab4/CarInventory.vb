' Name: Car Inventory Form 
' Programmer: MJ Galbraith 
' Date: Mar. 19, 2020 
' Description: keeps a list of cars with their information 

Option Strict On

Public Class frmCarInventory

    Private carList As New SortedList

    Private currentCarIdentificationNumber As String = String.Empty

    Private editMode As Boolean = False

    ''' <summary>
    ''' me close form
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' will validate the input data, create a car object with the paramiterized constructor, add the car object to the carList collection, check if the data was selected from the listView, and if it was update the car object and listView 
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car
        Dim carItem As ListViewItem

        ' checking if the data is valid 
        If IsValidInput()Then

            editMode = True

            lblResult.Text = "Entry Successful!"

            ' checking if the current car ID contains anything 
            If currentCarIdentificationNumber.Trim.Length = 0 Then

                car = New Car(cmbMake.Text, txtModel.Text, CInt(nudYear.Value), Double.Parse(txtPrice.Text), chkNew.Checked)

                carList.Add(car.IdentificationNumber.ToString(), car)

            Else ' if the current car ID has something 

                car = CType(carList.Item(currentCarIdentificationNumber), Car)

                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = CInt(nudYear.Value)
                car.Price = Double.Parse(txtPrice.Text)
                car.IsNew = chkNew.Checked

            End If

            lvwEntries.Items.Clear()

            ' looping through the list of car objects, adding them to the listView 
            For Each carEntry As DictionaryEntry In carList

                carItem = New ListViewItem()

                car = CType(carEntry.Value, Car)

                carItem.Checked = car.IsNew
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year.ToString())
                carItem.SubItems.Add("$" & car.Price.ToString())

                lvwEntries.Items.Add(carItem)

            Next

            Reset()

            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' me clear form 
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Reset()

    End Sub

    ''' <summary>
    ''' Reset - resets the input controles to their defalt values 
    ''' </summary>
    Private Sub Reset()

        cmbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        nudYear.Value = nudYear.Minimum
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        lblResult.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in the controles to make sure the user has entered valid data 
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim message As String = String.Empty
        Dim price As Double = 0

        ' checking if a make has been selected 
        If cmbMake.SelectedIndex = -1 Then

            message += "Please select the car's Make." & vbCrLf

            returnValue = False

        End If

        ' checking if a model has been entered 
        If txtModel.Text.Trim.Length = 0 Then

            message += "Please enter the car's Model" & vbCrLf

            returnValue = False

        End If

        ' checking if a valid price has been entered 
        If (Not Double.TryParse(txtPrice.Text, price)) Or price < 0 Then

            message += "Please enter a valid price" & vbCrLf

            returnValue = False

        End If

        ' checking if any of the entries was invalid 
        If Not returnValue Then

            lblResult.Text = "ERRORS" & vbCrLf & message

        End If

        Return returnValue

    End Function

    ''' <summary>
    ''' lvwEntries_SelectedIdexChanged - when user selects a row in the list it will populate the fields for editing 
    ''' </summary>
    Private Sub lvwEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwEntries.SelectedIndexChanged

        Const identificationSubItemIndex As Integer = 1

        currentCarIdentificationNumber = lvwEntries.Items(lvwEntries.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        Dim car As Car = CType(carList.Item(currentCarIdentificationNumber), Car)

        cmbMake.Text = car.Make
        txtModel.Text = car.Model
        nudYear.Value = car.Year
        txtPrice.Text = car.Price.ToString
        chkNew.Checked = car.IsNew

        lblResult.Text = car.GetCarData()

    End Sub

    ''' <summary>
    ''' lvwEntries_ItemCheck - prevents the user from checking the check box in the list if it's not in edit mode
    ''' </summary>
    Private Sub lvwEntries_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwEntries.ItemCheck

        ' checking if the listView is in editMode 
        If Not editMode Then

            e.NewValue = e.CurrentValue

        End If

    End Sub
End Class
