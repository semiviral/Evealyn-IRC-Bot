﻿using System;
using System.Collections.Generic;
using Eve.Types.Irc;

namespace Eve.Types.Classes {
	public class User {
		public User() {
			Messages = new List<Message>();
		}

		public int Id { get; set; }
		public string Nickname { get; set; }
		public string Realname { get; set; }
		public int Access { get; set; }
		public DateTime Seen { get; set; }
		public List<Message> Messages { get; set; }
		public int Attempts { get; set; }
	}

	public class Message {
		public string Sender { get; set; }
		public string Contents { get; set; }
		public DateTime Date { get; set; }
	}

	public class Channel {
		public string Name { get; set; }
		public string Topic { get; set; }
		public List<string> UserList { get; set; }
		public List<IrcMode> Modes { get; set; }
	}

	public class IrcConfig {
		public List<string> IgnoreList { get; set; } = new List<string>();

		public bool Joined { get; set; }
		public bool Identified { get; set; }

		public string Server { get; set; }
		public string[] Channels { get; set; }
		public string Realname { get; set; }
		public string Nickname { get; set; }
		public string Password { get; set; }
		public string Database { get; set; }

		public int Port { get; set; }
	}
}