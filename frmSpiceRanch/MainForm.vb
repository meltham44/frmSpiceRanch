Public Class MainForm
    Dim StrItems(0) As String
    Dim FoodCost As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Items() As String = {"Chicken Korma - £3.99", "Chicken Tikka - £4.99", "King Prawn - £5.99", "Margherita Pizza - £6.99", "Pepperoni Pizza - £7.99", "Vegetarian Pizza - £5.99", "¼ Cheeseburger w/Fries - £3.99", "½ Cheeseburger w/Fries - £4.59", "Chicken Burger w/Fries - £4.69"}
        cmboItems.MaxDropDownItems = Items.Length
        For Each column As String In Items
            cmboItems.Items.Add(column)
        Next
        'This code populates the combo box from a variable.

        picboxCheeseburger.Visible = False
        picboxChickenBurger.Visible = False
        picboxKorma.Visible = False
        picboxMargherita.Visible = False
        picboxPepperoni.Visible = False
        picboxPrawn.Visible = False
        picboxTikka.Visible = False
        picboxVegetarian.Visible = False
        'The picture boxes have been made invisible here.
    End Sub

    Private Sub trkbarQuantity_Scroll(sender As Object, e As EventArgs) Handles trkbarQuantity.Scroll
        lblQuantity.Text = trkbarQuantity.Value
        'The tracker bar value is output to a label showing the quantity
    End Sub

    Private Sub cmbAdd_Click(sender As Object, e As EventArgs) Handles cmbAdd.Click
        Dim Quantity As Integer
        Dim Price As Double
        Dim ItemPrice As Double
        Quantity = trkbarQuantity.Value

        If cmboItems.Text = "Chicken Korma - £3.99" Then
            StrItems(0) = "Chicken Korma"
            Price = 3.99
        End If
        If cmboItems.Text = "Chicken Tikka - £4.99" Then
            StrItems(0) = "Chicken Tikka"
            Price = 4.99
        End If
        If cmboItems.Text = "King Prawn - £5.99" Then
            StrItems(0) = "King Prawn"
            Price = 5.99
        End If
        If cmboItems.Text = "Margherita Pizza - £6.99" Then
            StrItems(0) = "Margherita Pizza"
            Price = 6.99
        End If
        If cmboItems.Text = "Pepperoni Pizza - £7.99" Then
            StrItems(0) = "Pepperoni Pizza"
            Price = 7.99
        End If
        If cmboItems.Text = "Vegetarian Pizza - £5.99" Then
            StrItems(0) = "Vegetarian Pizza"
            Price = 5.99
        End If
        If cmboItems.Text = "¼ Cheeseburger w/Fries - £3.99" Then
            StrItems(0) = "¼ Cheeseburger w/Fries"
            Price = 3.99
        End If
        If cmboItems.Text = "½ Cheeseburger w/Fries - £4.59" Then
            StrItems(0) = "½ Cheeseburger w/Fries"
            Price = 4.59
        End If
        If cmboItems.Text = "Chicken Burger w/Fries - £4.69" Then
            StrItems(0) = "Chicken Burger w/Fries"
            Price = 4.69
        End If
        'Here, the selected item's name is stored and the price variable is set.

        ItemPrice = Price * Quantity
        'The price to be added to the list box is calculated and stored.

        FoodCost = FoodCost + ItemPrice
        ItemPrice = Math.Round(ItemPrice, 2, MidpointRounding.AwayFromZero)
        'This part of code makes sure that the prices of items are within 

        lbItems.Items.Add(StrItems(0))
        lbPrice.Items.Add(ItemPrice)
        'The price and item name are added to the list boxes.

        lblFoodCost.Text = Format((FoodCost.ToString), "Currency")
        'The cost of all food is output as currency.
    End Sub

    Private Sub cmbCalculate_Click(sender As Object, e As EventArgs) Handles cmbCalculate.Click
        Dim Delivery As Double
        Dim TotalCost As Double

        If txtName.Text = "" Then
            MsgBox("Must input name")
        End If

        If txtAddress.Text = "" Then
            MsgBox("Must input address")
        End If

        If txtPostcode.Text = "" Then
            MsgBox("Must input postcode")
        End If

        If txtEmail.Text = "" Then
            MsgBox("Must input email")
        End If

        If txtPhone.Text = "" Then
            MsgBox("Must input phone number")
        End If
        'The text boxes are checked and if empty, message boxes will appear telling the user what they have missed.

        If rcmbDelivery.Checked Then
            Delivery = 1.99
        End If
        'The delivery variable is set if the delivery option is selected.

        TotalCost = FoodCost + Delivery
        lblTotal.Text = Format((TotalCost.ToString), "Currency")
        'The total order cost is calculated and output as currency.
    End Sub

    Private Sub cmboItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboItems.SelectedIndexChanged
        If cmboItems.Text = "Chicken Korma - £3.99" Then
            picboxCheeseburger.Visible = False
            picboxChickenBurger.Visible = False
            picboxKorma.Visible = True
            picboxMargherita.Visible = False
            picboxPepperoni.Visible = False
            picboxPrawn.Visible = False
            picboxTikka.Visible = False
            picboxVegetarian.Visible = False
        End If
        If cmboItems.Text = "Chicken Tikka - £4.99" Then
            picboxCheeseburger.Visible = False
            picboxChickenBurger.Visible = False
            picboxKorma.Visible = False
            picboxMargherita.Visible = False
            picboxPepperoni.Visible = False
            picboxPrawn.Visible = False
            picboxTikka.Visible = True
            picboxVegetarian.Visible = False
        End If
        If cmboItems.Text = "King Prawn - £5.99" Then
            picboxCheeseburger.Visible = False
            picboxChickenBurger.Visible = False
            picboxKorma.Visible = False
            picboxMargherita.Visible = False
            picboxPepperoni.Visible = False
            picboxPrawn.Visible = True
            picboxTikka.Visible = False
            picboxVegetarian.Visible = False
        End If
        If cmboItems.Text = "Margherita Pizza - £6.99" Then
            picboxCheeseburger.Visible = False
            picboxChickenBurger.Visible = False
            picboxKorma.Visible = False
            picboxMargherita.Visible = True
            picboxPepperoni.Visible = False
            picboxPrawn.Visible = False
            picboxTikka.Visible = False
            picboxVegetarian.Visible = False
        End If
        If cmboItems.Text = "Pepperoni Pizza - £7.99" Then
            picboxCheeseburger.Visible = False
            picboxChickenBurger.Visible = False
            picboxKorma.Visible = False
            picboxMargherita.Visible = False
            picboxPepperoni.Visible = True
            picboxPrawn.Visible = False
            picboxTikka.Visible = False
            picboxVegetarian.Visible = False
        End If
        If cmboItems.Text = "Vegetarian Pizza - £5.99" Then
            picboxCheeseburger.Visible = False
            picboxChickenBurger.Visible = False
            picboxKorma.Visible = False
            picboxMargherita.Visible = False
            picboxPepperoni.Visible = False
            picboxPrawn.Visible = False
            picboxTikka.Visible = False
            picboxVegetarian.Visible = True
        End If
        If cmboItems.Text = "¼ Cheeseburger w/Fries - £3.99" Then
            picboxCheeseburger.Visible = True
            picboxChickenBurger.Visible = False
            picboxKorma.Visible = False
            picboxMargherita.Visible = False
            picboxPepperoni.Visible = False
            picboxPrawn.Visible = False
            picboxTikka.Visible = False
            picboxVegetarian.Visible = False
        End If
        If cmboItems.Text = "½ Cheeseburger w/Fries - £4.59" Then
            picboxCheeseburger.Visible = True
            picboxChickenBurger.Visible = False
            picboxKorma.Visible = False
            picboxMargherita.Visible = False
            picboxPepperoni.Visible = False
            picboxPrawn.Visible = False
            picboxTikka.Visible = False
            picboxVegetarian.Visible = False
        End If
        If cmboItems.Text = "Chicken Burger w/Fries - £4.69" Then
            picboxCheeseburger.Visible = False
            picboxChickenBurger.Visible = True
            picboxKorma.Visible = False
            picboxMargherita.Visible = False
            picboxPepperoni.Visible = False
            picboxPrawn.Visible = False
            picboxTikka.Visible = False
            picboxVegetarian.Visible = False
        End If
        'The picture box for the food selected is displayed.
    End Sub

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoginForm.Hide()
        HelpForm.Hide()
        'This hides the other forms when this form is open.
    End Sub

    Private Sub cmbHelp_Click(sender As Object, e As EventArgs) Handles cmbHelp.Click
        HelpForm.Show()
        'This shows the help form when the help button is clicked.
    End Sub
End Class
