namespace KB11301_UltraGridFilterByOutsidePanel_WinFormsApp1;

partial class Form1
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
        Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
        ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
        label1 = new Label();
        checkBox1 = new CheckBox();
        checkBox2 = new CheckBox();
        checkBox3 = new CheckBox();
        checkBox4 = new CheckBox();
        checkBox5 = new CheckBox();
        checkBox6 = new CheckBox();
        checkBox7 = new CheckBox();
        ((System.ComponentModel.ISupportInitialize)ultraGrid1).BeginInit();
        SuspendLayout();
        // 
        // ultraGrid1
        // 
        ultraGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        appearance11.BackColor = SystemColors.Window;
        appearance11.BorderColor = SystemColors.InactiveCaption;
        ultraGrid1.DisplayLayout.Appearance = appearance11;
        ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
        ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
        appearance111.BackColor = SystemColors.ActiveBorder;
        appearance111.BackColor2 = SystemColors.ControlDark;
        appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
        appearance111.BorderColor = SystemColors.Window;
        ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance111;
        appearance110.ForeColor = SystemColors.GrayText;
        ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance110;
        ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
        appearance112.BackColor = SystemColors.ControlLightLight;
        appearance112.BackColor2 = SystemColors.Control;
        appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
        appearance112.ForeColor = SystemColors.GrayText;
        ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance112;
        ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
        ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
        appearance19.BackColor = SystemColors.Window;
        appearance19.ForeColor = SystemColors.ControlText;
        ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance19;
        appearance14.BackColor = SystemColors.Highlight;
        appearance14.ForeColor = SystemColors.HighlightText;
        ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance14;
        ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
        ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
        appearance17.BackColor = SystemColors.Window;
        ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance17;
        appearance13.BorderColor = Color.Silver;
        appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
        ultraGrid1.DisplayLayout.Override.CellAppearance = appearance13;
        ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
        ultraGrid1.DisplayLayout.Override.CellPadding = 0;
        appearance16.BackColor = SystemColors.Control;
        appearance16.BackColor2 = SystemColors.ControlDark;
        appearance16.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
        appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
        appearance16.BorderColor = SystemColors.Window;
        ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance16;
        appearance18.TextHAlignAsString = "Left";
        ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance18;
        ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
        ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
        appearance15.BackColor = SystemColors.Window;
        appearance15.BorderColor = Color.Silver;
        ultraGrid1.DisplayLayout.Override.RowAppearance = appearance15;
        ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
        appearance12.BackColor = SystemColors.ControlLight;
        ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
        ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
        ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
        ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
        ultraGrid1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        ultraGrid1.Location = new Point(12, 94);
        ultraGrid1.Name = "ultraGrid1";
        ultraGrid1.Size = new Size(921, 344);
        ultraGrid1.TabIndex = 0;
        ultraGrid1.Text = "ultraGrid1";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 19);
        label1.Name = "label1";
        label1.Size = new Size(84, 25);
        label1.TabIndex = 1;
        label1.Text = "都道府県";
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Checked = true;
        checkBox1.CheckState = CheckState.Checked;
        checkBox1.Location = new Point(123, 19);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(92, 29);
        checkBox1.TabIndex = 2;
        checkBox1.Text = "茨城県";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += prefectureCheckBox_CheckedChanged;
        // 
        // checkBox2
        // 
        checkBox2.AutoSize = true;
        checkBox2.Checked = true;
        checkBox2.CheckState = CheckState.Checked;
        checkBox2.Location = new Point(221, 19);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new Size(92, 29);
        checkBox2.TabIndex = 3;
        checkBox2.Text = "栃木県";
        checkBox2.UseVisualStyleBackColor = true;
        checkBox2.CheckedChanged += prefectureCheckBox_CheckedChanged;
        // 
        // checkBox3
        // 
        checkBox3.AutoSize = true;
        checkBox3.Checked = true;
        checkBox3.CheckState = CheckState.Checked;
        checkBox3.Location = new Point(319, 19);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new Size(92, 29);
        checkBox3.TabIndex = 4;
        checkBox3.Text = "群馬県";
        checkBox3.UseVisualStyleBackColor = true;
        checkBox3.CheckedChanged += prefectureCheckBox_CheckedChanged;
        // 
        // checkBox4
        // 
        checkBox4.AutoSize = true;
        checkBox4.Checked = true;
        checkBox4.CheckState = CheckState.Checked;
        checkBox4.Location = new Point(417, 19);
        checkBox4.Name = "checkBox4";
        checkBox4.Size = new Size(92, 29);
        checkBox4.TabIndex = 5;
        checkBox4.Text = "埼玉県";
        checkBox4.UseVisualStyleBackColor = true;
        checkBox4.CheckedChanged += prefectureCheckBox_CheckedChanged;
        // 
        // checkBox5
        // 
        checkBox5.AutoSize = true;
        checkBox5.Checked = true;
        checkBox5.CheckState = CheckState.Checked;
        checkBox5.Location = new Point(515, 19);
        checkBox5.Name = "checkBox5";
        checkBox5.Size = new Size(92, 29);
        checkBox5.TabIndex = 6;
        checkBox5.Text = "千葉県";
        checkBox5.UseVisualStyleBackColor = true;
        checkBox5.CheckedChanged += prefectureCheckBox_CheckedChanged;
        // 
        // checkBox6
        // 
        checkBox6.AutoSize = true;
        checkBox6.Checked = true;
        checkBox6.CheckState = CheckState.Checked;
        checkBox6.Location = new Point(613, 19);
        checkBox6.Name = "checkBox6";
        checkBox6.Size = new Size(92, 29);
        checkBox6.TabIndex = 7;
        checkBox6.Text = "東京都";
        checkBox6.UseVisualStyleBackColor = true;
        checkBox6.CheckedChanged += prefectureCheckBox_CheckedChanged;
        // 
        // checkBox7
        // 
        checkBox7.AutoSize = true;
        checkBox7.Checked = true;
        checkBox7.CheckState = CheckState.Checked;
        checkBox7.Location = new Point(711, 19);
        checkBox7.Name = "checkBox7";
        checkBox7.Size = new Size(110, 29);
        checkBox7.TabIndex = 8;
        checkBox7.Text = "神奈川県";
        checkBox7.UseVisualStyleBackColor = true;
        checkBox7.CheckedChanged += prefectureCheckBox_CheckedChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(945, 450);
        Controls.Add(checkBox7);
        Controls.Add(checkBox6);
        Controls.Add(checkBox5);
        Controls.Add(checkBox4);
        Controls.Add(checkBox3);
        Controls.Add(checkBox2);
        Controls.Add(checkBox1);
        Controls.Add(label1);
        Controls.Add(ultraGrid1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)ultraGrid1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
    private Label label1;
    private CheckBox checkBox1;
    private CheckBox checkBox2;
    private CheckBox checkBox3;
    private CheckBox checkBox4;
    private CheckBox checkBox5;
    private CheckBox checkBox6;
    private CheckBox checkBox7;
}
