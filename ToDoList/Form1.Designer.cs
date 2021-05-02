
namespace ToDoList
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
            this.lstbxDo = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbAdd = new System.Windows.Forms.TextBox();
            this.txbPriority = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxDo
            // 
            this.lstbxDo.FormattingEnabled = true;
            this.lstbxDo.ItemHeight = 25;
            this.lstbxDo.Location = new System.Drawing.Point(191, 460);
            this.lstbxDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbxDo.Name = "lstbxDo";
            this.lstbxDo.Size = new System.Drawing.Size(626, 229);
            this.lstbxDo.TabIndex = 0;
            this.lstbxDo.SelectedIndexChanged += new System.EventHandler(this.lstbxDo_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(800, 317);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+ Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbAdd
            // 
            this.txbAdd.Location = new System.Drawing.Point(503, 236);
            this.txbAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbAdd.Name = "txbAdd";
            this.txbAdd.PlaceholderText = "Description";
            this.txbAdd.Size = new System.Drawing.Size(152, 31);
            this.txbAdd.TabIndex = 2;
            this.txbAdd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbPriority
            // 
            this.txbPriority.Location = new System.Drawing.Point(527, 317);
            this.txbPriority.Name = "txbPriority";
            this.txbPriority.PlaceholderText = "Eg.High";
            this.txbPriority.Size = new System.Drawing.Size(150, 31);
            this.txbPriority.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(400, 421);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(291, 31);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Priority Level :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDoList.Properties.Resources._1020658_bb32f5ee0a8f5c7a56cc31664d52e015;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1030, 714);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txbPriority);
            this.Controls.Add(this.txbAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstbxDo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbAdd;
        private System.Windows.Forms.TextBox txbPriority;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

