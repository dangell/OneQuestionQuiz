namespace OneQuestionQuiz
{
    partial class frmOneQuestionQuiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rdoMeh = new System.Windows.Forms.RadioButton();
            this.rdoBad = new System.Windows.Forms.RadioButton();
            this.rdoGood = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(76, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "How Are You?";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.rdoMeh);
            this.grpOptions.Controls.Add(this.rdoBad);
            this.grpOptions.Controls.Add(this.rdoGood);
            this.grpOptions.Location = new System.Drawing.Point(12, 25);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(200, 100);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            // 
            // rdoMeh
            // 
            this.rdoMeh.AutoSize = true;
            this.rdoMeh.Location = new System.Drawing.Point(89, 77);
            this.rdoMeh.Name = "rdoMeh";
            this.rdoMeh.Size = new System.Drawing.Size(45, 17);
            this.rdoMeh.TabIndex = 2;
            this.rdoMeh.TabStop = true;
            this.rdoMeh.Text = "meh";
            this.rdoMeh.UseVisualStyleBackColor = true;
            this.rdoMeh.CheckedChanged += new System.EventHandler(this.rdoMeh_CheckedChanged);
            // 
            // rdoBad
            // 
            this.rdoBad.AutoSize = true;
            this.rdoBad.Location = new System.Drawing.Point(132, 41);
            this.rdoBad.Name = "rdoBad";
            this.rdoBad.Size = new System.Drawing.Size(43, 17);
            this.rdoBad.TabIndex = 1;
            this.rdoBad.TabStop = true;
            this.rdoBad.Text = "bad";
            this.rdoBad.UseVisualStyleBackColor = true;
            this.rdoBad.CheckedChanged += new System.EventHandler(this.rdoBad_CheckedChanged);
            // 
            // rdoGood
            // 
            this.rdoGood.AutoSize = true;
            this.rdoGood.Location = new System.Drawing.Point(27, 41);
            this.rdoGood.Name = "rdoGood";
            this.rdoGood.Size = new System.Drawing.Size(49, 17);
            this.rdoGood.TabIndex = 0;
            this.rdoGood.TabStop = true;
            this.rdoGood.Text = "good";
            this.rdoGood.UseVisualStyleBackColor = true;
            this.rdoGood.CheckedChanged += new System.EventHandler(this.rdoGood_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // frmOneQuestionQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 342);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmOneQuestionQuiz";
            this.Text = "One Question Quiz";
            this.Load += new System.EventHandler(this.lblQuestion_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rdoMeh;
        private System.Windows.Forms.RadioButton rdoBad;
        private System.Windows.Forms.RadioButton rdoGood;
        private System.Windows.Forms.Label lblResult;
    }
}

