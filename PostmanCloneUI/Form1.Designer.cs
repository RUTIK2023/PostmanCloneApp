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
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formHeader.ForeColor = Color.FromArgb(192, 0, 0);
            formHeader.Location = new Point(81, 37);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(288, 48);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postmone Clone";
            // 
            // apiText
            // 
            apiText.BackColor = SystemColors.InactiveBorder;
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Font = new Font("Microsoft Sans Serif", 10F);
            apiText.Location = new Point(161, 149);
            apiText.Name = "apiText";
            apiText.PlaceholderText = "  Enter URL";
            apiText.Size = new Size(450, 30);
            apiText.TabIndex = 2;
            apiText.TextChanged += apiText_TextChanged;
            // 
            // callApi
            // 
            callApi.AutoSize = true;
            callApi.BackColor = Color.SeaGreen;
            callApi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            callApi.ForeColor = SystemColors.InactiveCaptionText;
            callApi.Location = new Point(625, 141);
            callApi.Name = "callApi";
            callApi.Size = new Size(90, 44);
            callApi.TabIndex = 3;
            callApi.Text = "Send";
            callApi.UseVisualStyleBackColor = false;
            callApi.Click += callApi_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = SystemColors.ControlLight;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultsText.Location = new Point(88, 252);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(661, 271);
            resultsText.TabIndex = 4;
            resultsText.TextChanged += textBox2_TextChanged;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = SystemColors.ScrollBar;
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(2, 561);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(796, 36);
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
            apiLabel.Location = new Point(90, 147);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(60, 36);
            apiLabel.TabIndex = 6;
            apiLabel.Text = "API:";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 12F);
            resultsLabel.Location = new Point(90, 211);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(93, 32);
            resultsLabel.TabIndex = 7;
            resultsLabel.Text = "Results:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 599);
            Controls.Add(resultsLabel);
            Controls.Add(apiLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
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
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
