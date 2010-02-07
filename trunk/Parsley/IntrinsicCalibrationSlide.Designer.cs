﻿namespace Parsley {
  partial class IntrinsicCalibrationSlide {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntrinsicCalibrationSlide));
      this._cb_auto_take = new System.Windows.Forms.CheckBox();
      this._btn_calibrate = new Parsley.UI.ParsleyButtonSmall();
      this._btn_take_image = new Parsley.UI.ParsleyButtonSmall();
      this.growLabel3 = new Parsley.UI.GrowLabel();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // growLabel1
      // 
      this.growLabel1.Size = new System.Drawing.Size(392, 30);
      // 
      // _cb_auto_take
      // 
      this._cb_auto_take.AutoSize = true;
      this._cb_auto_take.Location = new System.Drawing.Point(149, 215);
      this._cb_auto_take.Name = "_cb_auto_take";
      this._cb_auto_take.Size = new System.Drawing.Size(118, 19);
      this._cb_auto_take.TabIndex = 9;
      this._cb_auto_take.Text = "Auto take images";
      this._cb_auto_take.UseVisualStyleBackColor = true;
      this._cb_auto_take.CheckedChanged += new System.EventHandler(this._cb_auto_take_CheckedChanged);
      // 
      // _btn_calibrate
      // 
      this._btn_calibrate.BackColor = System.Drawing.Color.White;
      this._btn_calibrate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this._btn_calibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this._btn_calibrate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btn_calibrate.ForeColor = System.Drawing.Color.Black;
      this._btn_calibrate.Image = ((System.Drawing.Image)(resources.GetObject("_btn_calibrate.Image")));
      this._btn_calibrate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_calibrate.Location = new System.Drawing.Point(3, 279);
      this._btn_calibrate.Name = "_btn_calibrate";
      this._btn_calibrate.Size = new System.Drawing.Size(142, 27);
      this._btn_calibrate.TabIndex = 14;
      this._btn_calibrate.Text = "Calibrate";
      this._btn_calibrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_calibrate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this._btn_calibrate.UseVisualStyleBackColor = true;
      this._btn_calibrate.Click += new System.EventHandler(this.btn_calibrate_Click);
      // 
      // _btn_take_image
      // 
      this._btn_take_image.BackColor = System.Drawing.Color.White;
      this._btn_take_image.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this._btn_take_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this._btn_take_image.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btn_take_image.ForeColor = System.Drawing.Color.Black;
      this._btn_take_image.Image = ((System.Drawing.Image)(resources.GetObject("_btn_take_image.Image")));
      this._btn_take_image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_take_image.Location = new System.Drawing.Point(1, 210);
      this._btn_take_image.Name = "_btn_take_image";
      this._btn_take_image.Size = new System.Drawing.Size(142, 27);
      this._btn_take_image.TabIndex = 15;
      this._btn_take_image.Text = "Take Image";
      this._btn_take_image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_take_image.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this._btn_take_image.UseVisualStyleBackColor = true;
      this._btn_take_image.Click += new System.EventHandler(this.btn_take_image_Click);
      // 
      // growLabel3
      // 
      this.growLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.growLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.growLabel3.Location = new System.Drawing.Point(0, 249);
      this.growLabel3.Name = "growLabel3";
      this.growLabel3.Size = new System.Drawing.Size(392, 15);
      this.growLabel3.TabIndex = 16;
      this.growLabel3.Text = "Perform the calibration, once you have acquired enough images.";
      this.growLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
      this.richTextBox1.Location = new System.Drawing.Point(1, 33);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(388, 171);
      this.richTextBox1.TabIndex = 17;
      this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
      this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
      // 
      // IntrinsicCalibrationSlide
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.growLabel3);
      this.Controls.Add(this._btn_take_image);
      this.Controls.Add(this._btn_calibrate);
      this.Controls.Add(this._cb_auto_take);
      this.Name = "IntrinsicCalibrationSlide";
      this.Size = new System.Drawing.Size(392, 376);
      this.Controls.SetChildIndex(this.growLabel1, 0);
      this.Controls.SetChildIndex(this._cb_auto_take, 0);
      this.Controls.SetChildIndex(this._btn_calibrate, 0);
      this.Controls.SetChildIndex(this._btn_take_image, 0);
      this.Controls.SetChildIndex(this.growLabel3, 0);
      this.Controls.SetChildIndex(this.richTextBox1, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox _cb_auto_take;
    private Parsley.UI.ParsleyButtonSmall _btn_calibrate;
    private Parsley.UI.ParsleyButtonSmall _btn_take_image;
    private Parsley.UI.GrowLabel growLabel3;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}