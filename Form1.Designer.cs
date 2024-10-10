namespace CashierApplication
{
    partial class frmPurchaseDiscountItem
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
            textItem = new TextBox();
            textDiscount = new TextBox();
            textPrice = new TextBox();
            textQuantity = new TextBox();
            textPayment = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelTotal = new Label();
            label7 = new Label();
            label8 = new Label();
            labelChange = new Label();
            SuspendLayout();
            // 
            // textItem
            // 
            textItem.Location = new Point(11, 35);
            textItem.Name = "textItem";
            textItem.Size = new Size(248, 27);
            textItem.TabIndex = 0;
            // 
            // textDiscount
            // 
            textDiscount.Location = new Point(265, 35);
            textDiscount.Name = "textDiscount";
            textDiscount.Size = new Size(151, 27);
            textDiscount.TabIndex = 1;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(70, 68);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(189, 27);
            textPrice.TabIndex = 2;
            // 
            // textQuantity
            // 
            textQuantity.Location = new Point(347, 67);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(69, 27);
            textQuantity.TabIndex = 3;
            // 
            // textPayment
            // 
            textPayment.Location = new Point(183, 199);
            textPayment.Name = "textPayment";
            textPayment.Size = new Size(138, 27);
            textPayment.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(150, 101);
            button1.Name = "button1";
            button1.Size = new Size(98, 30);
            button1.TabIndex = 5;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(327, 199);
            button2.Name = "button2";
            button2.Size = new Size(73, 29);
            button2.TabIndex = 6;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 7;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(265, 12);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 8;
            label2.Text = "Discount(%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 9;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(265, 68);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 10;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(60, 152);
            label5.Name = "label5";
            label5.Size = new Size(117, 23);
            label5.TabIndex = 11;
            label5.Text = "Total Amount:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 10F);
            labelTotal.Location = new Point(193, 152);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(55, 23);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(25, 200);
            label7.Name = "label7";
            label7.Size = new Size(152, 23);
            label7.TabIndex = 13;
            label7.Text = "Payment Received:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(104, 242);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 14;
            label8.Text = "Change:";
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Font = new Font("Segoe UI", 10F);
            labelChange.Location = new Point(193, 242);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(55, 23);
            labelChange.TabIndex = 15;
            labelChange.Text = "label9";
            // 
            // frmPurchaseDiscountItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 282);
            Controls.Add(labelChange);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(labelTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textPayment);
            Controls.Add(textQuantity);
            Controls.Add(textPrice);
            Controls.Add(textDiscount);
            Controls.Add(textItem);
            Name = "frmPurchaseDiscountItem";
            Text = "Purchase Discounted Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textItem;
        private TextBox textDiscount;
        private TextBox textPrice;
        private TextBox textQuantity;
        private TextBox textPayment;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelTotal;
        private Label label7;
        private Label label8;
        private Label labelChange;
    }
}
