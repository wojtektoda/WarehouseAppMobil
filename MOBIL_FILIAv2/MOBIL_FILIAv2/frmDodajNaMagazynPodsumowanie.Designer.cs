﻿namespace MOBIL_FILIAv2
{
    partial class frmDodajNaMagazynPodsumowanie
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
            this.components = new System.ComponentModel.Container();
            this.pozycjeNaMagazynBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.localDBDataSet = new MOBIL_FILIAv2.LocalDBDataSet();
            this.pozycjeNaMagazynTableAdapter = new MOBIL_FILIAv2.LocalDBDataSetTableAdapters.PozycjeNaMagazynTableAdapter();

            this.tWRMAGAZYNYBindingSource = new System.Windows.Forms.BindingSource(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.pozycjeNaMagazynBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.tWRMAGAZYNYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pozycjeNaMagazynBindingSource
            // 
            this.pozycjeNaMagazynBindingSource.DataMember = "PozycjeNaMagazyn";
            this.pozycjeNaMagazynBindingSource.DataSource = this.localDBDataSet;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataSource = this.pozycjeNaMagazynBindingSource;
            this.dataGrid1.Location = new System.Drawing.Point(9, 3);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(463, 506);
            this.dataGrid1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "DODAJ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "USUŃ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "WYJSCIE";
            // 
            // localDBDataSet
            // 
            this.localDBDataSet.DataSetName = "LocalDBDataSet";
            this.localDBDataSet.Prefix = "";
            this.localDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pozycjeNaMagazynTableAdapter
            // 
            this.pozycjeNaMagazynTableAdapter.ClearBeforeFill = true;


            // 
            // frmDodajNaMagazynPodsumowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "frmDodajNaMagazynPodsumowanie";
            this.Text = "frmDodajNaMagazynPodsumowanie";
            this.Load += new System.EventHandler(this.frmDodajNaMagazynPodsumowanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pozycjeNaMagazynBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWRMAGAZYNYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource tWRMAGAZYNYBindingSource;
        private LocalDBDataSet localDBDataSet;
        private System.Windows.Forms.BindingSource pozycjeNaMagazynBindingSource;
        private MOBIL_FILIAv2.LocalDBDataSetTableAdapters.PozycjeNaMagazynTableAdapter pozycjeNaMagazynTableAdapter;
    }
}