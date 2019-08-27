Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Public Class SQLConnect
    Public con As New OleDbConnection With {.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\medicalDia.accdb"}
    Public cmd As New OleDbCommand
    Public rdr As OleDbDataReader = Nothing
    Public dtable As New DataTable
    Public adp As OleDbDataAdapter
    Public ds As DataSet
    Public dt As DataTableCollection
    Public source1 As New BindingSource
End Class