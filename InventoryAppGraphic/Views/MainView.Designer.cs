namespace InventoryAppGraphic.Views;

partial class MainView
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

    public string ComboCategs {  get => comboCategs.Text; set => comboCategs.Text = value; }
    public string ComboCategItem { get => comboCategItem.Text; set => comboCategItem.Text = value; }
    public string TextBoxName { get => textBoxName.Text; set => textBoxName.Text = value; }
    public string TextBoxDesc { get => textBoxDesc.Text; set => textBoxDesc.Text = value; }
    public decimal NumericPrice { get => numericPrice.Value; set => numericPrice.Value = value; }
    public string ListItems { get => listItems.Text;}
    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    /// 
    private void AttachEventHandlers()
    {
        addCateg.Click += (sender, e) => AddCateg_Click?.Invoke(sender, e);
        remCateg.Click += (sender, e) => RemoveCateg_Click?.Invoke(sender, e);
        btnAddProd.Click += (sender, e) => AddProduct_Click?.Invoke(sender, e);
        btnRemProd.Click += (sender, e) => RemoveProduct_Click?.Invoke(sender, e);
        btnUpdateProd.Click += (sender, e) => UpdateProduct_Click?.Invoke(sender, e);
        comboCategs.SelectedIndexChanged += (sender, e) => ComboCategs_Click?.Invoke(sender, e);
        listItems.SelectedIndexChanged += (sender, e) => ListItems_Click?.Invoke(sender, e);
    }

    public void AddComboCategs(string categ)
    {
        comboCategs.Items.Add(categ);
        comboCategItem.Items.Add(categ);
    }

    public void RemoveComboCategs(string categ)
    {
        comboCategs.Items.Remove(categ);
        comboCategItem.Items.Remove(categ);
    }

    public void AddListItems(string prod)
    {
        listItems.Items.Add(prod);
    }

    /*public void RemoveListItems(string prod)
    {
        listItems.Items.Remove(prod);
    }*/
    public void RemoveListItems(string prod)
    {
        listItems.Items.Remove(prod);
    }
    public void ClearListItems()
    {
        listItems.Items.Clear();
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        listItems = new ListBox();
        tableLayoutPanel3 = new TableLayoutPanel();
        comboCategs = new ComboBox();
        tableLayoutPanel4 = new TableLayoutPanel();
        addCateg = new Button();
        remCateg = new Button();
        tableLayoutPanel5 = new TableLayoutPanel();
        textBoxDesc = new TextBox();
        labelCateg = new Label();
        tableLayoutPanel7 = new TableLayoutPanel();
        comboCategItem = new ComboBox();
        labelName = new Label();
        tableLayoutPanel8 = new TableLayoutPanel();
        textBoxName = new TextBox();
        tableLayoutPanel9 = new TableLayoutPanel();
        numericPrice = new NumericUpDown();
        labelDesc = new Label();
        labelPrice = new Label();
        tableLayoutPanel6 = new TableLayoutPanel();
        btnRemProd = new Button();
        btnAddProd = new Button();
        btnUpdateProd = new Button();
        contextMenuStrip1 = new ContextMenuStrip(components);
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        tableLayoutPanel8.SuspendLayout();
        tableLayoutPanel9.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
        tableLayoutPanel6.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.2400742F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.7599258F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(570, 496);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(listItems, 0, 1);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.606679F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 92.39332F));
        tableLayoutPanel2.Size = new Size(206, 490);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // listItems
        // 
        listItems.Dock = DockStyle.Fill;
        listItems.FormattingEnabled = true;
        listItems.ItemHeight = 15;
        listItems.Location = new Point(3, 40);
        listItems.Name = "listItems";
        listItems.Size = new Size(200, 447);
        listItems.TabIndex = 0;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.8888855F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.11111F));
        tableLayoutPanel3.Controls.Add(comboCategs, 0, 0);
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new Size(200, 31);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // comboCategs
        // 
        comboCategs.Dock = DockStyle.Fill;
        comboCategs.FormattingEnabled = true;
        comboCategs.Location = new Point(3, 3);
        comboCategs.Name = "comboCategs";
        comboCategs.Size = new Size(141, 23);
        comboCategs.TabIndex = 1;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(addCateg, 0, 0);
        tableLayoutPanel4.Controls.Add(remCateg, 1, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(150, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new Size(47, 25);
        tableLayoutPanel4.TabIndex = 2;
        // 
        // addCateg
        // 
        addCateg.Dock = DockStyle.Fill;
        addCateg.Location = new Point(3, 3);
        addCateg.Name = "addCateg";
        addCateg.Size = new Size(17, 19);
        addCateg.TabIndex = 1;
        addCateg.Text = "+";
        addCateg.UseVisualStyleBackColor = true;
        // 
        // remCateg
        // 
        remCateg.Dock = DockStyle.Fill;
        remCateg.Location = new Point(26, 3);
        remCateg.Name = "remCateg";
        remCateg.Size = new Size(18, 19);
        remCateg.TabIndex = 2;
        remCateg.Text = "-";
        remCateg.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 2;
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.23313F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.76687F));
        tableLayoutPanel5.Controls.Add(textBoxDesc, 1, 2);
        tableLayoutPanel5.Controls.Add(labelCateg, 0, 0);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 1, 0);
        tableLayoutPanel5.Controls.Add(labelName, 0, 1);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 1, 1);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel9, 1, 3);
        tableLayoutPanel5.Controls.Add(labelDesc, 0, 2);
        tableLayoutPanel5.Controls.Add(labelPrice, 0, 3);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 4);
        tableLayoutPanel5.Dock = DockStyle.Fill;
        tableLayoutPanel5.Location = new Point(215, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 5;
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel5.Size = new Size(352, 490);
        tableLayoutPanel5.TabIndex = 1;
        tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
        // 
        // textBoxDesc
        // 
        textBoxDesc.Dock = DockStyle.Fill;
        textBoxDesc.Location = new Point(88, 198);
        textBoxDesc.Multiline = true;
        textBoxDesc.Name = "textBoxDesc";
        textBoxDesc.Size = new Size(261, 91);
        textBoxDesc.TabIndex = 0;
        // 
        // labelCateg
        // 
        labelCateg.AutoSize = true;
        labelCateg.Dock = DockStyle.Fill;
        labelCateg.Location = new Point(3, 0);
        labelCateg.Name = "labelCateg";
        labelCateg.Size = new Size(79, 98);
        labelCateg.TabIndex = 1;
        labelCateg.Text = "Categoria: ";
        labelCateg.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel7.Controls.Add(comboCategItem, 0, 1);
        tableLayoutPanel7.Dock = DockStyle.Fill;
        tableLayoutPanel7.Location = new Point(88, 3);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 3;
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel7.Size = new Size(261, 92);
        tableLayoutPanel7.TabIndex = 3;
        // 
        // comboCategItem
        // 
        comboCategItem.Dock = DockStyle.Fill;
        comboCategItem.DropDownStyle = ComboBoxStyle.DropDownList;
        comboCategItem.FormattingEnabled = true;
        comboCategItem.Location = new Point(3, 33);
        comboCategItem.Name = "comboCategItem";
        comboCategItem.Size = new Size(255, 23);
        comboCategItem.TabIndex = 2;
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Dock = DockStyle.Fill;
        labelName.Location = new Point(3, 98);
        labelName.Name = "labelName";
        labelName.Size = new Size(79, 97);
        labelName.TabIndex = 4;
        labelName.Text = "Nombre:";
        labelName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 1;
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel8.Controls.Add(textBoxName, 0, 1);
        tableLayoutPanel8.Dock = DockStyle.Fill;
        tableLayoutPanel8.Location = new Point(88, 101);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 3;
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel8.Size = new Size(261, 91);
        tableLayoutPanel8.TabIndex = 6;
        tableLayoutPanel8.Paint += tableLayoutPanel8_Paint;
        // 
        // textBoxName
        // 
        textBoxName.Dock = DockStyle.Fill;
        textBoxName.Location = new Point(3, 33);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(255, 23);
        textBoxName.TabIndex = 5;
        // 
        // tableLayoutPanel9
        // 
        tableLayoutPanel9.ColumnCount = 1;
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel9.Controls.Add(numericPrice, 0, 1);
        tableLayoutPanel9.Dock = DockStyle.Fill;
        tableLayoutPanel9.Location = new Point(88, 295);
        tableLayoutPanel9.Name = "tableLayoutPanel9";
        tableLayoutPanel9.RowCount = 3;
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel9.Size = new Size(261, 91);
        tableLayoutPanel9.TabIndex = 7;
        // 
        // numericPrice
        // 
        numericPrice.Dock = DockStyle.Left;
        numericPrice.Location = new Point(3, 33);
        numericPrice.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numericPrice.Name = "numericPrice";
        numericPrice.Size = new Size(120, 23);
        numericPrice.TabIndex = 0;
        // 
        // labelDesc
        // 
        labelDesc.AutoSize = true;
        labelDesc.Dock = DockStyle.Fill;
        labelDesc.Location = new Point(3, 195);
        labelDesc.Name = "labelDesc";
        labelDesc.Size = new Size(79, 97);
        labelDesc.TabIndex = 10;
        labelDesc.Text = "Descripcion:";
        labelDesc.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Dock = DockStyle.Fill;
        labelPrice.Location = new Point(3, 292);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(79, 97);
        labelPrice.TabIndex = 11;
        labelPrice.Text = "Precio:";
        labelPrice.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 3;
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel6.Controls.Add(btnRemProd, 2, 1);
        tableLayoutPanel6.Controls.Add(btnAddProd, 1, 1);
        tableLayoutPanel6.Controls.Add(btnUpdateProd, 0, 1);
        tableLayoutPanel6.Dock = DockStyle.Right;
        tableLayoutPanel6.Location = new Point(129, 392);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 2;
        tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel6.Size = new Size(220, 95);
        tableLayoutPanel6.TabIndex = 0;
        // 
        // btnRemProd
        // 
        btnRemProd.Dock = DockStyle.Bottom;
        btnRemProd.Location = new Point(149, 69);
        btnRemProd.Name = "btnRemProd";
        btnRemProd.Size = new Size(68, 23);
        btnRemProd.TabIndex = 1;
        btnRemProd.Text = "Borrar";
        btnRemProd.UseVisualStyleBackColor = true;
        // 
        // btnAddProd
        // 
        btnAddProd.Dock = DockStyle.Bottom;
        btnAddProd.Location = new Point(76, 69);
        btnAddProd.Name = "btnAddProd";
        btnAddProd.Size = new Size(67, 23);
        btnAddProd.TabIndex = 0;
        btnAddProd.Text = "Añadir";
        btnAddProd.UseVisualStyleBackColor = true;
        // 
        // btnUpdateProd
        // 
        btnUpdateProd.Dock = DockStyle.Bottom;
        btnUpdateProd.Location = new Point(3, 69);
        btnUpdateProd.Name = "btnUpdateProd";
        btnUpdateProd.Size = new Size(67, 23);
        btnUpdateProd.TabIndex = 2;
        btnUpdateProd.Text = "Actualizar";
        btnUpdateProd.UseVisualStyleBackColor = true;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(570, 496);
        Controls.Add(tableLayoutPanel1);
        Name = "MainView";
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel8.ResumeLayout(false);
        tableLayoutPanel8.PerformLayout();
        tableLayoutPanel9.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
        tableLayoutPanel6.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private ListBox listItems;
    private ComboBox comboCategs;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel4;
    private Button addCateg;
    private Button remCateg;
    private TableLayoutPanel tableLayoutPanel5;
    private TableLayoutPanel tableLayoutPanel6;
    private Button btnAddProd;
    private Button btnRemProd;
    private Label labelCateg;
    private TableLayoutPanel tableLayoutPanel7;
    private ComboBox comboCategItem;
    private Label labelName;
    private TextBox textBoxName;
    private TableLayoutPanel tableLayoutPanel8;
    private TableLayoutPanel tableLayoutPanel9;
    private TextBox textBoxDesc;
    private Label labelDesc;
    private Label labelPrice;
    private ContextMenuStrip contextMenuStrip1;
    private NumericUpDown numericPrice;
    private Button btnUpdateProd;
}
