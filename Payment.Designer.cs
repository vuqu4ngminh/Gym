namespace GymManagementSystem
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PaymentDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSetPayment = new GymManagementSystem.GYMDataSetPayment();
            this.gYMDataSet = new GymManagementSystem.GYMDataSet();
            this.gYMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_paymentTableAdapter = new GymManagementSystem.GYMDataSetPaymentTableAdapters.tbl_paymentTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSetPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(427, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(43, 39);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 33);
            this.button3.TabIndex = 33;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(43, 438);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 32;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "Đặt Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentDGV
            // 
            this.PaymentDGV.AllowUserToAddRows = false;
            this.PaymentDGV.AllowUserToDeleteRows = false;
            this.PaymentDGV.AutoGenerateColumns = false;
            this.PaymentDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PaymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.offerDataGridViewTextBoxColumn,
            this.startAtDataGridViewTextBoxColumn,
            this.endAtDataGridViewTextBoxColumn});
            this.PaymentDGV.DataSource = this.tblpaymentBindingSource;
            this.PaymentDGV.Location = new System.Drawing.Point(345, 115);
            this.PaymentDGV.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentDGV.Name = "PaymentDGV";
            this.PaymentDGV.ReadOnly = true;
            this.PaymentDGV.RowHeadersWidth = 51;
            this.PaymentDGV.RowTemplate.Height = 24;
            this.PaymentDGV.Size = new System.Drawing.Size(653, 415);
            this.PaymentDGV.TabIndex = 36;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerDataGridViewTextBoxColumn
            // 
            this.offerDataGridViewTextBoxColumn.DataPropertyName = "offer";
            this.offerDataGridViewTextBoxColumn.HeaderText = "offer";
            this.offerDataGridViewTextBoxColumn.Name = "offerDataGridViewTextBoxColumn";
            this.offerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startAtDataGridViewTextBoxColumn
            // 
            this.startAtDataGridViewTextBoxColumn.DataPropertyName = "startAt";
            this.startAtDataGridViewTextBoxColumn.HeaderText = "startAt";
            this.startAtDataGridViewTextBoxColumn.Name = "startAtDataGridViewTextBoxColumn";
            this.startAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endAtDataGridViewTextBoxColumn
            // 
            this.endAtDataGridViewTextBoxColumn.DataPropertyName = "endAt";
            this.endAtDataGridViewTextBoxColumn.HeaderText = "endAt";
            this.endAtDataGridViewTextBoxColumn.Name = "endAtDataGridViewTextBoxColumn";
            this.endAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblpaymentBindingSource
            // 
            this.tblpaymentBindingSource.DataMember = "tbl_payment";
            this.tblpaymentBindingSource.DataSource = this.gYMDataSetPayment;
            // 
            // gYMDataSetPayment
            // 
            this.gYMDataSetPayment.DataSetName = "GYMDataSetPayment";
            this.gYMDataSetPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gYMDataSetBindingSource
            // 
            this.gYMDataSetBindingSource.DataSource = this.gYMDataSet;
            this.gYMDataSetBindingSource.Position = 0;
            // 
            // tbl_paymentTableAdapter
            // 
            this.tbl_paymentTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(43, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 33);
            this.textBox1.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Chọn Gói Dịch Vụ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 tháng",
            "3 tháng",
            "6 tháng",
            "12 tháng"});
            this.comboBox1.Location = new System.Drawing.Point(43, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 33);
            this.comboBox1.TabIndex = 39;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 536);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PaymentDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Payment";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSetPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView PaymentDGV;
        private System.Windows.Forms.BindingSource gYMDataSetBindingSource;
        private GYMDataSet gYMDataSet;
        private GYMDataSetPayment gYMDataSetPayment;
        private System.Windows.Forms.BindingSource tblpaymentBindingSource;
        private GYMDataSetPaymentTableAdapters.tbl_paymentTableAdapter tbl_paymentTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endAtDataGridViewTextBoxColumn;
    }
}