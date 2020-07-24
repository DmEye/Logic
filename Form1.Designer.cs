namespace Logic
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.up_radio = new System.Windows.Forms.RadioButton();
            this.down_radio = new System.Windows.Forms.RadioButton();
            this.left_radio = new System.Windows.Forms.RadioButton();
            this.right_radio = new System.Windows.Forms.RadioButton();
            this.clear_b = new System.Windows.Forms.Button();
            this.empty_radio = new System.Windows.Forms.RadioButton();
            this.signal_timer = new System.Windows.Forms.Timer(this.components);
            this.signal_radio = new System.Windows.Forms.RadioButton();
            this.andup_radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // up_radio
            // 
            this.up_radio.AutoSize = true;
            this.up_radio.Checked = true;
            this.up_radio.Location = new System.Drawing.Point(712, 12);
            this.up_radio.Name = "up_radio";
            this.up_radio.Size = new System.Drawing.Size(40, 17);
            this.up_radio.TabIndex = 0;
            this.up_radio.TabStop = true;
            this.up_radio.Text = "UP";
            this.up_radio.UseVisualStyleBackColor = true;
            // 
            // down_radio
            // 
            this.down_radio.AutoSize = true;
            this.down_radio.Location = new System.Drawing.Point(712, 35);
            this.down_radio.Name = "down_radio";
            this.down_radio.Size = new System.Drawing.Size(60, 17);
            this.down_radio.TabIndex = 1;
            this.down_radio.Text = "DOWN";
            this.down_radio.UseVisualStyleBackColor = true;
            // 
            // left_radio
            // 
            this.left_radio.AutoSize = true;
            this.left_radio.Location = new System.Drawing.Point(712, 58);
            this.left_radio.Name = "left_radio";
            this.left_radio.Size = new System.Drawing.Size(51, 17);
            this.left_radio.TabIndex = 2;
            this.left_radio.Text = "LEFT";
            this.left_radio.UseVisualStyleBackColor = true;
            // 
            // right_radio
            // 
            this.right_radio.AutoSize = true;
            this.right_radio.Location = new System.Drawing.Point(712, 81);
            this.right_radio.Name = "right_radio";
            this.right_radio.Size = new System.Drawing.Size(59, 17);
            this.right_radio.TabIndex = 3;
            this.right_radio.Text = "RIGHT";
            this.right_radio.UseVisualStyleBackColor = true;
            // 
            // clear_b
            // 
            this.clear_b.Location = new System.Drawing.Point(712, 132);
            this.clear_b.Name = "clear_b";
            this.clear_b.Size = new System.Drawing.Size(60, 23);
            this.clear_b.TabIndex = 4;
            this.clear_b.Text = "Clear";
            this.clear_b.UseVisualStyleBackColor = true;
            this.clear_b.Click += new System.EventHandler(this.clear_b_Click);
            // 
            // empty_radio
            // 
            this.empty_radio.AutoSize = true;
            this.empty_radio.Location = new System.Drawing.Point(712, 104);
            this.empty_radio.Name = "empty_radio";
            this.empty_radio.Size = new System.Drawing.Size(62, 17);
            this.empty_radio.TabIndex = 5;
            this.empty_radio.Text = "EMPTY";
            this.empty_radio.UseVisualStyleBackColor = true;
            // 
            // signal_timer
            // 
            this.signal_timer.Tick += new System.EventHandler(this.signal_timer_Tick);
            // 
            // signal_radio
            // 
            this.signal_radio.AutoSize = true;
            this.signal_radio.Location = new System.Drawing.Point(646, 12);
            this.signal_radio.Name = "signal_radio";
            this.signal_radio.Size = new System.Drawing.Size(54, 17);
            this.signal_radio.TabIndex = 6;
            this.signal_radio.Text = "Signal";
            this.signal_radio.UseVisualStyleBackColor = true;
            // 
            // andup_radio
            // 
            this.andup_radio.AutoSize = true;
            this.andup_radio.Location = new System.Drawing.Point(646, 35);
            this.andup_radio.Name = "andup_radio";
            this.andup_radio.Size = new System.Drawing.Size(63, 17);
            this.andup_radio.TabIndex = 7;
            this.andup_radio.Text = "ANDUP";
            this.andup_radio.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.andup_radio);
            this.Controls.Add(this.signal_radio);
            this.Controls.Add(this.empty_radio);
            this.Controls.Add(this.clear_b);
            this.Controls.Add(this.right_radio);
            this.Controls.Add(this.left_radio);
            this.Controls.Add(this.down_radio);
            this.Controls.Add(this.up_radio);
            this.Name = "MainForm";
            this.Text = "Logic";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton up_radio;
        private System.Windows.Forms.RadioButton down_radio;
        private System.Windows.Forms.RadioButton left_radio;
        private System.Windows.Forms.RadioButton right_radio;
        private System.Windows.Forms.Button clear_b;
        private System.Windows.Forms.RadioButton empty_radio;
        private System.Windows.Forms.Timer signal_timer;
        private System.Windows.Forms.RadioButton signal_radio;
        private System.Windows.Forms.RadioButton andup_radio;
    }
}

