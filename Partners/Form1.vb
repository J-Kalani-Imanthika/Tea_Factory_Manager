Public Class Form1
    'Dim rndcolor As New Random
    'Dim colorname As System.Type = GetType(System.Drawing.Color)
    'Dim colorinfo As System.Reflection.PropertyInfo() = colorname.GetProperties()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.FromArgb(rndcolor.Next(100), rndcolor.Next(105), rndcolor.Next(225))

        Panel_dashboard.Visible = False
        Sub_Panel1_invoice.Visible = False
        Sub_Panel2_update.Visible = False


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Panellist_down.Click
        Panel_dashboard.Visible = False
        Panellist_drop.Visible = True
        Panellist_down.Visible = False
        Sub_Panel1_invoice.Visible = False
        Sub_Panel2_update.Visible = False
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Panellist_drop.Click
        Panel_dashboard.Visible = True
        Panellist_drop.Visible = False
        Panellist_down.Visible = True
    End Sub

    Private Sub SubPictureBox1_invo_Click(sender As Object, e As EventArgs) Handles SubPictureBox1_invo.Click
        Sub_Panel1_invoice.Visible = True
        SubPictureBox1_invo.Visible = False
    End Sub

    Private Sub SubPictureBox2_updt_Click(sender As Object, e As EventArgs) Handles SubPictureBox2_updt.Click
        Sub_Panel2_update.Visible = True
        SubPictureBox2_updt.Visible = False
    End Sub

    Private Sub Sub_Panel1_invoice_Paint(sender As Object, e As PaintEventArgs) Handles Sub_Panel1_invoice.Paint
        'Sub_Panel2.Visible = True
    End Sub
    Private Sub Sub_Panel2_update_Paint(sender As Object, e As PaintEventArgs) Handles Sub_Panel2_update.Paint

    End Sub
    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        'Me.BackColor = Color.FromArgb(rndcolor.Next(250), rndcolor.Next(105), rndcolor.Next(225))
        Lbltop_panal.Text = "REGISTRATION"

        With Partner_Registration
            .TopLevel = False
            Disply_panal.Controls.Add(Partner_Registration)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub btn_teacollect_Click(sender As Object, e As EventArgs) Handles btn_teacollect.Click
        Lbltop_panal.Text = "TEA COLLECTION"
        With Tea_Collection
            .TopLevel = False
            Disply_panal.Controls.Add(Tea_Collection)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With

    End Sub

    Private Sub btnfertilizer_Click(sender As Object, e As EventArgs) Handles btnfertilizer.Click
        Lbltop_panal.Text = "FERTILIZER"
        With Fertilizer_Issue
            .TopLevel = False
            Disply_panal.Controls.Add(Fertilizer_Issue)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub btn_allowence_Click(sender As Object, e As EventArgs) Handles btn_allowence.Click
        Lbltop_panal.Text = "ALLOWENCE"
        With Allowence
            .TopLevel = False
            Disply_panal.Controls.Add(Allowence)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub btn_advance_Click(sender As Object, e As EventArgs) Handles btn_advance.Click
        Lbltop_panal.Text = "ADVANCE"

        With Advance_Money
            .TopLevel = False
            Disply_panal.Controls.Add(Advance_Money)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub btninvoice_Click(sender As Object, e As EventArgs) Handles btninvoice.Click
        Sub_Panel1_invoice.Visible = False
        SubPictureBox1_invo.Visible = True
    End Sub

    Private Sub btn_agent_Click(sender As Object, e As EventArgs) Handles btn_agent.Click
        Sub_Panel1_invoice.Visible = False
        SubPictureBox1_invo.Visible = True
        Lbltop_panal.Text = "AGENT INVOICE"

        With Transport_Agent
            .TopLevel = False
            Disply_panal.Controls.Add(Transport_Agent)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        Sub_Panel1_invoice.Visible = False
        SubPictureBox1_invo.Visible = True
        Lbltop_panal.Text = "SUPPLIER INVOICE"

        With Supplier_Invoice
            .TopLevel = False
            Disply_panal.Controls.Add(Supplier_Invoice)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Sub_Panel2_update.Visible = False
        SubPictureBox2_updt.Visible = True
    End Sub

    Private Sub Btn_categoty_Click(sender As Object, e As EventArgs) Handles Btn_categoty.Click
        Sub_Panel2_update.Visible = False
        SubPictureBox2_updt.Visible = True
        Lbltop_panal.Text = "CATEGORY"

        With Category
            .TopLevel = False
            Disply_panal.Controls.Add(Category)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub Btn_area_Click(sender As Object, e As EventArgs) Handles Btn_area.Click
        Sub_Panel2_update.Visible = False
        SubPictureBox2_updt.Visible = True
        Lbltop_panal.Text = "AREA"

        With Area
            .TopLevel = False
            Disply_panal.Controls.Add(Area)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub Btn_teatype_Click(sender As Object, e As EventArgs) Handles Btn_teatype.Click
        Sub_Panel2_update.Visible = False
        SubPictureBox2_updt.Visible = True
        Lbltop_panal.Text = "TEA TYPE"

        With Tea_type_update
            .TopLevel = False
            Disply_panal.Controls.Add(Tea_type_update)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub Btn_fertilizer_Click(sender As Object, e As EventArgs) Handles Btn_fertilizer.Click
        Sub_Panel2_update.Visible = False
        SubPictureBox2_updt.Visible = True
        Lbltop_panal.Text = "FERTILIZER"

        With Fertilizer_Update
            .TopLevel = False
            Disply_panal.Controls.Add(Fertilizer_Update)
            .BringToFront()
            .Show()
            Panel_dashboard.Visible = False
            Panellist_drop.Visible = False
            Panellist_down.Visible = False
        End With
    End Sub

    Private Sub Disply_panal_Paint(sender As Object, e As PaintEventArgs) Handles Disply_panal.Paint
        'Me.BackColor = Color.FromArgb(rndcolor.Next(250), rndcolor.Next(105), rndcolor.Next(225))

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        User_Login.Show()
        Me.Hide()
    End Sub
End Class





