namespace UI
{
    partial class FormMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlControleAqueceimento = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.dtpTimer = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPotency = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxTemplate = new System.Windows.Forms.ListBox();
            this.btnStartTemplate = new System.Windows.Forms.Button();
            this.pnlTemplateCommands = new System.Windows.Forms.Panel();
            this.gbxMealKind = new System.Windows.Forms.GroupBox();
            this.rdbAny = new System.Windows.Forms.RadioButton();
            this.rdbCheese = new System.Windows.Forms.RadioButton();
            this.rdbChicken = new System.Windows.Forms.RadioButton();
            this.rdbtnMeat = new System.Windows.Forms.RadioButton();
            this.txtSearchTemplate = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.deleteTemplate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlControleAqueceimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPotency)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTemplateCommands.SuspendLayout();
            this.gbxMealKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtOutput);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputString);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.pnlControleAqueceimento);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnStartTemplate);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTemplateCommands);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1081, 555);
            this.splitContainer1.SplitterDistance = 809;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "OUTPUT STRING:";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Location = new System.Drawing.Point(0, 441);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(617, 114);
            this.txtOutput.TabIndex = 2;
            // 
            // txtInputString
            // 
            this.txtInputString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputString.Location = new System.Drawing.Point(0, 15);
            this.txtInputString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInputString.Multiline = true;
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(617, 540);
            this.txtInputString.TabIndex = 2;
            this.txtInputString.Text = "{\r\n  \"Name\": \"New Job\",\r\n  \"MealKind\": 0,\r\n  \"Instructions\": null,\r\n  \"CanDelete\"" +
    ": true,\r\n  \"Default\": false,\r\n  \"Id\": \"98202e22-81fd-40ab-ac8e-bdb0eed9ad4c\",\r\n " +
    " \"Potency\": 8,\r\n  \"TimeLeft\": 30\r\n}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "INPUT STRING:";
            // 
            // pnlControleAqueceimento
            // 
            this.pnlControleAqueceimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControleAqueceimento.Controls.Add(this.btnCancel);
            this.pnlControleAqueceimento.Controls.Add(this.btnStart);
            this.pnlControleAqueceimento.Controls.Add(this.btnTranslate);
            this.pnlControleAqueceimento.Controls.Add(this.dtpTimer);
            this.pnlControleAqueceimento.Controls.Add(this.label1);
            this.pnlControleAqueceimento.Controls.Add(this.txtPotency);
            this.pnlControleAqueceimento.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControleAqueceimento.Location = new System.Drawing.Point(617, 0);
            this.pnlControleAqueceimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlControleAqueceimento.Name = "pnlControleAqueceimento";
            this.pnlControleAqueceimento.Size = new System.Drawing.Size(192, 555);
            this.pnlControleAqueceimento.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(15, 490);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(15, 439);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 44);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(22, 175);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(150, 42);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "<= Translate to imput string";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // dtpTimer
            // 
            this.dtpTimer.CustomFormat = "mm:ss";
            this.dtpTimer.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpTimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimer.Location = new System.Drawing.Point(63, 31);
            this.dtpTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpTimer.MaxDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTimer.Name = "dtpTimer";
            this.dtpTimer.ShowUpDown = true;
            this.dtpTimer.Size = new System.Drawing.Size(110, 40);
            this.dtpTimer.TabIndex = 1;
            this.dtpTimer.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTimer.ValueChanged += new System.EventHandler(this.dtpTimer_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Potency:";
            // 
            // txtPotency
            // 
            this.txtPotency.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPotency.Location = new System.Drawing.Point(103, 107);
            this.txtPotency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPotency.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPotency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPotency.Name = "txtPotency";
            this.txtPotency.Size = new System.Drawing.Size(70, 40);
            this.txtPotency.TabIndex = 2;
            this.txtPotency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPotency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPotency.ValueChanged += new System.EventHandler(this.txtPotency_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbxTemplate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 227);
            this.panel1.TabIndex = 7;
            // 
            // lbxTemplate
            // 
            this.lbxTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxTemplate.FormattingEnabled = true;
            this.lbxTemplate.ItemHeight = 15;
            this.lbxTemplate.Location = new System.Drawing.Point(0, 0);
            this.lbxTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxTemplate.Name = "lbxTemplate";
            this.lbxTemplate.Size = new System.Drawing.Size(264, 223);
            this.lbxTemplate.TabIndex = 1;
            // 
            // btnStartTemplate
            // 
            this.btnStartTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartTemplate.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartTemplate.Location = new System.Drawing.Point(0, 242);
            this.btnStartTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartTemplate.Name = "btnStartTemplate";
            this.btnStartTemplate.Size = new System.Drawing.Size(268, 44);
            this.btnStartTemplate.TabIndex = 6;
            this.btnStartTemplate.Text = "START";
            this.btnStartTemplate.UseVisualStyleBackColor = true;
            this.btnStartTemplate.Click += new System.EventHandler(this.btnStartTemplate_Click);
            // 
            // pnlTemplateCommands
            // 
            this.pnlTemplateCommands.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTemplateCommands.Controls.Add(this.gbxMealKind);
            this.pnlTemplateCommands.Controls.Add(this.txtSearchTemplate);
            this.pnlTemplateCommands.Controls.Add(this.btnSearch);
            this.pnlTemplateCommands.Controls.Add(this.btnAddTemplate);
            this.pnlTemplateCommands.Controls.Add(this.deleteTemplate);
            this.pnlTemplateCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTemplateCommands.Location = new System.Drawing.Point(0, 286);
            this.pnlTemplateCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTemplateCommands.Name = "pnlTemplateCommands";
            this.pnlTemplateCommands.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlTemplateCommands.Size = new System.Drawing.Size(268, 269);
            this.pnlTemplateCommands.TabIndex = 2;
            // 
            // gbxMealKind
            // 
            this.gbxMealKind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMealKind.Controls.Add(this.rdbAny);
            this.gbxMealKind.Controls.Add(this.rdbCheese);
            this.gbxMealKind.Controls.Add(this.rdbChicken);
            this.gbxMealKind.Controls.Add(this.rdbtnMeat);
            this.gbxMealKind.Location = new System.Drawing.Point(5, 10);
            this.gbxMealKind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxMealKind.Name = "gbxMealKind";
            this.gbxMealKind.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxMealKind.Size = new System.Drawing.Size(256, 105);
            this.gbxMealKind.TabIndex = 9;
            this.gbxMealKind.TabStop = false;
            this.gbxMealKind.Text = "Meal Kind";
            // 
            // rdbAny
            // 
            this.rdbAny.AutoSize = true;
            this.rdbAny.Checked = true;
            this.rdbAny.Location = new System.Drawing.Point(7, 80);
            this.rdbAny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbAny.Name = "rdbAny";
            this.rdbAny.Size = new System.Drawing.Size(46, 19);
            this.rdbAny.TabIndex = 2;
            this.rdbAny.TabStop = true;
            this.rdbAny.Text = "Any";
            this.rdbAny.UseVisualStyleBackColor = true;
            // 
            // rdbCheese
            // 
            this.rdbCheese.AutoSize = true;
            this.rdbCheese.Location = new System.Drawing.Point(7, 59);
            this.rdbCheese.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbCheese.Name = "rdbCheese";
            this.rdbCheese.Size = new System.Drawing.Size(63, 19);
            this.rdbCheese.TabIndex = 2;
            this.rdbCheese.Text = "Cheese";
            this.rdbCheese.UseVisualStyleBackColor = true;
            // 
            // rdbChicken
            // 
            this.rdbChicken.AutoSize = true;
            this.rdbChicken.Location = new System.Drawing.Point(7, 38);
            this.rdbChicken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbChicken.Name = "rdbChicken";
            this.rdbChicken.Size = new System.Drawing.Size(68, 19);
            this.rdbChicken.TabIndex = 1;
            this.rdbChicken.Text = "Chicken";
            this.rdbChicken.UseVisualStyleBackColor = true;
            // 
            // rdbtnMeat
            // 
            this.rdbtnMeat.AutoSize = true;
            this.rdbtnMeat.Location = new System.Drawing.Point(7, 17);
            this.rdbtnMeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbtnMeat.Name = "rdbtnMeat";
            this.rdbtnMeat.Size = new System.Drawing.Size(52, 19);
            this.rdbtnMeat.TabIndex = 0;
            this.rdbtnMeat.Text = "Meat";
            this.rdbtnMeat.UseVisualStyleBackColor = true;
            // 
            // txtSearchTemplate
            // 
            this.txtSearchTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTemplate.Location = new System.Drawing.Point(4, 122);
            this.txtSearchTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchTemplate.Name = "txtSearchTemplate";
            this.txtSearchTemplate.Size = new System.Drawing.Size(208, 23);
            this.txtSearchTemplate.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(219, 118);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTemplate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTemplate.Location = new System.Drawing.Point(54, 153);
            this.btnAddTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(206, 44);
            this.btnAddTemplate.TabIndex = 6;
            this.btnAddTemplate.Text = "Add template";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // deleteTemplate
            // 
            this.deleteTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTemplate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteTemplate.Location = new System.Drawing.Point(54, 203);
            this.deleteTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteTemplate.Name = "deleteTemplate";
            this.deleteTemplate.Size = new System.Drawing.Size(206, 50);
            this.deleteTemplate.TabIndex = 6;
            this.deleteTemplate.Text = "Delete template";
            this.deleteTemplate.UseVisualStyleBackColor = true;
            this.deleteTemplate.Click += new System.EventHandler(this.deleteTemplate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Templates:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 565);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Benner: Digital Microwave 2020++";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlControleAqueceimento.ResumeLayout(false);
            this.pnlControleAqueceimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPotency)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlTemplateCommands.ResumeLayout(false);
            this.pnlTemplateCommands.PerformLayout();
            this.gbxMealKind.ResumeLayout(false);
            this.gbxMealKind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlControleAqueceimento;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown txtPotency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTimer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTemplateCommands;
        private System.Windows.Forms.Button deleteTemplate;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.TextBox txtSearchTemplate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxMealKind;
        private System.Windows.Forms.RadioButton rdbtnMeat;
        private System.Windows.Forms.RadioButton rdbCheese;
        private System.Windows.Forms.RadioButton rdbChicken;
        private System.Windows.Forms.RadioButton rdbAny;
        private System.Windows.Forms.Button btnStartTemplate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxTemplate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label4;
    }
}

