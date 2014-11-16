using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Produtividade.Geral
{
	class Relatorio
	{
		public static bool enviarRelatorio(string destinatario, string assunto, string conteudo)
		{
			string fromEmail = Configurador.getEmail();
			MailMessage mailMessage = new MailMessage(fromEmail, destinatario, assunto, conteudo);
			SmtpClient smtpClient = new SmtpClient(Configurador.getEmailServer(), Configurador.getEmailPort());
			smtpClient.EnableSsl = true;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential(fromEmail, Configurador.getEmailPassword());
			mailMessage.IsBodyHtml = true;

			try
			{
				smtpClient.Send(mailMessage);
			}
			catch (Exception ex)
			{
				return false;
			}
			
			return true;
		}

		public static string gerarRelatorio(string data, string analista, Analistas analistas)
		{
			string relatorio = "<span style=\"font-family: verdana, geneva; font-size: small;\"><strong>Produtividade do dia " + data + "</strong></span><br><br>";

			Pessoa buffer = analistas.getDadosDiaPessoa(analista, Convert.ToDateTime(data));

			relatorio += "Novos atendimentos<br><strong>" + buffer.novos + "</strong><br>";
			relatorio += "Finalizados de outros<br><strong>" + buffer.outros + "</strong><br>";
			relatorio += "Finalizados<br><strong>" + buffer.finalizados + "</strong><br>";
			relatorio += "Retornos do dia<br><strong>" + (Convert.ToInt32(buffer.novos) - Convert.ToInt32(buffer.finalizados)) + "</strong><br>";
			relatorio += "Meta diária<br><strong>" + buffer.novos + "/" + analistas.getMeta(analista) +  " (" + (Convert.ToDouble(buffer.novos) / (double)analistas.getMeta(analista) * 100) + "%)</strong><br>";

			relatorio += "<br><br><br>";

			relatorio += "<span style=\"font-family: verdana, geneva; font-size: small;\"><strong>Produtividade do mês</strong></span><br><br>";

			buffer = analistas.getDadosMesPessoa(analista, Convert.ToDateTime(data));

			relatorio += "Novos atendimentos<br><strong>" + buffer.novos + "</strong><br>";
			relatorio += "Finalizados de outros<br><strong>" + buffer.outros + "</strong><br>";
			relatorio += "Finalizados<br><strong>" + buffer.finalizados + "</strong><br>";
			relatorio += "Retornos do mês<br><strong>" + (Convert.ToInt32(buffer.novos) - Convert.ToInt32(buffer.finalizados)) + "</strong><br>";
			relatorio += "Meta diária<br><strong>" + buffer.novos + "/" + analistas.getMeta(analista) + " (" + (Convert.ToDouble(buffer.novos) / (double)analistas.getMeta(analista) * 100) + "%)</strong><br>";

			//</span>
			return relatorio;
		}
	}
}
