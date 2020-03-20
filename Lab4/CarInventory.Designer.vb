<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwEntries = New System.Windows.Forms.ListView()
        Me.chdNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ttpCars = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(12, 14)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(100, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Honda", "Hyundai", "Volkswagon"})
        Me.cmbMake.Location = New System.Drawing.Point(118, 12)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 28)
        Me.cmbMake.TabIndex = 1
        Me.ttpCars.SetToolTip(Me.cmbMake, "Select the make of the car")
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(12, 48)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(118, 46)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 27)
        Me.txtModel.TabIndex = 3
        Me.ttpCars.SetToolTip(Me.txtModel, "Enter the model of the car")
        '
        'lblYear
        '
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(12, 80)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(100, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(12, 114)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(118, 112)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 27)
        Me.txtPrice.TabIndex = 7
        Me.ttpCars.SetToolTip(Me.txtPrice, "Enter the price of the car")
        '
        'nudYear
        '
        Me.nudYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudYear.Location = New System.Drawing.Point(118, 79)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(121, 27)
        Me.nudYear.TabIndex = 5
        Me.ttpCars.SetToolTip(Me.nudYear, "Select the year of the car")
        Me.nudYear.Value = New Decimal(New Integer() {1920, 0, 0, 0})
        '
        'lblNew
        '
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(12, 151)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(100, 23)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "New:"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNew.Location = New System.Drawing.Point(118, 155)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(18, 17)
        Me.chkNew.TabIndex = 9
        Me.ttpCars.SetToolTip(Me.chkNew, "Select if the car is new or not")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwEntries
        '
        Me.lvwEntries.CheckBoxes = True
        Me.lvwEntries.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chdNew, Me.chdId, Me.chdMake, Me.chdModel, Me.chdYear, Me.chdPrice})
        Me.lvwEntries.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwEntries.FullRowSelect = True
        Me.lvwEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwEntries.HideSelection = False
        Me.lvwEntries.Location = New System.Drawing.Point(12, 178)
        Me.lvwEntries.MultiSelect = False
        Me.lvwEntries.Name = "lvwEntries"
        Me.lvwEntries.Size = New System.Drawing.Size(444, 129)
        Me.lvwEntries.TabIndex = 10
        Me.ttpCars.SetToolTip(Me.lvwEntries, "Select a car to modify")
        Me.lvwEntries.UseCompatibleStateImageBehavior = False
        Me.lvwEntries.View = System.Windows.Forms.View.Details
        '
        'chdNew
        '
        Me.chdNew.Text = "New"
        Me.chdNew.Width = 48
        '
        'chdId
        '
        Me.chdId.Text = "ID"
        Me.chdId.Width = 35
        '
        'chdMake
        '
        Me.chdMake.Text = "Make"
        Me.chdMake.Width = 75
        '
        'chdModel
        '
        Me.chdModel.Text = "Model"
        Me.chdModel.Width = 71
        '
        'chdYear
        '
        Me.chdYear.Text = "Year"
        Me.chdYear.Width = 53
        '
        'chdPrice
        '
        Me.chdPrice.Text = "Price"
        Me.chdPrice.Width = 81
        '
        'btnEnter
        '
        Me.btnEnter.AutoSize = True
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(213, 398)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(77, 30)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ttpCars.SetToolTip(Me.btnEnter, "Click to enter car into the list")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(296, 398)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(77, 30)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ttpCars.SetToolTip(Me.btnReset, "Click to reset the list and entry fields")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(379, 398)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 30)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ttpCars.SetToolTip(Me.btnExit, "Click to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(12, 310)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(444, 85)
        Me.lblResult.TabIndex = 11
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(470, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwEntries)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents lblNew As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwEntries As ListView
    Friend WithEvents chdId As ColumnHeader
    Friend WithEvents chdNew As ColumnHeader
    Friend WithEvents chdMake As ColumnHeader
    Friend WithEvents chdModel As ColumnHeader
    Friend WithEvents chdYear As ColumnHeader
    Friend WithEvents chdPrice As ColumnHeader
    Friend WithEvents ttpCars As ToolTip
    Friend WithEvents lblResult As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
