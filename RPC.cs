using System;
using DiscordRPC;
namespace BlazeFN
{
	public class RPC
	{
		public static DiscordRpcClient client;
		public static Timestamps rpctimestamp { get; set; }
		private static RichPresence presence;
		public static void InitializeRPC()
		{
			client = new DiscordRpcClient("996414642559664238");
			client.Initialize();
			Button[] buttons = { new Button() { Label = "Discord Server", Url = "https://discord.gg/7f3fjaJ" }, new Button() { Label = "Youtube Channel", Url = "https://www.youtube.com/channel/UCRkabhnVbRJmjXk6PGjYm5Q" } };

			presence = new RichPresence()
			{
				State = "In The Launcher",
				Timestamps = rpctimestamp,
				Buttons = buttons,

				Assets = new Assets()
				{
					LargeImageKey = "large",
					SmallImageKey = "small",
				}
			};
			SetState("In The Launcher");
		}
		public static void SetState(string state, bool watching = false)
		{
			if (watching)
				state = "In The Launcher " + state;

			presence.State = state;
			client.SetPresence(presence);
		}
	}
}
