<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits LeulOutils.Fenetres.frmModele

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdQuitter = New LeulOutils.Controls.Boutons.cmdQuitter
        Me.txtAdresse = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblLongitude = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblLatitude = New System.Windows.Forms.Label
        Me.cmdChercher = New LeulOutils.Controls.Boutons.cmdChercher
        Me.wbrCarte = New System.Windows.Forms.WebBrowser
        Me.tkbZoom = New System.Windows.Forms.TrackBar
        Me.cboMapType = New System.Windows.Forms.ComboBox
        Me.grpBoutons.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tkbZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoutons
        '
        Me.grpBoutons.Controls.Add(Me.cboMapType)
        Me.grpBoutons.Controls.Add(Me.cmdQuitter)
        Me.grpBoutons.Location = New System.Drawing.Point(3, 707)
        Me.grpBoutons.Size = New System.Drawing.Size(548, 41)
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Location = New System.Drawing.Point(449, 12)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.TabIndex = 0
        '
        'txtAdresse
        '
        Me.txtAdresse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAdresse.Location = New System.Drawing.Point(3, 16)
        Me.txtAdresse.Multiline = True
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(533, 81)
        Me.txtAdresse.TabIndex = 6
        Me.txtAdresse.Text = "106 boulevard de thouars 79300 bressuire"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adresse :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLongitude)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 44)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Longitude :"
        '
        'lblLongitude
        '
        Me.lblLongitude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLongitude.Location = New System.Drawing.Point(6, 16)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(142, 23)
        Me.lblLongitude.TabIndex = 0
        Me.lblLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblLatitude)
        Me.GroupBox3.Location = New System.Drawing.Point(170, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(155, 44)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Latitude :"
        '
        'lblLatitude
        '
        Me.lblLatitude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLatitude.Location = New System.Drawing.Point(6, 16)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(142, 23)
        Me.lblLatitude.TabIndex = 0
        Me.lblLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdChercher
        '
        Me.cmdChercher.Location = New System.Drawing.Point(331, 125)
        Me.cmdChercher.Name = "cmdChercher"
        Me.cmdChercher.TabIndex = 10
        '
        'wbrCarte
        '
        Me.wbrCarte.IsWebBrowserContextMenuEnabled = False
        Me.wbrCarte.Location = New System.Drawing.Point(6, 162)
        Me.wbrCarte.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrCarte.Name = "wbrCarte"
        Me.wbrCarte.ScrollBarsEnabled = False
        Me.wbrCarte.Size = New System.Drawing.Size(540, 540)
        Me.wbrCarte.TabIndex = 11
        Me.wbrCarte.Url = New System.Uri("", System.UriKind.Relative)
        '
        'tkbZoom
        '
        Me.tkbZoom.LargeChange = 1
        Me.tkbZoom.Location = New System.Drawing.Point(372, 112)
        Me.tkbZoom.Maximum = 20
        Me.tkbZoom.Name = "tkbZoom"
        Me.tkbZoom.Size = New System.Drawing.Size(174, 45)
        Me.tkbZoom.TabIndex = 12
        Me.tkbZoom.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tkbZoom.Value = 8
        '
        'cboMapType
        '
        Me.cboMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMapType.FormattingEnabled = True
        Me.cboMapType.Location = New System.Drawing.Point(12, 12)
        Me.cboMapType.Name = "cboMapType"
        Me.cboMapType.Size = New System.Drawing.Size(240, 21)
        Me.cboMapType.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 751)
        Me.Controls.Add(Me.tkbZoom)
        Me.Controls.Add(Me.wbrCarte)
        Me.Controls.Add(Me.cmdChercher)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMain"
        Me.ShowIcon = True
        Me.ShowInTaskbar = True
        Me.Text = "Coordonnées GPS d'une adresse"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grpBoutons, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.cmdChercher, 0)
        Me.Controls.SetChildIndex(Me.wbrCarte, 0)
        Me.Controls.SetChildIndex(Me.tkbZoom, 0)
        Me.grpBoutons.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.tkbZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdQuitter As LeulOutils.Controls.Boutons.cmdQuitter
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLongitude As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLatitude As System.Windows.Forms.Label
    Friend WithEvents cmdChercher As LeulOutils.Controls.Boutons.cmdChercher
    Friend WithEvents wbrCarte As System.Windows.Forms.WebBrowser
    Friend WithEvents tkbZoom As System.Windows.Forms.TrackBar
    Friend WithEvents cboMapType As System.Windows.Forms.ComboBox

End Class
