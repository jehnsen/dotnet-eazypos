Public Class frmConnection

    Private Sub frmConnection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfigValueToControls()
    End Sub

    Private Sub LoadConfigValueToControls()
        txtServer.Text = System.Configuration.ConfigurationManager.AppSettings.Get("server")
        txtDatabase.Text = System.Configuration.ConfigurationManager.AppSettings.Get("database")
        txtUsername.Text = System.Configuration.ConfigurationManager.AppSettings.Get("username")
        txtPassword.Text = System.Configuration.ConfigurationManager.AppSettings.Get("password")
        txtPort.Text = System.Configuration.ConfigurationManager.AppSettings.Get("port")
        cboAuthentication.Text = System.Configuration.ConfigurationManager.AppSettings.Get("connection")
    End Sub

    Public Sub saveupdate()

        AppConfigFileSettings.UpdateAppSettings("server", txtServer.Text)
        AppConfigFileSettings.UpdateAppSettings("database", txtDatabase.Text)
        AppConfigFileSettings.UpdateAppSettings("username", txtUsername.Text)
        AppConfigFileSettings.UpdateAppSettings("password", txtPassword.Text)
        AppConfigFileSettings.UpdateAppSettings("port", txtPort.Text)
        AppConfigFileSettings.UpdateAppSettings("connection", cboAuthentication.Text)

    End Sub

    Private Sub btnTestConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestConnection.Click
        If ConnServer() = True Then
            MsgBox("Connected to database!", vbInformation, "Database Connection")
        Else
            MsgBox("Connection failed!", vbInformation, "Database Connection")
        End If
    End Sub

    Private Sub btnUpdateConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateConnection.Click
        saveupdate()
        System.Configuration.ConfigurationManager.RefreshSection("AppSettings")
        MsgBox("Connection settings was Updated!", vbInformation, "Connect")
        Application.Restart()
    End Sub

    Private Sub cboAuthentication_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAuthentication.SelectedIndexChanged
        If cboAuthentication.Text = "Windows Authentication" Then
            txtUsername.Enabled = False
            txtPassword.Enabled = False
            txtPort.Enabled = False
        Else
            txtUsername.Enabled = True
            txtPassword.Enabled = True
            txtPort.Enabled = True
        End If
    End Sub

End Class