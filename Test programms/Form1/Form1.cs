using System.Data;
using System.Timers;
using System.Globalization;
namespace Test;

public partial class Form1 : Form
{
    Point moveStart;
    public Form1()
    {
        InitializeComponent();
        this.BackColor = Color.Yellow;
        this.Load += Form1_Load;
    }

    private void button1_click(object? sender, EventArgs e)
    {
        this.Close();
    }
    private void form_loader(object? sender, EventArgs e)
    {
        System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
        myPath.AddEllipse(0,0,this.Width,this.Height);
        Region myRegion = new Region(myPath);
        this.Region = myRegion;
    }

    private void form_mouse_down(object? sender, MouseEventArgs e)
    {
        if(e.Button == MouseButtons.Left)
        {
            moveStart = new Point(e.X,e.Y);
        }
    }
    private void form_mouse_move(object? sender, MouseEventArgs e)
    {
        if((e.Button & MouseButtons.Left) != 0)
        {
            Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
            this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
        }
    }
    private void Form1_Load(object? sender, EventArgs e)
{
    Button helloButton = new Button();
    helloButton.BackColor = Color.LightGray;
    helloButton.ForeColor = Color.Red;
    helloButton.Location = new Point(10, 10);
    helloButton.Text = "Привет";
    this.Controls.Add(helloButton);
    AutoClosingMessageBox.Show("My_Text","Name",5000);
}

}
