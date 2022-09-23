<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmboItems = New System.Windows.Forms.ComboBox()
        Me.trkbarQuantity = New System.Windows.Forms.TrackBar()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.lbPrice = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rcmbDelivery = New System.Windows.Forms.RadioButton()
        Me.rcmbCollection = New System.Windows.Forms.RadioButton()
        Me.cmbCalculate = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblFoodCost = New System.Windows.Forms.Label()
        Me.picboxKorma = New System.Windows.Forms.PictureBox()
        Me.picboxTikka = New System.Windows.Forms.PictureBox()
        Me.picboxPrawn = New System.Windows.Forms.PictureBox()
        Me.picboxMargherita = New System.Windows.Forms.PictureBox()
        Me.picboxPepperoni = New System.Windows.Forms.PictureBox()
        Me.picboxVegetarian = New System.Windows.Forms.PictureBox()
        Me.picboxCheeseburger = New System.Windows.Forms.PictureBox()
        Me.picboxChickenBurger = New System.Windows.Forms.PictureBox()
        Me.cmbHelp = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbarQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.picboxKorma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxTikka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPrawn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxMargherita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPepperoni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxVegetarian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxCheeseburger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxChickenBurger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Postcode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telephone"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(107, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(356, 26)
        Me.txtName.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(107, 69)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(356, 26)
        Me.txtAddress.TabIndex = 7
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(107, 99)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(356, 26)
        Me.txtPostcode.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 129)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(356, 26)
        Me.txtEmail.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(107, 158)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(356, 26)
        Me.txtPhone.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1221, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'cmboItems
        '
        Me.cmboItems.FormattingEnabled = True
        Me.cmboItems.Location = New System.Drawing.Point(16, 231)
        Me.cmboItems.Name = "cmboItems"
        Me.cmboItems.Size = New System.Drawing.Size(447, 27)
        Me.cmboItems.TabIndex = 12
        '
        'trkbarQuantity
        '
        Me.trkbarQuantity.Location = New System.Drawing.Point(16, 264)
        Me.trkbarQuantity.Minimum = 1
        Me.trkbarQuantity.Name = "trkbarQuantity"
        Me.trkbarQuantity.Size = New System.Drawing.Size(447, 45)
        Me.trkbarQuantity.TabIndex = 14
        Me.trkbarQuantity.Value = 1
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(91, 316)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(18, 19)
        Me.lblQuantity.TabIndex = 15
        Me.lblQuantity.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Quantity:"
        '
        'cmbAdd
        '
        Me.cmbAdd.Location = New System.Drawing.Point(136, 302)
        Me.cmbAdd.Name = "cmbAdd"
        Me.cmbAdd.Size = New System.Drawing.Size(305, 54)
        Me.cmbAdd.TabIndex = 17
        Me.cmbAdd.Text = "Add To Basket"
        Me.cmbAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 181)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 153)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Please select desired item and quantity"
        '
        'lbItems
        '
        Me.lbItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.ItemHeight = 19
        Me.lbItems.Location = New System.Drawing.Point(508, 19)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(399, 346)
        Me.lbItems.TabIndex = 21
        '
        'lbPrice
        '
        Me.lbPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbPrice.FormattingEnabled = True
        Me.lbPrice.ItemHeight = 19
        Me.lbPrice.Location = New System.Drawing.Point(913, 19)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(242, 346)
        Me.lbPrice.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rcmbDelivery)
        Me.GroupBox3.Controls.Add(Me.rcmbCollection)
        Me.GroupBox3.Location = New System.Drawing.Point(508, 371)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 82)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Delivery Options"
        '
        'rcmbDelivery
        '
        Me.rcmbDelivery.AutoSize = True
        Me.rcmbDelivery.Location = New System.Drawing.Point(6, 54)
        Me.rcmbDelivery.Name = "rcmbDelivery"
        Me.rcmbDelivery.Size = New System.Drawing.Size(184, 23)
        Me.rcmbDelivery.TabIndex = 1
        Me.rcmbDelivery.TabStop = True
        Me.rcmbDelivery.Text = "Delivery - £1.99 extra"
        Me.rcmbDelivery.UseVisualStyleBackColor = True
        '
        'rcmbCollection
        '
        Me.rcmbCollection.AutoSize = True
        Me.rcmbCollection.Location = New System.Drawing.Point(6, 25)
        Me.rcmbCollection.Name = "rcmbCollection"
        Me.rcmbCollection.Size = New System.Drawing.Size(151, 23)
        Me.rcmbCollection.TabIndex = 0
        Me.rcmbCollection.TabStop = True
        Me.rcmbCollection.Text = "Collection - Free"
        Me.rcmbCollection.UseVisualStyleBackColor = True
        '
        'cmbCalculate
        '
        Me.cmbCalculate.Location = New System.Drawing.Point(507, 459)
        Me.cmbCalculate.Name = "cmbCalculate"
        Me.cmbCalculate.Size = New System.Drawing.Size(242, 79)
        Me.cmbCalculate.TabIndex = 24
        Me.cmbCalculate.Text = "Calculate Total"
        Me.cmbCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Location = New System.Drawing.Point(777, 459)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 79)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Price"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(70, 39)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(27, 19)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "£0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblFoodCost)
        Me.GroupBox5.Location = New System.Drawing.Point(913, 374)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(242, 79)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Current cost of all food"
        '
        'lblFoodCost
        '
        Me.lblFoodCost.AutoSize = True
        Me.lblFoodCost.Location = New System.Drawing.Point(81, 36)
        Me.lblFoodCost.Name = "lblFoodCost"
        Me.lblFoodCost.Size = New System.Drawing.Size(27, 19)
        Me.lblFoodCost.TabIndex = 0
        Me.lblFoodCost.Text = "£0"
        '
        'picboxKorma
        '
        Me.picboxKorma.Image = CType(resources.GetObject("picboxKorma.Image"), System.Drawing.Image)
        Me.picboxKorma.Location = New System.Drawing.Point(12, 371)
        Me.picboxKorma.Name = "picboxKorma"
        Me.picboxKorma.Size = New System.Drawing.Size(463, 263)
        Me.picboxKorma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picboxKorma.TabIndex = 1
        Me.picboxKorma.TabStop = False
        '
        'picboxTikka
        '
        Me.picboxTikka.Image = CType(resources.GetObject("picboxTikka.Image"), System.Drawing.Image)
        Me.picboxTikka.Location = New System.Drawing.Point(12, 371)
        Me.picboxTikka.Name = "picboxTikka"
        Me.picboxTikka.Size = New System.Drawing.Size(463, 263)
        Me.picboxTikka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxTikka.TabIndex = 27
        Me.picboxTikka.TabStop = False
        '
        'picboxPrawn
        '
        Me.picboxPrawn.Image = CType(resources.GetObject("picboxPrawn.Image"), System.Drawing.Image)
        Me.picboxPrawn.Location = New System.Drawing.Point(12, 371)
        Me.picboxPrawn.Name = "picboxPrawn"
        Me.picboxPrawn.Size = New System.Drawing.Size(463, 263)
        Me.picboxPrawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPrawn.TabIndex = 28
        Me.picboxPrawn.TabStop = False
        '
        'picboxMargherita
        '
        Me.picboxMargherita.Image = CType(resources.GetObject("picboxMargherita.Image"), System.Drawing.Image)
        Me.picboxMargherita.Location = New System.Drawing.Point(12, 371)
        Me.picboxMargherita.Name = "picboxMargherita"
        Me.picboxMargherita.Size = New System.Drawing.Size(463, 263)
        Me.picboxMargherita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxMargherita.TabIndex = 29
        Me.picboxMargherita.TabStop = False
        '
        'picboxPepperoni
        '
        Me.picboxPepperoni.Image = CType(resources.GetObject("picboxPepperoni.Image"), System.Drawing.Image)
        Me.picboxPepperoni.Location = New System.Drawing.Point(12, 371)
        Me.picboxPepperoni.Name = "picboxPepperoni"
        Me.picboxPepperoni.Size = New System.Drawing.Size(463, 263)
        Me.picboxPepperoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPepperoni.TabIndex = 30
        Me.picboxPepperoni.TabStop = False
        '
        'picboxVegetarian
        '
        Me.picboxVegetarian.Image = CType(resources.GetObject("picboxVegetarian.Image"), System.Drawing.Image)
        Me.picboxVegetarian.Location = New System.Drawing.Point(12, 371)
        Me.picboxVegetarian.Name = "picboxVegetarian"
        Me.picboxVegetarian.Size = New System.Drawing.Size(463, 263)
        Me.picboxVegetarian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxVegetarian.TabIndex = 31
        Me.picboxVegetarian.TabStop = False
        '
        'picboxCheeseburger
        '
        Me.picboxCheeseburger.Image = CType(resources.GetObject("picboxCheeseburger.Image"), System.Drawing.Image)
        Me.picboxCheeseburger.Location = New System.Drawing.Point(12, 371)
        Me.picboxCheeseburger.Name = "picboxCheeseburger"
        Me.picboxCheeseburger.Size = New System.Drawing.Size(463, 263)
        Me.picboxCheeseburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxCheeseburger.TabIndex = 32
        Me.picboxCheeseburger.TabStop = False
        '
        'picboxChickenBurger
        '
        Me.picboxChickenBurger.Image = CType(resources.GetObject("picboxChickenBurger.Image"), System.Drawing.Image)
        Me.picboxChickenBurger.Location = New System.Drawing.Point(12, 371)
        Me.picboxChickenBurger.Name = "picboxChickenBurger"
        Me.picboxChickenBurger.Size = New System.Drawing.Size(463, 263)
        Me.picboxChickenBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxChickenBurger.TabIndex = 33
        Me.picboxChickenBurger.TabStop = False
        '
        'cmbHelp
        '
        Me.cmbHelp.Location = New System.Drawing.Point(1103, 522)
        Me.cmbHelp.Name = "cmbHelp"
        Me.cmbHelp.Size = New System.Drawing.Size(189, 83)
        Me.cmbHelp.TabIndex = 34
        Me.cmbHelp.Text = "Click here for help!"
        Me.cmbHelp.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1333, 641)
        Me.Controls.Add(Me.cmbHelp)
        Me.Controls.Add(Me.picboxChickenBurger)
        Me.Controls.Add(Me.picboxCheeseburger)
        Me.Controls.Add(Me.picboxVegetarian)
        Me.Controls.Add(Me.picboxPepperoni)
        Me.Controls.Add(Me.picboxMargherita)
        Me.Controls.Add(Me.picboxPrawn)
        Me.Controls.Add(Me.picboxTikka)
        Me.Controls.Add(Me.picboxKorma)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmbCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbItems)
        Me.Controls.Add(Me.cmbAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.trkbarQuantity)
        Me.Controls.Add(Me.cmboItems)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "MainForm"
        Me.Text = "Spice Ranch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbarQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.picboxKorma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxTikka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPrawn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxMargherita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPepperoni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxVegetarian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxCheeseburger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxChickenBurger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmboItems As ComboBox
    Friend WithEvents trkbarQuantity As TrackBar
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbItems As ListBox
    Friend WithEvents lbPrice As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rcmbDelivery As RadioButton
    Friend WithEvents rcmbCollection As RadioButton
    Friend WithEvents cmbCalculate As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblFoodCost As Label
    Friend WithEvents picboxKorma As PictureBox
    Friend WithEvents picboxTikka As PictureBox
    Friend WithEvents picboxPrawn As PictureBox
    Friend WithEvents picboxMargherita As PictureBox
    Friend WithEvents picboxPepperoni As PictureBox
    Friend WithEvents picboxVegetarian As PictureBox
    Friend WithEvents picboxCheeseburger As PictureBox
    Friend WithEvents picboxChickenBurger As PictureBox
    Friend WithEvents cmbHelp As Button
End Class
