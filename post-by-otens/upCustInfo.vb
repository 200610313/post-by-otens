Module upCustInfo
    Private cID As Integer

    Public Sub updateCustInfo(cID As Integer, mainManagevb As MainManagevb)
        upCustInfo.cID = cID
        Dim form As New custRegistrationForm
        form.Show()
        form.submit_managerbtn.Visible = True
        form.managerClose_btn.Visible = True
        form.submitbutton.Visible = False
        form.PictureBox1.Visible = False
    End Sub

    Function getCIDOfExisting() As Integer
        Return cID
    End Function

    Public Sub queryUpdate(text As String, text1 As String, text2 As String, text3 As String, text4 As String, text5 As String, text6 As String)
        Dim adapter As New POSDataSetTableAdapters.customerTableAdapter
        Dim rowsaffected As Integer
        rowsaffected = adapter.updateCustInfo(text, text1, text2, text3, text4, text5, text6, cID)
        MainManagevb.loadTable()
    End Sub
End Module
