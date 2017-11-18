namespace Lv2ObjektnoProgramiranje
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.font = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.undo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(552, 406);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(587, 13);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 1;
            this.open.Text = "OPEN";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(587, 55);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // font
            // 
            this.font.Location = new System.Drawing.Point(587, 96);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(75, 23);
            this.font.TabIndex = 3;
            this.font.Text = "FONT";
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(587, 134);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 23);
            this.color.TabIndex = 4;
            this.color.Text = "COLOR";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(587, 176);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(75, 23);
            this.undo.TabIndex = 5;
            this.undo.Text = "UNDO";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "REDO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cut
            // 
            this.cut.Location = new System.Drawing.Point(587, 253);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(75, 23);
            this.cut.TabIndex = 7;
            this.cut.Text = "CUT";
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(587, 297);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(75, 23);
            this.copy.TabIndex = 8;
            this.copy.Text = "COPY";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.Location = new System.Drawing.Point(587, 338);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(75, 23);
            this.paste.TabIndex = 9;
            this.paste.Text = "PASTE";
            this.paste.UseVisualStyleBackColor = true;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 444);
            this.Controls.Add(this.paste);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.color);
            this.Controls.Add(this.font);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button font;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button paste;
    }
}

