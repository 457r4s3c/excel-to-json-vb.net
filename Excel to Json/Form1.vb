Imports System.IO
Imports Newtonsoft.Json
Imports ExcelDataReader
Public Class Form1
    Private Sub btnBrowseInput_Click(sender As Object, e As EventArgs) Handles btnBrowseInput.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Excel files (*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*"
            openFileDialog.Title = "Select Input Excel File"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                txtInputPath.Text = openFileDialog.FileName
            End If
        End Using
    End Sub

    Private Sub btnBrowseOutput_Click(sender As Object, e As EventArgs) Handles btnBrowseOutput.Click
        Using folderBrowserDialog As New FolderBrowserDialog()
            folderBrowserDialog.Description = "Select Output Folder"
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                txtOutputPath.Text = folderBrowserDialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputFilePath As String = txtInputPath.Text
        Dim outputFilePath As String = Path.Combine(txtOutputPath.Text, "output.json")

        If String.IsNullOrEmpty(inputFilePath) OrElse String.IsNullOrEmpty(txtOutputPath.Text) Then
            MessageBox.Show("Please select both input Excel file and output folder.")
            Return
        End If

        Try
            ConvertExcelToJson(inputFilePath, outputFilePath)
            MessageBox.Show("Excel to JSON conversion completed successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub ConvertExcelToJson(inputFilePath As String, outputFilePath As String)
        ' Open the Excel file for reading
        Using stream = File.Open(inputFilePath, FileMode.Open, FileAccess.Read)
            Using reader = ExcelReaderFactory.CreateReader(stream)
                Dim result = reader.AsDataSet()

                ' Convert the DataSet to JSON
                Dim json = JsonConvert.SerializeObject(result.Tables(0), Formatting.Indented)

                ' Write the JSON to a file
                File.WriteAllText(outputFilePath, json)
            End Using
        End Using
    End Sub
End Class
