Module Main1

    Sub Main()
        Dim EXEArgs = My.Application.CommandLineArgs.ToString()
        Dim EXEName = "failed"
        Dim EXERen = "C:\Windows\System32\cmd.exe /k"
        EXEName = Process.GetCurrentProcess().MainModule.ToString()
        If EXEName = "failed" Then
            MsgBox("Could not find the pass-through file..", vbCritical)
        Else
            Try
                EXERen = "C:\Windows\System32\cmd.exe /k rename " + EXEName + ".exe" + EXEName + ".exe"
                Process.Start(EXERen)
                Process.Start("C:\Windows\temp.exe " + EXEArgs(1) + EXEArgs(2) + EXEArgs(3) + EXEArgs(4) + EXEArgs(5) + EXEArgs(6))

                Process.Start("C:\Windows\System32\cmd.exe /k echo y | del C:\Windows\temp.exe")
            Catch
                MsgBox("Invalid File.", vbCritical)
            End Try
        End If
    End Sub

End Module
' not written in an IDE
