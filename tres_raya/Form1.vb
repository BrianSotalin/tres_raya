Public Class Form1
    Dim jugador1 As String = "X"
    Dim jugador2 As String = "O"

    'contador filas jugador1
    Dim filax1 As Integer = 0
    Dim filax2 As Integer = 0
    Dim filax3 As Integer = 0
    'contador columnas jugador1
    Dim clmx1 As Integer = 0
    Dim clmx2 As Integer = 0
    Dim clmx3 As Integer = 0
    'contador diagonal jugador1 
    Dim dgx As Integer = 0
    Dim dgx2 As Integer = 0

    'contador  filas jugador2
    Dim filao1 As Integer = 0
    Dim filao2 As Integer = 0
    Dim filao3 As Integer = 0
    'contador columnas jugador1
    Dim clmo1 As Integer = 0
    Dim clmo2 As Integer = 0
    Dim clmo3 As Integer = 0
    'contador diagonal jugador1 
    Dim dgo As Integer = 0
    Dim dgo2 As Integer = 0

    'puntaje jugador1
    Dim puntx As Integer = 0
    'puntaje jugador2
    Dim punto As Integer = 0
    Private Sub cambioturno()
        If lblturno.Text = "Jugador1" Then
            lblturno.Text = "Jugador2"
        ElseIf lblturno.Text = "Jugador2" Then
            lblturno.Text = "Jugador1"
        End If
    End Sub
    Private Sub seguir()
        'reinicio valores botonese fila1
        btn1fila1.Text = ""
        btn1fila1.Enabled = True
        btn2fila1.Text = ""
        btn2fila1.Enabled = True
        btn3fila1.Text = ""
        btn3fila1.Enabled = True
        'reinicio valores fila2
        btn1fila2.Text = ""
        btn1fila2.Enabled = True
        btn2fila2.Text = ""
        btn2fila2.Enabled = True
        btn3fila2.Text = ""
        btn3fila2.Enabled = True
        'reinicio valores fila3
        btn1fila3.Text = ""
        btn1fila3.Enabled = True
        btn2fila3.Text = ""
        btn2fila3.Enabled = True
        btn3fila3.Text = ""
        btn3fila3.Enabled = True
        'reinicio contadores jugador1
        filax1 = 0
        filax2 = 0
        filax3 = 0
        clmx1 = 0
        clmx2 = 0
        clmx3 = 0
        dgx = 0
        dgx2 = 0

        'reinicio contadores jugador2
        filao1 = 0
        filao2 = 0
        filao3 = 0
        clmo1 = 0
        clmo2 = 0
        clmo3 = 0
        dgo = 0
        dgo2 = 0

    End Sub
    Private Sub nuevaprt()
        puntx = 0
        punto = 0
    End Sub
    Private Sub inbtn()
        'inhabilitacion de botones para cuando haya un ganador

        'botones fila1
        btn1fila1.Enabled = False
        btn2fila1.Enabled = False
        btn3fila1.Enabled = False
        'botones fila2
        btn1fila2.Enabled = False
        btn2fila2.Enabled = False
        btn3fila2.Enabled = False
        'botones fila3
        btn1fila3.Enabled = False
        btn2fila3.Enabled = False
        btn3fila3.Enabled = False

    End Sub
    Private Sub ganador1()

        If filax1 = 3 Or filax2 = 6 Or filax3 = 9 Then
            MsgBox("Felicidades Jugador1 Ganaste ", vbInformation, "Juego 3 en raya")
            inbtn()
            puntx = puntx + 1
        ElseIf clmx1 = 3 Or clmx2 = 6 Or clmx3 = 9 Then
            MsgBox("Felicidades Jugador1 Ganaste ", vbInformation, "Juego 3 en raya")
            inbtn()
            puntx = puntx + 1
        ElseIf dgx = 30 Then
            MsgBox("Felicidades Jugador1 Ganaste ", vbInformation, "Juego 3 en raya")
            inbtn()
            puntx = puntx + 1
        ElseIf dgx2 = 300 Then
            MsgBox("Felicidades Jugador1 Ganaste ", vbInformation, "Juego 3 en raya")
            inbtn()
            puntx = puntx + 1
        End If


        lblptx.Text = puntx
    End Sub
    Private Sub ganador2()

        If filao1 = 3 Or filao2 = 6 Or filao3 = 9 Then
            MsgBox("Felicidades Jugador2 Ganaste ", vbInformation, "Juego 3 en raya")
            inbtn()
            punto = punto + 1
        ElseIf clmo1 = 3 Or clmo2 = 6 Or clmo3 = 9 Then
            MsgBox("Felicidades Jugador2 Ganaste ", vbInformation, "Juego 3 en raya")
            inbtn()
            punto = punto + 1
        ElseIf dgo = 30 Then
            MsgBox("Felicidades Jugador2 Ganaste ", vbInformation, "Juego 3 en raya")
            inbtn()
            punto = punto + 1
        ElseIf dgo2 = 300 Then
            MsgBox("Felicidades Jugador2 Ganaste ", vbInformation, "Juego 3 en raya")
            inbtn()
            punto = punto + 1
        End If

        lblpto.Text = punto
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblturno.Text = "Jugador1"
        lblptx.Text = puntx
        lblpto.Text = punto
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        seguir()
    End Sub

    Private Sub btn1fila1_Click_1(sender As Object, e As EventArgs) Handles btn1fila1.Click
        If lblturno.Text = "Jugador1" Then
            btn1fila1.Text = jugador1
            filax1 = filax1 + 1
            clmx1 = clmx1 + 1
            dgx = dgx + 10
        ElseIf lblturno.Text = "Jugador2" Then
            btn1fila1.Text = jugador2
            filao1 = filao1 + 1
            clmo1 = clmo1 + 1
            dgo = dgo + 10
        End If
        cambioturno()
        btn1fila1.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub btn2fila1_Click_1(sender As Object, e As EventArgs) Handles btn2fila1.Click
        If lblturno.Text = "Jugador1" Then
            btn2fila1.Text = jugador1
            filax1 = filax1 + 1
            clmx2 = clmx2 + 2
        ElseIf lblturno.Text = "Jugador2" Then
            btn2fila1.Text = jugador2
            filao1 = filao1 + 1
            clmo2 = clmo2 + 2
        End If
        cambioturno()
        btn2fila1.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub btn3fila1_Click_1(sender As Object, e As EventArgs) Handles btn3fila1.Click
        If lblturno.Text = "Jugador1" Then
            btn3fila1.Text = jugador1
            filax1 = filax1 + 1
            clmx3 = clmx3 + 3
            dgx2 = dgx2 + 100
        ElseIf lblturno.Text = "Jugador2" Then
            btn3fila1.Text = jugador2
            filao1 = filao1 + 1
            clmo3 = clmo3 + 3
            dgo2 = dgo + 100
        End If
        cambioturno()
        btn3fila1.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub btn1fila2_Click_1(sender As Object, e As EventArgs) Handles btn1fila2.Click
        If lblturno.Text = "Jugador1" Then
            btn1fila2.Text = jugador1
            filax2 = filax2 + 2
            clmx1 = clmx1 + 1
        ElseIf lblturno.Text = "Jugador2" Then
            btn1fila2.Text = jugador2
            filao2 = filao2 + 2
            clmo1 = clmo1 + 1
        End If
        cambioturno()
        btn1fila2.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub btn2fila2_Click_1(sender As Object, e As EventArgs) Handles btn2fila2.Click
        If lblturno.Text = "Jugador1" Then
            btn2fila2.Text = jugador1
            filax2 = filax2 + 2
            clmx2 = clmx2 + 2
            dgx = dgx + 10
            dgx2 = dgx2 + 100
        ElseIf lblturno.Text = "Jugador2" Then
            btn2fila2.Text = jugador2
            filao2 = filao2 + 2
            clmo2 = clmo2 + 2
            dgo = dgo + 10
            dgo2 = dgo2 + 100
        End If
        cambioturno()
        btn2fila2.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub btn3fila2_Click_1(sender As Object, e As EventArgs) Handles btn3fila2.Click
        If lblturno.Text = "Jugador1" Then
            btn3fila2.Text = jugador1
            filax2 = filax2 + 2
            clmx3 = clmx3 + 3
        ElseIf lblturno.Text = "Jugador2" Then
            btn3fila2.Text = jugador2
            filao2 = filao2 + 2
            clmo3 = clmo3 + 3
        End If
        cambioturno()
        btn3fila2.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub btn1fila3_Click_1(sender As Object, e As EventArgs) Handles btn1fila3.Click
        If lblturno.Text = "Jugador1" Then
            btn1fila3.Text = jugador1
            filax3 = filax3 + 3
            clmx1 = clmx1 + 1
            dgx2 = dgx2 + 100
        ElseIf lblturno.Text = "Jugador2" Then
            btn1fila3.Text = jugador2
            filao3 = filao3 + 3
            clmo1 = clmo1 + 1
            dgo2 = dgo2 + 100
        End If
        cambioturno()
        btn1fila3.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub btn2fila3_Click_1(sender As Object, e As EventArgs) Handles btn2fila3.Click
        If lblturno.Text = "Jugador1" Then
            btn2fila3.Text = jugador1
            filax3 = filax3 + 3
            clmx2 = clmx2 + 2
        ElseIf lblturno.Text = "Jugador2" Then
            btn2fila3.Text = jugador2
            filao3 = filao3 + 3
            clmo2 = clmo2 + 2
        End If
        cambioturno()
        btn2fila3.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub btn3fila3_Click_1(sender As Object, e As EventArgs) Handles btn3fila3.Click
        If lblturno.Text = "Jugador1" Then
            btn3fila3.Text = jugador1
            filax3 = filax3 + 3
            clmx3 = clmx3 + 3
            dgx = dgx + 10
        ElseIf lblturno.Text = "Jugador2" Then
            btn3fila3.Text = jugador2
            filao3 = filao3 + 3
            clmo3 = clmo3 + 3
            dgo = dgo + 10
        End If
        cambioturno()
        btn3fila3.Enabled = False
        ganador1()
        ganador2()
    End Sub

    Private Sub NuevoJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoJuegoToolStripMenuItem.Click
        seguir()
        puntx = 0
        punto = 0
        lblpto.Text = punto
        lblptx.Text = puntx
    End Sub
End Class
