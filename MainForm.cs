/*
 * Created by SharpDevelop.
 * User: David Ledford
 Date: 11/5/2011
 * Time: 3:29 AM
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Linq;
using System.Text;
using System.Data;

namespace Writer
{
	/// <summary>
	/// Writes your own thoughts to a .txt file. Encrypts the text file so it cannot be read.
	/// Decrypts it only in the program so that you can read it.
	/// </summary> 
	public partial class MainForm : Form
	{
		public MainForm()
			
		{
			InitializeComponent();
		}
	
		
		void Button1Click(object sender, EventArgs e)
		{
			string timenow = DateTime.Now.ToString();
//Create directory to save the text in.
			Directory.CreateDirectory(@"Libraries\Documents\Writer");
//Encrypting before it is saved into journal using personal algorythm.			
TextBox1.Text = TextBox1.Text.Replace("Q", "Ê");
TextBox1.Text = TextBox1.Text.Replace("W", "©");
TextBox1.Text = TextBox1.Text.Replace("E", "·");
TextBox1.Text = TextBox1.Text.Replace("R", "Æ");
TextBox1.Text = TextBox1.Text.Replace("T", "º");
TextBox1.Text = TextBox1.Text.Replace("Y", "Ò");
TextBox1.Text = TextBox1.Text.Replace("U", "§");
TextBox1.Text = TextBox1.Text.Replace("I", "Ý");
TextBox1.Text = TextBox1.Text.Replace("O", "Ñ");
TextBox1.Text = TextBox1.Text.Replace("P", "À");
TextBox1.Text = TextBox1.Text.Replace("A", "Ö");
TextBox1.Text = TextBox1.Text.Replace("S", "Î");
TextBox1.Text = TextBox1.Text.Replace("D", "ⱪ");
TextBox1.Text = TextBox1.Text.Replace("F", "ϯ");
TextBox1.Text = TextBox1.Text.Replace("G", "«");
TextBox1.Text = TextBox1.Text.Replace("H", "á");
TextBox1.Text = TextBox1.Text.Replace("J", "¥");
TextBox1.Text = TextBox1.Text.Replace("K", "¶");
TextBox1.Text = TextBox1.Text.Replace("L", "Þ");
TextBox1.Text = TextBox1.Text.Replace("Z", "§");
TextBox1.Text = TextBox1.Text.Replace("X", "҉");
TextBox1.Text = TextBox1.Text.Replace("C", "Ҙ");
TextBox1.Text = TextBox1.Text.Replace("V", "Ç");
TextBox1.Text = TextBox1.Text.Replace("B", "à");
TextBox1.Text = TextBox1.Text.Replace("N", "³");
TextBox1.Text = TextBox1.Text.Replace("M", "í");
TextBox1.Text = TextBox1.Text.Replace("?", "Ю");
TextBox1.Text = TextBox1.Text.Replace(".", "Ѡ");
TextBox1.Text = TextBox1.Text.Replace("q", "۞");
TextBox1.Text = TextBox1.Text.Replace("w", "å");
TextBox1.Text = TextBox1.Text.Replace("e", "ݠ");
TextBox1.Text = TextBox1.Text.Replace("r", "ẙ");
TextBox1.Text = TextBox1.Text.Replace("t", "Ṟ");
TextBox1.Text = TextBox1.Text.Replace("y", "Ấ");
TextBox1.Text = TextBox1.Text.Replace("u", "&");
TextBox1.Text = TextBox1.Text.Replace("i", "Ẑ");
TextBox1.Text = TextBox1.Text.Replace("o", "ṹ");
TextBox1.Text = TextBox1.Text.Replace("p", "ḕ");
TextBox1.Text = TextBox1.Text.Replace("a", "ẞ");
TextBox1.Text = TextBox1.Text.Replace("s", "ₔ");
TextBox1.Text = TextBox1.Text.Replace("d", "Ῥ");
TextBox1.Text = TextBox1.Text.Replace("f", "ῼ");
TextBox1.Text = TextBox1.Text.Replace("g", "‰");
TextBox1.Text = TextBox1.Text.Replace("h", "₰");
TextBox1.Text = TextBox1.Text.Replace("j", "₳");
TextBox1.Text = TextBox1.Text.Replace("k", "₡");
TextBox1.Text = TextBox1.Text.Replace("l", "₲");
TextBox1.Text = TextBox1.Text.Replace("z", "☻");
TextBox1.Text = TextBox1.Text.Replace("x", "╚");
TextBox1.Text = TextBox1.Text.Replace("c", "☼");
TextBox1.Text = TextBox1.Text.Replace("v", "♠");
TextBox1.Text = TextBox1.Text.Replace("b", "Ⱨ");
TextBox1.Text = TextBox1.Text.Replace("n", "סּ");
TextBox1.Text = TextBox1.Text.Replace("m", "◙");


//String with dateTime and the input textBox to be added to the file.
string news = Environment.NewLine + DateTime.Now +Environment.NewLine + TextBox1.Text + Environment.NewLine;
			TextBox1.Text += timenow;
			//Using my own encryption tool to encrypt.
			//Now writing encrypted file to the test.txt file I have created.
			System.IO.StreamWriter file = new System.IO.StreamWriter(@"Libraries\Documents\Writer\updated.txt", true);
			file.Write(news);
			file.Close();
			TextBox1.Clear();

		}
		
		//Exit and cancel any writing.
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		//When checkbox is checked it will display the text after it is decrypted
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
			 System.IO.StreamReader myFile =
  			 new System.IO.StreamReader(@"Libraries\Documents\Writer\updated.txt");
			 string myString = myFile.ReadToEnd();
			 TextBox1.Text = myString;
			 myFile.Close();
			
			 //Decrypting the file using personal algorythm.
TextBox1.Text = TextBox1.Text.Replace("Ê", "Q");
TextBox1.Text = TextBox1.Text.Replace("©", "W");
TextBox1.Text = TextBox1.Text.Replace("·", "E");
TextBox1.Text = TextBox1.Text.Replace("Æ", "R");
TextBox1.Text = TextBox1.Text.Replace("º", "T");
TextBox1.Text = TextBox1.Text.Replace("Ò", "Y");
TextBox1.Text = TextBox1.Text.Replace("§", "U");
TextBox1.Text = TextBox1.Text.Replace("Ý", "I");
TextBox1.Text = TextBox1.Text.Replace("Ñ", "O");
TextBox1.Text = TextBox1.Text.Replace("À", "P");
TextBox1.Text = TextBox1.Text.Replace("Ö", "A");
TextBox1.Text = TextBox1.Text.Replace("Î", "S");
TextBox1.Text = TextBox1.Text.Replace("ⱪ", "D");
TextBox1.Text = TextBox1.Text.Replace("ϯ", "F");
TextBox1.Text = TextBox1.Text.Replace("«", "G");
TextBox1.Text = TextBox1.Text.Replace("á", "H");
TextBox1.Text = TextBox1.Text.Replace("¥", "J");
TextBox1.Text = TextBox1.Text.Replace("¶", "K");
TextBox1.Text = TextBox1.Text.Replace("Þ", "L");
TextBox1.Text = TextBox1.Text.Replace("§", "Z");
TextBox1.Text = TextBox1.Text.Replace("҉", "X");
TextBox1.Text = TextBox1.Text.Replace("Ҙ", "C");
TextBox1.Text = TextBox1.Text.Replace("Ç", "V");
TextBox1.Text = TextBox1.Text.Replace("à", "B");
TextBox1.Text = TextBox1.Text.Replace("³", "N");
TextBox1.Text = TextBox1.Text.Replace("í", "M");
TextBox1.Text = TextBox1.Text.Replace("Ю", "?");
TextBox1.Text = TextBox1.Text.Replace("Ѡ", ".");
TextBox1.Text = TextBox1.Text.Replace("۞", "q");
TextBox1.Text = TextBox1.Text.Replace("å", "w");
TextBox1.Text = TextBox1.Text.Replace("ݠ", "e");
TextBox1.Text = TextBox1.Text.Replace("ẙ", "r");
TextBox1.Text = TextBox1.Text.Replace("Ṟ", "t");
TextBox1.Text = TextBox1.Text.Replace("Ấ", "y");
TextBox1.Text = TextBox1.Text.Replace("&", "u");
TextBox1.Text = TextBox1.Text.Replace("Ẑ", "i");
TextBox1.Text = TextBox1.Text.Replace("ṹ", "o");
TextBox1.Text = TextBox1.Text.Replace("ḕ", "p");
TextBox1.Text = TextBox1.Text.Replace("ẞ", "a");
TextBox1.Text = TextBox1.Text.Replace("ₔ", "s");
TextBox1.Text = TextBox1.Text.Replace("Ῥ", "d");
TextBox1.Text = TextBox1.Text.Replace("ῼ", "f");
TextBox1.Text = TextBox1.Text.Replace("‰", "g");
TextBox1.Text = TextBox1.Text.Replace("₰", "h");
TextBox1.Text = TextBox1.Text.Replace("₳", "j");
TextBox1.Text = TextBox1.Text.Replace("₡", "k");
TextBox1.Text = TextBox1.Text.Replace("₲", "l");
TextBox1.Text = TextBox1.Text.Replace("☻", "z");
TextBox1.Text = TextBox1.Text.Replace("╚", "x");
TextBox1.Text = TextBox1.Text.Replace("☼", "c");
TextBox1.Text = TextBox1.Text.Replace("♠", "v");
TextBox1.Text = TextBox1.Text.Replace("Ⱨ", "b");
TextBox1.Text = TextBox1.Text.Replace("סּ", "n");
TextBox1.Text = TextBox1.Text.Replace("◙", "m");


			}
			else
			{
				TextBox1.Text = "";

			}
		}

}
	}

