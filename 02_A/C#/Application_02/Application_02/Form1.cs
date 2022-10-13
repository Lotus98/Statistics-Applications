namespace Application02;
public partial class Form1 : Form {
    private Random rand = new Random();


    public Form1() {
        InitializeComponent();
    }

    private void timerTick(object sender, EventArgs e) {
        int val = rand.Next();
        textBox.Text = val.ToString();
    }
}