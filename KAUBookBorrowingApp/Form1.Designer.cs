namespace KAUBookBorrowingApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnTestLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("HYGothic-Extra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(155, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(607, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KAU Engineering Textbook Borrowing System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 19;
            this.lstBooks.Location = new System.Drawing.Point(18, 151);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBooks.Size = new System.Drawing.Size(270, 175);
            this.lstBooks.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtQuantity.Location = new System.Drawing.Point(40, 404);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(214, 27);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Green;
            this.btnAddToCart.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToCart.Location = new System.Drawing.Point(18, 448);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(277, 52);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Green;
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(465, 362);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(281, 69);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 19;
            this.lstCart.Location = new System.Drawing.Point(465, 151);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(281, 175);
            this.lstCart.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(36, 362);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(164, 24);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Enter Quantity:";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnTestLocation
            // 
            this.btnTestLocation.BackColor = System.Drawing.Color.Green;
            this.btnTestLocation.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTestLocation.Location = new System.Drawing.Point(465, 471);
            this.btnTestLocation.Name = "btnTestLocation";
            this.btnTestLocation.Size = new System.Drawing.Size(281, 65);
            this.btnTestLocation.TabIndex = 7;
            this.btnTestLocation.Text = "Test Location";
            this.btnTestLocation.UseVisualStyleBackColor = false;
            this.btnTestLocation.Click += new System.EventHandler(this.btnTestLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cart Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "List of Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KAUBookBorrowingApp.Properties.Resources._77dfbb5e_64f5_4931_8e07_fbd2a11c959c;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestLocation);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "TextBook Store";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTestLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

