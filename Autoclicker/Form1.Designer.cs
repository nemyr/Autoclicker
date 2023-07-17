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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.gbActionType = new System.Windows.Forms.GroupBox();
            this.rbActDragAndDrop = new System.Windows.Forms.RadioButton();
            this.rbActDrag = new System.Windows.Forms.RadioButton();
            this.rbActHold = new System.Windows.Forms.RadioButton();
            this.rbActClick = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDelay = new System.Windows.Forms.Label();
            this.gbArea = new System.Windows.Forms.GroupBox();
            this.tbDy = new System.Windows.Forms.TextBox();
            this.tbDx = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbActionType.SuspendLayout();
            this.gbArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbActionType
            // 
            this.gbActionType.Controls.Add(this.rbActDragAndDrop);
            this.gbActionType.Controls.Add(this.rbActDrag);
            this.gbActionType.Controls.Add(this.rbActHold);
            this.gbActionType.Controls.Add(this.rbActClick);
            this.gbActionType.Location = new System.Drawing.Point(12, 12);
            this.gbActionType.Name = "gbActionType";
            this.gbActionType.Size = new System.Drawing.Size(200, 125);
            this.gbActionType.TabIndex = 1;
            this.gbActionType.TabStop = false;
            this.gbActionType.Text = "Тип действия";
            // 
            // rbActDragAndDrop
            // 
            this.rbActDragAndDrop.AutoSize = true;
            this.rbActDragAndDrop.Location = new System.Drawing.Point(6, 97);
            this.rbActDragAndDrop.Name = "rbActDragAndDrop";
            this.rbActDragAndDrop.Size = new System.Drawing.Size(89, 19);
            this.rbActDragAndDrop.TabIndex = 3;
            this.rbActDragAndDrop.TabStop = true;
            this.rbActDragAndDrop.Text = "Drag\'n\'Drop";
            this.rbActDragAndDrop.UseVisualStyleBackColor = true;
            // 
            // rbActDrag
            // 
            this.rbActDrag.AutoSize = true;
            this.rbActDrag.Location = new System.Drawing.Point(6, 72);
            this.rbActDrag.Name = "rbActDrag";
            this.rbActDrag.Size = new System.Drawing.Size(50, 19);
            this.rbActDrag.TabIndex = 2;
            this.rbActDrag.TabStop = true;
            this.rbActDrag.Text = "Drag";
            this.rbActDrag.UseVisualStyleBackColor = true;
            // 
            // rbActHold
            // 
            this.rbActHold.AutoSize = true;
            this.rbActHold.Location = new System.Drawing.Point(6, 47);
            this.rbActHold.Name = "rbActHold";
            this.rbActHold.Size = new System.Drawing.Size(90, 19);
            this.rbActHold.TabIndex = 1;
            this.rbActHold.TabStop = true;
            this.rbActHold.Text = "Удерживать";
            this.rbActHold.UseVisualStyleBackColor = true;
            // 
            // rbActClick
            // 
            this.rbActClick.AutoSize = true;
            this.rbActClick.Location = new System.Drawing.Point(6, 22);
            this.rbActClick.Name = "rbActClick";
            this.rbActClick.Size = new System.Drawing.Size(52, 19);
            this.rbActClick.TabIndex = 0;
            this.rbActClick.TabStop = true;
            this.rbActClick.Text = "Клик";
            this.rbActClick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задержка:";
            // 
            // lbDelay
            // 
            this.lbDelay.AutoSize = true;
            this.lbDelay.Location = new System.Drawing.Point(287, 22);
            this.lbDelay.Name = "lbDelay";
            this.lbDelay.Size = new System.Drawing.Size(19, 15);
            this.lbDelay.TabIndex = 3;
            this.lbDelay.Text = "50";
            // 
            // gbArea
            // 
            this.gbArea.Controls.Add(this.tbDy);
            this.gbArea.Controls.Add(this.tbDx);
            this.gbArea.Location = new System.Drawing.Point(218, 84);
            this.gbArea.Name = "gbArea";
            this.gbArea.Size = new System.Drawing.Size(164, 53);
            this.gbArea.TabIndex = 4;
            this.gbArea.TabStop = false;
            this.gbArea.Text = "Область действия";
            // 
            // tbDy
            // 
            this.tbDy.Location = new System.Drawing.Point(101, 24);
            this.tbDy.Name = "tbDy";
            this.tbDy.Size = new System.Drawing.Size(57, 23);
            this.tbDy.TabIndex = 1;
            // 
            // tbDx
            // 
            this.tbDx.Location = new System.Drawing.Point(6, 24);
            this.tbDx.Name = "tbDx";
            this.tbDx.Size = new System.Drawing.Size(57, 23);
            this.tbDx.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 176);
            this.Controls.Add(this.gbArea);
            this.Controls.Add(this.lbDelay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbActionType);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Autoclicker";
            this.gbActionType.ResumeLayout(false);
            this.gbActionType.PerformLayout();
            this.gbArea.ResumeLayout(false);
            this.gbArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
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