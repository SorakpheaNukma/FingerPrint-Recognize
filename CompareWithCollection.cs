﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for CompareWithCollection.
	/// </summary>
	public class CompareWithCollection : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtFolderName;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.ListBox ltResult;
		private System.Windows.Forms.Label label1;

		private ImageData image;
		private FileInfo[] fileList;
		private System.Windows.Forms.FolderBrowserDialog folder;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CompareWithCollection()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.ltResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(259, 18);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(298, 30);
            this.txtFolderName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Các mẫu vân";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mở vân tay";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tìm kiếm";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic.Location = new System.Drawing.Point(19, 55);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(307, 296);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // ltResult
            // 
            this.ltResult.ItemHeight = 22;
            this.ltResult.Location = new System.Drawing.Point(346, 148);
            this.ltResult.Name = "ltResult";
            this.ltResult.Size = new System.Drawing.Size(220, 180);
            this.ltResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(346, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Các mẫu trùng khớp";
            // 
            // CompareWithCollection
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 23);
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltResult);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFolderName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CompareWithCollection";
            this.Text = "CompareWithCollection";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();			
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				image = new ImageData(dlg.FileName,FingerCompare.widthSquare);
				pic.Image = image.ToBitmap();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//FolderBrowserDialog folder = new FolderBrowserDialog();
			if(folder.ShowDialog()== DialogResult.OK)
			{
				txtFolderName.Text = folder.SelectedPath;
				DirectoryInfo dic = new DirectoryInfo(folder.SelectedPath);
				fileList = dic.GetFiles();
				//for(int i=0;i<fileList.Length;i++)
					//listBox1.Items.Add(fileList[i].Name);
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			for(int i=0;i<fileList.Length;i++)
			{
				ImageData imageT = new ImageData(fileList[i].FullName,FingerCompare.widthSquare);				
			}
		}
		private int Compare(ImageData image1,ImageData image2)
		{
			return 0;
		}
	}
}
