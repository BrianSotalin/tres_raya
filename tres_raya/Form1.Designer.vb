<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblturno = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReiniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoJuegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn3fila3 = New System.Windows.Forms.Button()
        Me.btn2fila3 = New System.Windows.Forms.Button()
        Me.btn1fila3 = New System.Windows.Forms.Button()
        Me.btn3fila2 = New System.Windows.Forms.Button()
        Me.btn2fila2 = New System.Windows.Forms.Button()
        Me.btn1fila2 = New System.Windows.Forms.Button()
        Me.btn3fila1 = New System.Windows.Forms.Button()
        Me.btn2fila1 = New System.Windows.Forms.Button()
        Me.btn1fila1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblptx = New System.Windows.Forms.Label()
        Me.lblpto = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label1.Location = New System.Drawing.Point(29, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Turno:"
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.BackColor = System.Drawing.Color.Transparent
        Me.lblturno.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturno.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.lblturno.Location = New System.Drawing.Point(154, 432)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(84, 26)
        Me.lblturno.TabIndex = 10
        Me.lblturno.Text = "Jugador"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReiniciarToolStripMenuItem, Me.NuevoJuegoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(315, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReiniciarToolStripMenuItem
        '
        Me.ReiniciarToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ReiniciarToolStripMenuItem.Name = "ReiniciarToolStripMenuItem"
        Me.ReiniciarToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ReiniciarToolStripMenuItem.Text = "Seguir Jugando"
        '
        'NuevoJuegoToolStripMenuItem
        '
        Me.NuevoJuegoToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.NuevoJuegoToolStripMenuItem.Name = "NuevoJuegoToolStripMenuItem"
        Me.NuevoJuegoToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.NuevoJuegoToolStripMenuItem.Text = "Nueva Partida"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.SalirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn3fila3
        '
        Me.btn3fila3.BackColor = System.Drawing.Color.DarkRed
        Me.btn3fila3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn3fila3.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3fila3.ForeColor = System.Drawing.Color.Black
        Me.btn3fila3.Location = New System.Drawing.Point(205, 349)
        Me.btn3fila3.Name = "btn3fila3"
        Me.btn3fila3.Size = New System.Drawing.Size(80, 80)
        Me.btn3fila3.TabIndex = 26
        Me.btn3fila3.UseVisualStyleBackColor = False
        '
        'btn2fila3
        '
        Me.btn2fila3.BackColor = System.Drawing.Color.DarkRed
        Me.btn2fila3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2fila3.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2fila3.ForeColor = System.Drawing.Color.Black
        Me.btn2fila3.Location = New System.Drawing.Point(119, 349)
        Me.btn2fila3.Name = "btn2fila3"
        Me.btn2fila3.Size = New System.Drawing.Size(80, 80)
        Me.btn2fila3.TabIndex = 25
        Me.btn2fila3.UseVisualStyleBackColor = False
        '
        'btn1fila3
        '
        Me.btn1fila3.BackColor = System.Drawing.Color.DarkRed
        Me.btn1fila3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1fila3.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1fila3.ForeColor = System.Drawing.Color.Black
        Me.btn1fila3.Location = New System.Drawing.Point(33, 349)
        Me.btn1fila3.Name = "btn1fila3"
        Me.btn1fila3.Size = New System.Drawing.Size(80, 80)
        Me.btn1fila3.TabIndex = 24
        Me.btn1fila3.UseVisualStyleBackColor = False
        '
        'btn3fila2
        '
        Me.btn3fila2.BackColor = System.Drawing.Color.DarkRed
        Me.btn3fila2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn3fila2.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3fila2.ForeColor = System.Drawing.Color.Black
        Me.btn3fila2.Location = New System.Drawing.Point(205, 263)
        Me.btn3fila2.Name = "btn3fila2"
        Me.btn3fila2.Size = New System.Drawing.Size(80, 80)
        Me.btn3fila2.TabIndex = 23
        Me.btn3fila2.UseVisualStyleBackColor = False
        '
        'btn2fila2
        '
        Me.btn2fila2.BackColor = System.Drawing.Color.DarkRed
        Me.btn2fila2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2fila2.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2fila2.ForeColor = System.Drawing.Color.Black
        Me.btn2fila2.Location = New System.Drawing.Point(119, 263)
        Me.btn2fila2.Name = "btn2fila2"
        Me.btn2fila2.Size = New System.Drawing.Size(80, 80)
        Me.btn2fila2.TabIndex = 22
        Me.btn2fila2.UseVisualStyleBackColor = False
        '
        'btn1fila2
        '
        Me.btn1fila2.BackColor = System.Drawing.Color.DarkRed
        Me.btn1fila2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1fila2.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1fila2.ForeColor = System.Drawing.Color.Black
        Me.btn1fila2.Location = New System.Drawing.Point(33, 263)
        Me.btn1fila2.Name = "btn1fila2"
        Me.btn1fila2.Size = New System.Drawing.Size(80, 80)
        Me.btn1fila2.TabIndex = 21
        Me.btn1fila2.UseVisualStyleBackColor = False
        '
        'btn3fila1
        '
        Me.btn3fila1.BackColor = System.Drawing.Color.DarkRed
        Me.btn3fila1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn3fila1.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3fila1.ForeColor = System.Drawing.Color.Black
        Me.btn3fila1.Location = New System.Drawing.Point(205, 177)
        Me.btn3fila1.Name = "btn3fila1"
        Me.btn3fila1.Size = New System.Drawing.Size(80, 80)
        Me.btn3fila1.TabIndex = 20
        Me.btn3fila1.UseVisualStyleBackColor = False
        '
        'btn2fila1
        '
        Me.btn2fila1.BackColor = System.Drawing.Color.DarkRed
        Me.btn2fila1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2fila1.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2fila1.ForeColor = System.Drawing.Color.Black
        Me.btn2fila1.Location = New System.Drawing.Point(119, 177)
        Me.btn2fila1.Name = "btn2fila1"
        Me.btn2fila1.Size = New System.Drawing.Size(80, 80)
        Me.btn2fila1.TabIndex = 19
        Me.btn2fila1.UseVisualStyleBackColor = False
        '
        'btn1fila1
        '
        Me.btn1fila1.BackColor = System.Drawing.Color.DarkRed
        Me.btn1fila1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1fila1.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1fila1.ForeColor = System.Drawing.Color.Black
        Me.btn1fila1.Location = New System.Drawing.Point(33, 177)
        Me.btn1fila1.Name = "btn1fila1"
        Me.btn1fila1.Size = New System.Drawing.Size(80, 80)
        Me.btn1fila1.TabIndex = 18
        Me.btn1fila1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(109, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 22)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Jugador1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label3.Location = New System.Drawing.Point(3, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Puntaje:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(205, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Jugador2"
        '
        'lblptx
        '
        Me.lblptx.AutoSize = True
        Me.lblptx.BackColor = System.Drawing.Color.Transparent
        Me.lblptx.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblptx.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblptx.Location = New System.Drawing.Point(109, 144)
        Me.lblptx.Name = "lblptx"
        Me.lblptx.Size = New System.Drawing.Size(20, 22)
        Me.lblptx.TabIndex = 30
        Me.lblptx.Text = "0"
        '
        'lblpto
        '
        Me.lblpto.AutoSize = True
        Me.lblpto.BackColor = System.Drawing.Color.Transparent
        Me.lblpto.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpto.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblpto.Location = New System.Drawing.Point(205, 144)
        Me.lblpto.Name = "lblpto"
        Me.lblpto.Size = New System.Drawing.Size(20, 22)
        Me.lblpto.TabIndex = 31
        Me.lblpto.Text = "0"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.MenuStrip1
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me
        Me.BunifuDragControl2.Vertical = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(37, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 28)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "3 en raya"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tres_raya.My.Resources.Resources._3raya
        Me.PictureBox1.Location = New System.Drawing.Point(172, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(315, 494)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblpto)
        Me.Controls.Add(Me.btn1fila2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn3fila2)
        Me.Controls.Add(Me.lblturno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn3fila3)
        Me.Controls.Add(Me.btn2fila1)
        Me.Controls.Add(Me.btn3fila1)
        Me.Controls.Add(Me.btn1fila3)
        Me.Controls.Add(Me.lblptx)
        Me.Controls.Add(Me.btn2fila3)
        Me.Controls.Add(Me.btn2fila2)
        Me.Controls.Add(Me.btn1fila1)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego tres en raya"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblturno As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReiniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoJuegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn3fila3 As Button
    Friend WithEvents btn2fila3 As Button
    Friend WithEvents btn1fila3 As Button
    Friend WithEvents btn3fila2 As Button
    Friend WithEvents btn2fila2 As Button
    Friend WithEvents btn1fila2 As Button
    Friend WithEvents btn3fila1 As Button
    Friend WithEvents btn2fila1 As Button
    Friend WithEvents btn1fila1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblptx As Label
    Friend WithEvents lblpto As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
