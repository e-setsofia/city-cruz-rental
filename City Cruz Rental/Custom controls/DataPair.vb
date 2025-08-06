Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DataPair
    Inherits UserControl

    ' Default constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor with parameters
    Public Sub New(label As String, value As String)
        InitializeComponent()
        Me.LabelText = label
        Me.ValueText = value
    End Sub

    <Browsable(True)>
    <Category("Data")>
    <Description("The text shown as the label.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property LabelText As String
        Get
            Return lblLabel.Text
        End Get
        Set(value As String)
            lblLabel.Text = value
        End Set
    End Property

    <Browsable(True)>
    <Category("Data")>
    <Description("The text shown as the value.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property ValueText As String
        Get
            Return lblValue.Text
        End Get
        Set(value As String)
            lblValue.Text = value
        End Set
    End Property

    ' Optional: handle click if needed
    Private Sub lblValue_Click(sender As Object, e As EventArgs) Handles lblValue.Click
        ' Handle click event
    End Sub
End Class
