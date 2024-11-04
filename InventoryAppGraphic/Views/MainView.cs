namespace InventoryAppGraphic.Views;

public partial class MainView : Form
{
    public EventHandler AddCateg_Click;
    public EventHandler RemoveCateg_Click;
    public EventHandler AddProduct_Click;
    public EventHandler RemoveProduct_Click;
    public EventHandler ComboCategs_Click;
    public EventHandler ListItems_Click;
    public EventHandler UpdateProduct_Click;
    public MainView()
    {
        InitializeComponent();
        AttachEventHandlers();
    }


    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
    {

    }

    
}
