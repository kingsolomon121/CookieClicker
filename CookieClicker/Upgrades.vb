Public Class Upgrades
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Clickers()
        Button1.Text = ("Clicker (" & Fix(15 * (1.15 ^ (Form1.clicker - 1))) & ")" & vbCrLf & "You have:" & Form1.clicker - 1)
        TextBox1.Text = (Form1.cookies & " cookies.")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Hide()
    End Sub

    Private Sub Upgrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = ("Clicker (" & Fix(15 * (1.15 ^ (Form1.clicker - 1))) & ")" & vbCrLf & "You have:" & Form1.clicker - 1)
        TextBox1.Text = (Form1.cookies & " cookies.")
        Button2.Text = ("Grandma (" & Fix(100 * (1.15 ^ (Form1.grandma - 1))) & ")" & vbCrLf & "You have:" & Form1.grandma - 1)
        Button3.Text = ("Farm (" & Fix(1100 * (1.15 ^ (Form1.farm - 1))) & ")" & vbCrLf & "You have:" & Form1.farm - 1)
        Button4.Text = ("Mine (" & Fix(12000 * (1.15 ^ (Form1.factory - 1))) & ")" & vbCrLf & "You have:" & Form1.mine - 1)
        Button5.Text = ("Factory (" & Fix(130000 * (1.15 ^ (Form1.factory - 1))) & ")" & vbCrLf & "You have:" & Form1.factory - 1)
        Button6.Text = ("Bank (" & Fix(1400000 * (1.15 ^ (Form1.bank - 1))) & ")" & vbCrLf & "You have:" & Form1.bank - 1)
        Button7.Text = ("Temple (" & Fix(20000000 * (1.15 ^ (Form1.temple - 1))) & ")" & vbCrLf & "You have:" & Form1.temple - 1)
        Button8.Text = ("Wizard (" & Fix(330000000 * (1.15 ^ (Form1.wizard - 1))) & ")" & vbCrLf & "You have:" & Form1.wizard - 1)
        Button9.Text = ("Shipment (" & Fix(5100000000 * (1.15 ^ (Form1.shipment - 1))) & ")" & vbCrLf & "You have:" & Form1.shipment - 1)
        Button10.Text = ("Alchemy (" & Fix(75000000000 * (1.15 ^ (Form1.alchemy - 1))) & ")" & vbCrLf & "You have:" & Form1.alchemy - 1)
        Button11.Text = ("Portal ( " & Fix(1000000000000 * (1.15 ^ (Form1.portal - 1))) & ")" & vbCrLf & "You have:" & Form1.portal - 1)
        Button12.Text = ("Time Machine (" & Fix(14000000000000 * (1.15 ^ (Form1.time - 1))) & ")" & vbCrLf & "You have:" & Form1.time - 1)
        Button13.Text = ("Condenser (" & Fix(170000000000000 * (1.15 ^ (Form1.condenser - 1))) & ")" & vbCrLf & "You have:" & Form1.condenser - 1)
        Button14.Text = ("Prism (" & Fix(2100000000000000 * (1.15 ^ (Form1.prism - 1))) & ")" & vbCrLf & "You have:" & Form1.prism - 1)
        Button15.Text = ("Chance (" & Fix(26000000000000000 * (1.15 ^ (Form1.chance - 1))) & ")" & vbCrLf & "You have:" & Form1.chance - 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Grandmas()
        Button2.Text = ("Grandma (" & Fix(100 * (1.15 ^ (Form1.Grandma - 1))) & ")" & vbCrLf & "You have:" & Form1.Grandma - 1)
        TextBox1.Text = Form1.cookies
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Farms()
        Button3.Text = ("Farm (" & Fix(1100 * (1.15 ^ (Form1.farm - 1))) & ")" & vbCrLf & "You have:" & Form1.farm - 1)
        TextBox1.Text = Form1.cookies
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Mines()
        Button4.Text = ("Mine (" & Fix(12000 * (1.15 ^ (Form1.mine - 1))) & ")" & vbCrLf & "You have:" & Form1.mine - 1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Factorys()
        Button5.Text = ("Factory (" & Fix(130000 * (1.15 ^ (Form1.factory - 1))) & ")" & vbCrLf & "You have:" & Form1.factory - 1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Banks()
        Button6.Text = ("Bank (" & Fix(1400000 * (1.15 ^ (Form1.bank - 1))) & ")" & vbCrLf & "You have:" & Form1.bank - 1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Temples()
        Button7.Text = ("Temple (" & Fix(20000000 * (1.15 ^ (Form1.temple - 1))) & ")" & vbCrLf & "You have:" & Form1.temple - 1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.Wizards()
        Button8.Text = ("Wizard (" & Fix(330000000 * (1.15 ^ (Form1.wizard - 1))) & ")" & vbCrLf & "You have:" & Form1.wizard - 1)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form1.shipments()
        Button9.Text = ("Shipment (" & Fix(5100000000 * (1.15 ^ (Form1.shipment - 1))) & ")" & vbCrLf & "You have:" & Form1.shipment - 1)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form1.Alchemys()
        Button10.Text = ("Alchemy (" & Fix(75000000000 * (1.15 ^ (Form1.alchemy - 1))) & ")" & vbCrLf & "You have:" & Form1.alchemy - 1)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form1.portals()
        Button11.Text = ("Portal (" & Fix(1000000000000 * (1.15 ^ (Form1.portal - 1))) & ")" & vbCrLf & "You have:" & Form1.portal - 1)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form1.times()
        Button12.Text = ("TimeMachine(" & Fix(14000000000000 * (1.15 ^ (Form1.time - 1))) & ")" & vbCrLf & "You have:" & Form1.time - 1)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form1.condensers()
        Button13.Text = ("Condenser (" & Fix(170000000000000 * (1.15 ^ (Form1.condenser - 1))) & ")" & vbCrLf & "You have:" & Form1.condenser - 1)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Form1.Prisms()
        Button14.Text = ("Prism (" & Fix(2100000000000000 * (1.15 ^ (Form1.prism - 1))) & ")" & vbCrLf & "You have:" & Form1.prism - 1)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form1.Chances()
        Button15.Text = ("Chance (" & Fix(26000000000000000 * (1.15 ^ (Form1.chance - 1))) & ")" & vbCrLf & "You have:" & Form1.chance - 1)
    End Sub
End Class