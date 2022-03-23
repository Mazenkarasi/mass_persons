Public Class Form1

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim l, k, m, d As Double
        k = Convert.ToDouble(TextBox1.Text)
        l = Convert.ToDouble(TextBox2.Text)
        m = k / (l * l)
        TextBox3.Text = Convert.ToString(m)
        Select Case m
            Case 18.5 To 25
                TextBox4.Text = "طبيعي"
            Case 25 To 30
                TextBox4.Text = "وزن زائد"
            Case 30 To 35
                TextBox4.Text = "بدانة درجة اولى "
            Case 35 To 40
                TextBox4.Text = "بدانة درجة ثانية  "
            Case Is > 40
                TextBox4.Text = "بدانة درجة ثالثة "
            Case Is < 18.5
                TextBox4.Text = "تحت الطبيعي"
        End Select
        d = (k * 8) / 100
        TextBox5.Text = Convert.ToString(d)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frm = New Form2
        frm.ShowDialog()
    End Sub


    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
