namespace ADSPortEx1
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
            this.Enqueue = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.IsEmpty = new System.Windows.Forms.Button();
            this.IsFull = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.GMFunds = new System.Windows.Forms.Button();
            this.Dequeue = new System.Windows.Forms.Button();
            this.Peek = new System.Windows.Forms.Button();
            this.kLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fundsLabel = new System.Windows.Forms.Label();
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.fundsEntry = new System.Windows.Forms.TextBox();
            this.kEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(21, 315);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(164, 103);
            this.Enqueue.TabIndex = 3;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(230, 33);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(162, 47);
            this.Count.TabIndex = 5;
            this.Count.Text = "Count items";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // IsEmpty
            // 
            this.IsEmpty.Location = new System.Drawing.Point(396, 33);
            this.IsEmpty.Name = "IsEmpty";
            this.IsEmpty.Size = new System.Drawing.Size(162, 47);
            this.IsEmpty.TabIndex = 6;
            this.IsEmpty.Text = "Check if empty";
            this.IsEmpty.UseVisualStyleBackColor = true;
            this.IsEmpty.Click += new System.EventHandler(this.IsEmpty_Click);
            // 
            // IsFull
            // 
            this.IsFull.Location = new System.Drawing.Point(564, 33);
            this.IsFull.Name = "IsFull";
            this.IsFull.Size = new System.Drawing.Size(162, 47);
            this.IsFull.TabIndex = 7;
            this.IsFull.Text = "Check if full";
            this.IsFull.UseVisualStyleBackColor = true;
            this.IsFull.Click += new System.EventHandler(this.IsFull_Click);
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(611, 105);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(162, 47);
            this.Reverse.TabIndex = 8;
            this.Reverse.Text = "Reverse k items";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // GMFunds
            // 
            this.GMFunds.Location = new System.Drawing.Point(611, 204);
            this.GMFunds.Name = "GMFunds";
            this.GMFunds.Size = new System.Drawing.Size(162, 47);
            this.GMFunds.TabIndex = 9;
            this.GMFunds.Text = "Get most funds";
            this.GMFunds.UseVisualStyleBackColor = true;
            this.GMFunds.Click += new System.EventHandler(this.GMFunds_Click);
            // 
            // Dequeue
            // 
            this.Dequeue.Location = new System.Drawing.Point(611, 315);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(164, 103);
            this.Dequeue.TabIndex = 10;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            this.Dequeue.Click += new System.EventHandler(this.Dequeue_Click);
            // 
            // Peek
            // 
            this.Peek.Location = new System.Drawing.Point(63, 33);
            this.Peek.Name = "Peek";
            this.Peek.Size = new System.Drawing.Size(162, 47);
            this.Peek.TabIndex = 11;
            this.Peek.Text = "Peek top";
            this.Peek.UseVisualStyleBackColor = true;
            this.Peek.Click += new System.EventHandler(this.Peek_Click);
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(655, 156);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(21, 20);
            this.kLabel.TabIndex = 15;
            this.kLabel.Text = "k:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 258);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name:";
            // 
            // fundsLabel
            // 
            this.fundsLabel.AutoSize = true;
            this.fundsLabel.Location = new System.Drawing.Point(28, 284);
            this.fundsLabel.Name = "fundsLabel";
            this.fundsLabel.Size = new System.Drawing.Size(58, 20);
            this.fundsLabel.TabIndex = 17;
            this.fundsLabel.Text = "Funds:";
            // 
            // nameEntry
            // 
            this.nameEntry.Location = new System.Drawing.Point(85, 255);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(100, 26);
            this.nameEntry.TabIndex = 18;
            // 
            // fundsEntry
            // 
            this.fundsEntry.Location = new System.Drawing.Point(85, 282);
            this.fundsEntry.Name = "fundsEntry";
            this.fundsEntry.Size = new System.Drawing.Size(100, 26);
            this.fundsEntry.TabIndex = 19;
            // 
            // kEntry
            // 
            this.kEntry.Location = new System.Drawing.Point(672, 153);
            this.kEntry.Name = "kEntry";
            this.kEntry.Size = new System.Drawing.Size(100, 26);
            this.kEntry.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kEntry);
            this.Controls.Add(this.fundsEntry);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.fundsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.Peek);
            this.Controls.Add(this.Dequeue);
            this.Controls.Add(this.GMFunds);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.IsFull);
            this.Controls.Add(this.IsEmpty);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Enqueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button IsEmpty;
        private System.Windows.Forms.Button IsFull;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button GMFunds;
        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.Button Peek;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label fundsLabel;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.TextBox fundsEntry;
        private System.Windows.Forms.TextBox kEntry;
    }
}

