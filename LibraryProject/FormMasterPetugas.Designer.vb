﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterPetugas
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(33, 235)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(503, 193)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 32)
        Label1.TabIndex = 1
        Label1.Text = "Kode Petugas"' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(33, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 32)
        Label2.TabIndex = 1
        Label2.Text = "Nama"' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(33, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 32)
        Label3.TabIndex = 1
        Label3.Text = "Password"' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(33, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 32)
        Label4.TabIndex = 1
        Label4.Text = "Level"' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(189, 28)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(178, 22)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(189, 59)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(347, 22)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(189, 91)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(178, 22)
        TextBox3.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(189, 123)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(178, 24)
        ComboBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(33, 177)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 38)
        Button1.TabIndex = 6
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(164, 177)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 38)
        Button2.TabIndex = 7
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(293, 177)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 38)
        Button3.TabIndex = 8
        Button3.Text = "HAPUS"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(427, 177)
        Button4.Name = "Button4"
        Button4.Size = New Size(109, 38)
        Button4.TabIndex = 9
        Button4.Text = "TUTUP"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' FormMasterPetugas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 440)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "FormMasterPetugas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Petugas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
