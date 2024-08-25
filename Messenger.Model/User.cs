using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Model
{
	public class User
	{
		public int Id { get; private set; }
		public string NickName { get; private set; }
		public DateTime CreateDate { get; private set; }
		public string PassWord { get; private set; }

	}
}
