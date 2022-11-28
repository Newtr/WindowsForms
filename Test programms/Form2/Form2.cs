namespace Test;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }
    public Form2(Form f)
    {
        InitializeComponent();
        f.BackColor = Color.Yellow;
    }
}
