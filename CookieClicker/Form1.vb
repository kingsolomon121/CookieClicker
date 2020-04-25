Public Class Form1
    Public cookies As Long = My.Settings.Cookies
    Public clicker As Integer = My.Settings.clicker
    Public grandma = My.Settings.Grandma
    Public farm = My.Settings.farm
    Public mine = My.Settings.mine
    Public factory = My.Settings.factory
    Public bank = My.Settings.bank
    Public temple = My.Settings.temple
    Public wizard = My.Settings.wizard
    Public shipment = My.Settings.shipment
    Public alchemy = My.Settings.alchemy
    Public portal = My.Settings.portal
    Public time = My.Settings.time
    Public condenser = My.Settings.condenser
    Public prism = My.Settings.prism
    Public chance = My.Settings.chance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cookies = cookies + 1
        TextBox1.Text = (cookies & " cookies")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Upgrades.Show()
    End Sub
    Public Sub Clickers()
        If (cookies > Fix(15 * (1.15 ^ (clicker - 1)))) Then
            cookies = cookies - Fix(15 * (1.15 ^ (clicker - 1)))
            clicker = clicker + 1
        End If
    End Sub
    Public Sub Grandmas()
        If (cookies > Fix(100 * (1.15 ^ (Grandma - 1)))) Then
            cookies = cookies - Fix(100 * (1.15 ^ (Grandma - 1)))
            Grandma = Grandma + 1
        End If
    End Sub
    Public Sub Farms()
        If (cookies > Fix(1100 * (1.15 ^ (farm - 1)))) Then
            cookies = cookies - Fix(1100 * (1.15 ^ (farm - 1)))
            farm = farm + 1
        End If
    End Sub
    Public Sub Mines()
        If (cookies > Fix(12000 * (1.15 ^ (mine - 1)))) Then
            cookies = cookies - Fix(12000 * (1.15 ^ (mine - 1)))
            mine = mine + 1
        End If
    End Sub
    Public Sub Factorys()
        If (cookies > Fix(130000 * (1.15 ^ (factory - 1)))) Then
            cookies = cookies - Fix(130000 * (1.15 ^ (factory - 1)))
            factory = factory + 1
        End If
    End Sub
    Public Sub Banks()
        If (cookies > Fix(1400000 * (1.15 ^ (bank - 1)))) Then
            cookies = cookies - Fix(1400000 * (1.15 ^ (bank - 1)))
            bank = bank + 1
        End If
    End Sub
    Public Sub Temples()
        If (cookies > Fix(20000000 * (1.15 ^ (temple - 1)))) Then
            cookies = cookies - Fix(20000000 * (1.15 ^ (temple - 1)))
            temple = temple + 1
        End If
    End Sub
    Public Sub Wizards()
        If (cookies > Fix(330000000 * (1.15 ^ (wizard - 1)))) Then
            cookies = cookies - Fix(330000000 * (1.15 ^ (wizard - 1)))
            wizard = wizard + 1
        End If
    End Sub
    Public Sub Shipments()
        If (cookies > Fix(5100000000 * (1.15 ^ (shipment - 1)))) Then
            cookies = cookies - Fix(5100000000 * (1.15 ^ (shipment - 1)))
            shipment = shipment + 1
        End If
    End Sub
    Public Sub Alchemys()
        If (cookies > Fix(75000000000 * (1.15 ^ (alchemy - 1)))) Then
            cookies = cookies - Fix(75000000000 * (1.15 ^ (alchemy - 1)))
            alchemy = alchemy + 1
        End If
    End Sub
    Public Sub Portals()
        If (cookies > Fix(1000000000000 * (1.15 ^ (portal - 1)))) Then
            cookies = cookies - Fix(1000000000000 * (1.15 ^ (portal - 1)))
            portal = portal + 1
        End If
    End Sub
    Public Sub Times()
        If (cookies > Fix(14000000000000 * (1.15 ^ (time - 1)))) Then
            cookies = cookies - Fix(14000000000000 * (1.15 ^ (time - 1)))
            time = time + 1
        End If
    End Sub
    Public Sub Condensers()
        If (cookies > Fix(170000000000000 * (1.15 ^ (condenser - 1)))) Then
            cookies = cookies - Fix(170000000000000 * (1.15 ^ (condenser - 1)))
            condenser = condenser + 1
        End If
    End Sub
    Public Sub Prisms()
        If (cookies > Fix(2100000000000000 * (1.15 ^ (prism - 1)))) Then
            cookies = cookies - Fix(2100000000000000 * (1.15 ^ (prism - 1)))
            prism = prism + 1
        End If
    End Sub
    Public Sub Chances()
        If (cookies > Fix(26000000000000000 * (1.15 ^ (chance - 1)))) Then
            cookies = cookies - Fix(26000000000000000 * (1.15 ^ (chance - 1)))
            chance = chance + 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Grandma > 1) Then
            cookies = cookies + 1 * (Grandma - 1)
        End If
        If (farm > 1) Then
            cookies = cookies + 8 * (farm - 1)
        End If
        If (mine > 1) Then
            cookies = cookies + 47 * (mine - 1)
        End If
        If (factory > 1) Then
            cookies = cookies + 260 * (factory - 1)
        End If
        If (bank > 1) Then
            cookies = cookies + 1400 * (bank - 1)
        End If
        If (temple > 1) Then
            cookies = cookies + 7800 * (temple - 1)
        End If
        If (wizard > 1) Then
            cookies = cookies + 44000 * (wizard - 1)
        End If
        If (shipment > 1) Then
            cookies = cookies + 260000 * (shipment - 1)
        End If
        If (alchemy > 1) Then
            cookies = cookies + 1600000 * (alchemy - 1)
        End If
        If (portal > 1) Then
            cookies = cookies + 10000000 * (portal - 1)
        End If
        If (time > 1) Then
            cookies = cookies + 65000000 * (time - 1)
        End If
        If (condenser > 1) Then
            cookies = cookies + 430000000 * (condenser - 1)
        End If
        If (prism > 1) Then
            cookies = cookies + 2900000000 * (prism - 1)
        End If
        If (chance > 1) Then
            cookies = cookies + 21000000000 * (chance - 1)
        End If
        TextBox1.Text = (cookies & " cookies")
        Upgrades.TextBox1.Text = (cookies & " cookies")
        TextBox2.Text = ((21000000000 * (chance - 1)) + (2900000000 * (prism - 1)) + (430000000 * (condenser - 1)) + (65000000 * (time - 1)) + (10000000 * (portal - 1)) + (1600000 * (alchemy - 1)) + (260000 * (shipment - 1)) + (44000 * (wizard - 1)) + (7800 * (temple - 1)) + (1400 * (bank - 1)) + (260 * (factory - 1)) + (47 * (mine - 1)) + (8 * (farm - 1)) + (1 * (grandma - 1)) + (0.1 * (clicker - 1)) & " cookies/sec")
        Upgrades.TextBox2.Text = ((21000000000 * (chance - 1)) + (2900000000 * (prism - 1)) + (430000000 * (condenser - 1)) + (65000000 * (time - 1)) + (10000000 * (portal - 1)) + (1600000 * (alchemy - 1)) + (260000 * (shipment - 1)) + (44000 * (wizard - 1)) + (7800 * (temple - 1)) + (1400 * (bank - 1)) + (260 * (factory - 1)) + (47 * (mine - 1)) + (8 * (farm - 1)) + (1 * (grandma - 1)) + (0.1 * (clicker - 1)) & " cookies/sec")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (clicker > 1) Then
            cookies = cookies + 1 * (clicker - 1)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Cookies = cookies
        My.Settings.clicker = clicker
        My.Settings.Grandma = grandma
        My.Settings.farm = farm
        My.Settings.mine = mine
        My.Settings.factory = factory
        My.Settings.bank = bank
        My.Settings.temple = temple
        My.Settings.wizard = wizard
        My.Settings.shipment = shipment
        My.Settings.alchemy = alchemy
        My.Settings.portal = portal
        My.Settings.time = time
        My.Settings.condenser = condenser
        My.Settings.prism = prism
        My.Settings.chance = chance


        My.Settings.Save()
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.Cookies = 0
        My.Settings.clicker = 1
        My.Settings.Grandma = 1
        My.Settings.farm = 1
        My.Settings.mine = 1
        My.Settings.factory = 1
        My.Settings.bank = 1
        My.Settings.temple = 1
        My.Settings.wizard = 1
        My.Settings.shipment = 1
        My.Settings.alchemy = 1
        My.Settings.portal = 1
        My.Settings.time = 1
        My.Settings.condenser = 1
        My.Settings.prism = 1
        My.Settings.chance = 1

        My.Settings.Save()
        End
    End Sub
End Class
