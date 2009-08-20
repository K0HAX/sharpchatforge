namespace Xcelor8.Chat
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
            this.components = new System.ComponentModel.Container();
            this.uxOutput = new System.Windows.Forms.TextBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uxInput = new System.Windows.Forms.TextBox();
            this.uxSendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxOutput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uxOutput, 4);
            this.uxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxOutput.Location = new System.Drawing.Point(3, 29);
            this.uxOutput.Multiline = true;
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxOutput.Size = new System.Drawing.Size(389, 207);
            this.uxOutput.TabIndex = 4;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Controls.Add(this.uxInput, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uxOutput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uxSendButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxClear, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 265);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // uxInput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uxInput, 2);
            this.uxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxInput.Location = new System.Drawing.Point(3, 242);
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(236, 20);
            this.uxInput.TabIndex = 6;
            this.uxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxInput_KeyPress);
            // 
            // uxSendButton
            // 
            this.uxSendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSendButton.Location = new System.Drawing.Point(245, 242);
            this.uxSendButton.Name = "uxSendButton";
            this.uxSendButton.Size = new System.Drawing.Size(70, 20);
            this.uxSendButton.TabIndex = 7;
            this.uxSendButton.Text = "&Send!";
            this.uxSendButton.UseVisualStyleBackColor = true;
            this.uxSendButton.Click += new System.EventHandler(this.uxSendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nickname";
            // 
            // uxName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uxName, 3);
            this.uxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxName.Location = new System.Drawing.Point(64, 3);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(328, 20);
            this.uxName.TabIndex = 9;
            this.uxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxName_KeyPress);
            // 
            // uxClear
            // 
            this.uxClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxClear.Location = new System.Drawing.Point(321, 242);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(71, 20);
            this.uxClear.TabIndex = 10;
            this.uxClear.Text = "&Clear Chat";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Xcelor8 Chat - A Michael Englehorn production";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox uxOutput;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox uxInput;
        private System.Windows.Forms.Button uxSendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.Button uxClear;
    }
}

