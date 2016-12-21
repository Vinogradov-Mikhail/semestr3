namespace GraphiEditor
{
    partial class Editor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.changePosition = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(594, 454);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaintHandler);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseClickHandler);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseMoveHandler);
            // 
            // changePosition
            // 
            this.changePosition.Location = new System.Drawing.Point(600, 12);
            this.changePosition.Name = "changePosition";
            this.changePosition.Size = new System.Drawing.Size(128, 43);
            this.changePosition.TabIndex = 1;
            this.changePosition.Text = "Переместить";
            this.changePosition.UseVisualStyleBackColor = true;
            this.changePosition.Click += new System.EventHandler(this.changePosition_Click);
            // 
            // undoButton
            // 
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undoButton.Location = new System.Drawing.Point(600, 75);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(128, 43);
            this.undoButton.TabIndex = 2;
            this.undoButton.Text = "←";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redoButton.Location = new System.Drawing.Point(600, 139);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(128, 43);
            this.redoButton.TabIndex = 3;
            this.redoButton.Text = "→";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(600, 199);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(128, 43);
            this.clearAll.TabIndex = 4;
            this.clearAll.Text = "Очистить";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(600, 266);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(128, 43);
            this.remove.TabIndex = 5;
            this.remove.Text = "Удалить";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 454);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.changePosition);
            this.Controls.Add(this.pictureBox);
            this.Name = "Editor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button changePosition;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button remove;
    }
}

