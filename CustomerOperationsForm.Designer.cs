namespace Store
{
    partial class CustomerOperationsForm
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
            this.operationsList = new DarkUI.Controls.DarkListView();
            this.SuspendLayout();
            // 
            // operationsList
            // 
            this.operationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsList.Location = new System.Drawing.Point(12, 12);
            this.operationsList.Name = "operationsList";
            this.operationsList.Size = new System.Drawing.Size(760, 437);
            this.operationsList.TabIndex = 0;
            this.operationsList.Text = "darkListView1";
            // 
            // CustomerOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.operationsList);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "CustomerOperationsForm";
            this.Text = "Список проведенных покупок";
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkListView operationsList;
    }
}