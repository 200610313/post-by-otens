Module mngrAcctCreator
    Public Sub verify(bname As String, new_BPhone As String, bmail_txtbx As String, new_BFName As String, new_BMinit As String, new_BLName As String, mun_txtbx As String, mpw_txtbx As String, run_txtbx As String, rpw_txtbx As String, pin As String)
        'check for business name

        Dim vEmailAddress As New System.Net.Mail.MailAddress(bmail_txtbx)
            If new_BPhone.Chars(0) = "0" And new_BPhone.Chars(1) = "9" And new_BPhone.Length = 11 And AllDigits(new_BPhone) And CheckForAlphaCharacters(new_BFName) And CheckForAlphaCharacters(new_BMinit) And CheckForAlphaCharacters(new_BLName) And pin.Length = 6 And AllDigits(pin) Then
                Dim adp As New POSDataSetTableAdapters.businessTableAdapter
                Dim rowsaff As Integer
                rowsaff = adp.InsertQuery(bname, new_BPhone, new_BFName, new_BLName, new_BMinit, bmail_txtbx, pin, run_txtbx, rpw_txtbx)
            End If

    End Sub
    ' Return True if the string contains only digits.
    Public Function AllDigits(ByVal txt As String) As Boolean
        Dim ch As String
        Dim i As Integer

        AllDigits = True
        For i = 1 To Len(txt)
            ' See if the next character is a non-digit.
            ch = Mid$(txt, i, 1)
            If ch < "0" Or ch > "9" Then
                ' This is not a digit.
                AllDigits = False
                Exit For
            End If
        Next i
    End Function

    Public Function CheckForAlphaCharacters(ByVal StringToCheck As String) As Boolean
        For i = 0 To StringToCheck.Length - 1
            If Not Char.IsLetter(StringToCheck.Chars(i)) Then
                Return False
            End If
        Next
        Return True 'Return true if all elements are characters
    End Function
End Module
