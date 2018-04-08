using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace PictureKey
{
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpPicture;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtImageFile;
		private System.Windows.Forms.PictureBox picImage;
		private System.Windows.Forms.Button btnImageFile;
		private System.Windows.Forms.TextBox txtKeyFile;
		private System.Windows.Forms.RadioButton rdoKeyText;
		private System.Windows.Forms.GroupBox grpKey;
		private System.Windows.Forms.TextBox txtKeyText;
		private System.Windows.Forms.RadioButton rdoKeyFile;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.Button btnExtract;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnSaveBitmap;
		private System.Windows.Forms.GroupBox grpMessage;
		private System.Windows.Forms.RadioButton rdoMessageText;
		private System.Windows.Forms.TextBox txtMessageFile;
		private System.Windows.Forms.TextBox txtMessageText;
		private System.Windows.Forms.Button btnMessage;
		private System.Windows.Forms.RadioButton rdoMessageFile;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnKeyFile;
		private System.Windows.Forms.TextBox txtExtractedMsgFile;
		private System.Windows.Forms.Button btnExtractedMsgFile;
		private System.Windows.Forms.TextBox txtExtractedMsgText;
		private System.Windows.Forms.CheckBox chkGrayscale;
		
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpPicture = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtImageFile = new System.Windows.Forms.TextBox();
			this.picImage = new System.Windows.Forms.PictureBox();
			this.btnImageFile = new System.Windows.Forms.Button();
			this.txtKeyFile = new System.Windows.Forms.TextBox();
			this.rdoKeyText = new System.Windows.Forms.RadioButton();
			this.grpKey = new System.Windows.Forms.GroupBox();
			this.txtKeyText = new System.Windows.Forms.TextBox();
			this.btnKeyFile = new System.Windows.Forms.Button();
			this.rdoKeyFile = new System.Windows.Forms.RadioButton();
			this.btnHide = new System.Windows.Forms.Button();
			this.btnExtract = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.grpMessage = new System.Windows.Forms.GroupBox();
			this.rdoMessageText = new System.Windows.Forms.RadioButton();
			this.txtMessageFile = new System.Windows.Forms.TextBox();
			this.txtMessageText = new System.Windows.Forms.TextBox();
			this.btnMessage = new System.Windows.Forms.Button();
			this.rdoMessageFile = new System.Windows.Forms.RadioButton();
			this.btnSaveBitmap = new System.Windows.Forms.Button();
			this.chkGrayscale = new System.Windows.Forms.CheckBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtExtractedMsgFile = new System.Windows.Forms.TextBox();
			this.txtExtractedMsgText = new System.Windows.Forms.TextBox();
			this.btnExtractedMsgFile = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.grpPicture.SuspendLayout();
			this.grpKey.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.grpMessage.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpPicture
			// 
			this.grpPicture.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.label2,
																					 this.txtImageFile,
																					 this.picImage,
																					 this.btnImageFile});
			this.grpPicture.Location = new System.Drawing.Point(16, 16);
			this.grpPicture.Name = "grpPicture";
			this.grpPicture.Size = new System.Drawing.Size(480, 296);
			this.grpPicture.TabIndex = 0;
			this.grpPicture.TabStop = false;
			this.grpPicture.Text = "Carrier Bitmap (no image loaded)";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Filename";
			// 
			// txtImageFile
			// 
			this.txtImageFile.Location = new System.Drawing.Point(88, 32);
			this.txtImageFile.Name = "txtImageFile";
			this.txtImageFile.Size = new System.Drawing.Size(296, 22);
			this.txtImageFile.TabIndex = 0;
			this.txtImageFile.Text = "";
			this.txtImageFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImageFile_KeyDown);
			// 
			// picImage
			// 
			this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picImage.Location = new System.Drawing.Point(16, 64);
			this.picImage.Name = "picImage";
			this.picImage.Size = new System.Drawing.Size(448, 216);
			this.picImage.TabIndex = 0;
			this.picImage.TabStop = false;
			// 
			// btnImageFile
			// 
			this.btnImageFile.Location = new System.Drawing.Point(384, 32);
			this.btnImageFile.Name = "btnImageFile";
			this.btnImageFile.Size = new System.Drawing.Size(80, 23);
			this.btnImageFile.TabIndex = 1;
			this.btnImageFile.Text = "Browse...";
			this.btnImageFile.Click += new System.EventHandler(this.btnImageFile_Click);
			// 
			// txtKeyFile
			// 
			this.txtKeyFile.Location = new System.Drawing.Point(112, 24);
			this.txtKeyFile.Name = "txtKeyFile";
			this.txtKeyFile.Size = new System.Drawing.Size(272, 22);
			this.txtKeyFile.TabIndex = 1;
			this.txtKeyFile.Text = "";
			// 
			// rdoKeyText
			// 
			this.rdoKeyText.Checked = true;
			this.rdoKeyText.Location = new System.Drawing.Point(16, 56);
			this.rdoKeyText.Name = "rdoKeyText";
			this.rdoKeyText.Size = new System.Drawing.Size(80, 24);
			this.rdoKeyText.TabIndex = 3;
			this.rdoKeyText.TabStop = true;
			this.rdoKeyText.Text = "Text";
			this.rdoKeyText.Click += new System.EventHandler(this.rdoKey_Click);
			// 
			// grpKey
			// 
			this.grpKey.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.rdoKeyText,
																				 this.txtKeyFile,
																				 this.txtKeyText,
																				 this.btnKeyFile,
																				 this.rdoKeyFile});
			this.grpKey.Location = new System.Drawing.Point(16, 320);
			this.grpKey.Name = "grpKey";
			this.grpKey.Size = new System.Drawing.Size(480, 96);
			this.grpKey.TabIndex = 1;
			this.grpKey.TabStop = false;
			this.grpKey.Text = "Key";
			// 
			// txtKeyText
			// 
			this.txtKeyText.Location = new System.Drawing.Point(112, 56);
			this.txtKeyText.Name = "txtKeyText";
			this.txtKeyText.Size = new System.Drawing.Size(352, 22);
			this.txtKeyText.TabIndex = 4;
			this.txtKeyText.Text = "";
			// 
			// btnKeyFile
			// 
			this.btnKeyFile.Location = new System.Drawing.Point(384, 24);
			this.btnKeyFile.Name = "btnKeyFile";
			this.btnKeyFile.Size = new System.Drawing.Size(80, 23);
			this.btnKeyFile.TabIndex = 2;
			this.btnKeyFile.Text = "Browse...";
			this.btnKeyFile.Click += new System.EventHandler(this.btnKeyFile_Click);
			// 
			// rdoKeyFile
			// 
			this.rdoKeyFile.Location = new System.Drawing.Point(16, 24);
			this.rdoKeyFile.Name = "rdoKeyFile";
			this.rdoKeyFile.Size = new System.Drawing.Size(88, 24);
			this.rdoKeyFile.TabIndex = 0;
			this.rdoKeyFile.Text = "Filename";
			this.rdoKeyFile.Click += new System.EventHandler(this.rdoKey_Click);
			// 
			// btnHide
			// 
			this.btnHide.Enabled = false;
			this.btnHide.Location = new System.Drawing.Point(280, 296);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(160, 23);
			this.btnHide.TabIndex = 2;
			this.btnHide.Text = "Hide Message";
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// btnExtract
			// 
			this.btnExtract.Enabled = false;
			this.btnExtract.Location = new System.Drawing.Point(280, 328);
			this.btnExtract.Name = "btnExtract";
			this.btnExtract.Size = new System.Drawing.Size(160, 23);
			this.btnExtract.TabIndex = 2;
			this.btnExtract.Text = "Extract Hidden Text";
			this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2});
			this.tabControl1.Location = new System.Drawing.Point(504, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(464, 392);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.grpMessage,
																				   this.btnHide,
																				   this.btnSaveBitmap,
																				   this.chkGrayscale});
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(456, 363);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Hide";
			// 
			// grpMessage
			// 
			this.grpMessage.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.rdoMessageText,
																					 this.txtMessageFile,
																					 this.txtMessageText,
																					 this.btnMessage,
																					 this.rdoMessageFile});
			this.grpMessage.Location = new System.Drawing.Point(16, 16);
			this.grpMessage.Name = "grpMessage";
			this.grpMessage.Size = new System.Drawing.Size(424, 264);
			this.grpMessage.TabIndex = 0;
			this.grpMessage.TabStop = false;
			this.grpMessage.Text = "Message";
			// 
			// rdoMessageText
			// 
			this.rdoMessageText.Checked = true;
			this.rdoMessageText.Location = new System.Drawing.Point(16, 48);
			this.rdoMessageText.Name = "rdoMessageText";
			this.rdoMessageText.Size = new System.Drawing.Size(72, 24);
			this.rdoMessageText.TabIndex = 3;
			this.rdoMessageText.TabStop = true;
			this.rdoMessageText.Text = "Text";
			this.rdoMessageText.Click += new System.EventHandler(this.rdoMessage_Click);
			// 
			// txtMessageFile
			// 
			this.txtMessageFile.Location = new System.Drawing.Point(104, 24);
			this.txtMessageFile.Name = "txtMessageFile";
			this.txtMessageFile.Size = new System.Drawing.Size(232, 22);
			this.txtMessageFile.TabIndex = 1;
			this.txtMessageFile.Text = "";
			this.txtMessageFile.Enter += new System.EventHandler(this.txtMessageFile_Enter);
			// 
			// txtMessageText
			// 
			this.txtMessageText.Location = new System.Drawing.Point(8, 72);
			this.txtMessageText.Multiline = true;
			this.txtMessageText.Name = "txtMessageText";
			this.txtMessageText.Size = new System.Drawing.Size(408, 176);
			this.txtMessageText.TabIndex = 4;
			this.txtMessageText.Text = "";
			this.txtMessageText.Enter += new System.EventHandler(this.txtMessageText_Enter);
			// 
			// btnMessage
			// 
			this.btnMessage.Location = new System.Drawing.Point(336, 24);
			this.btnMessage.Name = "btnMessage";
			this.btnMessage.Size = new System.Drawing.Size(80, 23);
			this.btnMessage.TabIndex = 2;
			this.btnMessage.Text = "Browse...";
			this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
			// 
			// rdoMessageFile
			// 
			this.rdoMessageFile.Location = new System.Drawing.Point(16, 24);
			this.rdoMessageFile.Name = "rdoMessageFile";
			this.rdoMessageFile.Size = new System.Drawing.Size(88, 24);
			this.rdoMessageFile.TabIndex = 0;
			this.rdoMessageFile.Text = "Filename";
			this.rdoMessageFile.Click += new System.EventHandler(this.rdoMessage_Click);
			// 
			// btnSaveBitmap
			// 
			this.btnSaveBitmap.Enabled = false;
			this.btnSaveBitmap.Location = new System.Drawing.Point(280, 328);
			this.btnSaveBitmap.Name = "btnSaveBitmap";
			this.btnSaveBitmap.Size = new System.Drawing.Size(160, 23);
			this.btnSaveBitmap.TabIndex = 3;
			this.btnSaveBitmap.Text = "Save Result";
			this.btnSaveBitmap.Click += new System.EventHandler(this.btnSaveBitmap_Click);
			// 
			// chkGrayscale
			// 
			this.chkGrayscale.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.chkGrayscale.Checked = true;
			this.chkGrayscale.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkGrayscale.Location = new System.Drawing.Point(16, 296);
			this.chkGrayscale.Name = "chkGrayscale";
			this.chkGrayscale.Size = new System.Drawing.Size(176, 24);
			this.chkGrayscale.TabIndex = 1;
			this.chkGrayscale.Text = "Produce grayscale noise";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.groupBox3,
																				   this.btnExtract});
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(456, 363);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Extract";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label1,
																					this.txtExtractedMsgFile,
																					this.txtExtractedMsgText,
																					this.btnExtractedMsgFile,
																					this.label3});
			this.groupBox3.Location = new System.Drawing.Point(16, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(424, 296);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Nachricht";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(376, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Save Extracted Message to File";
			// 
			// txtExtractedMsgFile
			// 
			this.txtExtractedMsgFile.Location = new System.Drawing.Point(16, 48);
			this.txtExtractedMsgFile.Name = "txtExtractedMsgFile";
			this.txtExtractedMsgFile.Size = new System.Drawing.Size(312, 22);
			this.txtExtractedMsgFile.TabIndex = 0;
			this.txtExtractedMsgFile.Text = "";
			// 
			// txtExtractedMsgText
			// 
			this.txtExtractedMsgText.Location = new System.Drawing.Point(16, 112);
			this.txtExtractedMsgText.Multiline = true;
			this.txtExtractedMsgText.Name = "txtExtractedMsgText";
			this.txtExtractedMsgText.ReadOnly = true;
			this.txtExtractedMsgText.Size = new System.Drawing.Size(392, 176);
			this.txtExtractedMsgText.TabIndex = 5;
			this.txtExtractedMsgText.Text = "";
			// 
			// btnExtractedMsgFile
			// 
			this.btnExtractedMsgFile.Location = new System.Drawing.Point(328, 48);
			this.btnExtractedMsgFile.Name = "btnExtractedMsgFile";
			this.btnExtractedMsgFile.Size = new System.Drawing.Size(80, 23);
			this.btnExtractedMsgFile.TabIndex = 1;
			this.btnExtractedMsgFile.Text = "Browse...";
			this.btnExtractedMsgFile.Click += new System.EventHandler(this.btnExtractedMsgFile_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(376, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Extracted UnicodeText";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(984, 431);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1,
																		  this.grpPicture,
																		  this.grpKey});
			this.Name = "frmMain";
			this.Text = "Use this on your own risk - for help and bug reports contact picturekey@binary-un" +
				"iverse.net";
			this.grpPicture.ResumeLayout(false);
			this.grpKey.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.grpMessage.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void btnHide_Click(object sender, System.EventArgs e) {
			Bitmap bitmap = (Bitmap)picImage.Image;
			
			Stream messageStream = GetMessageStream();
			if(messageStream.Length == 0){
				MessageBox.Show("Please enter a message or select a file.");
				txtMessageText.Focus();
			}else{
				Stream keyStream = GetKeyStream();
				if(keyStream.Length == 0){
					MessageBox.Show("Please enter a password or select a key file.");
					txtKeyText.Focus();
				}else{
				
					try{
						//hide the message
						CryptUtility.HideMessageInBitmap(messageStream, bitmap, keyStream, chkGrayscale.Checked);
						//display result
						picImage.Image = bitmap;
						btnSaveBitmap.Enabled = true;
					}catch(Exception ex){
						MessageBox.Show("Exception:\r\n"+ex.Message);
					}
				}
				keyStream.Close();
			}
			messageStream.Close();
			bitmap = null;
		}

		private void btnExtract_Click(object sender, System.EventArgs e) {
			Bitmap bitmap = (Bitmap)picImage.Image;
			Stream messageStream = new MemoryStream();
			Stream keyStream = GetKeyStream();
			if(keyStream.Length == 0){
				MessageBox.Show("Please enter a password or select a key file.");
				txtKeyText.Focus();
			}else{
			
				try{
					CryptUtility.ExtractMessageFromBitmap(bitmap, keyStream, ref messageStream);
					if(txtExtractedMsgFile.Text.Length > 0){
						messageStream.Seek(0, SeekOrigin.Begin);
						FileStream fs = new FileStream(txtExtractedMsgFile.Text, FileMode.Create);
						byte[] streamContent = new Byte[messageStream.Length];
						messageStream.Read(streamContent, 0, streamContent.Length);
						fs.Write(streamContent, 0, streamContent.Length);
					}

					messageStream.Seek(0, SeekOrigin.Begin);
					StreamReader reader = new StreamReader(messageStream, UnicodeEncoding.Unicode);
					String readerContent = reader.ReadToEnd();
					if(readerContent.Length > txtExtractedMsgText.MaxLength){
						readerContent = readerContent.Substring(0, txtExtractedMsgText.MaxLength);
					}
					txtExtractedMsgText.Text = readerContent;
				}catch(Exception ex){
					MessageBox.Show("Exception:\r\n"+ex.Message);
				}
			}
			messageStream.Close();
			keyStream.Close();
			bitmap = null;
		}

		private Stream GetMessageStream(){
			Stream messageStream;
			if(rdoMessageText.Checked){
				byte[] messageBytes = UnicodeEncoding.Unicode.GetBytes(txtMessageText.Text);
				messageStream = new MemoryStream(messageBytes);
			}else{
				messageStream = new FileStream(txtMessageFile.Text, FileMode.Open, FileAccess.Read);
			}
			return messageStream;
		}

		private Stream GetKeyStream(){
			Stream keyStream;
			if(rdoKeyText.Checked){
				byte[] keyBytes = UnicodeEncoding.Unicode.GetBytes(txtKeyText.Text);
				keyStream = new MemoryStream(keyBytes);
			}else{
				keyStream = new FileStream(txtKeyFile.Text, FileMode.Open, FileAccess.Read);
			}
			return keyStream;
		}

		private void SetImage(String fileName){
			picImage.Image = new Bitmap(fileName);

			btnHide.Enabled = btnExtract.Enabled = true;
			btnSaveBitmap.Enabled = false;
			
			int index = fileName.LastIndexOf("\\")+1;
			if(index > 0){ fileName = fileName.Substring(index); }
			grpPicture.Text = "Carrier Bitmap ("+fileName+")";
		}

		private String GetFileName(String filter){
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Multiselect = false;
			if(filter.Length > 0){ dlg.Filter = filter; }

			if( dlg.ShowDialog(this) != DialogResult.Cancel){
				return dlg.FileName;
			}else{
				return null;
			}
		}

		private void rdoMessage_Click(object sender, System.EventArgs e) {
			txtMessageFile.Enabled = rdoMessageFile.Checked;
			txtMessageText.Enabled = rdoMessageText.Checked;
		}

		private void rdoKey_Click(object sender, System.EventArgs e) {
			txtKeyFile.Enabled = rdoKeyFile.Checked;
			txtKeyText.Enabled = rdoKeyText.Checked;
		}

		private void btnImageFile_Click(object sender, System.EventArgs e) {
			String fileName = GetFileName("Bitmaps (*.bmp)|*.bmp|Tagged Image File Format(*.tif)|*.tif|PNG-24(*.png)|*.png");
			if(fileName != null){
				txtImageFile.Text = fileName;
				SetImage(fileName);
			}
		}

		private void btnSaveBitmap_Click(object sender, System.EventArgs e) {
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Bitmaps (*.bmp)|*.bmp|Tagged Image File Format(*.tif)|*.tif|PNG-24(*.png)|*.png";
			if( dlg.ShowDialog() == DialogResult.OK ){
				
				System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Bmp;

				if(dlg.FilterIndex == 2){
					format = System.Drawing.Imaging.ImageFormat.Tiff;
				}else if(dlg.FilterIndex == 3){
					format = System.Drawing.Imaging.ImageFormat.Png;
				}
				
				Image img = new Bitmap(picImage.Image);
				
				this.SuspendLayout();
				picImage.Image.Dispose();
				picImage.Image = null;
				btnSaveBitmap.Enabled = btnHide.Enabled = btnExtract.Enabled = false;
				txtImageFile.Text = String.Empty;
				this.ResumeLayout();

				img.Save(dlg.FileName, format);
			}
		}

		private void txtMessageFile_Enter(object sender, System.EventArgs e) {
			rdoKeyFile.Checked = true;
		}

		private void txtMessageText_Enter(object sender, System.EventArgs e) {
			rdoKeyText.Checked = true;
		}

		private void txtImageFile_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter){
				SetImage(txtImageFile.Text);
			}
		}

		private void btnMessage_Click(object sender, System.EventArgs e) {
			String fileName = GetFileName(String.Empty);
			if(fileName != null){
				txtMessageFile.Text = fileName;
				rdoMessageFile.Checked = true;
			}
		}

		private void btnExtractedMsgFile_Click(object sender, System.EventArgs e) {
			SaveFileDialog dlg = new SaveFileDialog();
			if( dlg.ShowDialog() == DialogResult.OK ){
				txtExtractedMsgFile.Text = dlg.FileName;
			}			
		}

		private void btnKeyFile_Click(object sender, System.EventArgs e) {
			String fileName = GetFileName(String.Empty);
			if(fileName != null){
				txtKeyFile.Text = fileName;
				rdoKeyFile.Checked = true;
			}
		}
	}
}
