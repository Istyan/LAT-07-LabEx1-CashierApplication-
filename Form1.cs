namespace CashierApplication
{
    public partial class frmPurchaseDiscountItem : Form
    {
        public frmPurchaseDiscountItem()
        {
            InitializeComponent();
        }
        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Item(string name, double price)
            {
                Name = name;
                Price = price;

            }
        }
        public class DiscountedItem : Item
        {
            public double Discount { get; set; }

            public DiscountedItem(string name, double price, double discount) : base(name, price)
            {
                Discount = discount;
            }

            public double GetDiscountedPrice()
            {
                double discountAmount = Discount * 0.01 * Price;
                return Price - discountAmount;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = textItem.Text;
                double price = Convert.ToDouble(textPrice.Text);
                double discount = Convert.ToDouble(textDiscount.Text);
                int quantity = Convert.ToInt32(textQuantity.Text);

                DiscountedItem discountedItem = new DiscountedItem(itemName, price, discount);

                double discountedPrice = discountedItem.GetDiscountedPrice();
                double totalAmount = discountedPrice * quantity;

                labelTotal.Text = $" {totalAmount:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = textItem.Text;
                double price = Convert.ToDouble(textPrice.Text);
                double discount = Convert.ToDouble(textDiscount.Text);
                int quantity = Convert.ToInt32(textQuantity.Text);
                double payment = Convert.ToDouble(textPayment.Text);

                DiscountedItem discountedItem = new DiscountedItem(itemName, price, discount);

                double discountedPrice = discountedItem.GetDiscountedPrice();
                double totalAmount = discountedPrice * quantity;

                double change = payment - totalAmount;

                labelChange.Text = $"Change: {change:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
