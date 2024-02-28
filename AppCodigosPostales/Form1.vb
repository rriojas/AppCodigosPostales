Public Class Form1
  Dim query As String
  'Create a constructor
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    ' Add any initialization after the InitializeComponent() call.
    'Create a new instance of the Connection class

    query = "select id, nombre from estado"
    cboEstado.DataSource = Connection.SelectQuery(query)
    cboEstado.DisplayMember = "nombre"
    cboEstado.ValueMember = "id"

  End Sub

  Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged
    query = "select id, nombre from municipio where idEstado=" & cboEstado.SelectedValue
    cboMunicipio.DataSource = Connection.SelectQuery(query)
    cboMunicipio.DisplayMember = "nombre"
    cboMunicipio.ValueMember = "id"
  End Sub

  Private Sub cboMunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMunicipio.SelectedIndexChanged
    If cboEstado.Text Is Nothing Then
      Exit Sub
    End If
    query = "select * from VW_Busqueda where [Nombre Municipio]='" & cboMunicipio.Text & "'"
    DataGridView1.DataSource = Connection.SelectQuery(query)
  End Sub
End Class
