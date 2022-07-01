namespace Chapter11
{
    partial class Form2
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
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.cbPosition = new System.Windows.Forms.ComboBox();
        this.label3 = new System.Windows.Forms.Label();
        this.btnPosition = new System.Windows.Forms.Button();
        this.lbResultPosition = new System.Windows.Forms.Label();
        this.lbResultHobby = new System.Windows.Forms.Label();
        this.btnHobby = new System.Windows.Forms.Button();
        this.label6 = new System.Windows.Forms.Label();
        this.cbHobby = new System.Windows.Forms.ComboBox();
        this.label4 = new System.Windows.Forms.Label();
        this.lstCountry = new System.Windows.Forms.ListBox();
        this.lbResultCountry = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.dgvMember = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(323, 30);
        this.label1.TabIndex = 0;
        this.label1.Text = "데이터를 공급해야 하는 컨트롤";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.label2.Location = new System.Drawing.Point(12, 58);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(97, 15);
        this.label2.TabIndex = 1;
        this.label2.Text = "ComboBox 연습";
        // 
        // cbPosition
        // 
        this.cbPosition.FormattingEnabled = true;
        this.cbPosition.Location = new System.Drawing.Point(59, 85);
        this.cbPosition.Name = "cbPosition";
        this.cbPosition.Size = new System.Drawing.Size(121, 23);
        this.cbPosition.TabIndex = 2;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(22, 88);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(31, 15);
        this.label3.TabIndex = 3;
        this.label3.Text = "직급";
        // 
        // btnPosition
        // 
        this.btnPosition.Location = new System.Drawing.Point(186, 85);
        this.btnPosition.Name = "btnPosition";
        this.btnPosition.Size = new System.Drawing.Size(75, 23);
        this.btnPosition.TabIndex = 4;
        this.btnPosition.Text = "확인";
        this.btnPosition.UseVisualStyleBackColor = true;
        this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
        // 
        // lbResultPosition
        // 
        this.lbResultPosition.AutoSize = true;
        this.lbResultPosition.Location = new System.Drawing.Point(267, 89);
        this.lbResultPosition.Name = "lbResultPosition";
        this.lbResultPosition.Size = new System.Drawing.Size(42, 15);
        this.lbResultPosition.TabIndex = 5;
        this.lbResultPosition.Text = "결과 : ";
        // 
        // lbResultHobby
        // 
        this.lbResultHobby.AutoSize = true;
        this.lbResultHobby.Location = new System.Drawing.Point(267, 118);
        this.lbResultHobby.Name = "lbResultHobby";
        this.lbResultHobby.Size = new System.Drawing.Size(42, 15);
        this.lbResultHobby.TabIndex = 9;
        this.lbResultHobby.Text = "결과 : ";
        // 
        // btnHobby
        // 
        this.btnHobby.Location = new System.Drawing.Point(186, 114);
        this.btnHobby.Name = "btnHobby";
        this.btnHobby.Size = new System.Drawing.Size(75, 23);
        this.btnHobby.TabIndex = 8;
        this.btnHobby.Text = "확인";
        this.btnHobby.UseVisualStyleBackColor = true;
        this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(22, 117);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(31, 15);
        this.label6.TabIndex = 7;
        this.label6.Text = "취미";
        // 
        // cbHobby
        // 
        this.cbHobby.FormattingEnabled = true;
        this.cbHobby.Location = new System.Drawing.Point(59, 114);
        this.cbHobby.Name = "cbHobby";
        this.cbHobby.Size = new System.Drawing.Size(121, 23);
        this.cbHobby.TabIndex = 6;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.label4.Location = new System.Drawing.Point(12, 163);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(76, 15);
        this.label4.TabIndex = 10;
        this.label4.Text = "ListBox 연습";
        // 
        // lstCountry
        // 
        this.lstCountry.FormattingEnabled = true;
        this.lstCountry.ItemHeight = 15;
        this.lstCountry.Location = new System.Drawing.Point(22, 181);
        this.lstCountry.Name = "lstCountry";
        this.lstCountry.Size = new System.Drawing.Size(158, 79);
        this.lstCountry.TabIndex = 11;
        this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
        // 
        // lbResultCountry
        // 
        this.lbResultCountry.AutoSize = true;
        this.lbResultCountry.Location = new System.Drawing.Point(186, 245);
        this.lbResultCountry.Name = "lbResultCountry";
        this.lbResultCountry.Size = new System.Drawing.Size(42, 15);
        this.lbResultCountry.TabIndex = 12;
        this.lbResultCountry.Text = "결과 : ";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.label5.Location = new System.Drawing.Point(12, 284);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(116, 15);
        this.label5.TabIndex = 13;
        this.label5.Text = "DataGridView 연습";
        // 
        // dgvMember
        // 
        this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvMember.Location = new System.Drawing.Point(21, 302);
        this.dgvMember.Name = "dgvMember";
        this.dgvMember.RowTemplate.Height = 25;
        this.dgvMember.Size = new System.Drawing.Size(446, 136);
        this.dgvMember.TabIndex = 14;
        this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        // 
        // Form2
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(479, 450);
        this.Controls.Add(this.dgvMember);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.lbResultCountry);
        this.Controls.Add(this.lstCountry);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.lbResultHobby);
        this.Controls.Add(this.btnHobby);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.cbHobby);
        this.Controls.Add(this.lbResultPosition);
        this.Controls.Add(this.btnPosition);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.cbPosition);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "Form2";
        this.Text = "Form2";
        this.Load += new System.EventHandler(this.Form2_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private ComboBox cbPosition;
    private Label label3;
    private Button btnPosition;
    private Label lbResultPosition;
    private Label lbResultHobby;
    private Button btnHobby;
    private Label label6;
    private ComboBox cbHobby;
    private Label label4;
    private ListBox lstCountry;
    private Label lbResultCountry;
    private Label label5;
    private DataGridView dgvMember;
}
}