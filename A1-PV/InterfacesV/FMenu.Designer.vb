<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMenu
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSelectiva1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRepetitiva1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Interfaces de estructuras selectivas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Interfaces de estructura repetitivas"
        '
        'BtnSelectiva1
        '
        Me.BtnSelectiva1.Location = New System.Drawing.Point(102, 340)
        Me.BtnSelectiva1.Name = "BtnSelectiva1"
        Me.BtnSelectiva1.Size = New System.Drawing.Size(164, 43)
        Me.BtnSelectiva1.TabIndex = 10
        Me.BtnSelectiva1.Text = "Calculadora"
        Me.BtnSelectiva1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Menu demostrattivo de diferentes interfaces"
        '
        'BtnRepetitiva1
        '
        Me.BtnRepetitiva1.Location = New System.Drawing.Point(102, 150)
        Me.BtnRepetitiva1.Name = "BtnRepetitiva1"
        Me.BtnRepetitiva1.Size = New System.Drawing.Size(164, 43)
        Me.BtnRepetitiva1.TabIndex = 8
        Me.BtnRepetitiva1.Text = "Tabla de multiplicar"
        Me.BtnRepetitiva1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 43)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Potenciación"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 482)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSelectiva1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRepetitiva1)
        Me.Name = "FMenu"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSelectiva1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRepetitiva1 As Button
    Friend WithEvents Button1 As Button
End Class
