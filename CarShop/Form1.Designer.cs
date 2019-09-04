namespace CarShop
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbx_cars = new System.Windows.Forms.ListBox();
            this.lstbx_cart = new System.Windows.Forms.ListBox();
            this.btn_addCar = new System.Windows.Forms.Button();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.txtbx_make = new System.Windows.Forms.TextBox();
            this.lbl_make = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.txtbx_model = new System.Windows.Forms.TextBox();
            this.txtbx_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbx_cars
            // 
            this.lstbx_cars.FormattingEnabled = true;
            this.lstbx_cars.ItemHeight = 31;
            this.lstbx_cars.Location = new System.Drawing.Point(546, 167);
            this.lstbx_cars.Name = "lstbx_cars";
            this.lstbx_cars.Size = new System.Drawing.Size(444, 345);
            this.lstbx_cars.TabIndex = 0;
            // 
            // lstbx_cart
            // 
            this.lstbx_cart.FormattingEnabled = true;
            this.lstbx_cart.ItemHeight = 31;
            this.lstbx_cart.Location = new System.Drawing.Point(1222, 167);
            this.lstbx_cart.Name = "lstbx_cart";
            this.lstbx_cart.Size = new System.Drawing.Size(444, 345);
            this.lstbx_cart.TabIndex = 1;
            // 
            // btn_addCar
            // 
            this.btn_addCar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_addCar.Location = new System.Drawing.Point(182, 422);
            this.btn_addCar.Name = "btn_addCar";
            this.btn_addCar.Size = new System.Drawing.Size(311, 90);
            this.btn_addCar.TabIndex = 2;
            this.btn_addCar.Text = "Create New Car";
            this.btn_addCar.UseVisualStyleBackColor = false;
            this.btn_addCar.Click += new System.EventHandler(this.btn_addCar_Click);
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.BackColor = System.Drawing.SystemColors.Window;
            this.btn_addToCart.Location = new System.Drawing.Point(1035, 294);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(142, 90);
            this.btn_addToCart.TabIndex = 3;
            this.btn_addToCart.Text = "Add to Cart";
            this.btn_addToCart.UseVisualStyleBackColor = false;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // txtbx_make
            // 
            this.txtbx_make.Location = new System.Drawing.Point(182, 164);
            this.txtbx_make.Name = "txtbx_make";
            this.txtbx_make.Size = new System.Drawing.Size(310, 38);
            this.txtbx_make.TabIndex = 4;
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Location = new System.Drawing.Point(46, 167);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(92, 32);
            this.lbl_make.TabIndex = 5;
            this.lbl_make.Text = "Make:";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(35, 245);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(101, 32);
            this.lbl_model.TabIndex = 6;
            this.lbl_model.Text = "Model:";
            // 
            // txtbx_model
            // 
            this.txtbx_model.Location = new System.Drawing.Point(182, 241);
            this.txtbx_model.Name = "txtbx_model";
            this.txtbx_model.Size = new System.Drawing.Size(310, 38);
            this.txtbx_model.TabIndex = 7;
            // 
            // txtbx_price
            // 
            this.txtbx_price.Location = new System.Drawing.Point(182, 317);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.Size = new System.Drawing.Size(310, 38);
            this.txtbx_price.TabIndex = 9;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(49, 323);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(88, 32);
            this.lbl_price.TabIndex = 8;
            this.lbl_price.Text = "Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1802, 655);
            this.Controls.Add(this.txtbx_price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txtbx_model);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_make);
            this.Controls.Add(this.txtbx_make);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.btn_addCar);
            this.Controls.Add(this.lstbx_cart);
            this.Controls.Add(this.lstbx_cars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_cars;
        private System.Windows.Forms.ListBox lstbx_cart;
        private System.Windows.Forms.Button btn_addCar;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.TextBox txtbx_make;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.TextBox txtbx_model;
        private System.Windows.Forms.TextBox txtbx_price;
        private System.Windows.Forms.Label lbl_price;
    }
}

