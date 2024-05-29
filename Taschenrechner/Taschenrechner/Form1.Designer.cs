namespace RechnerGUI;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "HTL Taschenrechner";
        this.Name = this.Text;

        TextBox tb = new TextBox();
        tb.Name = "input";
        tb.Left = 300;
        tb.Top = 50;
        tb.Width = 150;
        tb.Height = 20;
        tb.Multiline = false;
        this.Controls.Add(tb);
        
        Button s = new Button();
        s.Name = "submit";
        s.Text = "Submit";
        s.Left = 300;
        s.Top = 100;
        s.Width = 150;
        s.Height = 30;
        s.Click += btn_check_click;// was soll nach Click passieren?
        this.Controls.Add(s);

        this.Load += Form_Load;
        
        Button a = new Button();
        a.Name = "a";
        a.Text = "a";
        a.Left = 300;
        a.Top = 100;
        a.Width = 150;
        a.Height = 30;
        a.Click += btn_check_click;// was soll nach Click passieren?
        this.Controls.Add(s);
        
    }

    #endregion
}