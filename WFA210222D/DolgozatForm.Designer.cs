using System.Windows.Forms;

namespace WFA210222D
{
    partial class DolgozatForm : Form
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
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnFourth = new System.Windows.Forms.Button();
            this.cbUppercase = new System.Windows.Forms.CheckBox();
            this.recordedLines = new System.Windows.Forms.RichTextBox();
            this.textRecordTextBox = new System.Windows.Forms.TextBox();
            this.textRecordBtn = new System.Windows.Forms.Button();
            this.textRecordTextBoxLabel = new System.Windows.Forms.Label();
            this.textAppropriateLabel = new System.Windows.Forms.Label();
            this.befogo1Label = new System.Windows.Forms.Label();
            this.befogo1 = new System.Windows.Forms.TextBox();
            this.befogo2 = new System.Windows.Forms.TextBox();
            this.befogo2Label = new System.Windows.Forms.Label();
            this.calculateTriangleBtn = new System.Windows.Forms.Button();
            this.atfogoLabel = new System.Windows.Forms.Label();
            this.atfogo = new System.Windows.Forms.Label();
            this.keruletLabel = new System.Windows.Forms.Label();
            this.kerulet = new System.Windows.Forms.Label();
            this.teruletLabel = new System.Windows.Forms.Label();
            this.terulet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbRed
            // 
            this.rbRed.Location = new System.Drawing.Point(118, 23);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(104, 24);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Piros";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbYellow
            // 
            this.rbYellow.Location = new System.Drawing.Point(118, 53);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(104, 24);
            this.rbYellow.TabIndex = 1;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Sárga";
            this.rbYellow.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.Location = new System.Drawing.Point(118, 83);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(104, 24);
            this.rbGreen.TabIndex = 2;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Zöld";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.Location = new System.Drawing.Point(118, 113);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(104, 24);
            this.rbBlue.TabIndex = 3;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Kék";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.btnFirst.Location = new System.Drawing.Point(254, 23);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(123, 54);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "első";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.btnSecond.Location = new System.Drawing.Point(254, 83);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(123, 54);
            this.btnSecond.TabIndex = 5;
            this.btnSecond.Text = "második";
            this.btnSecond.UseVisualStyleBackColor = false;
            this.btnSecond.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // btnThird
            // 
            this.btnThird.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.btnThird.Location = new System.Drawing.Point(383, 23);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(123, 54);
            this.btnThird.TabIndex = 6;
            this.btnThird.Text = "harmadik";
            this.btnThird.UseVisualStyleBackColor = false;
            this.btnThird.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // btnFourth
            // 
            this.btnFourth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.btnFourth.Location = new System.Drawing.Point(383, 83);
            this.btnFourth.Name = "btnFourth";
            this.btnFourth.Size = new System.Drawing.Size(123, 54);
            this.btnFourth.TabIndex = 7;
            this.btnFourth.Text = "negyedik";
            this.btnFourth.UseVisualStyleBackColor = false;
            this.btnFourth.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // cbUppercase
            // 
            this.cbUppercase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.cbUppercase.Location = new System.Drawing.Point(527, 68);
            this.cbUppercase.Name = "cbUppercase";
            this.cbUppercase.Size = new System.Drawing.Size(154, 24);
            this.cbUppercase.TabIndex = 8;
            this.cbUppercase.Text = "CSUPA NAGYBETŰ";
            this.cbUppercase.UseVisualStyleBackColor = true;
            this.cbUppercase.CheckedChanged += new System.EventHandler(this.cbUppercase_CheckedChanged);
            // 
            // recordedLines
            // 
            this.recordedLines.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recordedLines.Location = new System.Drawing.Point(383, 157);
            this.recordedLines.Name = "recordedLines";
            this.recordedLines.ReadOnly = true;
            this.recordedLines.Size = new System.Drawing.Size(325, 165);
            this.recordedLines.TabIndex = 9;
            this.recordedLines.Text = "";
            // 
            // textRecordTextBox
            // 
            this.textRecordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textRecordTextBox.Location = new System.Drawing.Point(122, 198);
            this.textRecordTextBox.Name = "textRecordTextBox";
            this.textRecordTextBox.Size = new System.Drawing.Size(255, 22);
            this.textRecordTextBox.TabIndex = 10;
            this.textRecordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRecordTextBox.TextChanged += new System.EventHandler(this.textRecordTextBox_TextChanged);
            // 
            // textRecordBtn
            // 
            this.textRecordBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textRecordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textRecordBtn.Location = new System.Drawing.Point(122, 271);
            this.textRecordBtn.Name = "textRecordBtn";
            this.textRecordBtn.Size = new System.Drawing.Size(255, 51);
            this.textRecordBtn.TabIndex = 11;
            this.textRecordBtn.Text = "Rögzít!";
            this.textRecordBtn.UseVisualStyleBackColor = false;
            this.textRecordBtn.Click += new System.EventHandler(this.textRecordBtn_Click);
            // 
            // textRecordTextBoxLabel
            // 
            this.textRecordTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textRecordTextBoxLabel.Location = new System.Drawing.Point(122, 172);
            this.textRecordTextBoxLabel.Name = "textRecordTextBoxLabel";
            this.textRecordTextBoxLabel.Size = new System.Drawing.Size(255, 23);
            this.textRecordTextBoxLabel.TabIndex = 12;
            this.textRecordTextBoxLabel.Text = "Ide írd a rögzíteni kívánt sort:";
            this.textRecordTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAppropriateLabel
            // 
            this.textAppropriateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textAppropriateLabel.Location = new System.Drawing.Point(122, 223);
            this.textAppropriateLabel.Name = "textAppropriateLabel";
            this.textAppropriateLabel.Size = new System.Drawing.Size(255, 45);
            this.textAppropriateLabel.TabIndex = 13;
            this.textAppropriateLabel.Text = "######";
            this.textAppropriateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // befogo1Label
            // 
            this.befogo1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.befogo1Label.Location = new System.Drawing.Point(140, 344);
            this.befogo1Label.Name = "befogo1Label";
            this.befogo1Label.Size = new System.Drawing.Size(100, 23);
            this.befogo1Label.TabIndex = 14;
            this.befogo1Label.Text = "1. befogó:";
            this.befogo1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // befogo1
            // 
            this.befogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.befogo1.Location = new System.Drawing.Point(140, 370);
            this.befogo1.Name = "befogo1";
            this.befogo1.Size = new System.Drawing.Size(100, 24);
            this.befogo1.TabIndex = 15;
            // 
            // befogo2
            // 
            this.befogo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.befogo2.Location = new System.Drawing.Point(254, 370);
            this.befogo2.Name = "befogo2";
            this.befogo2.Size = new System.Drawing.Size(100, 24);
            this.befogo2.TabIndex = 17;
            // 
            // befogo2Label
            // 
            this.befogo2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.befogo2Label.Location = new System.Drawing.Point(254, 344);
            this.befogo2Label.Name = "befogo2Label";
            this.befogo2Label.Size = new System.Drawing.Size(100, 23);
            this.befogo2Label.TabIndex = 16;
            this.befogo2Label.Text = "2. befogó:";
            this.befogo2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateTriangleBtn
            // 
            this.calculateTriangleBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateTriangleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.calculateTriangleBtn.Location = new System.Drawing.Point(456, 344);
            this.calculateTriangleBtn.Name = "calculateTriangleBtn";
            this.calculateTriangleBtn.Size = new System.Drawing.Size(165, 49);
            this.calculateTriangleBtn.TabIndex = 18;
            this.calculateTriangleBtn.Text = "Számol!";
            this.calculateTriangleBtn.UseVisualStyleBackColor = false;
            this.calculateTriangleBtn.Click += new System.EventHandler(this.calculateTriangleBtn_Click);
            // 
            // atfogoLabel
            // 
            this.atfogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.atfogoLabel.Location = new System.Drawing.Point(47, 444);
            this.atfogoLabel.Name = "atfogoLabel";
            this.atfogoLabel.Size = new System.Drawing.Size(100, 23);
            this.atfogoLabel.TabIndex = 19;
            this.atfogoLabel.Text = "átfogó:";
            this.atfogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atfogo
            // 
            this.atfogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.atfogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.atfogo.Location = new System.Drawing.Point(153, 444);
            this.atfogo.Name = "atfogo";
            this.atfogo.Size = new System.Drawing.Size(100, 23);
            this.atfogo.TabIndex = 20;
            this.atfogo.Text = "???";
            this.atfogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keruletLabel
            // 
            this.keruletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.keruletLabel.Location = new System.Drawing.Point(525, 444);
            this.keruletLabel.Name = "keruletLabel";
            this.keruletLabel.Size = new System.Drawing.Size(100, 23);
            this.keruletLabel.TabIndex = 21;
            this.keruletLabel.Text = "kerület:";
            this.keruletLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kerulet
            // 
            this.kerulet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kerulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.kerulet.Location = new System.Drawing.Point(631, 444);
            this.kerulet.Name = "kerulet";
            this.kerulet.Size = new System.Drawing.Size(100, 23);
            this.kerulet.TabIndex = 22;
            this.kerulet.Text = "???";
            this.kerulet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teruletLabel
            // 
            this.teruletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.teruletLabel.Location = new System.Drawing.Point(288, 444);
            this.teruletLabel.Name = "teruletLabel";
            this.teruletLabel.Size = new System.Drawing.Size(100, 23);
            this.teruletLabel.TabIndex = 23;
            this.teruletLabel.Text = "terület:";
            this.teruletLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // terulet
            // 
            this.terulet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.terulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.terulet.Location = new System.Drawing.Point(394, 444);
            this.terulet.Name = "terulet";
            this.terulet.Size = new System.Drawing.Size(100, 23);
            this.terulet.TabIndex = 24;
            this.terulet.Text = "???";
            this.terulet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DolgozatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.terulet);
            this.Controls.Add(this.teruletLabel);
            this.Controls.Add(this.kerulet);
            this.Controls.Add(this.keruletLabel);
            this.Controls.Add(this.atfogo);
            this.Controls.Add(this.atfogoLabel);
            this.Controls.Add(this.calculateTriangleBtn);
            this.Controls.Add(this.befogo2);
            this.Controls.Add(this.befogo2Label);
            this.Controls.Add(this.befogo1);
            this.Controls.Add(this.befogo1Label);
            this.Controls.Add(this.textAppropriateLabel);
            this.Controls.Add(this.textRecordTextBoxLabel);
            this.Controls.Add(this.textRecordBtn);
            this.Controls.Add(this.textRecordTextBox);
            this.Controls.Add(this.recordedLines);
            this.Controls.Add(this.cbUppercase);
            this.Controls.Add(this.btnFourth);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbYellow);
            this.Controls.Add(this.rbRed);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "DolgozatForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label atfogo;
        private System.Windows.Forms.Label keruletLabel;
        private System.Windows.Forms.Label kerulet;
        private System.Windows.Forms.Label teruletLabel;
        private System.Windows.Forms.Label terulet;

        private System.Windows.Forms.Label atfogoLabel;

        private System.Windows.Forms.Button calculateTriangleBtn;

        private System.Windows.Forms.TextBox befogo2;
        private System.Windows.Forms.Label befogo2Label;

        private System.Windows.Forms.TextBox befogo1;

        private System.Windows.Forms.Label befogo1Label;

        private System.Windows.Forms.Label textRecordTextBoxLabel;
        private System.Windows.Forms.Label textAppropriateLabel;

        private System.Windows.Forms.Button textRecordBtn;

        private System.Windows.Forms.TextBox textRecordTextBox;

        private System.Windows.Forms.RichTextBox recordedLines;

        private System.Windows.Forms.CheckBox cbUppercase;

        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnFourth;

        private System.Windows.Forms.Button btnFirst;

        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;

        #endregion
    }
}