using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWinFormDemo.Assignment
{
    public partial class OrderMenuList : Form
    {
        public OrderMenuList()
        {
            InitializeComponent();
        }

        private void OrderMenuList_Load(object sender, EventArgs e)
        {
            PopulateMenuList();
            InitializeListOrder();
        }

        private void InitializeListOrder()
        {
            this.ListOrder.Items.Clear();
            this.ListOrder.ValueMember = "OrderItemId";
            this.ListOrder.DisplayMember = "GetOrderItemDetail";
        }

        private void PopulateMenuList()
        {
            ListMenu.Items.Clear();
            ListMenu.ValueMember = "ItemId";
            ListMenu.DisplayMember = "GetItemDetail";

            MenuRepo MenuList = new MenuRepo();
            ListMenu.Items.AddRange(MenuList.GetAllMenuItems().ToArray());

            //List<Menu> MenuList = new List<Menu>();
            //MenuList.Add(new Menu(102, "Chicken Burger", 200));
            //MenuList.Add(new Menu(103, "Zinger Burger", 280));
            //MenuList.Add(new Menu(104, "Crispy Zinger Burger with Extra Cheese", 320));
            //MenuList.Add(new Menu(105, "Quarter Braost", 280));
            //MenuList.Add(new Menu(106, "Chicken Tikka Chest", 270));
            //MenuList.Add(new Menu(107, "Chicken Tikka Leg", 280));
            //MenuList.Add(new Menu(108, "Chicken Biryani (1 Plate)", 120));
            //MenuList.Add(new Menu(109, "Chicken Biryani (1/5 Kg)", 400));
            //MenuList.Add(new Menu(110, "Chicken Biryani (1 Kg)", 800));
            //MenuList.Add(new Menu(111, "Chicken Shawrma", 80));
            //MenuList.Add(new Menu(112, "Chicken Shawrma Extra Loaded", 140));
            //MenuList.Add(new Menu(113, "Zinger Roll", 100));
            //MenuList.Add(new Menu(114, "Zinger Mayo Roll", 120));
            //MenuList.Add(new Menu(115, "Chicken Roll", 100));
            //MenuList.Add(new Menu(116, "BBQ Roll", 120));
            //MenuList.Add(new Menu(117, "Cold Drink (Can)", 80));
            //MenuList.Add(new Menu(118, "Cold Drink (Regular)", 60));
            //MenuList.Add(new Menu(119, "Cold Drink (1 Litre)", 100));
            //MenuList.Add(new Menu(120, "Cold Drink (1.5 Litre)", 110));
            //MenuList.Add(new Menu(121, "Cold Drink (Jumbo)", 125));
            //MenuList.Add(new Menu(122, "Mineral Water (Regular)", 70));
            //MenuList.Add(new Menu(123, "Mineral Water (1 Litre)", 100));
            //MenuList.Add(new Menu(124, "Mineral Water (1.5 Litre)", 115));
            
            //foreach (Menu MList in MenuList.GetAllMenuItems())
            //{
            //    ListMenu.Items.Add(MList);
            //}

        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (this.ListMenu.SelectedIndex >= 0)
            {
                List<Order> ListOrderItems = new List<Order>();
                int Qty = (int)this.Qty.Value;
                int Id;
                string Name;
                float Price;
                float TPrice;
                //Order OrderItem;

                foreach (Menu SelectedOrderItem in ListMenu.SelectedItems)
                {
                    Id = ((Menu)(SelectedOrderItem)).ItemId;
                    Name = ((Menu)(SelectedOrderItem)).ItemName;
                    Price = ((Menu)(SelectedOrderItem)).ItemPrice;
                    TPrice = Price * Qty;

                    this.ListOrder.Items.Add(new Order(Id, Name, Price, Qty, TPrice));


                    //this.ListOrder.Items.Add(OrderItem.GetOrderItemDetail);

                    //ListOrderItems.Add(new Order(Id, Name, Price, Qty));
                }

                //foreach (Order OrderItem in ListOrderItems)
                //{
                //    this.ListOrder.Items.Add(OrderItem.GetOrderItemDetail);
                //}

                this.ListMenu.ClearSelected();
                UpdateOrderSummary();

                //this.Qty.Value = 1;


            }
        }

        private void UpdateOrderSummary()
        {
            this.TxtItemCount.Text = OrderCount().ToString();
            this.TxtTotPrice.Text = OrderTotalPrice().ToString() + " PKR";
            this.TxtTotQty.Text = OrderTotalQty().ToString();
        }

        private int OrderCount()
        {
            return this.ListOrder.Items.Count;
        }

        private float OrderTotalPrice()
        {
            float TotalOrderPrice = 0;
            
            foreach(Order MyOrder in this.ListOrder.Items)
            {
                TotalOrderPrice += MyOrder.OrderItemTotalPrice;
            }

            return TotalOrderPrice; 
        }

        private int OrderTotalQty()
        {
            int TotalQty = 0;

            foreach (Order MyOrder in this.ListOrder.Items)
            {
                TotalQty += MyOrder.OrderItemQty;
            }

            return TotalQty;
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            foreach(int LOrder in ListOrder.SelectedIndices)
            {
                ListOrder.Items.RemoveAt(LOrder);
            }
            UpdateOrderSummary();

        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            ListOrder.Items.Clear();
            UpdateOrderSummary();
        }
    }

    public class Menu
    {
        public Menu(int Id, string Name, float Price)
        {
            this.ItemId = Id;
            this.ItemName = Name;
            this.ItemPrice = Price;
        }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public float ItemPrice { get; set; }

        public string GetItemDetail
        {
            get
            {
                return $"{this.ItemId}  -  {this.ItemName}  -  {this.ItemPrice}";
            }
        }

        

    }

    public class MenuRepo
    {

        public List<Menu> GetAllMenuItems()
        {
            List<Menu> MenuList = new List<Menu>();
            MenuList.Add(new Menu(102, "Chicken Burger", 200));
            MenuList.Add(new Menu(103, "Zinger Burger", 280));
            MenuList.Add(new Menu(104, "Crispy Zinger Burger with Extra Cheese", 320));
            MenuList.Add(new Menu(105, "Quarter Braost", 280));
            MenuList.Add(new Menu(106, "Chicken Tikka Chest", 270));
            MenuList.Add(new Menu(107, "Chicken Tikka Leg", 280));
            MenuList.Add(new Menu(108, "Chicken Biryani (1 Plate)", 120));
            MenuList.Add(new Menu(109, "Chicken Biryani (1/5 Kg)", 400));
            MenuList.Add(new Menu(110, "Chicken Biryani (1 Kg)", 800));
            MenuList.Add(new Menu(111, "Chicken Shawrma", 80));
            MenuList.Add(new Menu(112, "Chicken Shawrma Extra Loaded", 140));
            MenuList.Add(new Menu(113, "Zinger Roll", 100));
            MenuList.Add(new Menu(114, "Zinger Mayo Roll", 120));
            MenuList.Add(new Menu(115, "Chicken Roll", 100));
            MenuList.Add(new Menu(116, "BBQ Roll", 120));
            MenuList.Add(new Menu(117, "Cold Drink (Can)", 80));
            MenuList.Add(new Menu(118, "Cold Drink (Regular)", 60));
            MenuList.Add(new Menu(119, "Cold Drink (1 Litre)", 100));
            MenuList.Add(new Menu(120, "Cold Drink (1.5 Litre)", 110));
            MenuList.Add(new Menu(121, "Cold Drink (Jumbo)", 125));
            MenuList.Add(new Menu(122, "Mineral Water (Regular)", 70));
            MenuList.Add(new Menu(123, "Mineral Water (1 Litre)", 100));
            MenuList.Add(new Menu(124, "Mineral Water (1.5 Litre)", 115));

            return MenuList;
        }
    }

    public class Order
    {
        public Order(int Id, string Name, float Price, int Qty, float TPrice)
        {
            this.OrderItemId = Id;
            this.OrderItemName = Name;
            this.OrderItemPrice = Price;
            this.OrderItemQty = Qty;
            this.OrderItemTotalPrice = TPrice;
            ItemCount++;     
        }

        static int ItemCount = 0;
        public int OrderItemId { get; set; }
        public string OrderItemName { get; set; }
        public float OrderItemPrice { get; set; }
        public int OrderItemQty { get; set; }
        public float OrderItemTotalPrice { get; set; }
        public string GetOrderItemDetail
        {
            get
            {
                return $"{this.OrderItemId}  -  {this.OrderItemName}  -  {this.OrderItemPrice} PKR  -  {this.OrderItemQty} Qty  -  Total {this.OrderItemTotalPrice} PKR";
            }
        }

        public int Count
        {
            get
            {
                return ItemCount;
            }
        }
    }
}
