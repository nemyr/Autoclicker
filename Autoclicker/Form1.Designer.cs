namespace Autoclicker
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
            components = new System.ComponentModel.Container();
            gbActionType = new GroupBox();
            rbActClick = new RadioButton();
            rbActDragAndDrop = new RadioButton();
            rbActDrag = new RadioButton();
            rbActHold = new RadioButton();
            rbActClickHold = new RadioButton();
            label1 = new Label();
            lbDelay = new Label();
            gbArea = new GroupBox();
            tbDy = new TextBox();
            tbDx = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            gbActionType.SuspendLayout();
            gbArea.SuspendLayout();
            SuspendLayout();
            // 
            // gbActionType
            // 
            gbActionType.Controls.Add(rbActClick);
            gbActionType.Controls.Add(rbActDragAndDrop);
            gbActionType.Controls.Add(rbActDrag);
            gbActionType.Controls.Add(rbActHold);
            gbActionType.Controls.Add(rbActClickHold);
            gbActionType.Location = new Point(12, 12);
            gbActionType.Name = "gbActionType";
            gbActionType.Size = new Size(200, 143);
            gbActionType.TabIndex = 1;
            gbActionType.TabStop = false;
            gbActionType.Text = "Action type";
            // 
            // rbActClick
            // 
            rbActClick.AutoSize = true;
            rbActClick.Location = new Point(6, 17);
            rbActClick.Name = "rbActClick";
            rbActClick.Size = new Size(51, 19);
            rbActClick.TabIndex = 0;
            rbActClick.TabStop = true;
            rbActClick.Text = "Click";
            rbActClick.UseVisualStyleBackColor = true;
            // 
            // rbActDragAndDrop
            // 
            rbActDragAndDrop.AutoSize = true;
            rbActDragAndDrop.Location = new Point(6, 116);
            rbActDragAndDrop.Name = "rbActDragAndDrop";
            rbActDragAndDrop.Size = new Size(89, 19);
            rbActDragAndDrop.TabIndex = 4;
            rbActDragAndDrop.TabStop = true;
            rbActDragAndDrop.Text = "Drag'n'Drop";
            rbActDragAndDrop.UseVisualStyleBackColor = true;
            // 
            // rbActDrag
            // 
            rbActDrag.AutoSize = true;
            rbActDrag.Location = new Point(6, 91);
            rbActDrag.Name = "rbActDrag";
            rbActDrag.Size = new Size(50, 19);
            rbActDrag.TabIndex = 3;
            rbActDrag.TabStop = true;
            rbActDrag.Text = "Drag";
            rbActDrag.UseVisualStyleBackColor = true;
            // 
            // rbActHold
            // 
            rbActHold.AutoSize = true;
            rbActHold.Location = new Point(6, 66);
            rbActHold.Name = "rbActHold";
            rbActHold.Size = new Size(51, 19);
            rbActHold.TabIndex = 2;
            rbActHold.TabStop = true;
            rbActHold.Text = "Hold";
            rbActHold.UseVisualStyleBackColor = true;
            // 
            // rbActClickHold
            // 
            rbActClickHold.AutoSize = true;
            rbActClickHold.Location = new Point(6, 41);
            rbActClickHold.Name = "rbActClickHold";
            rbActClickHold.Size = new Size(80, 19);
            rbActClickHold.TabIndex = 1;
            rbActClickHold.TabStop = true;
            rbActClickHold.Text = "Click-hold";
            rbActClickHold.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 22);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Delay:";
            // 
            // lbDelay
            // 
            lbDelay.AutoSize = true;
            lbDelay.Location = new Point(287, 22);
            lbDelay.Name = "lbDelay";
            lbDelay.Size = new Size(25, 15);
            lbDelay.TabIndex = 3;
            lbDelay.Text = "500";
            // 
            // gbArea
            // 
            gbArea.Controls.Add(label3);
            gbArea.Controls.Add(label2);
            gbArea.Controls.Add(tbDy);
            gbArea.Controls.Add(tbDx);
            gbArea.Location = new Point(218, 40);
            gbArea.Name = "gbArea";
            gbArea.Size = new Size(176, 53);
            gbArea.TabIndex = 4;
            gbArea.TabStop = false;
            gbArea.Text = "Area";
            // 
            // tbDy
            // 
            tbDy.Location = new Point(113, 24);
            tbDy.Name = "tbDy";
            tbDy.Size = new Size(57, 23);
            tbDy.TabIndex = 1;
            // 
            // tbDx
            // 
            tbDx.Location = new Point(28, 24);
            tbDx.Name = "tbDx";
            tbDx.Size = new Size(57, 23);
            tbDx.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 28);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 2;
            label2.Text = "dx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 28);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 3;
            label3.Text = "dy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 167);
            Controls.Add(gbArea);
            Controls.Add(lbDelay);
            Controls.Add(label1);
            Controls.Add(gbActionType);
            Name = "Form1";
            Text = "Autoclicker";
            gbActionType.ResumeLayout(false);
            gbActionType.PerformLayout();
            gbArea.ResumeLayout(false);
            gbArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbActionType;
        private RadioButton rbActHold;
        private RadioButton rbActClickHold;
        private Label label1;
        private Label lbDelay;
        private RadioButton rbActDragAndDrop;
        private RadioButton rbActDrag;
        private GroupBox gbArea;
        private TextBox tbDy;
        private TextBox tbDx;
        private System.Windows.Forms.Timer timer1;
        private RadioButton rbActClick;
        private Label label3;
        private Label label2;
    }
}