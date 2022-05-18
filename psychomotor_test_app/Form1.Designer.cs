namespace psychomotor_test_app
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.buttonResults = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxMenu = new System.Windows.Forms.TextBox();
            this.buttonTest4 = new System.Windows.Forms.Button();
            this.buttonTest3 = new System.Windows.Forms.Button();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTest1
            // 
            this.buttonTest1.Location = new System.Drawing.Point(80, 193);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(91, 23);
            this.buttonTest1.TabIndex = 1;
            this.buttonTest1.Text = "Test 1";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest1_Click);
            // 
            // buttonResults
            // 
            this.buttonResults.Location = new System.Drawing.Point(80, 154);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(188, 23);
            this.buttonResults.TabIndex = 6;
            this.buttonResults.Text = "Wyniki";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(274, 154);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(188, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Wyczyść";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxMenu
            // 
            this.textBoxMenu.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMenu.Enabled = false;
            this.textBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMenu.Location = new System.Drawing.Point(15, 12);
            this.textBoxMenu.Multiline = true;
            this.textBoxMenu.Name = "textBoxMenu";
            this.textBoxMenu.Size = new System.Drawing.Size(562, 126);
            this.textBoxMenu.TabIndex = 9;
            this.textBoxMenu.Text = resources.GetString("textBoxMenu.Text");
            // 
            // buttonTest4
            // 
            this.buttonTest4.Location = new System.Drawing.Point(371, 193);
            this.buttonTest4.Name = "buttonTest4";
            this.buttonTest4.Size = new System.Drawing.Size(91, 23);
            this.buttonTest4.TabIndex = 11;
            this.buttonTest4.Text = "Test 4";
            this.buttonTest4.UseVisualStyleBackColor = true;
            this.buttonTest4.Click += new System.EventHandler(this.buttonTest4_Click);
            // 
            // buttonTest3
            // 
            this.buttonTest3.Location = new System.Drawing.Point(275, 193);
            this.buttonTest3.Name = "buttonTest3";
            this.buttonTest3.Size = new System.Drawing.Size(91, 23);
            this.buttonTest3.TabIndex = 12;
            this.buttonTest3.Text = "Test 3";
            this.buttonTest3.UseVisualStyleBackColor = true;
            this.buttonTest3.Click += new System.EventHandler(this.buttonTest3_Click);
            // 
            // buttonTest2
            // 
            this.buttonTest2.Location = new System.Drawing.Point(177, 193);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(91, 23);
            this.buttonTest2.TabIndex = 13;
            this.buttonTest2.Text = "Test 2";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Test 1 - Szybkość reakcji po zgaśnięciu świateł.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Test 2 - Szybkość reakcji na zapalające sie światła ustawione w rzędzie.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Test 3 - Szybkość reakcji po usłyszeniu dzwieku.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(11, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Test 4 - Szybkość reakcji i poprawność z wykożystaniem aparatu krzyżowego.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTest2);
            this.Controls.Add(this.buttonTest3);
            this.Controls.Add(this.buttonTest4);
            this.Controls.Add(this.textBoxMenu);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.buttonTest1);
            this.Name = "Form1";
            this.Text = "Psychomotr Test Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTest1;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxMenu;
        private System.Windows.Forms.Button buttonTest4;
        private System.Windows.Forms.Button buttonTest3;
        private System.Windows.Forms.Button buttonTest2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

