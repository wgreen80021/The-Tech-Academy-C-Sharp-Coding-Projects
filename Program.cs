using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFinalProj
{
   
    class Program
    {
        class Message
        {
            public int id { get; set; }
            public string strMessage { get; set; }
            public DateTime MsgWhen { get; set; }
        }

        class MsgContext : DbContext
        {
            public MsgContext() : base(@"Data Source=DESKTOP-BE2OVPM\SQLEXPRESS;Initial Catalog=FinalHello;Integrated Security=True") { }
            public DbSet<Message> Messages { get; set; }
        }

        static void Main(string[] args)
        {

            var message = new Message
            {
                strMessage = "Hello World",
                MsgWhen = DateTime.Now

            };

            var msgContext = new MsgContext();
            msgContext.Messages.Add(message);
            msgContext.SaveChanges();
        }
    }
}
