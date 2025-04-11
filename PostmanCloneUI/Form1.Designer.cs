namespace PostmanCloneUI
{
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
            formHeader = new Label();
            apiText = new TextBox();
            callApi = new Button();
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            apiLabel = new Label();
            httpVerb = new ComboBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            bodyText = new TextBox();
            resultTab = new TabPage();
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            resultTab.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formHeader.ForeColor = Color.FromArgb(192, 0, 0);
            formHeader.Location = new Point(55, 37);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(288, 48);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postmone Clone";
            // 
            // apiText
            // 
            apiText.AllowDrop = true;
            apiText.BackColor = SystemColors.ControlLightLight;
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Font = new Font("Microsoft Sans Serif", 12F);
            apiText.Location = new Point(240, 136);
            apiText.Margin = new Padding(4);
            apiText.Name = "apiText";
            apiText.PlaceholderText = "  Enter URL";
            apiText.Size = new Size(517, 35);
            apiText.TabIndex = 2;
            apiText.TextChanged += apiText_TextChanged;
            // 
            // callApi
            // 
            callApi.AutoSize = true;
            callApi.BackColor = Color.SeaGreen;
            callApi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            callApi.ForeColor = SystemColors.InactiveCaptionText;
            callApi.Location = new Point(771, 129);
            callApi.Name = "callApi";
            callApi.Size = new Size(90, 42);
            callApi.TabIndex = 3;
            callApi.Text = "Send";
            callApi.UseVisualStyleBackColor = false;
            callApi.Click += callApi_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = SystemColors.ButtonHighlight;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Dock = DockStyle.Fill;
            resultsText.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultsText.Location = new Point(3, 3);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(813, 338);
            resultsText.TabIndex = 4;
            resultsText.TextChanged += textBox2_TextChanged;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = SystemColors.ScrollBar;
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(2, 623);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(926, 36);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(77, 29);
            systemStatus.Text = "Ready";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Segoe UI", 13F);
            apiLabel.Location = new Point(41, 136);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(67, 36);
            apiLabel.TabIndex = 6;
            apiLabel.Text = "API :";
            // 
            // httpVerb
            // 
            httpVerb.BackColor = SystemColors.GradientInactiveCaption;
            httpVerb.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerb.Font = new Font("Segoe UI", 11F);
            httpVerb.FormattingEnabled = true;
            httpVerb.Items.AddRange(new object[] { "GET", "POST ", "PUT", "DELETE", "PATCH" });
            httpVerb.Location = new Point(114, 134);
            httpVerb.Name = "httpVerb";
            httpVerb.Size = new Size(109, 38);
            httpVerb.TabIndex = 8;
            // 
            // callData
            // 
            callData.AccessibleName = "callData";
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(resultTab);
            callData.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            callData.Location = new Point(41, 203);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(827, 385);
            callData.TabIndex = 9;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(bodyText);
            bodyTab.Location = new Point(4, 37);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(819, 344);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            bodyTab.Click += tabPage1_Click;
            // 
            // bodyText
            // 
            bodyText.BackColor = SystemColors.HighlightText;
            bodyText.Dock = DockStyle.Fill;
            bodyText.Location = new Point(3, 3);
            bodyText.Multiline = true;
            bodyText.Name = "bodyText";
            bodyText.Size = new Size(813, 338);
            bodyText.TabIndex = 0;
            // 
            // resultTab
            // 
            resultTab.Controls.Add(resultsText);
            resultTab.Location = new Point(4, 37);
            resultTab.Name = "resultTab";
            resultTab.Padding = new Padding(3);
            resultTab.Size = new Size(819, 344);
            resultTab.TabIndex = 1;
            resultTab.Text = "Results";
            resultTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(930, 661);
            Controls.Add(callData);
            Controls.Add(httpVerb);
            Controls.Add(apiLabel);
            Controls.Add(statusStrip);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(formHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Padding = new Padding(2);
            Text = "Postman Clone App";
            Load += Form1_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            resultTab.ResumeLayout(false);
            resultTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private TextBox apiText;
        private Button callApi;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label apiLabel;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpVerb;
        private TabPage bodyTab;
        private TabPage resultTab;
        public TabControl callData;
        private TextBox bodyText;
    }
}
