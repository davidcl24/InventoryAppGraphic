using InventoryAppGraphic.Models.Data_Classes;
using InventoryAppGraphic.Services;
using InventoryAppGraphic.Views;

namespace InventoryAppGraphic.Presenters;

public class MainPresenter
{
    private MainView mainView;
    private CategoryService categService;
    private ProductService prodService;

    public MainPresenter (MainView mainView, CategoryService categService, ProductService prodService)
    {
        this.mainView = mainView;
        this.categService = categService;
        this.prodService = prodService;

        mainView.AddCateg_Click += AddCategory;
        mainView.RemoveCateg_Click += RemoveCategory;
        mainView.AddProduct_Click += AddProduct;
        mainView.RemoveProduct_Click += RemoveProduct;
        mainView.ComboCategs_Click += GetCategory;
        mainView.ListItems_Click += GetProduct;
        mainView.UpdateProduct_Click += UpdateProduct;
    }

    public void AddProduct(object? sender, EventArgs e)
    {
        if (mainView.TextBoxName != "")
        {
            string sId = GetIDFromMainView(mainView.ComboCategItem);
            int id = int.Parse(sId);
            Product p = new(prodService.ProductId, mainView.TextBoxName, id, mainView.TextBoxDesc, mainView.NumericPrice);
            prodService.Add(p);
            Category c = new Category(categService.GetById(id).Id, categService.GetById(id).Name);
            c.Products = new List<Product>(categService.GetById(id).Products);
            c.Products.Add(p);
            UpdateCategory(c);
            ClearAll();
            prodService.ProductId++;
        }
        
    }

    public void RemoveProduct(object? sender, EventArgs e)
    {
        if (mainView.ListItems != "")
        {
            string sId = GetIDFromMainView(mainView.ListItems);
            int id = int.Parse(sId);
            int cId = prodService.GetById(id).CategoryId;
            Category c = new Category(categService.GetById(cId).Id, categService.GetById(cId).Name);
            c.Products = new List<Product>(categService.GetById(cId).Products);
            c.Products.Remove(prodService.GetById(id));
            UpdateCategory(c);
            prodService.Remove(id);
            mainView.RemoveListItems(mainView.ListItems);
            ClearAll();
        }
        
    }

    public void GetProduct(object? sender, EventArgs e)
    {
        if (mainView.ListItems != "")
        {
            string sId = GetIDFromMainView(mainView.ListItems);
            int id = int.Parse(sId);
            Product p = prodService.GetById(id);
            mainView.ComboCategItem = mainView.ComboCategs;
            mainView.NumericPrice = p.Price;
            mainView.TextBoxDesc = p.Description;
            mainView.TextBoxName = p.Name;
        }
    }

    public void GetAllProducts()
    {
        prodService.GetAll();
    }

    public void UpdateProduct(object? sender, EventArgs e)
    {
        if (mainView.ComboCategItem is not null && mainView.TextBoxName != "")
        {
            string sPid = GetIDFromMainView(mainView.ListItems);
            int pId = int.Parse(sPid);
            string sCid = GetIDFromMainView(mainView.ComboCategItem);
            int cId = int.Parse(sCid);
            int oldCId = prodService.GetById(pId).CategoryId;
            Product oldP = prodService.GetById(pId);
            Category oldC = new Category(categService.GetById(oldCId).Id, categService.GetById(oldCId).Name);
            oldC.Products = new List<Product>(categService.GetById(oldCId).Products);
            oldC.Products.Remove(oldP);
            UpdateCategory(oldC);
            Product newP = new Product(pId, mainView.TextBoxName, cId, mainView.TextBoxDesc, mainView.NumericPrice);
            prodService.Update(newP);
            Category newC = new Category(categService.GetById(cId).Id, categService.GetById(cId).Name);
            newC.Products.Add(newP);
            UpdateCategory(newC);
            GetCategory(sender, e);
        }
    }

    public void AddCategory(object? sender, EventArgs e)
    {
        categService.Add(new(categService.CategoryId, mainView.ComboCategs));
        string nameCateg = "[" + categService.CategoryId + "] " + mainView.ComboCategs;
        mainView.AddComboCategs(nameCateg);
        categService.CategoryId++;
        mainView.ComboCategs = "";
        mainView.ClearListItems();
    }

    public void RemoveCategory(object? sender, EventArgs e)
    {
        string sId = GetIDFromMainView(mainView.ComboCategs);
        int id = int.Parse(sId);
        categService.Remove(id);
        mainView.RemoveComboCategs(mainView.ComboCategs);
        mainView.ComboCategs = "";
        mainView.ComboCategItem = "";
    }

    public void GetCategory(object? sender, EventArgs e)
    {
        mainView.ClearListItems();
        string sId = GetIDFromMainView(mainView.ComboCategs);
        int id = int.Parse(sId);
        List<Product> products = categService.GetById(id).Products;
        string nameProd;
        foreach (Product p in products)
        {
            nameProd = "[" + p.Id + "]" + p.Name;
            mainView.AddListItems(nameProd);
        }
    }

    public void GetAllCategories()
    {
        categService.GetAll();
    }

    public void UpdateCategory(Category c) => categService.Update(c);

    public string GetIDFromMainView(string srcString)
    {

        int from = srcString.IndexOf("[")+1;
        int to = srcString.IndexOf("]")-1;
        string result = srcString.Substring(from, to);
        return result;
    }

    private void ClearAll()
    {
        mainView.TextBoxName = "";
        mainView.TextBoxDesc = "";
        mainView.ComboCategItem = null;
        mainView.NumericPrice = 0;
    }
}
