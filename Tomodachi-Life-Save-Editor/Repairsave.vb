﻿Imports System.IO
Imports PackageIO

Public Class Repairsave
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim fdialog As New Form2
    Dim applicationpath = Application.StartupPath
    Dim savedataArc As String

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
        TL_SaveEditor.Show()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub Repairsave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TL_SaveEditor.Filever_text.Text = "US" Then
            TLSE_logo.Image = My.Resources.logo_US
        ElseIf TL_SaveEditor.Filever_text.Text = "EU" Then
            TLSE_logo.Image = My.Resources.logo_EU
        ElseIf TL_SaveEditor.Filever_text.Text = "JP" Then
            TLSE_logo.Image = My.Resources.logo_JP
        ElseIf TL_SaveEditor.Filever_text.Text = "KR" Then
            TLSE_logo.Image = My.Resources.logo_KR
        End If
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Dim open As New OpenFileDialog
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            fdialog.Text_fdialog.Text = "Open savedataArc.txt" & vbNewLine & "Tomodachi Life Save Editor will make a backup of your save file before any changes, check ''bak\Tryrepair'' folder" & vbNewLine & vbNewLine & "Make sure you have choose right save file version"
            fdialog.ShowDialog()
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            fdialog.Text_fdialog.Text = "Ouvrir savedataArc.txt" & vbNewLine & "Tomodachi Life Save Editor va faire une copie de votre sauvegarde avant tout changements, vérifiez le dossier ''bak\Tryrepair''" & vbNewLine & vbNewLine & "Soyez sûr d'avoir choisi la bonne version de sauvegarde"
            fdialog.ShowDialog()
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            open.Filter = "Text files|*.txt"
            open.Title = "Open save savedataArc.txt"
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            open.Filter = "Fichiers texte|*.txt"
            open.Title = "Ouvrir la sauvegarde savedataArc.txt"
        End If
        open.ShowDialog()
        savedataArc = open.FileName
        readsavedataArc()
        makebak()
    End Sub

    Public Sub readsavedataArc()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = &H0
            Text_header.Text = Reader.ReadHexString(4)
            Text_menu_open.Visible = False
            Text_menu_save.Visible = True
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to read savedataArc.txt, make sure to have opened a Tomodachi Life save, or report this issue"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'ouverture de savedataArc.txt a échoué, soyez sûr d'avoir ouvert une sauvegarde de Tomodachi Life, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub makebak()
        Try
            My.Computer.FileSystem.CopyFile(
                         savedataArc,
                       applicationpath & "\bak\Tryrepair\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub writesavedataArc()
        Try
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            Writer.Position = &H0
            Writer.WriteHexString(Text_header.Text)
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "savedataArc.txt has been successfully edited"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "savedataArc.txt a été édité avec succès"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to write savedataArc.txt, make sure to have opened a Tomodachi Life save, or report this issue"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'écriture de savedataArc.txt a échoué, soyez sûr d'avoir ouvert une sauvegarde de Tomodachi Life, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Text_header_TextChanged(sender As Object, e As EventArgs) Handles Text_header.TextChanged
        If Text_header.Text = "11000000" Then
            Icon_repair_header.Image = My.Resources.repair_somethinggood
        Else
            Icon_repair_header.Image = My.Resources.repair_somethingwrong
            Text_header.BackColor = Color.Red
        End If
    End Sub

    Private Sub Info_repair_MouseMove(sender As Object, e As EventArgs) Handles Info_repair.MouseMove
        Icon_info_repair.Visible = True
    End Sub

    Private Sub Info_repair_MouseLeave(sender As Object, e As EventArgs) Handles Info_repair.MouseLeave
        Icon_info_repair.Visible = False
    End Sub

    Private Sub Icon_repair_header_Click(sender As Object, e As EventArgs) Handles Icon_repair_header.Click
        Text_header.Text = "11000000"
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        writesavedataArc()
    End Sub
End Class