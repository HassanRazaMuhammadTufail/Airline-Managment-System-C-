namespace sample_2
{
    partial class First_Custom_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.listitem = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fast Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(982, 853);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(38, 233);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Bar BQ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(362, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 29);
            this.label13.TabIndex = 30;
            this.label13.Text = "Roll";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(362, 171);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 29);
            this.label24.TabIndex = 41;
            this.label24.Text = "Pizzas";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.Maroon;
            this.label30.Location = new System.Drawing.Point(362, 321);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(124, 25);
            this.label30.TabIndex = 52;
            this.label30.Text = "Cold Drinks";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.DimGray;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.ForeColor = System.Drawing.Color.Maroon;
            this.confirm.Location = new System.Drawing.Point(659, 469);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(300, 31);
            this.confirm.TabIndex = 63;
            this.confirm.Text = "Order Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirmed_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.DimGray;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Chicken Tikkah(Leg)\tRs: 220",
            "Chicken Tikkah(Chest)\tRs: 200",
            "Green Malai Tikkah \tRs: 250",
            "Chicken Boti \t             Rs: 180",
            "Chicken Malai Boti \tRs: 200 ",
            "Kabab Plate \t             Rs: 280",
            "Gola Kabab Plate \tRs: 300",
            "Bihari Kabab Plate \tRs: 350 ",
            "Large Parhata \t             Rs: 50",
            "Small Parhata \t             Rs: 30\t"});
            this.checkedListBox2.Location = new System.Drawing.Point(43, 265);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(278, 210);
            this.checkedListBox2.TabIndex = 65;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BackColor = System.Drawing.Color.DimGray;
            this.checkedListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Chicken Boti               Rs: 100",
            "Chicken Garlic Mayo   Rs: 130",
            "Beef Boti                    Rs: 180",
            "Chicken Chapati         Rs: 90",
            "Kabab Chapati           Rs: 120  "});
            this.checkedListBox3.Location = new System.Drawing.Point(367, 52);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(286, 105);
            this.checkedListBox3.TabIndex = 66;
            this.checkedListBox3.SelectedIndexChanged += new System.EventHandler(this.checkedListBox3_SelectedIndexChanged);
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.BackColor = System.Drawing.Color.DimGray;
            this.checkedListBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "Bar BQ                  Rs: 999",
            "Hot and Spicy       Rs: 850",
            "Chicken Fajita       Rs: 700",
            "Chicken Lazania   Rs: 1200",
            "Chicken Cramy      Rs: 1500  "});
            this.checkedListBox4.Location = new System.Drawing.Point(367, 203);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(259, 105);
            this.checkedListBox4.TabIndex = 67;
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.BackColor = System.Drawing.Color.DimGray;
            this.checkedListBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Items.AddRange(new object[] {
            "String    Rs: 40\t",
            "Dew       Rs: 30",
            "7up        Rs: 30",
            "Coke      Rs: 30",
            "Pepsi     Rs: 30\t",
            "Fanta     Rs: 30"});
            this.checkedListBox5.Location = new System.Drawing.Point(367, 349);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(168, 126);
            this.checkedListBox5.TabIndex = 68;
            // 
            // OrderList
            // 
            this.OrderList.BackColor = System.Drawing.Color.DimGray;
            this.OrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderList.ForeColor = System.Drawing.Color.Black;
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 20;
            this.OrderList.Location = new System.Drawing.Point(659, 61);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(300, 402);
            this.OrderList.TabIndex = 69;
            // 
            // listitem
            // 
            this.listitem.BackColor = System.Drawing.Color.DimGray;
            this.listitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listitem.ForeColor = System.Drawing.Color.Maroon;
            this.listitem.Location = new System.Drawing.Point(659, 20);
            this.listitem.Name = "listitem";
            this.listitem.Size = new System.Drawing.Size(300, 35);
            this.listitem.TabIndex = 70;
            this.listitem.Text = "List items";
            this.listitem.UseVisualStyleBackColor = false;
            this.listitem.Click += new System.EventHandler(this.listitem_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.DimGray;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Zinger Burger            Rs:  200",
            "Beef Burger               Rs: 130",
            "Chicken Zinger          Rs: 180 ",
            "Quarter Broast          Rs: 220",
            "Spicy Quarter Broast Rs: 230",
            "French Fries               Rs: 50"});
            this.checkedListBox1.Location = new System.Drawing.Point(43, 74);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(278, 126);
            this.checkedListBox1.TabIndex = 71;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // First_Custom_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listitem);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.checkedListBox5);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "First_Custom_Control";
            this.Size = new System.Drawing.Size(1059, 535);
            this.Load += new System.EventHandler(this.First_Custom_Control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox5;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Button listitem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
