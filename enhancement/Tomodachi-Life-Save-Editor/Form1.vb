﻿Imports System.Net
Imports System.IO
Imports PackageIO

Public Class TL_SaveEditor
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim fdialog As New Form2
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim money As String
    Dim IslN As String
    Dim Islp As String
    Dim Mii1L As String
    Dim Mii1P As String
    Dim Mii1N As String
    Dim Mii1S As String
    Dim Mii1C As String
    Dim Mii1PP As String
    Dim Mii1NP As String
    Dim Mii1SP As String
    Dim Mii1R As String
    Dim soucis As String
    Dim vrecu As String
    Dim weddi As String
    Dim born As String
    Dim vsent As String
    Dim stpass As String
    Dim bullj1 As String
    Dim bullj2 As String
    Dim bull1 As String
    Dim bull2 As String
    Dim bull3 As String
    Dim bull4 As String
    Dim bull5 As String
    Dim antiTT As String
    Dim objet1 As String
    Dim objet2 As String
    Dim objet3 As String
    Dim objet4 As String
    Dim objet5 As String
    Dim objet6 As String
    Dim objet7 As String
    Dim objet8 As String
    Dim exp As String
    Dim econom As String
    Dim fullness As String
    Dim eat As String
    Dim interieur As String
    Dim interieur1 As String
    Dim Sfoods As String
    Dim objdiv As String
    Dim appart As String
    Dim mair As String
    Dim info As String
    Dim classem As String
    Dim vetem As String
    Dim chap As String
    Dim epicer As String
    Dim deco As String
    Dim broc As String
    Dim magimport As String
    Dim fontai As String
    Dim mais As String
    Dim port As String
    Dim tervague As String
    Dim conc As String
    Dim test As String
    Dim stud As String
    Dim plage As String
    Dim parc1 As String
    Dim cafe As String
    Dim parc As String
    Dim tour As String
    Dim part As String
    Dim frie1 As String
    Dim frie2 As String
    Dim alltime As String
    Dim alltime2 As String
    Dim fav As String
    Dim fav2 As String
    Dim fav3 As String
    Dim worst As String
    Dim worst2 As String
    Dim copy As String
    Dim sharing As String
    Dim couleur As String
    Dim grow As String
    Dim appartement As String
    Dim eventfountain As String
    Dim appartrenov As String
    Dim Splurge As String
    Dim Pampered As String
    Dim Miifriendr As String
    Dim MiiHC As String
    Dim House As String
    Dim Mhouse As String
    Dim Miimusic As String
    Dim Miiinteraction As String
    Dim Miitarget1 As String
    Dim Miitarget2 As String
    Dim Accessmii As String
    Dim Accessfriends As String
    Dim Emotions As String
    Dim Accessfriendlist As String
    Dim AccessMiilist As String
    Dim Accessrelalist As String
    Dim Patchmii As String

    Private Sub hidepanels()
        Panel_islandedit.Visible = False
        Panel_extras.Visible = False
        Panel_settings.Visible = False
        Panel_miiedit.Visible = False
    End Sub

    Private Sub unselectcolor()
        color_1.BorderStyle = BorderStyle.None
        color_2.BorderStyle = BorderStyle.None
        color_2.BorderStyle = BorderStyle.None
        color_3.BorderStyle = BorderStyle.None
        color_3.BorderStyle = BorderStyle.None
        color_4.BorderStyle = BorderStyle.None
        color_4.BorderStyle = BorderStyle.None
        color_5.BorderStyle = BorderStyle.None
        color_5.BorderStyle = BorderStyle.None
        color_6.BorderStyle = BorderStyle.None
        color_6.BorderStyle = BorderStyle.None
        color_7.BorderStyle = BorderStyle.None
        color_7.BorderStyle = BorderStyle.None
        color_8.BorderStyle = BorderStyle.None
        color_8.BorderStyle = BorderStyle.None
        color_9.BorderStyle = BorderStyle.None
        color_9.BorderStyle = BorderStyle.None
        color_10.BorderStyle = BorderStyle.None
        color_10.BorderStyle = BorderStyle.None
        color_11.BorderStyle = BorderStyle.None
        color_11.BorderStyle = BorderStyle.None
        color_12.BorderStyle = BorderStyle.None
        color_12.BorderStyle = BorderStyle.None
        color_13.BorderStyle = BorderStyle.None
        color_13.BorderStyle = BorderStyle.None
        color_14.BorderStyle = BorderStyle.None
        color_14.BorderStyle = BorderStyle.None
        color_15.BorderStyle = BorderStyle.None
        color_15.BorderStyle = BorderStyle.None
        color_16.BorderStyle = BorderStyle.None
        color_16.BorderStyle = BorderStyle.None
        color_17.BorderStyle = BorderStyle.None
        color_17.BorderStyle = BorderStyle.None
        color_18.BorderStyle = BorderStyle.None
        color_18.BorderStyle = BorderStyle.None
        color_19.BorderStyle = BorderStyle.None
        color_19.BorderStyle = BorderStyle.None
        color_20.BorderStyle = BorderStyle.None
        color_20.BorderStyle = BorderStyle.None
        color_21.BorderStyle = BorderStyle.None
        color_21.BorderStyle = BorderStyle.None
        color_22.BorderStyle = BorderStyle.None
        color_22.BorderStyle = BorderStyle.None
        color_23.BorderStyle = BorderStyle.None
        color_23.BorderStyle = BorderStyle.None
        color_24.BorderStyle = BorderStyle.None
        color_24.BorderStyle = BorderStyle.None
        color_25.BorderStyle = BorderStyle.None
        color_25.BorderStyle = BorderStyle.None
        color_26.BorderStyle = BorderStyle.None
        color_26.BorderStyle = BorderStyle.None
        color_27.BorderStyle = BorderStyle.None
        color_27.BorderStyle = BorderStyle.None
        color_28.BorderStyle = BorderStyle.None
        color_28.BorderStyle = BorderStyle.None
        color_29.BorderStyle = BorderStyle.None
        color_29.BorderStyle = BorderStyle.None
        color_30.BorderStyle = BorderStyle.None
        color_30.BorderStyle = BorderStyle.None
        color_31.BorderStyle = BorderStyle.None
        color_31.BorderStyle = BorderStyle.None
        color_32.BorderStyle = BorderStyle.None
        color_32.BorderStyle = BorderStyle.None
        color_empty.BorderStyle = BorderStyle.None
    End Sub

    Public Sub makebak()
        Try
            If Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\bak\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\bak\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\bak\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "KR" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\bak\KOR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub veriffilever()
        Timer1.Start()
    End Sub

    Public Sub Stopveriffilever()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Filever_text.ForeColor = Color.White
    End Sub

    Public Sub switchfilever()
        If Filever_text.Text = "US" Then
            Filever_text.Text = "EU"
            TLSE_logo.Image = My.Resources.logo_EU
            TLSE_logo_update.Image = My.Resources.logo_EU_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Icon_pronun_firstname.Visible = True
            Icon_pronun_lastname.Visible = True
            Icon_pronun_nickname.Visible = True
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 20
            Panel_cathph_01.Visible = True
            Icon_cathph_01.Visible = True
            Panel_cathph_J1.Visible = False
            Panel_cathph_J2.Visible = False
            Icon_cathphrase.Image = My.Resources.icon_mii_cathphrase
            Text_edit_metal.Enabled = True
            Text_edit_ballad.Enabled = True
            Text_edit_musical.Enabled = True
            Text_edit_opera.Enabled = True
            Text_edit_pop.Enabled = True
            Text_edit_rap.Enabled = True
            Text_edit_rockroll.Enabled = True
            Text_edit_techno.Enabled = True
            Select_allfav_1.Visible = True
            Select_allfav_2.Visible = True
            Select_fav_1.Visible = True
            Select_fav_2.Visible = True
            Select_fav_3.Visible = True
            Select_worst_1.Visible = True
            Select_worst_2.Visible = True
        ElseIf Filever_text.Text = "EU" Then
            Filever_text.Text = "JP"
            TLSE_logo.Image = My.Resources.logo_JP
            TLSE_logo_update.Image = My.Resources.logo_JP_update
            Icon_pronun_islandname.Visible = False
            Icon_tour.Image = My.Resources.touri
            Icon_part.Image = My.Resources.parti
            Icon_tour.Enabled = False
            Icon_part.Enabled = False
            Icon_pronun_firstname.Visible = False
            Icon_pronun_lastname.Visible = False
            Icon_pronun_nickname.Visible = False
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 0
            Panel_cathph_01.Visible = False
            Icon_cathph_01.Visible = False
            Panel_cathph_J1.Visible = True
            Panel_cathph_J2.Visible = True
            Icon_cathphrase.Image = My.Resources.icon_mii_cathphrase_j
            Text_edit_metal.Enabled = False
            Text_edit_ballad.Enabled = False
            Text_edit_musical.Enabled = False
            Text_edit_opera.Enabled = False
            Text_edit_pop.Enabled = False
            Text_edit_rap.Enabled = False
            Text_edit_rockroll.Enabled = False
            Text_edit_techno.Enabled = False
            Select_allfav_1.Visible = False
            Select_allfav_2.Visible = False
            Select_fav_1.Visible = False
            Select_fav_2.Visible = False
            Select_fav_3.Visible = False
            Select_worst_1.Visible = False
            Select_worst_2.Visible = False
        ElseIf Filever_text.Text = "JP" Then
            Filever_text.Text = "KR"
            TLSE_logo.Image = My.Resources.logo_KR
            TLSE_logo_update.Image = My.Resources.logo_KR_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Icon_pronun_firstname.Visible = True
            Icon_pronun_lastname.Visible = True
            Icon_pronun_nickname.Visible = True
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 20
            Panel_cathph_01.Visible = True
            Icon_cathph_01.Visible = True
            Panel_cathph_J1.Visible = False
            Panel_cathph_J2.Visible = False
            Icon_cathphrase.Image = My.Resources.icon_mii_cathphrase
            Text_edit_metal.Enabled = False
            Text_edit_ballad.Enabled = False
            Text_edit_musical.Enabled = False
            Text_edit_opera.Enabled = False
            Text_edit_pop.Enabled = False
            Text_edit_rap.Enabled = False
            Text_edit_rockroll.Enabled = False
            Text_edit_techno.Enabled = False
            Select_allfav_1.Visible = False
            Select_allfav_2.Visible = False
            Select_fav_1.Visible = False
            Select_fav_2.Visible = False
            Select_fav_3.Visible = False
            Select_worst_1.Visible = False
            Select_worst_2.Visible = False
        ElseIf Filever_text.Text = "KR" Then
            Filever_text.Text = "US"
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Icon_pronun_firstname.Visible = True
            Icon_pronun_lastname.Visible = True
            Icon_pronun_nickname.Visible = True
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 20
            Panel_cathph_01.Visible = True
            Icon_cathph_01.Visible = True
            Panel_cathph_J1.Visible = False
            Panel_cathph_J2.Visible = False
            Icon_cathphrase.Image = My.Resources.icon_mii_cathphrase
            Text_edit_metal.Enabled = True
            Text_edit_ballad.Enabled = True
            Text_edit_musical.Enabled = True
            Text_edit_opera.Enabled = True
            Text_edit_pop.Enabled = True
            Text_edit_rap.Enabled = True
            Text_edit_rockroll.Enabled = True
            Text_edit_techno.Enabled = True
            Select_allfav_1.Visible = True
            Select_allfav_2.Visible = True
            Select_fav_1.Visible = True
            Select_fav_2.Visible = True
            Select_fav_3.Visible = True
            Select_worst_1.Visible = True
            Select_worst_2.Visible = True
        ElseIf Filever_text.Text = "" Then
            Filever_text.Text = "US"
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Icon_pronun_firstname.Visible = True
            Icon_pronun_lastname.Visible = True
            Icon_pronun_nickname.Visible = True
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 20
            Panel_cathph_01.Visible = True
            Icon_cathph_01.Visible = True
            Panel_cathph_J1.Visible = False
            Panel_cathph_J2.Visible = False
            Icon_cathphrase.Image = My.Resources.icon_mii_cathphrase
            Text_edit_metal.Enabled = True
            Text_edit_ballad.Enabled = True
            Text_edit_musical.Enabled = True
            Text_edit_opera.Enabled = True
            Text_edit_pop.Enabled = True
            Text_edit_rap.Enabled = True
            Text_edit_rockroll.Enabled = True
            Text_edit_techno.Enabled = True
            Select_allfav_1.Visible = True
            Select_allfav_2.Visible = True
            Select_fav_1.Visible = True
            Select_fav_2.Visible = True
            Select_fav_3.Visible = True
            Select_worst_1.Visible = True
            Select_worst_2.Visible = True
        End If
        Icon_changelog.Image = TLSE_logo.Image
    End Sub

    Public Sub startmusic()
        Panel_music.Visible = True
        If Select_music.SelectedItem = Select_music.Items.Item(0) Then
            AudioTomodachi = My.Resources.sound1
        ElseIf Select_music.SelectedItem = Select_music.Items.Item(1) Then
            AudioTomodachi = My.Resources.sound2
        ElseIf Select_music.SelectedItem = Select_music.Items.Item(2) Then
            AudioTomodachi = My.Resources.sound3
        End If
        If Setting_music.Checked = True Then
            My.Computer.Audio.Play(AudioTomodachi, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
            Panel_music.Visible = False
        End If
    End Sub

    Public Sub Checkupdates()
        If Setting_ckupdate.Checked = False Then
            Try
                Dim MAJ As New WebClient
                Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Tomodachi-Life-Save-Editor/master/Version.txt")
                If Text_TLSE_version.Text = lastupdate Then
                    TLSE_logo.Visible = True
                    TLSE_logo_update.Visible = False
                Else
                    TLSE_logo.Visible = False
                    TLSE_logo_update.Visible = True
                    If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                        fdialog.Text_fdialog.Text = "An update is avalible, click on Tomodachi Life Save Editor icon to download new version"
                        fdialog.ShowDialog()
                    End If
                    If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                        fdialog.Text_fdialog.Text = "Une mise à jour est disponible, cliquez sur l'îcone de Tomodachi Life Save Editor pour télécharger la nouvelle version"
                        fdialog.ShowDialog()
                    End If
                End If
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    fdialog.Text_fdialog.Text = "An error has occured when checking updates"
                    fdialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    fdialog.Text_fdialog.Text = "Une erreur est survenue lors de la vérification des mises à jour"
                    fdialog.ShowDialog()
                End If
            End Try
        End If
    End Sub

    Public Sub readsavedataArc()
        Try
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
                Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
                Reader.Position = &H1E4BB8
                money = Reader.Position
                value_money.Value = Reader.ReadUInt32
                Reader.Position = &H1E4BCC
                IslN = Reader.Position
                Text_islandname.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1E4BF6
                Islp = Reader.Position
                Text_pronun_islandname.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1E4BC6
                soucis = Reader.Position
                value_problemsolved.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BBE
                vrecu = Reader.Position
                value_travelersreceived.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BC0
                weddi = Reader.Position
                value_weddings.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BC2
                born = Reader.Position
                value_childrenborn.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BC4
                vsent = Reader.Position
                value_travelerssent.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BBC
                stpass = Reader.Position
                value_streetpassencounters.Value = Reader.ReadUInt16
                Reader.Position = &H1E4C20
                appart = Reader.Position
                value_appart.Value = Reader.ReadInt8
                Reader.Position = &H1E4C21
                mair = Reader.Position
                value_mair.Value = Reader.ReadInt8
                Reader.Position = &H1E4C22
                info = Reader.Position
                value_info.Value = Reader.ReadInt8
                Reader.Position = &H1E4C23
                classem = Reader.Position
                value_classem.Value = Reader.ReadInt8
                Reader.Position = &H1E4C24
                vetem = Reader.Position
                value_vetem.Value = Reader.ReadInt8
                Reader.Position = &H1E4C25
                chap = Reader.Position
                value_chap.Value = Reader.ReadInt8
                Reader.Position = &H1E4C26
                epicer = Reader.Position
                value_epicer.Value = Reader.ReadInt8
                Reader.Position = &H1E4C27
                deco = Reader.Position
                value_deco.Value = Reader.ReadInt8
                Reader.Position = &H1E4C28
                broc = Reader.Position
                value_broc.Value = Reader.ReadInt8
                Reader.Position = &H1E4C29
                magimport = Reader.Position
                value_magimport.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2A
                fontai = Reader.Position
                value_font.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2B
                mais = Reader.Position
                value_mais.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2C
                port = Reader.Position
                value_port.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2D
                tervague = Reader.Position
                value_tervague.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2E
                conc = Reader.Position
                value_conc.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2F
                test = Reader.Position
                value_test.Value = Reader.ReadInt8
                Reader.Position = &H1E4C30
                stud = Reader.Position
                value_stud.Value = Reader.ReadInt8
                Reader.Position = &H1E4C31
                plage = Reader.Position
                value_plage.Value = Reader.ReadInt8
                Reader.Position = &H1E4C32
                parc1 = Reader.Position
                value_parc1.Value = Reader.ReadInt8
                Reader.Position = &H1E4C33
                cafe = Reader.Position
                value_cafe.Value = Reader.ReadInt8
                Reader.Position = &H1E4C34
                parc = Reader.Position
                value_parc.Value = Reader.ReadInt8
                Reader.Position = &H1E4C35
                tour = Reader.Position
                value_tour.Value = Reader.ReadInt8
                Reader.Position = &H1E4C36
                part = Reader.Position
                value_part.Value = Reader.ReadInt8
                Reader.Position = &H1E4AF8
                eventfountain = Reader.Position
                value_eventfountain.Value = Reader.ReadUInt32
                Reader.Position = &H1E4C79
                appartrenov = Reader.Position
                value_appartrenov.Value = Reader.ReadInt8
            End If
            If Filever_text.Text = "JP" Then
                Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
                Reader.Position = &H14BCA8
                money = Reader.Position
                value_money.Value = Reader.ReadUInt32
                Reader.Position = &H14BCBC
                IslN = Reader.Position
                Text_islandname.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H14BCB6
                soucis = Reader.Position
                value_problemsolved.Value = Reader.ReadUInt16
                Reader.Position = &H14BCAE
                vrecu = Reader.Position
                value_travelersreceived.Value = Reader.ReadUInt16
                Reader.Position = &H14BCB0
                weddi = Reader.Position
                value_weddings.Value = Reader.ReadUInt16
                Reader.Position = &H14BCB2
                born = Reader.Position
                value_childrenborn.Value = Reader.ReadUInt16
                Reader.Position = &H14BCB4
                vsent = Reader.Position
                value_travelerssent.Value = Reader.ReadUInt16
                Reader.Position = &H14BCAC
                stpass = Reader.Position
                value_streetpassencounters.Value = Reader.ReadUInt16
                Reader.Position = &H14BCF0
                appart = Reader.Position
                value_appart.Value = Reader.ReadInt8
                Reader.Position = &H14BCF1
                mair = Reader.Position
                value_mair.Value = Reader.ReadInt8
                Reader.Position = &H14BCF2
                info = Reader.Position
                value_info.Value = Reader.ReadInt8
                Reader.Position = &H14BCF3
                classem = Reader.Position
                value_classem.Value = Reader.ReadInt8
                Reader.Position = &H14BCF4
                vetem = Reader.Position
                value_vetem.Value = Reader.ReadInt8
                Reader.Position = &H14BCF5
                chap = Reader.Position
                value_chap.Value = Reader.ReadInt8
                Reader.Position = &H14BCF6
                epicer = Reader.Position
                value_epicer.Value = Reader.ReadInt8
                Reader.Position = &H14BCF7
                deco = Reader.Position
                value_deco.Value = Reader.ReadInt8
                Reader.Position = &H14BCF8
                broc = Reader.Position
                value_broc.Value = Reader.ReadInt8
                Reader.Position = &H14BCF9
                magimport = Reader.Position
                value_magimport.Value = Reader.ReadInt8
                Reader.Position = &H14BCFA
                fontai = Reader.Position
                value_font.Value = Reader.ReadInt8
                Reader.Position = &H14BCFB
                mais = Reader.Position
                value_mais.Value = Reader.ReadInt8
                Reader.Position = &H14BCFC
                port = Reader.Position
                value_port.Value = Reader.ReadInt8
                Reader.Position = &H14BCFD
                tervague = Reader.Position
                value_tervague.Value = Reader.ReadInt8
                Reader.Position = &H14BCFE
                conc = Reader.Position
                value_conc.Value = Reader.ReadInt8
                Reader.Position = &H14BCFF
                test = Reader.Position
                value_test.Value = Reader.ReadInt8
                Reader.Position = &H14BD00
                stud = Reader.Position
                value_stud.Value = Reader.ReadInt8
                Reader.Position = &H14BD01
                plage = Reader.Position
                value_plage.Value = Reader.ReadInt8
                Reader.Position = &H14BD02
                parc1 = Reader.Position
                value_parc1.Value = Reader.ReadInt8
                Reader.Position = &H14BD03
                cafe = Reader.Position
                value_cafe.Value = Reader.ReadInt8
                Reader.Position = &H14BD04
                parc = Reader.Position
                value_parc.Value = Reader.ReadInt8
                Reader.Position = &H14BBE8
                eventfountain = Reader.Position
                value_eventfountain.Value = Reader.ReadUInt32
                Reader.Position = &H14BD49
                appartrenov = Reader.Position
                value_appartrenov.Value = Reader.ReadInt8
            End If
            If Filever_text.Text = "KR" Then
                Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
                Reader.Position = &H1EFF68
                money = Reader.Position
                value_money.Value = Reader.ReadUInt32
                Reader.Position = &H1EFF7C
                IslN = Reader.Position
                Text_islandname.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1EFFA6
                Islp = Reader.Position
                Text_pronun_islandname.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1EFF76
                soucis = Reader.Position
                value_problemsolved.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF6E
                vrecu = Reader.Position
                value_travelersreceived.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF70
                weddi = Reader.Position
                value_weddings.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF72
                born = Reader.Position
                value_childrenborn.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF74
                vsent = Reader.Position
                value_travelerssent.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF6C
                stpass = Reader.Position
                value_streetpassencounters.Value = Reader.ReadUInt16
                Reader.Position = &H1EFFD0
                appart = Reader.Position
                value_appart.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD1
                mair = Reader.Position
                value_mair.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD2
                info = Reader.Position
                value_info.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD3
                classem = Reader.Position
                value_classem.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD4
                vetem = Reader.Position
                value_vetem.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD5
                chap = Reader.Position
                value_chap.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD6
                epicer = Reader.Position
                value_epicer.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD7
                deco = Reader.Position
                value_deco.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD8
                broc = Reader.Position
                value_broc.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD9
                magimport = Reader.Position
                value_magimport.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDA
                fontai = Reader.Position
                value_font.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDB
                mais = Reader.Position
                value_mais.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDC
                port = Reader.Position
                value_port.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDD
                tervague = Reader.Position
                value_tervague.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDE
                conc = Reader.Position
                value_conc.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDF
                test = Reader.Position
                value_test.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE0
                stud = Reader.Position
                value_stud.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE1
                plage = Reader.Position
                value_plage.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE2
                parc1 = Reader.Position
                value_parc1.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE3
                cafe = Reader.Position
                value_cafe.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE4
                parc = Reader.Position
                value_parc.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE5
                tour = Reader.Position
                value_tour.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE6
                part = Reader.Position
                value_part.Value = Reader.ReadInt8
                Reader.Position = &H1EFEA8
                eventfountain = Reader.Position
                value_eventfountain.Value = Reader.ReadUInt32
                Reader.Position = &H1F0029
                appartrenov = Reader.Position
                value_appartrenov.Value = Reader.ReadInt8
            End If
            Text_menu_open.Visible = False
            Text_menu_save.Visible = True
            Filever_text.Enabled = False
            Select_language.Enabled = False
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to read savedataArc.txt, make sure you choose right save file version and to have opened a file, or report this issue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'ouverture de savedataArc.txt a échoué, soyez sûr d'avoir choisi la bonne version de sauvegarde et d'avoir ouvert un fichier, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
            Text_menu_open.Visible = True
            Text_menu_save.Visible = False
            Filever_text.Enabled = True
            Select_language.Enabled = True
        End Try
    End Sub

    Public Sub writesavedataArc()
        Try
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            Writer.Position = money
            Writer.WriteUInt32(value_money.Value)
            For i As Integer = 0 To 19
                Writer.Position = IslN + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = IslN
            Writer.WriteUnicodeString(Text_islandname.Text)
            Writer.Position = soucis
            Writer.WriteUInt16(value_problemsolved.Value)
            Writer.Position = vrecu
            Writer.WriteUInt16(value_travelersreceived.Value)
            Writer.Position = weddi
            Writer.WriteUInt16(value_weddings.Value)
            Writer.Position = born
            Writer.WriteUInt16(value_childrenborn.Value)
            Writer.Position = vsent
            Writer.WriteUInt16(value_travelerssent.Value)
            Writer.Position = stpass
            Writer.WriteUInt16(value_streetpassencounters.Value)
            Writer.Position = appart
            Writer.WriteInt8(value_appart.Value)
            Writer.Position = mair
            Writer.WriteInt8(value_mair.Value)
            Writer.Position = info
            Writer.WriteInt8(value_info.Value)
            Writer.Position = classem
            Writer.WriteInt8(value_classem.Value)
            Writer.Position = vetem
            Writer.WriteInt8(value_vetem.Value)
            Writer.Position = chap
            Writer.WriteInt8(value_chap.Value)
            Writer.Position = epicer
            Writer.WriteInt8(value_epicer.Value)
            Writer.Position = deco
            Writer.WriteInt8(value_deco.Value)
            Writer.Position = broc
            Writer.WriteInt8(value_broc.Value)
            Writer.Position = magimport
            Writer.WriteInt8(value_magimport.Value)
            Writer.Position = fontai
            Writer.WriteInt8(value_font.Value)
            Writer.Position = mais
            Writer.WriteInt8(value_mais.Value)
            Writer.Position = port
            Writer.WriteInt8(value_port.Value)
            Writer.Position = tervague
            Writer.WriteInt8(value_tervague.Value)
            Writer.Position = conc
            Writer.WriteInt8(value_conc.Value)
            Writer.Position = test
            Writer.WriteInt8(value_test.Value)
            Writer.Position = stud
            Writer.WriteInt8(value_stud.Value)
            Writer.Position = plage
            Writer.WriteInt8(value_plage.Value)
            Writer.Position = parc1
            Writer.WriteInt8(value_parc1.Value)
            Writer.Position = cafe
            Writer.WriteInt8(value_cafe.Value)
            Writer.Position = parc
            Writer.WriteInt8(value_parc.Value)
            Writer.Position = eventfountain
            Writer.WriteUInt32(value_eventfountain.Value)
            Writer.Position = appartrenov
            Writer.WriteInt8(value_appartrenov.Value)
            If Filever_text.Text = "EU" Then
                For i As Integer = 0 To 19
                    Writer.Position = Islp + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Islp
                Writer.WriteUnicodeString(Text_pronun_islandname.Text)
                Writer.Position = tour
                Writer.WriteInt8(value_tour.Value)
                Writer.Position = part
                Writer.WriteInt8(value_part.Value)
                If Check_timetravel.Checked = True Then
                    Writer.Position = &H1E4C70
                    Writer.WriteInt8(0)
                End If
                If Check_resetstpspp.Checked = True Then
                    Writer.Position = &H1E4C71
                    Writer.WriteInt8(0)
                End If
            End If
            If Filever_text.Text = "US" Then
                For i As Integer = 0 To 19
                    Writer.Position = Islp + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Islp
                Writer.WriteUnicodeString(Text_pronun_islandname.Text)
                Writer.Position = tour
                Writer.WriteInt8(value_tour.Value)
                Writer.Position = part
                Writer.WriteInt8(value_part.Value)
                If Check_timetravel.Checked = True Then
                    Writer.Position = &H1E4C70
                    Writer.WriteInt8(0)
                End If
                If Check_resetstpspp.Checked = True Then
                    Writer.Position = &H1E4C71
                    Writer.WriteInt8(0)
                End If
            End If
            If Filever_text.Text = "JP" Then
                If Check_timetravel.Checked = True Then
                    Writer.Position = &H14BD40
                    Writer.WriteInt8(0)
                End If
                If Check_resetstpspp.Checked = True Then
                    Writer.Position = &H14BD41
                    Writer.WriteInt8(0)
                End If
            End If
            If Filever_text.Text = "KR" Then
                For i As Integer = 0 To 19
                    Writer.Position = Islp + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Islp
                Writer.WriteUnicodeString(Text_pronun_islandname.Text)
                Writer.Position = tour
                Writer.WriteInt8(value_tour.Value)
                Writer.Position = part
                Writer.WriteInt8(value_part.Value)
                If Check_timetravel.Checked = True Then
                    Writer.Position = &H1F0020
                    Writer.WriteInt8(0)
                End If
                If Check_resetstpspp.Checked = True Then
                    Writer.Position = &H1F0021
                    Writer.WriteInt8(0)
                End If
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Editing in savedataArc.txt has been saved"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "Les modifications dans savedataArc.txt ont été enregistrées"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to write savedataArc.txt, make sure you choose right save file version and to have opened a file, or report this issue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'écriture de savedataArc.txt a échoué, soyez sûr d'avoir choisi la bonne version de sauvegarde et d'avoir ouvert un fichier, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub readMii()
        Try
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "KR" Then
                Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
                Reader.Position = &H1CD0 + Accessmii
                Mii1P = Reader.Position
                Text_firstname.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CF0 + Accessmii
                Mii1N = Reader.Position
                Text_lastname.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C8A + Accessmii
                Mii1S = Reader.Position
                Text_nickname.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1F23 + Accessmii
                Mii1L = Reader.Position
                valu_level.Value = Reader.ReadByte
                Reader.Position = &H1E92 + Accessmii
                Mii1PP = Reader.Position
                Text_pronun_firstname.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1ED4 + Accessmii
                Mii1NP = Reader.Position
                Text_pronun_lastname.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1E50 + Accessmii
                Mii1SP = Reader.Position
                Text_pronun_nickname.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1F2D + Accessmii
                Mii1R = Reader.Position
                valu_relationyou.Value = Reader.ReadByte
                Reader.Position = &H1CB8 + Accessmii
                Mii1C = Reader.Position
                Text_creator.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1D20 + Accessmii
                bull1 = Reader.Position
                Text_cathph_01.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DC4 + Accessmii
                bull2 = Reader.Position
                Text_cathph_02.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DE6 + Accessmii
                bull3 = Reader.Position
                Text_cathph_03.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E08 + Accessmii
                bull4 = Reader.Position
                Text_cathph_04.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E2A + Accessmii
                bull5 = Reader.Position
                Text_cathph_05.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2258 + Accessmii
                objet1 = Reader.Position
                valu_itemmii_1.Value = Reader.ReadUInt16
                Reader.Position = &H225A + Accessmii
                objet2 = Reader.Position
                valu_itemmii_2.Value = Reader.ReadUInt16
                Reader.Position = &H225C + Accessmii
                objet3 = Reader.Position
                valu_itemmii_3.Value = Reader.ReadUInt16
                Reader.Position = &H225E + Accessmii
                objet4 = Reader.Position
                valu_itemmii_4.Value = Reader.ReadUInt16
                Reader.Position = &H2260 + Accessmii
                objet5 = Reader.Position
                valu_itemmii_5.Value = Reader.ReadUInt16
                Reader.Position = &H2262 + Accessmii
                objet6 = Reader.Position
                valu_itemmii_6.Value = Reader.ReadUInt16
                Reader.Position = &H2264 + Accessmii
                objet7 = Reader.Position
                valu_itemmii_7.Value = Reader.ReadUInt16
                Reader.Position = &H2266 + Accessmii
                objet8 = Reader.Position
                valu_itemmii_8.Value = Reader.ReadUInt16
                Reader.Position = &H1F22 + Accessmii
                exp = Reader.Position
                valu_experience.Value = Reader.ReadByte
                Reader.Position = &H1F28 + Accessmii
                econom = Reader.Position
                valu_economy.Value = Reader.ReadInt32
                Reader.Position = &H2272 + Accessmii
                eat = Reader.Position
                valu_chkfullness.Value = Reader.ReadByte
                Reader.Position = &H2293 + Accessmii
                fullness = Reader.Position
                valu_fullness.Value = Reader.ReadInt8
                Reader.Position = &H1F59 + Accessmii
                interieur = Reader.Position 'tout intérieur inventaire
                Reader.Position = &H1F64 + Accessmii
                interieur1 = Reader.Position 'tout intérieur inventaire
                Reader.Position = &H1F68 + Accessmii
                Sfoods = Reader.Position 'tout spécial nourriture inventaire
                Reader.Position = &H1F50 + Accessmii
                objdiv = Reader.Position 'tout objet divers inventaire
                Reader.Position = &H2298 + Accessmii
                alltime = Reader.Position
                valu_allfav_1.Value = Reader.ReadUInt16
                Reader.Position = &H229C + Accessmii
                alltime2 = Reader.Position
                valu_allfav_2.Value = Reader.ReadUInt16
                Reader.Position = &H22A0 + Accessmii
                fav = Reader.Position
                valu_fav_1.Value = Reader.ReadUInt16
                Reader.Position = &H22A2 + Accessmii
                fav2 = Reader.Position
                valu_fav_2.Value = Reader.ReadUInt16
                Reader.Position = &H22A4 + Accessmii
                fav3 = Reader.Position
                valu_fav_3.Value = Reader.ReadUInt16
                Reader.Position = &H229E + Accessmii
                worst = Reader.Position
                valu_worst_1.Value = Reader.ReadUInt16
                Reader.Position = &H229A + Accessmii
                worst2 = Reader.Position
                valu_worst_2.Value = Reader.ReadUInt16
                Reader.Position = &H1C71 + Accessmii
                copy = Reader.Position
                valu_copying.Value = Reader.ReadInt8
                Reader.Position = &H1CA0 + Accessmii
                sharing = Reader.Position
                valu_sharing.Value = Reader.ReadUInt16
                Reader.Position = &H1C89 + Accessmii
                couleur = Reader.Position
                valu_favcolor.Value = Reader.ReadInt8
                Reader.Position = &H22AE + Accessmii
                grow = Reader.Position
                valu_growkid.Value = Reader.ReadInt8
                Reader.Position = &H22A8 + Accessmii
                appartement = Reader.Position
                valu_miiapart.Value = Reader.ReadInt8
                Reader.Position = &H22B0 + Accessmii
                Splurge = Reader.Position
                valu_ranking_splurge.Value = Reader.ReadUInt32
                Reader.Position = &H1F24 + Accessmii
                Pampered = Reader.Position
                valu_ranking_pampered.Value = Reader.ReadUInt32
                Reader.Position = &H299F0 + Accessfriends 'Mii friendlist
                Miifriendr = Reader.Position
                Reader.Position = &H1D13 + Accessmii
                MiiHC = Reader.Position
                valu_haircolor.Value = Reader.ReadByte
                Reader.Position = &H22A9 + Accessmii
                House = Reader.Position
                valu_miihouse.Value = Reader.ReadByte
                Reader.Position = &H22A6 + Accessmii
                Miimusic = Reader.Position
                valu_allmusic.Value = Reader.ReadByte
                Reader.Position = &H29AB8 + Accessfriends 'Mii friendlist
                Miiinteraction = Reader.Position
                Text_interaction.Text = Reader.ReadHexString(16)
                Reader.Position = &H29AC4 + Accessfriends  'Mii friendlist
                Miitarget1 = Reader.Position
                valu_target1.Value = Reader.ReadUInt16
                Reader.Position = &H29AC6 + Accessfriends  'Mii friendlist
                Miitarget2 = Reader.Position
                valu_target2.Value = Reader.ReadUInt16
                Reader.Position = &H29AE6 + Accessfriends  'Mii friendlist
                Mhouse = Reader.Position
                valu_miiMhouse.Value = Reader.ReadByte
                Reader.Position = &H1F2C + Accessmii
                Emotions = Reader.Position
                valu_emotions.Value = Reader.ReadByte
            End If

            If Filever_text.Text = "JP" Then
                Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
                Reader.Position = &H1CA0 + Accessmii
                Mii1P = Reader.Position
                Text_firstname.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + Accessmii
                Mii1N = Reader.Position
                Text_lastname.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + Accessmii
                Mii1S = Reader.Position
                Text_nickname.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1E23 + Accessmii
                Mii1L = Reader.Position
                valu_level.Value = Reader.ReadByte
                Reader.Position = &H1E2D + Accessmii
                Mii1R = Reader.Position
                valu_relationyou.Value = Reader.ReadByte
                Reader.Position = &H1C88 + Accessmii
                Mii1C = Reader.Position
                Text_creator.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1CE4 + Accessmii
                bullj1 = Reader.Position
                Text_cathph_J1.Text = Reader.ReadUnicodeString(4)
                Reader.Position = &H1CF0 + Accessmii
                bullj2 = Reader.Position
                Text_cathph_J2.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1D94 + Accessmii
                bull2 = Reader.Position
                Text_cathph_02.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DB6 + Accessmii
                bull3 = Reader.Position
                Text_cathph_03.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DD8 + Accessmii
                bull4 = Reader.Position
                Text_cathph_04.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DFA + Accessmii
                bull5 = Reader.Position
                Text_cathph_05.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2158 + Accessmii
                objet1 = Reader.Position
                valu_itemmii_1.Value = Reader.ReadUInt16
                Reader.Position = &H215A + Accessmii
                objet2 = Reader.Position
                valu_itemmii_2.Value = Reader.ReadUInt16
                Reader.Position = &H215C + Accessmii
                objet3 = Reader.Position
                valu_itemmii_3.Value = Reader.ReadUInt16
                Reader.Position = &H215E + Accessmii
                objet4 = Reader.Position
                valu_itemmii_4.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + Accessmii
                objet5 = Reader.Position
                valu_itemmii_5.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + Accessmii
                objet6 = Reader.Position
                valu_itemmii_6.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + Accessmii
                objet7 = Reader.Position
                valu_itemmii_7.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + Accessmii
                objet8 = Reader.Position
                valu_itemmii_8.Value = Reader.ReadUInt16
                Reader.Position = &H1E22 + Accessmii
                exp = Reader.Position
                valu_experience.Value = Reader.ReadByte
                Reader.Position = &H1E28 + Accessmii
                econom = Reader.Position
                valu_economy.Value = Reader.ReadInt32
                Reader.Position = &H2172 + Accessmii
                eat = Reader.Position
                valu_chkfullness.Value = Reader.ReadByte
                Reader.Position = &H2193 + Accessmii
                fullness = Reader.Position
                valu_fullness.Value = Reader.ReadInt8
                Reader.Position = &H1E59 + Accessmii
                interieur = Reader.Position 'tout intérieur inventaire
                Reader.Position = &H1E64 + Accessmii
                interieur1 = Reader.Position 'tout intérieur inventaire
                Reader.Position = &H1E68 + Accessmii
                Sfoods = Reader.Position 'tout spécial nourriture inventaire
                Reader.Position = &H1E50 + Accessmii
                objdiv = Reader.Position 'tout objet divers inventaire
                Reader.Position = &H2198 + Accessmii
                alltime = Reader.Position
                valu_allfav_1.Value = Reader.ReadUInt16
                Reader.Position = &H219C + Accessmii
                alltime2 = Reader.Position
                valu_allfav_2.Value = Reader.ReadUInt16
                Reader.Position = &H21A0 + Accessmii
                fav = Reader.Position
                valu_fav_1.Value = Reader.ReadUInt16
                Reader.Position = &H21A2 + Accessmii
                fav2 = Reader.Position
                valu_fav_2.Value = Reader.ReadUInt16
                Reader.Position = &H21A4 + Accessmii
                fav3 = Reader.Position
                valu_fav_3.Value = Reader.ReadUInt16
                Reader.Position = &H219E + Accessmii
                worst = Reader.Position
                valu_worst_1.Value = Reader.ReadUInt16
                Reader.Position = &H219A + Accessmii
                worst2 = Reader.Position
                valu_worst_2.Value = Reader.ReadUInt16
                Reader.Position = &H1C41 + Accessmii
                copy = Reader.Position
                valu_copying.Value = Reader.ReadInt8
                Reader.Position = &H1C70 + Accessmii
                sharing = Reader.Position
                valu_sharing.Value = Reader.ReadUInt16
                Reader.Position = &H1C59 + Accessmii
                couleur = Reader.Position
                valu_favcolor.Value = Reader.ReadInt8
                Reader.Position = &H21AE + Accessmii
                grow = Reader.Position
                valu_growkid.Value = Reader.ReadInt8
                Reader.Position = &H21A8 + Accessmii
                appartement = Reader.Position
                valu_miiapart.Value = Reader.ReadInt8
                Reader.Position = &H21B0 + Accessmii
                Splurge = Reader.Position
                valu_ranking_splurge.Value = Reader.ReadUInt32
                Reader.Position = &H1E24 + Accessmii
                Pampered = Reader.Position
                valu_ranking_pampered.Value = Reader.ReadUInt32
                Reader.Position = &H24880 + Accessfriends 'Mii friendlist
                Miifriendr = Reader.Position
                Reader.Position = &H1CE3 + Accessmii
                MiiHC = Reader.Position
                valu_haircolor.Value = Reader.ReadByte
                Reader.Position = &H21A9 + Accessmii
                House = Reader.Position
                valu_miihouse.Value = Reader.ReadByte
                Reader.Position = &H21A6 + Accessmii
                Miimusic = Reader.Position
                valu_allmusic.Value = Reader.ReadByte
                Reader.Position = &H24948 + Accessfriends 'Mii friendlist
                Miiinteraction = Reader.Position
                Text_interaction.Text = Reader.ReadHexString(16)
                Reader.Position = &H24954 + Accessfriends  'Mii friendlist
                Miitarget1 = Reader.Position
                valu_target1.Value = Reader.ReadUInt16
                Reader.Position = &H24956 + Accessfriends  'Mii friendlist
                Miitarget2 = Reader.Position
                valu_target2.Value = Reader.ReadUInt16
                Reader.Position = &H24976 + Accessfriends  'Mii friendlist
                Mhouse = Reader.Position
                valu_miiMhouse.Value = Reader.ReadByte
                Reader.Position = &H1E2C + Accessmii
                Emotions = Reader.Position
                valu_emotions.Value = Reader.ReadByte
            End If
            Select_allfriends.Enabled = True
            Text_save_mii.Enabled = True
            Select_allfriends.SelectedItem = Select_allfriends.Items.Item(1)
            readfriendlist()
            Select_allfriends.SelectedItem = Select_allfriends.Items.Item(0)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to read informations of this Mii, make sure you have opened a file, or report this issue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "La lecture des informations de ce Mii a échoué, soyez sûr d'avoir ouvert un fichier, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
            Select_mii.SelectedItem = Nothing
            Select_allfriends.Enabled = False
            Text_save_mii.Enabled = False
        End Try
    End Sub

    Public Sub writeMii()
        Try
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            For i As Integer = 0 To 29
                Writer.Position = Mii1P + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Mii1P
            Writer.WriteUnicodeString(Text_firstname.Text)
            For i As Integer = 0 To 29
                Writer.Position = Mii1N + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Mii1N
            Writer.WriteUnicodeString(Text_lastname.Text)
            Writer.Position = objet1
            Writer.WriteUInt16(valu_itemmii_1.Value)
            Writer.Position = objet2
            Writer.WriteUInt16(valu_itemmii_2.Value)
            Writer.Position = objet3
            Writer.WriteUInt16(valu_itemmii_3.Value)
            Writer.Position = objet4
            Writer.WriteUInt16(valu_itemmii_4.Value)
            Writer.Position = objet5
            Writer.WriteUInt16(valu_itemmii_5.Value)
            Writer.Position = objet6
            Writer.WriteUInt16(valu_itemmii_6.Value)
            Writer.Position = objet7
            Writer.WriteUInt16(valu_itemmii_7.Value)
            Writer.Position = objet8
            Writer.WriteUInt16(valu_itemmii_8.Value)
            Writer.Position = alltime
            Writer.WriteUInt16(valu_allfav_1.Value)
            Writer.Position = alltime2
            Writer.WriteUInt16(valu_allfav_2.Value)
            Writer.Position = fav
            Writer.WriteUInt16(valu_fav_1.Value)
            Writer.Position = fav2
            Writer.WriteUInt16(valu_fav_2.Value)
            Writer.Position = fav3
            Writer.WriteUInt16(valu_fav_3.Value)
            Writer.Position = worst
            Writer.WriteUInt16(valu_worst_1.Value)
            Writer.Position = worst2
            Writer.WriteUInt16(valu_worst_2.Value)
            For i As Integer = 0 To 31
                Writer.Position = bull2 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull2
            Writer.WriteUnicodeString(Text_cathph_02.Text)
            For i As Integer = 0 To 31
                Writer.Position = bull3 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull3
            Writer.WriteUnicodeString(Text_cathph_03.Text)
            For i As Integer = 0 To 31
                Writer.Position = bull4 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull4
            Writer.WriteUnicodeString(Text_cathph_04.Text)
            For i As Integer = 0 To 31
                Writer.Position = bull5 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull5
            Writer.WriteUnicodeString(Text_cathph_05.Text)
            Writer.Position = econom
            Writer.WriteUInt32(valu_economy.Value)
            Writer.Position = Miiinteraction
            Writer.WriteHexString(Text_interaction.Text)
            Writer.Position = Miitarget1
            Writer.WriteUInt16(valu_target1.Value)
            Writer.Position = Miitarget2
            Writer.WriteUInt16(valu_target2.Value)
            Writer.Position = Splurge
            Writer.WriteUInt32(valu_ranking_splurge.Value)
            Writer.Position = Pampered
            Writer.WriteUInt32(valu_ranking_pampered.Value)
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                For i As Integer = 0 To 59
                    Writer.Position = Mii1PP + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Mii1PP
                Writer.WriteUnicodeString(Text_pronun_firstname.Text)
                For i As Integer = 0 To 59
                    Writer.Position = Mii1NP + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Mii1NP
                Writer.WriteUnicodeString(Text_pronun_lastname.Text)
                For i As Integer = 0 To 31
                    Writer.Position = bull1 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = bull1
                Writer.WriteUnicodeString(Text_cathph_01.Text)
            End If
            If Filever_text.Text = "JP" Then
                For i As Integer = 0 To 3
                    Writer.Position = bullj1 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = bullj1
                Writer.WriteUnicodeString(Text_cathph_J1.Text)
                For i As Integer = 0 To 31
                    Writer.Position = bullj2 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = bullj2
                Writer.WriteUnicodeString(Text_cathph_J2.Text)
            End If
            If Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(1) Then
                Writer.Position = objdiv
                Writer.WriteUInt24(262143)
            ElseIf Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(2) Then
                Writer.Position = objdiv
                Writer.WriteUInt24(0)
            End If
            If Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(1) Then
                For i As Integer = 0 To 10
                    Writer.Position = interieur + i
                    Writer.WriteUInt16(65535)
                Next
                Writer.Position = interieur1
                Writer.WriteUInt16(16383)
            ElseIf Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(2) Then
                For i As Integer = 0 To 11
                    Writer.Position = interieur + i
                    Writer.WriteUInt16(0)
                Next
            End If
            If Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(1) Then
                For i As Integer = 0 To 4
                    Writer.Position = Sfoods + i
                    Writer.WriteUInt16(65535)
                Next
            ElseIf Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(2) Then
                For i As Integer = 0 To 4
                    Writer.Position = Sfoods + i
                    Writer.WriteUInt16(0)
                Next
            End If
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            fs.Position = Mii1L
            fs.WriteByte(valu_level.Value)
            fs.Position = Mii1R
            fs.WriteByte(valu_relationyou.Value)
            fs.Position = exp
            fs.WriteByte(valu_experience.Value)
            fs.Position = eat
            fs.WriteByte(valu_chkfullness.Value)
            fs.Position = fullness
            fs.WriteByte(valu_fullness.Value)
            fs.Position = MiiHC
            fs.WriteByte(valu_haircolor.Value)
            fs.Position = grow
            fs.WriteByte(valu_growkid.Value)
            fs.Position = House
            fs.WriteByte(valu_miihouse.Value)
            fs.Position = Mhouse
            fs.WriteByte(valu_miiMhouse.Value)
            fs.Position = Miimusic
            fs.WriteByte(valu_allmusic.Value)
            fs.Position = Emotions
            fs.WriteByte(valu_emotions.Value)
            Patchfrienlist()
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Editing of " & Text_nickname.Text & " has been saved"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "Les modifications de " & Text_nickname.Text & " ont été enregistrées"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to save changes on this Mii, make sure you have opened a save file, or report this issue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'enregistrement des changements sur ce Mii a échoué, soyez sûr d'avoir ouvert un fichier de sauvegarde, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub readfriendlist()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = AccessMiilist
            Text_friendmii_1.Text = Reader.ReadUnicodeString(10)
            Reader.Position = Accessfriendlist
            valu_friend_rela_1.Value = Reader.ReadByte
            Reader.Position = Accessrelalist
            valu_selfriend_rela_1.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + &H660
                Text_friendmii_2.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + &H590
                Text_friendmii_2.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + &H1
            valu_friend_rela_2.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + &H1
            valu_selfriend_rela_2.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 2)
                Text_friendmii_3.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 2)
                Text_friendmii_3.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 2)
            valu_friend_rela_3.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 2)
            valu_selfriend_rela_3.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 3)
                Text_friendmii_4.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 3)
                Text_friendmii_4.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 3)
            valu_friend_rela_4.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 3)
            valu_selfriend_rela_4.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 4)
                Text_friendmii_5.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 4)
                Text_friendmii_5.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 4)
            valu_friend_rela_5.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 4)
            valu_selfriend_rela_5.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 5)
                Text_friendmii_6.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 5)
                Text_friendmii_6.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 5)
            valu_friend_rela_6.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 5)
            valu_selfriend_rela_6.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 6)
                Text_friendmii_7.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 6)
                Text_friendmii_7.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 6)
            valu_friend_rela_7.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 6)
            valu_selfriend_rela_7.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 7)
                Text_friendmii_8.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 7)
                Text_friendmii_8.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 7)
            valu_friend_rela_8.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 7)
            valu_selfriend_rela_8.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 8)
                Text_friendmii_9.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 8)
                Text_friendmii_9.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 8)
            valu_friend_rela_9.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 8)
            valu_selfriend_rela_9.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 9)
                Text_friendmii_10.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 9)
                Text_friendmii_10.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 9)
            valu_friend_rela_10.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 9)
            valu_selfriend_rela_10.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 10)
                Text_friendmii_11.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 10)
                Text_friendmii_11.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 10)
            valu_friend_rela_11.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 10)
            valu_selfriend_rela_11.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 11)
                Text_friendmii_12.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 11)
                Text_friendmii_12.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 11)
            valu_friend_rela_12.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 11)
            valu_selfriend_rela_12.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 12)
                Text_friendmii_13.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 12)
                Text_friendmii_13.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 12)
            valu_friend_rela_13.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 12)
            valu_selfriend_rela_13.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 13)
                Text_friendmii_14.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 13)
                Text_friendmii_14.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 13)
            valu_friend_rela_14.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 13)
            valu_selfriend_rela_14.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 14)
                Text_friendmii_15.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 14)
                Text_friendmii_15.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 14)
            valu_friend_rela_15.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 14)
            valu_selfriend_rela_15.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 15)
                Text_friendmii_16.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 15)
                Text_friendmii_16.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 15)
            valu_friend_rela_16.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 15)
            valu_selfriend_rela_16.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 16)
                Text_friendmii_17.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 16)
                Text_friendmii_17.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 16)
            valu_friend_rela_17.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 16)
            valu_selfriend_rela_17.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 17)
                Text_friendmii_18.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 17)
                Text_friendmii_18.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 17)
            valu_friend_rela_18.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 17)
            valu_selfriend_rela_18.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 18)
                Text_friendmii_19.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 18)
                Text_friendmii_19.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 18)
            valu_friend_rela_19.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 18)
            valu_selfriend_rela_19.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 19)
                Text_friendmii_20.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 19)
                Text_friendmii_20.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 19)
            valu_friend_rela_20.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 19)
            valu_selfriend_rela_20.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 20)
                Text_friendmii_21.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 20)
                Text_friendmii_21.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 20)
            valu_friend_rela_21.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 20)
            valu_selfriend_rela_21.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 21)
                Text_friendmii_22.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 21)
                Text_friendmii_22.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 21)
            valu_friend_rela_22.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 21)
            valu_selfriend_rela_22.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 22)
                Text_friendmii_23.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 22)
                Text_friendmii_23.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 22)
            valu_friend_rela_23.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 22)
            valu_selfriend_rela_23.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 23)
                Text_friendmii_24.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 23)
                Text_friendmii_24.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 23)
            valu_friend_rela_24.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 23)
            valu_selfriend_rela_24.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 24)
                Text_friendmii_25.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 24)
                Text_friendmii_25.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 24)
            valu_friend_rela_25.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 24)
            valu_selfriend_rela_25.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 25)
                Text_friendmii_26.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 25)
                Text_friendmii_26.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 25)
            valu_friend_rela_26.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 25)
            valu_selfriend_rela_26.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 26)
                Text_friendmii_27.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 26)
                Text_friendmii_27.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 26)
            valu_friend_rela_27.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 26)
            valu_selfriend_rela_27.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 27)
                Text_friendmii_28.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 27)
                Text_friendmii_28.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 27)
            valu_friend_rela_28.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 27)
            valu_selfriend_rela_28.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 28)
                Text_friendmii_29.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 28)
                Text_friendmii_29.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 28)
            valu_friend_rela_29.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 28)
            valu_selfriend_rela_29.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = AccessMiilist + (&H660 * 29)
                Text_friendmii_30.Text = Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "JP" Then
                Reader.Position = AccessMiilist + (&H590 * 29)
                Text_friendmii_30.Text = Reader.ReadUnicodeString(10)
            End If
            Reader.Position = Accessfriendlist + (&H1 * 29)
            valu_friend_rela_30.Value = Reader.ReadByte
            Reader.Position = Accessrelalist + (&H1 * 29)
            valu_selfriend_rela_30.Value = Reader.ReadByte
        Catch ex As Exception
        End Try
    End Sub

    Public Sub writefriendlist()
        Try
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            fs.Position = Accessfriendlist
            fs.WriteByte(valu_friend_rela_1.Value)
            fs.Position = Accessrelalist
            fs.WriteByte(valu_selfriend_rela_1.Value)
            fs.Position = Accessfriendlist + &H1
            fs.WriteByte(valu_friend_rela_2.Value)
            fs.Position = Accessrelalist + &H1
            fs.WriteByte(valu_selfriend_rela_2.Value)
            fs.Position = Accessfriendlist + (&H1 * 2)
            fs.WriteByte(valu_friend_rela_3.Value)
            fs.Position = Accessrelalist + (&H1 * 2)
            fs.WriteByte(valu_selfriend_rela_3.Value)
            fs.Position = Accessfriendlist + (&H1 * 3)
            fs.WriteByte(valu_friend_rela_4.Value)
            fs.Position = Accessrelalist + (&H1 * 3)
            fs.WriteByte(valu_selfriend_rela_4.Value)
            fs.Position = Accessfriendlist + (&H1 * 4)
            fs.WriteByte(valu_friend_rela_5.Value)
            fs.Position = Accessrelalist + (&H1 * 4)
            fs.WriteByte(valu_selfriend_rela_5.Value)
            fs.Position = Accessfriendlist + (&H1 * 5)
            fs.WriteByte(valu_friend_rela_6.Value)
            fs.Position = Accessrelalist + (&H1 * 5)
            fs.WriteByte(valu_selfriend_rela_6.Value)
            fs.Position = Accessfriendlist + (&H1 * 6)
            fs.WriteByte(valu_friend_rela_7.Value)
            fs.Position = Accessrelalist + (&H1 * 6)
            fs.WriteByte(valu_selfriend_rela_7.Value)
            fs.Position = Accessfriendlist + (&H1 * 7)
            fs.WriteByte(valu_friend_rela_8.Value)
            fs.Position = Accessrelalist + (&H1 * 7)
            fs.WriteByte(valu_selfriend_rela_8.Value)
            fs.Position = Accessfriendlist + (&H1 * 8)
            fs.WriteByte(valu_friend_rela_9.Value)
            fs.Position = Accessrelalist + (&H1 * 8)
            fs.WriteByte(valu_selfriend_rela_9.Value)
            fs.Position = Accessfriendlist + (&H1 * 9)
            fs.WriteByte(valu_friend_rela_10.Value)
            fs.Position = Accessrelalist + (&H1 * 9)
            fs.WriteByte(valu_selfriend_rela_10.Value)
            fs.Position = Accessfriendlist + (&H1 * 10)
            fs.WriteByte(valu_friend_rela_11.Value)
            fs.Position = Accessrelalist + (&H1 * 10)
            fs.WriteByte(valu_selfriend_rela_11.Value)
            fs.Position = Accessfriendlist + (&H1 * 11)
            fs.WriteByte(valu_friend_rela_12.Value)
            fs.Position = Accessrelalist + (&H1 * 11)
            fs.WriteByte(valu_selfriend_rela_12.Value)
            fs.Position = Accessfriendlist + (&H1 * 12)
            fs.WriteByte(valu_friend_rela_13.Value)
            fs.Position = Accessrelalist + (&H1 * 12)
            fs.WriteByte(valu_selfriend_rela_13.Value)
            fs.Position = Accessfriendlist + (&H1 * 13)
            fs.WriteByte(valu_friend_rela_14.Value)
            fs.Position = Accessrelalist + (&H1 * 13)
            fs.WriteByte(valu_selfriend_rela_14.Value)
            fs.Position = Accessfriendlist + (&H1 * 14)
            fs.WriteByte(valu_friend_rela_15.Value)
            fs.Position = Accessrelalist + (&H1 * 14)
            fs.WriteByte(valu_selfriend_rela_15.Value)
            fs.Position = Accessfriendlist + (&H1 * 15)
            fs.WriteByte(valu_friend_rela_16.Value)
            fs.Position = Accessrelalist + (&H1 * 15)
            fs.WriteByte(valu_selfriend_rela_16.Value)
            fs.Position = Accessfriendlist + (&H1 * 16)
            fs.WriteByte(valu_friend_rela_17.Value)
            fs.Position = Accessrelalist + (&H1 * 16)
            fs.WriteByte(valu_selfriend_rela_17.Value)
            fs.Position = Accessfriendlist + (&H1 * 17)
            fs.WriteByte(valu_friend_rela_18.Value)
            fs.Position = Accessrelalist + (&H1 * 17)
            fs.WriteByte(valu_selfriend_rela_18.Value)
            fs.Position = Accessfriendlist + (&H1 * 18)
            fs.WriteByte(valu_friend_rela_19.Value)
            fs.Position = Accessrelalist + (&H1 * 18)
            fs.WriteByte(valu_selfriend_rela_19.Value)
            fs.Position = Accessfriendlist + (&H1 * 19)
            fs.WriteByte(valu_friend_rela_20.Value)
            fs.Position = Accessrelalist + (&H1 * 19)
            fs.WriteByte(valu_selfriend_rela_20.Value)
            fs.Position = Accessfriendlist + (&H1 * 20)
            fs.WriteByte(valu_friend_rela_21.Value)
            fs.Position = Accessrelalist + (&H1 * 20)
            fs.WriteByte(valu_selfriend_rela_21.Value)
            fs.Position = Accessfriendlist + (&H1 * 21)
            fs.WriteByte(valu_friend_rela_22.Value)
            fs.Position = Accessrelalist + (&H1 * 21)
            fs.WriteByte(valu_selfriend_rela_22.Value)
            fs.Position = Accessfriendlist + (&H1 * 22)
            fs.WriteByte(valu_friend_rela_23.Value)
            fs.Position = Accessrelalist + (&H1 * 22)
            fs.WriteByte(valu_selfriend_rela_23.Value)
            fs.Position = Accessfriendlist + (&H1 * 23)
            fs.WriteByte(valu_friend_rela_24.Value)
            fs.Position = Accessrelalist + (&H1 * 23)
            fs.WriteByte(valu_selfriend_rela_24.Value)
            fs.Position = Accessfriendlist + (&H1 * 24)
            fs.WriteByte(valu_friend_rela_25.Value)
            fs.Position = Accessrelalist + (&H1 * 24)
            fs.WriteByte(valu_selfriend_rela_25.Value)
            fs.Position = Accessfriendlist + (&H1 * 25)
            fs.WriteByte(valu_friend_rela_26.Value)
            fs.Position = Accessrelalist + (&H1 * 25)
            fs.WriteByte(valu_selfriend_rela_26.Value)
            fs.Position = Accessfriendlist + (&H1 * 26)
            fs.WriteByte(valu_friend_rela_27.Value)
            fs.Position = Accessrelalist + (&H1 * 26)
            fs.WriteByte(valu_selfriend_rela_27.Value)
            fs.Position = Accessfriendlist + (&H1 * 27)
            fs.WriteByte(valu_friend_rela_28.Value)
            fs.Position = Accessrelalist + (&H1 * 27)
            fs.WriteByte(valu_selfriend_rela_28.Value)
            fs.Position = Accessfriendlist + (&H1 * 28)
            fs.WriteByte(valu_friend_rela_29.Value)
            fs.Position = Accessrelalist + (&H1 * 28)
            fs.WriteByte(valu_selfriend_rela_29.Value)
            fs.Position = Accessfriendlist + (&H1 * 29)
            fs.WriteByte(valu_friend_rela_30.Value)
            fs.Position = Accessrelalist + (&H1 * 29)
            fs.WriteByte(valu_selfriend_rela_30.Value)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub hidefriendlist()
        If Setting_hidden.Checked = True Then
            If Select_allfriends.SelectedItem = Select_allfriends.Items.Item(0) Or Select_allfriends.SelectedItem = Select_allfriends.Items.Item(1) Or Select_allfriends.SelectedItem = Select_allfriends.Items.Item(2) Then
                valu_selfriend_rela_11.Visible = True
                valu_selfriend_rela_12.Visible = True
                valu_selfriend_rela_13.Visible = True
                valu_selfriend_rela_14.Visible = True
                valu_selfriend_rela_15.Visible = True
                valu_selfriend_rela_16.Visible = True
                valu_selfriend_rela_17.Visible = True
                valu_selfriend_rela_18.Visible = True
                valu_selfriend_rela_19.Visible = True
                valu_selfriend_rela_20.Visible = True
                valu_selfriend_rela_21.Visible = True
                valu_selfriend_rela_22.Visible = True
                valu_selfriend_rela_23.Visible = True
                valu_selfriend_rela_24.Visible = True
                valu_selfriend_rela_25.Visible = True
                valu_selfriend_rela_26.Visible = True
                valu_selfriend_rela_27.Visible = True
                valu_selfriend_rela_28.Visible = True
                valu_selfriend_rela_29.Visible = True
                valu_selfriend_rela_30.Visible = True
            ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(3) Then
                valu_selfriend_rela_11.Visible = False
                valu_selfriend_rela_12.Visible = False
                valu_selfriend_rela_13.Visible = False
                valu_selfriend_rela_14.Visible = False
                valu_selfriend_rela_15.Visible = False
                valu_selfriend_rela_16.Visible = False
                valu_selfriend_rela_17.Visible = False
                valu_selfriend_rela_18.Visible = False
                valu_selfriend_rela_19.Visible = False
                valu_selfriend_rela_20.Visible = False
                valu_selfriend_rela_21.Visible = False
                valu_selfriend_rela_22.Visible = False
                valu_selfriend_rela_23.Visible = False
                valu_selfriend_rela_24.Visible = False
                valu_selfriend_rela_25.Visible = False
                valu_selfriend_rela_26.Visible = False
                valu_selfriend_rela_27.Visible = False
                valu_selfriend_rela_28.Visible = False
                valu_selfriend_rela_29.Visible = False
                valu_selfriend_rela_30.Visible = False
            End If
        End If
        If Select_allfriends.SelectedItem = Select_allfriends.Items.Item(0) Or Select_allfriends.SelectedItem = Select_allfriends.Items.Item(1) Or Select_allfriends.SelectedItem = Select_allfriends.Items.Item(2) Then
            Text_friendmii_11.Visible = True
            valu_friend_rela_11.Visible = True
            Select_friend_rela_11.Visible = True
            Text_friendmii_12.Visible = True
            valu_friend_rela_12.Visible = True
            Select_friend_rela_12.Visible = True
            Text_friendmii_13.Visible = True
            valu_friend_rela_13.Visible = True
            Select_friend_rela_13.Visible = True
            Text_friendmii_14.Visible = True
            valu_friend_rela_14.Visible = True
            Select_friend_rela_14.Visible = True
            Text_friendmii_15.Visible = True
            valu_friend_rela_15.Visible = True
            Select_friend_rela_15.Visible = True
            Text_friendmii_16.Visible = True
            valu_friend_rela_16.Visible = True
            Select_friend_rela_16.Visible = True
            Text_friendmii_17.Visible = True
            valu_friend_rela_17.Visible = True
            Select_friend_rela_17.Visible = True
            Text_friendmii_18.Visible = True
            valu_friend_rela_18.Visible = True
            Select_friend_rela_18.Visible = True
            Text_friendmii_19.Visible = True
            valu_friend_rela_19.Visible = True
            Select_friend_rela_19.Visible = True
            Text_friendmii_20.Visible = True
            valu_friend_rela_20.Visible = True
            Select_friend_rela_20.Visible = True
            Text_friendmii_21.Visible = True
            valu_friend_rela_21.Visible = True
            Select_friend_rela_21.Visible = True
            Text_friendmii_22.Visible = True
            valu_friend_rela_22.Visible = True
            Select_friend_rela_22.Visible = True
            Text_friendmii_23.Visible = True
            valu_friend_rela_23.Visible = True
            Select_friend_rela_23.Visible = True
            Text_friendmii_24.Visible = True
            valu_friend_rela_24.Visible = True
            Select_friend_rela_24.Visible = True
            Text_friendmii_25.Visible = True
            valu_friend_rela_25.Visible = True
            Select_friend_rela_25.Visible = True
            Text_friendmii_26.Visible = True
            valu_friend_rela_26.Visible = True
            Select_friend_rela_26.Visible = True
            Text_friendmii_27.Visible = True
            valu_friend_rela_27.Visible = True
            Select_friend_rela_27.Visible = True
            Text_friendmii_28.Visible = True
            valu_friend_rela_28.Visible = True
            Select_friend_rela_28.Visible = True
            Text_friendmii_29.Visible = True
            valu_friend_rela_29.Visible = True
            Select_friend_rela_29.Visible = True
            Text_friendmii_30.Visible = True
            valu_friend_rela_30.Visible = True
            Select_friend_rela_30.Visible = True
        ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(3) Then
            Text_friendmii_11.Visible = False
            valu_friend_rela_11.Visible = False
            Select_friend_rela_11.Visible = False
            Text_friendmii_12.Visible = False
            valu_friend_rela_12.Visible = False
            Select_friend_rela_12.Visible = False
            Text_friendmii_13.Visible = False
            valu_friend_rela_13.Visible = False
            Select_friend_rela_13.Visible = False
            Text_friendmii_14.Visible = False
            valu_friend_rela_14.Visible = False
            Select_friend_rela_14.Visible = False
            Text_friendmii_15.Visible = False
            valu_friend_rela_15.Visible = False
            Select_friend_rela_15.Visible = False
            Text_friendmii_16.Visible = False
            valu_friend_rela_16.Visible = False
            Select_friend_rela_16.Visible = False
            Text_friendmii_17.Visible = False
            valu_friend_rela_17.Visible = False
            Select_friend_rela_17.Visible = False
            Text_friendmii_18.Visible = False
            valu_friend_rela_18.Visible = False
            Select_friend_rela_18.Visible = False
            Text_friendmii_19.Visible = False
            valu_friend_rela_19.Visible = False
            Select_friend_rela_19.Visible = False
            Text_friendmii_20.Visible = False
            valu_friend_rela_20.Visible = False
            Select_friend_rela_20.Visible = False
            Text_friendmii_21.Visible = False
            valu_friend_rela_21.Visible = False
            Select_friend_rela_21.Visible = False
            Text_friendmii_22.Visible = False
            valu_friend_rela_22.Visible = False
            Select_friend_rela_22.Visible = False
            Text_friendmii_23.Visible = False
            valu_friend_rela_23.Visible = False
            Select_friend_rela_23.Visible = False
            Text_friendmii_24.Visible = False
            valu_friend_rela_24.Visible = False
            Select_friend_rela_24.Visible = False
            Text_friendmii_25.Visible = False
            valu_friend_rela_25.Visible = False
            Select_friend_rela_25.Visible = False
            Text_friendmii_26.Visible = False
            valu_friend_rela_26.Visible = False
            Select_friend_rela_26.Visible = False
            Text_friendmii_27.Visible = False
            valu_friend_rela_27.Visible = False
            Select_friend_rela_27.Visible = False
            Text_friendmii_28.Visible = False
            valu_friend_rela_28.Visible = False
            Select_friend_rela_28.Visible = False
            Text_friendmii_29.Visible = False
            valu_friend_rela_29.Visible = False
            Select_friend_rela_29.Visible = False
            Text_friendmii_30.Visible = False
            valu_friend_rela_30.Visible = False
            Select_friend_rela_30.Visible = False
        End If
    End Sub

    Public Sub Patchfrienlist()
        Try
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "KR" Then
                If Select_allfriends.SelectedItem = Select_allfriends.Items.Item(0) Then
                    fs.Position = &H29A54 + Patchmii
                    fs.WriteByte(valu_selfriend_rela_1.Value)
                    fs.Position = &H29A54 + &H100 + Patchmii
                    fs.WriteByte(valu_selfriend_rela_2.Value)
                    fs.Position = &H29A54 + (&H100 * 2) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_3.Value)
                    fs.Position = &H29A54 + (&H100 * 3) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_4.Value)
                    fs.Position = &H29A54 + (&H100 * 4) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_5.Value)
                    fs.Position = &H29A54 + (&H100 * 5) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_6.Value)
                    fs.Position = &H29A54 + (&H100 * 6) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_7.Value)
                    fs.Position = &H29A54 + (&H100 * 7) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_8.Value)
                    fs.Position = &H29A54 + (&H100 * 8) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_9.Value)
                    fs.Position = &H29A54 + (&H100 * 9) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_10.Value)
                    fs.Position = &H29A54 + (&H100 * 10) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_11.Value)
                    fs.Position = &H29A54 + (&H100 * 11) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_12.Value)
                    fs.Position = &H29A54 + (&H100 * 12) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_13.Value)
                    fs.Position = &H29A54 + (&H100 * 13) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_14.Value)
                    fs.Position = &H29A54 + (&H100 * 14) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_15.Value)
                    fs.Position = &H29A54 + (&H100 * 15) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_16.Value)
                    fs.Position = &H29A54 + (&H100 * 16) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_17.Value)
                    fs.Position = &H29A54 + (&H100 * 17) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_18.Value)
                    fs.Position = &H29A54 + (&H100 * 18) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_19.Value)
                    fs.Position = &H29A54 + (&H100 * 19) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_20.Value)
                    fs.Position = &H29A54 + (&H100 * 20) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_21.Value)
                    fs.Position = &H29A54 + (&H100 * 21) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_22.Value)
                    fs.Position = &H29A54 + (&H100 * 22) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_23.Value)
                    fs.Position = &H29A54 + (&H100 * 23) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_24.Value)
                    fs.Position = &H29A54 + (&H100 * 24) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_25.Value)
                    fs.Position = &H29A54 + (&H100 * 25) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_26.Value)
                    fs.Position = &H29A54 + (&H100 * 26) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_27.Value)
                    fs.Position = &H29A54 + (&H100 * 27) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_28.Value)
                    fs.Position = &H29A54 + (&H100 * 28) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_29.Value)
                    fs.Position = &H29A54 + (&H100 * 29) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_30.Value)
                ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(1) Then
                    fs.Position = &H29A54 + (&H100 * 30) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_1.Value)
                    fs.Position = &H29A54 + (&H100 * 31) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_2.Value)
                    fs.Position = &H29A54 + (&H100 * 32) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_3.Value)
                    fs.Position = &H29A54 + (&H100 * 33) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_4.Value)
                    fs.Position = &H29A54 + (&H100 * 34) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_5.Value)
                    fs.Position = &H29A54 + (&H100 * 35) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_6.Value)
                    fs.Position = &H29A54 + (&H100 * 36) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_7.Value)
                    fs.Position = &H29A54 + (&H100 * 37) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_8.Value)
                    fs.Position = &H29A54 + (&H100 * 38) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_9.Value)
                    fs.Position = &H29A54 + (&H100 * 39) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_10.Value)
                    fs.Position = &H29A54 + (&H100 * 40) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_11.Value)
                    fs.Position = &H29A54 + (&H100 * 41) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_12.Value)
                    fs.Position = &H29A54 + (&H100 * 42) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_13.Value)
                    fs.Position = &H29A54 + (&H100 * 43) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_14.Value)
                    fs.Position = &H29A54 + (&H100 * 44) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_15.Value)
                    fs.Position = &H29A54 + (&H100 * 45) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_16.Value)
                    fs.Position = &H29A54 + (&H100 * 46) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_17.Value)
                    fs.Position = &H29A54 + (&H100 * 47) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_18.Value)
                    fs.Position = &H29A54 + (&H100 * 48) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_19.Value)
                    fs.Position = &H29A54 + (&H100 * 49) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_20.Value)
                    fs.Position = &H29A54 + (&H100 * 50) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_21.Value)
                    fs.Position = &H29A54 + (&H100 * 51) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_22.Value)
                    fs.Position = &H29A54 + (&H100 * 52) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_23.Value)
                    fs.Position = &H29A54 + (&H100 * 53) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_24.Value)
                    fs.Position = &H29A54 + (&H100 * 54) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_25.Value)
                    fs.Position = &H29A54 + (&H100 * 55) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_26.Value)
                    fs.Position = &H29A54 + (&H100 * 56) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_27.Value)
                    fs.Position = &H29A54 + (&H100 * 57) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_28.Value)
                    fs.Position = &H29A54 + (&H100 * 58) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_29.Value)
                    fs.Position = &H29A54 + (&H100 * 59) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_30.Value)
                ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(2) Then
                    fs.Position = &H29A54 + (&H100 * 60) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_1.Value)
                    fs.Position = &H29A54 + (&H100 * 61) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_2.Value)
                    fs.Position = &H29A54 + (&H100 * 62) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_3.Value)
                    fs.Position = &H29A54 + (&H100 * 63) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_4.Value)
                    fs.Position = &H29A54 + (&H100 * 64) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_5.Value)
                    fs.Position = &H29A54 + (&H100 * 65) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_6.Value)
                    fs.Position = &H29A54 + (&H100 * 66) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_7.Value)
                    fs.Position = &H29A54 + (&H100 * 67) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_8.Value)
                    fs.Position = &H29A54 + (&H100 * 68) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_9.Value)
                    fs.Position = &H29A54 + (&H100 * 69) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_10.Value)
                    fs.Position = &H29A54 + (&H100 * 70) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_11.Value)
                    fs.Position = &H29A54 + (&H100 * 71) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_12.Value)
                    fs.Position = &H29A54 + (&H100 * 72) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_13.Value)
                    fs.Position = &H29A54 + (&H100 * 73) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_14.Value)
                    fs.Position = &H29A54 + (&H100 * 74) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_15.Value)
                    fs.Position = &H29A54 + (&H100 * 75) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_16.Value)
                    fs.Position = &H29A54 + (&H100 * 76) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_17.Value)
                    fs.Position = &H29A54 + (&H100 * 77) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_18.Value)
                    fs.Position = &H29A54 + (&H100 * 78) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_19.Value)
                    fs.Position = &H29A54 + (&H100 * 79) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_20.Value)
                    fs.Position = &H29A54 + (&H100 * 80) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_21.Value)
                    fs.Position = &H29A54 + (&H100 * 81) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_22.Value)
                    fs.Position = &H29A54 + (&H100 * 82) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_23.Value)
                    fs.Position = &H29A54 + (&H100 * 83) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_24.Value)
                    fs.Position = &H29A54 + (&H100 * 84) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_25.Value)
                    fs.Position = &H29A54 + (&H100 * 85) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_26.Value)
                    fs.Position = &H29A54 + (&H100 * 86) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_27.Value)
                    fs.Position = &H29A54 + (&H100 * 87) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_28.Value)
                    fs.Position = &H29A54 + (&H100 * 88) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_29.Value)
                    fs.Position = &H29A54 + (&H100 * 89) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_30.Value)
                ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(3) Then
                    fs.Position = &H29A54 + (&H100 * 90) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_1.Value)
                    fs.Position = &H29A54 + (&H100 * 91) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_2.Value)
                    fs.Position = &H29A54 + (&H100 * 92) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_3.Value)
                    fs.Position = &H29A54 + (&H100 * 93) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_4.Value)
                    fs.Position = &H29A54 + (&H100 * 94) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_5.Value)
                    fs.Position = &H29A54 + (&H100 * 95) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_6.Value)
                    fs.Position = &H29A54 + (&H100 * 96) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_7.Value)
                    fs.Position = &H29A54 + (&H100 * 97) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_8.Value)
                    fs.Position = &H29A54 + (&H100 * 98) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_9.Value)
                    fs.Position = &H29A54 + (&H100 * 99) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_10.Value)
                End If
            End If
            If Filever_text.Text = "JP" Then
                If Select_allfriends.SelectedItem = Select_allfriends.Items.Item(0) Then
                    fs.Position = &H248E4 + Patchmii
                    fs.WriteByte(valu_selfriend_rela_1.Value)
                    fs.Position = &H248E4 + &H100 + Patchmii
                    fs.WriteByte(valu_selfriend_rela_2.Value)
                    fs.Position = &H248E4 + (&H100 * 2) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_3.Value)
                    fs.Position = &H248E4 + (&H100 * 3) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_4.Value)
                    fs.Position = &H248E4 + (&H100 * 4) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_5.Value)
                    fs.Position = &H248E4 + (&H100 * 5) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_6.Value)
                    fs.Position = &H248E4 + (&H100 * 6) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_7.Value)
                    fs.Position = &H248E4 + (&H100 * 7) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_8.Value)
                    fs.Position = &H248E4 + (&H100 * 8) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_9.Value)
                    fs.Position = &H248E4 + (&H100 * 9) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_10.Value)
                    fs.Position = &H248E4 + (&H100 * 10) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_11.Value)
                    fs.Position = &H248E4 + (&H100 * 11) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_12.Value)
                    fs.Position = &H248E4 + (&H100 * 12) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_13.Value)
                    fs.Position = &H248E4 + (&H100 * 13) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_14.Value)
                    fs.Position = &H248E4 + (&H100 * 14) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_15.Value)
                    fs.Position = &H248E4 + (&H100 * 15) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_16.Value)
                    fs.Position = &H248E4 + (&H100 * 16) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_17.Value)
                    fs.Position = &H248E4 + (&H100 * 17) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_18.Value)
                    fs.Position = &H248E4 + (&H100 * 18) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_19.Value)
                    fs.Position = &H248E4 + (&H100 * 19) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_20.Value)
                    fs.Position = &H248E4 + (&H100 * 20) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_21.Value)
                    fs.Position = &H248E4 + (&H100 * 21) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_22.Value)
                    fs.Position = &H248E4 + (&H100 * 22) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_23.Value)
                    fs.Position = &H248E4 + (&H100 * 23) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_24.Value)
                    fs.Position = &H248E4 + (&H100 * 24) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_25.Value)
                    fs.Position = &H248E4 + (&H100 * 25) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_26.Value)
                    fs.Position = &H248E4 + (&H100 * 26) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_27.Value)
                    fs.Position = &H248E4 + (&H100 * 27) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_28.Value)
                    fs.Position = &H248E4 + (&H100 * 28) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_29.Value)
                    fs.Position = &H248E4 + (&H100 * 29) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_30.Value)
                ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(1) Then
                    fs.Position = &H248E4 + (&H100 * 30) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_1.Value)
                    fs.Position = &H248E4 + (&H100 * 31) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_2.Value)
                    fs.Position = &H248E4 + (&H100 * 32) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_3.Value)
                    fs.Position = &H248E4 + (&H100 * 33) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_4.Value)
                    fs.Position = &H248E4 + (&H100 * 34) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_5.Value)
                    fs.Position = &H248E4 + (&H100 * 35) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_6.Value)
                    fs.Position = &H248E4 + (&H100 * 36) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_7.Value)
                    fs.Position = &H248E4 + (&H100 * 37) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_8.Value)
                    fs.Position = &H248E4 + (&H100 * 38) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_9.Value)
                    fs.Position = &H248E4 + (&H100 * 39) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_10.Value)
                    fs.Position = &H248E4 + (&H100 * 40) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_11.Value)
                    fs.Position = &H248E4 + (&H100 * 41) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_12.Value)
                    fs.Position = &H248E4 + (&H100 * 42) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_13.Value)
                    fs.Position = &H248E4 + (&H100 * 43) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_14.Value)
                    fs.Position = &H248E4 + (&H100 * 44) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_15.Value)
                    fs.Position = &H248E4 + (&H100 * 45) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_16.Value)
                    fs.Position = &H248E4 + (&H100 * 46) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_17.Value)
                    fs.Position = &H248E4 + (&H100 * 47) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_18.Value)
                    fs.Position = &H248E4 + (&H100 * 48) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_19.Value)
                    fs.Position = &H248E4 + (&H100 * 49) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_20.Value)
                    fs.Position = &H248E4 + (&H100 * 50) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_21.Value)
                    fs.Position = &H248E4 + (&H100 * 51) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_22.Value)
                    fs.Position = &H248E4 + (&H100 * 52) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_23.Value)
                    fs.Position = &H248E4 + (&H100 * 53) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_24.Value)
                    fs.Position = &H248E4 + (&H100 * 54) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_25.Value)
                    fs.Position = &H248E4 + (&H100 * 55) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_26.Value)
                    fs.Position = &H248E4 + (&H100 * 56) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_27.Value)
                    fs.Position = &H248E4 + (&H100 * 57) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_28.Value)
                    fs.Position = &H248E4 + (&H100 * 58) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_29.Value)
                    fs.Position = &H248E4 + (&H100 * 59) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_30.Value)
                ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(2) Then
                    fs.Position = &H248E4 + (&H100 * 60) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_1.Value)
                    fs.Position = &H248E4 + (&H100 * 61) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_2.Value)
                    fs.Position = &H248E4 + (&H100 * 62) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_3.Value)
                    fs.Position = &H248E4 + (&H100 * 63) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_4.Value)
                    fs.Position = &H248E4 + (&H100 * 64) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_5.Value)
                    fs.Position = &H248E4 + (&H100 * 65) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_6.Value)
                    fs.Position = &H248E4 + (&H100 * 66) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_7.Value)
                    fs.Position = &H248E4 + (&H100 * 67) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_8.Value)
                    fs.Position = &H248E4 + (&H100 * 68) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_9.Value)
                    fs.Position = &H248E4 + (&H100 * 69) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_10.Value)
                    fs.Position = &H248E4 + (&H100 * 70) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_11.Value)
                    fs.Position = &H248E4 + (&H100 * 71) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_12.Value)
                    fs.Position = &H248E4 + (&H100 * 72) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_13.Value)
                    fs.Position = &H248E4 + (&H100 * 73) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_14.Value)
                    fs.Position = &H248E4 + (&H100 * 74) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_15.Value)
                    fs.Position = &H248E4 + (&H100 * 75) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_16.Value)
                    fs.Position = &H248E4 + (&H100 * 76) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_17.Value)
                    fs.Position = &H248E4 + (&H100 * 77) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_18.Value)
                    fs.Position = &H248E4 + (&H100 * 78) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_19.Value)
                    fs.Position = &H248E4 + (&H100 * 79) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_20.Value)
                    fs.Position = &H248E4 + (&H100 * 80) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_21.Value)
                    fs.Position = &H248E4 + (&H100 * 81) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_22.Value)
                    fs.Position = &H248E4 + (&H100 * 82) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_23.Value)
                    fs.Position = &H248E4 + (&H100 * 83) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_24.Value)
                    fs.Position = &H248E4 + (&H100 * 84) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_25.Value)
                    fs.Position = &H248E4 + (&H100 * 85) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_26.Value)
                    fs.Position = &H248E4 + (&H100 * 86) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_27.Value)
                    fs.Position = &H248E4 + (&H100 * 87) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_28.Value)
                    fs.Position = &H248E4 + (&H100 * 88) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_29.Value)
                    fs.Position = &H248E4 + (&H100 * 89) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_30.Value)
                ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(3) Then
                    fs.Position = &H248E4 + (&H100 * 90) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_1.Value)
                    fs.Position = &H248E4 + (&H100 * 91) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_2.Value)
                    fs.Position = &H248E4 + (&H100 * 92) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_3.Value)
                    fs.Position = &H248E4 + (&H100 * 93) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_4.Value)
                    fs.Position = &H248E4 + (&H100 * 94) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_5.Value)
                    fs.Position = &H248E4 + (&H100 * 95) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_6.Value)
                    fs.Position = &H248E4 + (&H100 * 96) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_7.Value)
                    fs.Position = &H248E4 + (&H100 * 97) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_8.Value)
                    fs.Position = &H248E4 + (&H100 * 98) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_9.Value)
                    fs.Position = &H248E4 + (&H100 * 99) + Patchmii
                    fs.WriteByte(valu_selfriend_rela_10.Value)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseDown, TLSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TLSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseUp, TLSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TLSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseMove, TLSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Filever_text_Click(sender As Object, e As EventArgs) Handles Filever_text.Click
        switchfilever()
    End Sub

    Private Sub Filever_text_MouseMove(sender As Object, e As EventArgs) Handles Filever_text.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to change save file version"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour changer la version de la sauvegarde"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Filever_text_MouseLeave(sender As Object, e As EventArgs) Handles Filever_text.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Info_islandbuild_MouseMove(sender As Object, e As EventArgs) Handles Info_islandbuild.MouseMove
        Icon_info_building.Visible = True
    End Sub

    Private Sub Info_islandbuild_MouseLeave(sender As Object, e As EventArgs) Handles Info_islandbuild.MouseLeave
        Icon_info_building.Visible = False
    End Sub

    Private Sub Icon_islandn_pronun_val_Click(sender As Object, e As EventArgs) Handles Icon_islandn_pronun_val.Click
        Panel_edit_pronun_island.Visible = False
        Text_pronun_islandname.Text = Text_pronun_island.Text
    End Sub

    Private Sub Icon_pronun_islandname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.Click
        Panel_edit_pronun_island.Visible = True
        Text_pronun_island.Text = Text_pronun_islandname.Text
    End Sub

    Private Sub Icon_pronun_islandname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseMove
        Text_pronun_islandname.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit island's pronunciation name"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la prononciation du nom de l'île"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_islandname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseLeave
        Text_pronun_islandname.Visible = False
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_appartrenov_Click(sender As Object, e As EventArgs) Handles Icon_appartrenov.Click
        value_appartrenov.Value = (value_appartrenov.Value + 1)
    End Sub

    Private Sub valu__appartrenov_ValueChanged(sender As Object, e As EventArgs) Handles value_appartrenov.ValueChanged
        If value_appartrenov.Value > 3 Then
            value_appartrenov.Value = 0
        End If
        If value_appartrenov.Value = 0 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_00
        ElseIf value_appartrenov.Value = 1 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_01
        ElseIf value_appartrenov.Value = 2 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_02
        ElseIf value_appartrenov.Value = 3 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_03
        End If
    End Sub

    Private Sub Icon_eventfountain_Click(sender As Object, e As EventArgs) Handles Icon_eventfountain.Click
        value_eventfountain.Value = 0
    End Sub

    Private Sub Icon_eventfountain_MouseMove(sender As Object, e As EventArgs) Handles Icon_eventfountain.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to active fountain's event"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour activer l'évènement de la fontaine"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_eventfountain_MouseLeave(sender As Object, e As EventArgs) Handles Icon_eventfountain.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Text_menu_button_Click(sender As Object, e As EventArgs) Handles Text_menu_button.Click
        If Menu_panel.Visible = False Then
            Menu_panel.Visible = True
        ElseIf Menu_panel.Visible = True Then
            Menu_panel.Visible = False
        End If
    End Sub

    Private Sub Menu_islandedit_Click(sender As Object, e As EventArgs) Handles Menu_islandedit.Click, Menu_text_islandedit.Click
        hidepanels()
        Panel_islandedit.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_islandedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_islandedit.MouseMove, Menu_text_islandedit.MouseMove
        Menu_islandedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_islandedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_islandedit.MouseLeave, Menu_text_islandedit.MouseLeave
        Menu_islandedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_extras_Click(sender As Object, e As EventArgs) Handles Menu_extras.Click, Menu_text_extras.Click
        hidepanels()
        Panel_extras.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_extras_MouseMove(sender As Object, e As EventArgs) Handles Menu_extras.MouseMove, Menu_text_extras.MouseMove
        Menu_extras.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_extras_MouseLeave(sender As Object, e As EventArgs) Handles Menu_extras.MouseLeave, Menu_text_extras.MouseLeave
        Menu_extras.BorderStyle = BorderStyle.None
    End Sub

    Private Sub TL_SaveEditor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Checkupdates()
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Private Sub Menu_settings_Click(sender As Object, e As EventArgs) Handles Menu_settings.Click, Menu_text_settings.Click
        hidepanels()
        Panel_settings.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_settings_MouseMove(sender As Object, e As EventArgs) Handles Menu_settings.MouseMove, Menu_text_settings.MouseMove
        Menu_settings.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_settings_MouseLeave(sender As Object, e As EventArgs) Handles Menu_settings.MouseLeave, Menu_text_settings.MouseLeave
        Menu_settings.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_itemsedit_Click(sender As Object, e As EventArgs) Handles Menu_itemsedit.Click, Menu_text_itemsedit.Click
        Menu_panel.Visible = False
        Me.Hide()
        'mettre un ecran de chargement (trop de ressources vont être utilisés)
        Loading.Show()
        Items_edit.Show()
    End Sub

    Private Sub Menu_itemsedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseMove, Menu_text_itemsedit.MouseMove
        Menu_itemsedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseLeave, Menu_text_itemsedit.MouseLeave
        Menu_itemsedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_miiedit_Click(sender As Object, e As EventArgs) Handles Menu_miiedit.Click, Menu_text_miiedit.Click
        hidepanels()
        Panel_miiedit.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_miiedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_miiedit.MouseMove, Menu_text_miiedit.MouseMove
        Menu_miiedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_miiedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_miiedit.MouseLeave, Menu_text_miiedit.MouseLeave
        Menu_miiedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Select_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_language.SelectedIndexChanged
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_menu_button.Text = "Menu"
            Text_menu_open.Text = "Open"
            Menu_text_extras.Text = "Extras"
            Menu_text_islandedit.Text = "Island edit"
            Menu_text_miiedit.Text = "Mii edit"
            Menu_text_repair.Text = "Repair save file"
            Menu_text_settings.Text = "Settings"
            Menu_text_itemsedit.Text = "Items edit"
            Title_appartrenov.Text = "Apartments renovation"
            Title_childrenborn.Text = "Children born"
            Title_eventfountain.Text = "Event fountain"
            Title_islandname.Text = "Island's name"
            Title_problemsolved.Text = "Problems solved"
            Title_streetpassencounters.Text = "Streetpass encounters"
            Title_travelersreceived.Text = "Travelers received"
            Title_travelerssent.Text = "Travelers sent"
            Title_weddings.Text = "Weddings"
            Check_resetstpspp.Text = "Reset Tomodachi Life Streetpass / Spotpass"
            Check_timetravel.Text = "Remove time travel penality"
            Setting_music.Text = "Active background music"
            Setting_hidden.Text = "Show hidden things"
            Setting_filepath.Text = "Show file path"
            Setting_ckupdate.Text = "Unactive check update"
            Text_language.Text = "Language"
            Tab_mii_edit.Text = "Edit"
            Tab_mii_status.Text = "Status"
            Tab_mii_friendlist.Text = "Friendlist"
            Tab_mii_extras.Text = "Extras"
            Title_sharing.Text = "Sharing"
            Title_copying.Text = "Copying"
            Title_firstname.Text = "First Name"
            Title_lastname.Text = "Last Name"
            Title_nickname.Text = "Nickname"
            Title_favcolor.Text = "Favorite Color"
            Title_relationyou.Text = "Relation to real You"
            Title_growkid.Text = "Grown-up / Kid"
            Title_haircolor.Text = "Hair Color"
            Title_creator.Text = "Creator"
            Text_save_mii.Text = "Save changes"
            Select_unlock_gooditems.Items.Item(0) = "Do nothing"
            Select_unlock_gooditems.Items.Item(1) = "Unlock all"
            Select_unlock_gooditems.Items.Item(2) = "Delete all"
            Select_unlock_interiors.Items.Item(0) = "Do nothing"
            Select_unlock_interiors.Items.Item(1) = "Unlock all"
            Select_unlock_interiors.Items.Item(2) = "Delete all"
            Select_unlock_specialfoods.Items.Item(0) = "Do nothing"
            Select_unlock_specialfoods.Items.Item(1) = "Unlock all"
            Select_unlock_specialfoods.Items.Item(2) = "Delete all"
            color_empty.Text = "normal"
            Button_close_hcoloredit.Text = "OK"
            Text_unlock_music.Text = "Unlock all"
            Text_edit_metal.Text = "Metal"
            Text_edit_pop.Text = "Pop"
            Text_edit_rockroll.Text = "Rock' n' Roll"
            Text_edit_rap.Text = "Rap"
            Text_edit_ballad.Text = "Ballad"
            Text_edit_opera.Text = "Opera"
            Text_edit_techno.Text = "Techno"
            Text_edit_musical.Text = "Musical"
            Text_level.Text = "Lv."
            Title_foods_allfav.Text = "Super All-Time Fav / All-Time Fav"
            Title_foods_favorite.Text = "Favorite Foods"
            Title_foods_worst.Text = "Worst / Worst Ever"
            Text_fullness.Text = "Fullness"
            Check_fullness.Text = "He didn't eat"
            Title_interactionpattern.Text = "Interaction pattern"
            Title_target1.Text = "Target 1"
            Title_target2.Text = "Target 2"
            Title_emotions.Text = "Emotions"
            Select_growkid.Items.Item(0) = "Grown-up"
            Select_growkid.Items.Item(1) = "Grown-up (1)"
            Select_growkid.Items.Item(2) = "Kid"
            Select_relationyou.Items.Item(0) = "Child"
            Select_relationyou.Items.Item(1) = "Not Related"
            Select_relationyou.Items.Item(2) = "Other Relative"
            Select_relationyou.Items.Item(3) = "Parent"
            Select_relationyou.Items.Item(4) = "Self"
            Select_relationyou.Items.Item(5) = "Sibling"
            Select_relationyou.Items.Item(6) = "Spouse"
            Select_interaction.Items.Item(0) = "Nothing"
            Select_interaction.Items.Item(1) = "I'm hungry"
            Select_interaction.Items.Item(2) = "I'm hungry(1)"
            Select_interaction.Items.Item(3) = "I'm hungry(2)"
            Select_interaction.Items.Item(4) = "In love with"
            Select_interaction.Items.Item(5) = "angry at"
            Select_interaction.Items.Item(6) = "angry at(1)"
            Select_interaction.Items.Item(7) = "In love with (undecided)"
            Select_interaction.Items.Item(8) = "Dream"
            Select_interaction.Items.Item(9) = "I need new clothes"
            Select_interaction.Items.Item(10) = "I need new clothes (something classy)"
            Select_interaction.Items.Item(11) = "I need new clothes (to do sports)"
            Select_interaction.Items.Item(12) = "Can I tell you about my [love stories? / my wife?]"
            Select_interaction.Items.Item(13) = "Sad : love rejected"
            Select_interaction.Items.Item(14) = "Want to get married"
            Select_emotions.Items.Item(0) = "Normal"
            Select_emotions.Items.Item(1) = "Happy"
            Select_emotions.Items.Item(2) = "Angry"
            Select_emotions.Items.Item(3) = "Sad"
            Select_emotions.Items.Item(4) = "In love"
            Button_setallfriends.Text = "Set all to"
            Select_allfriends.Items.Item(0) = "Mii 1 to 30"
            Select_allfriends.Items.Item(1) = "Mii 31 to 60"
            Select_allfriends.Items.Item(2) = "Mii 61 to 90"
            Select_allfriends.Items.Item(3) = "Mii 91 to 100"
            Title_ranking_pampered.Text = "Pampered ranking"
            Title_ranking_splurge.Text = "Splurge ranking"
            Select_friend_rela_1.Items.Item(0) = "Unknow"
            Select_friend_rela_1.Items.Item(1) = "Friend"
            Select_friend_rela_1.Items.Item(2) = "Lover"
            Select_friend_rela_1.Items.Item(3) = "Ex"
            Select_friend_rela_1.Items.Item(4) = "Spouse"
            Select_friend_rela_1.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_1.Items.Item(6) = "Parent"
            Select_friend_rela_1.Items.Item(7) = "Sibling"
            Select_friend_rela_1.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_1.Items.Item(9) = "Best friend"
            Select_friend_rela_2.Items.Item(0) = "Unknow"
            Select_friend_rela_2.Items.Item(1) = "Friend"
            Select_friend_rela_2.Items.Item(2) = "Lover"
            Select_friend_rela_2.Items.Item(3) = "Ex"
            Select_friend_rela_2.Items.Item(4) = "Spouse"
            Select_friend_rela_2.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_2.Items.Item(6) = "Parent"
            Select_friend_rela_2.Items.Item(7) = "Sibling"
            Select_friend_rela_2.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_2.Items.Item(9) = "Best friend"
            Select_friend_rela_3.Items.Item(0) = "Unknow"
            Select_friend_rela_3.Items.Item(1) = "Friend"
            Select_friend_rela_3.Items.Item(2) = "Lover"
            Select_friend_rela_3.Items.Item(3) = "Ex"
            Select_friend_rela_3.Items.Item(4) = "Spouse"
            Select_friend_rela_3.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_3.Items.Item(6) = "Parent"
            Select_friend_rela_3.Items.Item(7) = "Sibling"
            Select_friend_rela_3.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_3.Items.Item(9) = "Best friend"
            Select_friend_rela_4.Items.Item(0) = "Unknow"
            Select_friend_rela_4.Items.Item(1) = "Friend"
            Select_friend_rela_4.Items.Item(2) = "Lover"
            Select_friend_rela_4.Items.Item(3) = "Ex"
            Select_friend_rela_4.Items.Item(4) = "Spouse"
            Select_friend_rela_4.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_4.Items.Item(6) = "Parent"
            Select_friend_rela_4.Items.Item(7) = "Sibling"
            Select_friend_rela_4.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_4.Items.Item(9) = "Best friend"
            Select_friend_rela_5.Items.Item(0) = "Unknow"
            Select_friend_rela_5.Items.Item(1) = "Friend"
            Select_friend_rela_5.Items.Item(2) = "Lover"
            Select_friend_rela_5.Items.Item(3) = "Ex"
            Select_friend_rela_5.Items.Item(4) = "Spouse"
            Select_friend_rela_5.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_5.Items.Item(6) = "Parent"
            Select_friend_rela_5.Items.Item(7) = "Sibling"
            Select_friend_rela_5.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_5.Items.Item(9) = "Best friend"
            Select_friend_rela_6.Items.Item(0) = "Unknow"
            Select_friend_rela_6.Items.Item(1) = "Friend"
            Select_friend_rela_6.Items.Item(2) = "Lover"
            Select_friend_rela_6.Items.Item(3) = "Ex"
            Select_friend_rela_6.Items.Item(4) = "Spouse"
            Select_friend_rela_6.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_6.Items.Item(6) = "Parent"
            Select_friend_rela_6.Items.Item(7) = "Sibling"
            Select_friend_rela_6.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_6.Items.Item(9) = "Best friend"
            Select_friend_rela_7.Items.Item(0) = "Unknow"
            Select_friend_rela_7.Items.Item(1) = "Friend"
            Select_friend_rela_7.Items.Item(2) = "Lover"
            Select_friend_rela_7.Items.Item(3) = "Ex"
            Select_friend_rela_7.Items.Item(4) = "Spouse"
            Select_friend_rela_7.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_7.Items.Item(6) = "Parent"
            Select_friend_rela_7.Items.Item(7) = "Sibling"
            Select_friend_rela_7.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_7.Items.Item(9) = "Best friend"
            Select_friend_rela_8.Items.Item(0) = "Unknow"
            Select_friend_rela_8.Items.Item(1) = "Friend"
            Select_friend_rela_8.Items.Item(2) = "Lover"
            Select_friend_rela_8.Items.Item(3) = "Ex"
            Select_friend_rela_8.Items.Item(4) = "Spouse"
            Select_friend_rela_8.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_8.Items.Item(6) = "Parent"
            Select_friend_rela_8.Items.Item(7) = "Sibling"
            Select_friend_rela_8.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_8.Items.Item(9) = "Best friend"
            Select_friend_rela_9.Items.Item(0) = "Unknow"
            Select_friend_rela_9.Items.Item(1) = "Friend"
            Select_friend_rela_9.Items.Item(2) = "Lover"
            Select_friend_rela_9.Items.Item(3) = "Ex"
            Select_friend_rela_9.Items.Item(4) = "Spouse"
            Select_friend_rela_9.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_9.Items.Item(6) = "Parent"
            Select_friend_rela_9.Items.Item(7) = "Sibling"
            Select_friend_rela_9.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_9.Items.Item(9) = "Best friend"
            Select_friend_rela_10.Items.Item(0) = "Unknow"
            Select_friend_rela_10.Items.Item(1) = "Friend"
            Select_friend_rela_10.Items.Item(2) = "Lover"
            Select_friend_rela_10.Items.Item(3) = "Ex"
            Select_friend_rela_10.Items.Item(4) = "Spouse"
            Select_friend_rela_10.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_10.Items.Item(6) = "Parent"
            Select_friend_rela_10.Items.Item(7) = "Sibling"
            Select_friend_rela_10.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_10.Items.Item(9) = "Best friend"
            Select_friend_rela_11.Items.Item(0) = "Unknow"
            Select_friend_rela_11.Items.Item(1) = "Friend"
            Select_friend_rela_11.Items.Item(2) = "Lover"
            Select_friend_rela_11.Items.Item(3) = "Ex"
            Select_friend_rela_11.Items.Item(4) = "Spouse"
            Select_friend_rela_11.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_11.Items.Item(6) = "Parent"
            Select_friend_rela_11.Items.Item(7) = "Sibling"
            Select_friend_rela_11.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_11.Items.Item(9) = "Best friend"
            Select_friend_rela_12.Items.Item(0) = "Unknow"
            Select_friend_rela_12.Items.Item(1) = "Friend"
            Select_friend_rela_12.Items.Item(2) = "Lover"
            Select_friend_rela_12.Items.Item(3) = "Ex"
            Select_friend_rela_12.Items.Item(4) = "Spouse"
            Select_friend_rela_12.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_12.Items.Item(6) = "Parent"
            Select_friend_rela_12.Items.Item(7) = "Sibling"
            Select_friend_rela_12.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_12.Items.Item(9) = "Best friend"
            Select_friend_rela_13.Items.Item(0) = "Unknow"
            Select_friend_rela_13.Items.Item(1) = "Friend"
            Select_friend_rela_13.Items.Item(2) = "Lover"
            Select_friend_rela_13.Items.Item(3) = "Ex"
            Select_friend_rela_13.Items.Item(4) = "Spouse"
            Select_friend_rela_13.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_13.Items.Item(6) = "Parent"
            Select_friend_rela_13.Items.Item(7) = "Sibling"
            Select_friend_rela_13.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_13.Items.Item(9) = "Best friend"
            Select_friend_rela_14.Items.Item(0) = "Unknow"
            Select_friend_rela_14.Items.Item(1) = "Friend"
            Select_friend_rela_14.Items.Item(2) = "Lover"
            Select_friend_rela_14.Items.Item(3) = "Ex"
            Select_friend_rela_14.Items.Item(4) = "Spouse"
            Select_friend_rela_14.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_14.Items.Item(6) = "Parent"
            Select_friend_rela_14.Items.Item(7) = "Sibling"
            Select_friend_rela_14.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_14.Items.Item(9) = "Best friend"
            Select_friend_rela_15.Items.Item(0) = "Unknow"
            Select_friend_rela_15.Items.Item(1) = "Friend"
            Select_friend_rela_15.Items.Item(2) = "Lover"
            Select_friend_rela_15.Items.Item(3) = "Ex"
            Select_friend_rela_15.Items.Item(4) = "Spouse"
            Select_friend_rela_15.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_15.Items.Item(6) = "Parent"
            Select_friend_rela_15.Items.Item(7) = "Sibling"
            Select_friend_rela_15.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_15.Items.Item(9) = "Best friend"
            Select_friend_rela_16.Items.Item(0) = "Unknow"
            Select_friend_rela_16.Items.Item(1) = "Friend"
            Select_friend_rela_16.Items.Item(2) = "Lover"
            Select_friend_rela_16.Items.Item(3) = "Ex"
            Select_friend_rela_16.Items.Item(4) = "Spouse"
            Select_friend_rela_16.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_16.Items.Item(6) = "Parent"
            Select_friend_rela_16.Items.Item(7) = "Sibling"
            Select_friend_rela_16.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_16.Items.Item(9) = "Best friend"
            Select_friend_rela_17.Items.Item(0) = "Unknow"
            Select_friend_rela_17.Items.Item(1) = "Friend"
            Select_friend_rela_17.Items.Item(2) = "Lover"
            Select_friend_rela_17.Items.Item(3) = "Ex"
            Select_friend_rela_17.Items.Item(4) = "Spouse"
            Select_friend_rela_17.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_17.Items.Item(6) = "Parent"
            Select_friend_rela_17.Items.Item(7) = "Sibling"
            Select_friend_rela_17.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_17.Items.Item(9) = "Best friend"
            Select_friend_rela_18.Items.Item(0) = "Unknow"
            Select_friend_rela_18.Items.Item(1) = "Friend"
            Select_friend_rela_18.Items.Item(2) = "Lover"
            Select_friend_rela_18.Items.Item(3) = "Ex"
            Select_friend_rela_18.Items.Item(4) = "Spouse"
            Select_friend_rela_18.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_18.Items.Item(6) = "Parent"
            Select_friend_rela_18.Items.Item(7) = "Sibling"
            Select_friend_rela_18.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_18.Items.Item(9) = "Best friend"
            Select_friend_rela_19.Items.Item(0) = "Unknow"
            Select_friend_rela_19.Items.Item(1) = "Friend"
            Select_friend_rela_19.Items.Item(2) = "Lover"
            Select_friend_rela_19.Items.Item(3) = "Ex"
            Select_friend_rela_19.Items.Item(4) = "Spouse"
            Select_friend_rela_19.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_19.Items.Item(6) = "Parent"
            Select_friend_rela_19.Items.Item(7) = "Sibling"
            Select_friend_rela_19.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_19.Items.Item(9) = "Best friend"
            Select_friend_rela_20.Items.Item(0) = "Unknow"
            Select_friend_rela_20.Items.Item(1) = "Friend"
            Select_friend_rela_20.Items.Item(2) = "Lover"
            Select_friend_rela_20.Items.Item(3) = "Ex"
            Select_friend_rela_20.Items.Item(4) = "Spouse"
            Select_friend_rela_20.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_20.Items.Item(6) = "Parent"
            Select_friend_rela_20.Items.Item(7) = "Sibling"
            Select_friend_rela_20.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_20.Items.Item(9) = "Best friend"
            Select_friend_rela_21.Items.Item(0) = "Unknow"
            Select_friend_rela_21.Items.Item(1) = "Friend"
            Select_friend_rela_21.Items.Item(2) = "Lover"
            Select_friend_rela_21.Items.Item(3) = "Ex"
            Select_friend_rela_21.Items.Item(4) = "Spouse"
            Select_friend_rela_21.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_21.Items.Item(6) = "Parent"
            Select_friend_rela_21.Items.Item(7) = "Sibling"
            Select_friend_rela_21.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_21.Items.Item(9) = "Best friend"
            Select_friend_rela_22.Items.Item(0) = "Unknow"
            Select_friend_rela_22.Items.Item(1) = "Friend"
            Select_friend_rela_22.Items.Item(2) = "Lover"
            Select_friend_rela_22.Items.Item(3) = "Ex"
            Select_friend_rela_22.Items.Item(4) = "Spouse"
            Select_friend_rela_22.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_22.Items.Item(6) = "Parent"
            Select_friend_rela_22.Items.Item(7) = "Sibling"
            Select_friend_rela_22.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_22.Items.Item(9) = "Best friend"
            Select_friend_rela_23.Items.Item(0) = "Unknow"
            Select_friend_rela_23.Items.Item(1) = "Friend"
            Select_friend_rela_23.Items.Item(2) = "Lover"
            Select_friend_rela_23.Items.Item(3) = "Ex"
            Select_friend_rela_23.Items.Item(4) = "Spouse"
            Select_friend_rela_23.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_23.Items.Item(6) = "Parent"
            Select_friend_rela_23.Items.Item(7) = "Sibling"
            Select_friend_rela_23.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_23.Items.Item(9) = "Best friend"
            Select_friend_rela_24.Items.Item(0) = "Unknow"
            Select_friend_rela_24.Items.Item(1) = "Friend"
            Select_friend_rela_24.Items.Item(2) = "Lover"
            Select_friend_rela_24.Items.Item(3) = "Ex"
            Select_friend_rela_24.Items.Item(4) = "Spouse"
            Select_friend_rela_24.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_24.Items.Item(6) = "Parent"
            Select_friend_rela_24.Items.Item(7) = "Sibling"
            Select_friend_rela_24.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_24.Items.Item(9) = "Best friend"
            Select_friend_rela_25.Items.Item(0) = "Unknow"
            Select_friend_rela_25.Items.Item(1) = "Friend"
            Select_friend_rela_25.Items.Item(2) = "Lover"
            Select_friend_rela_25.Items.Item(3) = "Ex"
            Select_friend_rela_25.Items.Item(4) = "Spouse"
            Select_friend_rela_25.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_25.Items.Item(6) = "Parent"
            Select_friend_rela_25.Items.Item(7) = "Sibling"
            Select_friend_rela_25.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_25.Items.Item(9) = "Best friend"
            Select_friend_rela_26.Items.Item(0) = "Unknow"
            Select_friend_rela_26.Items.Item(1) = "Friend"
            Select_friend_rela_26.Items.Item(2) = "Lover"
            Select_friend_rela_26.Items.Item(3) = "Ex"
            Select_friend_rela_26.Items.Item(4) = "Spouse"
            Select_friend_rela_26.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_26.Items.Item(6) = "Parent"
            Select_friend_rela_26.Items.Item(7) = "Sibling"
            Select_friend_rela_26.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_26.Items.Item(9) = "Best friend"
            Select_friend_rela_27.Items.Item(0) = "Unknow"
            Select_friend_rela_27.Items.Item(1) = "Friend"
            Select_friend_rela_27.Items.Item(2) = "Lover"
            Select_friend_rela_27.Items.Item(3) = "Ex"
            Select_friend_rela_27.Items.Item(4) = "Spouse"
            Select_friend_rela_27.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_27.Items.Item(6) = "Parent"
            Select_friend_rela_27.Items.Item(7) = "Sibling"
            Select_friend_rela_27.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_27.Items.Item(9) = "Best friend"
            Select_friend_rela_28.Items.Item(0) = "Unknow"
            Select_friend_rela_28.Items.Item(1) = "Friend"
            Select_friend_rela_28.Items.Item(2) = "Lover"
            Select_friend_rela_28.Items.Item(3) = "Ex"
            Select_friend_rela_28.Items.Item(4) = "Spouse"
            Select_friend_rela_28.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_28.Items.Item(6) = "Parent"
            Select_friend_rela_28.Items.Item(7) = "Sibling"
            Select_friend_rela_28.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_28.Items.Item(9) = "Best friend"
            Select_friend_rela_29.Items.Item(0) = "Unknow"
            Select_friend_rela_29.Items.Item(1) = "Friend"
            Select_friend_rela_29.Items.Item(2) = "Lover"
            Select_friend_rela_29.Items.Item(3) = "Ex"
            Select_friend_rela_29.Items.Item(4) = "Spouse"
            Select_friend_rela_29.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_29.Items.Item(6) = "Parent"
            Select_friend_rela_29.Items.Item(7) = "Sibling"
            Select_friend_rela_29.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_29.Items.Item(9) = "Best friend"
            Select_friend_rela_30.Items.Item(0) = "Unknow"
            Select_friend_rela_30.Items.Item(1) = "Friend"
            Select_friend_rela_30.Items.Item(2) = "Lover"
            Select_friend_rela_30.Items.Item(3) = "Ex"
            Select_friend_rela_30.Items.Item(4) = "Spouse"
            Select_friend_rela_30.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_30.Items.Item(6) = "Parent"
            Select_friend_rela_30.Items.Item(7) = "Sibling"
            Select_friend_rela_30.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_30.Items.Item(9) = "Best friend"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_menu_button.Text = "Menu"
            Text_menu_open.Text = "Ouvrir"
            Menu_text_extras.Text = "Extras"
            Menu_text_islandedit.Text = "Édition île"
            Menu_text_miiedit.Text = "Édition Mii"
            Menu_text_repair.Text = "Réparation sauvegarde"
            Menu_text_settings.Text = "Paramètres"
            Menu_text_itemsedit.Text = "Édition objets"
            Title_appartrenov.Text = "Rénovation appartements"
            Title_childrenborn.Text = "Nouveau né"
            Title_eventfountain.Text = "Évènement fontaine"
            Title_islandname.Text = "Nom de l'île"
            Title_problemsolved.Text = "Problèmes résolus"
            Title_streetpassencounters.Text = "Streetpass reçus"
            Title_travelersreceived.Text = "Voyageurs reçus"
            Title_travelerssent.Text = "Voyageurs envoyés"
            Title_weddings.Text = "Mariages"
            Check_resetstpspp.Text = "Réinitialiser Streetpass / Spotpass de Tomodachi Life"
            Check_timetravel.Text = "Retirer la pénalité de voyage dans le temps"
            Setting_music.Text = "Activer la musique de fond"
            Setting_hidden.Text = "Afficher les choses cachés"
            Setting_filepath.Text = "Afficher le chemin du fichier"
            Setting_ckupdate.Text = "Désactiver la vérification des mises à jour"
            Text_language.Text = "Langage"
            Tab_mii_edit.Text = "Édition"
            Tab_mii_status.Text = "Status"
            Tab_mii_friendlist.Text = "Liste d'amis"
            Tab_mii_extras.Text = "Extras"
            Title_sharing.Text = "Partage"
            Title_copying.Text = "Copie"
            Title_firstname.Text = "Prénom"
            Title_lastname.Text = "Nom"
            Title_nickname.Text = "Surnom"
            Title_favcolor.Text = "Couleur favorite"
            Title_relationyou.Text = "Relation avec le ''vous'' réel"
            Title_growkid.Text = "Adulte / Enfant"
            Title_haircolor.Text = "Couleur cheveux"
            Title_creator.Text = "Créateur"
            Text_save_mii.Text = "Enregistrer changements"
            Select_unlock_gooditems.Items.Item(0) = "Ne rien faire"
            Select_unlock_gooditems.Items.Item(1) = "Tout débloquer"
            Select_unlock_gooditems.Items.Item(2) = "Tout supprimer"
            Select_unlock_interiors.Items.Item(0) = "Ne rien faire"
            Select_unlock_interiors.Items.Item(1) = "Tout débloquer"
            Select_unlock_interiors.Items.Item(2) = "Tout supprimer"
            Select_unlock_specialfoods.Items.Item(0) = "Ne rien faire"
            Select_unlock_specialfoods.Items.Item(1) = "Tout débloquer"
            Select_unlock_specialfoods.Items.Item(2) = "Tout supprimer"
            color_empty.Text = "normal"
            Button_close_hcoloredit.Text = "OK"
            Text_unlock_music.Text = "Tout débloquer"
            Text_edit_metal.Text = "Métal"
            Text_edit_pop.Text = "Pop"
            Text_edit_rockroll.Text = "Rock' n' Roll"
            Text_edit_rap.Text = "Rap"
            Text_edit_ballad.Text = "Ballade"
            Text_edit_opera.Text = "Opéra"
            Text_edit_techno.Text = "Techno"
            Text_edit_musical.Text = "Musicale"
            Text_level.Text = "Niv."
            Title_foods_allfav.Text = "Adore / Aime beaucoup"
            Title_foods_favorite.Text = "Aime bien"
            Title_foods_worst.Text = "N'aime pas / Déteste"
            Text_fullness.Text = "Estomac"
            Check_fullness.Text = "Il a pas mangé"
            Title_interactionpattern.Text = "Interaction"
            Title_target1.Text = "Cible 1"
            Title_target2.Text = "Cible 2"
            Title_emotions.Text = "Émotions"
            Select_growkid.Items.Item(0) = "Adulte"
            Select_growkid.Items.Item(1) = "Adulte (1)"
            Select_growkid.Items.Item(2) = "Enfant"
            Select_relationyou.Items.Item(0) = "Enfant"
            Select_relationyou.Items.Item(1) = "Aucune parenté"
            Select_relationyou.Items.Item(2) = "Famille"
            Select_relationyou.Items.Item(3) = "Parent"
            Select_relationyou.Items.Item(4) = "Moi-même"
            Select_relationyou.Items.Item(5) = "Frère / Soeur"
            Select_relationyou.Items.Item(6) = "Épouse"
            Select_interaction.Items.Item(0) = "Rien"
            Select_interaction.Items.Item(1) = "J'ai faim"
            Select_interaction.Items.Item(2) = "J'ai faim (1)"
            Select_interaction.Items.Item(3) = "J'ai faim (2)"
            Select_interaction.Items.Item(4) = "Amoureux de"
            Select_interaction.Items.Item(5) = "Faché contre"
            Select_interaction.Items.Item(6) = "Faché contre (1)"
            Select_interaction.Items.Item(7) = "Amoureux de (indécis)"
            Select_interaction.Items.Item(8) = "Rêve"
            Select_interaction.Items.Item(9) = "J'ai besoin de nouveaux vêtements"
            Select_interaction.Items.Item(10) = "J'ai besoin de nouveaux vêtements (qq.chose de classe)"
            Select_interaction.Items.Item(11) = "J'ai besoin de nouveaux vêtements (pr.faire du sports)"
            Select_interaction.Items.Item(12) = "Puis-je vous parler de [mes histoires d'amour? / ma femme?]"
            Select_interaction.Items.Item(13) = "Triste : amour rejeté"
            Select_interaction.Items.Item(14) = "Veux se marrier"
            Select_emotions.Items.Item(0) = "Normal"
            Select_emotions.Items.Item(1) = "Heureux"
            Select_emotions.Items.Item(2) = "En colère"
            Select_emotions.Items.Item(3) = "Triste"
            Select_emotions.Items.Item(4) = "Amoureux"
            Button_setallfriends.Text = "Mettre tout à"
            Select_allfriends.Items.Item(0) = "Mii 1 à 30"
            Select_allfriends.Items.Item(1) = "Mii 31 à 60"
            Select_allfriends.Items.Item(2) = "Mii 61 à 90"
            Select_allfriends.Items.Item(3) = "Mii 91 à 100"
            Title_ranking_pampered.Text = "Mii préférés"
            Title_ranking_splurge.Text = "Mii dépensiers"
            Select_friend_rela_1.Items.Item(0) = "Inconnu"
            Select_friend_rela_1.Items.Item(1) = "Ami"
            Select_friend_rela_1.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_1.Items.Item(3) = "Ex"
            Select_friend_rela_1.Items.Item(4) = "Époux(se)"
            Select_friend_rela_1.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_1.Items.Item(6) = "Parent"
            Select_friend_rela_1.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_1.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_1.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_2.Items.Item(0) = "Inconnu"
            Select_friend_rela_2.Items.Item(1) = "Ami"
            Select_friend_rela_2.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_2.Items.Item(3) = "Ex"
            Select_friend_rela_2.Items.Item(4) = "Époux(se)"
            Select_friend_rela_2.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_2.Items.Item(6) = "Parent"
            Select_friend_rela_2.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_2.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_2.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_3.Items.Item(0) = "Inconnu"
            Select_friend_rela_3.Items.Item(1) = "Ami"
            Select_friend_rela_3.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_3.Items.Item(3) = "Ex"
            Select_friend_rela_3.Items.Item(4) = "Époux(se)"
            Select_friend_rela_3.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_3.Items.Item(6) = "Parent"
            Select_friend_rela_3.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_3.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_3.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_4.Items.Item(0) = "Inconnu"
            Select_friend_rela_4.Items.Item(1) = "Ami"
            Select_friend_rela_4.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_4.Items.Item(3) = "Ex"
            Select_friend_rela_4.Items.Item(4) = "Époux(se)"
            Select_friend_rela_4.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_4.Items.Item(6) = "Parent"
            Select_friend_rela_4.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_4.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_4.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_5.Items.Item(0) = "Inconnu"
            Select_friend_rela_5.Items.Item(1) = "Ami"
            Select_friend_rela_5.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_5.Items.Item(3) = "Ex"
            Select_friend_rela_5.Items.Item(4) = "Époux(se)"
            Select_friend_rela_5.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_5.Items.Item(6) = "Parent"
            Select_friend_rela_5.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_5.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_5.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_6.Items.Item(0) = "Inconnu"
            Select_friend_rela_6.Items.Item(1) = "Ami"
            Select_friend_rela_6.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_6.Items.Item(3) = "Ex"
            Select_friend_rela_6.Items.Item(4) = "Époux(se)"
            Select_friend_rela_6.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_6.Items.Item(6) = "Parent"
            Select_friend_rela_6.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_6.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_6.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_7.Items.Item(0) = "Inconnu"
            Select_friend_rela_7.Items.Item(1) = "Ami"
            Select_friend_rela_7.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_7.Items.Item(3) = "Ex"
            Select_friend_rela_7.Items.Item(4) = "Époux(se)"
            Select_friend_rela_7.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_7.Items.Item(6) = "Parent"
            Select_friend_rela_7.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_7.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_7.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_8.Items.Item(0) = "Inconnu"
            Select_friend_rela_8.Items.Item(1) = "Ami"
            Select_friend_rela_8.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_8.Items.Item(3) = "Ex"
            Select_friend_rela_8.Items.Item(4) = "Époux(se)"
            Select_friend_rela_8.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_8.Items.Item(6) = "Parent"
            Select_friend_rela_8.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_8.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_8.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_9.Items.Item(0) = "Inconnu"
            Select_friend_rela_9.Items.Item(1) = "Ami"
            Select_friend_rela_9.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_9.Items.Item(3) = "Ex"
            Select_friend_rela_9.Items.Item(4) = "Époux(se)"
            Select_friend_rela_9.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_9.Items.Item(6) = "Parent"
            Select_friend_rela_9.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_9.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_9.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_10.Items.Item(0) = "Inconnu"
            Select_friend_rela_10.Items.Item(1) = "Ami"
            Select_friend_rela_10.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_10.Items.Item(3) = "Ex"
            Select_friend_rela_10.Items.Item(4) = "Époux(se)"
            Select_friend_rela_10.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_10.Items.Item(6) = "Parent"
            Select_friend_rela_10.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_10.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_10.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_11.Items.Item(0) = "Inconnu"
            Select_friend_rela_11.Items.Item(1) = "Ami"
            Select_friend_rela_11.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_11.Items.Item(3) = "Ex"
            Select_friend_rela_11.Items.Item(4) = "Époux(se)"
            Select_friend_rela_11.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_11.Items.Item(6) = "Parent"
            Select_friend_rela_11.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_11.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_11.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_12.Items.Item(0) = "Inconnu"
            Select_friend_rela_12.Items.Item(1) = "Ami"
            Select_friend_rela_12.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_12.Items.Item(3) = "Ex"
            Select_friend_rela_12.Items.Item(4) = "Époux(se)"
            Select_friend_rela_12.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_12.Items.Item(6) = "Parent"
            Select_friend_rela_12.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_12.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_12.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_13.Items.Item(0) = "Inconnu"
            Select_friend_rela_13.Items.Item(1) = "Ami"
            Select_friend_rela_13.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_13.Items.Item(3) = "Ex"
            Select_friend_rela_13.Items.Item(4) = "Époux(se)"
            Select_friend_rela_13.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_13.Items.Item(6) = "Parent"
            Select_friend_rela_13.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_13.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_13.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_14.Items.Item(0) = "Inconnu"
            Select_friend_rela_14.Items.Item(1) = "Ami"
            Select_friend_rela_14.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_14.Items.Item(3) = "Ex"
            Select_friend_rela_14.Items.Item(4) = "Époux(se)"
            Select_friend_rela_14.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_14.Items.Item(6) = "Parent"
            Select_friend_rela_14.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_14.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_14.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_15.Items.Item(0) = "Inconnu"
            Select_friend_rela_15.Items.Item(1) = "Ami"
            Select_friend_rela_15.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_15.Items.Item(3) = "Ex"
            Select_friend_rela_15.Items.Item(4) = "Époux(se)"
            Select_friend_rela_15.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_15.Items.Item(6) = "Parent"
            Select_friend_rela_15.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_15.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_15.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_16.Items.Item(0) = "Inconnu"
            Select_friend_rela_16.Items.Item(1) = "Ami"
            Select_friend_rela_16.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_16.Items.Item(3) = "Ex"
            Select_friend_rela_16.Items.Item(4) = "Époux(se)"
            Select_friend_rela_16.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_16.Items.Item(6) = "Parent"
            Select_friend_rela_16.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_16.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_16.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_17.Items.Item(0) = "Inconnu"
            Select_friend_rela_17.Items.Item(1) = "Ami"
            Select_friend_rela_17.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_17.Items.Item(3) = "Ex"
            Select_friend_rela_17.Items.Item(4) = "Époux(se)"
            Select_friend_rela_17.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_17.Items.Item(6) = "Parent"
            Select_friend_rela_17.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_17.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_17.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_18.Items.Item(0) = "Inconnu"
            Select_friend_rela_18.Items.Item(1) = "Ami"
            Select_friend_rela_18.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_18.Items.Item(3) = "Ex"
            Select_friend_rela_18.Items.Item(4) = "Époux(se)"
            Select_friend_rela_18.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_18.Items.Item(6) = "Parent"
            Select_friend_rela_18.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_18.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_18.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_19.Items.Item(0) = "Inconnu"
            Select_friend_rela_19.Items.Item(1) = "Ami"
            Select_friend_rela_19.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_19.Items.Item(3) = "Ex"
            Select_friend_rela_19.Items.Item(4) = "Époux(se)"
            Select_friend_rela_19.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_19.Items.Item(6) = "Parent"
            Select_friend_rela_19.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_19.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_19.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_20.Items.Item(0) = "Inconnu"
            Select_friend_rela_20.Items.Item(1) = "Ami"
            Select_friend_rela_20.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_20.Items.Item(3) = "Ex"
            Select_friend_rela_20.Items.Item(4) = "Époux(se)"
            Select_friend_rela_20.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_20.Items.Item(6) = "Parent"
            Select_friend_rela_20.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_20.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_20.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_21.Items.Item(0) = "Inconnu"
            Select_friend_rela_21.Items.Item(1) = "Ami"
            Select_friend_rela_21.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_21.Items.Item(3) = "Ex"
            Select_friend_rela_21.Items.Item(4) = "Époux(se)"
            Select_friend_rela_21.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_21.Items.Item(6) = "Parent"
            Select_friend_rela_21.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_21.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_21.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_22.Items.Item(0) = "Inconnu"
            Select_friend_rela_22.Items.Item(1) = "Ami"
            Select_friend_rela_22.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_22.Items.Item(3) = "Ex"
            Select_friend_rela_22.Items.Item(4) = "Époux(se)"
            Select_friend_rela_22.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_22.Items.Item(6) = "Parent"
            Select_friend_rela_22.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_22.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_22.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_23.Items.Item(0) = "Inconnu"
            Select_friend_rela_23.Items.Item(1) = "Ami"
            Select_friend_rela_23.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_23.Items.Item(3) = "Ex"
            Select_friend_rela_23.Items.Item(4) = "Époux(se)"
            Select_friend_rela_23.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_23.Items.Item(6) = "Parent"
            Select_friend_rela_23.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_23.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_23.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_24.Items.Item(0) = "Inconnu"
            Select_friend_rela_24.Items.Item(1) = "Ami"
            Select_friend_rela_24.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_24.Items.Item(3) = "Ex"
            Select_friend_rela_24.Items.Item(4) = "Époux(se)"
            Select_friend_rela_24.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_24.Items.Item(6) = "Parent"
            Select_friend_rela_24.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_24.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_24.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_25.Items.Item(0) = "Inconnu"
            Select_friend_rela_25.Items.Item(1) = "Ami"
            Select_friend_rela_25.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_25.Items.Item(3) = "Ex"
            Select_friend_rela_25.Items.Item(4) = "Époux(se)"
            Select_friend_rela_25.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_25.Items.Item(6) = "Parent"
            Select_friend_rela_25.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_25.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_25.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_26.Items.Item(0) = "Inconnu"
            Select_friend_rela_26.Items.Item(1) = "Ami"
            Select_friend_rela_26.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_26.Items.Item(3) = "Ex"
            Select_friend_rela_26.Items.Item(4) = "Époux(se)"
            Select_friend_rela_26.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_26.Items.Item(6) = "Parent"
            Select_friend_rela_26.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_26.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_26.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_27.Items.Item(0) = "Inconnu"
            Select_friend_rela_27.Items.Item(1) = "Ami"
            Select_friend_rela_27.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_27.Items.Item(3) = "Ex"
            Select_friend_rela_27.Items.Item(4) = "Époux(se)"
            Select_friend_rela_27.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_27.Items.Item(6) = "Parent"
            Select_friend_rela_27.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_27.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_27.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_28.Items.Item(0) = "Inconnu"
            Select_friend_rela_28.Items.Item(1) = "Ami"
            Select_friend_rela_28.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_28.Items.Item(3) = "Ex"
            Select_friend_rela_28.Items.Item(4) = "Époux(se)"
            Select_friend_rela_28.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_28.Items.Item(6) = "Parent"
            Select_friend_rela_28.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_28.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_28.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_29.Items.Item(0) = "Inconnu"
            Select_friend_rela_29.Items.Item(1) = "Ami"
            Select_friend_rela_29.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_29.Items.Item(3) = "Ex"
            Select_friend_rela_29.Items.Item(4) = "Époux(se)"
            Select_friend_rela_29.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_29.Items.Item(6) = "Parent"
            Select_friend_rela_29.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_29.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_29.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_30.Items.Item(0) = "Inconnu"
            Select_friend_rela_30.Items.Item(1) = "Ami"
            Select_friend_rela_30.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_30.Items.Item(3) = "Ex"
            Select_friend_rela_30.Items.Item(4) = "Époux(se)"
            Select_friend_rela_30.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_30.Items.Item(6) = "Parent"
            Select_friend_rela_30.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_30.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_30.Items.Item(9) = "Meilleur(e) ami(e)"
        End If
    End Sub

    Private Sub Icon_appart_Click(sender As Object, e As EventArgs) Handles Icon_appart.Click
        If value_appart.Value < 2 Then
            value_appart.Value = value_appart.Value + 1
        ElseIf value_appart.Value = 2 Then
            value_appart.Value = 0
        End If
    End Sub

    Private Sub Icon_broc_Click(sender As Object, e As EventArgs) Handles Icon_broc.Click
        If value_broc.Value < 2 Then
            value_broc.Value = value_broc.Value + 1
        ElseIf value_broc.Value = 2 Then
            value_broc.Value = 0
        End If
    End Sub

    Private Sub Icon_cafe_Click(sender As Object, e As EventArgs) Handles Icon_cafe.Click
        If value_cafe.Value < 2 Then
            value_cafe.Value = value_cafe.Value + 1
        ElseIf value_cafe.Value = 2 Then
            value_cafe.Value = 0
        End If
    End Sub

    Private Sub Icon_chap_Click(sender As Object, e As EventArgs) Handles Icon_chap.Click
        If value_chap.Value < 2 Then
            value_chap.Value = value_chap.Value + 1
        ElseIf value_chap.Value = 2 Then
            value_chap.Value = 0
        End If
    End Sub

    Private Sub Icon_classem_Click(sender As Object, e As EventArgs) Handles Icon_classem.Click
        If value_classem.Value < 2 Then
            value_classem.Value = value_classem.Value + 1
        ElseIf value_classem.Value = 2 Then
            value_classem.Value = 0
        End If
    End Sub

    Private Sub Icon_conc_Click(sender As Object, e As EventArgs) Handles Icon_conc.Click
        If value_conc.Value < 2 Then
            value_conc.Value = value_conc.Value + 1
        ElseIf value_conc.Value = 2 Then
            value_conc.Value = 0
        End If
    End Sub

    Private Sub Icon_deco_Click(sender As Object, e As EventArgs) Handles Icon_deco.Click
        If value_deco.Value < 2 Then
            value_deco.Value = value_deco.Value + 1
        ElseIf value_deco.Value = 2 Then
            value_deco.Value = 0
        End If
    End Sub

    Private Sub Icon_epicer_Click(sender As Object, e As EventArgs) Handles Icon_epicer.Click
        If value_epicer.Value < 2 Then
            value_epicer.Value = value_epicer.Value + 1
        ElseIf value_epicer.Value = 2 Then
            value_epicer.Value = 0
        End If
    End Sub

    Private Sub Icon_font_Click(sender As Object, e As EventArgs) Handles Icon_font.Click
        If value_font.Value < 2 Then
            value_font.Value = value_font.Value + 1
        ElseIf value_font.Value = 2 Then
            value_font.Value = 0
        End If
    End Sub

    Private Sub Icon_info_Click(sender As Object, e As EventArgs) Handles Icon_info.Click
        If value_info.Value < 2 Then
            value_info.Value = value_info.Value + 1
        ElseIf value_info.Value = 2 Then
            value_info.Value = 0
        End If
    End Sub

    Private Sub Icon_magimport_Click(sender As Object, e As EventArgs) Handles Icon_magimport.Click
        If value_magimport.Value < 2 Then
            value_magimport.Value = value_magimport.Value + 1
        ElseIf value_magimport.Value = 2 Then
            value_magimport.Value = 0
        End If
    End Sub

    Private Sub Icon_mair_Click(sender As Object, e As EventArgs) Handles Icon_mair.Click
        If value_mair.Value < 2 Then
            value_mair.Value = value_mair.Value + 1
        ElseIf value_mair.Value = 2 Then
            value_mair.Value = 0
        End If
    End Sub

    Private Sub Icon_mais_Click(sender As Object, e As EventArgs) Handles Icon_mais.Click
        If value_mais.Value < 2 Then
            value_mais.Value = value_mais.Value + 1
        ElseIf value_mais.Value = 2 Then
            value_mais.Value = 0
        End If
    End Sub

    Private Sub Icon_parc_Click(sender As Object, e As EventArgs) Handles Icon_parc.Click
        If value_parc.Value < 2 Then
            value_parc.Value = value_parc.Value + 1
        ElseIf value_parc.Value = 2 Then
            value_parc.Value = 0
        End If
    End Sub

    Private Sub Icon_parc1_Click(sender As Object, e As EventArgs) Handles Icon_parc1.Click
        If value_parc1.Value < 2 Then
            value_parc1.Value = value_parc1.Value + 1
        ElseIf value_parc1.Value = 2 Then
            value_parc1.Value = 0
        End If
    End Sub

    Private Sub Icon_part_Click(sender As Object, e As EventArgs) Handles Icon_part.Click
        If value_part.Value < 2 Then
            value_part.Value = value_part.Value + 1
        ElseIf value_part.Value = 2 Then
            value_part.Value = 0
        End If
    End Sub

    Private Sub Icon_plage_Click(sender As Object, e As EventArgs) Handles Icon_plage.Click
        If value_plage.Value < 2 Then
            value_plage.Value = value_plage.Value + 1
        ElseIf value_plage.Value = 2 Then
            value_plage.Value = 0
        End If
    End Sub

    Private Sub Icon_port_Click(sender As Object, e As EventArgs) Handles Icon_port.Click
        If value_port.Value < 2 Then
            value_port.Value = value_port.Value + 1
        ElseIf value_port.Value = 2 Then
            value_port.Value = 0
        End If
    End Sub

    Private Sub Icon_stud_Click(sender As Object, e As EventArgs) Handles Icon_stud.Click
        If value_stud.Value < 2 Then
            value_stud.Value = value_stud.Value + 1
        ElseIf value_stud.Value = 2 Then
            value_stud.Value = 0
        End If
    End Sub

    Private Sub Icon_tervague_Click(sender As Object, e As EventArgs) Handles Icon_tervague.Click
        If value_tervague.Value < 2 Then
            value_tervague.Value = value_tervague.Value + 1
        ElseIf value_tervague.Value = 2 Then
            value_tervague.Value = 0
        End If
    End Sub

    Private Sub Icon_test_Click(sender As Object, e As EventArgs) Handles Icon_test.Click
        If value_test.Value < 2 Then
            value_test.Value = value_test.Value + 1
        ElseIf value_test.Value = 2 Then
            value_test.Value = 0
        End If
    End Sub

    Private Sub Icon_tour_Click(sender As Object, e As EventArgs) Handles Icon_tour.Click
        If value_tour.Value < 2 Then
            value_tour.Value = value_tour.Value + 1
        ElseIf value_tour.Value = 2 Then
            value_tour.Value = 0
        End If
    End Sub

    Private Sub Icon_vetem_Click(sender As Object, e As EventArgs) Handles Icon_vetem.Click
        If value_vetem.Value < 2 Then
            value_vetem.Value = value_vetem.Value + 1
        ElseIf value_vetem.Value = 2 Then
            value_vetem.Value = 0
        End If
    End Sub

    Private Sub value_appart_ValueChanged(sender As Object, e As EventArgs) Handles value_appart.ValueChanged
        If value_appart.Value = 0 Then
            Icon_appart.Image = Nothing
        ElseIf value_appart.Value = 1 Then
            Icon_appart.Image = My.Resources.appart
        ElseIf value_appart.Value = 2 Then
            Icon_appart.Image = My.Resources.appartn
        End If
    End Sub

    Private Sub value_broc_ValueChanged(sender As Object, e As EventArgs) Handles value_broc.ValueChanged
        If value_broc.Value = 0 Then
            Icon_broc.Image = Nothing
        ElseIf value_broc.Value = 1 Then
            Icon_broc.Image = My.Resources.broc
        ElseIf value_broc.Value = 2 Then
            Icon_broc.Image = My.Resources.brocn
        End If
    End Sub

    Private Sub value_cafe_ValueChanged(sender As Object, e As EventArgs) Handles value_cafe.ValueChanged
        If value_cafe.Value = 0 Then
            Icon_cafe.Image = Nothing
        ElseIf value_cafe.Value = 1 Then
            Icon_cafe.Image = My.Resources.cafe
        ElseIf value_cafe.Value = 2 Then
            Icon_cafe.Image = My.Resources.cafen
        End If
    End Sub

    Private Sub value_chap_ValueChanged(sender As Object, e As EventArgs) Handles value_chap.ValueChanged
        If value_chap.Value = 0 Then
            Icon_chap.Image = Nothing
        ElseIf value_chap.Value = 1 Then
            Icon_chap.Image = My.Resources.chap
        ElseIf value_chap.Value = 2 Then
            Icon_chap.Image = My.Resources.chapn
        End If
    End Sub

    Private Sub value_classem_ValueChanged(sender As Object, e As EventArgs) Handles value_classem.ValueChanged
        If value_classem.Value = 0 Then
            Icon_classem.Image = Nothing
        ElseIf value_classem.Value = 1 Then
            Icon_classem.Image = My.Resources.classem
        ElseIf value_classem.Value = 2 Then
            Icon_classem.Image = My.Resources.classn
        End If
    End Sub

    Private Sub value_conc_ValueChanged(sender As Object, e As EventArgs) Handles value_conc.ValueChanged
        If value_conc.Value = 0 Then
            Icon_conc.Image = Nothing
        ElseIf value_conc.Value = 1 Then
            Icon_conc.Image = My.Resources.conc
        ElseIf value_conc.Value = 2 Then
            Icon_conc.Image = My.Resources.concn
        End If
    End Sub

    Private Sub value_deco_ValueChanged(sender As Object, e As EventArgs) Handles value_deco.ValueChanged
        If value_deco.Value = 0 Then
            Icon_deco.Image = Nothing
        ElseIf value_deco.Value = 1 Then
            Icon_deco.Image = My.Resources.deco
        ElseIf value_deco.Value = 2 Then
            Icon_deco.Image = My.Resources.decon
        End If
    End Sub

    Private Sub value_epicer_ValueChanged(sender As Object, e As EventArgs) Handles value_epicer.ValueChanged
        If value_epicer.Value = 0 Then
            Icon_epicer.Image = Nothing
        ElseIf value_epicer.Value = 1 Then
            Icon_epicer.Image = My.Resources.epicer
        ElseIf value_epicer.Value = 2 Then
            Icon_epicer.Image = My.Resources.epicern
        End If
    End Sub

    Private Sub value_font_ValueChanged(sender As Object, e As EventArgs) Handles value_font.ValueChanged
        If value_font.Value = 0 Then
            Icon_font.Image = Nothing
        ElseIf value_font.Value = 1 Then
            Icon_font.Image = My.Resources.font
        ElseIf value_font.Value = 2 Then
            Icon_font.Image = My.Resources.fontn
        End If
    End Sub

    Private Sub value_info_ValueChanged(sender As Object, e As EventArgs) Handles value_info.ValueChanged
        If value_info.Value = 0 Then
            Icon_info.Image = Nothing
        ElseIf value_info.Value = 1 Then
            Icon_info.Image = My.Resources.info
        ElseIf value_info.Value = 2 Then
            Icon_info.Image = My.Resources.infon
        End If
    End Sub

    Private Sub value_magimport_ValueChanged(sender As Object, e As EventArgs) Handles value_magimport.ValueChanged
        If value_magimport.Value = 0 Then
            Icon_magimport.Image = Nothing
        ElseIf value_magimport.Value = 1 Then
            Icon_magimport.Image = My.Resources.magimport
        ElseIf value_magimport.Value = 2 Then
            Icon_magimport.Image = My.Resources.magimportn
        End If
    End Sub

    Private Sub value_mair_ValueChanged(sender As Object, e As EventArgs) Handles value_mair.ValueChanged
        If value_mair.Value = 0 Then
            Icon_mair.Image = Nothing
        ElseIf value_mair.Value = 1 Then
            Icon_mair.Image = My.Resources.mair
        ElseIf value_mair.Value = 2 Then
            Icon_mair.Image = My.Resources.mairn
        End If
    End Sub

    Private Sub value_mais_ValueChanged(sender As Object, e As EventArgs) Handles value_mais.ValueChanged
        If value_mais.Value = 0 Then
            Icon_mais.Image = Nothing
        ElseIf value_mais.Value = 1 Then
            Icon_mais.Image = My.Resources.mais
        ElseIf value_mais.Value = 2 Then
            Icon_mais.Image = My.Resources.maisn
        End If
    End Sub

    Private Sub value_parc_ValueChanged(sender As Object, e As EventArgs) Handles value_parc.ValueChanged
        If value_parc.Value = 0 Then
            Icon_parc.Image = Nothing
        ElseIf value_parc.Value = 1 Then
            Icon_parc.Image = My.Resources.parc
        ElseIf value_parc.Value = 2 Then
            Icon_parc.Image = My.Resources.parcn
        End If
    End Sub

    Private Sub value_parc1_ValueChanged(sender As Object, e As EventArgs) Handles value_parc1.ValueChanged
        If value_parc1.Value = 0 Then
            Icon_parc1.Image = Nothing
        ElseIf value_parc1.Value = 1 Then
            Icon_parc1.Image = My.Resources.parc1
        ElseIf value_parc1.Value = 2 Then
            Icon_parc1.Image = My.Resources.parc1n
        End If
    End Sub

    Private Sub value_part_ValueChanged(sender As Object, e As EventArgs) Handles value_part.ValueChanged
        If value_part.Value = 0 Then
            Icon_part.Image = Nothing
        ElseIf value_part.Value = 1 Then
            Icon_part.Image = My.Resources.part
        ElseIf value_part.Value = 2 Then
            Icon_part.Image = My.Resources.partn
        End If
    End Sub

    Private Sub value_plage_ValueChanged(sender As Object, e As EventArgs) Handles value_plage.ValueChanged
        If value_plage.Value = 0 Then
            Icon_plage.Image = Nothing
        ElseIf value_plage.Value = 1 Then
            Icon_plage.Image = My.Resources.plage
        ElseIf value_plage.Value = 2 Then
            Icon_plage.Image = My.Resources.plagen
        End If
    End Sub

    Private Sub value_port_ValueChanged(sender As Object, e As EventArgs) Handles value_port.ValueChanged
        If value_port.Value = 0 Then
            Icon_port.Image = Nothing
        ElseIf value_port.Value = 1 Then
            Icon_port.Image = My.Resources.port
        ElseIf value_port.Value = 2 Then
            Icon_port.Image = My.Resources.portn
        End If
    End Sub

    Private Sub value_stud_ValueChanged(sender As Object, e As EventArgs) Handles value_stud.ValueChanged
        If value_stud.Value = 0 Then
            Icon_stud.Image = Nothing
        ElseIf value_stud.Value = 1 Then
            Icon_stud.Image = My.Resources.stud
        ElseIf value_stud.Value = 2 Then
            Icon_stud.Image = My.Resources.studn
        End If
    End Sub

    Private Sub value_tervague_ValueChanged(sender As Object, e As EventArgs) Handles value_tervague.ValueChanged
        If value_tervague.Value = 0 Then
            Icon_tervague.Image = Nothing
        ElseIf value_tervague.Value = 1 Then
            Icon_tervague.Image = My.Resources.tervague
        ElseIf value_tervague.Value = 2 Then
            Icon_tervague.Image = My.Resources.tervaguen
        End If
    End Sub

    Private Sub value_test_ValueChanged(sender As Object, e As EventArgs) Handles value_test.ValueChanged
        If value_test.Value = 0 Then
            Icon_test.Image = Nothing
        ElseIf value_test.Value = 1 Then
            Icon_test.Image = My.Resources.test
        ElseIf value_test.Value = 2 Then
            Icon_test.Image = My.Resources.testn
        End If
    End Sub

    Private Sub value_tour_ValueChanged(sender As Object, e As EventArgs) Handles value_tour.ValueChanged
        If value_tour.Value = 0 Then
            Icon_tour.Image = Nothing
        ElseIf value_tour.Value = 1 Then
            Icon_tour.Image = My.Resources.tour
        ElseIf value_tour.Value = 2 Then
            Icon_tour.Image = My.Resources.tourn
        End If
    End Sub

    Private Sub value_vetem_ValueChanged(sender As Object, e As EventArgs) Handles value_vetem.ValueChanged
        If value_vetem.Value = 0 Then
            Icon_vetem.Image = Nothing
        ElseIf value_vetem.Value = 1 Then
            Icon_vetem.Image = My.Resources.vet
        ElseIf value_vetem.Value = 2 Then
            Icon_vetem.Image = My.Resources.vetn
        End If
    End Sub

    Private Sub Menu_width_Click(sender As Object, e As EventArgs) Handles Menu_width.Click
        If Menu_panel.Width = 34 Then
            Menu_panel.Width = 150
            Menu_width.Location = New Point(116, 0)
        Else
            Menu_panel.Width = 34
            Menu_width.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub TL_SaveEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select_language.SelectedItem = Select_language.Items.Item(0)
        Select_music.SelectedItem = Select_music.Items.Item(0)
        Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(0)
        Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(0)
        Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(0)
        Try
            Setting_ckupdate.Checked = My.Settings.Parasetting_ckupdate
            Setting_filepath.Checked = My.Settings.Parasetting_filepath
            Setting_hidden.Checked = My.Settings.Parasetting_hidden
            Select_language.SelectedItem = My.Settings.Parasetting_language
            Menu_panel.Width = My.Settings.Parasetting_menu
            Setting_music.Checked = My.Settings.Parasetting_music
            Select_music.SelectedItem = My.Settings.Parasetting_musicsel
            Filever_text.Text = My.Settings.Parasetting_filever
            If Filever_text.Text = "US" Then
                Filever_text.Text = "KR"
            ElseIf Filever_text.Text = "EU" Then
                Filever_text.Text = "US"
            ElseIf Filever_text.Text = "JP" Then
                Filever_text.Text = "EU"
            ElseIf Filever_text.Text = "KR" Then
                Filever_text.Text = "JP"
            End If
            switchfilever()
        Catch ex As Exception
        End Try
        If Menu_panel.Width = 150 Then
            Menu_width.Location = New Point(116, 0)
        ElseIf Menu_panel.Width = 34 Then
            Menu_width.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub TL_SaveEditor_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.Parasetting_ckupdate = Setting_ckupdate.Checked
        My.Settings.Parasetting_filepath = Setting_filepath.Checked
        My.Settings.Parasetting_hidden = Setting_hidden.Checked
        My.Settings.Parasetting_language = Select_language.SelectedItem
        My.Settings.Parasetting_menu = Menu_panel.Width
        My.Settings.Parasetting_music = Setting_music.Checked
        My.Settings.Parasetting_musicsel = Select_music.SelectedItem
        My.Settings.Parasetting_filever = Filever_text.Text
    End Sub

    Private Sub Setting_hidden_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_hidden.CheckedChanged
        If Setting_hidden.Checked = True Then
            Hidden_things.Visible = True
            value_appartrenov.Visible = True
            value_eventfountain.Visible = True
            value_appart.Visible = True
            value_broc.Visible = True
            value_cafe.Visible = True
            value_chap.Visible = True
            value_classem.Visible = True
            value_conc.Visible = True
            value_deco.Visible = True
            value_epicer.Visible = True
            value_font.Visible = True
            value_info.Visible = True
            value_magimport.Visible = True
            value_mair.Visible = True
            value_mais.Visible = True
            value_parc.Visible = True
            value_parc1.Visible = True
            value_part.Visible = True
            value_plage.Visible = True
            value_port.Visible = True
            value_stud.Visible = True
            value_tervague.Visible = True
            value_test.Visible = True
            value_tour.Visible = True
            value_vetem.Visible = True
            valu_allmusic.Visible = True
            valu_sharing.Visible = True
            valu_copying.Visible = True
            valu_favcolor.Visible = True
            valu_growkid.Visible = True
            valu_haircolor.Visible = True
            valu_miiapart.Visible = True
            valu_experience.Visible = True
            valu_chkfullness.Visible = True
            valu_fullness.Visible = True
            valu_itemmii_1.Visible = True
            valu_itemmii_2.Visible = True
            valu_itemmii_3.Visible = True
            valu_itemmii_4.Visible = True
            valu_itemmii_5.Visible = True
            valu_itemmii_6.Visible = True
            valu_itemmii_7.Visible = True
            valu_itemmii_8.Visible = True
            valu_target1.Visible = True
            valu_target2.Visible = True
            Text_interaction.Visible = True
            valu_emotions.Visible = True
            valu_selfriend_rela_1.Visible = True
            valu_selfriend_rela_2.Visible = True
            valu_selfriend_rela_3.Visible = True
            valu_selfriend_rela_4.Visible = True
            valu_selfriend_rela_5.Visible = True
            valu_selfriend_rela_6.Visible = True
            valu_selfriend_rela_7.Visible = True
            valu_selfriend_rela_8.Visible = True
            valu_selfriend_rela_9.Visible = True
            valu_selfriend_rela_10.Visible = True
            valu_selfriend_rela_11.Visible = True
            valu_selfriend_rela_12.Visible = True
            valu_selfriend_rela_13.Visible = True
            valu_selfriend_rela_14.Visible = True
            valu_selfriend_rela_15.Visible = True
            valu_selfriend_rela_16.Visible = True
            valu_selfriend_rela_17.Visible = True
            valu_selfriend_rela_18.Visible = True
            valu_selfriend_rela_19.Visible = True
            valu_selfriend_rela_20.Visible = True
            valu_selfriend_rela_21.Visible = True
            valu_selfriend_rela_22.Visible = True
            valu_selfriend_rela_23.Visible = True
            valu_selfriend_rela_24.Visible = True
            valu_selfriend_rela_25.Visible = True
            valu_selfriend_rela_26.Visible = True
            valu_selfriend_rela_27.Visible = True
            valu_selfriend_rela_28.Visible = True
            valu_selfriend_rela_29.Visible = True
            valu_selfriend_rela_30.Visible = True
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
                Select_allfav_1.Visible = False
                Select_allfav_2.Visible = False
                Select_fav_1.Visible = False
                Select_fav_2.Visible = False
                Select_fav_3.Visible = False
                Select_worst_1.Visible = False
                Select_worst_2.Visible = False
            End If
        Else
            Hidden_things.Visible = False
            value_appartrenov.Visible = False
            value_eventfountain.Visible = False
            value_appart.Visible = False
            value_broc.Visible = False
            value_cafe.Visible = False
            value_chap.Visible = False
            value_classem.Visible = False
            value_conc.Visible = False
            value_deco.Visible = False
            value_epicer.Visible = False
            value_font.Visible = False
            value_info.Visible = False
            value_magimport.Visible = False
            value_mair.Visible = False
            value_mais.Visible = False
            value_parc.Visible = False
            value_parc1.Visible = False
            value_part.Visible = False
            value_plage.Visible = False
            value_port.Visible = False
            value_stud.Visible = False
            value_tervague.Visible = False
            value_test.Visible = False
            value_tour.Visible = False
            value_vetem.Visible = False
            valu_allmusic.Visible = False
            valu_sharing.Visible = False
            valu_copying.Visible = False
            valu_favcolor.Visible = False
            valu_growkid.Visible = False
            valu_haircolor.Visible = False
            valu_miiapart.Visible = False
            valu_experience.Visible = False
            valu_chkfullness.Visible = False
            valu_fullness.Visible = False
            valu_itemmii_1.Visible = False
            valu_itemmii_2.Visible = False
            valu_itemmii_3.Visible = False
            valu_itemmii_4.Visible = False
            valu_itemmii_5.Visible = False
            valu_itemmii_6.Visible = False
            valu_itemmii_7.Visible = False
            valu_itemmii_8.Visible = False
            valu_target1.Visible = False
            valu_target2.Visible = False
            Text_interaction.Visible = False
            valu_emotions.Visible = False
            valu_selfriend_rela_1.Visible = False
            valu_selfriend_rela_2.Visible = False
            valu_selfriend_rela_3.Visible = False
            valu_selfriend_rela_4.Visible = False
            valu_selfriend_rela_5.Visible = False
            valu_selfriend_rela_6.Visible = False
            valu_selfriend_rela_7.Visible = False
            valu_selfriend_rela_8.Visible = False
            valu_selfriend_rela_9.Visible = False
            valu_selfriend_rela_10.Visible = False
            valu_selfriend_rela_11.Visible = False
            valu_selfriend_rela_12.Visible = False
            valu_selfriend_rela_13.Visible = False
            valu_selfriend_rela_14.Visible = False
            valu_selfriend_rela_15.Visible = False
            valu_selfriend_rela_16.Visible = False
            valu_selfriend_rela_17.Visible = False
            valu_selfriend_rela_18.Visible = False
            valu_selfriend_rela_19.Visible = False
            valu_selfriend_rela_20.Visible = False
            valu_selfriend_rela_21.Visible = False
            valu_selfriend_rela_22.Visible = False
            valu_selfriend_rela_23.Visible = False
            valu_selfriend_rela_24.Visible = False
            valu_selfriend_rela_25.Visible = False
            valu_selfriend_rela_26.Visible = False
            valu_selfriend_rela_27.Visible = False
            valu_selfriend_rela_28.Visible = False
            valu_selfriend_rela_29.Visible = False
            valu_selfriend_rela_30.Visible = False
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
                Select_allfav_1.Visible = True
                Select_allfav_2.Visible = True
                Select_fav_1.Visible = True
                Select_fav_2.Visible = True
                Select_fav_3.Visible = True
                Select_worst_1.Visible = True
                Select_worst_2.Visible = True
            End If
        End If
    End Sub

    Private Sub Setting_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_filepath.CheckedChanged
        If Setting_filepath.Checked = True Then
            File_path.Visible = True
        Else
            File_path.Visible = False
        End If
    End Sub

    Private Sub Icon_miiedit_music_Click(sender As Object, e As EventArgs) Handles Icon_miiedit_music.Click
        Panel_cathphrase.Visible = False
        Panel_mii_musics.Visible = True
        Panel_mii_inventory.Visible = False
    End Sub

    Private Sub Icon_cathphrase_Click(sender As Object, e As EventArgs) Handles Icon_cathphrase.Click
        Panel_cathphrase.Visible = True
        Panel_mii_musics.Visible = False
        Panel_mii_inventory.Visible = False
    End Sub

    Private Sub Icon_inventory_Click(sender As Object, e As EventArgs) Handles Icon_inventory.Click
        Panel_cathphrase.Visible = False
        Panel_mii_musics.Visible = False
        Panel_mii_inventory.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.Click
        Text_edit_firstname.Text = Text_pronun_firstname.Text
        Panel_edit_firstname.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.MouseMove
        Text_pronun_firstname.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit first name pronunciation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la prononciation du prénom"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.MouseLeave
        Text_pronun_firstname.Visible = False
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_valid_firstname_Click(sender As Object, e As EventArgs) Handles Icon_valid_firstname.Click
        Text_pronun_firstname.Text = Text_edit_firstname.Text
        Panel_edit_firstname.Visible = False
    End Sub

    Private Sub Icon_pronun_lastname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.Click
        Text_edit_lastname.Text = Text_pronun_lastname.Text
        Panel_edit_lastname.Visible = True
    End Sub

    Private Sub Icon_pronun_lastname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.MouseMove
        Text_pronun_lastname.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit last name pronunciation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la prononciation du nom"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_lastname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.MouseLeave
        Text_pronun_lastname.Visible = False
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_valid_lastname_Click(sender As Object, e As EventArgs) Handles Icon_valid_lastname.Click
        Text_pronun_lastname.Text = Text_edit_lastname.Text
        Panel_edit_lastname.Visible = False
    End Sub

    Private Sub Icon_pronun_nickname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.MouseMove
        Text_pronun_nickname.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Nickname pronunciation can't be edited"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Le surnom ne peut être édité"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_nickname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.MouseLeave
        Text_pronun_nickname.Visible = False
        Panel_description.Visible = False
    End Sub

    Private Sub Button_close_hcoloredit_Click(sender As Object, e As EventArgs) Handles Button_close_hcoloredit.Click
        Panel_edit_haircolor.Visible = False
    End Sub

    Private Sub Icon_haircolor_Click(sender As Object, e As EventArgs) Handles Icon_haircolor.Click
        Panel_edit_haircolor.Visible = True
    End Sub

    Private Sub Icon_haircolor_MouseMove(sender As Object, e As EventArgs) Handles Icon_haircolor.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit hair color"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la couleur des cheveux"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_haircolor_MouseLeave(sender As Object, e As EventArgs) Handles Icon_haircolor.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub color_1_Click(sender As Object, e As EventArgs) Handles color_1.Click
        unselectcolor()
        color_1.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 128
    End Sub

    Private Sub color_2_Click(sender As Object, e As EventArgs) Handles color_2.Click
        unselectcolor()
        color_2.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 130
    End Sub

    Private Sub color_3_Click(sender As Object, e As EventArgs) Handles color_3.Click
        unselectcolor()
        color_3.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 132
    End Sub

    Private Sub color_4_Click(sender As Object, e As EventArgs) Handles color_4.Click
        unselectcolor()
        color_4.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 134
    End Sub

    Private Sub color_5_Click(sender As Object, e As EventArgs) Handles color_5.Click
        unselectcolor()
        color_5.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 136
    End Sub

    Private Sub color_6_Click(sender As Object, e As EventArgs) Handles color_6.Click
        unselectcolor()
        color_6.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 138
    End Sub

    Private Sub color_7_Click(sender As Object, e As EventArgs) Handles color_7.Click
        unselectcolor()
        color_7.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 140
    End Sub

    Private Sub color_8_Click(sender As Object, e As EventArgs) Handles color_8.Click
        unselectcolor()
        color_8.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 142
    End Sub

    Private Sub color_9_Click(sender As Object, e As EventArgs) Handles color_9.Click
        unselectcolor()
        color_9.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 144
    End Sub

    Private Sub color_10_Click(sender As Object, e As EventArgs) Handles color_10.Click
        unselectcolor()
        color_10.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 146
    End Sub

    Private Sub color_11_Click(sender As Object, e As EventArgs) Handles color_11.Click
        unselectcolor()
        color_11.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 148
    End Sub

    Private Sub color_12_Click(sender As Object, e As EventArgs) Handles color_12.Click
        unselectcolor()
        color_12.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 150
    End Sub

    Private Sub color_13_Click(sender As Object, e As EventArgs) Handles color_13.Click
        unselectcolor()
        color_13.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 152
    End Sub

    Private Sub color_14_Click(sender As Object, e As EventArgs) Handles color_14.Click
        unselectcolor()
        color_14.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 154
    End Sub

    Private Sub color_15_Click(sender As Object, e As EventArgs) Handles color_15.Click
        unselectcolor()
        color_15.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 156
    End Sub

    Private Sub color_16_Click(sender As Object, e As EventArgs) Handles color_16.Click
        unselectcolor()
        color_16.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 158
    End Sub

    Private Sub color_17_Click(sender As Object, e As EventArgs) Handles color_17.Click
        unselectcolor()
        color_17.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 160
    End Sub

    Private Sub color_18_Click(sender As Object, e As EventArgs) Handles color_18.Click
        unselectcolor()
        color_18.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 162
    End Sub

    Private Sub color_19_Click(sender As Object, e As EventArgs) Handles color_19.Click
        unselectcolor()
        color_19.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 164
    End Sub

    Private Sub color_20_Click(sender As Object, e As EventArgs) Handles color_20.Click
        unselectcolor()
        color_20.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 166
    End Sub

    Private Sub color_21_Click(sender As Object, e As EventArgs) Handles color_21.Click
        unselectcolor()
        color_21.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 168
    End Sub

    Private Sub color_22_Click(sender As Object, e As EventArgs) Handles color_22.Click
        unselectcolor()
        color_22.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 170
    End Sub

    Private Sub color_23_Click(sender As Object, e As EventArgs) Handles color_23.Click
        unselectcolor()
        color_23.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 172
    End Sub

    Private Sub color_24_Click(sender As Object, e As EventArgs) Handles color_24.Click
        unselectcolor()
        color_24.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 174
    End Sub

    Private Sub color_25_Click(sender As Object, e As EventArgs) Handles color_25.Click
        unselectcolor()
        color_25.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 176
    End Sub

    Private Sub color_26_Click(sender As Object, e As EventArgs) Handles color_26.Click
        unselectcolor()
        color_26.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 178
    End Sub

    Private Sub color_27_Click(sender As Object, e As EventArgs) Handles color_27.Click
        unselectcolor()
        color_27.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 180
    End Sub

    Private Sub color_28_Click(sender As Object, e As EventArgs) Handles color_28.Click
        unselectcolor()
        color_28.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 182
    End Sub

    Private Sub color_29_Click(sender As Object, e As EventArgs) Handles color_29.Click
        unselectcolor()
        color_29.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 184
    End Sub

    Private Sub color_30_Click(sender As Object, e As EventArgs) Handles color_30.Click
        unselectcolor()
        color_30.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 186
    End Sub

    Private Sub color_31_Click(sender As Object, e As EventArgs) Handles color_31.Click
        unselectcolor()
        color_31.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 188
    End Sub

    Private Sub color_32_Click(sender As Object, e As EventArgs) Handles color_32.Click
        unselectcolor()
        color_32.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 190
    End Sub

    Private Sub color_empty_Click(sender As Object, e As EventArgs) Handles color_empty.Click
        unselectcolor()
        color_empty.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 1
    End Sub

    Private Sub valu_haircolor_ValueChanged(sender As Object, e As EventArgs) Handles valu_haircolor.ValueChanged
        Select Case valu_haircolor.Value
            Case 128, 129
                Icon_haircolor.Image = My.Resources.HC80
            Case 130, 131
                Icon_haircolor.Image = My.Resources.HC82
            Case 132, 133
                Icon_haircolor.Image = My.Resources.HC84
            Case 134, 135
                Icon_haircolor.Image = My.Resources.HC86
            Case 136, 137
                Icon_haircolor.Image = My.Resources.HC88
            Case 138, 139
                Icon_haircolor.Image = My.Resources.HC8A
            Case 140, 141
                Icon_haircolor.Image = My.Resources.HC8C
            Case 142, 143
                Icon_haircolor.Image = My.Resources.HC8E
            Case 144, 145
                Icon_haircolor.Image = My.Resources.HC90
            Case 146, 147
                Icon_haircolor.Image = My.Resources.HC92
            Case 148, 149
                Icon_haircolor.Image = My.Resources.HC94
            Case 150, 151
                Icon_haircolor.Image = My.Resources.HC96
            Case 152, 153
                Icon_haircolor.Image = My.Resources.HC98
            Case 154, 155
                Icon_haircolor.Image = My.Resources.HC9A
            Case 156, 157
                Icon_haircolor.Image = My.Resources.HC9C
            Case 158, 159
                Icon_haircolor.Image = My.Resources.HC9E
            Case 160, 161
                Icon_haircolor.Image = My.Resources.HCA0
            Case 162, 163
                Icon_haircolor.Image = My.Resources.HCA2
            Case 164, 165
                Icon_haircolor.Image = My.Resources.HCA4
            Case 166, 167
                Icon_haircolor.Image = My.Resources.HCA6
            Case 168, 169
                Icon_haircolor.Image = My.Resources.HCA8
            Case 170, 171
                Icon_haircolor.Image = My.Resources.HCAA
            Case 172, 173
                Icon_haircolor.Image = My.Resources.HCAC
            Case 174, 175
                Icon_haircolor.Image = My.Resources.HCAE
            Case 176, 177
                Icon_haircolor.Image = My.Resources.HCB0
            Case 178, 179
                Icon_haircolor.Image = My.Resources.HCB2
            Case 180, 181
                Icon_haircolor.Image = My.Resources.HCB4
            Case 182, 183
                Icon_haircolor.Image = My.Resources.HCB6
            Case 184, 185
                Icon_haircolor.Image = My.Resources.HCB8
            Case 186, 187
                Icon_haircolor.Image = My.Resources.HCBA
            Case 188, 189
                Icon_haircolor.Image = My.Resources.HCBC
            Case 190, 191
                Icon_haircolor.Image = My.Resources.HCBE
            Case Else
                Icon_haircolor.Image = My.Resources.HCdefault
        End Select
    End Sub

    Private Sub Icon_fullness_Click(sender As Object, e As EventArgs) Handles Icon_fullness.Click
        Panel_edit_fullness.Visible = True
    End Sub

    Private Sub Icon_edit_full_00_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_00.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 0
    End Sub

    Private Sub Icon_edit_full_25_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_25.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 25
    End Sub

    Private Sub Icon_edit_full_50_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_50.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 50
    End Sub

    Private Sub Icon_edit_full_100_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_100.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 100
    End Sub

    Private Sub valu_fullness_ValueChanged(sender As Object, e As EventArgs) Handles valu_fullness.ValueChanged
        If valu_fullness.Value = 0 Then
            Icon_fullness.Image = My.Resources.fullness_00
        ElseIf valu_fullness.Value = 25 Then
            Icon_fullness.Image = My.Resources.fullness_25
        ElseIf valu_fullness.Value = 50 Then
            Icon_fullness.Image = My.Resources.fullness_50
        ElseIf valu_fullness.Value = 100 Then
            Icon_fullness.Image = My.Resources.fullness_100
        End If
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        veriffilever()
        Dim open As New OpenFileDialog
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Text_fdialog.Text = "Open savedataArc.txt" & vbNewLine & "Tomodachi Life Save Editor will make a backup of your save file, check ''bak'' folder" & vbNewLine & vbNewLine & "Make sure you have choose right save file version"
            fdialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Text_fdialog.Text = "Ouvrir savedataArc.txt" & vbNewLine & "Tomodachi Life Save Editor va faire une copie de votre sauvegarde, vérifiez le dossier ''bak''" & vbNewLine & vbNewLine & "Soyez sûr d'avoir choisi la bonne version de sauvegarde"
            fdialog.ShowDialog()
        End If
        Stopveriffilever()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            open.Filter = "Text files|*.txt"
            open.Title = "Open save savedataArc.txt"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            open.Filter = "Fichiers texte|*.txt"
            open.Title = "Ouvrir la sauvegarde savedataArc.txt"
        End If
        open.ShowDialog()
        savedataArc = open.FileName
        TextBox_fpath.Text = savedataArc
        readsavedataArc()
        makebak()
    End Sub

    Private Sub valu_experience_ValueChanged(sender As Object, e As EventArgs) Handles valu_experience.ValueChanged
        valu_exp.Value = valu_experience.Value
        If valu_experience.Value = 0 Then
            Icon_experience.Image = My.Resources.exp0
        End If
        If valu_experience.Value = 1 Then
            Icon_experience.Image = My.Resources.exp1
        End If
        If valu_experience.Value = 2 Then
            Icon_experience.Image = My.Resources.exp2
        End If
        If valu_experience.Value = 3 Then
            Icon_experience.Image = My.Resources.exp3
        End If
        If valu_experience.Value = 4 Then
            Icon_experience.Image = My.Resources.exp4
        End If
        If valu_experience.Value = 5 Then
            Icon_experience.Image = My.Resources.exp5
        End If
        If valu_experience.Value = 6 Then
            Icon_experience.Image = My.Resources.exp6
        End If
        If valu_experience.Value = 7 Then
            Icon_experience.Image = My.Resources.exp7
        End If
        If valu_experience.Value = 8 Then
            Icon_experience.Image = My.Resources.exp8
        End If
        If valu_experience.Value = 9 Then
            Icon_experience.Image = My.Resources.exp9
        End If
        If valu_experience.Value = 10 Then
            Icon_experience.Image = My.Resources.exp10
        End If
        If valu_experience.Value = 11 Then
            Icon_experience.Image = My.Resources.exp11
        End If
        If valu_experience.Value = 12 Then
            Icon_experience.Image = My.Resources.exp12
        End If
        If valu_experience.Value = 13 Then
            Icon_experience.Image = My.Resources.exp13
        End If
        If valu_experience.Value = 14 Then
            Icon_experience.Image = My.Resources.exp14
        End If
        If valu_experience.Value = 15 Then
            Icon_experience.Image = My.Resources.exp15
        End If
        If valu_experience.Value = 16 Then
            Icon_experience.Image = My.Resources.exp16
        End If
        If valu_experience.Value = 17 Then
            Icon_experience.Image = My.Resources.exp17
        End If
        If valu_experience.Value = 18 Then
            Icon_experience.Image = My.Resources.exp18
        End If
        If valu_experience.Value = 19 Then
            Icon_experience.Image = My.Resources.exp19
        End If
        If valu_experience.Value = 20 Then
            Icon_experience.Image = My.Resources.exp20
        End If
        If valu_experience.Value = 21 Then
            Icon_experience.Image = My.Resources.exp21
        End If
        If valu_experience.Value = 22 Then
            Icon_experience.Image = My.Resources.exp22
        End If
        If valu_experience.Value = 23 Then
            Icon_experience.Image = My.Resources.exp23
        End If
        If valu_experience.Value = 24 Then
            Icon_experience.Image = My.Resources.exp24
        End If
        If valu_experience.Value = 25 Then
            Icon_experience.Image = My.Resources.exp25
        End If
        If valu_experience.Value = 26 Then
            Icon_experience.Image = My.Resources.exp26
        End If
        If valu_experience.Value = 27 Then
            Icon_experience.Image = My.Resources.exp27
        End If
        If valu_experience.Value = 28 Then
            Icon_experience.Image = My.Resources.exp28
        End If
        If valu_experience.Value = 29 Then
            Icon_experience.Image = My.Resources.exp29
        End If
        If valu_experience.Value = 30 Then
            Icon_experience.Image = My.Resources.exp30
        End If
        If valu_experience.Value = 31 Then
            Icon_experience.Image = My.Resources.exp31
        End If
        If valu_experience.Value = 32 Then
            Icon_experience.Image = My.Resources.exp32
        End If
        If valu_experience.Value = 33 Then
            Icon_experience.Image = My.Resources.exp33
        End If
        If valu_experience.Value = 34 Then
            Icon_experience.Image = My.Resources.exp34
        End If
        If valu_experience.Value = 35 Then
            Icon_experience.Image = My.Resources.exp35
        End If
        If valu_experience.Value = 36 Then
            Icon_experience.Image = My.Resources.exp36
        End If
        If valu_experience.Value = 37 Then
            Icon_experience.Image = My.Resources.exp37
        End If
        If valu_experience.Value = 38 Then
            Icon_experience.Image = My.Resources.exp38
        End If
        If valu_experience.Value = 39 Then
            Icon_experience.Image = My.Resources.exp39
        End If
        If valu_experience.Value = 40 Then
            Icon_experience.Image = My.Resources.exp40
        End If
        If valu_experience.Value = 41 Then
            Icon_experience.Image = My.Resources.exp41
        End If
        If valu_experience.Value = 42 Then
            Icon_experience.Image = My.Resources.exp42
        End If
        If valu_experience.Value = 43 Then
            Icon_experience.Image = My.Resources.exp43
        End If
        If valu_experience.Value = 44 Then
            Icon_experience.Image = My.Resources.exp44
        End If
        If valu_experience.Value = 45 Then
            Icon_experience.Image = My.Resources.exp45
        End If
        If valu_experience.Value = 46 Then
            Icon_experience.Image = My.Resources.exp46
        End If
        If valu_experience.Value = 47 Then
            Icon_experience.Image = My.Resources.exp47
        End If
        If valu_experience.Value = 48 Then
            Icon_experience.Image = My.Resources.exp48
        End If
        If valu_experience.Value = 49 Then
            Icon_experience.Image = My.Resources.exp49
        End If
        If valu_experience.Value = 50 Then
            Icon_experience.Image = My.Resources.exp50
        End If
        If valu_experience.Value = 51 Then
            Icon_experience.Image = My.Resources.exp51
        End If
        If valu_experience.Value = 52 Then
            Icon_experience.Image = My.Resources.exp52
        End If
        If valu_experience.Value = 53 Then
            Icon_experience.Image = My.Resources.exp53
        End If
        If valu_experience.Value = 54 Then
            Icon_experience.Image = My.Resources.exp54
        End If
        If valu_experience.Value = 55 Then
            Icon_experience.Image = My.Resources.exp55
        End If
        If valu_experience.Value = 56 Then
            Icon_experience.Image = My.Resources.exp56
        End If
        If valu_experience.Value = 57 Then
            Icon_experience.Image = My.Resources.exp57
        End If
        If valu_experience.Value = 58 Then
            Icon_experience.Image = My.Resources.exp58
        End If
        If valu_experience.Value = 59 Then
            Icon_experience.Image = My.Resources.exp59
        End If
        If valu_experience.Value = 60 Then
            Icon_experience.Image = My.Resources.exp60
        End If
        If valu_experience.Value = 61 Then
            Icon_experience.Image = My.Resources.exp61
        End If
        If valu_experience.Value = 62 Then
            Icon_experience.Image = My.Resources.exp62
        End If
        If valu_experience.Value = 63 Then
            Icon_experience.Image = My.Resources.exp63
        End If
        If valu_experience.Value = 64 Then
            Icon_experience.Image = My.Resources.exp64
        End If
        If valu_experience.Value = 65 Then
            Icon_experience.Image = My.Resources.exp65
        End If
        If valu_experience.Value = 66 Then
            Icon_experience.Image = My.Resources.exp66
        End If
        If valu_experience.Value = 67 Then
            Icon_experience.Image = My.Resources.exp67
        End If
        If valu_experience.Value = 68 Then
            Icon_experience.Image = My.Resources.exp68
        End If
        If valu_experience.Value = 69 Then
            Icon_experience.Image = My.Resources.exp69
        End If
        If valu_experience.Value = 70 Then
            Icon_experience.Image = My.Resources.exp70
        End If
        If valu_experience.Value = 71 Then
            Icon_experience.Image = My.Resources.exp71
        End If
        If valu_experience.Value = 72 Then
            Icon_experience.Image = My.Resources.exp72
        End If
        If valu_experience.Value = 73 Then
            Icon_experience.Image = My.Resources.exp73
        End If
        If valu_experience.Value = 74 Then
            Icon_experience.Image = My.Resources.exp74
        End If
        If valu_experience.Value = 75 Then
            Icon_experience.Image = My.Resources.exp75
        End If
        If valu_experience.Value = 76 Then
            Icon_experience.Image = My.Resources.exp76
        End If
        If valu_experience.Value = 77 Then
            Icon_experience.Image = My.Resources.exp77
        End If
        If valu_experience.Value = 78 Then
            Icon_experience.Image = My.Resources.exp78
        End If
        If valu_experience.Value = 79 Then
            Icon_experience.Image = My.Resources.exp79
        End If
        If valu_experience.Value = 80 Then
            Icon_experience.Image = My.Resources.exp80
        End If
        If valu_experience.Value = 81 Then
            Icon_experience.Image = My.Resources.exp81
        End If
        If valu_experience.Value = 82 Then
            Icon_experience.Image = My.Resources.exp82
        End If
        If valu_experience.Value = 83 Then
            Icon_experience.Image = My.Resources.exp83
        End If
        If valu_experience.Value = 84 Then
            Icon_experience.Image = My.Resources.exp84
        End If
        If valu_experience.Value = 85 Then
            Icon_experience.Image = My.Resources.exp85
        End If
        If valu_experience.Value = 86 Then
            Icon_experience.Image = My.Resources.exp86
        End If
        If valu_experience.Value = 87 Then
            Icon_experience.Image = My.Resources.exp87
        End If
        If valu_experience.Value = 88 Then
            Icon_experience.Image = My.Resources.exp88
        End If
        If valu_experience.Value = 89 Then
            Icon_experience.Image = My.Resources.exp89
        End If
        If valu_experience.Value = 90 Then
            Icon_experience.Image = My.Resources.exp90
        End If
        If valu_experience.Value = 91 Then
            Icon_experience.Image = My.Resources.exp91
        End If
        If valu_experience.Value = 92 Then
            Icon_experience.Image = My.Resources.exp92
        End If
        If valu_experience.Value = 93 Then
            Icon_experience.Image = My.Resources.exp93
        End If
        If valu_experience.Value = 94 Then
            Icon_experience.Image = My.Resources.exp94
        End If
        If valu_experience.Value = 95 Then
            Icon_experience.Image = My.Resources.exp95
        End If
        If valu_experience.Value = 96 Then
            Icon_experience.Image = My.Resources.exp96
        End If
        If valu_experience.Value = 97 Then
            Icon_experience.Image = My.Resources.exp97
        End If
        If valu_experience.Value = 98 Then
            Icon_experience.Image = My.Resources.exp98
        End If
        If valu_experience.Value = 99 Then
            Icon_experience.Image = My.Resources.exp99
        End If
    End Sub

    Private Sub valu_exp_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp.ValueChanged
        valu_experience.Value = valu_exp.Value
    End Sub

    Private Sub Fea_edit_travelers_Click(sender As Object, e As EventArgs) Handles Fea_edit_travelers.Click
        Travelers_edit.ShowDialog()
    End Sub

    Private Sub Fea_edit_travelers_MouseLeave(sender As Object, e As EventArgs) Handles Fea_edit_travelers.MouseLeave
        Fea_edit_travelers.BackColor = Color.White
    End Sub

    Private Sub Fea_edit_travelers_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_edit_travelers.MouseMove
        Fea_edit_travelers.BackColor = Color.Orange
    End Sub

    Private Sub Fea_edit_concert_Click(sender As Object, e As EventArgs) Handles Fea_edit_concert.Click
        Concert_edit.Show()
    End Sub

    Private Sub Fea_edit_concert_MouseLeave(sender As Object, e As EventArgs) Handles Fea_edit_concert.MouseLeave
        Fea_edit_concert.BackColor = Color.White
    End Sub

    Private Sub Fea_edit_concert_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_edit_concert.MouseMove
        Fea_edit_concert.BackColor = Color.Orange
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        writesavedataArc()
    End Sub

    Private Sub Button_setallfriends_Click(sender As Object, e As EventArgs) Handles Button_setallfriends.Click
        valu_friend_rela_1.Value = valu_setallfriends.Value
        valu_friend_rela_2.Value = valu_setallfriends.Value
        valu_friend_rela_3.Value = valu_setallfriends.Value
        valu_friend_rela_4.Value = valu_setallfriends.Value
        valu_friend_rela_5.Value = valu_setallfriends.Value
        valu_friend_rela_6.Value = valu_setallfriends.Value
        valu_friend_rela_7.Value = valu_setallfriends.Value
        valu_friend_rela_8.Value = valu_setallfriends.Value
        valu_friend_rela_9.Value = valu_setallfriends.Value
        valu_friend_rela_10.Value = valu_setallfriends.Value
        valu_friend_rela_11.Value = valu_setallfriends.Value
        valu_friend_rela_12.Value = valu_setallfriends.Value
        valu_friend_rela_13.Value = valu_setallfriends.Value
        valu_friend_rela_14.Value = valu_setallfriends.Value
        valu_friend_rela_15.Value = valu_setallfriends.Value
        valu_friend_rela_16.Value = valu_setallfriends.Value
        valu_friend_rela_17.Value = valu_setallfriends.Value
        valu_friend_rela_18.Value = valu_setallfriends.Value
        valu_friend_rela_19.Value = valu_setallfriends.Value
        valu_friend_rela_20.Value = valu_setallfriends.Value
        valu_friend_rela_21.Value = valu_setallfriends.Value
        valu_friend_rela_22.Value = valu_setallfriends.Value
        valu_friend_rela_23.Value = valu_setallfriends.Value
        valu_friend_rela_24.Value = valu_setallfriends.Value
        valu_friend_rela_25.Value = valu_setallfriends.Value
        valu_friend_rela_26.Value = valu_setallfriends.Value
        valu_friend_rela_27.Value = valu_setallfriends.Value
        valu_friend_rela_28.Value = valu_setallfriends.Value
        valu_friend_rela_29.Value = valu_setallfriends.Value
        valu_friend_rela_30.Value = valu_setallfriends.Value
    End Sub

    Private Sub Check_fullness_CheckedChanged(sender As Object, e As EventArgs) Handles Check_fullness.CheckedChanged
        valu_fullness.Value = 0
        valu_chkfullness.Value = 0
    End Sub

    Private Sub valu_chkfullness_ValueChanged(sender As Object, e As EventArgs) Handles valu_chkfullness.ValueChanged
        If valu_chkfullness.Value > 0 Then
            Check_fullness.Checked = False
        ElseIf valu_chkfullness.Value = 0 Then
            Check_fullness.Checked = True
        End If
    End Sub

    Private Sub Icon_itemmii_1_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_1.Click
        If valu_itemmii_1.Value > 26 And valu_itemmii_1.Value < 65535 Then
            valu_itemmii_1.Value = 65535
        ElseIf valu_itemmii_1.Value = 65535 Then
            valu_itemmii_1.Value = 0
        Else
            valu_itemmii_1.Value = valu_itemmii_1.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_2_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_2.Click
        If valu_itemmii_2.Value > 26 And valu_itemmii_2.Value < 65535 Then
            valu_itemmii_2.Value = 65535
        ElseIf valu_itemmii_2.Value = 65535 Then
            valu_itemmii_2.Value = 0
        Else
            valu_itemmii_2.Value = valu_itemmii_2.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_3_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_3.Click
        If valu_itemmii_3.Value > 26 And valu_itemmii_3.Value < 65535 Then
            valu_itemmii_3.Value = 65535
        ElseIf valu_itemmii_3.Value = 65535 Then
            valu_itemmii_3.Value = 0
        Else
            valu_itemmii_3.Value = valu_itemmii_3.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_4_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_4.Click
        If valu_itemmii_4.Value > 26 And valu_itemmii_4.Value < 65535 Then
            valu_itemmii_4.Value = 65535
        ElseIf valu_itemmii_4.Value = 65535 Then
            valu_itemmii_4.Value = 0
        Else
            valu_itemmii_4.Value = valu_itemmii_4.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_5_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_5.Click
        If valu_itemmii_5.Value > 26 And valu_itemmii_5.Value < 65535 Then
            valu_itemmii_5.Value = 65535
        ElseIf valu_itemmii_5.Value = 65535 Then
            valu_itemmii_5.Value = 0
        Else
            valu_itemmii_5.Value = valu_itemmii_5.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_6_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_6.Click
        If valu_itemmii_6.Value > 26 And valu_itemmii_6.Value < 65535 Then
            valu_itemmii_6.Value = 65535
        ElseIf valu_itemmii_6.Value = 65535 Then
            valu_itemmii_6.Value = 0
        Else
            valu_itemmii_6.Value = valu_itemmii_6.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_7_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_7.Click
        If valu_itemmii_7.Value > 26 And valu_itemmii_7.Value < 65535 Then
            valu_itemmii_7.Value = 65535
        ElseIf valu_itemmii_7.Value = 65535 Then
            valu_itemmii_7.Value = 0
        Else
            valu_itemmii_7.Value = valu_itemmii_7.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_8_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_8.Click
        If valu_itemmii_8.Value > 26 And valu_itemmii_8.Value < 65535 Then
            valu_itemmii_8.Value = 65535
        ElseIf valu_itemmii_8.Value = 65535 Then
            valu_itemmii_8.Value = 0
        Else
            valu_itemmii_8.Value = valu_itemmii_8.Value + 1
        End If
    End Sub

    Private Sub valu_itemmii_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_1.ValueChanged
        If valu_itemmii_1.Value = 65535 Then
            Icon_itemmii_1.Image = My.Resources.FFFF
        End If
        If valu_itemmii_1.Value = 0 Then
            Icon_itemmii_1.Image = My.Resources._0000
        End If
        If valu_itemmii_1.Value = 1 Then
            Icon_itemmii_1.Image = My.Resources._0100
        End If
        If valu_itemmii_1.Value = 2 Then
            Icon_itemmii_1.Image = My.Resources._0200
        End If
        If valu_itemmii_1.Value = 3 Then
            Icon_itemmii_1.Image = My.Resources._0300
        End If
        If valu_itemmii_1.Value = 4 Then
            Icon_itemmii_1.Image = My.Resources._0400
        End If
        If valu_itemmii_1.Value = 5 Then
            Icon_itemmii_1.Image = My.Resources._0500
        End If
        If valu_itemmii_1.Value = 6 Then
            Icon_itemmii_1.Image = My.Resources._0600
        End If
        If valu_itemmii_1.Value = 7 Then
            Icon_itemmii_1.Image = My.Resources._0700
        End If
        If valu_itemmii_1.Value = 8 Then
            Icon_itemmii_1.Image = My.Resources._0800
        End If
        If valu_itemmii_1.Value = 9 Then
            Icon_itemmii_1.Image = My.Resources._0900
        End If
        If valu_itemmii_1.Value = 10 Then
            Icon_itemmii_1.Image = My.Resources._0a00
        End If
        If valu_itemmii_1.Value = 11 Then
            Icon_itemmii_1.Image = My.Resources._0b00
        End If
        If valu_itemmii_1.Value = 12 Then
            Icon_itemmii_1.Image = My.Resources._0c00
        End If
        If valu_itemmii_1.Value = 13 Then
            Icon_itemmii_1.Image = My.Resources._0d00
        End If
        If valu_itemmii_1.Value = 14 Then
            Icon_itemmii_1.Image = My.Resources._0e00
        End If
        If valu_itemmii_1.Value = 15 Then
            Icon_itemmii_1.Image = My.Resources._0f00
        End If
        If valu_itemmii_1.Value = 16 Then
            Icon_itemmii_1.Image = My.Resources._1000
        End If
        If valu_itemmii_1.Value = 17 Then
            Icon_itemmii_1.Image = My.Resources._1100
        End If
        If valu_itemmii_1.Value = 18 Then
            Icon_itemmii_1.Image = My.Resources._1200
        End If
        If valu_itemmii_1.Value = 19 Then
            Icon_itemmii_1.Image = My.Resources._1300
        End If
        If valu_itemmii_1.Value = 20 Then
            Icon_itemmii_1.Image = My.Resources._1400
        End If
        If valu_itemmii_1.Value = 21 Then
            Icon_itemmii_1.Image = My.Resources._1500
        End If
        If valu_itemmii_1.Value = 22 Then
            Icon_itemmii_1.Image = My.Resources._1600
        End If
        If valu_itemmii_1.Value = 23 Then
            Icon_itemmii_1.Image = My.Resources._1700
        End If
        If valu_itemmii_1.Value = 24 Then
            Icon_itemmii_1.Image = My.Resources._1800
        End If
        If valu_itemmii_1.Value = 25 Then
            Icon_itemmii_1.Image = My.Resources._1900
        End If
        If valu_itemmii_1.Value = 26 Then
            Icon_itemmii_1.Image = My.Resources._1a00
        End If
        If valu_itemmii_1.Value = 27 Then
            Icon_itemmii_1.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_2.ValueChanged
        If valu_itemmii_2.Value = 65535 Then
            Icon_itemmii_2.Image = My.Resources.FFFF
        End If
        If valu_itemmii_2.Value = 0 Then
            Icon_itemmii_2.Image = My.Resources._0000
        End If
        If valu_itemmii_2.Value = 1 Then
            Icon_itemmii_2.Image = My.Resources._0100
        End If
        If valu_itemmii_2.Value = 2 Then
            Icon_itemmii_2.Image = My.Resources._0200
        End If
        If valu_itemmii_2.Value = 3 Then
            Icon_itemmii_2.Image = My.Resources._0300
        End If
        If valu_itemmii_2.Value = 4 Then
            Icon_itemmii_2.Image = My.Resources._0400
        End If
        If valu_itemmii_2.Value = 5 Then
            Icon_itemmii_2.Image = My.Resources._0500
        End If
        If valu_itemmii_2.Value = 6 Then
            Icon_itemmii_2.Image = My.Resources._0600
        End If
        If valu_itemmii_2.Value = 7 Then
            Icon_itemmii_2.Image = My.Resources._0700
        End If
        If valu_itemmii_2.Value = 8 Then
            Icon_itemmii_2.Image = My.Resources._0800
        End If
        If valu_itemmii_2.Value = 9 Then
            Icon_itemmii_2.Image = My.Resources._0900
        End If
        If valu_itemmii_2.Value = 10 Then
            Icon_itemmii_2.Image = My.Resources._0a00
        End If
        If valu_itemmii_2.Value = 11 Then
            Icon_itemmii_2.Image = My.Resources._0b00
        End If
        If valu_itemmii_2.Value = 12 Then
            Icon_itemmii_2.Image = My.Resources._0c00
        End If
        If valu_itemmii_2.Value = 13 Then
            Icon_itemmii_2.Image = My.Resources._0d00
        End If
        If valu_itemmii_2.Value = 14 Then
            Icon_itemmii_2.Image = My.Resources._0e00
        End If
        If valu_itemmii_2.Value = 15 Then
            Icon_itemmii_2.Image = My.Resources._0f00
        End If
        If valu_itemmii_2.Value = 16 Then
            Icon_itemmii_2.Image = My.Resources._1000
        End If
        If valu_itemmii_2.Value = 17 Then
            Icon_itemmii_2.Image = My.Resources._1100
        End If
        If valu_itemmii_2.Value = 18 Then
            Icon_itemmii_2.Image = My.Resources._1200
        End If
        If valu_itemmii_2.Value = 19 Then
            Icon_itemmii_2.Image = My.Resources._1300
        End If
        If valu_itemmii_2.Value = 20 Then
            Icon_itemmii_2.Image = My.Resources._1400
        End If
        If valu_itemmii_2.Value = 21 Then
            Icon_itemmii_2.Image = My.Resources._1500
        End If
        If valu_itemmii_2.Value = 22 Then
            Icon_itemmii_2.Image = My.Resources._1600
        End If
        If valu_itemmii_2.Value = 23 Then
            Icon_itemmii_2.Image = My.Resources._1700
        End If
        If valu_itemmii_2.Value = 24 Then
            Icon_itemmii_2.Image = My.Resources._1800
        End If
        If valu_itemmii_2.Value = 25 Then
            Icon_itemmii_2.Image = My.Resources._1900
        End If
        If valu_itemmii_2.Value = 26 Then
            Icon_itemmii_2.Image = My.Resources._1a00
        End If
        If valu_itemmii_2.Value = 27 Then
            Icon_itemmii_2.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_3.ValueChanged
        If valu_itemmii_3.Value = 65535 Then
            Icon_itemmii_3.Image = My.Resources.FFFF
        End If
        If valu_itemmii_3.Value = 0 Then
            Icon_itemmii_3.Image = My.Resources._0000
        End If
        If valu_itemmii_3.Value = 1 Then
            Icon_itemmii_3.Image = My.Resources._0100
        End If
        If valu_itemmii_3.Value = 2 Then
            Icon_itemmii_3.Image = My.Resources._0200
        End If
        If valu_itemmii_3.Value = 3 Then
            Icon_itemmii_3.Image = My.Resources._0300
        End If
        If valu_itemmii_3.Value = 4 Then
            Icon_itemmii_3.Image = My.Resources._0400
        End If
        If valu_itemmii_3.Value = 5 Then
            Icon_itemmii_3.Image = My.Resources._0500
        End If
        If valu_itemmii_3.Value = 6 Then
            Icon_itemmii_3.Image = My.Resources._0600
        End If
        If valu_itemmii_3.Value = 7 Then
            Icon_itemmii_3.Image = My.Resources._0700
        End If
        If valu_itemmii_3.Value = 8 Then
            Icon_itemmii_3.Image = My.Resources._0800
        End If
        If valu_itemmii_3.Value = 9 Then
            Icon_itemmii_3.Image = My.Resources._0900
        End If
        If valu_itemmii_3.Value = 10 Then
            Icon_itemmii_3.Image = My.Resources._0a00
        End If
        If valu_itemmii_3.Value = 11 Then
            Icon_itemmii_3.Image = My.Resources._0b00
        End If
        If valu_itemmii_3.Value = 12 Then
            Icon_itemmii_3.Image = My.Resources._0c00
        End If
        If valu_itemmii_3.Value = 13 Then
            Icon_itemmii_3.Image = My.Resources._0d00
        End If
        If valu_itemmii_3.Value = 14 Then
            Icon_itemmii_3.Image = My.Resources._0e00
        End If
        If valu_itemmii_3.Value = 15 Then
            Icon_itemmii_3.Image = My.Resources._0f00
        End If
        If valu_itemmii_3.Value = 16 Then
            Icon_itemmii_3.Image = My.Resources._1000
        End If
        If valu_itemmii_3.Value = 17 Then
            Icon_itemmii_3.Image = My.Resources._1100
        End If
        If valu_itemmii_3.Value = 18 Then
            Icon_itemmii_3.Image = My.Resources._1200
        End If
        If valu_itemmii_3.Value = 19 Then
            Icon_itemmii_3.Image = My.Resources._1300
        End If
        If valu_itemmii_3.Value = 20 Then
            Icon_itemmii_3.Image = My.Resources._1400
        End If
        If valu_itemmii_3.Value = 21 Then
            Icon_itemmii_3.Image = My.Resources._1500
        End If
        If valu_itemmii_3.Value = 22 Then
            Icon_itemmii_3.Image = My.Resources._1600
        End If
        If valu_itemmii_3.Value = 23 Then
            Icon_itemmii_3.Image = My.Resources._1700
        End If
        If valu_itemmii_3.Value = 24 Then
            Icon_itemmii_3.Image = My.Resources._1800
        End If
        If valu_itemmii_3.Value = 25 Then
            Icon_itemmii_3.Image = My.Resources._1900
        End If
        If valu_itemmii_3.Value = 26 Then
            Icon_itemmii_3.Image = My.Resources._1a00
        End If
        If valu_itemmii_3.Value = 27 Then
            Icon_itemmii_3.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_4.ValueChanged
        If valu_itemmii_4.Value = 65535 Then
            Icon_itemmii_4.Image = My.Resources.FFFF
        End If
        If valu_itemmii_4.Value = 0 Then
            Icon_itemmii_4.Image = My.Resources._0000
        End If
        If valu_itemmii_4.Value = 1 Then
            Icon_itemmii_4.Image = My.Resources._0100
        End If
        If valu_itemmii_4.Value = 2 Then
            Icon_itemmii_4.Image = My.Resources._0200
        End If
        If valu_itemmii_4.Value = 3 Then
            Icon_itemmii_4.Image = My.Resources._0300
        End If
        If valu_itemmii_4.Value = 4 Then
            Icon_itemmii_4.Image = My.Resources._0400
        End If
        If valu_itemmii_4.Value = 5 Then
            Icon_itemmii_4.Image = My.Resources._0500
        End If
        If valu_itemmii_4.Value = 6 Then
            Icon_itemmii_4.Image = My.Resources._0600
        End If
        If valu_itemmii_4.Value = 7 Then
            Icon_itemmii_4.Image = My.Resources._0700
        End If
        If valu_itemmii_4.Value = 8 Then
            Icon_itemmii_4.Image = My.Resources._0800
        End If
        If valu_itemmii_4.Value = 9 Then
            Icon_itemmii_4.Image = My.Resources._0900
        End If
        If valu_itemmii_4.Value = 10 Then
            Icon_itemmii_4.Image = My.Resources._0a00
        End If
        If valu_itemmii_4.Value = 11 Then
            Icon_itemmii_4.Image = My.Resources._0b00
        End If
        If valu_itemmii_4.Value = 12 Then
            Icon_itemmii_4.Image = My.Resources._0c00
        End If
        If valu_itemmii_4.Value = 13 Then
            Icon_itemmii_4.Image = My.Resources._0d00
        End If
        If valu_itemmii_4.Value = 14 Then
            Icon_itemmii_4.Image = My.Resources._0e00
        End If
        If valu_itemmii_4.Value = 15 Then
            Icon_itemmii_4.Image = My.Resources._0f00
        End If
        If valu_itemmii_4.Value = 16 Then
            Icon_itemmii_4.Image = My.Resources._1000
        End If
        If valu_itemmii_4.Value = 17 Then
            Icon_itemmii_4.Image = My.Resources._1100
        End If
        If valu_itemmii_4.Value = 18 Then
            Icon_itemmii_4.Image = My.Resources._1200
        End If
        If valu_itemmii_4.Value = 19 Then
            Icon_itemmii_4.Image = My.Resources._1300
        End If
        If valu_itemmii_4.Value = 20 Then
            Icon_itemmii_4.Image = My.Resources._1400
        End If
        If valu_itemmii_4.Value = 21 Then
            Icon_itemmii_4.Image = My.Resources._1500
        End If
        If valu_itemmii_4.Value = 22 Then
            Icon_itemmii_4.Image = My.Resources._1600
        End If
        If valu_itemmii_4.Value = 23 Then
            Icon_itemmii_4.Image = My.Resources._1700
        End If
        If valu_itemmii_4.Value = 24 Then
            Icon_itemmii_4.Image = My.Resources._1800
        End If
        If valu_itemmii_4.Value = 25 Then
            Icon_itemmii_4.Image = My.Resources._1900
        End If
        If valu_itemmii_4.Value = 26 Then
            Icon_itemmii_4.Image = My.Resources._1a00
        End If
        If valu_itemmii_4.Value = 27 Then
            Icon_itemmii_4.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_5.ValueChanged
        If valu_itemmii_5.Value = 65535 Then
            Icon_itemmii_5.Image = My.Resources.FFFF
        End If
        If valu_itemmii_5.Value = 0 Then
            Icon_itemmii_5.Image = My.Resources._0000
        End If
        If valu_itemmii_5.Value = 1 Then
            Icon_itemmii_5.Image = My.Resources._0100
        End If
        If valu_itemmii_5.Value = 2 Then
            Icon_itemmii_5.Image = My.Resources._0200
        End If
        If valu_itemmii_5.Value = 3 Then
            Icon_itemmii_5.Image = My.Resources._0300
        End If
        If valu_itemmii_5.Value = 4 Then
            Icon_itemmii_5.Image = My.Resources._0400
        End If
        If valu_itemmii_5.Value = 5 Then
            Icon_itemmii_5.Image = My.Resources._0500
        End If
        If valu_itemmii_5.Value = 6 Then
            Icon_itemmii_5.Image = My.Resources._0600
        End If
        If valu_itemmii_5.Value = 7 Then
            Icon_itemmii_5.Image = My.Resources._0700
        End If
        If valu_itemmii_5.Value = 8 Then
            Icon_itemmii_5.Image = My.Resources._0800
        End If
        If valu_itemmii_5.Value = 9 Then
            Icon_itemmii_5.Image = My.Resources._0900
        End If
        If valu_itemmii_5.Value = 10 Then
            Icon_itemmii_5.Image = My.Resources._0a00
        End If
        If valu_itemmii_5.Value = 11 Then
            Icon_itemmii_5.Image = My.Resources._0b00
        End If
        If valu_itemmii_5.Value = 12 Then
            Icon_itemmii_5.Image = My.Resources._0c00
        End If
        If valu_itemmii_5.Value = 13 Then
            Icon_itemmii_5.Image = My.Resources._0d00
        End If
        If valu_itemmii_5.Value = 14 Then
            Icon_itemmii_5.Image = My.Resources._0e00
        End If
        If valu_itemmii_5.Value = 15 Then
            Icon_itemmii_5.Image = My.Resources._0f00
        End If
        If valu_itemmii_5.Value = 16 Then
            Icon_itemmii_5.Image = My.Resources._1000
        End If
        If valu_itemmii_5.Value = 17 Then
            Icon_itemmii_5.Image = My.Resources._1100
        End If
        If valu_itemmii_5.Value = 18 Then
            Icon_itemmii_5.Image = My.Resources._1200
        End If
        If valu_itemmii_5.Value = 19 Then
            Icon_itemmii_5.Image = My.Resources._1300
        End If
        If valu_itemmii_5.Value = 20 Then
            Icon_itemmii_5.Image = My.Resources._1400
        End If
        If valu_itemmii_5.Value = 21 Then
            Icon_itemmii_5.Image = My.Resources._1500
        End If
        If valu_itemmii_5.Value = 22 Then
            Icon_itemmii_5.Image = My.Resources._1600
        End If
        If valu_itemmii_5.Value = 23 Then
            Icon_itemmii_5.Image = My.Resources._1700
        End If
        If valu_itemmii_5.Value = 24 Then
            Icon_itemmii_5.Image = My.Resources._1800
        End If
        If valu_itemmii_5.Value = 25 Then
            Icon_itemmii_5.Image = My.Resources._1900
        End If
        If valu_itemmii_5.Value = 26 Then
            Icon_itemmii_5.Image = My.Resources._1a00
        End If
        If valu_itemmii_5.Value = 27 Then
            Icon_itemmii_5.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_6.ValueChanged
        If valu_itemmii_6.Value = 65535 Then
            Icon_itemmii_6.Image = My.Resources.FFFF
        End If
        If valu_itemmii_6.Value = 0 Then
            Icon_itemmii_6.Image = My.Resources._0000
        End If
        If valu_itemmii_6.Value = 1 Then
            Icon_itemmii_6.Image = My.Resources._0100
        End If
        If valu_itemmii_6.Value = 2 Then
            Icon_itemmii_6.Image = My.Resources._0200
        End If
        If valu_itemmii_6.Value = 3 Then
            Icon_itemmii_6.Image = My.Resources._0300
        End If
        If valu_itemmii_6.Value = 4 Then
            Icon_itemmii_6.Image = My.Resources._0400
        End If
        If valu_itemmii_6.Value = 5 Then
            Icon_itemmii_6.Image = My.Resources._0500
        End If
        If valu_itemmii_6.Value = 6 Then
            Icon_itemmii_6.Image = My.Resources._0600
        End If
        If valu_itemmii_6.Value = 7 Then
            Icon_itemmii_6.Image = My.Resources._0700
        End If
        If valu_itemmii_6.Value = 8 Then
            Icon_itemmii_6.Image = My.Resources._0800
        End If
        If valu_itemmii_6.Value = 9 Then
            Icon_itemmii_6.Image = My.Resources._0900
        End If
        If valu_itemmii_6.Value = 10 Then
            Icon_itemmii_6.Image = My.Resources._0a00
        End If
        If valu_itemmii_6.Value = 11 Then
            Icon_itemmii_6.Image = My.Resources._0b00
        End If
        If valu_itemmii_6.Value = 12 Then
            Icon_itemmii_6.Image = My.Resources._0c00
        End If
        If valu_itemmii_6.Value = 13 Then
            Icon_itemmii_6.Image = My.Resources._0d00
        End If
        If valu_itemmii_6.Value = 14 Then
            Icon_itemmii_6.Image = My.Resources._0e00
        End If
        If valu_itemmii_6.Value = 15 Then
            Icon_itemmii_6.Image = My.Resources._0f00
        End If
        If valu_itemmii_6.Value = 16 Then
            Icon_itemmii_6.Image = My.Resources._1000
        End If
        If valu_itemmii_6.Value = 17 Then
            Icon_itemmii_6.Image = My.Resources._1100
        End If
        If valu_itemmii_6.Value = 18 Then
            Icon_itemmii_6.Image = My.Resources._1200
        End If
        If valu_itemmii_6.Value = 19 Then
            Icon_itemmii_6.Image = My.Resources._1300
        End If
        If valu_itemmii_6.Value = 20 Then
            Icon_itemmii_6.Image = My.Resources._1400
        End If
        If valu_itemmii_6.Value = 21 Then
            Icon_itemmii_6.Image = My.Resources._1500
        End If
        If valu_itemmii_6.Value = 22 Then
            Icon_itemmii_6.Image = My.Resources._1600
        End If
        If valu_itemmii_6.Value = 23 Then
            Icon_itemmii_6.Image = My.Resources._1700
        End If
        If valu_itemmii_6.Value = 24 Then
            Icon_itemmii_6.Image = My.Resources._1800
        End If
        If valu_itemmii_6.Value = 25 Then
            Icon_itemmii_6.Image = My.Resources._1900
        End If
        If valu_itemmii_6.Value = 26 Then
            Icon_itemmii_6.Image = My.Resources._1a00
        End If
        If valu_itemmii_6.Value = 27 Then
            Icon_itemmii_6.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_7.ValueChanged
        If valu_itemmii_7.Value = 65535 Then
            Icon_itemmii_7.Image = My.Resources.FFFF
        End If
        If valu_itemmii_7.Value = 0 Then
            Icon_itemmii_7.Image = My.Resources._0000
        End If
        If valu_itemmii_7.Value = 1 Then
            Icon_itemmii_7.Image = My.Resources._0100
        End If
        If valu_itemmii_7.Value = 2 Then
            Icon_itemmii_7.Image = My.Resources._0200
        End If
        If valu_itemmii_7.Value = 3 Then
            Icon_itemmii_7.Image = My.Resources._0300
        End If
        If valu_itemmii_7.Value = 4 Then
            Icon_itemmii_7.Image = My.Resources._0400
        End If
        If valu_itemmii_7.Value = 5 Then
            Icon_itemmii_7.Image = My.Resources._0500
        End If
        If valu_itemmii_7.Value = 6 Then
            Icon_itemmii_7.Image = My.Resources._0600
        End If
        If valu_itemmii_7.Value = 7 Then
            Icon_itemmii_7.Image = My.Resources._0700
        End If
        If valu_itemmii_7.Value = 8 Then
            Icon_itemmii_7.Image = My.Resources._0800
        End If
        If valu_itemmii_7.Value = 9 Then
            Icon_itemmii_7.Image = My.Resources._0900
        End If
        If valu_itemmii_7.Value = 10 Then
            Icon_itemmii_7.Image = My.Resources._0a00
        End If
        If valu_itemmii_7.Value = 11 Then
            Icon_itemmii_7.Image = My.Resources._0b00
        End If
        If valu_itemmii_7.Value = 12 Then
            Icon_itemmii_7.Image = My.Resources._0c00
        End If
        If valu_itemmii_7.Value = 13 Then
            Icon_itemmii_7.Image = My.Resources._0d00
        End If
        If valu_itemmii_7.Value = 14 Then
            Icon_itemmii_7.Image = My.Resources._0e00
        End If
        If valu_itemmii_7.Value = 15 Then
            Icon_itemmii_7.Image = My.Resources._0f00
        End If
        If valu_itemmii_7.Value = 16 Then
            Icon_itemmii_7.Image = My.Resources._1000
        End If
        If valu_itemmii_7.Value = 17 Then
            Icon_itemmii_7.Image = My.Resources._1100
        End If
        If valu_itemmii_7.Value = 18 Then
            Icon_itemmii_7.Image = My.Resources._1200
        End If
        If valu_itemmii_7.Value = 19 Then
            Icon_itemmii_7.Image = My.Resources._1300
        End If
        If valu_itemmii_7.Value = 20 Then
            Icon_itemmii_7.Image = My.Resources._1400
        End If
        If valu_itemmii_7.Value = 21 Then
            Icon_itemmii_7.Image = My.Resources._1500
        End If
        If valu_itemmii_7.Value = 22 Then
            Icon_itemmii_7.Image = My.Resources._1600
        End If
        If valu_itemmii_7.Value = 23 Then
            Icon_itemmii_7.Image = My.Resources._1700
        End If
        If valu_itemmii_7.Value = 24 Then
            Icon_itemmii_7.Image = My.Resources._1800
        End If
        If valu_itemmii_7.Value = 25 Then
            Icon_itemmii_7.Image = My.Resources._1900
        End If
        If valu_itemmii_7.Value = 26 Then
            Icon_itemmii_7.Image = My.Resources._1a00
        End If
        If valu_itemmii_7.Value = 27 Then
            Icon_itemmii_7.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_8.ValueChanged
        If valu_itemmii_8.Value = 65535 Then
            Icon_itemmii_8.Image = My.Resources.FFFF
        End If
        If valu_itemmii_8.Value = 0 Then
            Icon_itemmii_8.Image = My.Resources._0000
        End If
        If valu_itemmii_8.Value = 1 Then
            Icon_itemmii_8.Image = My.Resources._0100
        End If
        If valu_itemmii_8.Value = 2 Then
            Icon_itemmii_8.Image = My.Resources._0200
        End If
        If valu_itemmii_8.Value = 3 Then
            Icon_itemmii_8.Image = My.Resources._0300
        End If
        If valu_itemmii_8.Value = 4 Then
            Icon_itemmii_8.Image = My.Resources._0400
        End If
        If valu_itemmii_8.Value = 5 Then
            Icon_itemmii_8.Image = My.Resources._0500
        End If
        If valu_itemmii_8.Value = 6 Then
            Icon_itemmii_8.Image = My.Resources._0600
        End If
        If valu_itemmii_8.Value = 7 Then
            Icon_itemmii_8.Image = My.Resources._0700
        End If
        If valu_itemmii_8.Value = 8 Then
            Icon_itemmii_8.Image = My.Resources._0800
        End If
        If valu_itemmii_8.Value = 9 Then
            Icon_itemmii_8.Image = My.Resources._0900
        End If
        If valu_itemmii_8.Value = 10 Then
            Icon_itemmii_8.Image = My.Resources._0a00
        End If
        If valu_itemmii_8.Value = 11 Then
            Icon_itemmii_8.Image = My.Resources._0b00
        End If
        If valu_itemmii_8.Value = 12 Then
            Icon_itemmii_8.Image = My.Resources._0c00
        End If
        If valu_itemmii_8.Value = 13 Then
            Icon_itemmii_8.Image = My.Resources._0d00
        End If
        If valu_itemmii_8.Value = 14 Then
            Icon_itemmii_8.Image = My.Resources._0e00
        End If
        If valu_itemmii_8.Value = 15 Then
            Icon_itemmii_8.Image = My.Resources._0f00
        End If
        If valu_itemmii_8.Value = 16 Then
            Icon_itemmii_8.Image = My.Resources._1000
        End If
        If valu_itemmii_8.Value = 17 Then
            Icon_itemmii_8.Image = My.Resources._1100
        End If
        If valu_itemmii_8.Value = 18 Then
            Icon_itemmii_8.Image = My.Resources._1200
        End If
        If valu_itemmii_8.Value = 19 Then
            Icon_itemmii_8.Image = My.Resources._1300
        End If
        If valu_itemmii_8.Value = 20 Then
            Icon_itemmii_8.Image = My.Resources._1400
        End If
        If valu_itemmii_8.Value = 21 Then
            Icon_itemmii_8.Image = My.Resources._1500
        End If
        If valu_itemmii_8.Value = 22 Then
            Icon_itemmii_8.Image = My.Resources._1600
        End If
        If valu_itemmii_8.Value = 23 Then
            Icon_itemmii_8.Image = My.Resources._1700
        End If
        If valu_itemmii_8.Value = 24 Then
            Icon_itemmii_8.Image = My.Resources._1800
        End If
        If valu_itemmii_8.Value = 25 Then
            Icon_itemmii_8.Image = My.Resources._1900
        End If
        If valu_itemmii_8.Value = 26 Then
            Icon_itemmii_8.Image = My.Resources._1a00
        End If
        If valu_itemmii_8.Value = 27 Then
            Icon_itemmii_8.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(0)
        Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(0)
        Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(0)
        Select_interaction.SelectedItem = Select_interaction.Items.Item(0)
        Select_emotions.SelectedItem = Select_emotions.Items.Item(0)
        Check_fullness.Checked = False
        Select_growkid.SelectedItem = Select_growkid.Items.Item(0)
        Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(0)
        Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(0)
        Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(0)
        Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(0)
        Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(0)
        Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(0)
        Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(0)
        Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(0)
        Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(0)
        Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(0)
        Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(0)
        Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(0)
        Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(0)
        Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(0)
        Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(0)
        Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(0)
        Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(0)
        Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(0)
        Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(0)
        Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(0)
        Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(0)
        Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(0)
        Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(0)
        Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(0)
        Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(0)
        Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(0)
        Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(0)
        Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(0)
        Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(0)
        Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(0)
        If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Accessmii = &H0
                Accessfriends = &H0
                Patchmii = 0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Accessmii = &H660
                Accessfriends = &H100
                Patchmii = 1
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Accessmii = &H660 * 2
                Accessfriends = &H100 * 2
                Patchmii = 2
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Accessmii = &H660 * 3
                Accessfriends = &H100 * 3
                Patchmii = 3
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Accessmii = &H660 * 4
                Accessfriends = &H100 * 4
                Patchmii = 4
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Accessmii = &H660 * 5
                Accessfriends = &H100 * 5
                Patchmii = 5
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Accessmii = &H660 * 6
                Accessfriends = &H100 * 6
                Patchmii = 6
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Accessmii = &H660 * 7
                Accessfriends = &H100 * 7
                Patchmii = 7
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Accessmii = &H660 * 8
                Accessfriends = &H100 * 8
                Patchmii = 8
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Accessmii = &H660 * 9
                Accessfriends = &H100 * 9
                Patchmii = 9
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Accessmii = &H660 * 10
                Accessfriends = &H100 * 10
                Patchmii = 10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Accessmii = &H660 * 11
                Accessfriends = &H100 * 11
                Patchmii = 11
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Accessmii = &H660 * 12
                Accessfriends = &H100 * 12
                Patchmii = 12
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Accessmii = &H660 * 13
                Accessfriends = &H100 * 13
                Patchmii = 13
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Accessmii = &H660 * 14
                Accessfriends = &H100 * 14
                Patchmii = 14
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Accessmii = &H660 * 15
                Accessfriends = &H100 * 15
                Patchmii = 15
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Accessmii = &H660 * 16
                Accessfriends = &H100 * 16
                Patchmii = 16
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Accessmii = &H660 * 17
                Accessfriends = &H100 * 17
                Patchmii = 17
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Accessmii = &H660 * 18
                Accessfriends = &H100 * 18
                Patchmii = 18
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Accessmii = &H660 * 19
                Accessfriends = &H100 * 19
                Patchmii = 19
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Accessmii = &H660 * 20
                Accessfriends = &H100 * 20
                Patchmii = 20
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Accessmii = &H660 * 21
                Accessfriends = &H100 * 21
                Patchmii = 21
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Accessmii = &H660 * 22
                Accessfriends = &H100 * 22
                Patchmii = 22
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Accessmii = &H660 * 23
                Accessfriends = &H100 * 23
                Patchmii = 23
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Accessmii = &H660 * 24
                Accessfriends = &H100 * 24
                Patchmii = 24
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Accessmii = &H660 * 25
                Accessfriends = &H100 * 25
                Patchmii = 25
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Accessmii = &H660 * 26
                Accessfriends = &H100 * 26
                Patchmii = 26
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Accessmii = &H660 * 27
                Accessfriends = &H100 * 27
                Patchmii = 27
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Accessmii = &H660 * 28
                Accessfriends = &H100 * 28
                Patchmii = 28
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Accessmii = &H660 * 29
                Accessfriends = &H100 * 29
                Patchmii = 29
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Accessmii = &H660 * 30
                Accessfriends = &H100 * 30
                Patchmii = 30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Accessmii = &H660 * 31
                Accessfriends = &H100 * 31
                Patchmii = 31
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Accessmii = &H660 * 32
                Accessfriends = &H100 * 32
                Patchmii = 32
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Accessmii = &H660 * 33
                Accessfriends = &H100 * 33
                Patchmii = 33
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Accessmii = &H660 * 34
                Accessfriends = &H100 * 34
                Patchmii = 34
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Accessmii = &H660 * 35
                Accessfriends = &H100 * 35
                Patchmii = 35
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Accessmii = &H660 * 36
                Accessfriends = &H100 * 36
                Patchmii = 36
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Accessmii = &H660 * 37
                Accessfriends = &H100 * 37
                Patchmii = 37
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Accessmii = &H660 * 38
                Accessfriends = &H100 * 38
                Patchmii = 38
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Accessmii = &H660 * 39
                Accessfriends = &H100 * 39
                Patchmii = 39
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Accessmii = &H660 * 40
                Accessfriends = &H100 * 40
                Patchmii = 40
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Accessmii = &H660 * 41
                Accessfriends = &H100 * 41
                Patchmii = 41
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Accessmii = &H660 * 42
                Accessfriends = &H100 * 42
                Patchmii = 42
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Accessmii = &H660 * 43
                Accessfriends = &H100 * 43
                Patchmii = 43
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Accessmii = &H660 * 44
                Accessfriends = &H100 * 44
                Patchmii = 44
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Accessmii = &H660 * 45
                Accessfriends = &H100 * 45
                Patchmii = 45
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Accessmii = &H660 * 46
                Accessfriends = &H100 * 46
                Patchmii = 46
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Accessmii = &H660 * 47
                Accessfriends = &H100 * 47
                Patchmii = 47
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Accessmii = &H660 * 48
                Accessfriends = &H100 * 48
                Patchmii = 48
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Accessmii = &H660 * 49
                Accessfriends = &H100 * 49
                Patchmii = 49
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                Accessmii = &H660 * 50
                Accessfriends = &H100 * 50
                Patchmii = 50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                Accessmii = &H660 * 51
                Accessfriends = &H100 * 51
                Patchmii = 51
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                Accessmii = &H660 * 52
                Accessfriends = &H100 * 52
                Patchmii = 52
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                Accessmii = &H660 * 53
                Accessfriends = &H100 * 53
                Patchmii = 53
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                Accessmii = &H660 * 54
                Accessfriends = &H100 * 54
                Patchmii = 54
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                Accessmii = &H660 * 55
                Accessfriends = &H100 * 55
                Patchmii = 55
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                Accessmii = &H660 * 56
                Accessfriends = &H100 * 56
                Patchmii = 56
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                Accessmii = &H660 * 57
                Accessfriends = &H100 * 57
                Patchmii = 57
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                Accessmii = &H660 * 58
                Accessfriends = &H100 * 58
                Patchmii = 58
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                Accessmii = &H660 * 59
                Accessfriends = &H100 * 59
                Patchmii = 59
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                Accessmii = &H660 * 60
                Accessfriends = &H100 * 60
                Patchmii = 60
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                Accessmii = &H660 * 61
                Accessfriends = &H100 * 61
                Patchmii = 61
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                Accessmii = &H660 * 62
                Accessfriends = &H100 * 62
                Patchmii = 62
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                Accessmii = &H660 * 63
                Accessfriends = &H100 * 63
                Patchmii = 63
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                Accessmii = &H660 * 64
                Accessfriends = &H100 * 64
                Patchmii = 64
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                Accessmii = &H660 * 65
                Accessfriends = &H100 * 65
                Patchmii = 65
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                Accessmii = &H660 * 66
                Accessfriends = &H100 * 66
                Patchmii = 66
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                Accessmii = &H660 * 67
                Accessfriends = &H100 * 67
                Patchmii = 67
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                Accessmii = &H660 * 68
                Accessfriends = &H100 * 68
                Patchmii = 68
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                Accessmii = &H660 * 69
                Accessfriends = &H100 * 69
                Patchmii = 69
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                Accessmii = &H660 * 70
                Accessfriends = &H100 * 70
                Patchmii = 70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                Accessmii = &H660 * 71
                Accessfriends = &H100 * 71
                Patchmii = 71
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                Accessmii = &H660 * 72
                Accessfriends = &H100 * 72
                Patchmii = 72
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                Accessmii = &H660 * 73
                Accessfriends = &H100 * 73
                Patchmii = 73
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                Accessmii = &H660 * 74
                Accessfriends = &H100 * 74
                Patchmii = 74
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                Accessmii = &H660 * 75
                Accessfriends = &H100 * 75
                Patchmii = 75
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                Accessmii = &H660 * 76
                Accessfriends = &H100 * 76
                Patchmii = 76
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                Accessmii = &H660 * 77
                Accessfriends = &H100 * 77
                Patchmii = 77
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                Accessmii = &H660 * 78
                Accessfriends = &H100 * 78
                Patchmii = 78
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                Accessmii = &H660 * 79
                Accessfriends = &H100 * 79
                Patchmii = 79
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                Accessmii = &H660 * 80
                Accessfriends = &H100 * 80
                Patchmii = 80
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                Accessmii = &H660 * 81
                Accessfriends = &H100 * 81
                Patchmii = 81
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                Accessmii = &H660 * 82
                Accessfriends = &H100 * 82
                Patchmii = 82
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                Accessmii = &H660 * 83
                Accessfriends = &H100 * 83
                Patchmii = 83
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                Accessmii = &H660 * 84
                Accessfriends = &H100 * 84
                Patchmii = 84
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                Accessmii = &H660 * 85
                Accessfriends = &H100 * 85
                Patchmii = 85
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                Accessmii = &H660 * 86
                Accessfriends = &H100 * 86
                Patchmii = 86
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                Accessmii = &H660 * 87
                Accessfriends = &H100 * 87
                Patchmii = 87
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                Accessmii = &H660 * 88
                Accessfriends = &H100 * 88
                Patchmii = 88
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                Accessmii = &H660 * 89
                Accessfriends = &H100 * 89
                Patchmii = 89
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                Accessmii = &H660 * 90
                Accessfriends = &H100 * 90
                Patchmii = 90
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                Accessmii = &H660 * 91
                Accessfriends = &H100 * 91
                Patchmii = 91
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                Accessmii = &H660 * 92
                Accessfriends = &H100 * 92
                Patchmii = 92
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                Accessmii = &H660 * 93
                Accessfriends = &H100 * 93
                Patchmii = 93
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                Accessmii = &H660 * 94
                Accessfriends = &H100 * 94
                Patchmii = 94
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                Accessmii = &H660 * 95
                Accessfriends = &H100 * 95
                Patchmii = 95
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                Accessmii = &H660 * 96
                Accessfriends = &H100 * 96
                Patchmii = 96
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                Accessmii = &H660 * 97
                Accessfriends = &H100 * 97
                Patchmii = 97
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                Accessmii = &H660 * 98
                Accessfriends = &H100 * 98
                Patchmii = 98
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                Accessmii = &H660 * 99
                Accessfriends = &H100 * 99
                Patchmii = 99
            End If
        End If
        If Filever_text.Text = "JP" Then
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Accessmii = &H0
                Accessfriends = &H0
                Patchmii = 0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Accessmii = &H590
                Accessfriends = &H100
                Patchmii = 1
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Accessmii = &H590 * 2
                Accessfriends = &H100 * 2
                Patchmii = 2
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Accessmii = &H590 * 3
                Accessfriends = &H100 * 3
                Patchmii = 3
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Accessmii = &H590 * 4
                Accessfriends = &H100 * 4
                Patchmii = 4
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Accessmii = &H590 * 5
                Accessfriends = &H100 * 5
                Patchmii = 5
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Accessmii = &H590 * 6
                Accessfriends = &H100 * 6
                Patchmii = 6
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Accessmii = &H590 * 7
                Accessfriends = &H100 * 7
                Patchmii = 7
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Accessmii = &H590 * 8
                Accessfriends = &H100 * 8
                Patchmii = 8
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Accessmii = &H590 * 9
                Accessfriends = &H100 * 9
                Patchmii = 9
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Accessmii = &H590 * 10
                Accessfriends = &H100 * 10
                Patchmii = 10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Accessmii = &H590 * 11
                Accessfriends = &H100 * 11
                Patchmii = 11
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Accessmii = &H590 * 12
                Accessfriends = &H100 * 12
                Patchmii = 12
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Accessmii = &H590 * 13
                Accessfriends = &H100 * 13
                Patchmii = 13
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Accessmii = &H590 * 14
                Accessfriends = &H100 * 14
                Patchmii = 14
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Accessmii = &H590 * 15
                Accessfriends = &H100 * 15
                Patchmii = 15
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Accessmii = &H590 * 16
                Accessfriends = &H100 * 16
                Patchmii = 16
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Accessmii = &H590 * 17
                Accessfriends = &H100 * 17
                Patchmii = 17
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Accessmii = &H590 * 18
                Accessfriends = &H100 * 18
                Patchmii = 18
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Accessmii = &H590 * 19
                Accessfriends = &H100 * 19
                Patchmii = 19
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Accessmii = &H590 * 20
                Accessfriends = &H100 * 20
                Patchmii = 20
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Accessmii = &H590 * 21
                Accessfriends = &H100 * 21
                Patchmii = 21
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Accessmii = &H590 * 22
                Accessfriends = &H100 * 22
                Patchmii = 22
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Accessmii = &H590 * 23
                Accessfriends = &H100 * 23
                Patchmii = 23
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Accessmii = &H590 * 24
                Accessfriends = &H100 * 24
                Patchmii = 24
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Accessmii = &H590 * 25
                Accessfriends = &H100 * 25
                Patchmii = 25
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Accessmii = &H590 * 26
                Accessfriends = &H100 * 26
                Patchmii = 26
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Accessmii = &H590 * 27
                Accessfriends = &H100 * 27
                Patchmii = 27
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Accessmii = &H590 * 28
                Accessfriends = &H100 * 28
                Patchmii = 28
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Accessmii = &H590 * 29
                Accessfriends = &H100 * 29
                Patchmii = 29
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Accessmii = &H590 * 30
                Accessfriends = &H100 * 30
                Patchmii = 30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Accessmii = &H590 * 31
                Accessfriends = &H100 * 31
                Patchmii = 31
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Accessmii = &H590 * 32
                Accessfriends = &H100 * 32
                Patchmii = 32
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Accessmii = &H590 * 33
                Accessfriends = &H100 * 33
                Patchmii = 33
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Accessmii = &H590 * 34
                Accessfriends = &H100 * 34
                Patchmii = 34
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Accessmii = &H590 * 35
                Accessfriends = &H100 * 35
                Patchmii = 35
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Accessmii = &H590 * 36
                Accessfriends = &H100 * 36
                Patchmii = 36
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Accessmii = &H590 * 37
                Accessfriends = &H100 * 37
                Patchmii = 37
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Accessmii = &H590 * 38
                Accessfriends = &H100 * 38
                Patchmii = 38
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Accessmii = &H590 * 39
                Accessfriends = &H100 * 39
                Patchmii = 39
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Accessmii = &H590 * 40
                Accessfriends = &H100 * 40
                Patchmii = 40
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Accessmii = &H590 * 41
                Accessfriends = &H100 * 41
                Patchmii = 41
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Accessmii = &H590 * 42
                Accessfriends = &H100 * 42
                Patchmii = 42
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Accessmii = &H590 * 43
                Accessfriends = &H100 * 43
                Patchmii = 43
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Accessmii = &H590 * 44
                Accessfriends = &H100 * 44
                Patchmii = 44
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Accessmii = &H590 * 45
                Accessfriends = &H100 * 45
                Patchmii = 45
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Accessmii = &H590 * 46
                Accessfriends = &H100 * 46
                Patchmii = 46
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Accessmii = &H590 * 47
                Accessfriends = &H100 * 47
                Patchmii = 47
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Accessmii = &H590 * 48
                Accessfriends = &H100 * 48
                Patchmii = 48
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Accessmii = &H590 * 49
                Accessfriends = &H100 * 49
                Patchmii = 49
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                Accessmii = &H590 * 50
                Accessfriends = &H100 * 50
                Patchmii = 50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                Accessmii = &H590 * 51
                Accessfriends = &H100 * 51
                Patchmii = 51
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                Accessmii = &H590 * 52
                Accessfriends = &H100 * 52
                Patchmii = 52
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                Accessmii = &H590 * 53
                Accessfriends = &H100 * 53
                Patchmii = 53
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                Accessmii = &H590 * 54
                Accessfriends = &H100 * 54
                Patchmii = 54
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                Accessmii = &H590 * 55
                Accessfriends = &H100 * 55
                Patchmii = 55
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                Accessmii = &H590 * 56
                Accessfriends = &H100 * 56
                Patchmii = 56
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                Accessmii = &H590 * 57
                Accessfriends = &H100 * 57
                Patchmii = 57
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                Accessmii = &H590 * 58
                Accessfriends = &H100 * 58
                Patchmii = 58
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                Accessmii = &H590 * 59
                Accessfriends = &H100 * 59
                Patchmii = 59
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                Accessmii = &H590 * 60
                Accessfriends = &H100 * 60
                Patchmii = 60
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                Accessmii = &H590 * 61
                Accessfriends = &H100 * 61
                Patchmii = 61
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                Accessmii = &H590 * 62
                Accessfriends = &H100 * 62
                Patchmii = 62
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                Accessmii = &H590 * 63
                Accessfriends = &H100 * 63
                Patchmii = 63
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                Accessmii = &H590 * 64
                Accessfriends = &H100 * 64
                Patchmii = 64
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                Accessmii = &H590 * 65
                Accessfriends = &H100 * 65
                Patchmii = 65
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                Accessmii = &H590 * 66
                Accessfriends = &H100 * 66
                Patchmii = 66
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                Accessmii = &H590 * 67
                Accessfriends = &H100 * 67
                Patchmii = 67
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                Accessmii = &H590 * 68
                Accessfriends = &H100 * 68
                Patchmii = 68
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                Accessmii = &H590 * 69
                Accessfriends = &H100 * 69
                Patchmii = 69
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                Accessmii = &H590 * 70
                Accessfriends = &H100 * 70
                Patchmii = 70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                Accessmii = &H590 * 71
                Accessfriends = &H100 * 71
                Patchmii = 71
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                Accessmii = &H590 * 72
                Accessfriends = &H100 * 72
                Patchmii = 72
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                Accessmii = &H590 * 73
                Accessfriends = &H100 * 73
                Patchmii = 73
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                Accessmii = &H590 * 74
                Accessfriends = &H100 * 74
                Patchmii = 74
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                Accessmii = &H590 * 75
                Accessfriends = &H100 * 75
                Patchmii = 75
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                Accessmii = &H590 * 76
                Accessfriends = &H100 * 76
                Patchmii = 76
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                Accessmii = &H590 * 77
                Accessfriends = &H100 * 77
                Patchmii = 77
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                Accessmii = &H590 * 78
                Accessfriends = &H100 * 78
                Patchmii = 78
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                Accessmii = &H590 * 79
                Accessfriends = &H100 * 79
                Patchmii = 79
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                Accessmii = &H590 * 80
                Accessfriends = &H100 * 80
                Patchmii = 80
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                Accessmii = &H590 * 81
                Accessfriends = &H100 * 81
                Patchmii = 81
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                Accessmii = &H590 * 82
                Accessfriends = &H100 * 82
                Patchmii = 82
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                Accessmii = &H590 * 83
                Accessfriends = &H100 * 83
                Patchmii = 83
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                Accessmii = &H590 * 84
                Accessfriends = &H100 * 84
                Patchmii = 84
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                Accessmii = &H590 * 85
                Accessfriends = &H100 * 85
                Patchmii = 85
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                Accessmii = &H590 * 86
                Accessfriends = &H100 * 86
                Patchmii = 86
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                Accessmii = &H590 * 87
                Accessfriends = &H100 * 87
                Patchmii = 87
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                Accessmii = &H590 * 88
                Accessfriends = &H100 * 88
                Patchmii = 88
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                Accessmii = &H590 * 89
                Accessfriends = &H100 * 89
                Patchmii = 89
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                Accessmii = &H590 * 90
                Accessfriends = &H100 * 90
                Patchmii = 90
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                Accessmii = &H590 * 91
                Accessfriends = &H100 * 91
                Patchmii = 91
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                Accessmii = &H590 * 92
                Accessfriends = &H100 * 92
                Patchmii = 92
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                Accessmii = &H590 * 93
                Accessfriends = &H100 * 93
                Patchmii = 93
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                Accessmii = &H590 * 94
                Accessfriends = &H100 * 94
                Patchmii = 94
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                Accessmii = &H590 * 95
                Accessfriends = &H100 * 95
                Patchmii = 95
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                Accessmii = &H590 * 96
                Accessfriends = &H100 * 96
                Patchmii = 96
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                Accessmii = &H590 * 97
                Accessfriends = &H100 * 97
                Patchmii = 97
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                Accessmii = &H590 * 98
                Accessfriends = &H100 * 98
                Patchmii = 98
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                Accessmii = &H590 * 99
                Accessfriends = &H100 * 99
                Patchmii = 99
            End If
        End If
        readMii()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_editing_mii.Text = "editing " & Text_nickname.Text & " ..."
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_editing_mii.Text = "édition de " & Text_nickname.Text & " ..."
        End If
    End Sub

    Private Sub Setting_music_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_music.CheckedChanged
        startmusic()
    End Sub

    Private Sub Select_music_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_music.SelectedIndexChanged
        startmusic()
    End Sub

    Private Sub Select_relationyou_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_relationyou.SelectedIndexChanged
        If Select_relationyou.SelectedItem = Select_relationyou.Items.Item(0) Then
            valu_relationyou.Value = 4
        End If
        If Select_relationyou.SelectedItem = Select_relationyou.Items.Item(1) Then
            valu_relationyou.Value = 0
        End If
        If Select_relationyou.SelectedItem = Select_relationyou.Items.Item(2) Then
            valu_relationyou.Value = 6
        End If
        If Select_relationyou.SelectedItem = Select_relationyou.Items.Item(3) Then
            valu_relationyou.Value = 3
        End If
        If Select_relationyou.SelectedItem = Select_relationyou.Items.Item(4) Then
            valu_relationyou.Value = 1
        End If
        If Select_relationyou.SelectedItem = Select_relationyou.Items.Item(5) Then
            valu_relationyou.Value = 5
        End If
        If Select_relationyou.SelectedItem = Select_relationyou.Items.Item(6) Then
            valu_relationyou.Value = 2
        End If
    End Sub

    Private Sub valu_relationyou_ValueChanged(sender As Object, e As EventArgs) Handles valu_relationyou.ValueChanged
        If valu_relationyou.Value = 0 Then
            Select_relationyou.SelectedItem = Select_relationyou.Items.Item(1)
        End If
        If valu_relationyou.Value = 1 Then
            Select_relationyou.SelectedItem = Select_relationyou.Items.Item(4)
        End If
        If valu_relationyou.Value = 2 Then
            Select_relationyou.SelectedItem = Select_relationyou.Items.Item(6)
        End If
        If valu_relationyou.Value = 3 Then
            Select_relationyou.SelectedItem = Select_relationyou.Items.Item(3)
        End If
        If valu_relationyou.Value = 4 Then
            Select_relationyou.SelectedItem = Select_relationyou.Items.Item(0)
        End If
        If valu_relationyou.Value = 5 Then
            Select_relationyou.SelectedItem = Select_relationyou.Items.Item(5)
        End If
        If valu_relationyou.Value = 6 Then
            Select_relationyou.SelectedItem = Select_relationyou.Items.Item(2)
        End If
    End Sub

    Private Sub valu_favcolor_ValueChanged(sender As Object, e As EventArgs) Handles valu_favcolor.ValueChanged
        Select Case valu_favcolor.Value
            Case Is <> 83, 17, 19, 16, 18, 22, 23, 36, 20, 21, 29, 30, 28, 31, 1, 67, 3, 2, 0, 26, 24, 89, 25, 7, 71, 4, 5, 6, 10, 11, 8, 9, 12, 14, 13, 15, 32, 33, 34, 35, 38, 37, 39, 41, 42, 40, 43, 45, 111, 47, 44, 46, 86, 93, 27
                Icon_favcolor.Image = My.Resources.color
        End Select
        Select Case valu_favcolor.Value
            Case 83, 17, 19, 16, 18
                Icon_favcolor.Image = My.Resources.color_vert
        End Select
        Select Case valu_favcolor.Value
            Case 22, 23, 20, 21, 86, 85
                Icon_favcolor.Image = My.Resources.color_bleu
        End Select
        Select Case valu_favcolor.Value
            Case 29, 30, 28, 31, 93
                Icon_favcolor.Image = My.Resources.color_rose
        End Select
        Select Case valu_favcolor.Value
            Case 1, 67, 3, 2, 0
                Icon_favcolor.Image = My.Resources.color_rouge
        End Select
        Select Case valu_favcolor.Value
            Case 26, 24, 89, 25, 27
                Icon_favcolor.Image = My.Resources.color_bleuclair
        End Select
        Select Case valu_favcolor.Value
            Case 7, 71, 4, 5, 6
                Icon_favcolor.Image = My.Resources.color_orange
        End Select
        Select Case valu_favcolor.Value
            Case 10, 11, 8, 9
                Icon_favcolor.Image = My.Resources.color_jaune
        End Select
        Select Case valu_favcolor.Value
            Case 12, 14, 13, 15
                Icon_favcolor.Image = My.Resources.color_vertclair
        End Select
        Select Case valu_favcolor.Value
            Case 32, 33, 34, 35
                Icon_favcolor.Image = My.Resources.color_violet
        End Select
        Select Case valu_favcolor.Value
            Case 38, 37, 39, 36
                Icon_favcolor.Image = My.Resources.color_marron
        End Select
        Select Case valu_favcolor.Value
            Case 41, 42, 40, 43
                Icon_favcolor.Image = My.Resources.color_blanc
        End Select
        Select Case valu_favcolor.Value
            Case 45, 111, 47, 44, 46
                Icon_favcolor.Image = My.Resources.color_noir
        End Select
    End Sub

    Private Sub valu_growkid_ValueChanged(sender As Object, e As EventArgs) Handles valu_growkid.ValueChanged
        If valu_growkid.Value = 0 Then
            Select_growkid.SelectedItem = Select_growkid.Items.Item(0)
        End If
        If valu_growkid.Value = 1 Then
            Select_growkid.SelectedItem = Select_growkid.Items.Item(1)
        End If
        If valu_growkid.Value = 2 Then
            Select_growkid.SelectedItem = Select_growkid.Items.Item(2)
        End If
    End Sub

    Private Sub Select_growkid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_growkid.SelectedIndexChanged
        If Select_growkid.SelectedItem = Select_growkid.Items.Item(0) Then
            valu_growkid.Value = 0
            Icon_growkid.Image = My.Resources.grown_up
        End If
        If Select_growkid.SelectedItem = Select_growkid.Items.Item(1) Then
            valu_growkid.Value = 1
            Icon_growkid.Image = My.Resources.grown_up
        End If
        If Select_growkid.SelectedItem = Select_growkid.Items.Item(2) Then
            valu_growkid.Value = 2
            Icon_growkid.Image = My.Resources.kid
        End If
    End Sub

    Private Sub valu_copying_ValueChanged(sender As Object, e As EventArgs) Handles valu_copying.ValueChanged
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            If valu_copying.Value = 0 Then
                Text_copying.Text = "Don't Allow"
            End If
            If valu_copying.Value = 1 Then
                Text_copying.Text = "Allow"
            End If
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            If valu_copying.Value = 0 Then
                Text_copying.Text = "Interdire"
            End If
            If valu_copying.Value = 1 Then
                Text_copying.Text = "Autoriser"
            End If
        End If
    End Sub

    Private Sub valu_sharing_ValueChanged(sender As Object, e As EventArgs) Handles valu_sharing.ValueChanged
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            If valu_sharing.Value Mod 2 = 0 Then
                Text_sharing.Text = "On"
            End If
            If valu_sharing.Value Mod 2 = 1 Then
                Text_sharing.Text = "Off"
            End If
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            If valu_sharing.Value Mod 2 = 0 Then
                Text_sharing.Text = "Oui"
            End If
            If valu_sharing.Value Mod 2 = 1 Then
                Text_sharing.Text = "Non"
            End If
        End If
    End Sub

    Private Sub valu_miiapart_ValueChanged(sender As Object, e As EventArgs) Handles valu_miiapart.ValueChanged
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            If valu_miiapart.Value = 0 Then
                Text_miiapart.Text = "app.101"
            ElseIf valu_miiapart.Value = 1 Then
                Text_miiapart.Text = "app.102"
            ElseIf valu_miiapart.Value = 2 Then
                Text_miiapart.Text = "app.103"
            ElseIf valu_miiapart.Value = 3 Then
                Text_miiapart.Text = "app.104"
            ElseIf valu_miiapart.Value = 4 Then
                Text_miiapart.Text = "app.105"
            ElseIf valu_miiapart.Value = 5 Then
                Text_miiapart.Text = "app.106"
            ElseIf valu_miiapart.Value = 6 Then
                Text_miiapart.Text = "app.107"
            ElseIf valu_miiapart.Value = 7 Then
                Text_miiapart.Text = "app.108"
            ElseIf valu_miiapart.Value = 8 Then
                Text_miiapart.Text = "app.201"
            ElseIf valu_miiapart.Value = 9 Then
                Text_miiapart.Text = "app.202"
            ElseIf valu_miiapart.Value = 10 Then
                Text_miiapart.Text = "app.203"
            ElseIf valu_miiapart.Value = 11 Then
                Text_miiapart.Text = "app.204"
            ElseIf valu_miiapart.Value = 12 Then
                Text_miiapart.Text = "app.205"
            ElseIf valu_miiapart.Value = 13 Then
                Text_miiapart.Text = "app.206"
            ElseIf valu_miiapart.Value = 14 Then
                Text_miiapart.Text = "app.207"
            ElseIf valu_miiapart.Value = 15 Then
                Text_miiapart.Text = "app.208"
            ElseIf valu_miiapart.Value = 16 Then
                Text_miiapart.Text = "app.301"
            ElseIf valu_miiapart.Value = 17 Then
                Text_miiapart.Text = "app.302"
            ElseIf valu_miiapart.Value = 18 Then
                Text_miiapart.Text = "app.303"
            ElseIf valu_miiapart.Value = 19 Then
                Text_miiapart.Text = "app.304"
            ElseIf valu_miiapart.Value = 20 Then
                Text_miiapart.Text = "app.305"
            ElseIf valu_miiapart.Value = 21 Then
                Text_miiapart.Text = "app.306"
            ElseIf valu_miiapart.Value = 22 Then
                Text_miiapart.Text = "app.307"
            ElseIf valu_miiapart.Value = 23 Then
                Text_miiapart.Text = "app.308"
            ElseIf valu_miiapart.Value = 24 Then
                Text_miiapart.Text = "app.401"
            ElseIf valu_miiapart.Value = 25 Then
                Text_miiapart.Text = "app.402"
            ElseIf valu_miiapart.Value = 26 Then
                Text_miiapart.Text = "app.403"
            ElseIf valu_miiapart.Value = 27 Then
                Text_miiapart.Text = "app.404"
            ElseIf valu_miiapart.Value = 28 Then
                Text_miiapart.Text = "app.405"
            ElseIf valu_miiapart.Value = 29 Then
                Text_miiapart.Text = "app.406"
            ElseIf valu_miiapart.Value = 30 Then
                Text_miiapart.Text = "app.407"
            ElseIf valu_miiapart.Value = 31 Then
                Text_miiapart.Text = "app.408"
            ElseIf valu_miiapart.Value = 32 Then
                Text_miiapart.Text = "app.501"
            ElseIf valu_miiapart.Value = 33 Then
                Text_miiapart.Text = "app.502"
            ElseIf valu_miiapart.Value = 34 Then
                Text_miiapart.Text = "app.503"
            ElseIf valu_miiapart.Value = 35 Then
                Text_miiapart.Text = "app.504"
            ElseIf valu_miiapart.Value = 36 Then
                Text_miiapart.Text = "app.505"
            ElseIf valu_miiapart.Value = 37 Then
                Text_miiapart.Text = "app.506"
            ElseIf valu_miiapart.Value = 38 Then
                Text_miiapart.Text = "app.507"
            ElseIf valu_miiapart.Value = 39 Then
                Text_miiapart.Text = "app.508"
            ElseIf valu_miiapart.Value = 40 Then
                Text_miiapart.Text = "app.601"
            ElseIf valu_miiapart.Value = 41 Then
                Text_miiapart.Text = "app.602"
            ElseIf valu_miiapart.Value = 42 Then
                Text_miiapart.Text = "app.603"
            ElseIf valu_miiapart.Value = 43 Then
                Text_miiapart.Text = "app.604"
            ElseIf valu_miiapart.Value = 44 Then
                Text_miiapart.Text = "app.605"
            ElseIf valu_miiapart.Value = 45 Then
                Text_miiapart.Text = "app.606"
            ElseIf valu_miiapart.Value = 46 Then
                Text_miiapart.Text = "app.607"
            ElseIf valu_miiapart.Value = 47 Then
                Text_miiapart.Text = "app.608"
            ElseIf valu_miiapart.Value = 48 Then
                Text_miiapart.Text = "app.701"
            ElseIf valu_miiapart.Value = 49 Then
                Text_miiapart.Text = "app.702"
            ElseIf valu_miiapart.Value = 50 Then
                Text_miiapart.Text = "app.703"
            ElseIf valu_miiapart.Value = 51 Then
                Text_miiapart.Text = "app.704"
            ElseIf valu_miiapart.Value = 52 Then
                Text_miiapart.Text = "app.705"
            ElseIf valu_miiapart.Value = 53 Then
                Text_miiapart.Text = "app.706"
            ElseIf valu_miiapart.Value = 54 Then
                Text_miiapart.Text = "app.707"
            ElseIf valu_miiapart.Value = 55 Then
                Text_miiapart.Text = "app.708"
            ElseIf valu_miiapart.Value = 56 Then
                Text_miiapart.Text = "app.801"
            ElseIf valu_miiapart.Value = 57 Then
                Text_miiapart.Text = "app.802"
            ElseIf valu_miiapart.Value = 58 Then
                Text_miiapart.Text = "app.803"
            ElseIf valu_miiapart.Value = 59 Then
                Text_miiapart.Text = "app.804"
            ElseIf valu_miiapart.Value = 60 Then
                Text_miiapart.Text = "app.805"
            ElseIf valu_miiapart.Value = 61 Then
                Text_miiapart.Text = "app.806"
            ElseIf valu_miiapart.Value = 62 Then
                Text_miiapart.Text = "app.807"
            ElseIf valu_miiapart.Value = 63 Then
                Text_miiapart.Text = "app.808"
            ElseIf valu_miiapart.Value = 64 Then
                Text_miiapart.Text = "app.901"
            ElseIf valu_miiapart.Value = 65 Then
                Text_miiapart.Text = "app.902"
            ElseIf valu_miiapart.Value = 66 Then
                Text_miiapart.Text = "app.903"
            ElseIf valu_miiapart.Value = 67 Then
                Text_miiapart.Text = "app.904"
            ElseIf valu_miiapart.Value = 68 Then
                Text_miiapart.Text = "app.905"
            ElseIf valu_miiapart.Value = 69 Then
                Text_miiapart.Text = "app.906"
            ElseIf valu_miiapart.Value = 70 Then
                Text_miiapart.Text = "app.907"
            ElseIf valu_miiapart.Value = 71 Then
                Text_miiapart.Text = "app.908"
            ElseIf valu_miiapart.Value = 72 Then
                Text_miiapart.Text = "app.1001"
            ElseIf valu_miiapart.Value = 73 Then
                Text_miiapart.Text = "app.1002"
            ElseIf valu_miiapart.Value = 74 Then
                Text_miiapart.Text = "app.1003"
            ElseIf valu_miiapart.Value = 75 Then
                Text_miiapart.Text = "app.1004"
            ElseIf valu_miiapart.Value = 76 Then
                Text_miiapart.Text = "app.1005"
            ElseIf valu_miiapart.Value = 77 Then
                Text_miiapart.Text = "app.1006"
            ElseIf valu_miiapart.Value = 78 Then
                Text_miiapart.Text = "app.1007"
            ElseIf valu_miiapart.Value = 79 Then
                Text_miiapart.Text = "app.1008"
            ElseIf valu_miiapart.Value = 80 Then
                Text_miiapart.Text = "app.1101"
            ElseIf valu_miiapart.Value = 81 Then
                Text_miiapart.Text = "app.1102"
            ElseIf valu_miiapart.Value = 82 Then
                Text_miiapart.Text = "app.1103"
            ElseIf valu_miiapart.Value = 83 Then
                Text_miiapart.Text = "app.1104"
            ElseIf valu_miiapart.Value = 84 Then
                Text_miiapart.Text = "app.1105"
            ElseIf valu_miiapart.Value = 85 Then
                Text_miiapart.Text = "app.1106"
            ElseIf valu_miiapart.Value = 86 Then
                Text_miiapart.Text = "app.1107"
            ElseIf valu_miiapart.Value = 87 Then
                Text_miiapart.Text = "app.1108"
            ElseIf valu_miiapart.Value = 88 Then
                Text_miiapart.Text = "app.1201"
            ElseIf valu_miiapart.Value = 89 Then
                Text_miiapart.Text = "app.1202"
            ElseIf valu_miiapart.Value = 90 Then
                Text_miiapart.Text = "app.1203"
            ElseIf valu_miiapart.Value = 91 Then
                Text_miiapart.Text = "app.1204"
            ElseIf valu_miiapart.Value = 92 Then
                Text_miiapart.Text = "app.1205"
            ElseIf valu_miiapart.Value = 93 Then
                Text_miiapart.Text = "app.1206"
            ElseIf valu_miiapart.Value = 94 Then
                Text_miiapart.Text = "app.1207"
            ElseIf valu_miiapart.Value = 95 Then
                Text_miiapart.Text = "app.1208"
            ElseIf valu_miiapart.Value = 96 Then
                Text_miiapart.Text = "app.1301"
            ElseIf valu_miiapart.Value = 97 Then
                Text_miiapart.Text = "app.1302"
            ElseIf valu_miiapart.Value = 98 Then
                Text_miiapart.Text = "app.1303"
            ElseIf valu_miiapart.Value = 99 Then
                Text_miiapart.Text = "app.1304"
            End If
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            If valu_miiapart.Value = 0 Then
                Text_miiapart.Text = "apt.101"
            ElseIf valu_miiapart.Value = 1 Then
                Text_miiapart.Text = "apt.102"
            ElseIf valu_miiapart.Value = 2 Then
                Text_miiapart.Text = "apt.103"
            ElseIf valu_miiapart.Value = 3 Then
                Text_miiapart.Text = "apt.104"
            ElseIf valu_miiapart.Value = 4 Then
                Text_miiapart.Text = "apt.105"
            ElseIf valu_miiapart.Value = 5 Then
                Text_miiapart.Text = "apt.106"
            ElseIf valu_miiapart.Value = 6 Then
                Text_miiapart.Text = "apt.107"
            ElseIf valu_miiapart.Value = 7 Then
                Text_miiapart.Text = "apt.108"
            ElseIf valu_miiapart.Value = 8 Then
                Text_miiapart.Text = "apt.201"
            ElseIf valu_miiapart.Value = 9 Then
                Text_miiapart.Text = "apt.202"
            ElseIf valu_miiapart.Value = 10 Then
                Text_miiapart.Text = "apt.203"
            ElseIf valu_miiapart.Value = 11 Then
                Text_miiapart.Text = "apt.204"
            ElseIf valu_miiapart.Value = 12 Then
                Text_miiapart.Text = "apt.205"
            ElseIf valu_miiapart.Value = 13 Then
                Text_miiapart.Text = "apt.206"
            ElseIf valu_miiapart.Value = 14 Then
                Text_miiapart.Text = "apt.207"
            ElseIf valu_miiapart.Value = 15 Then
                Text_miiapart.Text = "apt.208"
            ElseIf valu_miiapart.Value = 16 Then
                Text_miiapart.Text = "apt.301"
            ElseIf valu_miiapart.Value = 17 Then
                Text_miiapart.Text = "apt.302"
            ElseIf valu_miiapart.Value = 18 Then
                Text_miiapart.Text = "apt.303"
            ElseIf valu_miiapart.Value = 19 Then
                Text_miiapart.Text = "apt.304"
            ElseIf valu_miiapart.Value = 20 Then
                Text_miiapart.Text = "apt.305"
            ElseIf valu_miiapart.Value = 21 Then
                Text_miiapart.Text = "apt.306"
            ElseIf valu_miiapart.Value = 22 Then
                Text_miiapart.Text = "apt.307"
            ElseIf valu_miiapart.Value = 23 Then
                Text_miiapart.Text = "apt.308"
            ElseIf valu_miiapart.Value = 24 Then
                Text_miiapart.Text = "apt.401"
            ElseIf valu_miiapart.Value = 25 Then
                Text_miiapart.Text = "apt.402"
            ElseIf valu_miiapart.Value = 26 Then
                Text_miiapart.Text = "apt.403"
            ElseIf valu_miiapart.Value = 27 Then
                Text_miiapart.Text = "apt.404"
            ElseIf valu_miiapart.Value = 28 Then
                Text_miiapart.Text = "apt.405"
            ElseIf valu_miiapart.Value = 29 Then
                Text_miiapart.Text = "apt.406"
            ElseIf valu_miiapart.Value = 30 Then
                Text_miiapart.Text = "apt.407"
            ElseIf valu_miiapart.Value = 31 Then
                Text_miiapart.Text = "apt.408"
            ElseIf valu_miiapart.Value = 32 Then
                Text_miiapart.Text = "apt.501"
            ElseIf valu_miiapart.Value = 33 Then
                Text_miiapart.Text = "apt.502"
            ElseIf valu_miiapart.Value = 34 Then
                Text_miiapart.Text = "apt.503"
            ElseIf valu_miiapart.Value = 35 Then
                Text_miiapart.Text = "apt.504"
            ElseIf valu_miiapart.Value = 36 Then
                Text_miiapart.Text = "apt.505"
            ElseIf valu_miiapart.Value = 37 Then
                Text_miiapart.Text = "apt.506"
            ElseIf valu_miiapart.Value = 38 Then
                Text_miiapart.Text = "apt.507"
            ElseIf valu_miiapart.Value = 39 Then
                Text_miiapart.Text = "apt.508"
            ElseIf valu_miiapart.Value = 40 Then
                Text_miiapart.Text = "apt.601"
            ElseIf valu_miiapart.Value = 41 Then
                Text_miiapart.Text = "apt.602"
            ElseIf valu_miiapart.Value = 42 Then
                Text_miiapart.Text = "apt.603"
            ElseIf valu_miiapart.Value = 43 Then
                Text_miiapart.Text = "apt.604"
            ElseIf valu_miiapart.Value = 44 Then
                Text_miiapart.Text = "apt.605"
            ElseIf valu_miiapart.Value = 45 Then
                Text_miiapart.Text = "apt.606"
            ElseIf valu_miiapart.Value = 46 Then
                Text_miiapart.Text = "apt.607"
            ElseIf valu_miiapart.Value = 47 Then
                Text_miiapart.Text = "apt.608"
            ElseIf valu_miiapart.Value = 48 Then
                Text_miiapart.Text = "apt.701"
            ElseIf valu_miiapart.Value = 49 Then
                Text_miiapart.Text = "apt.702"
            ElseIf valu_miiapart.Value = 50 Then
                Text_miiapart.Text = "apt.703"
            ElseIf valu_miiapart.Value = 51 Then
                Text_miiapart.Text = "apt.704"
            ElseIf valu_miiapart.Value = 52 Then
                Text_miiapart.Text = "apt.705"
            ElseIf valu_miiapart.Value = 53 Then
                Text_miiapart.Text = "apt.706"
            ElseIf valu_miiapart.Value = 54 Then
                Text_miiapart.Text = "apt.707"
            ElseIf valu_miiapart.Value = 55 Then
                Text_miiapart.Text = "apt.708"
            ElseIf valu_miiapart.Value = 56 Then
                Text_miiapart.Text = "apt.801"
            ElseIf valu_miiapart.Value = 57 Then
                Text_miiapart.Text = "apt.802"
            ElseIf valu_miiapart.Value = 58 Then
                Text_miiapart.Text = "apt.803"
            ElseIf valu_miiapart.Value = 59 Then
                Text_miiapart.Text = "apt.804"
            ElseIf valu_miiapart.Value = 60 Then
                Text_miiapart.Text = "apt.805"
            ElseIf valu_miiapart.Value = 61 Then
                Text_miiapart.Text = "apt.806"
            ElseIf valu_miiapart.Value = 62 Then
                Text_miiapart.Text = "apt.807"
            ElseIf valu_miiapart.Value = 63 Then
                Text_miiapart.Text = "apt.808"
            ElseIf valu_miiapart.Value = 64 Then
                Text_miiapart.Text = "apt.901"
            ElseIf valu_miiapart.Value = 65 Then
                Text_miiapart.Text = "apt.902"
            ElseIf valu_miiapart.Value = 66 Then
                Text_miiapart.Text = "apt.903"
            ElseIf valu_miiapart.Value = 67 Then
                Text_miiapart.Text = "apt.904"
            ElseIf valu_miiapart.Value = 68 Then
                Text_miiapart.Text = "apt.905"
            ElseIf valu_miiapart.Value = 69 Then
                Text_miiapart.Text = "apt.906"
            ElseIf valu_miiapart.Value = 70 Then
                Text_miiapart.Text = "apt.907"
            ElseIf valu_miiapart.Value = 71 Then
                Text_miiapart.Text = "apt.908"
            ElseIf valu_miiapart.Value = 72 Then
                Text_miiapart.Text = "apt.1001"
            ElseIf valu_miiapart.Value = 73 Then
                Text_miiapart.Text = "apt.1002"
            ElseIf valu_miiapart.Value = 74 Then
                Text_miiapart.Text = "apt.1003"
            ElseIf valu_miiapart.Value = 75 Then
                Text_miiapart.Text = "apt.1004"
            ElseIf valu_miiapart.Value = 76 Then
                Text_miiapart.Text = "apt.1005"
            ElseIf valu_miiapart.Value = 77 Then
                Text_miiapart.Text = "apt.1006"
            ElseIf valu_miiapart.Value = 78 Then
                Text_miiapart.Text = "apt.1007"
            ElseIf valu_miiapart.Value = 79 Then
                Text_miiapart.Text = "apt.1008"
            ElseIf valu_miiapart.Value = 80 Then
                Text_miiapart.Text = "apt.1101"
            ElseIf valu_miiapart.Value = 81 Then
                Text_miiapart.Text = "apt.1102"
            ElseIf valu_miiapart.Value = 82 Then
                Text_miiapart.Text = "apt.1103"
            ElseIf valu_miiapart.Value = 83 Then
                Text_miiapart.Text = "apt.1104"
            ElseIf valu_miiapart.Value = 84 Then
                Text_miiapart.Text = "apt.1105"
            ElseIf valu_miiapart.Value = 85 Then
                Text_miiapart.Text = "apt.1106"
            ElseIf valu_miiapart.Value = 86 Then
                Text_miiapart.Text = "apt.1107"
            ElseIf valu_miiapart.Value = 87 Then
                Text_miiapart.Text = "apt.1108"
            ElseIf valu_miiapart.Value = 88 Then
                Text_miiapart.Text = "apt.1201"
            ElseIf valu_miiapart.Value = 89 Then
                Text_miiapart.Text = "apt.1202"
            ElseIf valu_miiapart.Value = 90 Then
                Text_miiapart.Text = "apt.1203"
            ElseIf valu_miiapart.Value = 91 Then
                Text_miiapart.Text = "apt.1204"
            ElseIf valu_miiapart.Value = 92 Then
                Text_miiapart.Text = "apt.1205"
            ElseIf valu_miiapart.Value = 93 Then
                Text_miiapart.Text = "apt.1206"
            ElseIf valu_miiapart.Value = 94 Then
                Text_miiapart.Text = "apt.1207"
            ElseIf valu_miiapart.Value = 95 Then
                Text_miiapart.Text = "apt.1208"
            ElseIf valu_miiapart.Value = 96 Then
                Text_miiapart.Text = "apt.1301"
            ElseIf valu_miiapart.Value = 97 Then
                Text_miiapart.Text = "apt.1302"
            ElseIf valu_miiapart.Value = 98 Then
                Text_miiapart.Text = "apt.1303"
            ElseIf valu_miiapart.Value = 99 Then
                Text_miiapart.Text = "apt.1304"
            End If
        End If
    End Sub

    Private Sub Text_unlock_music_Click(sender As Object, e As EventArgs) Handles Text_unlock_music.Click
        valu_allmusic.Value = 255
    End Sub

    Private Sub valu_emotions_ValueChanged(sender As Object, e As EventArgs) Handles valu_emotions.ValueChanged
        If valu_emotions.Value = 0 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(0)
        ElseIf valu_emotions.Value = 1 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(1)
        ElseIf valu_emotions.Value = 2 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(2)
        ElseIf valu_emotions.Value = 3 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(3)
        ElseIf valu_emotions.Value = 4 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(4)
        End If
    End Sub

    Private Sub Select_emotions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_emotions.SelectedIndexChanged
        If Select_emotions.SelectedItem = Select_emotions.Items.Item(0) Then
            valu_emotions.Value = 0
        ElseIf Select_emotions.SelectedItem = Select_emotions.Items.Item(1) Then
            valu_emotions.Value = 1
        ElseIf Select_emotions.SelectedItem = Select_emotions.Items.Item(2) Then
            valu_emotions.Value = 2
        ElseIf Select_emotions.SelectedItem = Select_emotions.Items.Item(3) Then
            valu_emotions.Value = 3
        ElseIf Select_emotions.SelectedItem = Select_emotions.Items.Item(4) Then
            valu_emotions.Value = 4
        End If
    End Sub

    Private Sub Select_interaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_interaction.SelectedIndexChanged
        If Select_interaction.SelectedItem = Select_interaction.Items.Item(0) Then
            Icon_interaction.Visible = False
            Text_interaction.Text = "00000000000000000000000CFFFFFFFF"
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(1) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_black
            Text_interaction.Text = "3EC1EF21000000000001010CFFFFFFFF"
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(2) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_black
            Text_interaction.Text = "002AF521000000000001000CFFFFFFFF"
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(3) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_black
            Text_interaction.Text = "74DEF521000000000001000CFFFFFFFF"
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(4) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_pink
            Text_interaction.Text = "86F5FF21000000004C01000C0000FFFF"
            valu_target1.Value = 0
            valu_target2.Value = 65535
            valu_target1.Visible = False
            valu_target2.Visible = False
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(5) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_orange
            Text_interaction.Text = "0906F421000000005801000C0000FFFF"
            valu_target1.Value = 0
            valu_target2.Value = 65535
            valu_target1.Visible = False
            valu_target2.Visible = False
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(6) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_orange
            Text_interaction.Text = "7E0AF621000000005801000C0000FFFF"
            valu_target1.Value = 0
            valu_target2.Value = 65535
            valu_target1.Visible = False
            valu_target2.Visible = False
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(7) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_pink
            Text_interaction.Text = "2F430022000000005001000C0000FFFF"
            valu_target1.Value = 0
            valu_target2.Value = 0
            valu_target1.Visible = False
            valu_target2.Visible = False
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(8) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_black
            Text_interaction.Text = "1600F621000000005801000C0000FFFF"
            valu_target1.Value = 0
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(9) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_black
            Text_interaction.Text = "59D6F521000000002501000CFFFFFFFF"
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(10) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_black
            Text_interaction.Text = "8ED5F521000000002F01000CFFFFFFFF"
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(11) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_black
            Text_interaction.Text = "9E5CF621000000003501010CFFFFFFFF"
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(12) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_black
            Text_interaction.Text = "8E5FF621000000008E01000CFFFFFFFF"
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            valu_target1.Visible = True
            valu_target2.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(13) Then
            Icon_interaction.Visible = True
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Icon_interaction.Image = My.Resources.apartment_blue
            ElseIf Filever_text.Text = "JP" Then
                Icon_interaction.Image = My.Resources.apartment_blue_j
            End If
            Text_interaction.Text = "78FAF821000000005F01000C0000FFFF"
            valu_target1.Value = 0
            valu_target2.Value = 65535
            valu_target1.Visible = False
            valu_target2.Visible = False
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(14) Then
            Icon_interaction.Visible = True
            Icon_interaction.Image = My.Resources.apartment_pink
            Text_interaction.Text = "C69E0822000000005401000C0000FFFF"
            valu_target1.Value = 0
            valu_target2.Value = 65535
            valu_target1.Visible = False
            valu_target2.Visible = False
        Else
            Icon_interaction.Visible = False
        End If
    End Sub

    Private Sub Text_save_mii_Click(sender As Object, e As EventArgs) Handles Text_save_mii.Click
        writeMii()
    End Sub

    Private Sub Select_target1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_target1.SelectedIndexChanged
        If Select_target1.SelectedItem = Select_target1.Items.Item(0) Then
            valu_target1.Value = 65535
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(1) Then
            valu_target1.Value = 0
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(2) Then
            valu_target1.Value = 1
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(3) Then
            valu_target1.Value = 2
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(4) Then
            valu_target1.Value = 3
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(5) Then
            valu_target1.Value = 4
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(6) Then
            valu_target1.Value = 5
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(7) Then
            valu_target1.Value = 6
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(8) Then
            valu_target1.Value = 7
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(9) Then
            valu_target1.Value = 8
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(10) Then
            valu_target1.Value = 9
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(11) Then
            valu_target1.Value = 10
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(12) Then
            valu_target1.Value = 11
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(13) Then
            valu_target1.Value = 12
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(14) Then
            valu_target1.Value = 13
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(15) Then
            valu_target1.Value = 14
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(16) Then
            valu_target1.Value = 15
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(17) Then
            valu_target1.Value = 16
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(18) Then
            valu_target1.Value = 17
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(19) Then
            valu_target1.Value = 18
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(20) Then
            valu_target1.Value = 19
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(21) Then
            valu_target1.Value = 20
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(22) Then
            valu_target1.Value = 21
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(23) Then
            valu_target1.Value = 22
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(24) Then
            valu_target1.Value = 23
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(25) Then
            valu_target1.Value = 24
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(26) Then
            valu_target1.Value = 25
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(27) Then
            valu_target1.Value = 26
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(28) Then
            valu_target1.Value = 27
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(29) Then
            valu_target1.Value = 28
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(30) Then
            valu_target1.Value = 29
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(31) Then
            valu_target1.Value = 30
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(32) Then
            valu_target1.Value = 31
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(33) Then
            valu_target1.Value = 32
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(34) Then
            valu_target1.Value = 33
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(35) Then
            valu_target1.Value = 34
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(36) Then
            valu_target1.Value = 35
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(37) Then
            valu_target1.Value = 36
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(38) Then
            valu_target1.Value = 37
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(39) Then
            valu_target1.Value = 38
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(40) Then
            valu_target1.Value = 39
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(41) Then
            valu_target1.Value = 40
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(42) Then
            valu_target1.Value = 41
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(43) Then
            valu_target1.Value = 42
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(44) Then
            valu_target1.Value = 43
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(45) Then
            valu_target1.Value = 44
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(46) Then
            valu_target1.Value = 45
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(47) Then
            valu_target1.Value = 46
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(48) Then
            valu_target1.Value = 47
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(49) Then
            valu_target1.Value = 48
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(50) Then
            valu_target1.Value = 49
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(51) Then
            valu_target1.Value = 50
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(52) Then
            valu_target1.Value = 51
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(53) Then
            valu_target1.Value = 52
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(54) Then
            valu_target1.Value = 53
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(55) Then
            valu_target1.Value = 54
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(56) Then
            valu_target1.Value = 55
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(57) Then
            valu_target1.Value = 56
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(58) Then
            valu_target1.Value = 57
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(59) Then
            valu_target1.Value = 58
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(60) Then
            valu_target1.Value = 59
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(61) Then
            valu_target1.Value = 60
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(62) Then
            valu_target1.Value = 61
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(63) Then
            valu_target1.Value = 62
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(64) Then
            valu_target1.Value = 63
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(65) Then
            valu_target1.Value = 64
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(66) Then
            valu_target1.Value = 65
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(67) Then
            valu_target1.Value = 66
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(68) Then
            valu_target1.Value = 67
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(69) Then
            valu_target1.Value = 68
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(70) Then
            valu_target1.Value = 69
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(71) Then
            valu_target1.Value = 70
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(72) Then
            valu_target1.Value = 71
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(73) Then
            valu_target1.Value = 72
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(74) Then
            valu_target1.Value = 73
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(75) Then
            valu_target1.Value = 74
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(76) Then
            valu_target1.Value = 75
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(77) Then
            valu_target1.Value = 76
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(78) Then
            valu_target1.Value = 77
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(79) Then
            valu_target1.Value = 78
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(80) Then
            valu_target1.Value = 79
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(81) Then
            valu_target1.Value = 80
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(82) Then
            valu_target1.Value = 81
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(83) Then
            valu_target1.Value = 82
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(84) Then
            valu_target1.Value = 83
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(85) Then
            valu_target1.Value = 84
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(86) Then
            valu_target1.Value = 85
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(87) Then
            valu_target1.Value = 86
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(88) Then
            valu_target1.Value = 87
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(89) Then
            valu_target1.Value = 88
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(90) Then
            valu_target1.Value = 89
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(91) Then
            valu_target1.Value = 90
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(92) Then
            valu_target1.Value = 91
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(93) Then
            valu_target1.Value = 92
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(94) Then
            valu_target1.Value = 93
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(95) Then
            valu_target1.Value = 94
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(96) Then
            valu_target1.Value = 95
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(97) Then
            valu_target1.Value = 96
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(98) Then
            valu_target1.Value = 97
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(99) Then
            valu_target1.Value = 98
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(100) Then
            valu_target1.Value = 99
        End If
    End Sub

    Private Sub Select_target2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_target2.SelectedIndexChanged
        If Select_target2.SelectedItem = Select_target2.Items.Item(0) Then
            valu_target1.Value = 65535
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(1) Then
            valu_target1.Value = 0
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(2) Then
            valu_target1.Value = 1
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(3) Then
            valu_target1.Value = 2
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(4) Then
            valu_target1.Value = 3
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(5) Then
            valu_target1.Value = 4
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(6) Then
            valu_target1.Value = 5
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(7) Then
            valu_target1.Value = 6
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(8) Then
            valu_target1.Value = 7
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(9) Then
            valu_target1.Value = 8
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(10) Then
            valu_target1.Value = 9
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(11) Then
            valu_target1.Value = 10
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(12) Then
            valu_target1.Value = 11
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(13) Then
            valu_target1.Value = 12
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(14) Then
            valu_target1.Value = 13
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(15) Then
            valu_target1.Value = 14
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(16) Then
            valu_target1.Value = 15
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(17) Then
            valu_target1.Value = 16
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(18) Then
            valu_target1.Value = 17
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(19) Then
            valu_target1.Value = 18
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(20) Then
            valu_target1.Value = 19
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(21) Then
            valu_target1.Value = 20
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(22) Then
            valu_target1.Value = 21
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(23) Then
            valu_target1.Value = 22
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(24) Then
            valu_target1.Value = 23
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(25) Then
            valu_target1.Value = 24
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(26) Then
            valu_target1.Value = 25
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(27) Then
            valu_target1.Value = 26
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(28) Then
            valu_target1.Value = 27
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(29) Then
            valu_target1.Value = 28
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(30) Then
            valu_target1.Value = 29
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(31) Then
            valu_target1.Value = 30
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(32) Then
            valu_target1.Value = 31
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(33) Then
            valu_target1.Value = 32
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(34) Then
            valu_target1.Value = 33
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(35) Then
            valu_target1.Value = 34
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(36) Then
            valu_target1.Value = 35
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(37) Then
            valu_target1.Value = 36
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(38) Then
            valu_target1.Value = 37
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(39) Then
            valu_target1.Value = 38
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(40) Then
            valu_target1.Value = 39
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(41) Then
            valu_target1.Value = 40
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(42) Then
            valu_target1.Value = 41
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(43) Then
            valu_target1.Value = 42
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(44) Then
            valu_target1.Value = 43
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(45) Then
            valu_target1.Value = 44
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(46) Then
            valu_target1.Value = 45
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(47) Then
            valu_target1.Value = 46
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(48) Then
            valu_target1.Value = 47
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(49) Then
            valu_target1.Value = 48
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(50) Then
            valu_target1.Value = 49
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(51) Then
            valu_target1.Value = 50
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(52) Then
            valu_target1.Value = 51
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(53) Then
            valu_target1.Value = 52
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(54) Then
            valu_target1.Value = 53
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(55) Then
            valu_target1.Value = 54
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(56) Then
            valu_target1.Value = 55
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(57) Then
            valu_target1.Value = 56
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(58) Then
            valu_target1.Value = 57
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(59) Then
            valu_target1.Value = 58
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(60) Then
            valu_target1.Value = 59
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(61) Then
            valu_target1.Value = 60
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(62) Then
            valu_target1.Value = 61
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(63) Then
            valu_target1.Value = 62
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(64) Then
            valu_target1.Value = 63
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(65) Then
            valu_target1.Value = 64
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(66) Then
            valu_target1.Value = 65
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(67) Then
            valu_target1.Value = 66
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(68) Then
            valu_target1.Value = 67
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(69) Then
            valu_target1.Value = 68
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(70) Then
            valu_target1.Value = 69
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(71) Then
            valu_target1.Value = 70
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(72) Then
            valu_target1.Value = 71
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(73) Then
            valu_target1.Value = 72
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(74) Then
            valu_target1.Value = 73
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(75) Then
            valu_target1.Value = 74
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(76) Then
            valu_target1.Value = 75
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(77) Then
            valu_target1.Value = 76
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(78) Then
            valu_target1.Value = 77
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(79) Then
            valu_target1.Value = 78
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(80) Then
            valu_target1.Value = 79
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(81) Then
            valu_target1.Value = 80
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(82) Then
            valu_target1.Value = 81
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(83) Then
            valu_target1.Value = 82
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(84) Then
            valu_target1.Value = 83
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(85) Then
            valu_target1.Value = 84
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(86) Then
            valu_target1.Value = 85
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(87) Then
            valu_target1.Value = 86
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(88) Then
            valu_target1.Value = 87
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(89) Then
            valu_target1.Value = 88
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(90) Then
            valu_target1.Value = 89
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(91) Then
            valu_target1.Value = 90
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(92) Then
            valu_target1.Value = 91
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(93) Then
            valu_target1.Value = 92
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(94) Then
            valu_target1.Value = 93
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(95) Then
            valu_target1.Value = 94
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(96) Then
            valu_target1.Value = 95
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(97) Then
            valu_target1.Value = 96
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(98) Then
            valu_target1.Value = 97
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(99) Then
            valu_target1.Value = 98
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(100) Then
            valu_target1.Value = 99
        End If
    End Sub

    Private Sub Select_allfriends_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_allfriends.SelectedIndexChanged
        If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
            Patchmii = &H0

        End If
        If Select_allfriends.SelectedItem = Select_allfriends.Items.Item(0) Then
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                AccessMiilist = &H1C8A
                Accessfriendlist = Miifriendr
                Accessrelalist = Miifriendr + &H64
            End If
            If Filever_text.Text = "JP" Then
                AccessMiilist = &H1C5A
                Accessfriendlist = Miifriendr
                Accessrelalist = Miifriendr + &H64
            End If
        ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(1) Then
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                AccessMiilist = &H1C8A + (&H660 * 30)
                Accessfriendlist = Miifriendr + 30
                Accessrelalist = (Miifriendr + &H64) + 30
            End If
            If Filever_text.Text = "JP" Then
                AccessMiilist = &H1C5A + (&H590 * 30)
                Accessfriendlist = Miifriendr + 30
                Accessrelalist = (Miifriendr + &H64) + 30
            End If
        ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(2) Then
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                AccessMiilist = &H1C8A + (&H660 * 60)
                Accessfriendlist = Miifriendr + 60
                Accessrelalist = (Miifriendr + &H64) + 60
            End If
            If Filever_text.Text = "JP" Then
                AccessMiilist = &H1C5A + (&H590 * 60)
                Accessfriendlist = Miifriendr + 60
                Accessrelalist = (Miifriendr + &H64) + 60
            End If
        ElseIf Select_allfriends.SelectedItem = Select_allfriends.Items.Item(3) Then
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                AccessMiilist = &H1C8A + (&H660 * 90)
                Accessfriendlist = Miifriendr + 90
                Accessrelalist = (Miifriendr + &H64) + 90
            End If
            If Filever_text.Text = "JP" Then
                AccessMiilist = &H1C5A + (&H590 * 90)
                Accessfriendlist = Miifriendr + 90
                Accessrelalist = (Miifriendr + &H64) + 90
            End If
        End If
        hidefriendlist()
        readfriendlist()
    End Sub

    Private Sub Select_friend_rela_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_1.SelectedIndexChanged
        If Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(0) Then
            valu_selfriend_rela_1.Value = 0
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(1) Then
            valu_selfriend_rela_1.Value = 1
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(2) Then
            valu_selfriend_rela_1.Value = 2
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(3) Then
            valu_selfriend_rela_1.Value = 3
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(4) Then
            valu_selfriend_rela_1.Value = 4
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(5) Then
            valu_selfriend_rela_1.Value = 6
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(6) Then
            valu_selfriend_rela_1.Value = 7
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(7) Then
            valu_selfriend_rela_1.Value = 8
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(8) Then
            valu_selfriend_rela_1.Value = 9
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(9) Then
            valu_selfriend_rela_1.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_2.SelectedIndexChanged
        If Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(0) Then
            valu_selfriend_rela_2.Value = 0
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(1) Then
            valu_selfriend_rela_2.Value = 1
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(2) Then
            valu_selfriend_rela_2.Value = 2
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(3) Then
            valu_selfriend_rela_2.Value = 3
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(4) Then
            valu_selfriend_rela_2.Value = 4
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(5) Then
            valu_selfriend_rela_2.Value = 6
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(6) Then
            valu_selfriend_rela_2.Value = 7
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(7) Then
            valu_selfriend_rela_2.Value = 8
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(8) Then
            valu_selfriend_rela_2.Value = 9
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(9) Then
            valu_selfriend_rela_2.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_3.SelectedIndexChanged
        If Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(0) Then
            valu_selfriend_rela_3.Value = 0
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(1) Then
            valu_selfriend_rela_3.Value = 1
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(2) Then
            valu_selfriend_rela_3.Value = 2
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(3) Then
            valu_selfriend_rela_3.Value = 3
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(4) Then
            valu_selfriend_rela_3.Value = 4
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(5) Then
            valu_selfriend_rela_3.Value = 6
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(6) Then
            valu_selfriend_rela_3.Value = 7
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(7) Then
            valu_selfriend_rela_3.Value = 8
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(8) Then
            valu_selfriend_rela_3.Value = 9
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(9) Then
            valu_selfriend_rela_3.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_4.SelectedIndexChanged
        If Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(0) Then
            valu_selfriend_rela_4.Value = 0
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(1) Then
            valu_selfriend_rela_4.Value = 1
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(2) Then
            valu_selfriend_rela_4.Value = 2
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(3) Then
            valu_selfriend_rela_4.Value = 3
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(4) Then
            valu_selfriend_rela_4.Value = 4
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(5) Then
            valu_selfriend_rela_4.Value = 6
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(6) Then
            valu_selfriend_rela_4.Value = 7
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(7) Then
            valu_selfriend_rela_4.Value = 8
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(8) Then
            valu_selfriend_rela_4.Value = 9
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(9) Then
            valu_selfriend_rela_4.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_5.SelectedIndexChanged
        If Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(0) Then
            valu_selfriend_rela_5.Value = 0
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(1) Then
            valu_selfriend_rela_5.Value = 1
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(2) Then
            valu_selfriend_rela_5.Value = 2
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(3) Then
            valu_selfriend_rela_5.Value = 3
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(4) Then
            valu_selfriend_rela_5.Value = 4
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(5) Then
            valu_selfriend_rela_5.Value = 6
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(6) Then
            valu_selfriend_rela_5.Value = 7
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(7) Then
            valu_selfriend_rela_5.Value = 8
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(8) Then
            valu_selfriend_rela_5.Value = 9
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(9) Then
            valu_selfriend_rela_5.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_6.SelectedIndexChanged
        If Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(0) Then
            valu_selfriend_rela_6.Value = 0
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(1) Then
            valu_selfriend_rela_6.Value = 1
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(2) Then
            valu_selfriend_rela_6.Value = 2
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(3) Then
            valu_selfriend_rela_6.Value = 3
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(4) Then
            valu_selfriend_rela_6.Value = 4
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(5) Then
            valu_selfriend_rela_6.Value = 6
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(6) Then
            valu_selfriend_rela_6.Value = 7
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(7) Then
            valu_selfriend_rela_6.Value = 8
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(8) Then
            valu_selfriend_rela_6.Value = 9
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(9) Then
            valu_selfriend_rela_6.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_7.SelectedIndexChanged
        If Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(0) Then
            valu_selfriend_rela_7.Value = 0
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(1) Then
            valu_selfriend_rela_7.Value = 1
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(2) Then
            valu_selfriend_rela_7.Value = 2
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(3) Then
            valu_selfriend_rela_7.Value = 3
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(4) Then
            valu_selfriend_rela_7.Value = 4
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(5) Then
            valu_selfriend_rela_7.Value = 6
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(6) Then
            valu_selfriend_rela_7.Value = 7
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(7) Then
            valu_selfriend_rela_7.Value = 8
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(8) Then
            valu_selfriend_rela_7.Value = 9
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(9) Then
            valu_selfriend_rela_7.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_8.SelectedIndexChanged
        If Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(0) Then
            valu_selfriend_rela_8.Value = 0
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(1) Then
            valu_selfriend_rela_8.Value = 1
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(2) Then
            valu_selfriend_rela_8.Value = 2
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(3) Then
            valu_selfriend_rela_8.Value = 3
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(4) Then
            valu_selfriend_rela_8.Value = 4
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(5) Then
            valu_selfriend_rela_8.Value = 6
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(6) Then
            valu_selfriend_rela_8.Value = 7
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(7) Then
            valu_selfriend_rela_8.Value = 8
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(8) Then
            valu_selfriend_rela_8.Value = 9
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(9) Then
            valu_selfriend_rela_8.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_9.SelectedIndexChanged
        If Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(0) Then
            valu_selfriend_rela_9.Value = 0
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(1) Then
            valu_selfriend_rela_9.Value = 1
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(2) Then
            valu_selfriend_rela_9.Value = 2
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(3) Then
            valu_selfriend_rela_9.Value = 3
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(4) Then
            valu_selfriend_rela_9.Value = 4
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(5) Then
            valu_selfriend_rela_9.Value = 6
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(6) Then
            valu_selfriend_rela_9.Value = 7
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(7) Then
            valu_selfriend_rela_9.Value = 8
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(8) Then
            valu_selfriend_rela_9.Value = 9
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(9) Then
            valu_selfriend_rela_9.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_10.SelectedIndexChanged
        If Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(0) Then
            valu_selfriend_rela_10.Value = 0
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(1) Then
            valu_selfriend_rela_10.Value = 1
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(2) Then
            valu_selfriend_rela_10.Value = 2
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(3) Then
            valu_selfriend_rela_10.Value = 3
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(4) Then
            valu_selfriend_rela_10.Value = 4
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(5) Then
            valu_selfriend_rela_10.Value = 6
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(6) Then
            valu_selfriend_rela_10.Value = 7
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(7) Then
            valu_selfriend_rela_10.Value = 8
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(8) Then
            valu_selfriend_rela_10.Value = 9
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(9) Then
            valu_selfriend_rela_10.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_11.SelectedIndexChanged
        If Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(0) Then
            valu_selfriend_rela_11.Value = 0
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(1) Then
            valu_selfriend_rela_11.Value = 1
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(2) Then
            valu_selfriend_rela_11.Value = 2
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(3) Then
            valu_selfriend_rela_11.Value = 3
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(4) Then
            valu_selfriend_rela_11.Value = 4
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(5) Then
            valu_selfriend_rela_11.Value = 6
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(6) Then
            valu_selfriend_rela_11.Value = 7
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(7) Then
            valu_selfriend_rela_11.Value = 8
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(8) Then
            valu_selfriend_rela_11.Value = 9
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(9) Then
            valu_selfriend_rela_11.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_12.SelectedIndexChanged
        If Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(0) Then
            valu_selfriend_rela_12.Value = 0
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(1) Then
            valu_selfriend_rela_12.Value = 1
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(2) Then
            valu_selfriend_rela_12.Value = 2
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(3) Then
            valu_selfriend_rela_12.Value = 3
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(4) Then
            valu_selfriend_rela_12.Value = 4
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(5) Then
            valu_selfriend_rela_12.Value = 6
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(6) Then
            valu_selfriend_rela_12.Value = 7
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(7) Then
            valu_selfriend_rela_12.Value = 8
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(8) Then
            valu_selfriend_rela_12.Value = 9
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(9) Then
            valu_selfriend_rela_12.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_13.SelectedIndexChanged
        If Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(0) Then
            valu_selfriend_rela_13.Value = 0
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(1) Then
            valu_selfriend_rela_13.Value = 1
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(2) Then
            valu_selfriend_rela_13.Value = 2
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(3) Then
            valu_selfriend_rela_13.Value = 3
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(4) Then
            valu_selfriend_rela_13.Value = 4
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(5) Then
            valu_selfriend_rela_13.Value = 6
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(6) Then
            valu_selfriend_rela_13.Value = 7
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(7) Then
            valu_selfriend_rela_13.Value = 8
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(8) Then
            valu_selfriend_rela_13.Value = 9
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(9) Then
            valu_selfriend_rela_13.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_14.SelectedIndexChanged
        If Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(0) Then
            valu_selfriend_rela_14.Value = 0
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(1) Then
            valu_selfriend_rela_14.Value = 1
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(2) Then
            valu_selfriend_rela_14.Value = 2
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(3) Then
            valu_selfriend_rela_14.Value = 3
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(4) Then
            valu_selfriend_rela_14.Value = 4
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(5) Then
            valu_selfriend_rela_14.Value = 6
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(6) Then
            valu_selfriend_rela_14.Value = 7
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(7) Then
            valu_selfriend_rela_14.Value = 8
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(8) Then
            valu_selfriend_rela_14.Value = 9
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(9) Then
            valu_selfriend_rela_14.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_15.SelectedIndexChanged
        If Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(0) Then
            valu_selfriend_rela_15.Value = 0
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(1) Then
            valu_selfriend_rela_15.Value = 1
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(2) Then
            valu_selfriend_rela_15.Value = 2
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(3) Then
            valu_selfriend_rela_15.Value = 3
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(4) Then
            valu_selfriend_rela_15.Value = 4
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(5) Then
            valu_selfriend_rela_15.Value = 6
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(6) Then
            valu_selfriend_rela_15.Value = 7
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(7) Then
            valu_selfriend_rela_15.Value = 8
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(8) Then
            valu_selfriend_rela_15.Value = 9
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(9) Then
            valu_selfriend_rela_15.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_16.SelectedIndexChanged
        If Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(0) Then
            valu_selfriend_rela_16.Value = 0
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(1) Then
            valu_selfriend_rela_16.Value = 1
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(2) Then
            valu_selfriend_rela_16.Value = 2
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(3) Then
            valu_selfriend_rela_16.Value = 3
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(4) Then
            valu_selfriend_rela_16.Value = 4
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(5) Then
            valu_selfriend_rela_16.Value = 6
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(6) Then
            valu_selfriend_rela_16.Value = 7
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(7) Then
            valu_selfriend_rela_16.Value = 8
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(8) Then
            valu_selfriend_rela_16.Value = 9
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(9) Then
            valu_selfriend_rela_16.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_17.SelectedIndexChanged
        If Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(0) Then
            valu_selfriend_rela_17.Value = 0
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(1) Then
            valu_selfriend_rela_17.Value = 1
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(2) Then
            valu_selfriend_rela_17.Value = 2
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(3) Then
            valu_selfriend_rela_17.Value = 3
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(4) Then
            valu_selfriend_rela_17.Value = 4
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(5) Then
            valu_selfriend_rela_17.Value = 6
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(6) Then
            valu_selfriend_rela_17.Value = 7
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(7) Then
            valu_selfriend_rela_17.Value = 8
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(8) Then
            valu_selfriend_rela_17.Value = 9
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(9) Then
            valu_selfriend_rela_17.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_18.SelectedIndexChanged
        If Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(0) Then
            valu_selfriend_rela_18.Value = 0
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(1) Then
            valu_selfriend_rela_18.Value = 1
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(2) Then
            valu_selfriend_rela_18.Value = 2
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(3) Then
            valu_selfriend_rela_18.Value = 3
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(4) Then
            valu_selfriend_rela_18.Value = 4
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(5) Then
            valu_selfriend_rela_18.Value = 6
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(6) Then
            valu_selfriend_rela_18.Value = 7
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(7) Then
            valu_selfriend_rela_18.Value = 8
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(8) Then
            valu_selfriend_rela_18.Value = 9
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(9) Then
            valu_selfriend_rela_18.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_19.SelectedIndexChanged
        If Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(0) Then
            valu_selfriend_rela_19.Value = 0
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(1) Then
            valu_selfriend_rela_19.Value = 1
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(2) Then
            valu_selfriend_rela_19.Value = 2
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(3) Then
            valu_selfriend_rela_19.Value = 3
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(4) Then
            valu_selfriend_rela_19.Value = 4
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(5) Then
            valu_selfriend_rela_19.Value = 6
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(6) Then
            valu_selfriend_rela_19.Value = 7
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(7) Then
            valu_selfriend_rela_19.Value = 8
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(8) Then
            valu_selfriend_rela_19.Value = 9
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(9) Then
            valu_selfriend_rela_19.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_20.SelectedIndexChanged
        If Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(0) Then
            valu_selfriend_rela_20.Value = 0
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(1) Then
            valu_selfriend_rela_20.Value = 1
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(2) Then
            valu_selfriend_rela_20.Value = 2
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(3) Then
            valu_selfriend_rela_20.Value = 3
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(4) Then
            valu_selfriend_rela_20.Value = 4
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(5) Then
            valu_selfriend_rela_20.Value = 6
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(6) Then
            valu_selfriend_rela_20.Value = 7
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(7) Then
            valu_selfriend_rela_20.Value = 8
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(8) Then
            valu_selfriend_rela_20.Value = 9
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(9) Then
            valu_selfriend_rela_20.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_21_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_21.SelectedIndexChanged
        If Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(0) Then
            valu_selfriend_rela_21.Value = 0
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(1) Then
            valu_selfriend_rela_21.Value = 1
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(2) Then
            valu_selfriend_rela_21.Value = 2
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(3) Then
            valu_selfriend_rela_21.Value = 3
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(4) Then
            valu_selfriend_rela_21.Value = 4
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(5) Then
            valu_selfriend_rela_21.Value = 6
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(6) Then
            valu_selfriend_rela_21.Value = 7
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(7) Then
            valu_selfriend_rela_21.Value = 8
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(8) Then
            valu_selfriend_rela_21.Value = 9
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(9) Then
            valu_selfriend_rela_21.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_22_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_22.SelectedIndexChanged
        If Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(0) Then
            valu_selfriend_rela_22.Value = 0
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(1) Then
            valu_selfriend_rela_22.Value = 1
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(2) Then
            valu_selfriend_rela_22.Value = 2
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(3) Then
            valu_selfriend_rela_22.Value = 3
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(4) Then
            valu_selfriend_rela_22.Value = 4
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(5) Then
            valu_selfriend_rela_22.Value = 6
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(6) Then
            valu_selfriend_rela_22.Value = 7
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(7) Then
            valu_selfriend_rela_22.Value = 8
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(8) Then
            valu_selfriend_rela_22.Value = 9
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(9) Then
            valu_selfriend_rela_22.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_23_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_23.SelectedIndexChanged
        If Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(0) Then
            valu_selfriend_rela_23.Value = 0
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(1) Then
            valu_selfriend_rela_23.Value = 1
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(2) Then
            valu_selfriend_rela_23.Value = 2
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(3) Then
            valu_selfriend_rela_23.Value = 3
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(4) Then
            valu_selfriend_rela_23.Value = 4
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(5) Then
            valu_selfriend_rela_23.Value = 6
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(6) Then
            valu_selfriend_rela_23.Value = 7
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(7) Then
            valu_selfriend_rela_23.Value = 8
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(8) Then
            valu_selfriend_rela_23.Value = 9
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(9) Then
            valu_selfriend_rela_23.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_24_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_24.SelectedIndexChanged
        If Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(0) Then
            valu_selfriend_rela_24.Value = 0
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(1) Then
            valu_selfriend_rela_24.Value = 1
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(2) Then
            valu_selfriend_rela_24.Value = 2
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(3) Then
            valu_selfriend_rela_24.Value = 3
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(4) Then
            valu_selfriend_rela_24.Value = 4
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(5) Then
            valu_selfriend_rela_24.Value = 6
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(6) Then
            valu_selfriend_rela_24.Value = 7
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(7) Then
            valu_selfriend_rela_24.Value = 8
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(8) Then
            valu_selfriend_rela_24.Value = 9
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(9) Then
            valu_selfriend_rela_24.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_25_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_25.SelectedIndexChanged
        If Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(0) Then
            valu_selfriend_rela_25.Value = 0
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(1) Then
            valu_selfriend_rela_25.Value = 1
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(2) Then
            valu_selfriend_rela_25.Value = 2
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(3) Then
            valu_selfriend_rela_25.Value = 3
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(4) Then
            valu_selfriend_rela_25.Value = 4
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(5) Then
            valu_selfriend_rela_25.Value = 6
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(6) Then
            valu_selfriend_rela_25.Value = 7
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(7) Then
            valu_selfriend_rela_25.Value = 8
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(8) Then
            valu_selfriend_rela_25.Value = 9
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(9) Then
            valu_selfriend_rela_25.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_26_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_26.SelectedIndexChanged
        If Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(0) Then
            valu_selfriend_rela_26.Value = 0
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(1) Then
            valu_selfriend_rela_26.Value = 1
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(2) Then
            valu_selfriend_rela_26.Value = 2
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(3) Then
            valu_selfriend_rela_26.Value = 3
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(4) Then
            valu_selfriend_rela_26.Value = 4
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(5) Then
            valu_selfriend_rela_26.Value = 6
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(6) Then
            valu_selfriend_rela_26.Value = 7
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(7) Then
            valu_selfriend_rela_26.Value = 8
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(8) Then
            valu_selfriend_rela_26.Value = 9
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(9) Then
            valu_selfriend_rela_26.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_27_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_27.SelectedIndexChanged
        If Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(0) Then
            valu_selfriend_rela_27.Value = 0
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(1) Then
            valu_selfriend_rela_27.Value = 1
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(2) Then
            valu_selfriend_rela_27.Value = 2
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(3) Then
            valu_selfriend_rela_27.Value = 3
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(4) Then
            valu_selfriend_rela_27.Value = 4
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(5) Then
            valu_selfriend_rela_27.Value = 6
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(6) Then
            valu_selfriend_rela_27.Value = 7
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(7) Then
            valu_selfriend_rela_27.Value = 8
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(8) Then
            valu_selfriend_rela_27.Value = 9
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(9) Then
            valu_selfriend_rela_27.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_28_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_28.SelectedIndexChanged
        If Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(0) Then
            valu_selfriend_rela_28.Value = 0
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(1) Then
            valu_selfriend_rela_28.Value = 1
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(2) Then
            valu_selfriend_rela_28.Value = 2
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(3) Then
            valu_selfriend_rela_28.Value = 3
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(4) Then
            valu_selfriend_rela_28.Value = 4
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(5) Then
            valu_selfriend_rela_28.Value = 6
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(6) Then
            valu_selfriend_rela_28.Value = 7
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(7) Then
            valu_selfriend_rela_28.Value = 8
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(8) Then
            valu_selfriend_rela_28.Value = 9
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(9) Then
            valu_selfriend_rela_28.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_29_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_29.SelectedIndexChanged
        If Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(0) Then
            valu_selfriend_rela_29.Value = 0
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(1) Then
            valu_selfriend_rela_29.Value = 1
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(2) Then
            valu_selfriend_rela_29.Value = 2
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(3) Then
            valu_selfriend_rela_29.Value = 3
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(4) Then
            valu_selfriend_rela_29.Value = 4
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(5) Then
            valu_selfriend_rela_29.Value = 6
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(6) Then
            valu_selfriend_rela_29.Value = 7
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(7) Then
            valu_selfriend_rela_29.Value = 8
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(8) Then
            valu_selfriend_rela_29.Value = 9
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(9) Then
            valu_selfriend_rela_29.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_30_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_30.SelectedIndexChanged
        If Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(0) Then
            valu_selfriend_rela_30.Value = 0
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(1) Then
            valu_selfriend_rela_30.Value = 1
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(2) Then
            valu_selfriend_rela_30.Value = 2
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(3) Then
            valu_selfriend_rela_30.Value = 3
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(4) Then
            valu_selfriend_rela_30.Value = 4
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(5) Then
            valu_selfriend_rela_30.Value = 6
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(6) Then
            valu_selfriend_rela_30.Value = 7
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(7) Then
            valu_selfriend_rela_30.Value = 8
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(8) Then
            valu_selfriend_rela_30.Value = 9
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(9) Then
            valu_selfriend_rela_30.Value = 12
        End If
    End Sub

    Private Sub valu_selfriend_rela_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_1.ValueChanged
        If valu_selfriend_rela_1.Value = 0 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(0)
        ElseIf valu_selfriend_rela_1.Value = 1 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(1)
        ElseIf valu_selfriend_rela_1.Value = 2 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(2)
        ElseIf valu_selfriend_rela_1.Value = 3 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(3)
        ElseIf valu_selfriend_rela_1.Value = 4 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(4)
        ElseIf valu_selfriend_rela_1.Value = 6 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(5)
        ElseIf valu_selfriend_rela_1.Value = 7 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(6)
        ElseIf valu_selfriend_rela_1.Value = 8 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(7)
        ElseIf valu_selfriend_rela_1.Value = 9 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(8)
        ElseIf valu_selfriend_rela_1.Value = 12 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_2.ValueChanged
        If valu_selfriend_rela_2.Value = 0 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(0)
        ElseIf valu_selfriend_rela_2.Value = 1 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(1)
        ElseIf valu_selfriend_rela_2.Value = 2 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(2)
        ElseIf valu_selfriend_rela_2.Value = 3 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(3)
        ElseIf valu_selfriend_rela_2.Value = 4 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(4)
        ElseIf valu_selfriend_rela_2.Value = 6 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(5)
        ElseIf valu_selfriend_rela_2.Value = 7 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(6)
        ElseIf valu_selfriend_rela_2.Value = 8 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(7)
        ElseIf valu_selfriend_rela_2.Value = 9 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(8)
        ElseIf valu_selfriend_rela_2.Value = 12 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_3.ValueChanged
        If valu_selfriend_rela_3.Value = 0 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(0)
        ElseIf valu_selfriend_rela_3.Value = 1 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(1)
        ElseIf valu_selfriend_rela_3.Value = 2 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(2)
        ElseIf valu_selfriend_rela_3.Value = 3 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(3)
        ElseIf valu_selfriend_rela_3.Value = 4 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(4)
        ElseIf valu_selfriend_rela_3.Value = 6 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(5)
        ElseIf valu_selfriend_rela_3.Value = 7 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(6)
        ElseIf valu_selfriend_rela_3.Value = 8 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(7)
        ElseIf valu_selfriend_rela_3.Value = 9 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(8)
        ElseIf valu_selfriend_rela_3.Value = 12 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_4.ValueChanged
        If valu_selfriend_rela_4.Value = 0 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(0)
        ElseIf valu_selfriend_rela_4.Value = 1 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(1)
        ElseIf valu_selfriend_rela_4.Value = 2 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(2)
        ElseIf valu_selfriend_rela_4.Value = 3 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(3)
        ElseIf valu_selfriend_rela_4.Value = 4 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(4)
        ElseIf valu_selfriend_rela_4.Value = 6 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(5)
        ElseIf valu_selfriend_rela_4.Value = 7 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(6)
        ElseIf valu_selfriend_rela_4.Value = 8 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(7)
        ElseIf valu_selfriend_rela_4.Value = 9 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(8)
        ElseIf valu_selfriend_rela_4.Value = 12 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_5.ValueChanged
        If valu_selfriend_rela_5.Value = 0 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(0)
        ElseIf valu_selfriend_rela_5.Value = 1 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(1)
        ElseIf valu_selfriend_rela_5.Value = 2 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(2)
        ElseIf valu_selfriend_rela_5.Value = 3 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(3)
        ElseIf valu_selfriend_rela_5.Value = 4 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(4)
        ElseIf valu_selfriend_rela_5.Value = 6 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(5)
        ElseIf valu_selfriend_rela_5.Value = 7 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(6)
        ElseIf valu_selfriend_rela_5.Value = 8 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(7)
        ElseIf valu_selfriend_rela_5.Value = 9 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(8)
        ElseIf valu_selfriend_rela_5.Value = 12 Then
            Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_6.ValueChanged
        If valu_selfriend_rela_6.Value = 0 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(0)
        ElseIf valu_selfriend_rela_6.Value = 1 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(1)
        ElseIf valu_selfriend_rela_6.Value = 2 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(2)
        ElseIf valu_selfriend_rela_6.Value = 3 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(3)
        ElseIf valu_selfriend_rela_6.Value = 4 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(4)
        ElseIf valu_selfriend_rela_6.Value = 6 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(5)
        ElseIf valu_selfriend_rela_6.Value = 7 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(6)
        ElseIf valu_selfriend_rela_6.Value = 8 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(7)
        ElseIf valu_selfriend_rela_6.Value = 9 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(8)
        ElseIf valu_selfriend_rela_6.Value = 12 Then
            Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_7.ValueChanged
        If valu_selfriend_rela_7.Value = 0 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(0)
        ElseIf valu_selfriend_rela_7.Value = 1 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(1)
        ElseIf valu_selfriend_rela_7.Value = 2 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(2)
        ElseIf valu_selfriend_rela_7.Value = 3 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(3)
        ElseIf valu_selfriend_rela_7.Value = 4 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(4)
        ElseIf valu_selfriend_rela_7.Value = 6 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(5)
        ElseIf valu_selfriend_rela_7.Value = 7 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(6)
        ElseIf valu_selfriend_rela_7.Value = 8 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(7)
        ElseIf valu_selfriend_rela_7.Value = 9 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(8)
        ElseIf valu_selfriend_rela_7.Value = 12 Then
            Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_8.ValueChanged
        If valu_selfriend_rela_8.Value = 0 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(0)
        ElseIf valu_selfriend_rela_8.Value = 1 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(1)
        ElseIf valu_selfriend_rela_8.Value = 2 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(2)
        ElseIf valu_selfriend_rela_8.Value = 3 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(3)
        ElseIf valu_selfriend_rela_8.Value = 4 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(4)
        ElseIf valu_selfriend_rela_8.Value = 6 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(5)
        ElseIf valu_selfriend_rela_8.Value = 7 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(6)
        ElseIf valu_selfriend_rela_8.Value = 8 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(7)
        ElseIf valu_selfriend_rela_8.Value = 9 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(8)
        ElseIf valu_selfriend_rela_8.Value = 12 Then
            Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_9.ValueChanged
        If valu_selfriend_rela_9.Value = 0 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(0)
        ElseIf valu_selfriend_rela_9.Value = 1 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(1)
        ElseIf valu_selfriend_rela_9.Value = 2 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(2)
        ElseIf valu_selfriend_rela_9.Value = 3 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(3)
        ElseIf valu_selfriend_rela_9.Value = 4 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(4)
        ElseIf valu_selfriend_rela_9.Value = 6 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(5)
        ElseIf valu_selfriend_rela_9.Value = 7 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(6)
        ElseIf valu_selfriend_rela_9.Value = 8 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(7)
        ElseIf valu_selfriend_rela_9.Value = 9 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(8)
        ElseIf valu_selfriend_rela_9.Value = 12 Then
            Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_10.ValueChanged
        If valu_selfriend_rela_10.Value = 0 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(0)
        ElseIf valu_selfriend_rela_10.Value = 1 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(1)
        ElseIf valu_selfriend_rela_10.Value = 2 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(2)
        ElseIf valu_selfriend_rela_10.Value = 3 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(3)
        ElseIf valu_selfriend_rela_10.Value = 4 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(4)
        ElseIf valu_selfriend_rela_10.Value = 6 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(5)
        ElseIf valu_selfriend_rela_10.Value = 7 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(6)
        ElseIf valu_selfriend_rela_10.Value = 8 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(7)
        ElseIf valu_selfriend_rela_10.Value = 9 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(8)
        ElseIf valu_selfriend_rela_10.Value = 12 Then
            Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_11.ValueChanged
        If valu_selfriend_rela_11.Value = 0 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(0)
        ElseIf valu_selfriend_rela_11.Value = 1 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(1)
        ElseIf valu_selfriend_rela_11.Value = 2 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(2)
        ElseIf valu_selfriend_rela_11.Value = 3 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(3)
        ElseIf valu_selfriend_rela_11.Value = 4 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(4)
        ElseIf valu_selfriend_rela_11.Value = 6 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(5)
        ElseIf valu_selfriend_rela_11.Value = 7 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(6)
        ElseIf valu_selfriend_rela_11.Value = 8 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(7)
        ElseIf valu_selfriend_rela_11.Value = 9 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(8)
        ElseIf valu_selfriend_rela_11.Value = 12 Then
            Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_12.ValueChanged
        If valu_selfriend_rela_12.Value = 0 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(0)
        ElseIf valu_selfriend_rela_12.Value = 1 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(1)
        ElseIf valu_selfriend_rela_12.Value = 2 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(2)
        ElseIf valu_selfriend_rela_12.Value = 3 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(3)
        ElseIf valu_selfriend_rela_12.Value = 4 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(4)
        ElseIf valu_selfriend_rela_12.Value = 6 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(5)
        ElseIf valu_selfriend_rela_12.Value = 7 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(6)
        ElseIf valu_selfriend_rela_12.Value = 8 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(7)
        ElseIf valu_selfriend_rela_12.Value = 9 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(8)
        ElseIf valu_selfriend_rela_12.Value = 12 Then
            Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_13.ValueChanged
        If valu_selfriend_rela_13.Value = 0 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(0)
        ElseIf valu_selfriend_rela_13.Value = 1 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(1)
        ElseIf valu_selfriend_rela_13.Value = 2 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(2)
        ElseIf valu_selfriend_rela_13.Value = 3 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(3)
        ElseIf valu_selfriend_rela_13.Value = 4 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(4)
        ElseIf valu_selfriend_rela_13.Value = 6 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(5)
        ElseIf valu_selfriend_rela_13.Value = 7 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(6)
        ElseIf valu_selfriend_rela_13.Value = 8 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(7)
        ElseIf valu_selfriend_rela_13.Value = 9 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(8)
        ElseIf valu_selfriend_rela_13.Value = 12 Then
            Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_14.ValueChanged
        If valu_selfriend_rela_14.Value = 0 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(0)
        ElseIf valu_selfriend_rela_14.Value = 1 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(1)
        ElseIf valu_selfriend_rela_14.Value = 2 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(2)
        ElseIf valu_selfriend_rela_14.Value = 3 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(3)
        ElseIf valu_selfriend_rela_14.Value = 4 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(4)
        ElseIf valu_selfriend_rela_14.Value = 6 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(5)
        ElseIf valu_selfriend_rela_14.Value = 7 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(6)
        ElseIf valu_selfriend_rela_14.Value = 8 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(7)
        ElseIf valu_selfriend_rela_14.Value = 9 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(8)
        ElseIf valu_selfriend_rela_14.Value = 12 Then
            Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_15.ValueChanged
        If valu_selfriend_rela_15.Value = 0 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(0)
        ElseIf valu_selfriend_rela_15.Value = 1 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(1)
        ElseIf valu_selfriend_rela_15.Value = 2 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(2)
        ElseIf valu_selfriend_rela_15.Value = 3 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(3)
        ElseIf valu_selfriend_rela_15.Value = 4 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(4)
        ElseIf valu_selfriend_rela_15.Value = 6 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(5)
        ElseIf valu_selfriend_rela_15.Value = 7 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(6)
        ElseIf valu_selfriend_rela_15.Value = 8 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(7)
        ElseIf valu_selfriend_rela_15.Value = 9 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(8)
        ElseIf valu_selfriend_rela_15.Value = 12 Then
            Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_16.ValueChanged
        If valu_selfriend_rela_16.Value = 0 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(0)
        ElseIf valu_selfriend_rela_16.Value = 1 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(1)
        ElseIf valu_selfriend_rela_16.Value = 2 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(2)
        ElseIf valu_selfriend_rela_16.Value = 3 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(3)
        ElseIf valu_selfriend_rela_16.Value = 4 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(4)
        ElseIf valu_selfriend_rela_16.Value = 6 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(5)
        ElseIf valu_selfriend_rela_16.Value = 7 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(6)
        ElseIf valu_selfriend_rela_16.Value = 8 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(7)
        ElseIf valu_selfriend_rela_16.Value = 9 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(8)
        ElseIf valu_selfriend_rela_16.Value = 12 Then
            Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_17.ValueChanged
        If valu_selfriend_rela_17.Value = 0 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(0)
        ElseIf valu_selfriend_rela_17.Value = 1 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(1)
        ElseIf valu_selfriend_rela_17.Value = 2 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(2)
        ElseIf valu_selfriend_rela_17.Value = 3 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(3)
        ElseIf valu_selfriend_rela_17.Value = 4 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(4)
        ElseIf valu_selfriend_rela_17.Value = 6 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(5)
        ElseIf valu_selfriend_rela_17.Value = 7 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(6)
        ElseIf valu_selfriend_rela_17.Value = 8 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(7)
        ElseIf valu_selfriend_rela_17.Value = 9 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(8)
        ElseIf valu_selfriend_rela_17.Value = 12 Then
            Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_18.ValueChanged
        If valu_selfriend_rela_18.Value = 0 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(0)
        ElseIf valu_selfriend_rela_18.Value = 1 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(1)
        ElseIf valu_selfriend_rela_18.Value = 2 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(2)
        ElseIf valu_selfriend_rela_18.Value = 3 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(3)
        ElseIf valu_selfriend_rela_18.Value = 4 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(4)
        ElseIf valu_selfriend_rela_18.Value = 6 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(5)
        ElseIf valu_selfriend_rela_18.Value = 7 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(6)
        ElseIf valu_selfriend_rela_18.Value = 8 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(7)
        ElseIf valu_selfriend_rela_18.Value = 9 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(8)
        ElseIf valu_selfriend_rela_18.Value = 12 Then
            Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_19.ValueChanged
        If valu_selfriend_rela_19.Value = 0 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(0)
        ElseIf valu_selfriend_rela_19.Value = 1 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(1)
        ElseIf valu_selfriend_rela_19.Value = 2 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(2)
        ElseIf valu_selfriend_rela_19.Value = 3 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(3)
        ElseIf valu_selfriend_rela_19.Value = 4 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(4)
        ElseIf valu_selfriend_rela_19.Value = 6 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(5)
        ElseIf valu_selfriend_rela_19.Value = 7 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(6)
        ElseIf valu_selfriend_rela_19.Value = 8 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(7)
        ElseIf valu_selfriend_rela_19.Value = 9 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(8)
        ElseIf valu_selfriend_rela_19.Value = 12 Then
            Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_20.ValueChanged
        If valu_selfriend_rela_20.Value = 0 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(0)
        ElseIf valu_selfriend_rela_20.Value = 1 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(1)
        ElseIf valu_selfriend_rela_20.Value = 2 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(2)
        ElseIf valu_selfriend_rela_20.Value = 3 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(3)
        ElseIf valu_selfriend_rela_20.Value = 4 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(4)
        ElseIf valu_selfriend_rela_20.Value = 6 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(5)
        ElseIf valu_selfriend_rela_20.Value = 7 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(6)
        ElseIf valu_selfriend_rela_20.Value = 8 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(7)
        ElseIf valu_selfriend_rela_20.Value = 9 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(8)
        ElseIf valu_selfriend_rela_20.Value = 12 Then
            Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_21_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_21.ValueChanged
        If valu_selfriend_rela_21.Value = 0 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(0)
        ElseIf valu_selfriend_rela_21.Value = 1 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(1)
        ElseIf valu_selfriend_rela_21.Value = 2 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(2)
        ElseIf valu_selfriend_rela_21.Value = 3 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(3)
        ElseIf valu_selfriend_rela_21.Value = 4 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(4)
        ElseIf valu_selfriend_rela_21.Value = 6 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(5)
        ElseIf valu_selfriend_rela_21.Value = 7 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(6)
        ElseIf valu_selfriend_rela_21.Value = 8 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(7)
        ElseIf valu_selfriend_rela_21.Value = 9 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(8)
        ElseIf valu_selfriend_rela_21.Value = 12 Then
            Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_22_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_22.ValueChanged
        If valu_selfriend_rela_22.Value = 0 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(0)
        ElseIf valu_selfriend_rela_22.Value = 1 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(1)
        ElseIf valu_selfriend_rela_22.Value = 2 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(2)
        ElseIf valu_selfriend_rela_22.Value = 3 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(3)
        ElseIf valu_selfriend_rela_22.Value = 4 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(4)
        ElseIf valu_selfriend_rela_22.Value = 6 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(5)
        ElseIf valu_selfriend_rela_22.Value = 7 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(6)
        ElseIf valu_selfriend_rela_22.Value = 8 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(7)
        ElseIf valu_selfriend_rela_22.Value = 9 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(8)
        ElseIf valu_selfriend_rela_22.Value = 12 Then
            Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_23_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_23.ValueChanged
        If valu_selfriend_rela_23.Value = 0 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(0)
        ElseIf valu_selfriend_rela_23.Value = 1 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(1)
        ElseIf valu_selfriend_rela_23.Value = 2 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(2)
        ElseIf valu_selfriend_rela_23.Value = 3 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(3)
        ElseIf valu_selfriend_rela_23.Value = 4 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(4)
        ElseIf valu_selfriend_rela_23.Value = 6 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(5)
        ElseIf valu_selfriend_rela_23.Value = 7 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(6)
        ElseIf valu_selfriend_rela_23.Value = 8 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(7)
        ElseIf valu_selfriend_rela_23.Value = 9 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(8)
        ElseIf valu_selfriend_rela_23.Value = 12 Then
            Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_24_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_24.ValueChanged
        If valu_selfriend_rela_24.Value = 0 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(0)
        ElseIf valu_selfriend_rela_24.Value = 1 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(1)
        ElseIf valu_selfriend_rela_24.Value = 2 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(2)
        ElseIf valu_selfriend_rela_24.Value = 3 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(3)
        ElseIf valu_selfriend_rela_24.Value = 4 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(4)
        ElseIf valu_selfriend_rela_24.Value = 6 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(5)
        ElseIf valu_selfriend_rela_24.Value = 7 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(6)
        ElseIf valu_selfriend_rela_24.Value = 8 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(7)
        ElseIf valu_selfriend_rela_24.Value = 9 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(8)
        ElseIf valu_selfriend_rela_24.Value = 12 Then
            Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_25_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_25.ValueChanged
        If valu_selfriend_rela_25.Value = 0 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(0)
        ElseIf valu_selfriend_rela_25.Value = 1 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(1)
        ElseIf valu_selfriend_rela_25.Value = 2 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(2)
        ElseIf valu_selfriend_rela_25.Value = 3 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(3)
        ElseIf valu_selfriend_rela_25.Value = 4 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(4)
        ElseIf valu_selfriend_rela_25.Value = 6 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(5)
        ElseIf valu_selfriend_rela_25.Value = 7 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(6)
        ElseIf valu_selfriend_rela_25.Value = 8 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(7)
        ElseIf valu_selfriend_rela_25.Value = 9 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(8)
        ElseIf valu_selfriend_rela_25.Value = 12 Then
            Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_26_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_26.ValueChanged
        If valu_selfriend_rela_26.Value = 0 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(0)
        ElseIf valu_selfriend_rela_26.Value = 1 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(1)
        ElseIf valu_selfriend_rela_26.Value = 2 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(2)
        ElseIf valu_selfriend_rela_26.Value = 3 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(3)
        ElseIf valu_selfriend_rela_26.Value = 4 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(4)
        ElseIf valu_selfriend_rela_26.Value = 6 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(5)
        ElseIf valu_selfriend_rela_26.Value = 7 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(6)
        ElseIf valu_selfriend_rela_26.Value = 8 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(7)
        ElseIf valu_selfriend_rela_26.Value = 9 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(8)
        ElseIf valu_selfriend_rela_26.Value = 12 Then
            Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_27_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_27.ValueChanged
        If valu_selfriend_rela_27.Value = 0 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(0)
        ElseIf valu_selfriend_rela_27.Value = 1 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(1)
        ElseIf valu_selfriend_rela_27.Value = 2 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(2)
        ElseIf valu_selfriend_rela_27.Value = 3 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(3)
        ElseIf valu_selfriend_rela_27.Value = 4 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(4)
        ElseIf valu_selfriend_rela_27.Value = 6 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(5)
        ElseIf valu_selfriend_rela_27.Value = 7 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(6)
        ElseIf valu_selfriend_rela_27.Value = 8 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(7)
        ElseIf valu_selfriend_rela_27.Value = 9 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(8)
        ElseIf valu_selfriend_rela_27.Value = 12 Then
            Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_28_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_28.ValueChanged
        If valu_selfriend_rela_28.Value = 0 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(0)
        ElseIf valu_selfriend_rela_28.Value = 1 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(1)
        ElseIf valu_selfriend_rela_28.Value = 2 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(2)
        ElseIf valu_selfriend_rela_28.Value = 3 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(3)
        ElseIf valu_selfriend_rela_28.Value = 4 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(4)
        ElseIf valu_selfriend_rela_28.Value = 6 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(5)
        ElseIf valu_selfriend_rela_28.Value = 7 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(6)
        ElseIf valu_selfriend_rela_28.Value = 8 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(7)
        ElseIf valu_selfriend_rela_28.Value = 9 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(8)
        ElseIf valu_selfriend_rela_28.Value = 12 Then
            Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_29_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_29.ValueChanged
        If valu_selfriend_rela_29.Value = 0 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(0)
        ElseIf valu_selfriend_rela_29.Value = 1 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(1)
        ElseIf valu_selfriend_rela_29.Value = 2 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(2)
        ElseIf valu_selfriend_rela_29.Value = 3 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(3)
        ElseIf valu_selfriend_rela_29.Value = 4 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(4)
        ElseIf valu_selfriend_rela_29.Value = 6 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(5)
        ElseIf valu_selfriend_rela_29.Value = 7 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(6)
        ElseIf valu_selfriend_rela_29.Value = 8 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(7)
        ElseIf valu_selfriend_rela_29.Value = 9 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(8)
        ElseIf valu_selfriend_rela_29.Value = 12 Then
            Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_30_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_30.ValueChanged
        If valu_selfriend_rela_30.Value = 0 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(0)
        ElseIf valu_selfriend_rela_30.Value = 1 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(1)
        ElseIf valu_selfriend_rela_30.Value = 2 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(2)
        ElseIf valu_selfriend_rela_30.Value = 3 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(3)
        ElseIf valu_selfriend_rela_30.Value = 4 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(4)
        ElseIf valu_selfriend_rela_30.Value = 6 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(5)
        ElseIf valu_selfriend_rela_30.Value = 7 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(6)
        ElseIf valu_selfriend_rela_30.Value = 8 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(7)
        ElseIf valu_selfriend_rela_30.Value = 9 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(8)
        ElseIf valu_selfriend_rela_30.Value = 12 Then
            Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(9)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Filever_text.ForeColor = Color.Red
        Timer1.Stop()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Filever_text.ForeColor = Color.Orange
        Timer2.Stop()
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Filever_text.ForeColor = Color.Yellow
        Timer3.Stop()
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Filever_text.ForeColor = Color.Green
        Timer4.Stop()
        Timer5.Start()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Filever_text.ForeColor = Color.Blue
        Timer5.Stop()
        Timer6.Start()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Filever_text.ForeColor = Color.Indigo
        Timer6.Stop()
        Timer7.Start()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Filever_text.ForeColor = Color.Violet
        Timer7.Stop()
        Timer1.Start()
    End Sub

    Private Sub Text_edit_metal_Click(sender As Object, e As EventArgs) Handles Text_edit_metal.Click
        valu_selected_music.Value = 1
        Miimusic_edit.ShowDialog()
    End Sub

    Private Sub Text_edit_pop_Click(sender As Object, e As EventArgs) Handles Text_edit_pop.Click
        valu_selected_music.Value = 2
        Miimusic_edit.ShowDialog()
    End Sub

    Private Sub Text_edit_rockroll_Click(sender As Object, e As EventArgs) Handles Text_edit_rockroll.Click
        valu_selected_music.Value = 3
        Miimusic_edit.ShowDialog()
    End Sub

    Private Sub Text_edit_rap_Click(sender As Object, e As EventArgs) Handles Text_edit_rap.Click
        valu_selected_music.Value = 4
        Miimusic_edit.ShowDialog()
    End Sub

    Private Sub Text_edit_ballad_Click(sender As Object, e As EventArgs) Handles Text_edit_ballad.Click
        valu_selected_music.Value = 5
        Miimusic_edit.ShowDialog()
    End Sub

    Private Sub Text_edit_opera_Click(sender As Object, e As EventArgs) Handles Text_edit_opera.Click
        valu_selected_music.Value = 6
        Miimusic_edit.ShowDialog()
    End Sub

    Private Sub Text_edit_techno_Click(sender As Object, e As EventArgs) Handles Text_edit_techno.Click
        valu_selected_music.Value = 7
        Miimusic_edit.ShowDialog()
    End Sub

    Private Sub Text_edit_musical_Click(sender As Object, e As EventArgs) Handles Text_edit_musical.Click
        valu_selected_music.Value = 8
        Miimusic_edit.ShowDialog()
    End Sub

    Private Sub Icon_MiitopiaSE_Click(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.Click
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor/releases")
    End Sub

    Private Sub Icon_MiitopiaSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.MouseLeave
        Icon_MiitopiaSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MiitopiaSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.MouseMove
        Icon_MiitopiaSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Miitopia Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Miitopia Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_ChibiRoboZLSE_Click(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.Click
        Process.Start("https://github.com/Brionjv/Chibi-Robo-ZL-Save-Editor/releases")
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.MouseLeave
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.MouseMove
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Chibi Robo zip Lash Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Chibi Robo zip Lash Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Select_allfav_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_allfav_1.SelectedIndexChanged
        If Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(0) Then
            valu_allfav_1.Value = 65535
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(1) Then
            valu_allfav_1.Value = 2
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(2) Then
            valu_allfav_1.Value = 5
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(3) Then
            valu_allfav_1.Value = 10
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(4) Then
            valu_allfav_1.Value = 16
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(5) Then
            valu_allfav_1.Value = 20
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(6) Then
            valu_allfav_1.Value = 23
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(7) Then
            valu_allfav_1.Value = 26
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(8) Then
            valu_allfav_1.Value = 27
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(9) Then
            valu_allfav_1.Value = 29
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(10) Then
            valu_allfav_1.Value = 31
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(11) Then
            valu_allfav_1.Value = 32
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(12) Then
            valu_allfav_1.Value = 34
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(13) Then
            valu_allfav_1.Value = 36
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(14) Then
            valu_allfav_1.Value = 38
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(15) Then
            valu_allfav_1.Value = 40
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(16) Then
            valu_allfav_1.Value = 42
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(17) Then
            valu_allfav_1.Value = 44
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(18) Then
            valu_allfav_1.Value = 45
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(19) Then
            valu_allfav_1.Value = 46
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(20) Then
            valu_allfav_1.Value = 47
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(21) Then
            valu_allfav_1.Value = 48
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(22) Then
            valu_allfav_1.Value = 49
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(23) Then
            valu_allfav_1.Value = 50
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(24) Then
            valu_allfav_1.Value = 51
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(25) Then
            valu_allfav_1.Value = 53
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(26) Then
            valu_allfav_1.Value = 54
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(27) Then
            valu_allfav_1.Value = 56
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(28) Then
            valu_allfav_1.Value = 58
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(29) Then
            valu_allfav_1.Value = 61
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(30) Then
            valu_allfav_1.Value = 62
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(31) Then
            valu_allfav_1.Value = 63
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(32) Then
            valu_allfav_1.Value = 66
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(33) Then
            valu_allfav_1.Value = 67
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(34) Then
            valu_allfav_1.Value = 69
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(35) Then
            valu_allfav_1.Value = 70
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(36) Then
            valu_allfav_1.Value = 73
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(37) Then
            valu_allfav_1.Value = 76
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(38) Then
            valu_allfav_1.Value = 77
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(39) Then
            valu_allfav_1.Value = 80
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(40) Then
            valu_allfav_1.Value = 86
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(41) Then
            valu_allfav_1.Value = 87
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(42) Then
            valu_allfav_1.Value = 89
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(43) Then
            valu_allfav_1.Value = 90
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(44) Then
            valu_allfav_1.Value = 91
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(45) Then
            valu_allfav_1.Value = 92
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(46) Then
            valu_allfav_1.Value = 96
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(47) Then
            valu_allfav_1.Value = 97
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(48) Then
            valu_allfav_1.Value = 98
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(49) Then
            valu_allfav_1.Value = 99
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(50) Then
            valu_allfav_1.Value = 100
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(51) Then
            valu_allfav_1.Value = 101
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(52) Then
            valu_allfav_1.Value = 102
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(53) Then
            valu_allfav_1.Value = 103
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(54) Then
            valu_allfav_1.Value = 104
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(55) Then
            valu_allfav_1.Value = 105
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(56) Then
            valu_allfav_1.Value = 106
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(57) Then
            valu_allfav_1.Value = 107
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(58) Then
            valu_allfav_1.Value = 108
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(59) Then
            valu_allfav_1.Value = 109
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(60) Then
            valu_allfav_1.Value = 110
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(61) Then
            valu_allfav_1.Value = 112
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(62) Then
            valu_allfav_1.Value = 114
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(63) Then
            valu_allfav_1.Value = 115
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(64) Then
            valu_allfav_1.Value = 117
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(65) Then
            valu_allfav_1.Value = 119
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(66) Then
            valu_allfav_1.Value = 122
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(67) Then
            valu_allfav_1.Value = 123
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(68) Then
            valu_allfav_1.Value = 126
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(69) Then
            valu_allfav_1.Value = 132
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(70) Then
            valu_allfav_1.Value = 135
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(71) Then
            valu_allfav_1.Value = 136
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(72) Then
            valu_allfav_1.Value = 137
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(73) Then
            valu_allfav_1.Value = 138
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(74) Then
            valu_allfav_1.Value = 139
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(75) Then
            valu_allfav_1.Value = 140
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(76) Then
            valu_allfav_1.Value = 141
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(77) Then
            valu_allfav_1.Value = 142
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(78) Then
            valu_allfav_1.Value = 143
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(79) Then
            valu_allfav_1.Value = 144
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(80) Then
            valu_allfav_1.Value = 146
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(81) Then
            valu_allfav_1.Value = 147
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(82) Then
            valu_allfav_1.Value = 148
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(83) Then
            valu_allfav_1.Value = 149
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(84) Then
            valu_allfav_1.Value = 150
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(85) Then
            valu_allfav_1.Value = 151
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(86) Then
            valu_allfav_1.Value = 152
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(87) Then
            valu_allfav_1.Value = 153
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(88) Then
            valu_allfav_1.Value = 154
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(89) Then
            valu_allfav_1.Value = 155
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(90) Then
            valu_allfav_1.Value = 156
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(91) Then
            valu_allfav_1.Value = 157
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(92) Then
            valu_allfav_1.Value = 158
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(93) Then
            valu_allfav_1.Value = 159
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(94) Then
            valu_allfav_1.Value = 160
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(95) Then
            valu_allfav_1.Value = 161
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(96) Then
            valu_allfav_1.Value = 162
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(97) Then
            valu_allfav_1.Value = 163
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(98) Then
            valu_allfav_1.Value = 164
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(99) Then
            valu_allfav_1.Value = 165
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(100) Then
            valu_allfav_1.Value = 166
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(101) Then
            valu_allfav_1.Value = 167
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(102) Then
            valu_allfav_1.Value = 168
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(103) Then
            valu_allfav_1.Value = 169
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(104) Then
            valu_allfav_1.Value = 170
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(105) Then
            valu_allfav_1.Value = 171
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(106) Then
            valu_allfav_1.Value = 172
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(107) Then
            valu_allfav_1.Value = 173
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(108) Then
            valu_allfav_1.Value = 174
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(109) Then
            valu_allfav_1.Value = 175
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(110) Then
            valu_allfav_1.Value = 178
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(111) Then
            valu_allfav_1.Value = 180
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(112) Then
            valu_allfav_1.Value = 182
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(113) Then
            valu_allfav_1.Value = 183
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(114) Then
            valu_allfav_1.Value = 185
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(115) Then
            valu_allfav_1.Value = 186
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(116) Then
            valu_allfav_1.Value = 187
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(117) Then
            valu_allfav_1.Value = 188
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(118) Then
            valu_allfav_1.Value = 189
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(119) Then
            valu_allfav_1.Value = 190
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(120) Then
            valu_allfav_1.Value = 191
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(121) Then
            valu_allfav_1.Value = 192
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(122) Then
            valu_allfav_1.Value = 193
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(123) Then
            valu_allfav_1.Value = 194
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(124) Then
            valu_allfav_1.Value = 195
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(125) Then
            valu_allfav_1.Value = 197
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(126) Then
            valu_allfav_1.Value = 198
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(127) Then
            valu_allfav_1.Value = 199
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(128) Then
            valu_allfav_1.Value = 200
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(129) Then
            valu_allfav_1.Value = 201
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(130) Then
            valu_allfav_1.Value = 202
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(131) Then
            valu_allfav_1.Value = 205
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(132) Then
            valu_allfav_1.Value = 210
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(133) Then
            valu_allfav_1.Value = 216
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(134) Then
            valu_allfav_1.Value = 218
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(135) Then
            valu_allfav_1.Value = 222
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(136) Then
            valu_allfav_1.Value = 229
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(137) Then
            valu_allfav_1.Value = 230
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(138) Then
            valu_allfav_1.Value = 231
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(139) Then
            valu_allfav_1.Value = 232
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(140) Then
            valu_allfav_1.Value = 233
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(141) Then
            valu_allfav_1.Value = 234
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(142) Then
            valu_allfav_1.Value = 235
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(143) Then
            valu_allfav_1.Value = 236
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(144) Then
            valu_allfav_1.Value = 237
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(145) Then
            valu_allfav_1.Value = 238
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(146) Then
            valu_allfav_1.Value = 239
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(147) Then
            valu_allfav_1.Value = 240
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(148) Then
            valu_allfav_1.Value = 241
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(149) Then
            valu_allfav_1.Value = 242
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(150) Then
            valu_allfav_1.Value = 243
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(151) Then
            valu_allfav_1.Value = 244
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(152) Then
            valu_allfav_1.Value = 245
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(153) Then
            valu_allfav_1.Value = 246
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(154) Then
            valu_allfav_1.Value = 247
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(155) Then
            valu_allfav_1.Value = 248
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(156) Then
            valu_allfav_1.Value = 249
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(157) Then
            valu_allfav_1.Value = 250
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(158) Then
            valu_allfav_1.Value = 251
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(159) Then
            valu_allfav_1.Value = 252
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(160) Then
            valu_allfav_1.Value = 253
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(161) Then
            valu_allfav_1.Value = 297
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(162) Then
            valu_allfav_1.Value = 298
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(163) Then
            valu_allfav_1.Value = 299
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(164) Then
            valu_allfav_1.Value = 300
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(165) Then
            valu_allfav_1.Value = 301
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(166) Then
            valu_allfav_1.Value = 302
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(167) Then
            valu_allfav_1.Value = 303
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(168) Then
            valu_allfav_1.Value = 304
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(169) Then
            valu_allfav_1.Value = 305
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(170) Then
            valu_allfav_1.Value = 306
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(171) Then
            valu_allfav_1.Value = 307
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(172) Then
            valu_allfav_1.Value = 308
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(173) Then
            valu_allfav_1.Value = 309
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(174) Then
            valu_allfav_1.Value = 310
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(175) Then
            valu_allfav_1.Value = 311
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(176) Then
            valu_allfav_1.Value = 312
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(177) Then
            valu_allfav_1.Value = 314
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(178) Then
            valu_allfav_1.Value = 315
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(179) Then
            valu_allfav_1.Value = 316
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(180) Then
            valu_allfav_1.Value = 317
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(181) Then
            valu_allfav_1.Value = 318
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(182) Then
            valu_allfav_1.Value = 319
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(183) Then
            valu_allfav_1.Value = 320
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(184) Then
            valu_allfav_1.Value = 321
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(185) Then
            valu_allfav_1.Value = 322
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(186) Then
            valu_allfav_1.Value = 323
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(187) Then
            valu_allfav_1.Value = 324
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(188) Then
            valu_allfav_1.Value = 325
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(189) Then
            valu_allfav_1.Value = 326
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(190) Then
            valu_allfav_1.Value = 327
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(191) Then
            valu_allfav_1.Value = 328
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(192) Then
            valu_allfav_1.Value = 329
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(193) Then
            valu_allfav_1.Value = 330
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(194) Then
            valu_allfav_1.Value = 331
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(195) Then
            valu_allfav_1.Value = 332
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(196) Then
            valu_allfav_1.Value = 333
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(197) Then
            valu_allfav_1.Value = 334
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(198) Then
            valu_allfav_1.Value = 335
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(199) Then
            valu_allfav_1.Value = 336
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(200) Then
            valu_allfav_1.Value = 337
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(201) Then
            valu_allfav_1.Value = 338
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(202) Then
            valu_allfav_1.Value = 340
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(203) Then
            valu_allfav_1.Value = 342
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(204) Then
            valu_allfav_1.Value = 343
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(205) Then
            valu_allfav_1.Value = 344
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(206) Then
            valu_allfav_1.Value = 345
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(207) Then
            valu_allfav_1.Value = 346
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(208) Then
            valu_allfav_1.Value = 347
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(209) Then
            valu_allfav_1.Value = 348
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(210) Then
            valu_allfav_1.Value = 349
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(211) Then
            valu_allfav_1.Value = 350
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(212) Then
            valu_allfav_1.Value = 354
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(213) Then
            valu_allfav_1.Value = 355
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(214) Then
            valu_allfav_1.Value = 356
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(215) Then
            valu_allfav_1.Value = 357
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(216) Then
            valu_allfav_1.Value = 358
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(217) Then
            valu_allfav_1.Value = 359
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(218) Then
            valu_allfav_1.Value = 360
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(219) Then
            valu_allfav_1.Value = 361
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(220) Then
            valu_allfav_1.Value = 362
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(221) Then
            valu_allfav_1.Value = 363
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(222) Then
            valu_allfav_1.Value = 364
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(223) Then
            valu_allfav_1.Value = 365
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(224) Then
            valu_allfav_1.Value = 366
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(225) Then
            valu_allfav_1.Value = 367
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(226) Then
            valu_allfav_1.Value = 368
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(227) Then
            valu_allfav_1.Value = 369
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(228) Then
            valu_allfav_1.Value = 370
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(229) Then
            valu_allfav_1.Value = 371
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(230) Then
            valu_allfav_1.Value = 381
        ElseIf Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(231) Then
            valu_allfav_1.Value = 0
        End If
    End Sub

    Private Sub Select_allfav_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_allfav_2.SelectedIndexChanged
        If Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(0) Then
            valu_allfav_2.Value = 65535
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(1) Then
            valu_allfav_2.Value = 2
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(2) Then
            valu_allfav_2.Value = 5
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(3) Then
            valu_allfav_2.Value = 10
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(4) Then
            valu_allfav_2.Value = 16
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(5) Then
            valu_allfav_2.Value = 20
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(6) Then
            valu_allfav_2.Value = 23
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(7) Then
            valu_allfav_2.Value = 26
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(8) Then
            valu_allfav_2.Value = 27
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(9) Then
            valu_allfav_2.Value = 29
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(10) Then
            valu_allfav_2.Value = 31
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(11) Then
            valu_allfav_2.Value = 32
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(12) Then
            valu_allfav_2.Value = 34
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(13) Then
            valu_allfav_2.Value = 36
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(14) Then
            valu_allfav_2.Value = 38
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(15) Then
            valu_allfav_2.Value = 40
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(16) Then
            valu_allfav_2.Value = 42
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(17) Then
            valu_allfav_2.Value = 44
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(18) Then
            valu_allfav_2.Value = 45
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(19) Then
            valu_allfav_2.Value = 46
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(20) Then
            valu_allfav_2.Value = 47
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(21) Then
            valu_allfav_2.Value = 48
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(22) Then
            valu_allfav_2.Value = 49
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(23) Then
            valu_allfav_2.Value = 50
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(24) Then
            valu_allfav_2.Value = 51
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(25) Then
            valu_allfav_2.Value = 53
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(26) Then
            valu_allfav_2.Value = 54
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(27) Then
            valu_allfav_2.Value = 56
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(28) Then
            valu_allfav_2.Value = 58
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(29) Then
            valu_allfav_2.Value = 61
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(30) Then
            valu_allfav_2.Value = 62
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(31) Then
            valu_allfav_2.Value = 63
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(32) Then
            valu_allfav_2.Value = 66
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(33) Then
            valu_allfav_2.Value = 67
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(34) Then
            valu_allfav_2.Value = 69
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(35) Then
            valu_allfav_2.Value = 70
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(36) Then
            valu_allfav_2.Value = 73
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(37) Then
            valu_allfav_2.Value = 76
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(38) Then
            valu_allfav_2.Value = 77
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(39) Then
            valu_allfav_2.Value = 80
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(40) Then
            valu_allfav_2.Value = 86
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(41) Then
            valu_allfav_2.Value = 87
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(42) Then
            valu_allfav_2.Value = 89
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(43) Then
            valu_allfav_2.Value = 90
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(44) Then
            valu_allfav_2.Value = 91
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(45) Then
            valu_allfav_2.Value = 92
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(46) Then
            valu_allfav_2.Value = 96
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(47) Then
            valu_allfav_2.Value = 97
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(48) Then
            valu_allfav_2.Value = 98
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(49) Then
            valu_allfav_2.Value = 99
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(50) Then
            valu_allfav_2.Value = 100
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(51) Then
            valu_allfav_2.Value = 101
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(52) Then
            valu_allfav_2.Value = 102
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(53) Then
            valu_allfav_2.Value = 103
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(54) Then
            valu_allfav_2.Value = 104
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(55) Then
            valu_allfav_2.Value = 105
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(56) Then
            valu_allfav_2.Value = 106
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(57) Then
            valu_allfav_2.Value = 107
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(58) Then
            valu_allfav_2.Value = 108
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(59) Then
            valu_allfav_2.Value = 109
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(60) Then
            valu_allfav_2.Value = 110
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(61) Then
            valu_allfav_2.Value = 112
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(62) Then
            valu_allfav_2.Value = 114
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(63) Then
            valu_allfav_2.Value = 115
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(64) Then
            valu_allfav_2.Value = 117
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(65) Then
            valu_allfav_2.Value = 119
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(66) Then
            valu_allfav_2.Value = 122
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(67) Then
            valu_allfav_2.Value = 123
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(68) Then
            valu_allfav_2.Value = 126
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(69) Then
            valu_allfav_2.Value = 132
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(70) Then
            valu_allfav_2.Value = 135
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(71) Then
            valu_allfav_2.Value = 136
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(72) Then
            valu_allfav_2.Value = 137
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(73) Then
            valu_allfav_2.Value = 138
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(74) Then
            valu_allfav_2.Value = 139
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(75) Then
            valu_allfav_2.Value = 140
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(76) Then
            valu_allfav_2.Value = 141
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(77) Then
            valu_allfav_2.Value = 142
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(78) Then
            valu_allfav_2.Value = 143
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(79) Then
            valu_allfav_2.Value = 144
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(80) Then
            valu_allfav_2.Value = 146
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(81) Then
            valu_allfav_2.Value = 147
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(82) Then
            valu_allfav_2.Value = 148
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(83) Then
            valu_allfav_2.Value = 149
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(84) Then
            valu_allfav_2.Value = 150
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(85) Then
            valu_allfav_2.Value = 151
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(86) Then
            valu_allfav_2.Value = 152
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(87) Then
            valu_allfav_2.Value = 153
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(88) Then
            valu_allfav_2.Value = 154
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(89) Then
            valu_allfav_2.Value = 155
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(90) Then
            valu_allfav_2.Value = 156
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(91) Then
            valu_allfav_2.Value = 157
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(92) Then
            valu_allfav_2.Value = 158
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(93) Then
            valu_allfav_2.Value = 159
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(94) Then
            valu_allfav_2.Value = 160
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(95) Then
            valu_allfav_2.Value = 161
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(96) Then
            valu_allfav_2.Value = 162
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(97) Then
            valu_allfav_2.Value = 163
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(98) Then
            valu_allfav_2.Value = 164
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(99) Then
            valu_allfav_2.Value = 165
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(100) Then
            valu_allfav_2.Value = 166
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(101) Then
            valu_allfav_2.Value = 167
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(102) Then
            valu_allfav_2.Value = 168
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(103) Then
            valu_allfav_2.Value = 169
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(104) Then
            valu_allfav_2.Value = 170
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(105) Then
            valu_allfav_2.Value = 171
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(106) Then
            valu_allfav_2.Value = 172
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(107) Then
            valu_allfav_2.Value = 173
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(108) Then
            valu_allfav_2.Value = 174
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(109) Then
            valu_allfav_2.Value = 175
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(110) Then
            valu_allfav_2.Value = 178
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(111) Then
            valu_allfav_2.Value = 180
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(112) Then
            valu_allfav_2.Value = 182
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(113) Then
            valu_allfav_2.Value = 183
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(114) Then
            valu_allfav_2.Value = 185
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(115) Then
            valu_allfav_2.Value = 186
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(116) Then
            valu_allfav_2.Value = 187
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(117) Then
            valu_allfav_2.Value = 188
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(118) Then
            valu_allfav_2.Value = 189
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(119) Then
            valu_allfav_2.Value = 190
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(120) Then
            valu_allfav_2.Value = 191
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(121) Then
            valu_allfav_2.Value = 192
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(122) Then
            valu_allfav_2.Value = 193
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(123) Then
            valu_allfav_2.Value = 194
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(124) Then
            valu_allfav_2.Value = 195
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(125) Then
            valu_allfav_2.Value = 197
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(126) Then
            valu_allfav_2.Value = 198
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(127) Then
            valu_allfav_2.Value = 199
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(128) Then
            valu_allfav_2.Value = 200
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(129) Then
            valu_allfav_2.Value = 201
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(130) Then
            valu_allfav_2.Value = 202
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(131) Then
            valu_allfav_2.Value = 205
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(132) Then
            valu_allfav_2.Value = 210
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(133) Then
            valu_allfav_2.Value = 216
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(134) Then
            valu_allfav_2.Value = 218
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(135) Then
            valu_allfav_2.Value = 222
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(136) Then
            valu_allfav_2.Value = 229
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(137) Then
            valu_allfav_2.Value = 230
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(138) Then
            valu_allfav_2.Value = 231
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(139) Then
            valu_allfav_2.Value = 232
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(140) Then
            valu_allfav_2.Value = 233
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(141) Then
            valu_allfav_2.Value = 234
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(142) Then
            valu_allfav_2.Value = 235
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(143) Then
            valu_allfav_2.Value = 236
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(144) Then
            valu_allfav_2.Value = 237
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(145) Then
            valu_allfav_2.Value = 238
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(146) Then
            valu_allfav_2.Value = 239
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(147) Then
            valu_allfav_2.Value = 240
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(148) Then
            valu_allfav_2.Value = 241
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(149) Then
            valu_allfav_2.Value = 242
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(150) Then
            valu_allfav_2.Value = 243
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(151) Then
            valu_allfav_2.Value = 244
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(152) Then
            valu_allfav_2.Value = 245
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(153) Then
            valu_allfav_2.Value = 246
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(154) Then
            valu_allfav_2.Value = 247
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(155) Then
            valu_allfav_2.Value = 248
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(156) Then
            valu_allfav_2.Value = 249
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(157) Then
            valu_allfav_2.Value = 250
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(158) Then
            valu_allfav_2.Value = 251
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(159) Then
            valu_allfav_2.Value = 252
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(160) Then
            valu_allfav_2.Value = 253
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(161) Then
            valu_allfav_2.Value = 297
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(162) Then
            valu_allfav_2.Value = 298
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(163) Then
            valu_allfav_2.Value = 299
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(164) Then
            valu_allfav_2.Value = 300
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(165) Then
            valu_allfav_2.Value = 301
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(166) Then
            valu_allfav_2.Value = 302
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(167) Then
            valu_allfav_2.Value = 303
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(168) Then
            valu_allfav_2.Value = 304
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(169) Then
            valu_allfav_2.Value = 305
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(170) Then
            valu_allfav_2.Value = 306
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(171) Then
            valu_allfav_2.Value = 307
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(172) Then
            valu_allfav_2.Value = 308
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(173) Then
            valu_allfav_2.Value = 309
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(174) Then
            valu_allfav_2.Value = 310
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(175) Then
            valu_allfav_2.Value = 311
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(176) Then
            valu_allfav_2.Value = 312
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(177) Then
            valu_allfav_2.Value = 314
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(178) Then
            valu_allfav_2.Value = 315
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(179) Then
            valu_allfav_2.Value = 316
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(180) Then
            valu_allfav_2.Value = 317
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(181) Then
            valu_allfav_2.Value = 318
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(182) Then
            valu_allfav_2.Value = 319
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(183) Then
            valu_allfav_2.Value = 320
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(184) Then
            valu_allfav_2.Value = 321
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(185) Then
            valu_allfav_2.Value = 322
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(186) Then
            valu_allfav_2.Value = 323
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(187) Then
            valu_allfav_2.Value = 324
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(188) Then
            valu_allfav_2.Value = 325
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(189) Then
            valu_allfav_2.Value = 326
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(190) Then
            valu_allfav_2.Value = 327
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(191) Then
            valu_allfav_2.Value = 328
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(192) Then
            valu_allfav_2.Value = 329
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(193) Then
            valu_allfav_2.Value = 330
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(194) Then
            valu_allfav_2.Value = 331
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(195) Then
            valu_allfav_2.Value = 332
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(196) Then
            valu_allfav_2.Value = 333
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(197) Then
            valu_allfav_2.Value = 334
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(198) Then
            valu_allfav_2.Value = 335
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(199) Then
            valu_allfav_2.Value = 336
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(200) Then
            valu_allfav_2.Value = 337
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(201) Then
            valu_allfav_2.Value = 338
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(202) Then
            valu_allfav_2.Value = 340
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(203) Then
            valu_allfav_2.Value = 342
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(204) Then
            valu_allfav_2.Value = 343
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(205) Then
            valu_allfav_2.Value = 344
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(206) Then
            valu_allfav_2.Value = 345
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(207) Then
            valu_allfav_2.Value = 346
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(208) Then
            valu_allfav_2.Value = 347
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(209) Then
            valu_allfav_2.Value = 348
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(210) Then
            valu_allfav_2.Value = 349
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(211) Then
            valu_allfav_2.Value = 350
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(212) Then
            valu_allfav_2.Value = 354
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(213) Then
            valu_allfav_2.Value = 355
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(214) Then
            valu_allfav_2.Value = 356
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(215) Then
            valu_allfav_2.Value = 357
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(216) Then
            valu_allfav_2.Value = 358
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(217) Then
            valu_allfav_2.Value = 359
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(218) Then
            valu_allfav_2.Value = 360
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(219) Then
            valu_allfav_2.Value = 361
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(220) Then
            valu_allfav_2.Value = 362
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(221) Then
            valu_allfav_2.Value = 363
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(222) Then
            valu_allfav_2.Value = 364
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(223) Then
            valu_allfav_2.Value = 365
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(224) Then
            valu_allfav_2.Value = 366
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(225) Then
            valu_allfav_2.Value = 367
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(226) Then
            valu_allfav_2.Value = 368
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(227) Then
            valu_allfav_2.Value = 369
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(228) Then
            valu_allfav_2.Value = 370
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(229) Then
            valu_allfav_2.Value = 371
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(230) Then
            valu_allfav_2.Value = 381
        ElseIf Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(231) Then
            valu_allfav_2.Value = 0
        End If
    End Sub

    Private Sub Select_fav_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_fav_1.SelectedIndexChanged
        If Select_fav_1.SelectedItem = Select_fav_1.Items.Item(0) Then
            valu_fav_1.Value = 65535
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(1) Then
            valu_fav_1.Value = 2
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(2) Then
            valu_fav_1.Value = 5
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(3) Then
            valu_fav_1.Value = 10
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(4) Then
            valu_fav_1.Value = 16
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(5) Then
            valu_fav_1.Value = 20
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(6) Then
            valu_fav_1.Value = 23
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(7) Then
            valu_fav_1.Value = 26
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(8) Then
            valu_fav_1.Value = 27
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(9) Then
            valu_fav_1.Value = 29
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(10) Then
            valu_fav_1.Value = 31
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(11) Then
            valu_fav_1.Value = 32
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(12) Then
            valu_fav_1.Value = 34
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(13) Then
            valu_fav_1.Value = 36
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(14) Then
            valu_fav_1.Value = 38
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(15) Then
            valu_fav_1.Value = 40
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(16) Then
            valu_fav_1.Value = 42
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(17) Then
            valu_fav_1.Value = 44
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(18) Then
            valu_fav_1.Value = 45
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(19) Then
            valu_fav_1.Value = 46
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(20) Then
            valu_fav_1.Value = 47
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(21) Then
            valu_fav_1.Value = 48
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(22) Then
            valu_fav_1.Value = 49
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(23) Then
            valu_fav_1.Value = 50
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(24) Then
            valu_fav_1.Value = 51
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(25) Then
            valu_fav_1.Value = 53
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(26) Then
            valu_fav_1.Value = 54
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(27) Then
            valu_fav_1.Value = 56
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(28) Then
            valu_fav_1.Value = 58
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(29) Then
            valu_fav_1.Value = 61
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(30) Then
            valu_fav_1.Value = 62
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(31) Then
            valu_fav_1.Value = 63
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(32) Then
            valu_fav_1.Value = 66
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(33) Then
            valu_fav_1.Value = 67
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(34) Then
            valu_fav_1.Value = 69
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(35) Then
            valu_fav_1.Value = 70
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(36) Then
            valu_fav_1.Value = 73
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(37) Then
            valu_fav_1.Value = 76
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(38) Then
            valu_fav_1.Value = 77
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(39) Then
            valu_fav_1.Value = 80
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(40) Then
            valu_fav_1.Value = 86
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(41) Then
            valu_fav_1.Value = 87
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(42) Then
            valu_fav_1.Value = 89
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(43) Then
            valu_fav_1.Value = 90
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(44) Then
            valu_fav_1.Value = 91
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(45) Then
            valu_fav_1.Value = 92
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(46) Then
            valu_fav_1.Value = 96
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(47) Then
            valu_fav_1.Value = 97
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(48) Then
            valu_fav_1.Value = 98
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(49) Then
            valu_fav_1.Value = 99
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(50) Then
            valu_fav_1.Value = 100
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(51) Then
            valu_fav_1.Value = 101
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(52) Then
            valu_fav_1.Value = 102
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(53) Then
            valu_fav_1.Value = 103
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(54) Then
            valu_fav_1.Value = 104
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(55) Then
            valu_fav_1.Value = 105
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(56) Then
            valu_fav_1.Value = 106
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(57) Then
            valu_fav_1.Value = 107
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(58) Then
            valu_fav_1.Value = 108
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(59) Then
            valu_fav_1.Value = 109
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(60) Then
            valu_fav_1.Value = 110
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(61) Then
            valu_fav_1.Value = 112
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(62) Then
            valu_fav_1.Value = 114
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(63) Then
            valu_fav_1.Value = 115
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(64) Then
            valu_fav_1.Value = 117
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(65) Then
            valu_fav_1.Value = 119
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(66) Then
            valu_fav_1.Value = 122
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(67) Then
            valu_fav_1.Value = 123
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(68) Then
            valu_fav_1.Value = 126
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(69) Then
            valu_fav_1.Value = 132
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(70) Then
            valu_fav_1.Value = 135
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(71) Then
            valu_fav_1.Value = 136
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(72) Then
            valu_fav_1.Value = 137
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(73) Then
            valu_fav_1.Value = 138
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(74) Then
            valu_fav_1.Value = 139
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(75) Then
            valu_fav_1.Value = 140
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(76) Then
            valu_fav_1.Value = 141
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(77) Then
            valu_fav_1.Value = 142
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(78) Then
            valu_fav_1.Value = 143
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(79) Then
            valu_fav_1.Value = 144
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(80) Then
            valu_fav_1.Value = 146
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(81) Then
            valu_fav_1.Value = 147
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(82) Then
            valu_fav_1.Value = 148
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(83) Then
            valu_fav_1.Value = 149
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(84) Then
            valu_fav_1.Value = 150
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(85) Then
            valu_fav_1.Value = 151
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(86) Then
            valu_fav_1.Value = 152
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(87) Then
            valu_fav_1.Value = 153
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(88) Then
            valu_fav_1.Value = 154
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(89) Then
            valu_fav_1.Value = 155
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(90) Then
            valu_fav_1.Value = 156
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(91) Then
            valu_fav_1.Value = 157
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(92) Then
            valu_fav_1.Value = 158
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(93) Then
            valu_fav_1.Value = 159
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(94) Then
            valu_fav_1.Value = 160
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(95) Then
            valu_fav_1.Value = 161
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(96) Then
            valu_fav_1.Value = 162
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(97) Then
            valu_fav_1.Value = 163
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(98) Then
            valu_fav_1.Value = 164
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(99) Then
            valu_fav_1.Value = 165
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(100) Then
            valu_fav_1.Value = 166
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(101) Then
            valu_fav_1.Value = 167
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(102) Then
            valu_fav_1.Value = 168
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(103) Then
            valu_fav_1.Value = 169
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(104) Then
            valu_fav_1.Value = 170
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(105) Then
            valu_fav_1.Value = 171
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(106) Then
            valu_fav_1.Value = 172
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(107) Then
            valu_fav_1.Value = 173
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(108) Then
            valu_fav_1.Value = 174
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(109) Then
            valu_fav_1.Value = 175
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(110) Then
            valu_fav_1.Value = 178
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(111) Then
            valu_fav_1.Value = 180
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(112) Then
            valu_fav_1.Value = 182
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(113) Then
            valu_fav_1.Value = 183
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(114) Then
            valu_fav_1.Value = 185
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(115) Then
            valu_fav_1.Value = 186
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(116) Then
            valu_fav_1.Value = 187
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(117) Then
            valu_fav_1.Value = 188
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(118) Then
            valu_fav_1.Value = 189
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(119) Then
            valu_fav_1.Value = 190
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(120) Then
            valu_fav_1.Value = 191
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(121) Then
            valu_fav_1.Value = 192
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(122) Then
            valu_fav_1.Value = 193
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(123) Then
            valu_fav_1.Value = 194
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(124) Then
            valu_fav_1.Value = 195
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(125) Then
            valu_fav_1.Value = 197
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(126) Then
            valu_fav_1.Value = 198
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(127) Then
            valu_fav_1.Value = 199
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(128) Then
            valu_fav_1.Value = 200
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(129) Then
            valu_fav_1.Value = 201
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(130) Then
            valu_fav_1.Value = 202
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(131) Then
            valu_fav_1.Value = 205
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(132) Then
            valu_fav_1.Value = 210
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(133) Then
            valu_fav_1.Value = 216
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(134) Then
            valu_fav_1.Value = 218
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(135) Then
            valu_fav_1.Value = 222
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(136) Then
            valu_fav_1.Value = 229
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(137) Then
            valu_fav_1.Value = 230
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(138) Then
            valu_fav_1.Value = 231
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(139) Then
            valu_fav_1.Value = 232
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(140) Then
            valu_fav_1.Value = 233
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(141) Then
            valu_fav_1.Value = 234
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(142) Then
            valu_fav_1.Value = 235
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(143) Then
            valu_fav_1.Value = 236
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(144) Then
            valu_fav_1.Value = 237
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(145) Then
            valu_fav_1.Value = 238
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(146) Then
            valu_fav_1.Value = 239
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(147) Then
            valu_fav_1.Value = 240
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(148) Then
            valu_fav_1.Value = 241
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(149) Then
            valu_fav_1.Value = 242
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(150) Then
            valu_fav_1.Value = 243
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(151) Then
            valu_fav_1.Value = 244
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(152) Then
            valu_fav_1.Value = 245
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(153) Then
            valu_fav_1.Value = 246
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(154) Then
            valu_fav_1.Value = 247
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(155) Then
            valu_fav_1.Value = 248
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(156) Then
            valu_fav_1.Value = 249
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(157) Then
            valu_fav_1.Value = 250
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(158) Then
            valu_fav_1.Value = 251
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(159) Then
            valu_fav_1.Value = 252
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(160) Then
            valu_fav_1.Value = 253
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(161) Then
            valu_fav_1.Value = 297
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(162) Then
            valu_fav_1.Value = 298
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(163) Then
            valu_fav_1.Value = 299
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(164) Then
            valu_fav_1.Value = 300
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(165) Then
            valu_fav_1.Value = 301
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(166) Then
            valu_fav_1.Value = 302
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(167) Then
            valu_fav_1.Value = 303
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(168) Then
            valu_fav_1.Value = 304
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(169) Then
            valu_fav_1.Value = 305
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(170) Then
            valu_fav_1.Value = 306
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(171) Then
            valu_fav_1.Value = 307
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(172) Then
            valu_fav_1.Value = 308
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(173) Then
            valu_fav_1.Value = 309
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(174) Then
            valu_fav_1.Value = 310
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(175) Then
            valu_fav_1.Value = 311
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(176) Then
            valu_fav_1.Value = 312
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(177) Then
            valu_fav_1.Value = 314
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(178) Then
            valu_fav_1.Value = 315
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(179) Then
            valu_fav_1.Value = 316
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(180) Then
            valu_fav_1.Value = 317
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(181) Then
            valu_fav_1.Value = 318
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(182) Then
            valu_fav_1.Value = 319
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(183) Then
            valu_fav_1.Value = 320
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(184) Then
            valu_fav_1.Value = 321
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(185) Then
            valu_fav_1.Value = 322
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(186) Then
            valu_fav_1.Value = 323
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(187) Then
            valu_fav_1.Value = 324
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(188) Then
            valu_fav_1.Value = 325
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(189) Then
            valu_fav_1.Value = 326
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(190) Then
            valu_fav_1.Value = 327
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(191) Then
            valu_fav_1.Value = 328
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(192) Then
            valu_fav_1.Value = 329
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(193) Then
            valu_fav_1.Value = 330
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(194) Then
            valu_fav_1.Value = 331
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(195) Then
            valu_fav_1.Value = 332
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(196) Then
            valu_fav_1.Value = 333
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(197) Then
            valu_fav_1.Value = 334
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(198) Then
            valu_fav_1.Value = 335
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(199) Then
            valu_fav_1.Value = 336
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(200) Then
            valu_fav_1.Value = 337
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(201) Then
            valu_fav_1.Value = 338
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(202) Then
            valu_fav_1.Value = 340
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(203) Then
            valu_fav_1.Value = 342
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(204) Then
            valu_fav_1.Value = 343
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(205) Then
            valu_fav_1.Value = 344
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(206) Then
            valu_fav_1.Value = 345
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(207) Then
            valu_fav_1.Value = 346
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(208) Then
            valu_fav_1.Value = 347
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(209) Then
            valu_fav_1.Value = 348
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(210) Then
            valu_fav_1.Value = 349
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(211) Then
            valu_fav_1.Value = 350
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(212) Then
            valu_fav_1.Value = 354
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(213) Then
            valu_fav_1.Value = 355
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(214) Then
            valu_fav_1.Value = 356
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(215) Then
            valu_fav_1.Value = 357
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(216) Then
            valu_fav_1.Value = 358
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(217) Then
            valu_fav_1.Value = 359
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(218) Then
            valu_fav_1.Value = 360
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(219) Then
            valu_fav_1.Value = 361
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(220) Then
            valu_fav_1.Value = 362
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(221) Then
            valu_fav_1.Value = 363
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(222) Then
            valu_fav_1.Value = 364
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(223) Then
            valu_fav_1.Value = 365
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(224) Then
            valu_fav_1.Value = 366
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(225) Then
            valu_fav_1.Value = 367
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(226) Then
            valu_fav_1.Value = 368
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(227) Then
            valu_fav_1.Value = 369
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(228) Then
            valu_fav_1.Value = 370
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(229) Then
            valu_fav_1.Value = 371
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(230) Then
            valu_fav_1.Value = 381
        ElseIf Select_fav_1.SelectedItem = Select_fav_1.Items.Item(231) Then
            valu_fav_1.Value = 0
        End If
    End Sub

    Private Sub Select_fav_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_fav_2.SelectedIndexChanged
        If Select_fav_2.SelectedItem = Select_fav_2.Items.Item(0) Then
            valu_fav_2.Value = 65535
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(1) Then
            valu_fav_2.Value = 2
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(2) Then
            valu_fav_2.Value = 5
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(3) Then
            valu_fav_2.Value = 10
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(4) Then
            valu_fav_2.Value = 16
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(5) Then
            valu_fav_2.Value = 20
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(6) Then
            valu_fav_2.Value = 23
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(7) Then
            valu_fav_2.Value = 26
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(8) Then
            valu_fav_2.Value = 27
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(9) Then
            valu_fav_2.Value = 29
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(10) Then
            valu_fav_2.Value = 31
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(11) Then
            valu_fav_2.Value = 32
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(12) Then
            valu_fav_2.Value = 34
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(13) Then
            valu_fav_2.Value = 36
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(14) Then
            valu_fav_2.Value = 38
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(15) Then
            valu_fav_2.Value = 40
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(16) Then
            valu_fav_2.Value = 42
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(17) Then
            valu_fav_2.Value = 44
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(18) Then
            valu_fav_2.Value = 45
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(19) Then
            valu_fav_2.Value = 46
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(20) Then
            valu_fav_2.Value = 47
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(21) Then
            valu_fav_2.Value = 48
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(22) Then
            valu_fav_2.Value = 49
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(23) Then
            valu_fav_2.Value = 50
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(24) Then
            valu_fav_2.Value = 51
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(25) Then
            valu_fav_2.Value = 53
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(26) Then
            valu_fav_2.Value = 54
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(27) Then
            valu_fav_2.Value = 56
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(28) Then
            valu_fav_2.Value = 58
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(29) Then
            valu_fav_2.Value = 61
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(30) Then
            valu_fav_2.Value = 62
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(31) Then
            valu_fav_2.Value = 63
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(32) Then
            valu_fav_2.Value = 66
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(33) Then
            valu_fav_2.Value = 67
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(34) Then
            valu_fav_2.Value = 69
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(35) Then
            valu_fav_2.Value = 70
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(36) Then
            valu_fav_2.Value = 73
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(37) Then
            valu_fav_2.Value = 76
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(38) Then
            valu_fav_2.Value = 77
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(39) Then
            valu_fav_2.Value = 80
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(40) Then
            valu_fav_2.Value = 86
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(41) Then
            valu_fav_2.Value = 87
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(42) Then
            valu_fav_2.Value = 89
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(43) Then
            valu_fav_2.Value = 90
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(44) Then
            valu_fav_2.Value = 91
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(45) Then
            valu_fav_2.Value = 92
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(46) Then
            valu_fav_2.Value = 96
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(47) Then
            valu_fav_2.Value = 97
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(48) Then
            valu_fav_2.Value = 98
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(49) Then
            valu_fav_2.Value = 99
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(50) Then
            valu_fav_2.Value = 100
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(51) Then
            valu_fav_2.Value = 101
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(52) Then
            valu_fav_2.Value = 102
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(53) Then
            valu_fav_2.Value = 103
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(54) Then
            valu_fav_2.Value = 104
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(55) Then
            valu_fav_2.Value = 105
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(56) Then
            valu_fav_2.Value = 106
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(57) Then
            valu_fav_2.Value = 107
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(58) Then
            valu_fav_2.Value = 108
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(59) Then
            valu_fav_2.Value = 109
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(60) Then
            valu_fav_2.Value = 110
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(61) Then
            valu_fav_2.Value = 112
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(62) Then
            valu_fav_2.Value = 114
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(63) Then
            valu_fav_2.Value = 115
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(64) Then
            valu_fav_2.Value = 117
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(65) Then
            valu_fav_2.Value = 119
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(66) Then
            valu_fav_2.Value = 122
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(67) Then
            valu_fav_2.Value = 123
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(68) Then
            valu_fav_2.Value = 126
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(69) Then
            valu_fav_2.Value = 132
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(70) Then
            valu_fav_2.Value = 135
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(71) Then
            valu_fav_2.Value = 136
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(72) Then
            valu_fav_2.Value = 137
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(73) Then
            valu_fav_2.Value = 138
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(74) Then
            valu_fav_2.Value = 139
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(75) Then
            valu_fav_2.Value = 140
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(76) Then
            valu_fav_2.Value = 141
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(77) Then
            valu_fav_2.Value = 142
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(78) Then
            valu_fav_2.Value = 143
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(79) Then
            valu_fav_2.Value = 144
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(80) Then
            valu_fav_2.Value = 146
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(81) Then
            valu_fav_2.Value = 147
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(82) Then
            valu_fav_2.Value = 148
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(83) Then
            valu_fav_2.Value = 149
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(84) Then
            valu_fav_2.Value = 150
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(85) Then
            valu_fav_2.Value = 151
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(86) Then
            valu_fav_2.Value = 152
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(87) Then
            valu_fav_2.Value = 153
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(88) Then
            valu_fav_2.Value = 154
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(89) Then
            valu_fav_2.Value = 155
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(90) Then
            valu_fav_2.Value = 156
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(91) Then
            valu_fav_2.Value = 157
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(92) Then
            valu_fav_2.Value = 158
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(93) Then
            valu_fav_2.Value = 159
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(94) Then
            valu_fav_2.Value = 160
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(95) Then
            valu_fav_2.Value = 161
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(96) Then
            valu_fav_2.Value = 162
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(97) Then
            valu_fav_2.Value = 163
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(98) Then
            valu_fav_2.Value = 164
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(99) Then
            valu_fav_2.Value = 165
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(100) Then
            valu_fav_2.Value = 166
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(101) Then
            valu_fav_2.Value = 167
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(102) Then
            valu_fav_2.Value = 168
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(103) Then
            valu_fav_2.Value = 169
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(104) Then
            valu_fav_2.Value = 170
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(105) Then
            valu_fav_2.Value = 171
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(106) Then
            valu_fav_2.Value = 172
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(107) Then
            valu_fav_2.Value = 173
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(108) Then
            valu_fav_2.Value = 174
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(109) Then
            valu_fav_2.Value = 175
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(110) Then
            valu_fav_2.Value = 178
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(111) Then
            valu_fav_2.Value = 180
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(112) Then
            valu_fav_2.Value = 182
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(113) Then
            valu_fav_2.Value = 183
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(114) Then
            valu_fav_2.Value = 185
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(115) Then
            valu_fav_2.Value = 186
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(116) Then
            valu_fav_2.Value = 187
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(117) Then
            valu_fav_2.Value = 188
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(118) Then
            valu_fav_2.Value = 189
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(119) Then
            valu_fav_2.Value = 190
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(120) Then
            valu_fav_2.Value = 191
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(121) Then
            valu_fav_2.Value = 192
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(122) Then
            valu_fav_2.Value = 193
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(123) Then
            valu_fav_2.Value = 194
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(124) Then
            valu_fav_2.Value = 195
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(125) Then
            valu_fav_2.Value = 197
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(126) Then
            valu_fav_2.Value = 198
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(127) Then
            valu_fav_2.Value = 199
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(128) Then
            valu_fav_2.Value = 200
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(129) Then
            valu_fav_2.Value = 201
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(130) Then
            valu_fav_2.Value = 202
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(131) Then
            valu_fav_2.Value = 205
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(132) Then
            valu_fav_2.Value = 210
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(133) Then
            valu_fav_2.Value = 216
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(134) Then
            valu_fav_2.Value = 218
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(135) Then
            valu_fav_2.Value = 222
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(136) Then
            valu_fav_2.Value = 229
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(137) Then
            valu_fav_2.Value = 230
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(138) Then
            valu_fav_2.Value = 231
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(139) Then
            valu_fav_2.Value = 232
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(140) Then
            valu_fav_2.Value = 233
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(141) Then
            valu_fav_2.Value = 234
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(142) Then
            valu_fav_2.Value = 235
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(143) Then
            valu_fav_2.Value = 236
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(144) Then
            valu_fav_2.Value = 237
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(145) Then
            valu_fav_2.Value = 238
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(146) Then
            valu_fav_2.Value = 239
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(147) Then
            valu_fav_2.Value = 240
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(148) Then
            valu_fav_2.Value = 241
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(149) Then
            valu_fav_2.Value = 242
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(150) Then
            valu_fav_2.Value = 243
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(151) Then
            valu_fav_2.Value = 244
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(152) Then
            valu_fav_2.Value = 245
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(153) Then
            valu_fav_2.Value = 246
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(154) Then
            valu_fav_2.Value = 247
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(155) Then
            valu_fav_2.Value = 248
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(156) Then
            valu_fav_2.Value = 249
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(157) Then
            valu_fav_2.Value = 250
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(158) Then
            valu_fav_2.Value = 251
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(159) Then
            valu_fav_2.Value = 252
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(160) Then
            valu_fav_2.Value = 253
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(161) Then
            valu_fav_2.Value = 297
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(162) Then
            valu_fav_2.Value = 298
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(163) Then
            valu_fav_2.Value = 299
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(164) Then
            valu_fav_2.Value = 300
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(165) Then
            valu_fav_2.Value = 301
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(166) Then
            valu_fav_2.Value = 302
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(167) Then
            valu_fav_2.Value = 303
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(168) Then
            valu_fav_2.Value = 304
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(169) Then
            valu_fav_2.Value = 305
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(170) Then
            valu_fav_2.Value = 306
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(171) Then
            valu_fav_2.Value = 307
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(172) Then
            valu_fav_2.Value = 308
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(173) Then
            valu_fav_2.Value = 309
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(174) Then
            valu_fav_2.Value = 310
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(175) Then
            valu_fav_2.Value = 311
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(176) Then
            valu_fav_2.Value = 312
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(177) Then
            valu_fav_2.Value = 314
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(178) Then
            valu_fav_2.Value = 315
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(179) Then
            valu_fav_2.Value = 316
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(180) Then
            valu_fav_2.Value = 317
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(181) Then
            valu_fav_2.Value = 318
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(182) Then
            valu_fav_2.Value = 319
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(183) Then
            valu_fav_2.Value = 320
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(184) Then
            valu_fav_2.Value = 321
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(185) Then
            valu_fav_2.Value = 322
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(186) Then
            valu_fav_2.Value = 323
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(187) Then
            valu_fav_2.Value = 324
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(188) Then
            valu_fav_2.Value = 325
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(189) Then
            valu_fav_2.Value = 326
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(190) Then
            valu_fav_2.Value = 327
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(191) Then
            valu_fav_2.Value = 328
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(192) Then
            valu_fav_2.Value = 329
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(193) Then
            valu_fav_2.Value = 330
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(194) Then
            valu_fav_2.Value = 331
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(195) Then
            valu_fav_2.Value = 332
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(196) Then
            valu_fav_2.Value = 333
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(197) Then
            valu_fav_2.Value = 334
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(198) Then
            valu_fav_2.Value = 335
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(199) Then
            valu_fav_2.Value = 336
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(200) Then
            valu_fav_2.Value = 337
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(201) Then
            valu_fav_2.Value = 338
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(202) Then
            valu_fav_2.Value = 340
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(203) Then
            valu_fav_2.Value = 342
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(204) Then
            valu_fav_2.Value = 343
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(205) Then
            valu_fav_2.Value = 344
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(206) Then
            valu_fav_2.Value = 345
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(207) Then
            valu_fav_2.Value = 346
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(208) Then
            valu_fav_2.Value = 347
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(209) Then
            valu_fav_2.Value = 348
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(210) Then
            valu_fav_2.Value = 349
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(211) Then
            valu_fav_2.Value = 350
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(212) Then
            valu_fav_2.Value = 354
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(213) Then
            valu_fav_2.Value = 355
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(214) Then
            valu_fav_2.Value = 356
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(215) Then
            valu_fav_2.Value = 357
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(216) Then
            valu_fav_2.Value = 358
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(217) Then
            valu_fav_2.Value = 359
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(218) Then
            valu_fav_2.Value = 360
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(219) Then
            valu_fav_2.Value = 361
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(220) Then
            valu_fav_2.Value = 362
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(221) Then
            valu_fav_2.Value = 363
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(222) Then
            valu_fav_2.Value = 364
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(223) Then
            valu_fav_2.Value = 365
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(224) Then
            valu_fav_2.Value = 366
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(225) Then
            valu_fav_2.Value = 367
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(226) Then
            valu_fav_2.Value = 368
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(227) Then
            valu_fav_2.Value = 369
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(228) Then
            valu_fav_2.Value = 370
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(229) Then
            valu_fav_2.Value = 371
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(230) Then
            valu_fav_2.Value = 381
        ElseIf Select_fav_2.SelectedItem = Select_fav_2.Items.Item(231) Then
            valu_fav_2.Value = 0
        End If
    End Sub

    Private Sub Select_fav_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_fav_3.SelectedIndexChanged
        If Select_fav_3.SelectedItem = Select_fav_3.Items.Item(0) Then
            valu_fav_3.Value = 65535
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(1) Then
            valu_fav_3.Value = 2
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(2) Then
            valu_fav_3.Value = 5
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(3) Then
            valu_fav_3.Value = 10
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(4) Then
            valu_fav_3.Value = 16
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(5) Then
            valu_fav_3.Value = 20
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(6) Then
            valu_fav_3.Value = 23
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(7) Then
            valu_fav_3.Value = 26
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(8) Then
            valu_fav_3.Value = 27
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(9) Then
            valu_fav_3.Value = 29
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(10) Then
            valu_fav_3.Value = 31
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(11) Then
            valu_fav_3.Value = 32
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(12) Then
            valu_fav_3.Value = 34
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(13) Then
            valu_fav_3.Value = 36
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(14) Then
            valu_fav_3.Value = 38
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(15) Then
            valu_fav_3.Value = 40
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(16) Then
            valu_fav_3.Value = 42
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(17) Then
            valu_fav_3.Value = 44
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(18) Then
            valu_fav_3.Value = 45
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(19) Then
            valu_fav_3.Value = 46
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(20) Then
            valu_fav_3.Value = 47
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(21) Then
            valu_fav_3.Value = 48
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(22) Then
            valu_fav_3.Value = 49
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(23) Then
            valu_fav_3.Value = 50
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(24) Then
            valu_fav_3.Value = 51
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(25) Then
            valu_fav_3.Value = 53
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(26) Then
            valu_fav_3.Value = 54
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(27) Then
            valu_fav_3.Value = 56
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(28) Then
            valu_fav_3.Value = 58
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(29) Then
            valu_fav_3.Value = 61
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(30) Then
            valu_fav_3.Value = 62
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(31) Then
            valu_fav_3.Value = 63
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(32) Then
            valu_fav_3.Value = 66
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(33) Then
            valu_fav_3.Value = 67
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(34) Then
            valu_fav_3.Value = 69
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(35) Then
            valu_fav_3.Value = 70
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(36) Then
            valu_fav_3.Value = 73
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(37) Then
            valu_fav_3.Value = 76
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(38) Then
            valu_fav_3.Value = 77
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(39) Then
            valu_fav_3.Value = 80
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(40) Then
            valu_fav_3.Value = 86
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(41) Then
            valu_fav_3.Value = 87
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(42) Then
            valu_fav_3.Value = 89
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(43) Then
            valu_fav_3.Value = 90
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(44) Then
            valu_fav_3.Value = 91
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(45) Then
            valu_fav_3.Value = 92
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(46) Then
            valu_fav_3.Value = 96
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(47) Then
            valu_fav_3.Value = 97
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(48) Then
            valu_fav_3.Value = 98
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(49) Then
            valu_fav_3.Value = 99
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(50) Then
            valu_fav_3.Value = 100
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(51) Then
            valu_fav_3.Value = 101
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(52) Then
            valu_fav_3.Value = 102
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(53) Then
            valu_fav_3.Value = 103
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(54) Then
            valu_fav_3.Value = 104
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(55) Then
            valu_fav_3.Value = 105
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(56) Then
            valu_fav_3.Value = 106
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(57) Then
            valu_fav_3.Value = 107
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(58) Then
            valu_fav_3.Value = 108
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(59) Then
            valu_fav_3.Value = 109
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(60) Then
            valu_fav_3.Value = 110
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(61) Then
            valu_fav_3.Value = 112
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(62) Then
            valu_fav_3.Value = 114
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(63) Then
            valu_fav_3.Value = 115
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(64) Then
            valu_fav_3.Value = 117
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(65) Then
            valu_fav_3.Value = 119
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(66) Then
            valu_fav_3.Value = 122
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(67) Then
            valu_fav_3.Value = 123
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(68) Then
            valu_fav_3.Value = 126
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(69) Then
            valu_fav_3.Value = 132
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(70) Then
            valu_fav_3.Value = 135
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(71) Then
            valu_fav_3.Value = 136
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(72) Then
            valu_fav_3.Value = 137
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(73) Then
            valu_fav_3.Value = 138
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(74) Then
            valu_fav_3.Value = 139
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(75) Then
            valu_fav_3.Value = 140
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(76) Then
            valu_fav_3.Value = 141
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(77) Then
            valu_fav_3.Value = 142
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(78) Then
            valu_fav_3.Value = 143
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(79) Then
            valu_fav_3.Value = 144
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(80) Then
            valu_fav_3.Value = 146
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(81) Then
            valu_fav_3.Value = 147
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(82) Then
            valu_fav_3.Value = 148
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(83) Then
            valu_fav_3.Value = 149
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(84) Then
            valu_fav_3.Value = 150
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(85) Then
            valu_fav_3.Value = 151
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(86) Then
            valu_fav_3.Value = 152
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(87) Then
            valu_fav_3.Value = 153
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(88) Then
            valu_fav_3.Value = 154
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(89) Then
            valu_fav_3.Value = 155
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(90) Then
            valu_fav_3.Value = 156
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(91) Then
            valu_fav_3.Value = 157
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(92) Then
            valu_fav_3.Value = 158
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(93) Then
            valu_fav_3.Value = 159
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(94) Then
            valu_fav_3.Value = 160
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(95) Then
            valu_fav_3.Value = 161
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(96) Then
            valu_fav_3.Value = 162
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(97) Then
            valu_fav_3.Value = 163
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(98) Then
            valu_fav_3.Value = 164
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(99) Then
            valu_fav_3.Value = 165
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(100) Then
            valu_fav_3.Value = 166
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(101) Then
            valu_fav_3.Value = 167
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(102) Then
            valu_fav_3.Value = 168
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(103) Then
            valu_fav_3.Value = 169
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(104) Then
            valu_fav_3.Value = 170
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(105) Then
            valu_fav_3.Value = 171
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(106) Then
            valu_fav_3.Value = 172
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(107) Then
            valu_fav_3.Value = 173
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(108) Then
            valu_fav_3.Value = 174
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(109) Then
            valu_fav_3.Value = 175
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(110) Then
            valu_fav_3.Value = 178
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(111) Then
            valu_fav_3.Value = 180
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(112) Then
            valu_fav_3.Value = 182
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(113) Then
            valu_fav_3.Value = 183
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(114) Then
            valu_fav_3.Value = 185
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(115) Then
            valu_fav_3.Value = 186
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(116) Then
            valu_fav_3.Value = 187
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(117) Then
            valu_fav_3.Value = 188
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(118) Then
            valu_fav_3.Value = 189
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(119) Then
            valu_fav_3.Value = 190
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(120) Then
            valu_fav_3.Value = 191
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(121) Then
            valu_fav_3.Value = 192
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(122) Then
            valu_fav_3.Value = 193
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(123) Then
            valu_fav_3.Value = 194
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(124) Then
            valu_fav_3.Value = 195
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(125) Then
            valu_fav_3.Value = 197
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(126) Then
            valu_fav_3.Value = 198
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(127) Then
            valu_fav_3.Value = 199
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(128) Then
            valu_fav_3.Value = 200
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(129) Then
            valu_fav_3.Value = 201
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(130) Then
            valu_fav_3.Value = 202
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(131) Then
            valu_fav_3.Value = 205
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(132) Then
            valu_fav_3.Value = 210
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(133) Then
            valu_fav_3.Value = 216
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(134) Then
            valu_fav_3.Value = 218
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(135) Then
            valu_fav_3.Value = 222
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(136) Then
            valu_fav_3.Value = 229
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(137) Then
            valu_fav_3.Value = 230
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(138) Then
            valu_fav_3.Value = 231
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(139) Then
            valu_fav_3.Value = 232
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(140) Then
            valu_fav_3.Value = 233
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(141) Then
            valu_fav_3.Value = 234
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(142) Then
            valu_fav_3.Value = 235
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(143) Then
            valu_fav_3.Value = 236
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(144) Then
            valu_fav_3.Value = 237
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(145) Then
            valu_fav_3.Value = 238
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(146) Then
            valu_fav_3.Value = 239
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(147) Then
            valu_fav_3.Value = 240
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(148) Then
            valu_fav_3.Value = 241
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(149) Then
            valu_fav_3.Value = 242
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(150) Then
            valu_fav_3.Value = 243
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(151) Then
            valu_fav_3.Value = 244
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(152) Then
            valu_fav_3.Value = 245
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(153) Then
            valu_fav_3.Value = 246
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(154) Then
            valu_fav_3.Value = 247
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(155) Then
            valu_fav_3.Value = 248
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(156) Then
            valu_fav_3.Value = 249
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(157) Then
            valu_fav_3.Value = 250
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(158) Then
            valu_fav_3.Value = 251
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(159) Then
            valu_fav_3.Value = 252
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(160) Then
            valu_fav_3.Value = 253
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(161) Then
            valu_fav_3.Value = 297
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(162) Then
            valu_fav_3.Value = 298
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(163) Then
            valu_fav_3.Value = 299
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(164) Then
            valu_fav_3.Value = 300
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(165) Then
            valu_fav_3.Value = 301
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(166) Then
            valu_fav_3.Value = 302
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(167) Then
            valu_fav_3.Value = 303
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(168) Then
            valu_fav_3.Value = 304
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(169) Then
            valu_fav_3.Value = 305
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(170) Then
            valu_fav_3.Value = 306
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(171) Then
            valu_fav_3.Value = 307
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(172) Then
            valu_fav_3.Value = 308
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(173) Then
            valu_fav_3.Value = 309
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(174) Then
            valu_fav_3.Value = 310
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(175) Then
            valu_fav_3.Value = 311
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(176) Then
            valu_fav_3.Value = 312
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(177) Then
            valu_fav_3.Value = 314
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(178) Then
            valu_fav_3.Value = 315
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(179) Then
            valu_fav_3.Value = 316
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(180) Then
            valu_fav_3.Value = 317
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(181) Then
            valu_fav_3.Value = 318
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(182) Then
            valu_fav_3.Value = 319
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(183) Then
            valu_fav_3.Value = 320
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(184) Then
            valu_fav_3.Value = 321
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(185) Then
            valu_fav_3.Value = 322
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(186) Then
            valu_fav_3.Value = 323
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(187) Then
            valu_fav_3.Value = 324
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(188) Then
            valu_fav_3.Value = 325
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(189) Then
            valu_fav_3.Value = 326
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(190) Then
            valu_fav_3.Value = 327
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(191) Then
            valu_fav_3.Value = 328
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(192) Then
            valu_fav_3.Value = 329
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(193) Then
            valu_fav_3.Value = 330
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(194) Then
            valu_fav_3.Value = 331
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(195) Then
            valu_fav_3.Value = 332
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(196) Then
            valu_fav_3.Value = 333
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(197) Then
            valu_fav_3.Value = 334
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(198) Then
            valu_fav_3.Value = 335
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(199) Then
            valu_fav_3.Value = 336
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(200) Then
            valu_fav_3.Value = 337
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(201) Then
            valu_fav_3.Value = 338
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(202) Then
            valu_fav_3.Value = 340
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(203) Then
            valu_fav_3.Value = 342
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(204) Then
            valu_fav_3.Value = 343
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(205) Then
            valu_fav_3.Value = 344
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(206) Then
            valu_fav_3.Value = 345
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(207) Then
            valu_fav_3.Value = 346
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(208) Then
            valu_fav_3.Value = 347
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(209) Then
            valu_fav_3.Value = 348
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(210) Then
            valu_fav_3.Value = 349
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(211) Then
            valu_fav_3.Value = 350
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(212) Then
            valu_fav_3.Value = 354
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(213) Then
            valu_fav_3.Value = 355
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(214) Then
            valu_fav_3.Value = 356
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(215) Then
            valu_fav_3.Value = 357
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(216) Then
            valu_fav_3.Value = 358
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(217) Then
            valu_fav_3.Value = 359
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(218) Then
            valu_fav_3.Value = 360
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(219) Then
            valu_fav_3.Value = 361
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(220) Then
            valu_fav_3.Value = 362
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(221) Then
            valu_fav_3.Value = 363
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(222) Then
            valu_fav_3.Value = 364
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(223) Then
            valu_fav_3.Value = 365
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(224) Then
            valu_fav_3.Value = 366
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(225) Then
            valu_fav_3.Value = 367
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(226) Then
            valu_fav_3.Value = 368
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(227) Then
            valu_fav_3.Value = 369
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(228) Then
            valu_fav_3.Value = 370
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(229) Then
            valu_fav_3.Value = 371
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(230) Then
            valu_fav_3.Value = 381
        ElseIf Select_fav_3.SelectedItem = Select_fav_3.Items.Item(231) Then
            valu_fav_3.Value = 0
        End If
    End Sub

    Private Sub Select_worst_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_worst_1.SelectedIndexChanged
        If Select_worst_1.SelectedItem = Select_worst_1.Items.Item(0) Then
            valu_worst_1.Value = 65535
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(1) Then
            valu_worst_1.Value = 2
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(2) Then
            valu_worst_1.Value = 5
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(3) Then
            valu_worst_1.Value = 10
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(4) Then
            valu_worst_1.Value = 16
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(5) Then
            valu_worst_1.Value = 20
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(6) Then
            valu_worst_1.Value = 23
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(7) Then
            valu_worst_1.Value = 26
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(8) Then
            valu_worst_1.Value = 27
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(9) Then
            valu_worst_1.Value = 29
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(10) Then
            valu_worst_1.Value = 31
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(11) Then
            valu_worst_1.Value = 32
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(12) Then
            valu_worst_1.Value = 34
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(13) Then
            valu_worst_1.Value = 36
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(14) Then
            valu_worst_1.Value = 38
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(15) Then
            valu_worst_1.Value = 40
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(16) Then
            valu_worst_1.Value = 42
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(17) Then
            valu_worst_1.Value = 44
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(18) Then
            valu_worst_1.Value = 45
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(19) Then
            valu_worst_1.Value = 46
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(20) Then
            valu_worst_1.Value = 47
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(21) Then
            valu_worst_1.Value = 48
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(22) Then
            valu_worst_1.Value = 49
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(23) Then
            valu_worst_1.Value = 50
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(24) Then
            valu_worst_1.Value = 51
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(25) Then
            valu_worst_1.Value = 53
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(26) Then
            valu_worst_1.Value = 54
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(27) Then
            valu_worst_1.Value = 56
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(28) Then
            valu_worst_1.Value = 58
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(29) Then
            valu_worst_1.Value = 61
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(30) Then
            valu_worst_1.Value = 62
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(31) Then
            valu_worst_1.Value = 63
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(32) Then
            valu_worst_1.Value = 66
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(33) Then
            valu_worst_1.Value = 67
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(34) Then
            valu_worst_1.Value = 69
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(35) Then
            valu_worst_1.Value = 70
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(36) Then
            valu_worst_1.Value = 73
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(37) Then
            valu_worst_1.Value = 76
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(38) Then
            valu_worst_1.Value = 77
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(39) Then
            valu_worst_1.Value = 80
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(40) Then
            valu_worst_1.Value = 86
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(41) Then
            valu_worst_1.Value = 87
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(42) Then
            valu_worst_1.Value = 89
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(43) Then
            valu_worst_1.Value = 90
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(44) Then
            valu_worst_1.Value = 91
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(45) Then
            valu_worst_1.Value = 92
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(46) Then
            valu_worst_1.Value = 96
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(47) Then
            valu_worst_1.Value = 97
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(48) Then
            valu_worst_1.Value = 98
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(49) Then
            valu_worst_1.Value = 99
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(50) Then
            valu_worst_1.Value = 100
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(51) Then
            valu_worst_1.Value = 101
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(52) Then
            valu_worst_1.Value = 102
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(53) Then
            valu_worst_1.Value = 103
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(54) Then
            valu_worst_1.Value = 104
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(55) Then
            valu_worst_1.Value = 105
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(56) Then
            valu_worst_1.Value = 106
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(57) Then
            valu_worst_1.Value = 107
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(58) Then
            valu_worst_1.Value = 108
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(59) Then
            valu_worst_1.Value = 109
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(60) Then
            valu_worst_1.Value = 110
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(61) Then
            valu_worst_1.Value = 112
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(62) Then
            valu_worst_1.Value = 114
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(63) Then
            valu_worst_1.Value = 115
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(64) Then
            valu_worst_1.Value = 117
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(65) Then
            valu_worst_1.Value = 119
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(66) Then
            valu_worst_1.Value = 122
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(67) Then
            valu_worst_1.Value = 123
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(68) Then
            valu_worst_1.Value = 126
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(69) Then
            valu_worst_1.Value = 132
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(70) Then
            valu_worst_1.Value = 135
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(71) Then
            valu_worst_1.Value = 136
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(72) Then
            valu_worst_1.Value = 137
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(73) Then
            valu_worst_1.Value = 138
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(74) Then
            valu_worst_1.Value = 139
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(75) Then
            valu_worst_1.Value = 140
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(76) Then
            valu_worst_1.Value = 141
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(77) Then
            valu_worst_1.Value = 142
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(78) Then
            valu_worst_1.Value = 143
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(79) Then
            valu_worst_1.Value = 144
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(80) Then
            valu_worst_1.Value = 146
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(81) Then
            valu_worst_1.Value = 147
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(82) Then
            valu_worst_1.Value = 148
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(83) Then
            valu_worst_1.Value = 149
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(84) Then
            valu_worst_1.Value = 150
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(85) Then
            valu_worst_1.Value = 151
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(86) Then
            valu_worst_1.Value = 152
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(87) Then
            valu_worst_1.Value = 153
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(88) Then
            valu_worst_1.Value = 154
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(89) Then
            valu_worst_1.Value = 155
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(90) Then
            valu_worst_1.Value = 156
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(91) Then
            valu_worst_1.Value = 157
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(92) Then
            valu_worst_1.Value = 158
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(93) Then
            valu_worst_1.Value = 159
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(94) Then
            valu_worst_1.Value = 160
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(95) Then
            valu_worst_1.Value = 161
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(96) Then
            valu_worst_1.Value = 162
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(97) Then
            valu_worst_1.Value = 163
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(98) Then
            valu_worst_1.Value = 164
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(99) Then
            valu_worst_1.Value = 165
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(100) Then
            valu_worst_1.Value = 166
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(101) Then
            valu_worst_1.Value = 167
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(102) Then
            valu_worst_1.Value = 168
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(103) Then
            valu_worst_1.Value = 169
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(104) Then
            valu_worst_1.Value = 170
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(105) Then
            valu_worst_1.Value = 171
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(106) Then
            valu_worst_1.Value = 172
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(107) Then
            valu_worst_1.Value = 173
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(108) Then
            valu_worst_1.Value = 174
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(109) Then
            valu_worst_1.Value = 175
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(110) Then
            valu_worst_1.Value = 178
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(111) Then
            valu_worst_1.Value = 180
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(112) Then
            valu_worst_1.Value = 182
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(113) Then
            valu_worst_1.Value = 183
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(114) Then
            valu_worst_1.Value = 185
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(115) Then
            valu_worst_1.Value = 186
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(116) Then
            valu_worst_1.Value = 187
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(117) Then
            valu_worst_1.Value = 188
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(118) Then
            valu_worst_1.Value = 189
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(119) Then
            valu_worst_1.Value = 190
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(120) Then
            valu_worst_1.Value = 191
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(121) Then
            valu_worst_1.Value = 192
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(122) Then
            valu_worst_1.Value = 193
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(123) Then
            valu_worst_1.Value = 194
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(124) Then
            valu_worst_1.Value = 195
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(125) Then
            valu_worst_1.Value = 197
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(126) Then
            valu_worst_1.Value = 198
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(127) Then
            valu_worst_1.Value = 199
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(128) Then
            valu_worst_1.Value = 200
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(129) Then
            valu_worst_1.Value = 201
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(130) Then
            valu_worst_1.Value = 202
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(131) Then
            valu_worst_1.Value = 205
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(132) Then
            valu_worst_1.Value = 210
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(133) Then
            valu_worst_1.Value = 216
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(134) Then
            valu_worst_1.Value = 218
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(135) Then
            valu_worst_1.Value = 222
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(136) Then
            valu_worst_1.Value = 229
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(137) Then
            valu_worst_1.Value = 230
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(138) Then
            valu_worst_1.Value = 231
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(139) Then
            valu_worst_1.Value = 232
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(140) Then
            valu_worst_1.Value = 233
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(141) Then
            valu_worst_1.Value = 234
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(142) Then
            valu_worst_1.Value = 235
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(143) Then
            valu_worst_1.Value = 236
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(144) Then
            valu_worst_1.Value = 237
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(145) Then
            valu_worst_1.Value = 238
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(146) Then
            valu_worst_1.Value = 239
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(147) Then
            valu_worst_1.Value = 240
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(148) Then
            valu_worst_1.Value = 241
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(149) Then
            valu_worst_1.Value = 242
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(150) Then
            valu_worst_1.Value = 243
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(151) Then
            valu_worst_1.Value = 244
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(152) Then
            valu_worst_1.Value = 245
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(153) Then
            valu_worst_1.Value = 246
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(154) Then
            valu_worst_1.Value = 247
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(155) Then
            valu_worst_1.Value = 248
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(156) Then
            valu_worst_1.Value = 249
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(157) Then
            valu_worst_1.Value = 250
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(158) Then
            valu_worst_1.Value = 251
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(159) Then
            valu_worst_1.Value = 252
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(160) Then
            valu_worst_1.Value = 253
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(161) Then
            valu_worst_1.Value = 297
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(162) Then
            valu_worst_1.Value = 298
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(163) Then
            valu_worst_1.Value = 299
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(164) Then
            valu_worst_1.Value = 300
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(165) Then
            valu_worst_1.Value = 301
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(166) Then
            valu_worst_1.Value = 302
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(167) Then
            valu_worst_1.Value = 303
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(168) Then
            valu_worst_1.Value = 304
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(169) Then
            valu_worst_1.Value = 305
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(170) Then
            valu_worst_1.Value = 306
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(171) Then
            valu_worst_1.Value = 307
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(172) Then
            valu_worst_1.Value = 308
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(173) Then
            valu_worst_1.Value = 309
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(174) Then
            valu_worst_1.Value = 310
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(175) Then
            valu_worst_1.Value = 311
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(176) Then
            valu_worst_1.Value = 312
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(177) Then
            valu_worst_1.Value = 314
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(178) Then
            valu_worst_1.Value = 315
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(179) Then
            valu_worst_1.Value = 316
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(180) Then
            valu_worst_1.Value = 317
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(181) Then
            valu_worst_1.Value = 318
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(182) Then
            valu_worst_1.Value = 319
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(183) Then
            valu_worst_1.Value = 320
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(184) Then
            valu_worst_1.Value = 321
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(185) Then
            valu_worst_1.Value = 322
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(186) Then
            valu_worst_1.Value = 323
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(187) Then
            valu_worst_1.Value = 324
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(188) Then
            valu_worst_1.Value = 325
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(189) Then
            valu_worst_1.Value = 326
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(190) Then
            valu_worst_1.Value = 327
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(191) Then
            valu_worst_1.Value = 328
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(192) Then
            valu_worst_1.Value = 329
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(193) Then
            valu_worst_1.Value = 330
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(194) Then
            valu_worst_1.Value = 331
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(195) Then
            valu_worst_1.Value = 332
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(196) Then
            valu_worst_1.Value = 333
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(197) Then
            valu_worst_1.Value = 334
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(198) Then
            valu_worst_1.Value = 335
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(199) Then
            valu_worst_1.Value = 336
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(200) Then
            valu_worst_1.Value = 337
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(201) Then
            valu_worst_1.Value = 338
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(202) Then
            valu_worst_1.Value = 340
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(203) Then
            valu_worst_1.Value = 342
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(204) Then
            valu_worst_1.Value = 343
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(205) Then
            valu_worst_1.Value = 344
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(206) Then
            valu_worst_1.Value = 345
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(207) Then
            valu_worst_1.Value = 346
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(208) Then
            valu_worst_1.Value = 347
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(209) Then
            valu_worst_1.Value = 348
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(210) Then
            valu_worst_1.Value = 349
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(211) Then
            valu_worst_1.Value = 350
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(212) Then
            valu_worst_1.Value = 354
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(213) Then
            valu_worst_1.Value = 355
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(214) Then
            valu_worst_1.Value = 356
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(215) Then
            valu_worst_1.Value = 357
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(216) Then
            valu_worst_1.Value = 358
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(217) Then
            valu_worst_1.Value = 359
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(218) Then
            valu_worst_1.Value = 360
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(219) Then
            valu_worst_1.Value = 361
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(220) Then
            valu_worst_1.Value = 362
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(221) Then
            valu_worst_1.Value = 363
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(222) Then
            valu_worst_1.Value = 364
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(223) Then
            valu_worst_1.Value = 365
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(224) Then
            valu_worst_1.Value = 366
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(225) Then
            valu_worst_1.Value = 367
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(226) Then
            valu_worst_1.Value = 368
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(227) Then
            valu_worst_1.Value = 369
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(228) Then
            valu_worst_1.Value = 370
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(229) Then
            valu_worst_1.Value = 371
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(230) Then
            valu_worst_1.Value = 381
        ElseIf Select_worst_1.SelectedItem = Select_worst_1.Items.Item(231) Then
            valu_worst_1.Value = 0
        End If
    End Sub

    Private Sub Select_worst_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_worst_2.SelectedIndexChanged
        If Select_worst_2.SelectedItem = Select_worst_2.Items.Item(0) Then
            valu_worst_2.Value = 65535
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(1) Then
            valu_worst_2.Value = 2
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(2) Then
            valu_worst_2.Value = 5
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(3) Then
            valu_worst_2.Value = 10
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(4) Then
            valu_worst_2.Value = 16
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(5) Then
            valu_worst_2.Value = 20
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(6) Then
            valu_worst_2.Value = 23
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(7) Then
            valu_worst_2.Value = 26
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(8) Then
            valu_worst_2.Value = 27
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(9) Then
            valu_worst_2.Value = 29
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(10) Then
            valu_worst_2.Value = 31
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(11) Then
            valu_worst_2.Value = 32
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(12) Then
            valu_worst_2.Value = 34
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(13) Then
            valu_worst_2.Value = 36
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(14) Then
            valu_worst_2.Value = 38
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(15) Then
            valu_worst_2.Value = 40
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(16) Then
            valu_worst_2.Value = 42
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(17) Then
            valu_worst_2.Value = 44
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(18) Then
            valu_worst_2.Value = 45
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(19) Then
            valu_worst_2.Value = 46
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(20) Then
            valu_worst_2.Value = 47
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(21) Then
            valu_worst_2.Value = 48
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(22) Then
            valu_worst_2.Value = 49
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(23) Then
            valu_worst_2.Value = 50
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(24) Then
            valu_worst_2.Value = 51
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(25) Then
            valu_worst_2.Value = 53
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(26) Then
            valu_worst_2.Value = 54
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(27) Then
            valu_worst_2.Value = 56
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(28) Then
            valu_worst_2.Value = 58
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(29) Then
            valu_worst_2.Value = 61
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(30) Then
            valu_worst_2.Value = 62
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(31) Then
            valu_worst_2.Value = 63
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(32) Then
            valu_worst_2.Value = 66
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(33) Then
            valu_worst_2.Value = 67
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(34) Then
            valu_worst_2.Value = 69
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(35) Then
            valu_worst_2.Value = 70
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(36) Then
            valu_worst_2.Value = 73
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(37) Then
            valu_worst_2.Value = 76
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(38) Then
            valu_worst_2.Value = 77
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(39) Then
            valu_worst_2.Value = 80
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(40) Then
            valu_worst_2.Value = 86
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(41) Then
            valu_worst_2.Value = 87
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(42) Then
            valu_worst_2.Value = 89
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(43) Then
            valu_worst_2.Value = 90
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(44) Then
            valu_worst_2.Value = 91
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(45) Then
            valu_worst_2.Value = 92
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(46) Then
            valu_worst_2.Value = 96
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(47) Then
            valu_worst_2.Value = 97
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(48) Then
            valu_worst_2.Value = 98
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(49) Then
            valu_worst_2.Value = 99
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(50) Then
            valu_worst_2.Value = 100
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(51) Then
            valu_worst_2.Value = 101
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(52) Then
            valu_worst_2.Value = 102
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(53) Then
            valu_worst_2.Value = 103
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(54) Then
            valu_worst_2.Value = 104
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(55) Then
            valu_worst_2.Value = 105
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(56) Then
            valu_worst_2.Value = 106
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(57) Then
            valu_worst_2.Value = 107
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(58) Then
            valu_worst_2.Value = 108
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(59) Then
            valu_worst_2.Value = 109
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(60) Then
            valu_worst_2.Value = 110
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(61) Then
            valu_worst_2.Value = 112
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(62) Then
            valu_worst_2.Value = 114
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(63) Then
            valu_worst_2.Value = 115
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(64) Then
            valu_worst_2.Value = 117
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(65) Then
            valu_worst_2.Value = 119
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(66) Then
            valu_worst_2.Value = 122
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(67) Then
            valu_worst_2.Value = 123
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(68) Then
            valu_worst_2.Value = 126
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(69) Then
            valu_worst_2.Value = 132
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(70) Then
            valu_worst_2.Value = 135
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(71) Then
            valu_worst_2.Value = 136
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(72) Then
            valu_worst_2.Value = 137
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(73) Then
            valu_worst_2.Value = 138
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(74) Then
            valu_worst_2.Value = 139
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(75) Then
            valu_worst_2.Value = 140
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(76) Then
            valu_worst_2.Value = 141
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(77) Then
            valu_worst_2.Value = 142
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(78) Then
            valu_worst_2.Value = 143
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(79) Then
            valu_worst_2.Value = 144
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(80) Then
            valu_worst_2.Value = 146
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(81) Then
            valu_worst_2.Value = 147
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(82) Then
            valu_worst_2.Value = 148
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(83) Then
            valu_worst_2.Value = 149
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(84) Then
            valu_worst_2.Value = 150
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(85) Then
            valu_worst_2.Value = 151
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(86) Then
            valu_worst_2.Value = 152
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(87) Then
            valu_worst_2.Value = 153
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(88) Then
            valu_worst_2.Value = 154
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(89) Then
            valu_worst_2.Value = 155
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(90) Then
            valu_worst_2.Value = 156
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(91) Then
            valu_worst_2.Value = 157
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(92) Then
            valu_worst_2.Value = 158
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(93) Then
            valu_worst_2.Value = 159
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(94) Then
            valu_worst_2.Value = 160
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(95) Then
            valu_worst_2.Value = 161
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(96) Then
            valu_worst_2.Value = 162
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(97) Then
            valu_worst_2.Value = 163
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(98) Then
            valu_worst_2.Value = 164
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(99) Then
            valu_worst_2.Value = 165
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(100) Then
            valu_worst_2.Value = 166
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(101) Then
            valu_worst_2.Value = 167
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(102) Then
            valu_worst_2.Value = 168
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(103) Then
            valu_worst_2.Value = 169
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(104) Then
            valu_worst_2.Value = 170
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(105) Then
            valu_worst_2.Value = 171
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(106) Then
            valu_worst_2.Value = 172
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(107) Then
            valu_worst_2.Value = 173
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(108) Then
            valu_worst_2.Value = 174
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(109) Then
            valu_worst_2.Value = 175
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(110) Then
            valu_worst_2.Value = 178
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(111) Then
            valu_worst_2.Value = 180
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(112) Then
            valu_worst_2.Value = 182
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(113) Then
            valu_worst_2.Value = 183
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(114) Then
            valu_worst_2.Value = 185
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(115) Then
            valu_worst_2.Value = 186
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(116) Then
            valu_worst_2.Value = 187
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(117) Then
            valu_worst_2.Value = 188
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(118) Then
            valu_worst_2.Value = 189
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(119) Then
            valu_worst_2.Value = 190
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(120) Then
            valu_worst_2.Value = 191
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(121) Then
            valu_worst_2.Value = 192
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(122) Then
            valu_worst_2.Value = 193
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(123) Then
            valu_worst_2.Value = 194
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(124) Then
            valu_worst_2.Value = 195
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(125) Then
            valu_worst_2.Value = 197
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(126) Then
            valu_worst_2.Value = 198
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(127) Then
            valu_worst_2.Value = 199
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(128) Then
            valu_worst_2.Value = 200
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(129) Then
            valu_worst_2.Value = 201
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(130) Then
            valu_worst_2.Value = 202
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(131) Then
            valu_worst_2.Value = 205
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(132) Then
            valu_worst_2.Value = 210
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(133) Then
            valu_worst_2.Value = 216
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(134) Then
            valu_worst_2.Value = 218
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(135) Then
            valu_worst_2.Value = 222
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(136) Then
            valu_worst_2.Value = 229
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(137) Then
            valu_worst_2.Value = 230
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(138) Then
            valu_worst_2.Value = 231
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(139) Then
            valu_worst_2.Value = 232
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(140) Then
            valu_worst_2.Value = 233
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(141) Then
            valu_worst_2.Value = 234
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(142) Then
            valu_worst_2.Value = 235
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(143) Then
            valu_worst_2.Value = 236
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(144) Then
            valu_worst_2.Value = 237
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(145) Then
            valu_worst_2.Value = 238
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(146) Then
            valu_worst_2.Value = 239
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(147) Then
            valu_worst_2.Value = 240
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(148) Then
            valu_worst_2.Value = 241
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(149) Then
            valu_worst_2.Value = 242
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(150) Then
            valu_worst_2.Value = 243
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(151) Then
            valu_worst_2.Value = 244
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(152) Then
            valu_worst_2.Value = 245
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(153) Then
            valu_worst_2.Value = 246
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(154) Then
            valu_worst_2.Value = 247
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(155) Then
            valu_worst_2.Value = 248
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(156) Then
            valu_worst_2.Value = 249
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(157) Then
            valu_worst_2.Value = 250
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(158) Then
            valu_worst_2.Value = 251
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(159) Then
            valu_worst_2.Value = 252
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(160) Then
            valu_worst_2.Value = 253
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(161) Then
            valu_worst_2.Value = 297
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(162) Then
            valu_worst_2.Value = 298
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(163) Then
            valu_worst_2.Value = 299
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(164) Then
            valu_worst_2.Value = 300
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(165) Then
            valu_worst_2.Value = 301
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(166) Then
            valu_worst_2.Value = 302
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(167) Then
            valu_worst_2.Value = 303
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(168) Then
            valu_worst_2.Value = 304
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(169) Then
            valu_worst_2.Value = 305
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(170) Then
            valu_worst_2.Value = 306
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(171) Then
            valu_worst_2.Value = 307
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(172) Then
            valu_worst_2.Value = 308
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(173) Then
            valu_worst_2.Value = 309
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(174) Then
            valu_worst_2.Value = 310
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(175) Then
            valu_worst_2.Value = 311
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(176) Then
            valu_worst_2.Value = 312
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(177) Then
            valu_worst_2.Value = 314
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(178) Then
            valu_worst_2.Value = 315
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(179) Then
            valu_worst_2.Value = 316
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(180) Then
            valu_worst_2.Value = 317
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(181) Then
            valu_worst_2.Value = 318
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(182) Then
            valu_worst_2.Value = 319
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(183) Then
            valu_worst_2.Value = 320
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(184) Then
            valu_worst_2.Value = 321
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(185) Then
            valu_worst_2.Value = 322
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(186) Then
            valu_worst_2.Value = 323
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(187) Then
            valu_worst_2.Value = 324
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(188) Then
            valu_worst_2.Value = 325
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(189) Then
            valu_worst_2.Value = 326
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(190) Then
            valu_worst_2.Value = 327
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(191) Then
            valu_worst_2.Value = 328
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(192) Then
            valu_worst_2.Value = 329
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(193) Then
            valu_worst_2.Value = 330
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(194) Then
            valu_worst_2.Value = 331
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(195) Then
            valu_worst_2.Value = 332
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(196) Then
            valu_worst_2.Value = 333
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(197) Then
            valu_worst_2.Value = 334
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(198) Then
            valu_worst_2.Value = 335
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(199) Then
            valu_worst_2.Value = 336
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(200) Then
            valu_worst_2.Value = 337
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(201) Then
            valu_worst_2.Value = 338
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(202) Then
            valu_worst_2.Value = 340
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(203) Then
            valu_worst_2.Value = 342
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(204) Then
            valu_worst_2.Value = 343
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(205) Then
            valu_worst_2.Value = 344
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(206) Then
            valu_worst_2.Value = 345
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(207) Then
            valu_worst_2.Value = 346
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(208) Then
            valu_worst_2.Value = 347
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(209) Then
            valu_worst_2.Value = 348
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(210) Then
            valu_worst_2.Value = 349
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(211) Then
            valu_worst_2.Value = 350
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(212) Then
            valu_worst_2.Value = 354
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(213) Then
            valu_worst_2.Value = 355
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(214) Then
            valu_worst_2.Value = 356
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(215) Then
            valu_worst_2.Value = 357
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(216) Then
            valu_worst_2.Value = 358
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(217) Then
            valu_worst_2.Value = 359
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(218) Then
            valu_worst_2.Value = 360
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(219) Then
            valu_worst_2.Value = 361
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(220) Then
            valu_worst_2.Value = 362
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(221) Then
            valu_worst_2.Value = 363
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(222) Then
            valu_worst_2.Value = 364
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(223) Then
            valu_worst_2.Value = 365
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(224) Then
            valu_worst_2.Value = 366
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(225) Then
            valu_worst_2.Value = 367
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(226) Then
            valu_worst_2.Value = 368
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(227) Then
            valu_worst_2.Value = 369
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(228) Then
            valu_worst_2.Value = 370
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(229) Then
            valu_worst_2.Value = 371
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(230) Then
            valu_worst_2.Value = 381
        ElseIf Select_worst_2.SelectedItem = Select_worst_2.Items.Item(231) Then
            valu_worst_2.Value = 0
        End If
    End Sub

    Private Sub valu_allfav_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_allfav_1.ValueChanged
        If valu_allfav_1.Value = 65535 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(0)
        ElseIf valu_allfav_1.Value = 2 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(1)
        ElseIf valu_allfav_1.Value = 5 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(2)
        ElseIf valu_allfav_1.Value = 10 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(3)
        ElseIf valu_allfav_1.Value = 16 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(4)
        ElseIf valu_allfav_1.Value = 20 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(5)
        ElseIf valu_allfav_1.Value = 23 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(6)
        ElseIf valu_allfav_1.Value = 26 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(7)
        ElseIf valu_allfav_1.Value = 27 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(8)
        ElseIf valu_allfav_1.Value = 29 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(9)
        ElseIf valu_allfav_1.Value = 31 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(10)
        ElseIf valu_allfav_1.Value = 32 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(11)
        ElseIf valu_allfav_1.Value = 34 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(12)
        ElseIf valu_allfav_1.Value = 36 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(13)
        ElseIf valu_allfav_1.Value = 38 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(14)
        ElseIf valu_allfav_1.Value = 40 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(15)
        ElseIf valu_allfav_1.Value = 42 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(16)
        ElseIf valu_allfav_1.Value = 44 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(17)
        ElseIf valu_allfav_1.Value = 45 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(18)
        ElseIf valu_allfav_1.Value = 46 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(19)
        ElseIf valu_allfav_1.Value = 47 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(20)
        ElseIf valu_allfav_1.Value = 48 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(21)
        ElseIf valu_allfav_1.Value = 49 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(22)
        ElseIf valu_allfav_1.Value = 50 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(23)
        ElseIf valu_allfav_1.Value = 51 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(24)
        ElseIf valu_allfav_1.Value = 53 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(25)
        ElseIf valu_allfav_1.Value = 54 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(26)
        ElseIf valu_allfav_1.Value = 56 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(27)
        ElseIf valu_allfav_1.Value = 58 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(28)
        ElseIf valu_allfav_1.Value = 61 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(29)
        ElseIf valu_allfav_1.Value = 62 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(30)
        ElseIf valu_allfav_1.Value = 63 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(31)
        ElseIf valu_allfav_1.Value = 66 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(32)
        ElseIf valu_allfav_1.Value = 67 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(33)
        ElseIf valu_allfav_1.Value = 69 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(34)
        ElseIf valu_allfav_1.Value = 70 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(35)
        ElseIf valu_allfav_1.Value = 73 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(36)
        ElseIf valu_allfav_1.Value = 76 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(37)
        ElseIf valu_allfav_1.Value = 77 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(38)
        ElseIf valu_allfav_1.Value = 80 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(39)
        ElseIf valu_allfav_1.Value = 86 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(40)
        ElseIf valu_allfav_1.Value = 87 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(41)
        ElseIf valu_allfav_1.Value = 89 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(42)
        ElseIf valu_allfav_1.Value = 90 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(43)
        ElseIf valu_allfav_1.Value = 91 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(44)
        ElseIf valu_allfav_1.Value = 92 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(45)
        ElseIf valu_allfav_1.Value = 96 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(46)
        ElseIf valu_allfav_1.Value = 97 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(47)
        ElseIf valu_allfav_1.Value = 98 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(48)
        ElseIf valu_allfav_1.Value = 99 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(49)
        ElseIf valu_allfav_1.Value = 100 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(50)
        ElseIf valu_allfav_1.Value = 101 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(51)
        ElseIf valu_allfav_1.Value = 102 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(52)
        ElseIf valu_allfav_1.Value = 103 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(53)
        ElseIf valu_allfav_1.Value = 104 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(54)
        ElseIf valu_allfav_1.Value = 105 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(55)
        ElseIf valu_allfav_1.Value = 106 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(56)
        ElseIf valu_allfav_1.Value = 107 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(57)
        ElseIf valu_allfav_1.Value = 108 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(58)
        ElseIf valu_allfav_1.Value = 109 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(59)
        ElseIf valu_allfav_1.Value = 110 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(60)
        ElseIf valu_allfav_1.Value = 112 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(61)
        ElseIf valu_allfav_1.Value = 114 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(62)
        ElseIf valu_allfav_1.Value = 115 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(63)
        ElseIf valu_allfav_1.Value = 117 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(64)
        ElseIf valu_allfav_1.Value = 119 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(65)
        ElseIf valu_allfav_1.Value = 122 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(66)
        ElseIf valu_allfav_1.Value = 123 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(67)
        ElseIf valu_allfav_1.Value = 126 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(68)
        ElseIf valu_allfav_1.Value = 132 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(69)
        ElseIf valu_allfav_1.Value = 135 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(70)
        ElseIf valu_allfav_1.Value = 136 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(71)
        ElseIf valu_allfav_1.Value = 137 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(72)
        ElseIf valu_allfav_1.Value = 138 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(73)
        ElseIf valu_allfav_1.Value = 139 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(74)
        ElseIf valu_allfav_1.Value = 140 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(75)
        ElseIf valu_allfav_1.Value = 141 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(76)
        ElseIf valu_allfav_1.Value = 142 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(77)
        ElseIf valu_allfav_1.Value = 143 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(78)
        ElseIf valu_allfav_1.Value = 144 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(79)
        ElseIf valu_allfav_1.Value = 146 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(80)
        ElseIf valu_allfav_1.Value = 147 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(81)
        ElseIf valu_allfav_1.Value = 148 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(82)
        ElseIf valu_allfav_1.Value = 149 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(83)
        ElseIf valu_allfav_1.Value = 150 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(84)
        ElseIf valu_allfav_1.Value = 151 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(85)
        ElseIf valu_allfav_1.Value = 152 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(86)
        ElseIf valu_allfav_1.Value = 153 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(87)
        ElseIf valu_allfav_1.Value = 154 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(88)
        ElseIf valu_allfav_1.Value = 155 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(89)
        ElseIf valu_allfav_1.Value = 156 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(90)
        ElseIf valu_allfav_1.Value = 157 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(91)
        ElseIf valu_allfav_1.Value = 158 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(92)
        ElseIf valu_allfav_1.Value = 159 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(93)
        ElseIf valu_allfav_1.Value = 160 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(94)
        ElseIf valu_allfav_1.Value = 161 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(95)
        ElseIf valu_allfav_1.Value = 162 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(96)
        ElseIf valu_allfav_1.Value = 163 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(97)
        ElseIf valu_allfav_1.Value = 164 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(98)
        ElseIf valu_allfav_1.Value = 165 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(99)
        ElseIf valu_allfav_1.Value = 166 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(100)
        ElseIf valu_allfav_1.Value = 167 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(101)
        ElseIf valu_allfav_1.Value = 168 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(102)
        ElseIf valu_allfav_1.Value = 169 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(103)
        ElseIf valu_allfav_1.Value = 170 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(104)
        ElseIf valu_allfav_1.Value = 171 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(105)
        ElseIf valu_allfav_1.Value = 172 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(106)
        ElseIf valu_allfav_1.Value = 173 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(107)
        ElseIf valu_allfav_1.Value = 174 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(108)
        ElseIf valu_allfav_1.Value = 175 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(109)
        ElseIf valu_allfav_1.Value = 178 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(110)
        ElseIf valu_allfav_1.Value = 180 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(111)
        ElseIf valu_allfav_1.Value = 182 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(112)
        ElseIf valu_allfav_1.Value = 183 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(113)
        ElseIf valu_allfav_1.Value = 185 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(114)
        ElseIf valu_allfav_1.Value = 186 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(115)
        ElseIf valu_allfav_1.Value = 187 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(116)
        ElseIf valu_allfav_1.Value = 188 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(117)
        ElseIf valu_allfav_1.Value = 189 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(118)
        ElseIf valu_allfav_1.Value = 190 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(119)
        ElseIf valu_allfav_1.Value = 191 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(120)
        ElseIf valu_allfav_1.Value = 192 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(121)
        ElseIf valu_allfav_1.Value = 193 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(122)
        ElseIf valu_allfav_1.Value = 194 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(123)
        ElseIf valu_allfav_1.Value = 195 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(124)
        ElseIf valu_allfav_1.Value = 197 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(125)
        ElseIf valu_allfav_1.Value = 198 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(126)
        ElseIf valu_allfav_1.Value = 199 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(127)
        ElseIf valu_allfav_1.Value = 200 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(128)
        ElseIf valu_allfav_1.Value = 201 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(129)
        ElseIf valu_allfav_1.Value = 202 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(130)
        ElseIf valu_allfav_1.Value = 205 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(131)
        ElseIf valu_allfav_1.Value = 210 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(132)
        ElseIf valu_allfav_1.Value = 216 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(133)
        ElseIf valu_allfav_1.Value = 218 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(134)
        ElseIf valu_allfav_1.Value = 222 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(135)
        ElseIf valu_allfav_1.Value = 229 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(136)
        ElseIf valu_allfav_1.Value = 230 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(137)
        ElseIf valu_allfav_1.Value = 231 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(138)
        ElseIf valu_allfav_1.Value = 232 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(139)
        ElseIf valu_allfav_1.Value = 233 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(140)
        ElseIf valu_allfav_1.Value = 234 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(141)
        ElseIf valu_allfav_1.Value = 235 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(142)
        ElseIf valu_allfav_1.Value = 236 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(143)
        ElseIf valu_allfav_1.Value = 237 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(144)
        ElseIf valu_allfav_1.Value = 238 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(145)
        ElseIf valu_allfav_1.Value = 239 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(146)
        ElseIf valu_allfav_1.Value = 240 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(147)
        ElseIf valu_allfav_1.Value = 241 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(148)
        ElseIf valu_allfav_1.Value = 242 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(149)
        ElseIf valu_allfav_1.Value = 243 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(150)
        ElseIf valu_allfav_1.Value = 244 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(151)
        ElseIf valu_allfav_1.Value = 245 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(152)
        ElseIf valu_allfav_1.Value = 246 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(153)
        ElseIf valu_allfav_1.Value = 247 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(154)
        ElseIf valu_allfav_1.Value = 248 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(155)
        ElseIf valu_allfav_1.Value = 249 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(156)
        ElseIf valu_allfav_1.Value = 250 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(157)
        ElseIf valu_allfav_1.Value = 251 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(158)
        ElseIf valu_allfav_1.Value = 252 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(159)
        ElseIf valu_allfav_1.Value = 253 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(160)
        ElseIf valu_allfav_1.Value = 297 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(161)
        ElseIf valu_allfav_1.Value = 298 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(162)
        ElseIf valu_allfav_1.Value = 299 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(163)
        ElseIf valu_allfav_1.Value = 300 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(164)
        ElseIf valu_allfav_1.Value = 301 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(165)
        ElseIf valu_allfav_1.Value = 302 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(166)
        ElseIf valu_allfav_1.Value = 303 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(167)
        ElseIf valu_allfav_1.Value = 304 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(168)
        ElseIf valu_allfav_1.Value = 305 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(169)
        ElseIf valu_allfav_1.Value = 306 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(170)
        ElseIf valu_allfav_1.Value = 307 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(171)
        ElseIf valu_allfav_1.Value = 308 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(172)
        ElseIf valu_allfav_1.Value = 309 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(173)
        ElseIf valu_allfav_1.Value = 310 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(174)
        ElseIf valu_allfav_1.Value = 311 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(175)
        ElseIf valu_allfav_1.Value = 312 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(176)
        ElseIf valu_allfav_1.Value = 314 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(177)
        ElseIf valu_allfav_1.Value = 315 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(178)
        ElseIf valu_allfav_1.Value = 316 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(179)
        ElseIf valu_allfav_1.Value = 317 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(180)
        ElseIf valu_allfav_1.Value = 318 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(181)
        ElseIf valu_allfav_1.Value = 319 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(182)
        ElseIf valu_allfav_1.Value = 320 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(183)
        ElseIf valu_allfav_1.Value = 321 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(184)
        ElseIf valu_allfav_1.Value = 322 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(185)
        ElseIf valu_allfav_1.Value = 323 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(186)
        ElseIf valu_allfav_1.Value = 324 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(187)
        ElseIf valu_allfav_1.Value = 325 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(188)
        ElseIf valu_allfav_1.Value = 326 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(189)
        ElseIf valu_allfav_1.Value = 327 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(190)
        ElseIf valu_allfav_1.Value = 328 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(191)
        ElseIf valu_allfav_1.Value = 329 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(192)
        ElseIf valu_allfav_1.Value = 330 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(193)
        ElseIf valu_allfav_1.Value = 331 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(194)
        ElseIf valu_allfav_1.Value = 332 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(195)
        ElseIf valu_allfav_1.Value = 333 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(196)
        ElseIf valu_allfav_1.Value = 334 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(197)
        ElseIf valu_allfav_1.Value = 335 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(198)
        ElseIf valu_allfav_1.Value = 336 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(199)
        ElseIf valu_allfav_1.Value = 337 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(200)
        ElseIf valu_allfav_1.Value = 338 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(201)
        ElseIf valu_allfav_1.Value = 340 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(202)
        ElseIf valu_allfav_1.Value = 342 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(203)
        ElseIf valu_allfav_1.Value = 343 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(204)
        ElseIf valu_allfav_1.Value = 344 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(205)
        ElseIf valu_allfav_1.Value = 345 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(206)
        ElseIf valu_allfav_1.Value = 346 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(207)
        ElseIf valu_allfav_1.Value = 347 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(208)
        ElseIf valu_allfav_1.Value = 348 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(209)
        ElseIf valu_allfav_1.Value = 349 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(210)
        ElseIf valu_allfav_1.Value = 350 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(211)
        ElseIf valu_allfav_1.Value = 354 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(212)
        ElseIf valu_allfav_1.Value = 355 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(213)
        ElseIf valu_allfav_1.Value = 356 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(214)
        ElseIf valu_allfav_1.Value = 357 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(215)
        ElseIf valu_allfav_1.Value = 358 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(216)
        ElseIf valu_allfav_1.Value = 359 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(217)
        ElseIf valu_allfav_1.Value = 360 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(218)
        ElseIf valu_allfav_1.Value = 361 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(219)
        ElseIf valu_allfav_1.Value = 362 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(220)
        ElseIf valu_allfav_1.Value = 363 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(221)
        ElseIf valu_allfav_1.Value = 364 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(222)
        ElseIf valu_allfav_1.Value = 365 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(223)
        ElseIf valu_allfav_1.Value = 366 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(224)
        ElseIf valu_allfav_1.Value = 367 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(225)
        ElseIf valu_allfav_1.Value = 368 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(226)
        ElseIf valu_allfav_1.Value = 369 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(227)
        ElseIf valu_allfav_1.Value = 370 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(228)
        ElseIf valu_allfav_1.Value = 371 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(229)
        ElseIf valu_allfav_1.Value = 381 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(230)
        ElseIf valu_allfav_1.Value = 0 Then
            Select_allfav_1.SelectedItem = Select_allfav_1.Items.Item(231)
        End If
    End Sub

    Private Sub valu_allfav_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_allfav_2.ValueChanged
        If valu_allfav_2.Value = 65535 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(0)
        ElseIf valu_allfav_2.Value = 2 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(1)
        ElseIf valu_allfav_2.Value = 5 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(2)
        ElseIf valu_allfav_2.Value = 10 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(3)
        ElseIf valu_allfav_2.Value = 16 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(4)
        ElseIf valu_allfav_2.Value = 20 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(5)
        ElseIf valu_allfav_2.Value = 23 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(6)
        ElseIf valu_allfav_2.Value = 26 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(7)
        ElseIf valu_allfav_2.Value = 27 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(8)
        ElseIf valu_allfav_2.Value = 29 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(9)
        ElseIf valu_allfav_2.Value = 31 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(10)
        ElseIf valu_allfav_2.Value = 32 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(11)
        ElseIf valu_allfav_2.Value = 34 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(12)
        ElseIf valu_allfav_2.Value = 36 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(13)
        ElseIf valu_allfav_2.Value = 38 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(14)
        ElseIf valu_allfav_2.Value = 40 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(15)
        ElseIf valu_allfav_2.Value = 42 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(16)
        ElseIf valu_allfav_2.Value = 44 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(17)
        ElseIf valu_allfav_2.Value = 45 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(18)
        ElseIf valu_allfav_2.Value = 46 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(19)
        ElseIf valu_allfav_2.Value = 47 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(20)
        ElseIf valu_allfav_2.Value = 48 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(21)
        ElseIf valu_allfav_2.Value = 49 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(22)
        ElseIf valu_allfav_2.Value = 50 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(23)
        ElseIf valu_allfav_2.Value = 51 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(24)
        ElseIf valu_allfav_2.Value = 53 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(25)
        ElseIf valu_allfav_2.Value = 54 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(26)
        ElseIf valu_allfav_2.Value = 56 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(27)
        ElseIf valu_allfav_2.Value = 58 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(28)
        ElseIf valu_allfav_2.Value = 61 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(29)
        ElseIf valu_allfav_2.Value = 62 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(30)
        ElseIf valu_allfav_2.Value = 63 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(31)
        ElseIf valu_allfav_2.Value = 66 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(32)
        ElseIf valu_allfav_2.Value = 67 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(33)
        ElseIf valu_allfav_2.Value = 69 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(34)
        ElseIf valu_allfav_2.Value = 70 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(35)
        ElseIf valu_allfav_2.Value = 73 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(36)
        ElseIf valu_allfav_2.Value = 76 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(37)
        ElseIf valu_allfav_2.Value = 77 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(38)
        ElseIf valu_allfav_2.Value = 80 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(39)
        ElseIf valu_allfav_2.Value = 86 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(40)
        ElseIf valu_allfav_2.Value = 87 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(41)
        ElseIf valu_allfav_2.Value = 89 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(42)
        ElseIf valu_allfav_2.Value = 90 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(43)
        ElseIf valu_allfav_2.Value = 91 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(44)
        ElseIf valu_allfav_2.Value = 92 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(45)
        ElseIf valu_allfav_2.Value = 96 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(46)
        ElseIf valu_allfav_2.Value = 97 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(47)
        ElseIf valu_allfav_2.Value = 98 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(48)
        ElseIf valu_allfav_2.Value = 99 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(49)
        ElseIf valu_allfav_2.Value = 100 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(50)
        ElseIf valu_allfav_2.Value = 101 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(51)
        ElseIf valu_allfav_2.Value = 102 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(52)
        ElseIf valu_allfav_2.Value = 103 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(53)
        ElseIf valu_allfav_2.Value = 104 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(54)
        ElseIf valu_allfav_2.Value = 105 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(55)
        ElseIf valu_allfav_2.Value = 106 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(56)
        ElseIf valu_allfav_2.Value = 107 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(57)
        ElseIf valu_allfav_2.Value = 108 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(58)
        ElseIf valu_allfav_2.Value = 109 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(59)
        ElseIf valu_allfav_2.Value = 110 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(60)
        ElseIf valu_allfav_2.Value = 112 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(61)
        ElseIf valu_allfav_2.Value = 114 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(62)
        ElseIf valu_allfav_2.Value = 115 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(63)
        ElseIf valu_allfav_2.Value = 117 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(64)
        ElseIf valu_allfav_2.Value = 119 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(65)
        ElseIf valu_allfav_2.Value = 122 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(66)
        ElseIf valu_allfav_2.Value = 123 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(67)
        ElseIf valu_allfav_2.Value = 126 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(68)
        ElseIf valu_allfav_2.Value = 132 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(69)
        ElseIf valu_allfav_2.Value = 135 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(70)
        ElseIf valu_allfav_2.Value = 136 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(71)
        ElseIf valu_allfav_2.Value = 137 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(72)
        ElseIf valu_allfav_2.Value = 138 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(73)
        ElseIf valu_allfav_2.Value = 139 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(74)
        ElseIf valu_allfav_2.Value = 140 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(75)
        ElseIf valu_allfav_2.Value = 141 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(76)
        ElseIf valu_allfav_2.Value = 142 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(77)
        ElseIf valu_allfav_2.Value = 143 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(78)
        ElseIf valu_allfav_2.Value = 144 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(79)
        ElseIf valu_allfav_2.Value = 146 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(80)
        ElseIf valu_allfav_2.Value = 147 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(81)
        ElseIf valu_allfav_2.Value = 148 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(82)
        ElseIf valu_allfav_2.Value = 149 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(83)
        ElseIf valu_allfav_2.Value = 150 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(84)
        ElseIf valu_allfav_2.Value = 151 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(85)
        ElseIf valu_allfav_2.Value = 152 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(86)
        ElseIf valu_allfav_2.Value = 153 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(87)
        ElseIf valu_allfav_2.Value = 154 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(88)
        ElseIf valu_allfav_2.Value = 155 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(89)
        ElseIf valu_allfav_2.Value = 156 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(90)
        ElseIf valu_allfav_2.Value = 157 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(91)
        ElseIf valu_allfav_2.Value = 158 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(92)
        ElseIf valu_allfav_2.Value = 159 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(93)
        ElseIf valu_allfav_2.Value = 160 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(94)
        ElseIf valu_allfav_2.Value = 161 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(95)
        ElseIf valu_allfav_2.Value = 162 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(96)
        ElseIf valu_allfav_2.Value = 163 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(97)
        ElseIf valu_allfav_2.Value = 164 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(98)
        ElseIf valu_allfav_2.Value = 165 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(99)
        ElseIf valu_allfav_2.Value = 166 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(100)
        ElseIf valu_allfav_2.Value = 167 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(101)
        ElseIf valu_allfav_2.Value = 168 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(102)
        ElseIf valu_allfav_2.Value = 169 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(103)
        ElseIf valu_allfav_2.Value = 170 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(104)
        ElseIf valu_allfav_2.Value = 171 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(105)
        ElseIf valu_allfav_2.Value = 172 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(106)
        ElseIf valu_allfav_2.Value = 173 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(107)
        ElseIf valu_allfav_2.Value = 174 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(108)
        ElseIf valu_allfav_2.Value = 175 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(109)
        ElseIf valu_allfav_2.Value = 178 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(110)
        ElseIf valu_allfav_2.Value = 180 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(111)
        ElseIf valu_allfav_2.Value = 182 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(112)
        ElseIf valu_allfav_2.Value = 183 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(113)
        ElseIf valu_allfav_2.Value = 185 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(114)
        ElseIf valu_allfav_2.Value = 186 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(115)
        ElseIf valu_allfav_2.Value = 187 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(116)
        ElseIf valu_allfav_2.Value = 188 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(117)
        ElseIf valu_allfav_2.Value = 189 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(118)
        ElseIf valu_allfav_2.Value = 190 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(119)
        ElseIf valu_allfav_2.Value = 191 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(120)
        ElseIf valu_allfav_2.Value = 192 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(121)
        ElseIf valu_allfav_2.Value = 193 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(122)
        ElseIf valu_allfav_2.Value = 194 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(123)
        ElseIf valu_allfav_2.Value = 195 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(124)
        ElseIf valu_allfav_2.Value = 197 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(125)
        ElseIf valu_allfav_2.Value = 198 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(126)
        ElseIf valu_allfav_2.Value = 199 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(127)
        ElseIf valu_allfav_2.Value = 200 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(128)
        ElseIf valu_allfav_2.Value = 201 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(129)
        ElseIf valu_allfav_2.Value = 202 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(130)
        ElseIf valu_allfav_2.Value = 205 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(131)
        ElseIf valu_allfav_2.Value = 210 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(132)
        ElseIf valu_allfav_2.Value = 216 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(133)
        ElseIf valu_allfav_2.Value = 218 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(134)
        ElseIf valu_allfav_2.Value = 222 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(135)
        ElseIf valu_allfav_2.Value = 229 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(136)
        ElseIf valu_allfav_2.Value = 230 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(137)
        ElseIf valu_allfav_2.Value = 231 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(138)
        ElseIf valu_allfav_2.Value = 232 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(139)
        ElseIf valu_allfav_2.Value = 233 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(140)
        ElseIf valu_allfav_2.Value = 234 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(141)
        ElseIf valu_allfav_2.Value = 235 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(142)
        ElseIf valu_allfav_2.Value = 236 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(143)
        ElseIf valu_allfav_2.Value = 237 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(144)
        ElseIf valu_allfav_2.Value = 238 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(145)
        ElseIf valu_allfav_2.Value = 239 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(146)
        ElseIf valu_allfav_2.Value = 240 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(147)
        ElseIf valu_allfav_2.Value = 241 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(148)
        ElseIf valu_allfav_2.Value = 242 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(149)
        ElseIf valu_allfav_2.Value = 243 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(150)
        ElseIf valu_allfav_2.Value = 244 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(151)
        ElseIf valu_allfav_2.Value = 245 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(152)
        ElseIf valu_allfav_2.Value = 246 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(153)
        ElseIf valu_allfav_2.Value = 247 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(154)
        ElseIf valu_allfav_2.Value = 248 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(155)
        ElseIf valu_allfav_2.Value = 249 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(156)
        ElseIf valu_allfav_2.Value = 250 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(157)
        ElseIf valu_allfav_2.Value = 251 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(158)
        ElseIf valu_allfav_2.Value = 252 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(159)
        ElseIf valu_allfav_2.Value = 253 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(160)
        ElseIf valu_allfav_2.Value = 297 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(161)
        ElseIf valu_allfav_2.Value = 298 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(162)
        ElseIf valu_allfav_2.Value = 299 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(163)
        ElseIf valu_allfav_2.Value = 300 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(164)
        ElseIf valu_allfav_2.Value = 301 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(165)
        ElseIf valu_allfav_2.Value = 302 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(166)
        ElseIf valu_allfav_2.Value = 303 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(167)
        ElseIf valu_allfav_2.Value = 304 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(168)
        ElseIf valu_allfav_2.Value = 305 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(169)
        ElseIf valu_allfav_2.Value = 306 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(170)
        ElseIf valu_allfav_2.Value = 307 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(171)
        ElseIf valu_allfav_2.Value = 308 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(172)
        ElseIf valu_allfav_2.Value = 309 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(173)
        ElseIf valu_allfav_2.Value = 310 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(174)
        ElseIf valu_allfav_2.Value = 311 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(175)
        ElseIf valu_allfav_2.Value = 312 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(176)
        ElseIf valu_allfav_2.Value = 314 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(177)
        ElseIf valu_allfav_2.Value = 315 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(178)
        ElseIf valu_allfav_2.Value = 316 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(179)
        ElseIf valu_allfav_2.Value = 317 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(180)
        ElseIf valu_allfav_2.Value = 318 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(181)
        ElseIf valu_allfav_2.Value = 319 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(182)
        ElseIf valu_allfav_2.Value = 320 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(183)
        ElseIf valu_allfav_2.Value = 321 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(184)
        ElseIf valu_allfav_2.Value = 322 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(185)
        ElseIf valu_allfav_2.Value = 323 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(186)
        ElseIf valu_allfav_2.Value = 324 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(187)
        ElseIf valu_allfav_2.Value = 325 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(188)
        ElseIf valu_allfav_2.Value = 326 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(189)
        ElseIf valu_allfav_2.Value = 327 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(190)
        ElseIf valu_allfav_2.Value = 328 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(191)
        ElseIf valu_allfav_2.Value = 329 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(192)
        ElseIf valu_allfav_2.Value = 330 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(193)
        ElseIf valu_allfav_2.Value = 331 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(194)
        ElseIf valu_allfav_2.Value = 332 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(195)
        ElseIf valu_allfav_2.Value = 333 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(196)
        ElseIf valu_allfav_2.Value = 334 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(197)
        ElseIf valu_allfav_2.Value = 335 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(198)
        ElseIf valu_allfav_2.Value = 336 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(199)
        ElseIf valu_allfav_2.Value = 337 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(200)
        ElseIf valu_allfav_2.Value = 338 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(201)
        ElseIf valu_allfav_2.Value = 340 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(202)
        ElseIf valu_allfav_2.Value = 342 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(203)
        ElseIf valu_allfav_2.Value = 343 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(204)
        ElseIf valu_allfav_2.Value = 344 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(205)
        ElseIf valu_allfav_2.Value = 345 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(206)
        ElseIf valu_allfav_2.Value = 346 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(207)
        ElseIf valu_allfav_2.Value = 347 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(208)
        ElseIf valu_allfav_2.Value = 348 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(209)
        ElseIf valu_allfav_2.Value = 349 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(210)
        ElseIf valu_allfav_2.Value = 350 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(211)
        ElseIf valu_allfav_2.Value = 354 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(212)
        ElseIf valu_allfav_2.Value = 355 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(213)
        ElseIf valu_allfav_2.Value = 356 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(214)
        ElseIf valu_allfav_2.Value = 357 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(215)
        ElseIf valu_allfav_2.Value = 358 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(216)
        ElseIf valu_allfav_2.Value = 359 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(217)
        ElseIf valu_allfav_2.Value = 360 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(218)
        ElseIf valu_allfav_2.Value = 361 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(219)
        ElseIf valu_allfav_2.Value = 362 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(220)
        ElseIf valu_allfav_2.Value = 363 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(221)
        ElseIf valu_allfav_2.Value = 364 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(222)
        ElseIf valu_allfav_2.Value = 365 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(223)
        ElseIf valu_allfav_2.Value = 366 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(224)
        ElseIf valu_allfav_2.Value = 367 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(225)
        ElseIf valu_allfav_2.Value = 368 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(226)
        ElseIf valu_allfav_2.Value = 369 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(227)
        ElseIf valu_allfav_2.Value = 370 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(228)
        ElseIf valu_allfav_2.Value = 371 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(229)
        ElseIf valu_allfav_2.Value = 381 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(230)
        ElseIf valu_allfav_2.Value = 0 Then
            Select_allfav_2.SelectedItem = Select_allfav_2.Items.Item(231)
        End If
    End Sub

    Private Sub valu_fav_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_fav_1.ValueChanged
        If valu_fav_1.Value = 65535 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(0)
        ElseIf valu_fav_1.Value = 2 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(1)
        ElseIf valu_fav_1.Value = 5 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(2)
        ElseIf valu_fav_1.Value = 10 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(3)
        ElseIf valu_fav_1.Value = 16 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(4)
        ElseIf valu_fav_1.Value = 20 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(5)
        ElseIf valu_fav_1.Value = 23 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(6)
        ElseIf valu_fav_1.Value = 26 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(7)
        ElseIf valu_fav_1.Value = 27 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(8)
        ElseIf valu_fav_1.Value = 29 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(9)
        ElseIf valu_fav_1.Value = 31 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(10)
        ElseIf valu_fav_1.Value = 32 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(11)
        ElseIf valu_fav_1.Value = 34 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(12)
        ElseIf valu_fav_1.Value = 36 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(13)
        ElseIf valu_fav_1.Value = 38 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(14)
        ElseIf valu_fav_1.Value = 40 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(15)
        ElseIf valu_fav_1.Value = 42 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(16)
        ElseIf valu_fav_1.Value = 44 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(17)
        ElseIf valu_fav_1.Value = 45 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(18)
        ElseIf valu_fav_1.Value = 46 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(19)
        ElseIf valu_fav_1.Value = 47 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(20)
        ElseIf valu_fav_1.Value = 48 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(21)
        ElseIf valu_fav_1.Value = 49 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(22)
        ElseIf valu_fav_1.Value = 50 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(23)
        ElseIf valu_fav_1.Value = 51 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(24)
        ElseIf valu_fav_1.Value = 53 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(25)
        ElseIf valu_fav_1.Value = 54 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(26)
        ElseIf valu_fav_1.Value = 56 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(27)
        ElseIf valu_fav_1.Value = 58 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(28)
        ElseIf valu_fav_1.Value = 61 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(29)
        ElseIf valu_fav_1.Value = 62 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(30)
        ElseIf valu_fav_1.Value = 63 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(31)
        ElseIf valu_fav_1.Value = 66 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(32)
        ElseIf valu_fav_1.Value = 67 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(33)
        ElseIf valu_fav_1.Value = 69 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(34)
        ElseIf valu_fav_1.Value = 70 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(35)
        ElseIf valu_fav_1.Value = 73 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(36)
        ElseIf valu_fav_1.Value = 76 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(37)
        ElseIf valu_fav_1.Value = 77 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(38)
        ElseIf valu_fav_1.Value = 80 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(39)
        ElseIf valu_fav_1.Value = 86 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(40)
        ElseIf valu_fav_1.Value = 87 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(41)
        ElseIf valu_fav_1.Value = 89 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(42)
        ElseIf valu_fav_1.Value = 90 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(43)
        ElseIf valu_fav_1.Value = 91 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(44)
        ElseIf valu_fav_1.Value = 92 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(45)
        ElseIf valu_fav_1.Value = 96 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(46)
        ElseIf valu_fav_1.Value = 97 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(47)
        ElseIf valu_fav_1.Value = 98 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(48)
        ElseIf valu_fav_1.Value = 99 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(49)
        ElseIf valu_fav_1.Value = 100 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(50)
        ElseIf valu_fav_1.Value = 101 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(51)
        ElseIf valu_fav_1.Value = 102 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(52)
        ElseIf valu_fav_1.Value = 103 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(53)
        ElseIf valu_fav_1.Value = 104 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(54)
        ElseIf valu_fav_1.Value = 105 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(55)
        ElseIf valu_fav_1.Value = 106 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(56)
        ElseIf valu_fav_1.Value = 107 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(57)
        ElseIf valu_fav_1.Value = 108 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(58)
        ElseIf valu_fav_1.Value = 109 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(59)
        ElseIf valu_fav_1.Value = 110 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(60)
        ElseIf valu_fav_1.Value = 112 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(61)
        ElseIf valu_fav_1.Value = 114 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(62)
        ElseIf valu_fav_1.Value = 115 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(63)
        ElseIf valu_fav_1.Value = 117 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(64)
        ElseIf valu_fav_1.Value = 119 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(65)
        ElseIf valu_fav_1.Value = 122 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(66)
        ElseIf valu_fav_1.Value = 123 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(67)
        ElseIf valu_fav_1.Value = 126 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(68)
        ElseIf valu_fav_1.Value = 132 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(69)
        ElseIf valu_fav_1.Value = 135 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(70)
        ElseIf valu_fav_1.Value = 136 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(71)
        ElseIf valu_fav_1.Value = 137 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(72)
        ElseIf valu_fav_1.Value = 138 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(73)
        ElseIf valu_fav_1.Value = 139 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(74)
        ElseIf valu_fav_1.Value = 140 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(75)
        ElseIf valu_fav_1.Value = 141 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(76)
        ElseIf valu_fav_1.Value = 142 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(77)
        ElseIf valu_fav_1.Value = 143 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(78)
        ElseIf valu_fav_1.Value = 144 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(79)
        ElseIf valu_fav_1.Value = 146 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(80)
        ElseIf valu_fav_1.Value = 147 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(81)
        ElseIf valu_fav_1.Value = 148 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(82)
        ElseIf valu_fav_1.Value = 149 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(83)
        ElseIf valu_fav_1.Value = 150 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(84)
        ElseIf valu_fav_1.Value = 151 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(85)
        ElseIf valu_fav_1.Value = 152 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(86)
        ElseIf valu_fav_1.Value = 153 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(87)
        ElseIf valu_fav_1.Value = 154 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(88)
        ElseIf valu_fav_1.Value = 155 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(89)
        ElseIf valu_fav_1.Value = 156 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(90)
        ElseIf valu_fav_1.Value = 157 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(91)
        ElseIf valu_fav_1.Value = 158 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(92)
        ElseIf valu_fav_1.Value = 159 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(93)
        ElseIf valu_fav_1.Value = 160 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(94)
        ElseIf valu_fav_1.Value = 161 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(95)
        ElseIf valu_fav_1.Value = 162 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(96)
        ElseIf valu_fav_1.Value = 163 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(97)
        ElseIf valu_fav_1.Value = 164 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(98)
        ElseIf valu_fav_1.Value = 165 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(99)
        ElseIf valu_fav_1.Value = 166 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(100)
        ElseIf valu_fav_1.Value = 167 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(101)
        ElseIf valu_fav_1.Value = 168 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(102)
        ElseIf valu_fav_1.Value = 169 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(103)
        ElseIf valu_fav_1.Value = 170 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(104)
        ElseIf valu_fav_1.Value = 171 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(105)
        ElseIf valu_fav_1.Value = 172 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(106)
        ElseIf valu_fav_1.Value = 173 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(107)
        ElseIf valu_fav_1.Value = 174 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(108)
        ElseIf valu_fav_1.Value = 175 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(109)
        ElseIf valu_fav_1.Value = 178 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(110)
        ElseIf valu_fav_1.Value = 180 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(111)
        ElseIf valu_fav_1.Value = 182 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(112)
        ElseIf valu_fav_1.Value = 183 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(113)
        ElseIf valu_fav_1.Value = 185 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(114)
        ElseIf valu_fav_1.Value = 186 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(115)
        ElseIf valu_fav_1.Value = 187 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(116)
        ElseIf valu_fav_1.Value = 188 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(117)
        ElseIf valu_fav_1.Value = 189 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(118)
        ElseIf valu_fav_1.Value = 190 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(119)
        ElseIf valu_fav_1.Value = 191 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(120)
        ElseIf valu_fav_1.Value = 192 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(121)
        ElseIf valu_fav_1.Value = 193 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(122)
        ElseIf valu_fav_1.Value = 194 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(123)
        ElseIf valu_fav_1.Value = 195 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(124)
        ElseIf valu_fav_1.Value = 197 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(125)
        ElseIf valu_fav_1.Value = 198 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(126)
        ElseIf valu_fav_1.Value = 199 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(127)
        ElseIf valu_fav_1.Value = 200 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(128)
        ElseIf valu_fav_1.Value = 201 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(129)
        ElseIf valu_fav_1.Value = 202 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(130)
        ElseIf valu_fav_1.Value = 205 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(131)
        ElseIf valu_fav_1.Value = 210 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(132)
        ElseIf valu_fav_1.Value = 216 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(133)
        ElseIf valu_fav_1.Value = 218 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(134)
        ElseIf valu_fav_1.Value = 222 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(135)
        ElseIf valu_fav_1.Value = 229 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(136)
        ElseIf valu_fav_1.Value = 230 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(137)
        ElseIf valu_fav_1.Value = 231 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(138)
        ElseIf valu_fav_1.Value = 232 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(139)
        ElseIf valu_fav_1.Value = 233 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(140)
        ElseIf valu_fav_1.Value = 234 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(141)
        ElseIf valu_fav_1.Value = 235 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(142)
        ElseIf valu_fav_1.Value = 236 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(143)
        ElseIf valu_fav_1.Value = 237 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(144)
        ElseIf valu_fav_1.Value = 238 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(145)
        ElseIf valu_fav_1.Value = 239 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(146)
        ElseIf valu_fav_1.Value = 240 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(147)
        ElseIf valu_fav_1.Value = 241 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(148)
        ElseIf valu_fav_1.Value = 242 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(149)
        ElseIf valu_fav_1.Value = 243 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(150)
        ElseIf valu_fav_1.Value = 244 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(151)
        ElseIf valu_fav_1.Value = 245 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(152)
        ElseIf valu_fav_1.Value = 246 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(153)
        ElseIf valu_fav_1.Value = 247 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(154)
        ElseIf valu_fav_1.Value = 248 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(155)
        ElseIf valu_fav_1.Value = 249 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(156)
        ElseIf valu_fav_1.Value = 250 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(157)
        ElseIf valu_fav_1.Value = 251 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(158)
        ElseIf valu_fav_1.Value = 252 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(159)
        ElseIf valu_fav_1.Value = 253 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(160)
        ElseIf valu_fav_1.Value = 297 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(161)
        ElseIf valu_fav_1.Value = 298 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(162)
        ElseIf valu_fav_1.Value = 299 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(163)
        ElseIf valu_fav_1.Value = 300 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(164)
        ElseIf valu_fav_1.Value = 301 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(165)
        ElseIf valu_fav_1.Value = 302 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(166)
        ElseIf valu_fav_1.Value = 303 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(167)
        ElseIf valu_fav_1.Value = 304 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(168)
        ElseIf valu_fav_1.Value = 305 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(169)
        ElseIf valu_fav_1.Value = 306 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(170)
        ElseIf valu_fav_1.Value = 307 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(171)
        ElseIf valu_fav_1.Value = 308 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(172)
        ElseIf valu_fav_1.Value = 309 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(173)
        ElseIf valu_fav_1.Value = 310 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(174)
        ElseIf valu_fav_1.Value = 311 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(175)
        ElseIf valu_fav_1.Value = 312 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(176)
        ElseIf valu_fav_1.Value = 314 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(177)
        ElseIf valu_fav_1.Value = 315 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(178)
        ElseIf valu_fav_1.Value = 316 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(179)
        ElseIf valu_fav_1.Value = 317 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(180)
        ElseIf valu_fav_1.Value = 318 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(181)
        ElseIf valu_fav_1.Value = 319 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(182)
        ElseIf valu_fav_1.Value = 320 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(183)
        ElseIf valu_fav_1.Value = 321 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(184)
        ElseIf valu_fav_1.Value = 322 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(185)
        ElseIf valu_fav_1.Value = 323 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(186)
        ElseIf valu_fav_1.Value = 324 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(187)
        ElseIf valu_fav_1.Value = 325 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(188)
        ElseIf valu_fav_1.Value = 326 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(189)
        ElseIf valu_fav_1.Value = 327 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(190)
        ElseIf valu_fav_1.Value = 328 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(191)
        ElseIf valu_fav_1.Value = 329 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(192)
        ElseIf valu_fav_1.Value = 330 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(193)
        ElseIf valu_fav_1.Value = 331 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(194)
        ElseIf valu_fav_1.Value = 332 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(195)
        ElseIf valu_fav_1.Value = 333 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(196)
        ElseIf valu_fav_1.Value = 334 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(197)
        ElseIf valu_fav_1.Value = 335 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(198)
        ElseIf valu_fav_1.Value = 336 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(199)
        ElseIf valu_fav_1.Value = 337 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(200)
        ElseIf valu_fav_1.Value = 338 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(201)
        ElseIf valu_fav_1.Value = 340 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(202)
        ElseIf valu_fav_1.Value = 342 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(203)
        ElseIf valu_fav_1.Value = 343 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(204)
        ElseIf valu_fav_1.Value = 344 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(205)
        ElseIf valu_fav_1.Value = 345 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(206)
        ElseIf valu_fav_1.Value = 346 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(207)
        ElseIf valu_fav_1.Value = 347 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(208)
        ElseIf valu_fav_1.Value = 348 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(209)
        ElseIf valu_fav_1.Value = 349 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(210)
        ElseIf valu_fav_1.Value = 350 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(211)
        ElseIf valu_fav_1.Value = 354 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(212)
        ElseIf valu_fav_1.Value = 355 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(213)
        ElseIf valu_fav_1.Value = 356 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(214)
        ElseIf valu_fav_1.Value = 357 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(215)
        ElseIf valu_fav_1.Value = 358 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(216)
        ElseIf valu_fav_1.Value = 359 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(217)
        ElseIf valu_fav_1.Value = 360 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(218)
        ElseIf valu_fav_1.Value = 361 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(219)
        ElseIf valu_fav_1.Value = 362 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(220)
        ElseIf valu_fav_1.Value = 363 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(221)
        ElseIf valu_fav_1.Value = 364 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(222)
        ElseIf valu_fav_1.Value = 365 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(223)
        ElseIf valu_fav_1.Value = 366 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(224)
        ElseIf valu_fav_1.Value = 367 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(225)
        ElseIf valu_fav_1.Value = 368 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(226)
        ElseIf valu_fav_1.Value = 369 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(227)
        ElseIf valu_fav_1.Value = 370 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(228)
        ElseIf valu_fav_1.Value = 371 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(229)
        ElseIf valu_fav_1.Value = 381 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(230)
        ElseIf valu_fav_1.Value = 0 Then
            Select_fav_1.SelectedItem = Select_fav_1.Items.Item(231)
        End If
    End Sub

    Private Sub valu_fav_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_fav_2.ValueChanged
        If valu_fav_2.Value = 65535 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(0)
        ElseIf valu_fav_2.Value = 2 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(1)
        ElseIf valu_fav_2.Value = 5 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(2)
        ElseIf valu_fav_2.Value = 10 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(3)
        ElseIf valu_fav_2.Value = 16 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(4)
        ElseIf valu_fav_2.Value = 20 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(5)
        ElseIf valu_fav_2.Value = 23 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(6)
        ElseIf valu_fav_2.Value = 26 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(7)
        ElseIf valu_fav_2.Value = 27 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(8)
        ElseIf valu_fav_2.Value = 29 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(9)
        ElseIf valu_fav_2.Value = 31 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(10)
        ElseIf valu_fav_2.Value = 32 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(11)
        ElseIf valu_fav_2.Value = 34 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(12)
        ElseIf valu_fav_2.Value = 36 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(13)
        ElseIf valu_fav_2.Value = 38 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(14)
        ElseIf valu_fav_2.Value = 40 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(15)
        ElseIf valu_fav_2.Value = 42 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(16)
        ElseIf valu_fav_2.Value = 44 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(17)
        ElseIf valu_fav_2.Value = 45 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(18)
        ElseIf valu_fav_2.Value = 46 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(19)
        ElseIf valu_fav_2.Value = 47 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(20)
        ElseIf valu_fav_2.Value = 48 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(21)
        ElseIf valu_fav_2.Value = 49 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(22)
        ElseIf valu_fav_2.Value = 50 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(23)
        ElseIf valu_fav_2.Value = 51 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(24)
        ElseIf valu_fav_2.Value = 53 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(25)
        ElseIf valu_fav_2.Value = 54 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(26)
        ElseIf valu_fav_2.Value = 56 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(27)
        ElseIf valu_fav_2.Value = 58 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(28)
        ElseIf valu_fav_2.Value = 61 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(29)
        ElseIf valu_fav_2.Value = 62 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(30)
        ElseIf valu_fav_2.Value = 63 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(31)
        ElseIf valu_fav_2.Value = 66 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(32)
        ElseIf valu_fav_2.Value = 67 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(33)
        ElseIf valu_fav_2.Value = 69 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(34)
        ElseIf valu_fav_2.Value = 70 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(35)
        ElseIf valu_fav_2.Value = 73 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(36)
        ElseIf valu_fav_2.Value = 76 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(37)
        ElseIf valu_fav_2.Value = 77 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(38)
        ElseIf valu_fav_2.Value = 80 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(39)
        ElseIf valu_fav_2.Value = 86 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(40)
        ElseIf valu_fav_2.Value = 87 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(41)
        ElseIf valu_fav_2.Value = 89 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(42)
        ElseIf valu_fav_2.Value = 90 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(43)
        ElseIf valu_fav_2.Value = 91 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(44)
        ElseIf valu_fav_2.Value = 92 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(45)
        ElseIf valu_fav_2.Value = 96 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(46)
        ElseIf valu_fav_2.Value = 97 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(47)
        ElseIf valu_fav_2.Value = 98 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(48)
        ElseIf valu_fav_2.Value = 99 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(49)
        ElseIf valu_fav_2.Value = 100 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(50)
        ElseIf valu_fav_2.Value = 101 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(51)
        ElseIf valu_fav_2.Value = 102 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(52)
        ElseIf valu_fav_2.Value = 103 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(53)
        ElseIf valu_fav_2.Value = 104 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(54)
        ElseIf valu_fav_2.Value = 105 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(55)
        ElseIf valu_fav_2.Value = 106 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(56)
        ElseIf valu_fav_2.Value = 107 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(57)
        ElseIf valu_fav_2.Value = 108 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(58)
        ElseIf valu_fav_2.Value = 109 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(59)
        ElseIf valu_fav_2.Value = 110 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(60)
        ElseIf valu_fav_2.Value = 112 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(61)
        ElseIf valu_fav_2.Value = 114 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(62)
        ElseIf valu_fav_2.Value = 115 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(63)
        ElseIf valu_fav_2.Value = 117 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(64)
        ElseIf valu_fav_2.Value = 119 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(65)
        ElseIf valu_fav_2.Value = 122 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(66)
        ElseIf valu_fav_2.Value = 123 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(67)
        ElseIf valu_fav_2.Value = 126 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(68)
        ElseIf valu_fav_2.Value = 132 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(69)
        ElseIf valu_fav_2.Value = 135 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(70)
        ElseIf valu_fav_2.Value = 136 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(71)
        ElseIf valu_fav_2.Value = 137 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(72)
        ElseIf valu_fav_2.Value = 138 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(73)
        ElseIf valu_fav_2.Value = 139 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(74)
        ElseIf valu_fav_2.Value = 140 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(75)
        ElseIf valu_fav_2.Value = 141 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(76)
        ElseIf valu_fav_2.Value = 142 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(77)
        ElseIf valu_fav_2.Value = 143 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(78)
        ElseIf valu_fav_2.Value = 144 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(79)
        ElseIf valu_fav_2.Value = 146 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(80)
        ElseIf valu_fav_2.Value = 147 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(81)
        ElseIf valu_fav_2.Value = 148 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(82)
        ElseIf valu_fav_2.Value = 149 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(83)
        ElseIf valu_fav_2.Value = 150 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(84)
        ElseIf valu_fav_2.Value = 151 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(85)
        ElseIf valu_fav_2.Value = 152 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(86)
        ElseIf valu_fav_2.Value = 153 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(87)
        ElseIf valu_fav_2.Value = 154 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(88)
        ElseIf valu_fav_2.Value = 155 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(89)
        ElseIf valu_fav_2.Value = 156 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(90)
        ElseIf valu_fav_2.Value = 157 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(91)
        ElseIf valu_fav_2.Value = 158 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(92)
        ElseIf valu_fav_2.Value = 159 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(93)
        ElseIf valu_fav_2.Value = 160 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(94)
        ElseIf valu_fav_2.Value = 161 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(95)
        ElseIf valu_fav_2.Value = 162 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(96)
        ElseIf valu_fav_2.Value = 163 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(97)
        ElseIf valu_fav_2.Value = 164 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(98)
        ElseIf valu_fav_2.Value = 165 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(99)
        ElseIf valu_fav_2.Value = 166 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(100)
        ElseIf valu_fav_2.Value = 167 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(101)
        ElseIf valu_fav_2.Value = 168 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(102)
        ElseIf valu_fav_2.Value = 169 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(103)
        ElseIf valu_fav_2.Value = 170 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(104)
        ElseIf valu_fav_2.Value = 171 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(105)
        ElseIf valu_fav_2.Value = 172 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(106)
        ElseIf valu_fav_2.Value = 173 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(107)
        ElseIf valu_fav_2.Value = 174 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(108)
        ElseIf valu_fav_2.Value = 175 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(109)
        ElseIf valu_fav_2.Value = 178 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(110)
        ElseIf valu_fav_2.Value = 180 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(111)
        ElseIf valu_fav_2.Value = 182 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(112)
        ElseIf valu_fav_2.Value = 183 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(113)
        ElseIf valu_fav_2.Value = 185 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(114)
        ElseIf valu_fav_2.Value = 186 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(115)
        ElseIf valu_fav_2.Value = 187 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(116)
        ElseIf valu_fav_2.Value = 188 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(117)
        ElseIf valu_fav_2.Value = 189 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(118)
        ElseIf valu_fav_2.Value = 190 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(119)
        ElseIf valu_fav_2.Value = 191 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(120)
        ElseIf valu_fav_2.Value = 192 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(121)
        ElseIf valu_fav_2.Value = 193 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(122)
        ElseIf valu_fav_2.Value = 194 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(123)
        ElseIf valu_fav_2.Value = 195 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(124)
        ElseIf valu_fav_2.Value = 197 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(125)
        ElseIf valu_fav_2.Value = 198 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(126)
        ElseIf valu_fav_2.Value = 199 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(127)
        ElseIf valu_fav_2.Value = 200 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(128)
        ElseIf valu_fav_2.Value = 201 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(129)
        ElseIf valu_fav_2.Value = 202 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(130)
        ElseIf valu_fav_2.Value = 205 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(131)
        ElseIf valu_fav_2.Value = 210 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(132)
        ElseIf valu_fav_2.Value = 216 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(133)
        ElseIf valu_fav_2.Value = 218 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(134)
        ElseIf valu_fav_2.Value = 222 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(135)
        ElseIf valu_fav_2.Value = 229 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(136)
        ElseIf valu_fav_2.Value = 230 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(137)
        ElseIf valu_fav_2.Value = 231 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(138)
        ElseIf valu_fav_2.Value = 232 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(139)
        ElseIf valu_fav_2.Value = 233 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(140)
        ElseIf valu_fav_2.Value = 234 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(141)
        ElseIf valu_fav_2.Value = 235 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(142)
        ElseIf valu_fav_2.Value = 236 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(143)
        ElseIf valu_fav_2.Value = 237 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(144)
        ElseIf valu_fav_2.Value = 238 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(145)
        ElseIf valu_fav_2.Value = 239 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(146)
        ElseIf valu_fav_2.Value = 240 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(147)
        ElseIf valu_fav_2.Value = 241 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(148)
        ElseIf valu_fav_2.Value = 242 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(149)
        ElseIf valu_fav_2.Value = 243 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(150)
        ElseIf valu_fav_2.Value = 244 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(151)
        ElseIf valu_fav_2.Value = 245 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(152)
        ElseIf valu_fav_2.Value = 246 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(153)
        ElseIf valu_fav_2.Value = 247 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(154)
        ElseIf valu_fav_2.Value = 248 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(155)
        ElseIf valu_fav_2.Value = 249 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(156)
        ElseIf valu_fav_2.Value = 250 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(157)
        ElseIf valu_fav_2.Value = 251 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(158)
        ElseIf valu_fav_2.Value = 252 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(159)
        ElseIf valu_fav_2.Value = 253 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(160)
        ElseIf valu_fav_2.Value = 297 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(161)
        ElseIf valu_fav_2.Value = 298 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(162)
        ElseIf valu_fav_2.Value = 299 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(163)
        ElseIf valu_fav_2.Value = 300 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(164)
        ElseIf valu_fav_2.Value = 301 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(165)
        ElseIf valu_fav_2.Value = 302 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(166)
        ElseIf valu_fav_2.Value = 303 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(167)
        ElseIf valu_fav_2.Value = 304 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(168)
        ElseIf valu_fav_2.Value = 305 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(169)
        ElseIf valu_fav_2.Value = 306 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(170)
        ElseIf valu_fav_2.Value = 307 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(171)
        ElseIf valu_fav_2.Value = 308 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(172)
        ElseIf valu_fav_2.Value = 309 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(173)
        ElseIf valu_fav_2.Value = 310 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(174)
        ElseIf valu_fav_2.Value = 311 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(175)
        ElseIf valu_fav_2.Value = 312 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(176)
        ElseIf valu_fav_2.Value = 314 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(177)
        ElseIf valu_fav_2.Value = 315 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(178)
        ElseIf valu_fav_2.Value = 316 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(179)
        ElseIf valu_fav_2.Value = 317 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(180)
        ElseIf valu_fav_2.Value = 318 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(181)
        ElseIf valu_fav_2.Value = 319 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(182)
        ElseIf valu_fav_2.Value = 320 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(183)
        ElseIf valu_fav_2.Value = 321 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(184)
        ElseIf valu_fav_2.Value = 322 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(185)
        ElseIf valu_fav_2.Value = 323 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(186)
        ElseIf valu_fav_2.Value = 324 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(187)
        ElseIf valu_fav_2.Value = 325 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(188)
        ElseIf valu_fav_2.Value = 326 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(189)
        ElseIf valu_fav_2.Value = 327 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(190)
        ElseIf valu_fav_2.Value = 328 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(191)
        ElseIf valu_fav_2.Value = 329 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(192)
        ElseIf valu_fav_2.Value = 330 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(193)
        ElseIf valu_fav_2.Value = 331 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(194)
        ElseIf valu_fav_2.Value = 332 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(195)
        ElseIf valu_fav_2.Value = 333 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(196)
        ElseIf valu_fav_2.Value = 334 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(197)
        ElseIf valu_fav_2.Value = 335 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(198)
        ElseIf valu_fav_2.Value = 336 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(199)
        ElseIf valu_fav_2.Value = 337 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(200)
        ElseIf valu_fav_2.Value = 338 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(201)
        ElseIf valu_fav_2.Value = 340 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(202)
        ElseIf valu_fav_2.Value = 342 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(203)
        ElseIf valu_fav_2.Value = 343 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(204)
        ElseIf valu_fav_2.Value = 344 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(205)
        ElseIf valu_fav_2.Value = 345 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(206)
        ElseIf valu_fav_2.Value = 346 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(207)
        ElseIf valu_fav_2.Value = 347 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(208)
        ElseIf valu_fav_2.Value = 348 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(209)
        ElseIf valu_fav_2.Value = 349 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(210)
        ElseIf valu_fav_2.Value = 350 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(211)
        ElseIf valu_fav_2.Value = 354 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(212)
        ElseIf valu_fav_2.Value = 355 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(213)
        ElseIf valu_fav_2.Value = 356 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(214)
        ElseIf valu_fav_2.Value = 357 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(215)
        ElseIf valu_fav_2.Value = 358 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(216)
        ElseIf valu_fav_2.Value = 359 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(217)
        ElseIf valu_fav_2.Value = 360 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(218)
        ElseIf valu_fav_2.Value = 361 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(219)
        ElseIf valu_fav_2.Value = 362 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(220)
        ElseIf valu_fav_2.Value = 363 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(221)
        ElseIf valu_fav_2.Value = 364 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(222)
        ElseIf valu_fav_2.Value = 365 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(223)
        ElseIf valu_fav_2.Value = 366 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(224)
        ElseIf valu_fav_2.Value = 367 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(225)
        ElseIf valu_fav_2.Value = 368 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(226)
        ElseIf valu_fav_2.Value = 369 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(227)
        ElseIf valu_fav_2.Value = 370 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(228)
        ElseIf valu_fav_2.Value = 371 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(229)
        ElseIf valu_fav_2.Value = 381 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(230)
        ElseIf valu_fav_2.Value = 0 Then
            Select_fav_2.SelectedItem = Select_fav_2.Items.Item(231)
        End If
    End Sub

    Private Sub valu_fav_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_fav_3.ValueChanged
        If valu_fav_3.Value = 65535 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(0)
        ElseIf valu_fav_3.Value = 2 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(1)
        ElseIf valu_fav_3.Value = 5 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(2)
        ElseIf valu_fav_3.Value = 10 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(3)
        ElseIf valu_fav_3.Value = 16 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(4)
        ElseIf valu_fav_3.Value = 20 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(5)
        ElseIf valu_fav_3.Value = 23 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(6)
        ElseIf valu_fav_3.Value = 26 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(7)
        ElseIf valu_fav_3.Value = 27 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(8)
        ElseIf valu_fav_3.Value = 29 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(9)
        ElseIf valu_fav_3.Value = 31 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(10)
        ElseIf valu_fav_3.Value = 32 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(11)
        ElseIf valu_fav_3.Value = 34 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(12)
        ElseIf valu_fav_3.Value = 36 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(13)
        ElseIf valu_fav_3.Value = 38 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(14)
        ElseIf valu_fav_3.Value = 40 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(15)
        ElseIf valu_fav_3.Value = 42 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(16)
        ElseIf valu_fav_3.Value = 44 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(17)
        ElseIf valu_fav_3.Value = 45 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(18)
        ElseIf valu_fav_3.Value = 46 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(19)
        ElseIf valu_fav_3.Value = 47 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(20)
        ElseIf valu_fav_3.Value = 48 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(21)
        ElseIf valu_fav_3.Value = 49 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(22)
        ElseIf valu_fav_3.Value = 50 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(23)
        ElseIf valu_fav_3.Value = 51 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(24)
        ElseIf valu_fav_3.Value = 53 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(25)
        ElseIf valu_fav_3.Value = 54 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(26)
        ElseIf valu_fav_3.Value = 56 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(27)
        ElseIf valu_fav_3.Value = 58 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(28)
        ElseIf valu_fav_3.Value = 61 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(29)
        ElseIf valu_fav_3.Value = 62 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(30)
        ElseIf valu_fav_3.Value = 63 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(31)
        ElseIf valu_fav_3.Value = 66 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(32)
        ElseIf valu_fav_3.Value = 67 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(33)
        ElseIf valu_fav_3.Value = 69 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(34)
        ElseIf valu_fav_3.Value = 70 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(35)
        ElseIf valu_fav_3.Value = 73 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(36)
        ElseIf valu_fav_3.Value = 76 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(37)
        ElseIf valu_fav_3.Value = 77 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(38)
        ElseIf valu_fav_3.Value = 80 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(39)
        ElseIf valu_fav_3.Value = 86 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(40)
        ElseIf valu_fav_3.Value = 87 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(41)
        ElseIf valu_fav_3.Value = 89 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(42)
        ElseIf valu_fav_3.Value = 90 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(43)
        ElseIf valu_fav_3.Value = 91 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(44)
        ElseIf valu_fav_3.Value = 92 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(45)
        ElseIf valu_fav_3.Value = 96 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(46)
        ElseIf valu_fav_3.Value = 97 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(47)
        ElseIf valu_fav_3.Value = 98 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(48)
        ElseIf valu_fav_3.Value = 99 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(49)
        ElseIf valu_fav_3.Value = 100 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(50)
        ElseIf valu_fav_3.Value = 101 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(51)
        ElseIf valu_fav_3.Value = 102 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(52)
        ElseIf valu_fav_3.Value = 103 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(53)
        ElseIf valu_fav_3.Value = 104 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(54)
        ElseIf valu_fav_3.Value = 105 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(55)
        ElseIf valu_fav_3.Value = 106 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(56)
        ElseIf valu_fav_3.Value = 107 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(57)
        ElseIf valu_fav_3.Value = 108 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(58)
        ElseIf valu_fav_3.Value = 109 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(59)
        ElseIf valu_fav_3.Value = 110 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(60)
        ElseIf valu_fav_3.Value = 112 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(61)
        ElseIf valu_fav_3.Value = 114 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(62)
        ElseIf valu_fav_3.Value = 115 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(63)
        ElseIf valu_fav_3.Value = 117 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(64)
        ElseIf valu_fav_3.Value = 119 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(65)
        ElseIf valu_fav_3.Value = 122 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(66)
        ElseIf valu_fav_3.Value = 123 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(67)
        ElseIf valu_fav_3.Value = 126 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(68)
        ElseIf valu_fav_3.Value = 132 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(69)
        ElseIf valu_fav_3.Value = 135 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(70)
        ElseIf valu_fav_3.Value = 136 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(71)
        ElseIf valu_fav_3.Value = 137 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(72)
        ElseIf valu_fav_3.Value = 138 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(73)
        ElseIf valu_fav_3.Value = 139 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(74)
        ElseIf valu_fav_3.Value = 140 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(75)
        ElseIf valu_fav_3.Value = 141 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(76)
        ElseIf valu_fav_3.Value = 142 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(77)
        ElseIf valu_fav_3.Value = 143 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(78)
        ElseIf valu_fav_3.Value = 144 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(79)
        ElseIf valu_fav_3.Value = 146 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(80)
        ElseIf valu_fav_3.Value = 147 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(81)
        ElseIf valu_fav_3.Value = 148 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(82)
        ElseIf valu_fav_3.Value = 149 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(83)
        ElseIf valu_fav_3.Value = 150 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(84)
        ElseIf valu_fav_3.Value = 151 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(85)
        ElseIf valu_fav_3.Value = 152 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(86)
        ElseIf valu_fav_3.Value = 153 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(87)
        ElseIf valu_fav_3.Value = 154 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(88)
        ElseIf valu_fav_3.Value = 155 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(89)
        ElseIf valu_fav_3.Value = 156 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(90)
        ElseIf valu_fav_3.Value = 157 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(91)
        ElseIf valu_fav_3.Value = 158 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(92)
        ElseIf valu_fav_3.Value = 159 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(93)
        ElseIf valu_fav_3.Value = 160 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(94)
        ElseIf valu_fav_3.Value = 161 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(95)
        ElseIf valu_fav_3.Value = 162 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(96)
        ElseIf valu_fav_3.Value = 163 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(97)
        ElseIf valu_fav_3.Value = 164 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(98)
        ElseIf valu_fav_3.Value = 165 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(99)
        ElseIf valu_fav_3.Value = 166 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(100)
        ElseIf valu_fav_3.Value = 167 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(101)
        ElseIf valu_fav_3.Value = 168 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(102)
        ElseIf valu_fav_3.Value = 169 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(103)
        ElseIf valu_fav_3.Value = 170 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(104)
        ElseIf valu_fav_3.Value = 171 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(105)
        ElseIf valu_fav_3.Value = 172 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(106)
        ElseIf valu_fav_3.Value = 173 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(107)
        ElseIf valu_fav_3.Value = 174 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(108)
        ElseIf valu_fav_3.Value = 175 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(109)
        ElseIf valu_fav_3.Value = 178 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(110)
        ElseIf valu_fav_3.Value = 180 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(111)
        ElseIf valu_fav_3.Value = 182 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(112)
        ElseIf valu_fav_3.Value = 183 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(113)
        ElseIf valu_fav_3.Value = 185 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(114)
        ElseIf valu_fav_3.Value = 186 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(115)
        ElseIf valu_fav_3.Value = 187 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(116)
        ElseIf valu_fav_3.Value = 188 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(117)
        ElseIf valu_fav_3.Value = 189 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(118)
        ElseIf valu_fav_3.Value = 190 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(119)
        ElseIf valu_fav_3.Value = 191 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(120)
        ElseIf valu_fav_3.Value = 192 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(121)
        ElseIf valu_fav_3.Value = 193 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(122)
        ElseIf valu_fav_3.Value = 194 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(123)
        ElseIf valu_fav_3.Value = 195 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(124)
        ElseIf valu_fav_3.Value = 197 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(125)
        ElseIf valu_fav_3.Value = 198 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(126)
        ElseIf valu_fav_3.Value = 199 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(127)
        ElseIf valu_fav_3.Value = 200 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(128)
        ElseIf valu_fav_3.Value = 201 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(129)
        ElseIf valu_fav_3.Value = 202 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(130)
        ElseIf valu_fav_3.Value = 205 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(131)
        ElseIf valu_fav_3.Value = 210 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(132)
        ElseIf valu_fav_3.Value = 216 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(133)
        ElseIf valu_fav_3.Value = 218 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(134)
        ElseIf valu_fav_3.Value = 222 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(135)
        ElseIf valu_fav_3.Value = 229 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(136)
        ElseIf valu_fav_3.Value = 230 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(137)
        ElseIf valu_fav_3.Value = 231 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(138)
        ElseIf valu_fav_3.Value = 232 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(139)
        ElseIf valu_fav_3.Value = 233 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(140)
        ElseIf valu_fav_3.Value = 234 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(141)
        ElseIf valu_fav_3.Value = 235 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(142)
        ElseIf valu_fav_3.Value = 236 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(143)
        ElseIf valu_fav_3.Value = 237 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(144)
        ElseIf valu_fav_3.Value = 238 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(145)
        ElseIf valu_fav_3.Value = 239 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(146)
        ElseIf valu_fav_3.Value = 240 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(147)
        ElseIf valu_fav_3.Value = 241 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(148)
        ElseIf valu_fav_3.Value = 242 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(149)
        ElseIf valu_fav_3.Value = 243 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(150)
        ElseIf valu_fav_3.Value = 244 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(151)
        ElseIf valu_fav_3.Value = 245 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(152)
        ElseIf valu_fav_3.Value = 246 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(153)
        ElseIf valu_fav_3.Value = 247 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(154)
        ElseIf valu_fav_3.Value = 248 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(155)
        ElseIf valu_fav_3.Value = 249 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(156)
        ElseIf valu_fav_3.Value = 250 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(157)
        ElseIf valu_fav_3.Value = 251 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(158)
        ElseIf valu_fav_3.Value = 252 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(159)
        ElseIf valu_fav_3.Value = 253 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(160)
        ElseIf valu_fav_3.Value = 297 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(161)
        ElseIf valu_fav_3.Value = 298 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(162)
        ElseIf valu_fav_3.Value = 299 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(163)
        ElseIf valu_fav_3.Value = 300 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(164)
        ElseIf valu_fav_3.Value = 301 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(165)
        ElseIf valu_fav_3.Value = 302 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(166)
        ElseIf valu_fav_3.Value = 303 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(167)
        ElseIf valu_fav_3.Value = 304 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(168)
        ElseIf valu_fav_3.Value = 305 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(169)
        ElseIf valu_fav_3.Value = 306 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(170)
        ElseIf valu_fav_3.Value = 307 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(171)
        ElseIf valu_fav_3.Value = 308 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(172)
        ElseIf valu_fav_3.Value = 309 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(173)
        ElseIf valu_fav_3.Value = 310 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(174)
        ElseIf valu_fav_3.Value = 311 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(175)
        ElseIf valu_fav_3.Value = 312 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(176)
        ElseIf valu_fav_3.Value = 314 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(177)
        ElseIf valu_fav_3.Value = 315 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(178)
        ElseIf valu_fav_3.Value = 316 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(179)
        ElseIf valu_fav_3.Value = 317 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(180)
        ElseIf valu_fav_3.Value = 318 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(181)
        ElseIf valu_fav_3.Value = 319 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(182)
        ElseIf valu_fav_3.Value = 320 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(183)
        ElseIf valu_fav_3.Value = 321 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(184)
        ElseIf valu_fav_3.Value = 322 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(185)
        ElseIf valu_fav_3.Value = 323 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(186)
        ElseIf valu_fav_3.Value = 324 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(187)
        ElseIf valu_fav_3.Value = 325 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(188)
        ElseIf valu_fav_3.Value = 326 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(189)
        ElseIf valu_fav_3.Value = 327 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(190)
        ElseIf valu_fav_3.Value = 328 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(191)
        ElseIf valu_fav_3.Value = 329 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(192)
        ElseIf valu_fav_3.Value = 330 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(193)
        ElseIf valu_fav_3.Value = 331 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(194)
        ElseIf valu_fav_3.Value = 332 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(195)
        ElseIf valu_fav_3.Value = 333 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(196)
        ElseIf valu_fav_3.Value = 334 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(197)
        ElseIf valu_fav_3.Value = 335 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(198)
        ElseIf valu_fav_3.Value = 336 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(199)
        ElseIf valu_fav_3.Value = 337 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(200)
        ElseIf valu_fav_3.Value = 338 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(201)
        ElseIf valu_fav_3.Value = 340 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(202)
        ElseIf valu_fav_3.Value = 342 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(203)
        ElseIf valu_fav_3.Value = 343 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(204)
        ElseIf valu_fav_3.Value = 344 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(205)
        ElseIf valu_fav_3.Value = 345 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(206)
        ElseIf valu_fav_3.Value = 346 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(207)
        ElseIf valu_fav_3.Value = 347 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(208)
        ElseIf valu_fav_3.Value = 348 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(209)
        ElseIf valu_fav_3.Value = 349 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(210)
        ElseIf valu_fav_3.Value = 350 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(211)
        ElseIf valu_fav_3.Value = 354 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(212)
        ElseIf valu_fav_3.Value = 355 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(213)
        ElseIf valu_fav_3.Value = 356 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(214)
        ElseIf valu_fav_3.Value = 357 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(215)
        ElseIf valu_fav_3.Value = 358 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(216)
        ElseIf valu_fav_3.Value = 359 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(217)
        ElseIf valu_fav_3.Value = 360 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(218)
        ElseIf valu_fav_3.Value = 361 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(219)
        ElseIf valu_fav_3.Value = 362 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(220)
        ElseIf valu_fav_3.Value = 363 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(221)
        ElseIf valu_fav_3.Value = 364 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(222)
        ElseIf valu_fav_3.Value = 365 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(223)
        ElseIf valu_fav_3.Value = 366 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(224)
        ElseIf valu_fav_3.Value = 367 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(225)
        ElseIf valu_fav_3.Value = 368 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(226)
        ElseIf valu_fav_3.Value = 369 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(227)
        ElseIf valu_fav_3.Value = 370 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(228)
        ElseIf valu_fav_3.Value = 371 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(229)
        ElseIf valu_fav_3.Value = 381 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(230)
        ElseIf valu_fav_3.Value = 0 Then
            Select_fav_3.SelectedItem = Select_fav_3.Items.Item(231)
        End If
    End Sub

    Private Sub valu_worst_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_worst_1.ValueChanged
        If valu_worst_1.Value = 65535 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(0)
        ElseIf valu_worst_1.Value = 2 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(1)
        ElseIf valu_worst_1.Value = 5 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(2)
        ElseIf valu_worst_1.Value = 10 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(3)
        ElseIf valu_worst_1.Value = 16 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(4)
        ElseIf valu_worst_1.Value = 20 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(5)
        ElseIf valu_worst_1.Value = 23 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(6)
        ElseIf valu_worst_1.Value = 26 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(7)
        ElseIf valu_worst_1.Value = 27 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(8)
        ElseIf valu_worst_1.Value = 29 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(9)
        ElseIf valu_worst_1.Value = 31 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(10)
        ElseIf valu_worst_1.Value = 32 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(11)
        ElseIf valu_worst_1.Value = 34 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(12)
        ElseIf valu_worst_1.Value = 36 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(13)
        ElseIf valu_worst_1.Value = 38 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(14)
        ElseIf valu_worst_1.Value = 40 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(15)
        ElseIf valu_worst_1.Value = 42 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(16)
        ElseIf valu_worst_1.Value = 44 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(17)
        ElseIf valu_worst_1.Value = 45 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(18)
        ElseIf valu_worst_1.Value = 46 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(19)
        ElseIf valu_worst_1.Value = 47 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(20)
        ElseIf valu_worst_1.Value = 48 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(21)
        ElseIf valu_worst_1.Value = 49 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(22)
        ElseIf valu_worst_1.Value = 50 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(23)
        ElseIf valu_worst_1.Value = 51 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(24)
        ElseIf valu_worst_1.Value = 53 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(25)
        ElseIf valu_worst_1.Value = 54 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(26)
        ElseIf valu_worst_1.Value = 56 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(27)
        ElseIf valu_worst_1.Value = 58 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(28)
        ElseIf valu_worst_1.Value = 61 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(29)
        ElseIf valu_worst_1.Value = 62 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(30)
        ElseIf valu_worst_1.Value = 63 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(31)
        ElseIf valu_worst_1.Value = 66 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(32)
        ElseIf valu_worst_1.Value = 67 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(33)
        ElseIf valu_worst_1.Value = 69 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(34)
        ElseIf valu_worst_1.Value = 70 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(35)
        ElseIf valu_worst_1.Value = 73 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(36)
        ElseIf valu_worst_1.Value = 76 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(37)
        ElseIf valu_worst_1.Value = 77 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(38)
        ElseIf valu_worst_1.Value = 80 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(39)
        ElseIf valu_worst_1.Value = 86 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(40)
        ElseIf valu_worst_1.Value = 87 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(41)
        ElseIf valu_worst_1.Value = 89 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(42)
        ElseIf valu_worst_1.Value = 90 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(43)
        ElseIf valu_worst_1.Value = 91 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(44)
        ElseIf valu_worst_1.Value = 92 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(45)
        ElseIf valu_worst_1.Value = 96 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(46)
        ElseIf valu_worst_1.Value = 97 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(47)
        ElseIf valu_worst_1.Value = 98 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(48)
        ElseIf valu_worst_1.Value = 99 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(49)
        ElseIf valu_worst_1.Value = 100 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(50)
        ElseIf valu_worst_1.Value = 101 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(51)
        ElseIf valu_worst_1.Value = 102 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(52)
        ElseIf valu_worst_1.Value = 103 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(53)
        ElseIf valu_worst_1.Value = 104 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(54)
        ElseIf valu_worst_1.Value = 105 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(55)
        ElseIf valu_worst_1.Value = 106 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(56)
        ElseIf valu_worst_1.Value = 107 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(57)
        ElseIf valu_worst_1.Value = 108 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(58)
        ElseIf valu_worst_1.Value = 109 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(59)
        ElseIf valu_worst_1.Value = 110 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(60)
        ElseIf valu_worst_1.Value = 112 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(61)
        ElseIf valu_worst_1.Value = 114 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(62)
        ElseIf valu_worst_1.Value = 115 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(63)
        ElseIf valu_worst_1.Value = 117 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(64)
        ElseIf valu_worst_1.Value = 119 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(65)
        ElseIf valu_worst_1.Value = 122 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(66)
        ElseIf valu_worst_1.Value = 123 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(67)
        ElseIf valu_worst_1.Value = 126 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(68)
        ElseIf valu_worst_1.Value = 132 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(69)
        ElseIf valu_worst_1.Value = 135 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(70)
        ElseIf valu_worst_1.Value = 136 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(71)
        ElseIf valu_worst_1.Value = 137 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(72)
        ElseIf valu_worst_1.Value = 138 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(73)
        ElseIf valu_worst_1.Value = 139 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(74)
        ElseIf valu_worst_1.Value = 140 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(75)
        ElseIf valu_worst_1.Value = 141 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(76)
        ElseIf valu_worst_1.Value = 142 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(77)
        ElseIf valu_worst_1.Value = 143 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(78)
        ElseIf valu_worst_1.Value = 144 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(79)
        ElseIf valu_worst_1.Value = 146 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(80)
        ElseIf valu_worst_1.Value = 147 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(81)
        ElseIf valu_worst_1.Value = 148 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(82)
        ElseIf valu_worst_1.Value = 149 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(83)
        ElseIf valu_worst_1.Value = 150 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(84)
        ElseIf valu_worst_1.Value = 151 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(85)
        ElseIf valu_worst_1.Value = 152 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(86)
        ElseIf valu_worst_1.Value = 153 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(87)
        ElseIf valu_worst_1.Value = 154 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(88)
        ElseIf valu_worst_1.Value = 155 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(89)
        ElseIf valu_worst_1.Value = 156 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(90)
        ElseIf valu_worst_1.Value = 157 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(91)
        ElseIf valu_worst_1.Value = 158 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(92)
        ElseIf valu_worst_1.Value = 159 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(93)
        ElseIf valu_worst_1.Value = 160 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(94)
        ElseIf valu_worst_1.Value = 161 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(95)
        ElseIf valu_worst_1.Value = 162 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(96)
        ElseIf valu_worst_1.Value = 163 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(97)
        ElseIf valu_worst_1.Value = 164 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(98)
        ElseIf valu_worst_1.Value = 165 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(99)
        ElseIf valu_worst_1.Value = 166 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(100)
        ElseIf valu_worst_1.Value = 167 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(101)
        ElseIf valu_worst_1.Value = 168 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(102)
        ElseIf valu_worst_1.Value = 169 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(103)
        ElseIf valu_worst_1.Value = 170 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(104)
        ElseIf valu_worst_1.Value = 171 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(105)
        ElseIf valu_worst_1.Value = 172 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(106)
        ElseIf valu_worst_1.Value = 173 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(107)
        ElseIf valu_worst_1.Value = 174 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(108)
        ElseIf valu_worst_1.Value = 175 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(109)
        ElseIf valu_worst_1.Value = 178 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(110)
        ElseIf valu_worst_1.Value = 180 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(111)
        ElseIf valu_worst_1.Value = 182 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(112)
        ElseIf valu_worst_1.Value = 183 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(113)
        ElseIf valu_worst_1.Value = 185 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(114)
        ElseIf valu_worst_1.Value = 186 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(115)
        ElseIf valu_worst_1.Value = 187 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(116)
        ElseIf valu_worst_1.Value = 188 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(117)
        ElseIf valu_worst_1.Value = 189 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(118)
        ElseIf valu_worst_1.Value = 190 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(119)
        ElseIf valu_worst_1.Value = 191 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(120)
        ElseIf valu_worst_1.Value = 192 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(121)
        ElseIf valu_worst_1.Value = 193 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(122)
        ElseIf valu_worst_1.Value = 194 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(123)
        ElseIf valu_worst_1.Value = 195 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(124)
        ElseIf valu_worst_1.Value = 197 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(125)
        ElseIf valu_worst_1.Value = 198 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(126)
        ElseIf valu_worst_1.Value = 199 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(127)
        ElseIf valu_worst_1.Value = 200 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(128)
        ElseIf valu_worst_1.Value = 201 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(129)
        ElseIf valu_worst_1.Value = 202 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(130)
        ElseIf valu_worst_1.Value = 205 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(131)
        ElseIf valu_worst_1.Value = 210 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(132)
        ElseIf valu_worst_1.Value = 216 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(133)
        ElseIf valu_worst_1.Value = 218 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(134)
        ElseIf valu_worst_1.Value = 222 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(135)
        ElseIf valu_worst_1.Value = 229 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(136)
        ElseIf valu_worst_1.Value = 230 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(137)
        ElseIf valu_worst_1.Value = 231 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(138)
        ElseIf valu_worst_1.Value = 232 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(139)
        ElseIf valu_worst_1.Value = 233 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(140)
        ElseIf valu_worst_1.Value = 234 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(141)
        ElseIf valu_worst_1.Value = 235 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(142)
        ElseIf valu_worst_1.Value = 236 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(143)
        ElseIf valu_worst_1.Value = 237 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(144)
        ElseIf valu_worst_1.Value = 238 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(145)
        ElseIf valu_worst_1.Value = 239 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(146)
        ElseIf valu_worst_1.Value = 240 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(147)
        ElseIf valu_worst_1.Value = 241 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(148)
        ElseIf valu_worst_1.Value = 242 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(149)
        ElseIf valu_worst_1.Value = 243 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(150)
        ElseIf valu_worst_1.Value = 244 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(151)
        ElseIf valu_worst_1.Value = 245 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(152)
        ElseIf valu_worst_1.Value = 246 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(153)
        ElseIf valu_worst_1.Value = 247 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(154)
        ElseIf valu_worst_1.Value = 248 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(155)
        ElseIf valu_worst_1.Value = 249 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(156)
        ElseIf valu_worst_1.Value = 250 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(157)
        ElseIf valu_worst_1.Value = 251 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(158)
        ElseIf valu_worst_1.Value = 252 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(159)
        ElseIf valu_worst_1.Value = 253 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(160)
        ElseIf valu_worst_1.Value = 297 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(161)
        ElseIf valu_worst_1.Value = 298 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(162)
        ElseIf valu_worst_1.Value = 299 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(163)
        ElseIf valu_worst_1.Value = 300 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(164)
        ElseIf valu_worst_1.Value = 301 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(165)
        ElseIf valu_worst_1.Value = 302 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(166)
        ElseIf valu_worst_1.Value = 303 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(167)
        ElseIf valu_worst_1.Value = 304 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(168)
        ElseIf valu_worst_1.Value = 305 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(169)
        ElseIf valu_worst_1.Value = 306 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(170)
        ElseIf valu_worst_1.Value = 307 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(171)
        ElseIf valu_worst_1.Value = 308 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(172)
        ElseIf valu_worst_1.Value = 309 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(173)
        ElseIf valu_worst_1.Value = 310 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(174)
        ElseIf valu_worst_1.Value = 311 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(175)
        ElseIf valu_worst_1.Value = 312 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(176)
        ElseIf valu_worst_1.Value = 314 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(177)
        ElseIf valu_worst_1.Value = 315 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(178)
        ElseIf valu_worst_1.Value = 316 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(179)
        ElseIf valu_worst_1.Value = 317 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(180)
        ElseIf valu_worst_1.Value = 318 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(181)
        ElseIf valu_worst_1.Value = 319 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(182)
        ElseIf valu_worst_1.Value = 320 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(183)
        ElseIf valu_worst_1.Value = 321 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(184)
        ElseIf valu_worst_1.Value = 322 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(185)
        ElseIf valu_worst_1.Value = 323 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(186)
        ElseIf valu_worst_1.Value = 324 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(187)
        ElseIf valu_worst_1.Value = 325 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(188)
        ElseIf valu_worst_1.Value = 326 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(189)
        ElseIf valu_worst_1.Value = 327 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(190)
        ElseIf valu_worst_1.Value = 328 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(191)
        ElseIf valu_worst_1.Value = 329 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(192)
        ElseIf valu_worst_1.Value = 330 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(193)
        ElseIf valu_worst_1.Value = 331 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(194)
        ElseIf valu_worst_1.Value = 332 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(195)
        ElseIf valu_worst_1.Value = 333 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(196)
        ElseIf valu_worst_1.Value = 334 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(197)
        ElseIf valu_worst_1.Value = 335 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(198)
        ElseIf valu_worst_1.Value = 336 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(199)
        ElseIf valu_worst_1.Value = 337 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(200)
        ElseIf valu_worst_1.Value = 338 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(201)
        ElseIf valu_worst_1.Value = 340 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(202)
        ElseIf valu_worst_1.Value = 342 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(203)
        ElseIf valu_worst_1.Value = 343 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(204)
        ElseIf valu_worst_1.Value = 344 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(205)
        ElseIf valu_worst_1.Value = 345 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(206)
        ElseIf valu_worst_1.Value = 346 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(207)
        ElseIf valu_worst_1.Value = 347 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(208)
        ElseIf valu_worst_1.Value = 348 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(209)
        ElseIf valu_worst_1.Value = 349 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(210)
        ElseIf valu_worst_1.Value = 350 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(211)
        ElseIf valu_worst_1.Value = 354 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(212)
        ElseIf valu_worst_1.Value = 355 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(213)
        ElseIf valu_worst_1.Value = 356 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(214)
        ElseIf valu_worst_1.Value = 357 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(215)
        ElseIf valu_worst_1.Value = 358 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(216)
        ElseIf valu_worst_1.Value = 359 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(217)
        ElseIf valu_worst_1.Value = 360 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(218)
        ElseIf valu_worst_1.Value = 361 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(219)
        ElseIf valu_worst_1.Value = 362 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(220)
        ElseIf valu_worst_1.Value = 363 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(221)
        ElseIf valu_worst_1.Value = 364 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(222)
        ElseIf valu_worst_1.Value = 365 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(223)
        ElseIf valu_worst_1.Value = 366 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(224)
        ElseIf valu_worst_1.Value = 367 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(225)
        ElseIf valu_worst_1.Value = 368 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(226)
        ElseIf valu_worst_1.Value = 369 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(227)
        ElseIf valu_worst_1.Value = 370 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(228)
        ElseIf valu_worst_1.Value = 371 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(229)
        ElseIf valu_worst_1.Value = 381 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(230)
        ElseIf valu_worst_1.Value = 0 Then
            Select_worst_1.SelectedItem = Select_worst_1.Items.Item(231)
        End If
    End Sub

    Private Sub valu_worst_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_worst_2.ValueChanged
        If valu_worst_2.Value = 65535 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(0)
        ElseIf valu_worst_2.Value = 2 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(1)
        ElseIf valu_worst_2.Value = 5 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(2)
        ElseIf valu_worst_2.Value = 10 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(3)
        ElseIf valu_worst_2.Value = 16 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(4)
        ElseIf valu_worst_2.Value = 20 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(5)
        ElseIf valu_worst_2.Value = 23 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(6)
        ElseIf valu_worst_2.Value = 26 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(7)
        ElseIf valu_worst_2.Value = 27 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(8)
        ElseIf valu_worst_2.Value = 29 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(9)
        ElseIf valu_worst_2.Value = 31 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(10)
        ElseIf valu_worst_2.Value = 32 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(11)
        ElseIf valu_worst_2.Value = 34 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(12)
        ElseIf valu_worst_2.Value = 36 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(13)
        ElseIf valu_worst_2.Value = 38 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(14)
        ElseIf valu_worst_2.Value = 40 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(15)
        ElseIf valu_worst_2.Value = 42 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(16)
        ElseIf valu_worst_2.Value = 44 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(17)
        ElseIf valu_worst_2.Value = 45 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(18)
        ElseIf valu_worst_2.Value = 46 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(19)
        ElseIf valu_worst_2.Value = 47 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(20)
        ElseIf valu_worst_2.Value = 48 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(21)
        ElseIf valu_worst_2.Value = 49 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(22)
        ElseIf valu_worst_2.Value = 50 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(23)
        ElseIf valu_worst_2.Value = 51 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(24)
        ElseIf valu_worst_2.Value = 53 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(25)
        ElseIf valu_worst_2.Value = 54 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(26)
        ElseIf valu_worst_2.Value = 56 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(27)
        ElseIf valu_worst_2.Value = 58 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(28)
        ElseIf valu_worst_2.Value = 61 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(29)
        ElseIf valu_worst_2.Value = 62 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(30)
        ElseIf valu_worst_2.Value = 63 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(31)
        ElseIf valu_worst_2.Value = 66 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(32)
        ElseIf valu_worst_2.Value = 67 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(33)
        ElseIf valu_worst_2.Value = 69 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(34)
        ElseIf valu_worst_2.Value = 70 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(35)
        ElseIf valu_worst_2.Value = 73 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(36)
        ElseIf valu_worst_2.Value = 76 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(37)
        ElseIf valu_worst_2.Value = 77 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(38)
        ElseIf valu_worst_2.Value = 80 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(39)
        ElseIf valu_worst_2.Value = 86 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(40)
        ElseIf valu_worst_2.Value = 87 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(41)
        ElseIf valu_worst_2.Value = 89 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(42)
        ElseIf valu_worst_2.Value = 90 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(43)
        ElseIf valu_worst_2.Value = 91 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(44)
        ElseIf valu_worst_2.Value = 92 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(45)
        ElseIf valu_worst_2.Value = 96 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(46)
        ElseIf valu_worst_2.Value = 97 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(47)
        ElseIf valu_worst_2.Value = 98 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(48)
        ElseIf valu_worst_2.Value = 99 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(49)
        ElseIf valu_worst_2.Value = 100 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(50)
        ElseIf valu_worst_2.Value = 101 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(51)
        ElseIf valu_worst_2.Value = 102 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(52)
        ElseIf valu_worst_2.Value = 103 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(53)
        ElseIf valu_worst_2.Value = 104 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(54)
        ElseIf valu_worst_2.Value = 105 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(55)
        ElseIf valu_worst_2.Value = 106 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(56)
        ElseIf valu_worst_2.Value = 107 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(57)
        ElseIf valu_worst_2.Value = 108 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(58)
        ElseIf valu_worst_2.Value = 109 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(59)
        ElseIf valu_worst_2.Value = 110 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(60)
        ElseIf valu_worst_2.Value = 112 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(61)
        ElseIf valu_worst_2.Value = 114 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(62)
        ElseIf valu_worst_2.Value = 115 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(63)
        ElseIf valu_worst_2.Value = 117 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(64)
        ElseIf valu_worst_2.Value = 119 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(65)
        ElseIf valu_worst_2.Value = 122 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(66)
        ElseIf valu_worst_2.Value = 123 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(67)
        ElseIf valu_worst_2.Value = 126 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(68)
        ElseIf valu_worst_2.Value = 132 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(69)
        ElseIf valu_worst_2.Value = 135 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(70)
        ElseIf valu_worst_2.Value = 136 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(71)
        ElseIf valu_worst_2.Value = 137 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(72)
        ElseIf valu_worst_2.Value = 138 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(73)
        ElseIf valu_worst_2.Value = 139 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(74)
        ElseIf valu_worst_2.Value = 140 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(75)
        ElseIf valu_worst_2.Value = 141 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(76)
        ElseIf valu_worst_2.Value = 142 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(77)
        ElseIf valu_worst_2.Value = 143 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(78)
        ElseIf valu_worst_2.Value = 144 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(79)
        ElseIf valu_worst_2.Value = 146 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(80)
        ElseIf valu_worst_2.Value = 147 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(81)
        ElseIf valu_worst_2.Value = 148 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(82)
        ElseIf valu_worst_2.Value = 149 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(83)
        ElseIf valu_worst_2.Value = 150 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(84)
        ElseIf valu_worst_2.Value = 151 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(85)
        ElseIf valu_worst_2.Value = 152 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(86)
        ElseIf valu_worst_2.Value = 153 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(87)
        ElseIf valu_worst_2.Value = 154 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(88)
        ElseIf valu_worst_2.Value = 155 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(89)
        ElseIf valu_worst_2.Value = 156 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(90)
        ElseIf valu_worst_2.Value = 157 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(91)
        ElseIf valu_worst_2.Value = 158 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(92)
        ElseIf valu_worst_2.Value = 159 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(93)
        ElseIf valu_worst_2.Value = 160 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(94)
        ElseIf valu_worst_2.Value = 161 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(95)
        ElseIf valu_worst_2.Value = 162 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(96)
        ElseIf valu_worst_2.Value = 163 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(97)
        ElseIf valu_worst_2.Value = 164 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(98)
        ElseIf valu_worst_2.Value = 165 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(99)
        ElseIf valu_worst_2.Value = 166 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(100)
        ElseIf valu_worst_2.Value = 167 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(101)
        ElseIf valu_worst_2.Value = 168 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(102)
        ElseIf valu_worst_2.Value = 169 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(103)
        ElseIf valu_worst_2.Value = 170 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(104)
        ElseIf valu_worst_2.Value = 171 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(105)
        ElseIf valu_worst_2.Value = 172 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(106)
        ElseIf valu_worst_2.Value = 173 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(107)
        ElseIf valu_worst_2.Value = 174 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(108)
        ElseIf valu_worst_2.Value = 175 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(109)
        ElseIf valu_worst_2.Value = 178 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(110)
        ElseIf valu_worst_2.Value = 180 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(111)
        ElseIf valu_worst_2.Value = 182 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(112)
        ElseIf valu_worst_2.Value = 183 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(113)
        ElseIf valu_worst_2.Value = 185 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(114)
        ElseIf valu_worst_2.Value = 186 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(115)
        ElseIf valu_worst_2.Value = 187 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(116)
        ElseIf valu_worst_2.Value = 188 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(117)
        ElseIf valu_worst_2.Value = 189 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(118)
        ElseIf valu_worst_2.Value = 190 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(119)
        ElseIf valu_worst_2.Value = 191 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(120)
        ElseIf valu_worst_2.Value = 192 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(121)
        ElseIf valu_worst_2.Value = 193 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(122)
        ElseIf valu_worst_2.Value = 194 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(123)
        ElseIf valu_worst_2.Value = 195 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(124)
        ElseIf valu_worst_2.Value = 197 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(125)
        ElseIf valu_worst_2.Value = 198 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(126)
        ElseIf valu_worst_2.Value = 199 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(127)
        ElseIf valu_worst_2.Value = 200 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(128)
        ElseIf valu_worst_2.Value = 201 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(129)
        ElseIf valu_worst_2.Value = 202 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(130)
        ElseIf valu_worst_2.Value = 205 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(131)
        ElseIf valu_worst_2.Value = 210 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(132)
        ElseIf valu_worst_2.Value = 216 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(133)
        ElseIf valu_worst_2.Value = 218 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(134)
        ElseIf valu_worst_2.Value = 222 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(135)
        ElseIf valu_worst_2.Value = 229 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(136)
        ElseIf valu_worst_2.Value = 230 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(137)
        ElseIf valu_worst_2.Value = 231 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(138)
        ElseIf valu_worst_2.Value = 232 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(139)
        ElseIf valu_worst_2.Value = 233 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(140)
        ElseIf valu_worst_2.Value = 234 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(141)
        ElseIf valu_worst_2.Value = 235 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(142)
        ElseIf valu_worst_2.Value = 236 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(143)
        ElseIf valu_worst_2.Value = 237 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(144)
        ElseIf valu_worst_2.Value = 238 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(145)
        ElseIf valu_worst_2.Value = 239 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(146)
        ElseIf valu_worst_2.Value = 240 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(147)
        ElseIf valu_worst_2.Value = 241 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(148)
        ElseIf valu_worst_2.Value = 242 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(149)
        ElseIf valu_worst_2.Value = 243 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(150)
        ElseIf valu_worst_2.Value = 244 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(151)
        ElseIf valu_worst_2.Value = 245 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(152)
        ElseIf valu_worst_2.Value = 246 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(153)
        ElseIf valu_worst_2.Value = 247 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(154)
        ElseIf valu_worst_2.Value = 248 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(155)
        ElseIf valu_worst_2.Value = 249 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(156)
        ElseIf valu_worst_2.Value = 250 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(157)
        ElseIf valu_worst_2.Value = 251 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(158)
        ElseIf valu_worst_2.Value = 252 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(159)
        ElseIf valu_worst_2.Value = 253 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(160)
        ElseIf valu_worst_2.Value = 297 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(161)
        ElseIf valu_worst_2.Value = 298 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(162)
        ElseIf valu_worst_2.Value = 299 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(163)
        ElseIf valu_worst_2.Value = 300 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(164)
        ElseIf valu_worst_2.Value = 301 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(165)
        ElseIf valu_worst_2.Value = 302 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(166)
        ElseIf valu_worst_2.Value = 303 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(167)
        ElseIf valu_worst_2.Value = 304 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(168)
        ElseIf valu_worst_2.Value = 305 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(169)
        ElseIf valu_worst_2.Value = 306 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(170)
        ElseIf valu_worst_2.Value = 307 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(171)
        ElseIf valu_worst_2.Value = 308 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(172)
        ElseIf valu_worst_2.Value = 309 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(173)
        ElseIf valu_worst_2.Value = 310 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(174)
        ElseIf valu_worst_2.Value = 311 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(175)
        ElseIf valu_worst_2.Value = 312 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(176)
        ElseIf valu_worst_2.Value = 314 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(177)
        ElseIf valu_worst_2.Value = 315 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(178)
        ElseIf valu_worst_2.Value = 316 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(179)
        ElseIf valu_worst_2.Value = 317 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(180)
        ElseIf valu_worst_2.Value = 318 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(181)
        ElseIf valu_worst_2.Value = 319 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(182)
        ElseIf valu_worst_2.Value = 320 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(183)
        ElseIf valu_worst_2.Value = 321 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(184)
        ElseIf valu_worst_2.Value = 322 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(185)
        ElseIf valu_worst_2.Value = 323 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(186)
        ElseIf valu_worst_2.Value = 324 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(187)
        ElseIf valu_worst_2.Value = 325 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(188)
        ElseIf valu_worst_2.Value = 326 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(189)
        ElseIf valu_worst_2.Value = 327 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(190)
        ElseIf valu_worst_2.Value = 328 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(191)
        ElseIf valu_worst_2.Value = 329 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(192)
        ElseIf valu_worst_2.Value = 330 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(193)
        ElseIf valu_worst_2.Value = 331 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(194)
        ElseIf valu_worst_2.Value = 332 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(195)
        ElseIf valu_worst_2.Value = 333 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(196)
        ElseIf valu_worst_2.Value = 334 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(197)
        ElseIf valu_worst_2.Value = 335 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(198)
        ElseIf valu_worst_2.Value = 336 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(199)
        ElseIf valu_worst_2.Value = 337 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(200)
        ElseIf valu_worst_2.Value = 338 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(201)
        ElseIf valu_worst_2.Value = 340 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(202)
        ElseIf valu_worst_2.Value = 342 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(203)
        ElseIf valu_worst_2.Value = 343 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(204)
        ElseIf valu_worst_2.Value = 344 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(205)
        ElseIf valu_worst_2.Value = 345 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(206)
        ElseIf valu_worst_2.Value = 346 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(207)
        ElseIf valu_worst_2.Value = 347 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(208)
        ElseIf valu_worst_2.Value = 348 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(209)
        ElseIf valu_worst_2.Value = 349 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(210)
        ElseIf valu_worst_2.Value = 350 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(211)
        ElseIf valu_worst_2.Value = 354 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(212)
        ElseIf valu_worst_2.Value = 355 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(213)
        ElseIf valu_worst_2.Value = 356 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(214)
        ElseIf valu_worst_2.Value = 357 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(215)
        ElseIf valu_worst_2.Value = 358 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(216)
        ElseIf valu_worst_2.Value = 359 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(217)
        ElseIf valu_worst_2.Value = 360 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(218)
        ElseIf valu_worst_2.Value = 361 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(219)
        ElseIf valu_worst_2.Value = 362 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(220)
        ElseIf valu_worst_2.Value = 363 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(221)
        ElseIf valu_worst_2.Value = 364 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(222)
        ElseIf valu_worst_2.Value = 365 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(223)
        ElseIf valu_worst_2.Value = 366 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(224)
        ElseIf valu_worst_2.Value = 367 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(225)
        ElseIf valu_worst_2.Value = 368 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(226)
        ElseIf valu_worst_2.Value = 369 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(227)
        ElseIf valu_worst_2.Value = 370 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(228)
        ElseIf valu_worst_2.Value = 371 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(229)
        ElseIf valu_worst_2.Value = 381 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(230)
        ElseIf valu_worst_2.Value = 0 Then
            Select_worst_2.SelectedItem = Select_worst_2.Items.Item(231)
        End If
    End Sub
End Class