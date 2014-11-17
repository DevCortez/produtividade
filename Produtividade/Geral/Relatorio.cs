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
				Console.WriteLine("Erro ao enviar e-mail -> " + ex.Message);
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
			relatorio += "Meta diária<br><strong>" + buffer.novos + "/" + analistas.getMeta(analista) +  " (" + (Convert.ToDouble(buffer.novos) / (double)analistas.getMeta(analista) * 100).ToString("0.00") + "%)</strong><br>";

			relatorio += "<br><br><br>";

			relatorio += "<span style=\"font-family: verdana, geneva; font-size: small;\"><strong>Produtividade do mês (" + analistas.getDiasTrabalhados(analista, Convert.ToDateTime(data)) + " dias trabalhados)</strong></span><br><br>";

			buffer = analistas.getDadosMesPessoa(analista, Convert.ToDateTime(data));

			relatorio += "Novos atendimentos<br><strong>" + buffer.novos + "</strong><br>";
			relatorio += "Finalizados de outros<br><strong>" + buffer.outros + "</strong><br>";
			relatorio += "Finalizados<br><strong>" + buffer.finalizados + "</strong><br>";
			relatorio += "Retornos do mês<br><strong>" + (Convert.ToInt32(buffer.novos) - Convert.ToInt32(buffer.finalizados)) + "</strong><br>";
			relatorio += "Meta mensal<br><strong>" + buffer.novos + "/" + analistas.getMeta(analista) * analistas.getDiasTrabalhados(analista, Convert.ToDateTime(data)) + " (" + (Convert.ToDouble(buffer.novos) / (double)(analistas.getMeta(analista) * analistas.getDiasTrabalhados(analista, Convert.ToDateTime(data))) * 100).ToString("0.00") + "%)</strong><br><br><br>";

			relatorio += "<style>table {    width:100%;}table, th, td {    border: 1px solid black;    border-collapse: collapse;}th, td {    padding: 5px;    text-align: left;}table#t01 tr:nth-child(even) {    background-color: #eee;}table#t01 tr:nth-child(odd) {   background-color:#fff;}table#t01 th	{    background-color: black;    color: white;}</style>";
			relatorio += "<table id=\"t01\">";

			relatorio += "<tr><th>Dia</th><th>Novos</th><th>Outros</th><th>Finalizados</th></tr>";

			foreach(DiaTrabalhado x in analistas.getListaDiasTrabalhados(analista, Convert.ToDateTime(data)))
			{
				relatorio += "<tr><td>" + x.dia + "</td>";
				relatorio += "<td>" + x.novos + "</td>";
				relatorio += "<td>" + x.outros + "</td>";
				relatorio += "<td>" + x.finalizados + "</td></tr>";
			}


			relatorio += "</table><br><br>C0rt3z";

			return relatorio;
		}
	}
}
