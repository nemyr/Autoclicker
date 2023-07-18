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
            rbActDragAndDrop = new RadioButton();
            rbActDrag = new RadioButton();
            rbActHold = new RadioButton();
            rbActClick = new RadioButton();
            label1 = new Label();
            lbDelay = new Label();
            gbArea = new GroupBox();
            tbDy = new TextBox();
            tbDx = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            gbActionType.SuspendLayout();
            gbArea.SuspendLayout();
            SuspendLayout();
            // 
            // gbActionType
            // 
            gbActionType.Controls.Add(rbActDragAndDrop);
            gbActionType.Controls.Add(rbActDrag);
            gbActionType.Controls.Add(rbActHold);
            gbActionType.Controls.Add(rbActClick);
            gbActionType.Location = new Point(12, 12);
            gbActionType.Name = "gbActionType";
            gbActionType.Size = new Size(200, 125);
            gbActionType.TabIndex = 1;
            gbActionType.TabStop = false;
            gbActionType.Text = "Тип действия";
            // 
            // rbActDragAndDrop
            // 
            rbActDragAndDrop.AutoSize = true;
            rbActDragAndDrop.Location = new Point(6, 97);
            rbActDragAndDrop.Name = "rbActDragAndDrop";
            rbActDragAndDrop.Size = new Size(89, 19);
            rbActDragAndDrop.TabIndex = 3;
            rbActDragAndDrop.TabStop = true;
            rbActDragAndDrop.Text = "Drag'n'Drop";
            rbActDragAndDrop.UseVisualStyleBackColor = true;
            // 
            // rbActDrag
            // 
            rbActDrag.AutoSize = true;
            rbActDrag.Location = new Point(6, 72);
            rbActDrag.Name = "rbActDrag";
            rbActDrag.Size = new Size(50, 19);
            rbActDrag.TabIndex = 2;
            rbActDrag.TabStop = true;
            rbActDrag.Text = "Drag";
            rbActDrag.UseVisualStyleBackColor = true;
            // 
            // rbActHold
            // 
            rbActHold.AutoSize = true;
            rbActHold.Location = new Point(6, 47);
            rbActHold.Name = "rbActHold";
            rbActHold.Size = new Size(90, 19);
            rbActHold.TabIndex = 1;
            rbActHold.TabStop = true;
            rbActHold.Text = "Удерживать";
            rbActHold.UseVisualStyleBackColor = true;
            // 
            // rbActClick
            // 
            rbActClick.AutoSize = true;
            rbActClick.Location = new Point(6, 22);
            rbActClick.Name = "rbActClick";
            rbActClick.Size = new Size(52, 19);
            rbActClick.TabIndex = 0;
            rbActClick.TabStop = true;
            rbActClick.Text = "Клик";
            rbActClick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 22);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Задержка:";
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
            gbArea.Controls.Add(tbDy);
            gbArea.Controls.Add(tbDx);
            gbArea.Location = new Point(218, 84);
            gbArea.Name = "gbArea";
            gbArea.Size = new Size(164, 53);
            gbArea.TabIndex = 4;
            gbArea.TabStop = false;
            gbArea.Text = "Область действия";
            // 
            // tbDy
            // 
            tbDy.Location = new Point(101, 24);
            tbDy.Name = "tbDy";
            tbDy.Size = new Size(57, 23);
            tbDy.TabIndex = 1;
            // 
            // tbDx
            // 
            tbDx.Location = new Point(6, 24);
            tbDx.Name = "tbDx";
            tbDx.Size = new Size(57, 23);
            tbDx.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 142);
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
        private RadioButton rbActClick;
        private Label label1;
        private Label lbDelay;
        private RadioButton rbActDragAndDrop;
        private RadioButton rbActDrag;
        private GroupBox gbArea;
        private TextBox tbDy;
        private TextBox tbDx;
        private System.Windows.Forms.Timer timer1;
    }
}