namespace Mask
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtShortcutKeyAddress = new System.Windows.Forms.TextBox();
            this.txtShortcutKeyCardNumber = new System.Windows.Forms.TextBox();
            this.txtShortcutKeyPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtShortcutKeyName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearText = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 255);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "方案一";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtShortcutKeyAddress);
            this.groupBox2.Controls.Add(this.txtShortcutKeyCardNumber);
            this.groupBox2.Controls.Add(this.txtShortcutKeyPhoneNumber);
            this.groupBox2.Controls.Add(this.txtShortcutKeyName);
            this.groupBox2.Location = new System.Drawing.Point(300, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "快捷键";
            // 
            // txtShortcutKeyAddress
            // 
            this.txtShortcutKeyAddress.Enabled = false;
            this.txtShortcutKeyAddress.Location = new System.Drawing.Point(4, 143);
            this.txtShortcutKeyAddress.Name = "txtShortcutKeyAddress";
            this.txtShortcutKeyAddress.Size = new System.Drawing.Size(117, 21);
            this.txtShortcutKeyAddress.TabIndex = 9;
            this.txtShortcutKeyAddress.Text = "F4";
            // 
            // txtShortcutKeyCardNumber
            // 
            this.txtShortcutKeyCardNumber.Enabled = false;
            this.txtShortcutKeyCardNumber.Location = new System.Drawing.Point(4, 98);
            this.txtShortcutKeyCardNumber.Name = "txtShortcutKeyCardNumber";
            this.txtShortcutKeyCardNumber.Size = new System.Drawing.Size(117, 21);
            this.txtShortcutKeyCardNumber.TabIndex = 8;
            this.txtShortcutKeyCardNumber.Text = "F3";
            // 
            // txtShortcutKeyPhoneNumber
            // 
            this.txtShortcutKeyPhoneNumber.Enabled = false;
            this.txtShortcutKeyPhoneNumber.Location = new System.Drawing.Point(4, 58);
            this.txtShortcutKeyPhoneNumber.Name = "txtShortcutKeyPhoneNumber";
            this.txtShortcutKeyPhoneNumber.Size = new System.Drawing.Size(117, 21);
            this.txtShortcutKeyPhoneNumber.TabIndex = 7;
            this.txtShortcutKeyPhoneNumber.Text = "F2";
            // 
            // txtShortcutKeyName
            // 
            this.txtShortcutKeyName.Enabled = false;
            this.txtShortcutKeyName.Location = new System.Drawing.Point(4, 18);
            this.txtShortcutKeyName.Name = "txtShortcutKeyName";
            this.txtShortcutKeyName.Size = new System.Drawing.Size(117, 21);
            this.txtShortcutKeyName.TabIndex = 6;
            this.txtShortcutKeyName.Text = "F1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtCardNumber);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(59, 143);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(203, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(59, 98);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(203, 21);
            this.txtCardNumber.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(59, 58);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(203, 21);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 21);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "详细地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "身份证号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "电话";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(12, 285);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(75, 23);
            this.btnClearText.TabIndex = 1;
            this.btnClearText.Text = "清空文本";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "导出数据";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(147, 285);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "导入数据";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 320);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MaskShield";
            this.Activated += new System.EventHandler(this.frmActivated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.frm_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtShortcutKeyAddress;
        private System.Windows.Forms.TextBox txtShortcutKeyCardNumber;
        private System.Windows.Forms.TextBox txtShortcutKeyPhoneNumber;
        private System.Windows.Forms.TextBox txtShortcutKeyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Timer timer1;
    }
}

