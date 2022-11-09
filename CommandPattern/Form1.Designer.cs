namespace CommandPattern
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRedraw = new System.Windows.Forms.Button();
            this.canvas = new CommandPattern.DrawCanvas();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(56, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Location = new System.Drawing.Point(240, 12);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(75, 23);
            this.buttonRedraw.TabIndex = 2;
            this.buttonRedraw.Text = "Redraw";
            this.buttonRedraw.UseVisualStyleBackColor = true;
            this.buttonRedraw.Click += new System.EventHandler(this.ButtonRedraw_Click);
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Color = System.Drawing.Color.Red;
            this.canvas.Location = new System.Drawing.Point(12, 41);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(428, 300);
            this.canvas.TabIndex = 0;
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas1_MouseMove);
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.Location = new System.Drawing.Point(137, 12);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(97, 23);
            this.buttonClearHistory.TabIndex = 3;
            this.buttonClearHistory.Text = "ClearHistory";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.ButtonClearHistory_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(321, 12);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 23);
            this.buttonUndo.TabIndex = 4;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 353);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.buttonRedraw);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DrawCanvas canvas;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.Button buttonUndo;
    }
}