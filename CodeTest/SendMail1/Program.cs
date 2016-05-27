using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.IO;

namespace SendMail1
{
    class Program
    {
        static void Main(string[] args)
        {

            MailMessage myMail = new MailMessage();

            myMail.From = new MailAddress("83145521@qq.com");
          //  myMail.To.Add(new MailAddress("102968345@qq.com"));

            //myMail.Subject = "C#发送Email";
            //myMail.SubjectEncoding = Encoding.UTF8;

            //myMail.Body = "this is a test email from QQ!";
            //myMail.BodyEncoding = Encoding.UTF8;
            //myMail.IsBodyHtml = true;


            //SmtpClient smtp = new SmtpClient();
            //smtp.EnableSsl = true;
            //smtp.UseDefaultCredentials = false;      
            //smtp.Host = "smtp.qq.com";
            //smtp.Credentials = new NetworkCredential("83145521@qq.com", "jiangyuejuan1982");

            //smtp.Send(myMail);

            string fileName = AppDomain.CurrentDomain.BaseDirectory + "\\log\\" + DateTime.Now.ToString("yyyyMMdd");//Server.MapPath("files/JSON.rar");
            StringBuilder strContent = new StringBuilder();

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        strContent.Append(sr.ReadLine()).Append("</br>");
                    }
                }
            }
            



            SmtpClient smtpClient = new SmtpClient();    
            smtpClient.EnableSsl = true;     
            
            smtpClient.UseDefaultCredentials = false;  
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式  
            smtpClient.Host = "smtp.qq.com"; //指定SMTP服务器        

            smtpClient.Credentials = new System.Net.NetworkCredential("83145521@qq.com", "XXXXXXXX");//用户名和授权码
            // 发送邮件设置        
            MailMessage mailMessage = new MailMessage(myMail.From, new MailAddress("jane.jiang@etocrm.com"));//2853229028@qq.com")); // 发送人和收件人  
            mailMessage.To.Add(new MailAddress("jane.jiang@etocrm.com"));
            mailMessage.To.Add(new MailAddress("jiangyuejuan2005@163.com"));
            mailMessage.Subject = DateTime.Now.ToString("yyyy-MM-dd") + "用户同步日志";//主题      

            mailMessage.Body = DateTime.Now.ToString("yyyy-MM-dd")+"用户同步日志详情</br>" + strContent.ToString();
            
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码    
            mailMessage.IsBodyHtml = true;//设置为HTML格式        
            mailMessage.Priority = MailPriority.Low;//优先级
            smtpClient.Send(mailMessage);

            Console.ReadKey();

        }




        private void SendMail()
        {

            MailMessage myMail = new MailMessage();

            myMail.From = new MailAddress("83145521@qq.com");        
            myMail.To.Add(new MailAddress("jane.jiang@etocrm.com"));
            //读取日志
            string fj = AppDomain.CurrentDomain.BaseDirectory + "\\log\\" + DateTime.Now.ToString("yyyyMMdd");//Server.MapPath("files/JSON.rar");
            StringBuilder strContent = new StringBuilder();

            using (StreamReader sr = new StreamReader(fj, Encoding.UTF8, true))
            {
                while (!sr.EndOfStream)
                {
                    strContent.Append(sr.ReadLine()).Append("</br>");
                }
            }

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式  
            smtpClient.Host = "smtp.qq.com"; //指定SMTP服务器        
            smtpClient.Credentials = new System.Net.NetworkCredential("83145521@qq.com", "dncpfkvtikjxcacc");//用户名和授权码
            // 发送邮件设置        
            MailMessage mailMessage = new MailMessage(myMail.From, new MailAddress("jane.jiang@etocrm.com"));     
            mailMessage.Subject = DateTime.Now.ToString("yyyy-MM-dd") + "用户同步日志";//主题      

            mailMessage.Body = DateTime.Now.ToString("yyyy-MM-dd") + "用户同步日志详情</br>" + strContent.ToString();

            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码    
            mailMessage.IsBodyHtml = true;//设置为HTML格式        
            mailMessage.Priority = MailPriority.Low;//优先级
            smtpClient.Send(mailMessage);

            Console.ReadKey();
        }
    }
}
