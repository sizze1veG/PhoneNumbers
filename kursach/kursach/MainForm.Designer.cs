namespace kursach
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxAddName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxAddPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBoxPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonPrice = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonInfo = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер телефона";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Location = new System.Drawing.Point(590, 165);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = false;
            this.buttonAdd.Size = new System.Drawing.Size(147, 36);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить данные";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(440, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Имя";
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.BackColor = System.Drawing.Color.White;
            this.textBoxAddName.Depth = 0;
            this.textBoxAddName.Hint = "";
            this.textBoxAddName.Location = new System.Drawing.Point(348, 134);
            this.textBoxAddName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.PasswordChar = '\0';
            this.textBoxAddName.SelectedText = "";
            this.textBoxAddName.SelectionLength = 0;
            this.textBoxAddName.SelectionStart = 0;
            this.textBoxAddName.Size = new System.Drawing.Size(219, 23);
            this.textBoxAddName.TabIndex = 3;
            this.textBoxAddName.UseSystemPasswordChar = false;
            this.textBoxAddName.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(396, 184);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Номер телефона";
            // 
            // textBoxAddPhone
            // 
            this.textBoxAddPhone.BackColor = System.Drawing.Color.White;
            this.textBoxAddPhone.Depth = 0;
            this.textBoxAddPhone.Hint = "";
            this.textBoxAddPhone.Location = new System.Drawing.Point(348, 206);
            this.textBoxAddPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAddPhone.Name = "textBoxAddPhone";
            this.textBoxAddPhone.PasswordChar = '\0';
            this.textBoxAddPhone.SelectedText = "";
            this.textBoxAddPhone.SelectionLength = 0;
            this.textBoxAddPhone.SelectionStart = 0;
            this.textBoxAddPhone.Size = new System.Drawing.Size(219, 23);
            this.textBoxAddPhone.TabIndex = 5;
            this.textBoxAddPhone.UseSystemPasswordChar = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.Location = new System.Drawing.Point(598, 284);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Primary = false;
            this.buttonDelete.Size = new System.Drawing.Size(139, 36);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить данные";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.Depth = 0;
            this.textBoxPhone.Hint = "";
            this.textBoxPhone.Location = new System.Drawing.Point(348, 384);
            this.textBoxPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.SelectionLength = 0;
            this.textBoxPhone.SelectionStart = 0;
            this.textBoxPhone.Size = new System.Drawing.Size(219, 23);
            this.textBoxPhone.TabIndex = 7;
            this.textBoxPhone.UseSystemPasswordChar = false;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.White;
            this.textBoxTime.Depth = 0;
            this.textBoxTime.Hint = "";
            this.textBoxTime.Location = new System.Drawing.Point(348, 455);
            this.textBoxTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.PasswordChar = '\0';
            this.textBoxTime.SelectedText = "";
            this.textBoxTime.SelectionLength = 0;
            this.textBoxTime.SelectionStart = 0;
            this.textBoxTime.Size = new System.Drawing.Size(219, 23);
            this.textBoxTime.TabIndex = 8;
            this.textBoxTime.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(396, 362);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(129, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Номер телефона";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(385, 433);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(173, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Время разговора (мин)";
            // 
            // buttonPrice
            // 
            this.buttonPrice.AutoSize = true;
            this.buttonPrice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPrice.Depth = 0;
            this.buttonPrice.Location = new System.Drawing.Point(574, 416);
            this.buttonPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Primary = false;
            this.buttonPrice.Size = new System.Drawing.Size(163, 36);
            this.buttonPrice.TabIndex = 11;
            this.buttonPrice.Text = "Вывести извещение";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Black;
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.Depth = 0;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.Location = new System.Drawing.Point(642, 25);
            this.buttonInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Primary = true;
            this.buttonInfo.Size = new System.Drawing.Size(108, 39);
            this.buttonInfo.TabIndex = 12;
            this.buttonInfo.Text = "о программе";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 535);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxAddPhone);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картотека абонентов";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MaterialSkin.Controls.MaterialFlatButton buttonAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAddName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAddPhone;
        private MaterialSkin.Controls.MaterialFlatButton buttonDelete;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton buttonPrice;
        private MaterialSkin.Controls.MaterialRaisedButton buttonInfo;
    }
}