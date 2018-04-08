
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace PictureKey {

	public class CryptUtility {
		
		public static void HideMessageInBitmap(Stream messageStream, Bitmap bitmap, Stream keyStream, bool useGrayscale){
			HideOrExtract(ref messageStream, bitmap, keyStream, false, useGrayscale);
			messageStream = null;
		}
		public static void ExtractMessageFromBitmap(Bitmap bitmap, Stream keyStream, ref Stream messageStream){
			HideOrExtract(ref messageStream, bitmap, keyStream, true, false);
		}

		private static void HideOrExtract(ref Stream messageStream, Bitmap bitmap, Stream keyStream, bool extract, bool useGrayscale){
		
			int currentStepWidth = 0;
			byte currentKeyByte;
			byte currentReverseKeyByte;
			long keyPosition;
			int bitmapWidth = bitmap.Width-1;
			int bitmapHeight = bitmap.Height-1;
			int currentColorComponent = 0;
			Color pixelColor;
			Int32 messageLength;

			if(extract){
				pixelColor = bitmap.GetPixel(0,0);
				messageLength = (pixelColor.R << 2) + (pixelColor.G << 1) + pixelColor.B;
				messageStream = new MemoryStream(messageLength);
			}else{
				
				messageLength = (Int32)messageStream.Length;

				if(messageStream.Length >= 16777215){ //The message is too long
					String exceptionMessage = "Themessage is too long, only 16777215 bytes are allowed.";
					throw new Exception(exceptionMessage);
				}
		
				long countPixels = (bitmapWidth*bitmapHeight) -1;
				long countRequiredPixels = 1;
				while((keyStream.Position < keyStream.Length)&&(keyStream.Position < messageLength)){
					countRequiredPixels += keyStream.ReadByte();
				}
				
				countRequiredPixels *= (long)System.Math.Ceiling( ((float)messageStream.Length / (float)keyStream.Length) );

				if(countRequiredPixels > countPixels){ //The bitmap is too small
					String exceptionMessage = "The image is too small for this message and key. "+countRequiredPixels+" pixels are required.";
					throw new Exception(exceptionMessage);
				}
				
				int colorValue = messageLength;
				int red = colorValue >> 2;
				colorValue -= red << 2;
				int green = colorValue >> 1;
				int blue = colorValue - (green << 1);
				pixelColor = Color.FromArgb(red, green, blue);
				bitmap.SetPixel(0,0, pixelColor);
			}
			
			keyStream.Seek(0, SeekOrigin.Begin);
			messageStream.Seek(0, SeekOrigin.Begin);
			Point pixelPosition = new Point(1,0);

			for(int messageIndex=0; messageIndex<messageLength; messageIndex++){
    				if(keyStream.Position == keyStream.Length){
					keyStream.Seek(0, SeekOrigin.Begin);
				}
				currentKeyByte = (byte)keyStream.ReadByte();
				currentStepWidth = (currentKeyByte==0) ? (byte)1 : currentKeyByte;
				keyPosition = keyStream.Position;
				keyStream.Seek(-keyPosition, SeekOrigin.End);
				currentReverseKeyByte = (byte)keyStream.ReadByte();
				keyStream.Seek(keyPosition, SeekOrigin.Begin);
				while(currentStepWidth > bitmapWidth){
				    currentStepWidth -= bitmapWidth;
					pixelPosition.Y++;
				}
				
				if((bitmapWidth - pixelPosition.X) < currentStepWidth){
					pixelPosition.X = currentStepWidth - (bitmapWidth - pixelPosition.X);	
					pixelPosition.Y++;
				}else{
					pixelPosition.X += currentStepWidth;
				}
				pixelColor = bitmap.GetPixel(pixelPosition.X, pixelPosition.Y);

				if(extract){
					byte foundByte = (byte)(currentReverseKeyByte ^ GetColorComponent(pixelColor, currentColorComponent));
					messageStream.WriteByte(foundByte);
					currentColorComponent = (currentColorComponent==2) ? 0 : (currentColorComponent+1);

				}else{
					int currentByte = messageStream.ReadByte() ^ currentReverseKeyByte;
					
					if(useGrayscale){
						pixelColor = Color.FromArgb(currentByte, currentByte, currentByte);
					}else{
						SetColorComponent(ref pixelColor, currentColorComponent, currentByte);
						currentColorComponent = (currentColorComponent==2) ? 0 : (currentColorComponent+1);
					}
					bitmap.SetPixel(pixelPosition.X, pixelPosition.Y, pixelColor);
				}
			}

			bitmap = null;
			keyStream = null;
		}

		private static byte GetColorComponent(Color pixelColor, int colorComponent){
			byte returnValue = 0;
			switch(colorComponent){
				case 0:
					returnValue = pixelColor.R;
					break;
				case 1:
					returnValue = pixelColor.G;
					break;
				case 2:
					returnValue = pixelColor.B;
					break;
			}
			return returnValue;
		}

		private static void SetColorComponent(ref Color pixelColor, int colorComponent, int newValue){
			switch(colorComponent){
				case 0:
					pixelColor = Color.FromArgb(newValue, pixelColor.G, pixelColor.B);
					break;
				case 1:
					pixelColor = Color.FromArgb(pixelColor.R, newValue, pixelColor.B);
					break;
				case 2:
					pixelColor = Color.FromArgb(pixelColor.R, pixelColor.G, newValue);
					break;
			}
		}

		private static String UnTrimColorString(String color, int desiredLength){
			int difference = desiredLength - color.Length;
			if(difference > 0){
				color = new String('0', difference) + color;
			}
			return color;
		}

	}
}
