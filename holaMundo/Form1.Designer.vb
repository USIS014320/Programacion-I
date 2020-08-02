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
        Me.LstTablas = New System.Windows.Forms.ListBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.txtntabla = New System.Windows.Forms.TextBox()
        Me.lbltabla = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstTablas
        '
        Me.LstTablas.FormattingEnabled = True
        Me.LstTablas.Location = New System.Drawing.Point(250, 12)
        Me.LstTablas.Name = "LstTablas"
        Me.LstTablas.Size = New System.Drawing.Size(256, 173)
        Me.LstTablas.TabIndex = 0
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(97, 135)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(109, 50)
        Me.btnProcesar.TabIndex = 1
        Me.btnProcesar.Text = "Generar tabla"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'txtntabla
        '
        Me.txtntabla.Location = New System.Drawing.Point(110, 31)
        Me.txtntabla.Name = "txtntabla"
        Me.txtntabla.Size = New System.Drawing.Size(96, 20)
        Me.txtntabla.TabIndex = 2
        '
        'lbltabla
        '
        Me.lbltabla.AutoSize = True
        Me.lbltabla.Location = New System.Drawing.Point(67, 31)
        Me.lbltabla.Name = "lbltabla"
        Me.lbltabla.Size = New System.Drawing.Size(37, 13)
        Me.lbltabla.TabIndex = 3
        Me.lbltabla.Text = "Tabla:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 259)
        Me.Controls.Add(Me.lbltabla)
        Me.Controls.Add(Me.txtntabla)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.LstTablas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstTablas As ListBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents txtntabla As TextBox
    Friend WithEvents lbltabla As Label
End Class
