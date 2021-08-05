
namespace CarsTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarVendor = new System.Windows.Forms.Label();
            this.lblCarYear = new System.Windows.Forms.Label();
            this.lblCarEngine = new System.Windows.Forms.Label();
            this.btnCarChanger = new System.Windows.Forms.Button();
            this.CarPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engine:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(112, 9);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(0, 25);
            this.lblCarModel.TabIndex = 5;
            // 
            // lblCarVendor
            // 
            this.lblCarVendor.AutoSize = true;
            this.lblCarVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarVendor.Location = new System.Drawing.Point(112, 43);
            this.lblCarVendor.Name = "lblCarVendor";
            this.lblCarVendor.Size = new System.Drawing.Size(0, 25);
            this.lblCarVendor.TabIndex = 6;
            // 
            // lblCarYear
            // 
            this.lblCarYear.AutoSize = true;
            this.lblCarYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarYear.Location = new System.Drawing.Point(112, 77);
            this.lblCarYear.Name = "lblCarYear";
            this.lblCarYear.Size = new System.Drawing.Size(0, 25);
            this.lblCarYear.TabIndex = 7;
            // 
            // lblCarEngine
            // 
            this.lblCarEngine.AutoSize = true;
            this.lblCarEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarEngine.Location = new System.Drawing.Point(112, 111);
            this.lblCarEngine.Name = "lblCarEngine";
            this.lblCarEngine.Size = new System.Drawing.Size(0, 25);
            this.lblCarEngine.TabIndex = 8;
            // 
            // btnCarChanger
            // 
            this.btnCarChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCarChanger.Location = new System.Drawing.Point(117, 147);
            this.btnCarChanger.Name = "btnCarChanger";
            this.btnCarChanger.Size = new System.Drawing.Size(134, 38);
            this.btnCarChanger.TabIndex = 9;
            this.btnCarChanger.Text = "Change";
            this.btnCarChanger.UseVisualStyleBackColor = true;
            this.btnCarChanger.Click += new System.EventHandler(this.btnCarChanger_Click);
            // 
            // CarPicture
            // 
            this.CarPicture.Location = new System.Drawing.Point(257, 9);
            this.CarPicture.Name = "CarPicture";
            this.CarPicture.Size = new System.Drawing.Size(273, 185);
            this.CarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPicture.TabIndex = 4;
            this.CarPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(531, 197);
            this.Controls.Add(this.btnCarChanger);
            this.Controls.Add(this.lblCarEngine);
            this.Controls.Add(this.lblCarYear);
            this.Controls.Add(this.lblCarVendor);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.CarPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(547, 236);
            this.MinimumSize = new System.Drawing.Size(547, 236);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox CarPicture;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarVendor;
        private System.Windows.Forms.Label lblCarYear;
        private System.Windows.Forms.Label lblCarEngine;
        private System.Windows.Forms.Button btnCarChanger;
    }
}

