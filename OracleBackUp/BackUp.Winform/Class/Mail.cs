using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace BackUp.Winform.Class
{
    public static class Mail
    {
        /// <summary>
        /// 发送邮件，不带附件
        /// </summary>
        /// <param name="Port"></param>
        /// <param name="Host"></param>
        /// <param name="SendMail"></param>
        /// <param name="ReceiveMail"></param>
        /// <param name="Password"></param>
        /// <param name="MessageHead"></param>
        /// <param name="MessageBody"></param>
        /// <returns></returns>
        public static bool sendMail(int Port, string Host, string SendMail, string ReceiveMail, string Password, string MessageHead, string MessageBody)
        {
            try
            {
                //实例化一个发送邮件类。
                MailMessage mailMessage = new MailMessage();

                mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
                mailMessage.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码 
                mailMessage.IsBodyHtml = true;//是否是HTML邮件 
                mailMessage.Priority = MailPriority.High;

                //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
                mailMessage.From = new MailAddress(SendMail);
                //收件人邮箱地址。
                mailMessage.To.Add(new MailAddress(ReceiveMail));
                //邮件标题。
                mailMessage.Subject = MessageHead;
                //邮件内容。
                mailMessage.Body = MessageBody;
                //实例化一个SmtpClient类。
                SmtpClient client = new SmtpClient();
                //qq邮箱，所以是smtp.qq.com，填写企业邮箱：smtp.exmail.qq.com
                client.Host = Host;
                //端口587
                client.Port = Port;
                //使用安全加密连接。
                client.EnableSsl = true;
                //不和请求一块发送。
                client.UseDefaultCredentials = false;
                //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
                //client.Credentials = new NetworkCredential("1770085711@qq.com", "rvybgpdxxnnlfdfj");//qq邮箱
                //client.Credentials = new NetworkCredential("shuoyu@blackvon.top", "Hy169267");//企业邮箱
                client.Credentials = new NetworkCredential(SendMail, Password);
                //发送
                client.Send(mailMessage);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        /// <summary>
        /// 发送邮件，带附件
        /// </summary>
        /// <param name="Port"></param>
        /// <param name="Host"></param>
        /// <param name="SendMail"></param>
        /// <param name="ReceiveMail"></param>
        /// <param name="Password"></param>
        /// <param name="MessageHead"></param>
        /// <param name="MessageBody"></param>
        /// <param name="strAttachfileArr">附件地址</param>
        /// <returns></returns>
        public static bool sendMailWithAttachfile(int Port, string Host, string SendMail, string ReceiveMail, string Password, string MessageHead, string MessageBody, string[] strAttachfileArr)
        {
            //实例化一个发送邮件类。
            MailMessage mailMessage = new MailMessage();
            try
            {
                mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
                mailMessage.BodyEncoding = System.Text.Encoding.UTF8; //邮件内容编码 
                mailMessage.IsBodyHtml = true; //是否是HTML邮件 
                mailMessage.Priority = MailPriority.High;

                //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
                mailMessage.From = new MailAddress(SendMail);
                //收件人邮箱地址。
                mailMessage.To.Add(new MailAddress(ReceiveMail));
                //邮件标题。
                mailMessage.Subject = MessageHead;
                //邮件内容。
                mailMessage.Body = MessageBody;
                //附件
                if (strAttachfileArr != null)
                {
                    foreach (string strFile in strAttachfileArr)
                    {
                        Attachment attachment = new Attachment(strFile);
                        mailMessage.Attachments.Add(attachment);
                    }
                }

                //实例化一个SmtpClient类。
                SmtpClient client = new SmtpClient();
                //qq邮箱，所以是smtp.qq.com，填写企业邮箱：smtp.exmail.qq.com
                client.Host = Host;
                //端口587
                client.Port = Port;
                //使用安全加密连接。
                client.EnableSsl = true;
                //不和请求一块发送。
                client.UseDefaultCredentials = false;
                //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
                //client.Credentials = new NetworkCredential("1770085711@qq.com", "rvybgpdxxnnlfdfj");//qq邮箱
                //client.Credentials = new NetworkCredential("shuoyu@blackvon.top", "Hy169267");//企业邮箱
                client.Credentials = new NetworkCredential(SendMail, Password);
                //发送
                client.Send(mailMessage);

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {                
                foreach (Attachment item in mailMessage.Attachments)
                {
                    item.Dispose();   //一定要释放该对象,否则无法删除附件
                }
            }

        }

    }
}
