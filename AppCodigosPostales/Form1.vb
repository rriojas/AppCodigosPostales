Public Class Form1
  'Create a constructor
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    'Create a new instance of the Connection class
    Dim query As String = "select nombre from estado"
    DataGridView1.DataSource = Connection.SelectQuery(query)
  End Sub
End Class
