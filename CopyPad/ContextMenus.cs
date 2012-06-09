using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using CopyPad.Properties;
using System.Drawing;

namespace CopyPad
{
	class ContextMenus
	{
		private static List<String> emoticons;
		public static int lastClicked = 0;

		public ContextMenu Create()
		{
			ContextMenu menu = new ContextMenu();
			MenuItem item;

			emoticons = new List<string>();
			emoticons.Add(@"(⌐■_■)");
			emoticons.Add(@"('x_x)G-(._.Q)");
			emoticons.Add(@"ಠ_ಠ");
			emoticons.Add(@"( ¬‿¬)");
			emoticons.Add(@"(◕‿◕✿)");
			emoticons.Add(@"(◑‿◐)");
			emoticons.Add(@"(｡♥‿♥｡)");
			emoticons.Add(@"ლ(́◉◞౪◟◉‵ლ)");
			emoticons.Add(@"(ﾉ◕ヮ◕)ﾉ");
			emoticons.Add(@"(✖╭╮✖)");
			emoticons.Add(@"(。・_・。)");
			emoticons.Add(@"(⊙_◎)");
			emoticons.Add(@"(ノಠ益ಠ)ノ彡┻━┻");
			emoticons.Add(@"┬─┬ノ( º _ ºノ)");
			emoticons.Add(@"☉‿☉");
			emoticons.Add(@"╭∩╮（︶︿︶）╭∩╮");
			emoticons.Add(@"⊙﹏⊙");
			emoticons.Add(@"✲ﾟ｡.(✿╹◡╹)ﾉ☆.｡₀:*ﾟ✲");
			emoticons.Add(@"◕‿◕");

			foreach (String emoticon in emoticons)
			{
				String thisEmoticon = emoticon;

				item = new MenuItem();
				item.Text = thisEmoticon;
				item.Click += delegate
				{
					Clipboard.SetText(thisEmoticon);
				};

				menu.MenuItems.Add(item);
			}

			return menu;
		}
	}
}
