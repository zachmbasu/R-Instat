﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFromLibrary
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
        Me.ucrBase = New instat.ucrButtons()
        Me.lblBrowse = New System.Windows.Forms.Label()
        Me.cmdLibraryCollection = New System.Windows.Forms.Button()
        Me.chkChooseFrom = New System.Windows.Forms.CheckBox()
        Me.lstDataCollection = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(0, 115)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'lblBrowse
        '
        Me.lblBrowse.AutoSize = True
        Me.lblBrowse.Location = New System.Drawing.Point(12, 9)
        Me.lblBrowse.Name = "lblBrowse"
        Me.lblBrowse.Size = New System.Drawing.Size(131, 13)
        Me.lblBrowse.TabIndex = 1
        Me.lblBrowse.Text = "Browse from our collection"
        '
        'cmdLibraryCollection
        '
        Me.cmdLibraryCollection.Location = New System.Drawing.Point(15, 25)
        Me.cmdLibraryCollection.Name = "cmdLibraryCollection"
        Me.cmdLibraryCollection.Size = New System.Drawing.Size(142, 23)
        Me.cmdLibraryCollection.TabIndex = 2
        Me.cmdLibraryCollection.Text = "Browse Collection"
        Me.cmdLibraryCollection.UseVisualStyleBackColor = True
        '
        'chkChooseFrom
        '
        Me.chkChooseFrom.AutoSize = True
        Me.chkChooseFrom.Location = New System.Drawing.Point(163, 9)
        Me.chkChooseFrom.Name = "chkChooseFrom"
        Me.chkChooseFrom.Size = New System.Drawing.Size(98, 17)
        Me.chkChooseFrom.TabIndex = 3
        Me.chkChooseFrom.Text = "Or Load from R"
        Me.chkChooseFrom.UseVisualStyleBackColor = True
        '
        'lstDataCollection
        '
        Me.lstDataCollection.Location = New System.Drawing.Point(267, 9)
        Me.lstDataCollection.MultiSelect = False
        Me.lstDataCollection.Name = "lstDataCollection"
        Me.lstDataCollection.Size = New System.Drawing.Size(127, 100)
        Me.lstDataCollection.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstDataCollection.TabIndex = 4
        Me.lstDataCollection.UseCompatibleStateImageBehavior = False
        Me.lstDataCollection.View = System.Windows.Forms.View.Details
        '
        'dlgFromLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 168)
        Me.Controls.Add(Me.lstDataCollection)
        Me.Controls.Add(Me.chkChooseFrom)
        Me.Controls.Add(Me.cmdLibraryCollection)
        Me.Controls.Add(Me.lblBrowse)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFromLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Open from library"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblBrowse As Label
    Friend WithEvents cmdLibraryCollection As Button
    Friend WithEvents chkChooseFrom As CheckBox
    Friend WithEvents lstDataCollection As ListView
End Class