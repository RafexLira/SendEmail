



//using System.Net.Mail;
//using System.Net;

//var _smpthost = "smtp.gmail.com";
//var _smptUser = "rafael.alexandrelira@gmail.com";
//var _smptPwd = "password";
//var port = 587;

//var destinatario = "floricica771@uorak.com";

//const string site = "http://portalgerencial.record.com.br";

//var novaSenha = string.Concat("PW#", Guid.NewGuid().ToString().Substring(0, 8).ToUpper(), "%");

//var smtpClient = new SmtpClient(_smpthost)
//{
//    Port = port,
//    Credentials = new NetworkCredential(_smptUser, _smptPwd),
//    EnableSsl = true,
//    UseDefaultCredentials = false,
//    Timeout = 30000,
//    DeliveryMethod = SmtpDeliveryMethod.Network
//};

//var mailMessage = new MailMessage
//{
//    From = new MailAddress(_smptUser),
//    Subject = "Recuperação de Senha - Portal Gerencial Record",
//    Body = string.Concat("A sua nova senha é ", novaSenha, ", copie e use no ", site, " e recupere a sua conta."),
//    IsBodyHtml = false
//};

//mailMessage.To.Add(destinatario);

//try 
//{
//    smtpClient.Send(mailMessage);

//    smtpClient.Dispose();

//    Console.WriteLine("Enviado com sucesso!");
//    Console.ReadKey();
//}
//catch
//{
//    Console.WriteLine("Não foi possível enviar o e-mail");
//    Console.ReadKey();
//}

using System.Net.Mail;
using System.Net;

SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
{
    Port = 587,
    Credentials = new NetworkCredential("rafael.alexandrelira@gmail.com", "password"),
    EnableSsl = true,
};

// Construir o e-mail
MailMessage mailMessage = new MailMessage
{
    From = new MailAddress("rafael.alexandrelira@gmail.com"),
    Subject = "testando envio de email",
    Body = "email teste bla-bla-bla",
    IsBodyHtml = false,
};

// Adicionar destinatários
mailMessage.To.Add("floricica771@uorak.com");

// Anexar arquivos (opcional)
// mailMessage.Attachments.Add(new Attachment("caminho/do/seu/arquivo.txt"));

try
{
    // Enviar o e-mail
   smtpClient.Send(mailMessage);
    Console.WriteLine("E-mail enviado com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao enviar o e-mail: {ex.Message}");
}
finally
{
    // Certifique-se de liberar os recursos
    smtpClient.Dispose();
    mailMessage.Dispose();
}
